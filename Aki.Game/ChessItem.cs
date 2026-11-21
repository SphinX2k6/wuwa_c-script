using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000681 RID: 1665
[NullableContext(1)]
[Nullable(0)]
public class ChessItem
{
	// Token: 0x06004CFB RID: 19707 RVA: 0x001A2828 File Offset: 0x001A0A28
	public void Init(int id, IChessAgent agent, bool rotationIsForward)
	{
		this.Id = id;
		this.Agent = agent;
		this.RotationIsForwardInternal = rotationIsForward;
	}

	// Token: 0x06004CFC RID: 19708 RVA: 0x001A283F File Offset: 0x001A0A3F
	public virtual void OnClear()
	{
	}

	// Token: 0x06004CFD RID: 19709 RVA: 0x001A2841 File Offset: 0x001A0A41
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06004CFE RID: 19710 RVA: 0x001A284C File Offset: 0x001A0A4C
	public void SetCurrentPoint(ChessboardPoint point)
	{
		ChessboardPoint currentPoint = this.CurrentPoint;
		this.CurrentPoint = point;
		if (currentPoint == null)
		{
			return;
		}
		ChessboardPoint terminalPoint = ChessModel.Instance.GetTerminalPoint();
		if (terminalPoint == null)
		{
			return;
		}
		if (terminalPoint.GetId() == point.GetId())
		{
			this.ReachTerminalTimes++;
			return;
		}
		int sortIndex = terminalPoint.GetSortIndex();
		int sortIndex2 = point.GetSortIndex();
		if (currentPoint.GetSortIndex() < sortIndex && sortIndex2 > sortIndex)
		{
			this.ReachTerminalTimes++;
		}
	}

	// Token: 0x06004CFF RID: 19711 RVA: 0x001A28C0 File Offset: 0x001A0AC0
	[NullableContext(2)]
	public ChessboardPoint GetCurrentPoint()
	{
		return this.CurrentPoint;
	}

	// Token: 0x06004D00 RID: 19712 RVA: 0x001A28C8 File Offset: 0x001A0AC8
	public int GetReachTerminalTimes()
	{
		return this.ReachTerminalTimes;
	}

	// Token: 0x06004D01 RID: 19713 RVA: 0x001A28D0 File Offset: 0x001A0AD0
	[NullableContext(2)]
	public Vector GetLocation()
	{
		IChessAgent agent = this.Agent;
		if (agent == null)
		{
			return null;
		}
		return agent.GetLocation();
	}

	// Token: 0x06004D02 RID: 19714 RVA: 0x001A28E3 File Offset: 0x001A0AE3
	public bool RotationIsForward()
	{
		return this.RotationIsForwardInternal;
	}

	// Token: 0x06004D03 RID: 19715 RVA: 0x001A28EC File Offset: 0x001A0AEC
	public virtual UniTask MoveAsync(Vector location, Rotator rotator, bool performIsForward)
	{
		ChessItem.<MoveAsync>d__14 <MoveAsync>d__;
		<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveAsync>d__.<>4__this = this;
		<MoveAsync>d__.location = location;
		<MoveAsync>d__.rotator = rotator;
		<MoveAsync>d__.performIsForward = performIsForward;
		<MoveAsync>d__.<>1__state = -1;
		<MoveAsync>d__.<>t__builder.Start<ChessItem.<MoveAsync>d__14>(ref <MoveAsync>d__);
		return <MoveAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004D04 RID: 19716 RVA: 0x001A2947 File Offset: 0x001A0B47
	public virtual void Teleport(Vector location, Rotator rotator)
	{
		if (this.CurrentState != EChessStateType.Idle || this.Agent == null)
		{
			return;
		}
		this.Agent.Teleport(location, rotator);
	}

	// Token: 0x06004D05 RID: 19717 RVA: 0x001A2968 File Offset: 0x001A0B68
	public virtual UniTask PerformAsync(int type)
	{
		ChessItem.<PerformAsync>d__16 <PerformAsync>d__;
		<PerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PerformAsync>d__.<>4__this = this;
		<PerformAsync>d__.type = type;
		<PerformAsync>d__.<>1__state = -1;
		<PerformAsync>d__.<>t__builder.Start<ChessItem.<PerformAsync>d__16>(ref <PerformAsync>d__);
		return <PerformAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04003873 RID: 14451
	private int Id;

	// Token: 0x04003874 RID: 14452
	protected EChessStateType CurrentState;

	// Token: 0x04003875 RID: 14453
	[Nullable(2)]
	protected ChessboardPoint CurrentPoint;

	// Token: 0x04003876 RID: 14454
	[Nullable(2)]
	protected IChessAgent Agent;

	// Token: 0x04003877 RID: 14455
	private int ReachTerminalTimes;

	// Token: 0x04003878 RID: 14456
	private bool RotationIsForwardInternal = true;
}
