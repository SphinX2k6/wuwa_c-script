using System;
using System.Runtime.CompilerServices;

// Token: 0x02003127 RID: 12583
[NullableContext(1)]
[Nullable(0)]
public class PerformModeBase
{
	// Token: 0x0601B094 RID: 110740 RVA: 0x00756976 File Offset: 0x00754B76
	public PerformModeBase(EPerformMode mode, BasePerformComponent performComp, PerformMachine machine)
	{
		this.Mode = mode;
		this.PerformComp = performComp;
		this.Machine = machine;
	}

	// Token: 0x0601B095 RID: 110741 RVA: 0x0075699F File Offset: 0x00754B9F
	public void PushAction(IPerformActionBase actionInfo, bool bRestore)
	{
		if (bRestore)
		{
			this.CachePerformAction.AddFront(actionInfo);
			return;
		}
		this.CachePerformAction.AddRear(actionInfo);
	}

	// Token: 0x0601B096 RID: 110742 RVA: 0x007569BD File Offset: 0x00754BBD
	[NullableContext(2)]
	public IPerformActionBase PopAction()
	{
		if (this.CachePerformAction.Size == 0)
		{
			return null;
		}
		return this.CachePerformAction.RemoveFront();
	}

	// Token: 0x0601B097 RID: 110743 RVA: 0x007569D9 File Offset: 0x00754BD9
	public virtual bool CheckEnter()
	{
		return false;
	}

	// Token: 0x0601B098 RID: 110744 RVA: 0x007569DC File Offset: 0x00754BDC
	public virtual bool CheckExit()
	{
		return false;
	}

	// Token: 0x0601B099 RID: 110745 RVA: 0x007569DF File Offset: 0x00754BDF
	public void Clear()
	{
		this.CachePerformAction.Clear();
	}

	// Token: 0x0400D244 RID: 53828
	public readonly EPerformMode Mode;

	// Token: 0x0400D245 RID: 53829
	protected readonly BasePerformComponent PerformComp;

	// Token: 0x0400D246 RID: 53830
	protected readonly PerformMachine Machine;

	// Token: 0x0400D247 RID: 53831
	protected readonly Deque<IPerformActionBase> CachePerformAction = new Deque<IPerformActionBase>(4);
}
