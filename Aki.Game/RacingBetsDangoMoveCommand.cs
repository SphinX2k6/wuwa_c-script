using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BBB RID: 7099
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoMoveCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA1 RID: 6817
	// (get) Token: 0x06011AF0 RID: 72432 RVA: 0x0053637A File Offset: 0x0053457A
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoMove;
		}
	}

	// Token: 0x06011AF1 RID: 72433 RVA: 0x0053637D File Offset: 0x0053457D
	public void Init(RacingBetsDangoActionMove moveAction)
	{
		this.MoveAction = moveAction;
	}

	// Token: 0x06011AF2 RID: 72434 RVA: 0x00536388 File Offset: 0x00534588
	public override UniTask OnExecute()
	{
		RacingBetsDangoMoveCommand.<OnExecute>d__5 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoMoveCommand.<OnExecute>d__5>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AF3 RID: 72435 RVA: 0x005363CB File Offset: 0x005345CB
	public override string LogInfo()
	{
		return "RacingBetsDangoMoveCommand";
	}

	// Token: 0x04009A73 RID: 39539
	private const int DANGO_MOVE_EFFECT_REFRESH_DELAY_MS = 500;

	// Token: 0x04009A74 RID: 39540
	private RacingBetsDangoActionMove MoveAction;
}
