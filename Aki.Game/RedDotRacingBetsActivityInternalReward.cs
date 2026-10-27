using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02003405 RID: 13317
public class RedDotRacingBetsActivityInternalReward : RedDotBase
{
	// Token: 0x0601CD00 RID: 118016 RVA: 0x0080B1EA File Offset: 0x008093EA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601CD01 RID: 118017 RVA: 0x0080B224 File Offset: 0x00809424
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601CD02 RID: 118018 RVA: 0x0080B260 File Offset: 0x00809460
	protected override bool OnCheck(int uId = 0)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		return racingBetsSeasonData != null && racingBetsSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn).CanReceiveRewards();
	}

	// Token: 0x0601CD03 RID: 118019 RVA: 0x0080B289 File Offset: 0x00809489
	[NullableContext(1)]
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		base.EventCheck();
	}
}
