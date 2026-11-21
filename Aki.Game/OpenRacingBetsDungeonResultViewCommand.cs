using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB3 RID: 7091
[NullableContext(1)]
[Nullable(0)]
public class OpenRacingBetsDungeonResultViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A96 RID: 6806
	// (get) Token: 0x06011AB8 RID: 72376 RVA: 0x00535DF3 File Offset: 0x00533FF3
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DungeonResultView;
		}
	}

	// Token: 0x06011AB9 RID: 72377 RVA: 0x00535DF7 File Offset: 0x00533FF7
	public void Init(RacingBetsLegMatchData legMatchData)
	{
		this.LegMatchData = legMatchData;
	}

	// Token: 0x06011ABA RID: 72378 RVA: 0x00535E00 File Offset: 0x00534000
	public override UniTask OnExecute()
	{
		OpenRacingBetsDungeonResultViewCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsDungeonResultViewCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011ABB RID: 72379 RVA: 0x00535E43 File Offset: 0x00534043
	public override string LogInfo()
	{
		return "RacingBetsDungeonResultView";
	}

	// Token: 0x04009A68 RID: 39528
	private RacingBetsLegMatchData LegMatchData;
}
