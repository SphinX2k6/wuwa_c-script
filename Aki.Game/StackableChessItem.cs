using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000690 RID: 1680
[NullableContext(2)]
[Nullable(0)]
public class StackableChessItem : ChessItem
{
	// Token: 0x17000A88 RID: 2696
	// (get) Token: 0x06004D68 RID: 19816 RVA: 0x001A3128 File Offset: 0x001A1328
	protected new IStackableChessAgent Agent
	{
		get
		{
			return this.Agent as IStackableChessAgent;
		}
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x001A3135 File Offset: 0x001A1335
	public override void OnClear()
	{
		this.SetNextItem(null);
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x001A3140 File Offset: 0x001A1340
	public void SetNextItem(StackableChessItem otherItem)
	{
		if (this.NextItem != otherItem && this.Agent != null)
		{
			StackableChessItem nextItem = this.NextItem;
			if (nextItem != null)
			{
				IStackableChessAgent agent = nextItem.Agent;
				if (agent != null)
				{
					agent.DetachFromTarget(this.Agent);
				}
			}
		}
		if (this.Agent != null && otherItem != null)
		{
			IStackableChessAgent agent2 = otherItem.Agent;
			if (agent2 != null)
			{
				agent2.AttachToTarget(this.Agent);
			}
		}
		this.NextItem = otherItem;
	}

	// Token: 0x06004D6B RID: 19819 RVA: 0x001A31A9 File Offset: 0x001A13A9
	public StackableChessItem GetNextItem()
	{
		return this.NextItem;
	}

	// Token: 0x06004D6C RID: 19820 RVA: 0x001A31B1 File Offset: 0x001A13B1
	public Vector GetStackableLocation()
	{
		IStackableChessAgent agent = this.Agent;
		if (agent == null)
		{
			return null;
		}
		return agent.GetStackableLocation();
	}

	// Token: 0x06004D6D RID: 19821 RVA: 0x001A31C4 File Offset: 0x001A13C4
	public Rotator GetStackableRotator(bool otherIsForward)
	{
		IStackableChessAgent agent = this.Agent;
		if (agent == null)
		{
			return null;
		}
		return agent.GetStackableRotator(base.RotationIsForward() == otherIsForward);
	}

	// Token: 0x06004D6E RID: 19822 RVA: 0x001A31E0 File Offset: 0x001A13E0
	[NullableContext(1)]
	public override UniTask MoveAsync(Vector location, Rotator rotator, bool isForward)
	{
		StackableChessItem.<MoveAsync>d__8 <MoveAsync>d__;
		<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveAsync>d__.<>4__this = this;
		<MoveAsync>d__.location = location;
		<MoveAsync>d__.rotator = rotator;
		<MoveAsync>d__.isForward = isForward;
		<MoveAsync>d__.<>1__state = -1;
		<MoveAsync>d__.<>t__builder.Start<StackableChessItem.<MoveAsync>d__8>(ref <MoveAsync>d__);
		return <MoveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004D6F RID: 19823 RVA: 0x001A323C File Offset: 0x001A143C
	public override UniTask PerformAsync(int type)
	{
		StackableChessItem.<PerformAsync>d__9 <PerformAsync>d__;
		<PerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PerformAsync>d__.<>4__this = this;
		<PerformAsync>d__.type = type;
		<PerformAsync>d__.<>1__state = -1;
		<PerformAsync>d__.<>t__builder.Start<StackableChessItem.<PerformAsync>d__9>(ref <PerformAsync>d__);
		return <PerformAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x001A3288 File Offset: 0x001A1488
	[NullableContext(1)]
	private void NotifyNextItemsMoveStateChange(IStackableChessAgent agent, bool isMoving, bool isForward)
	{
		HashSet<int> hashSet = new HashSet<int>();
		bool flag = base.RotationIsForward();
		StackableChessItem nextItem = this.NextItem;
		while (nextItem != null && !hashSet.Contains(nextItem.GetId()))
		{
			hashSet.Add(nextItem.GetId());
			IStackableChessAgent agent2 = nextItem.Agent;
			if (agent2 != null)
			{
				agent2.OnPreviousMoveStateChange(agent, isMoving, isForward, flag == nextItem.RotationIsForward());
			}
			nextItem = nextItem.GetNextItem();
		}
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x001A32F0 File Offset: 0x001A14F0
	[NullableContext(1)]
	private void NotifyNextItemsPerformStateChange(IStackableChessAgent agent, int type, bool isPerforming)
	{
		HashSet<int> hashSet = new HashSet<int>();
		StackableChessItem nextItem = this.NextItem;
		while (nextItem != null && !hashSet.Contains(nextItem.GetId()))
		{
			hashSet.Add(nextItem.GetId());
			if (nextItem != null)
			{
				IStackableChessAgent agent2 = nextItem.Agent;
				if (agent2 != null)
				{
					agent2.OnPreviousPerformStateChange(agent, type, isPerforming);
				}
			}
			nextItem = nextItem.GetNextItem();
		}
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x001A3348 File Offset: 0x001A1548
	public void DetachSelfFromChain()
	{
		StackableChessItem nextItem = this.NextItem;
		StackableChessboardPoint stackableChessboardPoint = base.GetCurrentPoint() as StackableChessboardPoint;
		this.SetNextItem(null);
		if (stackableChessboardPoint == null || nextItem == null)
		{
			return;
		}
		StackableChessItem stackableChessItem = stackableChessboardPoint.FindPreviousItem(this);
		if (stackableChessItem != null)
		{
			stackableChessItem.SetNextItem(nextItem);
			Vector stackableLocation = stackableChessItem.GetStackableLocation();
			if (stackableLocation != null)
			{
				nextItem.Teleport(stackableLocation, stackableChessboardPoint.GetPointRotator(true));
				return;
			}
		}
		else
		{
			Vector pointLocation = stackableChessboardPoint.GetPointLocation();
			nextItem.Teleport(pointLocation, stackableChessboardPoint.GetPointRotator(true));
		}
	}

	// Token: 0x04003895 RID: 14485
	private StackableChessItem NextItem;
}
