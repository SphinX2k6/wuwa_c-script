using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000086 RID: 134
[NullableContext(1)]
[Nullable(0)]
public class TickEntityManager
{
	// Token: 0x06000404 RID: 1028 RVA: 0x00017F20 File Offset: 0x00016120
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

	// Token: 0x06000405 RID: 1029 RVA: 0x00017F54 File Offset: 0x00016154
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

	// Token: 0x06000406 RID: 1030 RVA: 0x00017FAC File Offset: 0x000161AC
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

	// Token: 0x06000407 RID: 1031 RVA: 0x00018034 File Offset: 0x00016234
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

	// Token: 0x06000408 RID: 1032 RVA: 0x0001806F File Offset: 0x0001626F
	private void DeleteInternal(int entityId, int priority)
	{
		this.EntityPriority.Remove(entityId);
		this.TickEntityMap[priority].Entities.Remove(entityId);
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00018098 File Offset: 0x00016298
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

	// Token: 0x0600040A RID: 1034 RVA: 0x00018150 File Offset: 0x00016350
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

	// Token: 0x0600040B RID: 1035 RVA: 0x00018210 File Offset: 0x00016410
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

	// Token: 0x0600040C RID: 1036 RVA: 0x000182C8 File Offset: 0x000164C8
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

	// Token: 0x0600040D RID: 1037 RVA: 0x00018388 File Offset: 0x00016588
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

	// Token: 0x0600040E RID: 1038 RVA: 0x00018468 File Offset: 0x00016668
	public void Clear()
	{
		this.TickEntityMap.Clear();
		this.TickEntityQueue.Clear();
	}

	// Token: 0x040003D5 RID: 981
	private readonly Dictionary<int, TickEntityGroup> TickEntityMap = new Dictionary<int, TickEntityGroup>();

	// Token: 0x040003D6 RID: 982
	private readonly List<TickEntityGroup> TickEntityQueue = new List<TickEntityGroup>();

	// Token: 0x040003D7 RID: 983
	private readonly Dictionary<int, int> EntityPriority = new Dictionary<int, int>();

	// Token: 0x040003D8 RID: 984
	private bool Ticking;

	// Token: 0x040003D9 RID: 985
	private readonly List<Entity> CreateEntities = new List<Entity>();

	// Token: 0x040003DA RID: 986
	private readonly List<int> DestroyEntities = new List<int>();

	// Token: 0x040003DB RID: 987
	[StaticVariableRuleIgnore]
	private static readonly Stat ForceTickStat = Stat.Create("TickEntityManager.ForceTick", "", "");

	// Token: 0x040003DC RID: 988
	[StaticVariableRuleIgnore]
	private static readonly Stat TickStat = Stat.Create("TickEntityManager.Tick", "", "");

	// Token: 0x040003DD RID: 989
	[StaticVariableRuleIgnore]
	private static readonly Stat ForceAfterTickStat = Stat.Create("TickEntityManager.ForceAfterTick", "", "");

	// Token: 0x040003DE RID: 990
	[StaticVariableRuleIgnore]
	private static readonly Stat AfterTickStat = Stat.Create("TickEntityManager.AfterTick", "", "");

	// Token: 0x040003DF RID: 991
	private const int BINARY_SEARCH_THREADHOLD = 4;
}
