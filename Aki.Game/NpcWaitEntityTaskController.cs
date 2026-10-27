using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003219 RID: 12825
[NullableContext(1)]
[Nullable(0)]
public class NpcWaitEntityTaskController
{
	// Token: 0x0601BA80 RID: 113280 RVA: 0x00799CED File Offset: 0x00797EED
	public NpcWaitEntityTaskController(Entity entity)
	{
		this.OwnerEntity = entity;
	}

	// Token: 0x0601BA81 RID: 113281 RVA: 0x00799D12 File Offset: 0x00797F12
	private void Init()
	{
		this.TasksMap[ETaskType.IgnoreCollision] = ((Entity npcEntity, int pbDataId) => new NpcIgnoreCollisionTask(npcEntity, pbDataId));
	}

	// Token: 0x0601BA82 RID: 113282 RVA: 0x00799D40 File Offset: 0x00797F40
	public void Dispose()
	{
		foreach (NpcWaitEntityTask npcWaitEntityTask in this.WaitEntityTaskList)
		{
			npcWaitEntityTask.Stop();
		}
		this.WaitEntityTaskList.Clear();
	}

	// Token: 0x0601BA83 RID: 113283 RVA: 0x00799D9C File Offset: 0x00797F9C
	[NullableContext(2)]
	public void AddTask(List<int> pbDataIdArray, ETaskType type)
	{
		if (pbDataIdArray != null && pbDataIdArray.Count == 0)
		{
			return;
		}
		if (!this.IsInit)
		{
			this.IsInit = true;
			this.Init();
		}
		Func<Entity, int, NpcWaitEntityTask> func = this.TasksMap[type];
		foreach (int arg in pbDataIdArray)
		{
			NpcWaitEntityTask item = func(this.OwnerEntity, arg);
			this.WaitEntityTaskList.Add(item);
		}
	}

	// Token: 0x0601BA84 RID: 113284 RVA: 0x00799E2C File Offset: 0x0079802C
	public void RunTask()
	{
		foreach (NpcWaitEntityTask npcWaitEntityTask in this.WaitEntityTaskList)
		{
			npcWaitEntityTask.Start();
		}
	}

	// Token: 0x0400D997 RID: 55703
	public const int WAIT_IGNORE_ACTOR_TIMEOUT = 30000;

	// Token: 0x0400D998 RID: 55704
	[Nullable(2)]
	private readonly Entity OwnerEntity;

	// Token: 0x0400D999 RID: 55705
	private readonly List<NpcWaitEntityTask> WaitEntityTaskList = new List<NpcWaitEntityTask>();

	// Token: 0x0400D99A RID: 55706
	private readonly Dictionary<ETaskType, Func<Entity, int, NpcWaitEntityTask>> TasksMap = new Dictionary<ETaskType, Func<Entity, int, NpcWaitEntityTask>>();

	// Token: 0x0400D99B RID: 55707
	private bool IsInit;
}
