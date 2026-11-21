using System;

// Token: 0x0200076B RID: 1899
public class ActivityLoopTowerData : ActivityBaseData
{
	// Token: 0x06005734 RID: 22324 RVA: 0x001C93D8 File Offset: 0x001C75D8
	public override bool GetExDataRedPointShowState()
	{
		return TowerModel.Instance.CurrentSeason != -1 && (TowerModel.Instance.GetLoopTowerIsClickSeason() < TowerModel.Instance.CurrentSeason || TowerModel.Instance.CanGetRewardByDifficulties(3) || !TowerModel.Instance.GetLoopTowerIsClickShop());
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x001C9426 File Offset: 0x001C7626
	protected override bool GetExDataFinishShowState()
	{
		return TowerModel.Instance.CurrentSeason == TowerModel.Instance.DataSeason && TowerModel.Instance.IsRewardAllFinished(new int?(3));
	}
}
