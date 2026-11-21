using System;
using System.Runtime.CompilerServices;

// Token: 0x02002682 RID: 9858
[NullableContext(1)]
[Nullable(0)]
public class PerformModeBase
{
	// Token: 0x06018AEF RID: 101103 RVA: 0x0077C9E2 File Offset: 0x0077ABE2
	public PerformModeBase(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine)
	{
		this.Mode = mode;
		this.PerformComp = performComp;
		this.Machine = machine;
	}

	// Token: 0x06018AF0 RID: 101104 RVA: 0x0077CA0B File Offset: 0x0077AC0B
	public void PushAction(IPerformActionBase actionInfo, bool bRestore)
	{
		if (bRestore)
		{
			this.CachePerformAction.AddFront(actionInfo);
			return;
		}
		this.CachePerformAction.AddRear(actionInfo);
	}

	// Token: 0x06018AF1 RID: 101105 RVA: 0x0077CA29 File Offset: 0x0077AC29
	[NullableContext(2)]
	public IPerformActionBase PopAction()
	{
		if (this.CachePerformAction.Size == 0)
		{
			return null;
		}
		return this.CachePerformAction.RemoveFront();
	}

	// Token: 0x06018AF2 RID: 101106 RVA: 0x0077CA45 File Offset: 0x0077AC45
	public virtual bool CheckEnter()
	{
		return false;
	}

	// Token: 0x06018AF3 RID: 101107 RVA: 0x0077CA48 File Offset: 0x0077AC48
	public virtual bool CheckExit()
	{
		return false;
	}

	// Token: 0x06018AF4 RID: 101108 RVA: 0x0077CA4B File Offset: 0x0077AC4B
	public void Clear()
	{
		this.CachePerformAction.Clear();
	}

	// Token: 0x0400D666 RID: 54886
	public readonly EPerformMode Mode;

	// Token: 0x0400D667 RID: 54887
	protected readonly BasePerformComponent PerformComp;

	// Token: 0x0400D668 RID: 54888
	protected readonly PerformMachine Machine;

	// Token: 0x0400D669 RID: 54889
	protected readonly Deque<IPerformActionBase> CachePerformAction = new Deque<IPerformActionBase>(4);
}
