using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020011DC RID: 4572
[NullableContext(2)]
[Nullable(0)]
public class StackableChessItem : ChessItem
{
	// Token: 0x17000A68 RID: 2664
	// (get) Token: 0x060079D1 RID: 31185 RVA: 0x0019A478 File Offset: 0x00198678
	protected new IStackableChessAgent Agent
	{
		get
		{
			return this.Agent as IStackableChessAgent;
		}
	}

	// Token: 0x060079D2 RID: 31186 RVA: 0x0019A485 File Offset: 0x00198685
	public override void OnClear()
	{
		this.SetNextItem(null);
	}

	// Token: 0x060079D3 RID: 31187 RVA: 0x0019A490 File Offset: 0x00198690
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

	// Token: 0x060079D4 RID: 31188 RVA: 0x0019A4F9 File Offset: 0x001986F9
	public StackableChessItem GetNextItem()
	{
		return this.NextItem;
	}

	// Token: 0x060079D5 RID: 31189 RVA: 0x0019A501 File Offset: 0x00198701
	public Vector GetStackableLocation()
	{
		IStackableChessAgent agent = this.Agent;
		if (agent == null)
		{
			return null;
		}
		return agent.GetStackableLocation();
	}

	// Token: 0x060079D6 RID: 31190 RVA: 0x0019A514 File Offset: 0x00198714
	public Rotator GetStackableRotator(bool otherIsForward)
	{
		IStackableChessAgent agent = this.Agent;
		if (agent == null)
		{
			return null;
		}
		return agent.GetStackableRotator(base.RotationIsForward() == otherIsForward);
	}

	// Token: 0x060079D7 RID: 31191 RVA: 0x0019A530 File Offset: 0x00198730
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

	// Token: 0x060079D8 RID: 31192 RVA: 0x0019A58C File Offset: 0x0019878C
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

	// Token: 0x060079D9 RID: 31193 RVA: 0x0019A5D8 File Offset: 0x001987D8
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

	// Token: 0x060079DA RID: 31194 RVA: 0x0019A640 File Offset: 0x00198840
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

	// Token: 0x060079DB RID: 31195 RVA: 0x0019A698 File Offset: 0x00198898
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

	// Token: 0x040037FC RID: 14332
	private StackableChessItem NextItem;
}
