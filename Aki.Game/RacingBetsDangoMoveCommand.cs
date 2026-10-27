using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D0 RID: 9936
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoMoveCommand : RacingBetsCommandBase
{
	// Token: 0x17001A69 RID: 6761
	// (get) Token: 0x0601460E RID: 83470 RVA: 0x00527642 File Offset: 0x00525842
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoMove;
		}
	}

	// Token: 0x0601460F RID: 83471 RVA: 0x00527645 File Offset: 0x00525845
	public void Init(RacingBetsDangoActionMove moveAction)
	{
		this.MoveAction = moveAction;
	}

	// Token: 0x06014610 RID: 83472 RVA: 0x00527650 File Offset: 0x00525850
	public override UniTask OnExecute()
	{
		RacingBetsDangoMoveCommand.<OnExecute>d__5 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoMoveCommand.<OnExecute>d__5>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014611 RID: 83473 RVA: 0x00527693 File Offset: 0x00525893
	public override string LogInfo()
	{
		return "RacingBetsDangoMoveCommand";
	}

	// Token: 0x0400991B RID: 39195
	private const int DANGO_MOVE_EFFECT_REFRESH_DELAY_MS = 500;

	// Token: 0x0400991C RID: 39196
	private RacingBetsDangoActionMove MoveAction;
}
