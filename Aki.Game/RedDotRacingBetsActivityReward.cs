using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02003406 RID: 13318
public class RedDotRacingBetsActivityReward : RedDotBase
{
	// Token: 0x0601CD05 RID: 118021 RVA: 0x0080B299 File Offset: 0x00809499
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601CD06 RID: 118022 RVA: 0x0080B2D3 File Offset: 0x008094D3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601CD07 RID: 118023 RVA: 0x0080B310 File Offset: 0x00809510
	protected override bool OnCheck(int uId = 0)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return false;
		}
		RacingBetsGroupRewardData groupRewardData = racingBetsSeasonData.GetGroupRewardData(ERacingBetsRewardType.BetsCount);
		RacingBetsGroupRewardData groupRewardData2 = racingBetsSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyEarn);
		return groupRewardData.CanReceiveRewards() || groupRewardData2.CanReceiveRewards();
	}

	// Token: 0x0601CD08 RID: 118024 RVA: 0x0080B34D File Offset: 0x0080954D
	[NullableContext(1)]
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		base.EventCheck();
	}
}
