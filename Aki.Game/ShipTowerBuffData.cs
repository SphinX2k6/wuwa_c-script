using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

// Token: 0x02001EF3 RID: 7923
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffData
{
	// Token: 0x060139F5 RID: 80373 RVA: 0x005B923F File Offset: 0x005B743F
	public ShipTowerBuffData()
	{
		this.BuffIds = new List<long>();
		this.ItemNameKey = "";
		this.ObtainedShowDescKey = "";
		this.BgDescKey = "";
	}

	// Token: 0x17001DE3 RID: 7651
	// (get) Token: 0x060139F6 RID: 80374 RVA: 0x005B9273 File Offset: 0x005B7473
	public int CanUseCount
	{
		get
		{
			return this.TotalUseCount - this.UsedCount;
		}
	}

	// Token: 0x17001DE4 RID: 7652
	// (get) Token: 0x060139F7 RID: 80375 RVA: 0x005B9282 File Offset: 0x005B7482
	public int CanUseCountNoEdit
	{
		get
		{
			return this.TotalUseCount - this.UsedCountNoEdit;
		}
	}

	// Token: 0x17001DE5 RID: 7653
	// (get) Token: 0x060139F8 RID: 80376 RVA: 0x005B9291 File Offset: 0x005B7491
	public bool IsUnlock
	{
		get
		{
			return this.TotalUseCount > 0;
		}
	}

	// Token: 0x17001DE6 RID: 7654
	// (get) Token: 0x060139F9 RID: 80377 RVA: 0x005B929C File Offset: 0x005B749C
	public int TotalUseCount
	{
		get
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
		}
	}

	// Token: 0x17001DE7 RID: 7655
	// (get) Token: 0x060139FA RID: 80378 RVA: 0x005B92B0 File Offset: 0x005B74B0
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

	// Token: 0x17001DE8 RID: 7656
	// (get) Token: 0x060139FB RID: 80379 RVA: 0x005B93B4 File Offset: 0x005B75B4
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

	// Token: 0x060139FC RID: 80380 RVA: 0x005B94B8 File Offset: 0x005B76B8
	public void Init(SlashBuffToItem cfg)
	{
		this.Id = cfg.Id;
		this.ItemId = cfg.ItemId;
		this.Unlimited = cfg.Unlimited;
		this.BuffIds = new List<long>(cfg.BuffIds());
		this.Season = cfg.Season;
		this.UpdateItemInfo();
	}

	// Token: 0x060139FD RID: 80381 RVA: 0x005B9514 File Offset: 0x005B7714
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

	// Token: 0x060139FE RID: 80382 RVA: 0x005B958F File Offset: 0x005B778F
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

	// Token: 0x060139FF RID: 80383 RVA: 0x005B95BC File Offset: 0x005B77BC
	public void ClearSelected()
	{
		this.IsSelected = false;
	}

	// Token: 0x06013A00 RID: 80384 RVA: 0x005B95C8 File Offset: 0x005B77C8
	public string CanUseCountStr(int? stageId = null)
	{
		if (!this.IsUnlimited(stageId))
		{
			return this.CanUseCount.ToString();
		}
		return "∞";
	}

	// Token: 0x06013A01 RID: 80385 RVA: 0x005B95F2 File Offset: 0x005B77F2
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

	// Token: 0x06013A02 RID: 80386 RVA: 0x005B9629 File Offset: 0x005B7829
	public bool IsShowNumTextCallback(int? stageId = null)
	{
		return !this.IsUnlimited(stageId);
	}

	// Token: 0x06013A03 RID: 80387 RVA: 0x005B9638 File Offset: 0x005B7838
	public FColor GetQualityColor()
	{
		QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(this.Quality);
		if (qualityConfig != null)
		{
			return FColor.FromHex(qualityConfig.Value.DropColor);
		}
		return new FColor();
	}

	// Token: 0x06013A04 RID: 80388 RVA: 0x005B9679 File Offset: 0x005B7879
	public bool IsCanUse(int? stageId = null)
	{
		ShipTowerModel instance = ShipTowerModel.Instance;
		return (instance == null || !instance.IsOldSeason(this.Season)) && this.IsUnlock && (this.IsUnlimited(stageId) || this.CanUseCount > 0);
	}

	// Token: 0x06013A05 RID: 80389 RVA: 0x005B96B4 File Offset: 0x005B78B4
	public string GetQualityTitle()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GhostShipItemQuality_Text");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Quality);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06013A06 RID: 80390 RVA: 0x005B96EB File Offset: 0x005B78EB
	public bool IsFirstGet()
	{
		return this.IsUnlock && !ShipTowerModel.Instance.PlayerGetBuffSet.Contains(this.Id);
	}

	// Token: 0x06013A07 RID: 80391 RVA: 0x005B9711 File Offset: 0x005B7911
	public bool AddToGetState()
	{
		if (!this.IsFirstGet())
		{
			return false;
		}
		ShipTowerModel.Instance.AddPlayerGetBuff(this.Id);
		return true;
	}

	// Token: 0x0400A782 RID: 42882
	public int Id;

	// Token: 0x0400A783 RID: 42883
	public List<long> BuffIds;

	// Token: 0x0400A784 RID: 42884
	public int ItemId;

	// Token: 0x0400A785 RID: 42885
	public int Quality;

	// Token: 0x0400A786 RID: 42886
	public string ItemNameKey;

	// Token: 0x0400A787 RID: 42887
	public string ObtainedShowDescKey;

	// Token: 0x0400A788 RID: 42888
	public string BgDescKey;

	// Token: 0x0400A789 RID: 42889
	public bool IsSelected;

	// Token: 0x0400A78A RID: 42890
	private bool Unlimited;

	// Token: 0x0400A78B RID: 42891
	public int Season;
}
