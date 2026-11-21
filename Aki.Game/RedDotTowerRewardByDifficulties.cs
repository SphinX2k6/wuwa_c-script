using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029B0 RID: 10672
public class RedDotTowerRewardByDifficulties : RedDotBase
{
	// Token: 0x0601AB0D RID: 109325 RVA: 0x00834174 File Offset: 0x00832374
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotTowerRewardByDifficulties, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB0E RID: 109326 RVA: 0x008341AE File Offset: 0x008323AE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotTowerRewardByDifficulties, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB0F RID: 109327 RVA: 0x008341E8 File Offset: 0x008323E8
	protected override bool OnCheck(int uId = 0)
	{
		switch (uId)
		{
		case 1:
			return TowerModel.Instance.CanGetRewardByDifficulties(1);
		case 2:
			return TowerModel.Instance.CanGetRewardByDifficulties(2);
		case 3:
		{
			int loopTowerIsClickSeason = TowerModel.Instance.GetLoopTowerIsClickSeason();
			return TowerModel.Instance.CanGetRewardByDifficulties(3) || loopTowerIsClickSeason < TowerModel.Instance.CurrentSeason;
		}
		case 4:
			return TowerModel.Instance.CanGetRewardByDifficulties(4);
		case 5:
		{
			bool flag = TowerModel.Instance.CanGetRewardByDifficulties(1);
			bool flag2 = TowerModel.Instance.CanGetRewardByDifficulties(2);
			bool flag3 = TowerModel.Instance.CanGetRewardByDifficulties(4);
			return flag || flag2 || flag3;
		}
		default:
			return false;
		}
	}
}
