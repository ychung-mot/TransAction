﻿using System.Collections.Generic;
using TransAction.Data.Models;

namespace TransAction.Data.Repositories.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable<TraEvent> GetAll(int page, int pageSize, string name);
        int Count(string name);
        TraEvent GetById(int id);
        void Create(TraEvent newEvent);
        void Update(TraEvent updateEvent);
    }
}
