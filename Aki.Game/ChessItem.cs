using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020011CD RID: 4557
[NullableContext(1)]
[Nullable(0)]
public class ChessItem
{
	// Token: 0x06007964 RID: 31076 RVA: 0x00199B78 File Offset: 0x00197D78
	public void Init(int id, IChessAgent agent, bool rotationIsForward)
	{
		this.Id = id;
		this.Agent = agent;
		this.RotationIsForwardInternal = rotationIsForward;
	}

	// Token: 0x06007965 RID: 31077 RVA: 0x00199B8F File Offset: 0x00197D8F
	public virtual void OnClear()
	{
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x00199B91 File Offset: 0x00197D91
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x00199B9C File Offset: 0x00197D9C
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

	// Token: 0x06007968 RID: 31080 RVA: 0x00199C10 File Offset: 0x00197E10
	[NullableContext(2)]
	public ChessboardPoint GetCurrentPoint()
	{
		return this.CurrentPoint;
	}

	// Token: 0x06007969 RID: 31081 RVA: 0x00199C18 File Offset: 0x00197E18
	public int GetReachTerminalTimes()
	{
		return this.ReachTerminalTimes;
	}

	// Token: 0x0600796A RID: 31082 RVA: 0x00199C20 File Offset: 0x00197E20
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

	// Token: 0x0600796B RID: 31083 RVA: 0x00199C33 File Offset: 0x00197E33
	public bool RotationIsForward()
	{
		return this.RotationIsForwardInternal;
	}

	// Token: 0x0600796C RID: 31084 RVA: 0x00199C3C File Offset: 0x00197E3C
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

	// Token: 0x0600796D RID: 31085 RVA: 0x00199C97 File Offset: 0x00197E97
	public virtual void Teleport(Vector location, Rotator rotator)
	{
		if (this.CurrentState != EChessStateType.Idle || this.Agent == null)
		{
			return;
		}
		this.Agent.Teleport(location, rotator);
	}

	// Token: 0x0600796E RID: 31086 RVA: 0x00199CB8 File Offset: 0x00197EB8
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

	// Token: 0x040037DA RID: 14298
	private int Id;

	// Token: 0x040037DB RID: 14299
	protected EChessStateType CurrentState;

	// Token: 0x040037DC RID: 14300
	[Nullable(2)]
	protected ChessboardPoint CurrentPoint;

	// Token: 0x040037DD RID: 14301
	[Nullable(2)]
	protected IChessAgent Agent;

	// Token: 0x040037DE RID: 14302
	private int ReachTerminalTimes;

	// Token: 0x040037DF RID: 14303
	private bool RotationIsForwardInternal = true;
}
