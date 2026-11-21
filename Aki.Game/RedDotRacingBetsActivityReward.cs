using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02002978 RID: 10616
public class RedDotRacingBetsActivityReward : RedDotBase
{
	// Token: 0x0601A9FD RID: 109053 RVA: 0x0083185D File Offset: 0x0082FA5D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601A9FE RID: 109054 RVA: 0x00831897 File Offset: 0x0082FA97
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
	}

	// Token: 0x0601A9FF RID: 109055 RVA: 0x008318D4 File Offset: 0x0082FAD4
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

	// Token: 0x0601AA00 RID: 109056 RVA: 0x00831911 File Offset: 0x0082FB11
	[NullableContext(1)]
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		base.EventCheck();
	}
}
