using System;

// Token: 0x020012B7 RID: 4791
public class ActivityLoopTowerData : ActivityBaseData
{
	// Token: 0x0600839D RID: 33693 RVA: 0x001C0648 File Offset: 0x001BE848
	public override bool GetExDataRedPointShowState()
	{
		return TowerModel.Instance.CurrentSeason != -1 && (TowerModel.Instance.GetLoopTowerIsClickSeason() < TowerModel.Instance.CurrentSeason || TowerModel.Instance.CanGetRewardByDifficulties(3) || !TowerModel.Instance.GetLoopTowerIsClickShop());
	}

	// Token: 0x0600839E RID: 33694 RVA: 0x001C0696 File Offset: 0x001BE896
	protected override bool GetExDataFinishShowState()
	{
		return TowerModel.Instance.CurrentSeason == TowerModel.Instance.DataSeason && TowerModel.Instance.IsRewardAllFinished(new int?(3));
	}
}
