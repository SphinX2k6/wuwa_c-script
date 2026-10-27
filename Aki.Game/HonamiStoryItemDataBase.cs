using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E6E RID: 7790
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemDataBase : IHonamiStoryGridItemData
{
	// Token: 0x0600ED37 RID: 60727 RVA: 0x00388450 File Offset: 0x00386650
	public virtual void Init(HonamiStoryItemInfo itemInfo)
	{
		this.IncId = itemInfo.IncrId;
		this.ItemId = itemInfo.HonamiStoryItemId;
		this.FuncValue = itemInfo.FuncValue;
		this.ItemType = (EHonamiStoryItemType)this.GetBaseConfig(this.ItemId).Value.ItemType;
	}

	// Token: 0x0600ED38 RID: 60728 RVA: 0x003884A3 File Offset: 0x003866A3
	public bool IsLock()
	{
		return (this.FuncValue & 1) > 0;
	}

	// Token: 0x0600ED39 RID: 60729 RVA: 0x003884B0 File Offset: 0x003866B0
	public void SetIsLock(bool value)
	{
		if (value)
		{
			this.FuncValue |= 1;
			return;
		}
		this.FuncValue &= -2;
	}

	// Token: 0x0600ED3A RID: 60730 RVA: 0x003884D3 File Offset: 0x003866D3
	public HonamiStoryItem? GetBaseConfig(int id)
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryItem(this.ItemId);
	}

	// Token: 0x0600ED3B RID: 60731 RVA: 0x003884E8 File Offset: 0x003866E8
	[NullableContext(2)]
	public void UpdatePositionInfo(HonamiStoryPosInfo posInfo)
	{
		if (posInfo == null)
		{
			this.Position = -1;
			this.IsCross = false;
			this.IsDragCross = false;
			this.FillPositionList.Clear();
			return;
		}
		this.Position = posInfo.Position;
		this.IsCross = posInfo.IsCross;
		this.IsDragCross = this.IsCross;
		this.FillPositionList.Clear();
	}

	// Token: 0x0600ED3C RID: 60732 RVA: 0x00388548 File Offset: 0x00386748
	private void InitGridFillPositionList()
	{
		this.FillPositionList = this.GetGridFillPositionByPosition(this.Position, this.IsCross);
	}

	// Token: 0x0600ED3D RID: 60733 RVA: 0x00388562 File Offset: 0x00386762
	public void SetBackpackWidth(int width)
	{
		this.BackpackWidth = width;
	}

	// Token: 0x0600ED3E RID: 60734 RVA: 0x0038856B File Offset: 0x0038676B
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0600ED3F RID: 60735 RVA: 0x00388573 File Offset: 0x00386773
	public int GetIncId()
	{
		return this.IncId;
	}

	// Token: 0x0600ED40 RID: 60736 RVA: 0x0038857C File Offset: 0x0038677C
	public string GetName()
	{
		return this.GetBaseConfig(this.ItemId).Value.Name;
	}

	// Token: 0x0600ED41 RID: 60737 RVA: 0x003885A8 File Offset: 0x003867A8
	public int GetQuality()
	{
		if (this.QualityId == -1)
		{
			this.QualityId = this.GetBaseConfig(this.ItemId).Value.QualityId;
		}
		return this.QualityId;
	}

	// Token: 0x0600ED42 RID: 60738 RVA: 0x003885E8 File Offset: 0x003867E8
	public HonamiStoryItemQuality? GetQualityConfig()
	{
		HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
		return HonamiStoryConfig.Instance.GetHonamiStoryQuality(baseConfig.Value.QualityId);
	}

	// Token: 0x0600ED43 RID: 60739 RVA: 0x0038861C File Offset: 0x0038681C
	public string GetDesc()
	{
		return this.GetBaseConfig(this.ItemId).Value.AttributesDescription;
	}

	// Token: 0x0600ED44 RID: 60740 RVA: 0x00388645 File Offset: 0x00386845
	public EHonamiStoryItemType GetItemType()
	{
		return this.ItemType;
	}

	// Token: 0x0600ED45 RID: 60741 RVA: 0x00388650 File Offset: 0x00386850
	public int GetSellPrice()
	{
		if (this.SellPrice == -1)
		{
			this.SellPrice = this.GetBaseConfig(this.ItemId).Value.SellPrice;
		}
		return this.SellPrice;
	}

	// Token: 0x0600ED46 RID: 60742 RVA: 0x00388690 File Offset: 0x00386890
	public string GetItemTypeText()
	{
		string result;
		if (HonamiStoryDefine.Instance.honamiItemTypeMap.TryGetValue(this.ItemType, out result))
		{
			return result;
		}
		return "";
	}

	// Token: 0x0600ED47 RID: 60743 RVA: 0x003886C0 File Offset: 0x003868C0
	public int GetSubType()
	{
		if (this.SubType == -1)
		{
			this.SubType = this.GetBaseConfig(this.ItemId).Value.SubType;
		}
		return this.SubType;
	}

	// Token: 0x0600ED48 RID: 60744 RVA: 0x003886FE File Offset: 0x003868FE
	public int GetPosition()
	{
		return this.Position;
	}

	// Token: 0x0600ED49 RID: 60745 RVA: 0x00388706 File Offset: 0x00386906
	public bool GetIsCross()
	{
		return this.IsCross;
	}

	// Token: 0x0600ED4A RID: 60746 RVA: 0x0038870E File Offset: 0x0038690E
	public bool GetIsDragCross()
	{
		return this.IsDragCross;
	}

	// Token: 0x0600ED4B RID: 60747 RVA: 0x00388716 File Offset: 0x00386916
	public void SetIsDragCross(bool value)
	{
		this.IsDragCross = value;
	}

	// Token: 0x0600ED4C RID: 60748 RVA: 0x0038871F File Offset: 0x0038691F
	public bool GetOldCross()
	{
		return this.OldCross;
	}

	// Token: 0x0600ED4D RID: 60749 RVA: 0x00388727 File Offset: 0x00386927
	public void SetOldCross(bool value)
	{
		this.OldCross = value;
	}

	// Token: 0x0600ED4E RID: 60750 RVA: 0x00388730 File Offset: 0x00386930
	public int GetGridHeight()
	{
		if (this.BaseWidth == -1 || this.BaseHeight == -1)
		{
			HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
			this.BaseWidth = baseConfig.Value.GridOccupy(0);
			this.BaseHeight = baseConfig.Value.GridOccupy(1);
		}
		if (!this.IsCross)
		{
			return this.BaseHeight;
		}
		return this.BaseWidth;
	}

	// Token: 0x0600ED4F RID: 60751 RVA: 0x003887A0 File Offset: 0x003869A0
	public int GetGridWidth()
	{
		if (this.BaseWidth == -1 || this.BaseHeight == -1)
		{
			HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
			this.BaseWidth = baseConfig.Value.GridOccupy(0);
			this.BaseHeight = baseConfig.Value.GridOccupy(1);
		}
		if (!this.IsCross)
		{
			return this.BaseWidth;
		}
		return this.BaseHeight;
	}

	// Token: 0x0600ED50 RID: 60752 RVA: 0x00388810 File Offset: 0x00386A10
	public int GetBaseGridHeight(bool isCross)
	{
		if (this.BaseWidth == -1 || this.BaseHeight == -1)
		{
			HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
			this.BaseWidth = baseConfig.Value.GridOccupy(0);
			this.BaseHeight = baseConfig.Value.GridOccupy(1);
		}
		if (!isCross)
		{
			return this.BaseHeight;
		}
		return this.BaseWidth;
	}

	// Token: 0x0600ED51 RID: 60753 RVA: 0x00388878 File Offset: 0x00386A78
	public int GetBaseGridWidth(bool isCross)
	{
		if (this.BaseWidth == -1 || this.BaseHeight == -1)
		{
			HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
			this.BaseWidth = baseConfig.Value.GridOccupy(0);
			this.BaseHeight = baseConfig.Value.GridOccupy(1);
		}
		if (!isCross)
		{
			return this.BaseWidth;
		}
		return this.BaseHeight;
	}

	// Token: 0x0600ED52 RID: 60754 RVA: 0x003888E0 File Offset: 0x00386AE0
	public int GetRow()
	{
		return (int)Math.Floor((double)this.GetPosition() / (double)this.BackpackWidth);
	}

	// Token: 0x0600ED53 RID: 60755 RVA: 0x003888F7 File Offset: 0x00386AF7
	public int GetColumn()
	{
		return this.GetPosition() % this.BackpackWidth;
	}

	// Token: 0x0600ED54 RID: 60756 RVA: 0x00388906 File Offset: 0x00386B06
	public List<int> GetGridFillPositionList()
	{
		if (this.FillPositionList.Count <= 0)
		{
			this.InitGridFillPositionList();
		}
		return this.FillPositionList;
	}

	// Token: 0x0600ED55 RID: 60757 RVA: 0x00388924 File Offset: 0x00386B24
	public List<int> GetGridFillPositionByPosition(int position, bool isCross)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.GetBaseGridWidth(isCross); i++)
		{
			for (int j = 0; j < this.GetBaseGridHeight(isCross); j++)
			{
				list.Add(position + i + j * this.BackpackWidth);
			}
		}
		return list;
	}

	// Token: 0x0600ED56 RID: 60758 RVA: 0x00388970 File Offset: 0x00386B70
	public string GetIconTexture()
	{
		return this.GetBaseConfig(this.ItemId).Value.Icon;
	}

	// Token: 0x0600ED57 RID: 60759 RVA: 0x0038899C File Offset: 0x00386B9C
	public string GetIconBackpack()
	{
		return this.GetBaseConfig(this.ItemId).Value.IconBackpack;
	}

	// Token: 0x0600ED58 RID: 60760 RVA: 0x003889C5 File Offset: 0x00386BC5
	public bool GetIsSelected()
	{
		return this.IsSelected;
	}

	// Token: 0x0600ED59 RID: 60761 RVA: 0x003889CD File Offset: 0x00386BCD
	public void SetIsSelected(bool value)
	{
		this.IsSelected = value;
	}

	// Token: 0x0600ED5A RID: 60762 RVA: 0x003889D6 File Offset: 0x00386BD6
	public bool GetNewInBackpack()
	{
		return this.IsNewInBackpack;
	}

	// Token: 0x0600ED5B RID: 60763 RVA: 0x003889DE File Offset: 0x00386BDE
	public void SetNewInBackpack(bool value)
	{
		this.IsNewInBackpack = value;
	}

	// Token: 0x0600ED5C RID: 60764 RVA: 0x003889E8 File Offset: 0x00386BE8
	public int GetTransPosIndex(int oldIndex)
	{
		bool isDragCross = this.IsDragCross;
		int num = (int)Math.Floor((double)oldIndex / (double)this.GetBaseGridHeight(isDragCross));
		return oldIndex % this.GetBaseGridHeight(isDragCross) * this.GetBaseGridWidth(isDragCross) + num;
	}

	// Token: 0x04006E20 RID: 28192
	private int IncId;

	// Token: 0x04006E21 RID: 28193
	private int ItemId;

	// Token: 0x04006E22 RID: 28194
	private EHonamiStoryItemType ItemType = EHonamiStoryItemType.Normal;

	// Token: 0x04006E23 RID: 28195
	protected int Position;

	// Token: 0x04006E24 RID: 28196
	protected int QualityId = -1;

	// Token: 0x04006E25 RID: 28197
	protected int SubType = -1;

	// Token: 0x04006E26 RID: 28198
	protected int SellPrice = -1;

	// Token: 0x04006E27 RID: 28199
	protected bool IsCross;

	// Token: 0x04006E28 RID: 28200
	protected bool OldCross;

	// Token: 0x04006E29 RID: 28201
	protected bool IsDragCross;

	// Token: 0x04006E2A RID: 28202
	protected List<int> FillPositionList = new List<int>();

	// Token: 0x04006E2B RID: 28203
	protected int BackpackWidth;

	// Token: 0x04006E2C RID: 28204
	protected int FuncValue;

	// Token: 0x04006E2D RID: 28205
	protected bool IsSelected;

	// Token: 0x04006E2E RID: 28206
	protected int BaseWidth = -1;

	// Token: 0x04006E2F RID: 28207
	protected int BaseHeight = -1;

	// Token: 0x04006E30 RID: 28208
	protected bool IsNewInBackpack;
}
