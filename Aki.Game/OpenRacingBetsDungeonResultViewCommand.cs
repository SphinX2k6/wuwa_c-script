using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026C8 RID: 9928
[NullableContext(1)]
[Nullable(0)]
public class OpenRacingBetsDungeonResultViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A5E RID: 6750
	// (get) Token: 0x060145D6 RID: 83414 RVA: 0x005270BB File Offset: 0x005252BB
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DungeonResultView;
		}
	}

	// Token: 0x060145D7 RID: 83415 RVA: 0x005270BF File Offset: 0x005252BF
	public void Init(RacingBetsLegMatchData legMatchData)
	{
		this.LegMatchData = legMatchData;
	}

	// Token: 0x060145D8 RID: 83416 RVA: 0x005270C8 File Offset: 0x005252C8
	public override UniTask OnExecute()
	{
		OpenRacingBetsDungeonResultViewCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsDungeonResultViewCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x060145D9 RID: 83417 RVA: 0x0052710B File Offset: 0x0052530B
	public override string LogInfo()
	{
		return "RacingBetsDungeonResultView";
	}

	// Token: 0x04009910 RID: 39184
	private RacingBetsLegMatchData LegMatchData;
}
