using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02002977 RID: 10615
public class RedDotRacingBetsActivityInternalReward : RedDotBase
{
	// Token: 0x0601A9F8 RID: 109048 RVA: 0x008317AE File Offset: 0x0082F9AE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601A9F9 RID: 109049 RVA: 0x008317E8 File Offset: 0x0082F9E8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601A9FA RID: 109050 RVA: 0x00831824 File Offset: 0x0082FA24
	protected override bool OnCheck(int uId = 0)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		return racingBetsSeasonData != null && racingBetsSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn).CanReceiveRewards();
	}

	// Token: 0x0601A9FB RID: 109051 RVA: 0x0083184D File Offset: 0x0082FA4D
	[NullableContext(1)]
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		base.EventCheck();
	}
}
