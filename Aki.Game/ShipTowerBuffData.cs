using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x02002978 RID: 10616
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffData
{
	// Token: 0x06015FEF RID: 90095 RVA: 0x0058E27A File Offset: 0x0058C47A
	public ShipTowerBuffData()
	{
		this.BuffIds = new List<long>();
		this.ItemNameKey = "";
		this.ObtainedShowDescKey = "";
		this.BgDescKey = "";
	}

	// Token: 0x17001D8A RID: 7562
	// (get) Token: 0x06015FF0 RID: 90096 RVA: 0x0058E2AE File Offset: 0x0058C4AE
	public int CanUseCount
	{
		get
		{
			return this.TotalUseCount - this.UsedCount;
		}
	}

	// Token: 0x17001D8B RID: 7563
	// (get) Token: 0x06015FF1 RID: 90097 RVA: 0x0058E2BD File Offset: 0x0058C4BD
	public int CanUseCountNoEdit
	{
		get
		{
			return this.TotalUseCount - this.UsedCountNoEdit;
		}
	}

	// Token: 0x17001D8C RID: 7564
	// (get) Token: 0x06015FF2 RID: 90098 RVA: 0x0058E2CC File Offset: 0x0058C4CC
	public bool IsUnlock
	{
		get
		{
			return this.TotalUseCount > 0;
		}
	}

	// Token: 0x17001D8D RID: 7565
	// (get) Token: 0x06015FF3 RID: 90099 RVA: 0x0058E2D7 File Offset: 0x0058C4D7
	public int TotalUseCount
	{
		get
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
		}
	}

	// Token: 0x17001D8E RID: 7566
	// (get) Token: 0x06015FF4 RID: 90100 RVA: 0x0058E2EC File Offset: 0x0058C4EC
	public int UsedCount
	{
		get
		{
			IReadOnlyList<ShipTowerStageData> towerStageDataList = ShipTowerModel.Instance.TowerStageDataList;
			if (towerStageDataList.Count != 0)
			{
				ShipTowerStageData shipTowerStageData = towerStageDataList[0];
				if (shipTowerStageData != null && shipTowerStageData.IsHaveProtoData)
				{
					int num = 0;
					foreach (ShipTowerStageData shipTowerStageData2 in towerStageDataList)
					{
						if (!shipTowerStageData2.IsEndLess && shipTowerStageData2.IsUnLocked())
						{
							foreach (ShipTowerTeamData shipTowerTeamData in shipTowerStageData2.TeamDataList)
							{
								ShipTowerBuffData buffDataEdit = shipTowerTeamData.BuffDataEdit;
								int? num2 = (buffDataEdit != null) ? new int?(buffDataEdit.Id) : null;
								int id = this.Id;
								if (num2.GetValueOrDefault() == id & num2 != null)
								{
									num++;
								}
							}
						}
					}
					return num;
				}
			}
			return 0;
		}
	}

	// Token: 0x17001D8F RID: 7567
	// (get) Token: 0x06015FF5 RID: 90101 RVA: 0x0058E3F0 File Offset: 0x0058C5F0
	public int UsedCountNoEdit
	{
		get
		{
			IReadOnlyList<ShipTowerStageData> towerStageDataList = ShipTowerModel.Instance.TowerStageDataList;
			if (towerStageDataList.Count != 0)
			{
				ShipTowerStageData shipTowerStageData = towerStageDataList[0];
				if (shipTowerStageData != null && shipTowerStageData.IsHaveProtoData)
				{
					int num = 0;
					foreach (ShipTowerStageData shipTowerStageData2 in towerStageDataList)
					{
						if (!shipTowerStageData2.IsEndLess && shipTowerStageData2.IsUnLocked())
						{
							foreach (ShipTowerTeamData shipTowerTeamData in shipTowerStageData2.TeamDataList)
							{
								ShipTowerBuffData buffData = shipTowerTeamData.BuffData;
								int? num2 = (buffData != null) ? new int?(buffData.Id) : null;
								int id = this.Id;
								if (num2.GetValueOrDefault() == id & num2 != null)
								{
									num++;
								}
							}
						}
					}
					return num;
				}
			}
			return 0;
		}
	}

	// Token: 0x06015FF6 RID: 90102 RVA: 0x0058E4F4 File Offset: 0x0058C6F4
	public void Init(SlashBuffToItem cfg)
	{
		this.Id = cfg.Id;
		this.ItemId = cfg.ItemId;
		this.Unlimited = cfg.Unlimited;
		this.BuffIds = new List<long>(cfg.BuffIds());
		this.Season = cfg.Season;
		this.UpdateItemInfo();
	}

	// Token: 0x06015FF7 RID: 90103 RVA: 0x0058E550 File Offset: 0x0058C750
	private void UpdateItemInfo()
	{
		ItemInfo? config = ItemConfig.Instance.GetConfig(this.ItemId);
		if (config != null)
		{
			this.Quality = config.Value.QualityId;
			this.ItemNameKey = config.Value.Name;
			this.ObtainedShowDescKey = config.Value.ObtainedShowDescription;
			this.BgDescKey = config.Value.BgDescription;
		}
	}

	// Token: 0x06015FF8 RID: 90104 RVA: 0x0058E5CB File Offset: 0x0058C7CB
	public void SetSelected(bool isSelected)
	{
		if (isSelected)
		{
			ShipTowerBuffData curSelectBuffData = ShipTowerModel.Instance.CurSelectBuffData;
			if (curSelectBuffData != null)
			{
				curSelectBuffData.SetSelected(false);
			}
			ShipTowerModel.Instance.CurSelectBuffData = this;
		}
		this.IsSelected = isSelected;
	}

	// Token: 0x06015FF9 RID: 90105 RVA: 0x0058E5F8 File Offset: 0x0058C7F8
	public void ClearSelected()
	{
		this.IsSelected = false;
	}

	// Token: 0x06015FFA RID: 90106 RVA: 0x0058E604 File Offset: 0x0058C804
	public string CanUseCountStr(int? stageId = null)
	{
		if (!this.IsUnlimited(stageId))
		{
			return this.CanUseCount.ToString();
		}
		return "∞";
	}

	// Token: 0x06015FFB RID: 90107 RVA: 0x0058E62E File Offset: 0x0058C82E
	public bool IsUnlimited(int? stageId = null)
	{
		if (this.Unlimited)
		{
			return true;
		}
		if (stageId != null)
		{
			ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(stageId.Value);
			if (stageDataById != null && stageDataById.IsEndLess)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06015FFC RID: 90108 RVA: 0x0058E665 File Offset: 0x0058C865
	public bool IsShowNumTextCallback(int? stageId = null)
	{
		return !this.IsUnlimited(stageId);
	}

	// Token: 0x06015FFD RID: 90109 RVA: 0x0058E674 File Offset: 0x0058C874
	public FColor GetQualityColor()
	{
		QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(this.Quality);
		if (qualityConfig != null)
		{
			return FColor.FromHex(qualityConfig.Value.DropColor);
		}
		return new FColor();
	}

	// Token: 0x06015FFE RID: 90110 RVA: 0x0058E6B5 File Offset: 0x0058C8B5
	public bool IsCanUse(int? stageId = null)
	{
		ShipTowerModel instance = ShipTowerModel.Instance;
		return (instance == null || !instance.IsOldSeason(this.Season)) && this.IsUnlock && (this.IsUnlimited(stageId) || this.CanUseCount > 0);
	}

	// Token: 0x06015FFF RID: 90111 RVA: 0x0058E6F0 File Offset: 0x0058C8F0
	public string GetQualityTitle()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GhostShipItemQuality_Text");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Quality);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016000 RID: 90112 RVA: 0x0058E727 File Offset: 0x0058C927
	public bool IsFirstGet()
	{
		return this.IsUnlock && !ShipTowerModel.Instance.PlayerGetBuffSet.Contains(this.Id);
	}

	// Token: 0x06016001 RID: 90113 RVA: 0x0058E74D File Offset: 0x0058C94D
	public bool AddToGetState()
	{
		if (!this.IsFirstGet())
		{
			return false;
		}
		ShipTowerModel.Instance.AddPlayerGetBuff(this.Id);
		return true;
	}

	// Token: 0x0400A398 RID: 41880
	public int Id;

	// Token: 0x0400A399 RID: 41881
	public List<long> BuffIds;

	// Token: 0x0400A39A RID: 41882
	public int ItemId;

	// Token: 0x0400A39B RID: 41883
	public int Quality;

	// Token: 0x0400A39C RID: 41884
	public string ItemNameKey;

	// Token: 0x0400A39D RID: 41885
	public string ObtainedShowDescKey;

	// Token: 0x0400A39E RID: 41886
	public string BgDescKey;

	// Token: 0x0400A39F RID: 41887
	public bool IsSelected;

	// Token: 0x0400A3A0 RID: 41888
	private bool Unlimited;

	// Token: 0x0400A3A1 RID: 41889
	public int Season;
}
