using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000088 RID: 136
[NullableContext(1)]
[Nullable(0)]
public class TickEntityManager
{
	// Token: 0x06000444 RID: 1092 RVA: 0x00018808 File Offset: 0x00016A08
	public void Add(Entity entity, int priority)
	{
		this.EntityPriority[entity.Id] = priority;
		if (this.Ticking)
		{
			this.CreateEntities.Add(entity);
			return;
		}
		this.AddInternal(entity, priority);
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0001883C File Offset: 0x00016A3C
	private void AddInternal(Entity entity, int priority)
	{
		TickEntityGroup tickEntityGroup;
		if (!this.TickEntityMap.TryGetValue(priority, out tickEntityGroup))
		{
			tickEntityGroup = new TickEntityGroup(priority);
			this.TickEntityMap[priority] = tickEntityGroup;
			this.TickEntityQueue.Insert(this.SearchQueue(priority), tickEntityGroup);
		}
		tickEntityGroup.Entities[entity.Id] = entity;
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00018894 File Offset: 0x00016A94
	private int SearchQueue(int priority)
	{
		int count = this.TickEntityQueue.Count;
		if (count < 4)
		{
			for (int i = 0; i < count; i++)
			{
				if (this.TickEntityQueue[i].Priority < priority)
				{
					return i;
				}
			}
			return count;
		}
		if (this.TickEntityQueue[0].Priority < priority)
		{
			return 0;
		}
		int num = 0;
		int num2 = count;
		while (num2 - num > 1)
		{
			int num3 = num + num2 >> 1;
			if (this.TickEntityQueue[num3].Priority > priority)
			{
				num = num3;
			}
			else
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0001891C File Offset: 0x00016B1C
	public void Delete(int entityId)
	{
		int priority;
		if (!this.EntityPriority.TryGetValue(entityId, out priority))
		{
			return;
		}
		if (this.Ticking)
		{
			this.DestroyEntities.Add(entityId);
			return;
		}
		this.DeleteInternal(entityId, priority);
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00018957 File Offset: 0x00016B57
	private void DeleteInternal(int entityId, int priority)
	{
		this.EntityPriority.Remove(entityId);
		this.TickEntityMap[priority].Entities.Remove(entityId);
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00018980 File Offset: 0x00016B80
	public void ForceTick(float delta)
	{
		this.Ticking = true;
		foreach (TickEntityGroup tickEntityGroup in this.TickEntityQueue)
		{
			foreach (Entity entity in tickEntityGroup.Entities.Values)
			{
				if (entity.Valid && entity.IsInit)
				{
					entity.ForceTick(delta);
				}
			}
		}
		this.Ticking = false;
		this.CreateAndDestroyInternal();
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00018A38 File Offset: 0x00016C38
	public void Tick(float delta)
	{
		if (GameBudgetInterfaceController.IsOpen)
		{
			return;
		}
		this.Ticking = true;
		foreach (TickEntityGroup tickEntityGroup in this.TickEntityQueue)
		{
			foreach (Entity entity in tickEntityGroup.Entities.Values)
			{
				if (entity.Valid && entity.IsInit)
				{
					entity.Tick(delta);
				}
			}
		}
		this.Ticking = false;
		this.CreateAndDestroyInternal();
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00018AF8 File Offset: 0x00016CF8
	public void ForceAfterTick(float delta)
	{
		this.Ticking = true;
		foreach (TickEntityGroup tickEntityGroup in this.TickEntityQueue)
		{
			foreach (Entity entity in tickEntityGroup.Entities.Values)
			{
				if (entity.Valid && entity.IsInit)
				{
					entity.ForceAfterTick(delta);
				}
			}
		}
		this.Ticking = false;
		this.CreateAndDestroyInternal();
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00018BB0 File Offset: 0x00016DB0
	public void AfterTick(float delta)
	{
		if (GameBudgetInterfaceController.IsOpen)
		{
			return;
		}
		this.Ticking = true;
		foreach (TickEntityGroup tickEntityGroup in this.TickEntityQueue)
		{
			foreach (Entity entity in tickEntityGroup.Entities.Values)
			{
				if (entity.Valid && entity.IsInit)
				{
					entity.AfterTick(delta);
				}
			}
		}
		this.Ticking = false;
		this.CreateAndDestroyInternal();
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00018C70 File Offset: 0x00016E70
	private void CreateAndDestroyInternal()
	{
		foreach (Entity entity in this.CreateEntities)
		{
			int priority;
			if (entity.Valid && this.EntityPriority.TryGetValue(entity.Id, out priority))
			{
				this.AddInternal(entity, priority);
			}
		}
		this.CreateEntities.Clear();
		foreach (int num in this.DestroyEntities)
		{
			int priority2;
			if (this.EntityPriority.TryGetValue(num, out priority2))
			{
				this.DeleteInternal(num, priority2);
			}
		}
		this.DestroyEntities.Clear();
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00018D50 File Offset: 0x00016F50
	public void Clear()
	{
		this.TickEntityMap.Clear();
		this.TickEntityQueue.Clear();
	}

	// Token: 0x040003E3 RID: 995
	private readonly Dictionary<int, TickEntityGroup> TickEntityMap = new Dictionary<int, TickEntityGroup>();

	// Token: 0x040003E4 RID: 996
	private readonly List<TickEntityGroup> TickEntityQueue = new List<TickEntityGroup>();

	// Token: 0x040003E5 RID: 997
	private readonly Dictionary<int, int> EntityPriority = new Dictionary<int, int>();

	// Token: 0x040003E6 RID: 998
	private bool Ticking;

	// Token: 0x040003E7 RID: 999
	private readonly List<Entity> CreateEntities = new List<Entity>();

	// Token: 0x040003E8 RID: 1000
	private readonly List<int> DestroyEntities = new List<int>();

	// Token: 0x040003E9 RID: 1001
	[StaticVariableRuleIgnore]
	private static readonly Stat ForceTickStat = Stat.Create("TickEntityManager.ForceTick", "", "");

	// Token: 0x040003EA RID: 1002
	[StaticVariableRuleIgnore]
	private static readonly Stat TickStat = Stat.Create("TickEntityManager.Tick", "", "");

	// Token: 0x040003EB RID: 1003
	[StaticVariableRuleIgnore]
	private static readonly Stat ForceAfterTickStat = Stat.Create("TickEntityManager.ForceAfterTick", "", "");

	// Token: 0x040003EC RID: 1004
	[StaticVariableRuleIgnore]
	private static readonly Stat AfterTickStat = Stat.Create("TickEntityManager.AfterTick", "", "");

	// Token: 0x040003ED RID: 1005
	private const int BINARY_SEARCH_THREADHOLD = 4;
}
