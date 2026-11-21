using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BC2 RID: 7106
public class RacingBetsNextRoundRequestCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA8 RID: 6824
	// (get) Token: 0x06011B1E RID: 72478 RVA: 0x005371A6 File Offset: 0x005353A6
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.NextRoundRequest;
		}
	}

	// Token: 0x06011B1F RID: 72479 RVA: 0x005371AA File Offset: 0x005353AA
	public void Init(int activityId, int legMatchId, int roundId)
	{
		this.ActivityId = activityId;
		this.LegMatchId = legMatchId;
		this.RoundId = roundId;
	}

	// Token: 0x06011B20 RID: 72480 RVA: 0x005371C4 File Offset: 0x005353C4
	public override UniTask OnExecute()
	{
		RacingBetsNextRoundRequestCommand.<OnExecute>d__9 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsNextRoundRequestCommand.<OnExecute>d__9>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B21 RID: 72481 RVA: 0x00537207 File Offset: 0x00535407
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsNextRoundRequestCommand";
	}

	// Token: 0x04009A84 RID: 39556
	[Nullable(2)]
	private CustomPromise Promise;

	// Token: 0x04009A85 RID: 39557
	private int ActivityId;

	// Token: 0x04009A86 RID: 39558
	private int LegMatchId;

	// Token: 0x04009A87 RID: 39559
	private int RoundId;

	// Token: 0x04009A88 RID: 39560
	private const int REQUEST_INTERVAL_TIME = 1000;

	// Token: 0x04009A89 RID: 39561
	private const int REQUEST_MAX_COUNT = 5;
}
