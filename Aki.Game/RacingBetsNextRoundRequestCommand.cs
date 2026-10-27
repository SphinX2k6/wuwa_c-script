using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D7 RID: 9943
public class RacingBetsNextRoundRequestCommand : RacingBetsCommandBase
{
	// Token: 0x17001A70 RID: 6768
	// (get) Token: 0x0601463C RID: 83516 RVA: 0x0052846E File Offset: 0x0052666E
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.NextRoundRequest;
		}
	}

	// Token: 0x0601463D RID: 83517 RVA: 0x00528472 File Offset: 0x00526672
	public void Init(int activityId, int legMatchId, int roundId)
	{
		this.ActivityId = activityId;
		this.LegMatchId = legMatchId;
		this.RoundId = roundId;
	}

	// Token: 0x0601463E RID: 83518 RVA: 0x0052848C File Offset: 0x0052668C
	public override UniTask OnExecute()
	{
		RacingBetsNextRoundRequestCommand.<OnExecute>d__9 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsNextRoundRequestCommand.<OnExecute>d__9>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0601463F RID: 83519 RVA: 0x005284CF File Offset: 0x005266CF
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsNextRoundRequestCommand";
	}

	// Token: 0x0400992C RID: 39212
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x0400992D RID: 39213
	private int ActivityId;

	// Token: 0x0400992E RID: 39214
	private int LegMatchId;

	// Token: 0x0400992F RID: 39215
	private int RoundId;

	// Token: 0x04009930 RID: 39216
	private const int REQUEST_INTERVAL_TIME = 1000;

	// Token: 0x04009931 RID: 39217
	private const int REQUEST_MAX_COUNT = 5;
}
