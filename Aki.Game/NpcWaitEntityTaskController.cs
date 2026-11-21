using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002788 RID: 10120
[NullableContext(1)]
[Nullable(0)]
public class NpcWaitEntityTaskController
{
	// Token: 0x06019605 RID: 103941 RVA: 0x007C2489 File Offset: 0x007C0689
	public NpcWaitEntityTaskController(Entity entity)
	{
		this.OwnerEntity = entity;
	}

	// Token: 0x06019606 RID: 103942 RVA: 0x007C24AE File Offset: 0x007C06AE
	private void Init()
	{
		this.TasksMap[ETaskType.IgnoreCollision] = ((Entity npcEntity, int pbDataId) => new NpcIgnoreCollisionTask(npcEntity, pbDataId));
	}

	// Token: 0x06019607 RID: 103943 RVA: 0x007C24DC File Offset: 0x007C06DC
	public void Dispose()
	{
		foreach (NpcWaitEntityTask npcWaitEntityTask in this.WaitEntityTaskList)
		{
			npcWaitEntityTask.Stop();
		}
		this.WaitEntityTaskList.Clear();
	}

	// Token: 0x06019608 RID: 103944 RVA: 0x007C2538 File Offset: 0x007C0738
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

	// Token: 0x06019609 RID: 103945 RVA: 0x007C25C8 File Offset: 0x007C07C8
	public void RunTask()
	{
		foreach (NpcWaitEntityTask npcWaitEntityTask in this.WaitEntityTaskList)
		{
			npcWaitEntityTask.Start();
		}
	}

	// Token: 0x0400DE36 RID: 56886
	public const int WAIT_IGNORE_ACTOR_TIMEOUT = 30000;

	// Token: 0x0400DE37 RID: 56887
	[Nullable(2)]
	private readonly Entity OwnerEntity;

	// Token: 0x0400DE38 RID: 56888
	private readonly List<NpcWaitEntityTask> WaitEntityTaskList = new List<NpcWaitEntityTask>();

	// Token: 0x0400DE39 RID: 56889
	private readonly Dictionary<ETaskType, Func<Entity, int, NpcWaitEntityTask>> TasksMap = new Dictionary<ETaskType, Func<Entity, int, NpcWaitEntityTask>>();

	// Token: 0x0400DE3A RID: 56890
	private bool IsInit;
}
