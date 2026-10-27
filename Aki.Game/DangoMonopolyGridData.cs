using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200123A RID: 4666
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyGridData
{
	// Token: 0x06007E17 RID: 32279 RVA: 0x001AB037 File Offset: 0x001A9237
	public static DangoMonopolyGridData Create(DangoMonopolyGrid config, int index, DangoMonopolyBoardData board)
	{
		DangoMonopolyGridData dangoMonopolyGridData = new DangoMonopolyGridData(config.GridId, index, board);
		dangoMonopolyGridData.Init(config);
		return dangoMonopolyGridData;
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x001AB04E File Offset: 0x001A924E
	private DangoMonopolyGridData(int id, int index, DangoMonopolyBoardData board)
	{
		this.Id = id;
		this.Index = index;
		this.BelongBoard = board;
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x001AB078 File Offset: 0x001A9278
	private void Init(DangoMonopolyGrid config)
	{
		this.GroupId = config.GridGroupId;
		this.AddPropertyId = config.AddPropertyId;
		this.RemovePropertyId = config.RemovePropertyId;
		this.GridInfo = config.GridInfo();
		if (this.GridInfo.Length == 0)
		{
			return;
		}
		this.GridType = (EDangoMonopolyGridType)this.GridInfo[0];
		switch (this.GridType)
		{
		case EDangoMonopolyGridType.Empty:
			break;
		case EDangoMonopolyGridType.Item:
			this.ItemId = ((this.GridInfo.Length > 1) ? this.GridInfo[1] : 0);
			this.ItemCount = ((this.GridInfo.Length > 2) ? this.GridInfo[2] : 0);
			break;
		case EDangoMonopolyGridType.Dango:
			this.DangoId = ((this.GridInfo.Length > 1) ? this.GridInfo[1] : 0);
			return;
		default:
			return;
		}
	}

	// Token: 0x06007E1A RID: 32282 RVA: 0x001AB140 File Offset: 0x001A9340
	public bool IsGreaterIndex(int index)
	{
		return this.Index > index;
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x001AB14B File Offset: 0x001A934B
	public bool IsEqualIndex(int index)
	{
		return this.Index == index;
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x001AB156 File Offset: 0x001A9356
	public bool IsLessIndex(int index)
	{
		return this.Index < index;
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x001AB161 File Offset: 0x001A9361
	public bool IsExistDango()
	{
		return this.GridType == EDangoMonopolyGridType.Dango;
	}

	// Token: 0x06007E1E RID: 32286 RVA: 0x001AB16C File Offset: 0x001A936C
	public bool IsExistItem()
	{
		return this.GridType == EDangoMonopolyGridType.Item;
	}

	// Token: 0x06007E1F RID: 32287 RVA: 0x001AB177 File Offset: 0x001A9377
	public bool IsExistEmpty()
	{
		return this.GridType == EDangoMonopolyGridType.Empty;
	}

	// Token: 0x06007E20 RID: 32288 RVA: 0x001AB182 File Offset: 0x001A9382
	public int GetPosition()
	{
		return this.Index + 1;
	}

	// Token: 0x06007E21 RID: 32289 RVA: 0x001AB18C File Offset: 0x001A938C
	[NullableContext(2)]
	public DangoData GetDangoData()
	{
		if (this.IsExistDango())
		{
			return DangoManager.Instance.GetDangoData(this.DangoId);
		}
		return null;
	}

	// Token: 0x06007E22 RID: 32290 RVA: 0x001AB1A8 File Offset: 0x001A93A8
	public DangoMonopolyProperty? GetAddPropertyConfig()
	{
		if (this.AddPropertyId == 0)
		{
			return null;
		}
		ActivityDangoMonopolyConfig instance = ActivityDangoMonopolyConfig.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetProperty(this.AddPropertyId);
	}

	// Token: 0x06007E23 RID: 32291 RVA: 0x001AB1E8 File Offset: 0x001A93E8
	public EDangoMonopolyBuffType GetAddPropertyType()
	{
		DangoMonopolyProperty? addPropertyConfig = this.GetAddPropertyConfig();
		if (addPropertyConfig == null)
		{
			return EDangoMonopolyBuffType.None;
		}
		return (EDangoMonopolyBuffType)addPropertyConfig.Value.PropertyInfo()[0];
	}

	// Token: 0x06007E24 RID: 32292 RVA: 0x001AB218 File Offset: 0x001A9418
	public bool IsAddPropertyType(EDangoMonopolyBuffType buffType)
	{
		return this.GetAddPropertyType() == buffType;
	}

	// Token: 0x06007E25 RID: 32293 RVA: 0x001AB223 File Offset: 0x001A9423
	public bool PropertyIsDouble()
	{
		return this.IsAddPropertyType(EDangoMonopolyBuffType.RewardDouble);
	}

	// Token: 0x06007E26 RID: 32294 RVA: 0x001AB22C File Offset: 0x001A942C
	public bool IsFinish()
	{
		return this.BelongBoard.GetFinishGridNum() >= this.GetPosition();
	}

	// Token: 0x06007E27 RID: 32295 RVA: 0x001AB244 File Offset: 0x001A9444
	public bool IsActiveDouble()
	{
		DangoMonopolyGridData firstDoubleGrid = this.BelongBoard.GetFirstDoubleGrid();
		return firstDoubleGrid != null && !this.IsLessIndex(firstDoubleGrid.Index) && firstDoubleGrid.IsFinish();
	}

	// Token: 0x06007E28 RID: 32296 RVA: 0x001AB27D File Offset: 0x001A947D
	public int GetDangoRunningGridId()
	{
		if (!this.IsExistDango())
		{
			return this.Id;
		}
		if (!this.IsFinish())
		{
			return this.Id;
		}
		DangoMonopolyGridData currentGridData = this.BelongBoard.GetCurrentGridData();
		if (currentGridData == null)
		{
			return this.Id;
		}
		return currentGridData.Id;
	}

	// Token: 0x06007E29 RID: 32297 RVA: 0x001AB2B8 File Offset: 0x001A94B8
	public void UpdateMoveFinishBuffId(int id)
	{
		this.MoveFinishBuffId = id;
	}

	// Token: 0x06007E2A RID: 32298 RVA: 0x001AB2C1 File Offset: 0x001A94C1
	public bool IsNeedTriggerBuff()
	{
		return this.GetFireBuffId() > 0;
	}

	// Token: 0x06007E2B RID: 32299 RVA: 0x001AB2CC File Offset: 0x001A94CC
	public int GetFireBuffId()
	{
		if (this.MoveFinishBuffId != 0)
		{
			return this.MoveFinishBuffId;
		}
		if (this.AddPropertyId != 0)
		{
			return this.AddPropertyId;
		}
		return 0;
	}

	// Token: 0x06007E2C RID: 32300 RVA: 0x001AB2ED File Offset: 0x001A94ED
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x0400397F RID: 14719
	public int Id;

	// Token: 0x04003980 RID: 14720
	public int GroupId;

	// Token: 0x04003981 RID: 14721
	public int Index;

	// Token: 0x04003982 RID: 14722
	public int AddPropertyId;

	// Token: 0x04003983 RID: 14723
	public int RemovePropertyId;

	// Token: 0x04003984 RID: 14724
	public int[] GridInfo = Array.Empty<int>();

	// Token: 0x04003985 RID: 14725
	public EDangoMonopolyGridType GridType;

	// Token: 0x04003986 RID: 14726
	public int DangoId;

	// Token: 0x04003987 RID: 14727
	public int ItemId;

	// Token: 0x04003988 RID: 14728
	public int ItemCount;

	// Token: 0x04003989 RID: 14729
	public DangoMonopolyBoardData BelongBoard;

	// Token: 0x0400398A RID: 14730
	public int MoveFinishBuffId;
}
