using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020006EE RID: 1774
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyGridData
{
	// Token: 0x060051AE RID: 20910 RVA: 0x001B3CF7 File Offset: 0x001B1EF7
	public static DangoMonopolyGridData Create(DangoMonopolyGrid config, int index, DangoMonopolyBoardData board)
	{
		DangoMonopolyGridData dangoMonopolyGridData = new DangoMonopolyGridData(config.GridId, index, board);
		dangoMonopolyGridData.Init(config);
		return dangoMonopolyGridData;
	}

	// Token: 0x060051AF RID: 20911 RVA: 0x001B3D0E File Offset: 0x001B1F0E
	private DangoMonopolyGridData(int id, int index, DangoMonopolyBoardData board)
	{
		this.Id = id;
		this.Index = index;
		this.BelongBoard = board;
	}

	// Token: 0x060051B0 RID: 20912 RVA: 0x001B3D38 File Offset: 0x001B1F38
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

	// Token: 0x060051B1 RID: 20913 RVA: 0x001B3E00 File Offset: 0x001B2000
	public bool IsGreaterIndex(int index)
	{
		return this.Index > index;
	}

	// Token: 0x060051B2 RID: 20914 RVA: 0x001B3E0B File Offset: 0x001B200B
	public bool IsEqualIndex(int index)
	{
		return this.Index == index;
	}

	// Token: 0x060051B3 RID: 20915 RVA: 0x001B3E16 File Offset: 0x001B2016
	public bool IsLessIndex(int index)
	{
		return this.Index < index;
	}

	// Token: 0x060051B4 RID: 20916 RVA: 0x001B3E21 File Offset: 0x001B2021
	public bool IsExistDango()
	{
		return this.GridType == EDangoMonopolyGridType.Dango;
	}

	// Token: 0x060051B5 RID: 20917 RVA: 0x001B3E2C File Offset: 0x001B202C
	public bool IsExistItem()
	{
		return this.GridType == EDangoMonopolyGridType.Item;
	}

	// Token: 0x060051B6 RID: 20918 RVA: 0x001B3E37 File Offset: 0x001B2037
	public bool IsExistEmpty()
	{
		return this.GridType == EDangoMonopolyGridType.Empty;
	}

	// Token: 0x060051B7 RID: 20919 RVA: 0x001B3E42 File Offset: 0x001B2042
	public int GetPosition()
	{
		return this.Index + 1;
	}

	// Token: 0x060051B8 RID: 20920 RVA: 0x001B3E4C File Offset: 0x001B204C
	[NullableContext(2)]
	public DangoData GetDangoData()
	{
		if (this.IsExistDango())
		{
			return DangoManager.Instance.GetDangoData(this.DangoId);
		}
		return null;
	}

	// Token: 0x060051B9 RID: 20921 RVA: 0x001B3E68 File Offset: 0x001B2068
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

	// Token: 0x060051BA RID: 20922 RVA: 0x001B3EA8 File Offset: 0x001B20A8
	public EDangoMonopolyBuffType GetAddPropertyType()
	{
		DangoMonopolyProperty? addPropertyConfig = this.GetAddPropertyConfig();
		if (addPropertyConfig == null)
		{
			return EDangoMonopolyBuffType.None;
		}
		return (EDangoMonopolyBuffType)addPropertyConfig.Value.PropertyInfo()[0];
	}

	// Token: 0x060051BB RID: 20923 RVA: 0x001B3ED8 File Offset: 0x001B20D8
	public bool IsAddPropertyType(EDangoMonopolyBuffType buffType)
	{
		return this.GetAddPropertyType() == buffType;
	}

	// Token: 0x060051BC RID: 20924 RVA: 0x001B3EE3 File Offset: 0x001B20E3
	public bool PropertyIsDouble()
	{
		return this.IsAddPropertyType(EDangoMonopolyBuffType.RewardDouble);
	}

	// Token: 0x060051BD RID: 20925 RVA: 0x001B3EEC File Offset: 0x001B20EC
	public bool IsFinish()
	{
		return this.BelongBoard.GetFinishGridNum() >= this.GetPosition();
	}

	// Token: 0x060051BE RID: 20926 RVA: 0x001B3F04 File Offset: 0x001B2104
	public bool IsActiveDouble()
	{
		DangoMonopolyGridData firstDoubleGrid = this.BelongBoard.GetFirstDoubleGrid();
		return firstDoubleGrid != null && !this.IsLessIndex(firstDoubleGrid.Index) && firstDoubleGrid.IsFinish();
	}

	// Token: 0x060051BF RID: 20927 RVA: 0x001B3F3D File Offset: 0x001B213D
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

	// Token: 0x060051C0 RID: 20928 RVA: 0x001B3F78 File Offset: 0x001B2178
	public void UpdateMoveFinishBuffId(int id)
	{
		this.MoveFinishBuffId = id;
	}

	// Token: 0x060051C1 RID: 20929 RVA: 0x001B3F81 File Offset: 0x001B2181
	public bool IsNeedTriggerBuff()
	{
		return this.GetFireBuffId() > 0;
	}

	// Token: 0x060051C2 RID: 20930 RVA: 0x001B3F8C File Offset: 0x001B218C
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

	// Token: 0x060051C3 RID: 20931 RVA: 0x001B3FAD File Offset: 0x001B21AD
	[Conditional("DEBUG")]
	public void LogInfo()
	{
	}

	// Token: 0x04003A17 RID: 14871
	public int Id;

	// Token: 0x04003A18 RID: 14872
	public int GroupId;

	// Token: 0x04003A19 RID: 14873
	public int Index;

	// Token: 0x04003A1A RID: 14874
	public int AddPropertyId;

	// Token: 0x04003A1B RID: 14875
	public int RemovePropertyId;

	// Token: 0x04003A1C RID: 14876
	public int[] GridInfo = Array.Empty<int>();

	// Token: 0x04003A1D RID: 14877
	public EDangoMonopolyGridType GridType;

	// Token: 0x04003A1E RID: 14878
	public int DangoId;

	// Token: 0x04003A1F RID: 14879
	public int ItemId;

	// Token: 0x04003A20 RID: 14880
	public int ItemCount;

	// Token: 0x04003A21 RID: 14881
	public DangoMonopolyBoardData BelongBoard;

	// Token: 0x04003A22 RID: 14882
	public int MoveFinishBuffId;
}
