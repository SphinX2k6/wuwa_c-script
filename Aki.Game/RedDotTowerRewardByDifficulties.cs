using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200343C RID: 13372
public class RedDotTowerRewardByDifficulties : RedDotBase
{
	// Token: 0x0601CE0D RID: 118285 RVA: 0x0080DA8C File Offset: 0x0080BC8C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotTowerRewardByDifficulties, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE0E RID: 118286 RVA: 0x0080DAC6 File Offset: 0x0080BCC6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotTowerRewardByDifficulties, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE0F RID: 118287 RVA: 0x0080DB00 File Offset: 0x0080BD00
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
