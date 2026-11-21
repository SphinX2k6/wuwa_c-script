using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001330 RID: 4912
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemDataBase : IHonamiStoryGridItemData
{
	// Token: 0x0600C156 RID: 49494 RVA: 0x0039405C File Offset: 0x0039225C
	public virtual void Init(HonamiStoryItemInfo itemInfo)
	{
		this.IncId = itemInfo.IncrId;
		this.ItemId = itemInfo.HonamiStoryItemId;
		this.FuncValue = itemInfo.FuncValue;
		this.ItemType = (EHonamiStoryItemType)this.GetBaseConfig(this.ItemId).Value.ItemType;
	}

	// Token: 0x0600C157 RID: 49495 RVA: 0x003940AF File Offset: 0x003922AF
	public bool IsLock()
	{
		return (this.FuncValue & 1) > 0;
	}

	// Token: 0x0600C158 RID: 49496 RVA: 0x003940BC File Offset: 0x003922BC
	public void SetIsLock(bool value)
	{
		if (value)
		{
			this.FuncValue |= 1;
			return;
		}
		this.FuncValue &= -2;
	}

	// Token: 0x0600C159 RID: 49497 RVA: 0x003940DF File Offset: 0x003922DF
	public HonamiStoryItem? GetBaseConfig(int id)
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryItem(this.ItemId);
	}

	// Token: 0x0600C15A RID: 49498 RVA: 0x003940F4 File Offset: 0x003922F4
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

	// Token: 0x0600C15B RID: 49499 RVA: 0x00394154 File Offset: 0x00392354
	private void InitGridFillPositionList()
	{
		this.FillPositionList = this.GetGridFillPositionByPosition(this.Position, this.IsCross);
	}

	// Token: 0x0600C15C RID: 49500 RVA: 0x0039416E File Offset: 0x0039236E
	public void SetBackpackWidth(int width)
	{
		this.BackpackWidth = width;
	}

	// Token: 0x0600C15D RID: 49501 RVA: 0x00394177 File Offset: 0x00392377
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0600C15E RID: 49502 RVA: 0x0039417F File Offset: 0x0039237F
	public int GetIncId()
	{
		return this.IncId;
	}

	// Token: 0x0600C15F RID: 49503 RVA: 0x00394188 File Offset: 0x00392388
	public string GetName()
	{
		return this.GetBaseConfig(this.ItemId).Value.Name;
	}

	// Token: 0x0600C160 RID: 49504 RVA: 0x003941B4 File Offset: 0x003923B4
	public int GetQuality()
	{
		if (this.QualityId == -1)
		{
			this.QualityId = this.GetBaseConfig(this.ItemId).Value.QualityId;
		}
		return this.QualityId;
	}

	// Token: 0x0600C161 RID: 49505 RVA: 0x003941F4 File Offset: 0x003923F4
	public HonamiStoryItemQuality? GetQualityConfig()
	{
		HonamiStoryItem? baseConfig = this.GetBaseConfig(this.ItemId);
		return HonamiStoryConfig.Instance.GetHonamiStoryQuality(baseConfig.Value.QualityId);
	}

	// Token: 0x0600C162 RID: 49506 RVA: 0x00394228 File Offset: 0x00392428
	public string GetDesc()
	{
		return this.GetBaseConfig(this.ItemId).Value.AttributesDescription;
	}

	// Token: 0x0600C163 RID: 49507 RVA: 0x00394251 File Offset: 0x00392451
	public EHonamiStoryItemType GetItemType()
	{
		return this.ItemType;
	}

	// Token: 0x0600C164 RID: 49508 RVA: 0x0039425C File Offset: 0x0039245C
	public int GetSellPrice()
	{
		if (this.SellPrice == -1)
		{
			this.SellPrice = this.GetBaseConfig(this.ItemId).Value.SellPrice;
		}
		return this.SellPrice;
	}

	// Token: 0x0600C165 RID: 49509 RVA: 0x0039429C File Offset: 0x0039249C
	public string GetItemTypeText()
	{
		string result;
		if (HonamiStoryDefine.Instance.honamiItemTypeMap.TryGetValue(this.ItemType, out result))
		{
			return result;
		}
		return "";
	}

	// Token: 0x0600C166 RID: 49510 RVA: 0x003942CC File Offset: 0x003924CC
	public int GetSubType()
	{
		if (this.SubType == -1)
		{
			this.SubType = this.GetBaseConfig(this.ItemId).Value.SubType;
		}
		return this.SubType;
	}

	// Token: 0x0600C167 RID: 49511 RVA: 0x0039430A File Offset: 0x0039250A
	public int GetPosition()
	{
		return this.Position;
	}

	// Token: 0x0600C168 RID: 49512 RVA: 0x00394312 File Offset: 0x00392512
	public bool GetIsCross()
	{
		return this.IsCross;
	}

	// Token: 0x0600C169 RID: 49513 RVA: 0x0039431A File Offset: 0x0039251A
	public bool GetIsDragCross()
	{
		return this.IsDragCross;
	}

	// Token: 0x0600C16A RID: 49514 RVA: 0x00394322 File Offset: 0x00392522
	public void SetIsDragCross(bool value)
	{
		this.IsDragCross = value;
	}

	// Token: 0x0600C16B RID: 49515 RVA: 0x0039432B File Offset: 0x0039252B
	public bool GetOldCross()
	{
		return this.OldCross;
	}

	// Token: 0x0600C16C RID: 49516 RVA: 0x00394333 File Offset: 0x00392533
	public void SetOldCross(bool value)
	{
		this.OldCross = value;
	}

	// Token: 0x0600C16D RID: 49517 RVA: 0x0039433C File Offset: 0x0039253C
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

	// Token: 0x0600C16E RID: 49518 RVA: 0x003943AC File Offset: 0x003925AC
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

	// Token: 0x0600C16F RID: 49519 RVA: 0x0039441C File Offset: 0x0039261C
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

	// Token: 0x0600C170 RID: 49520 RVA: 0x00394484 File Offset: 0x00392684
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

	// Token: 0x0600C171 RID: 49521 RVA: 0x003944EC File Offset: 0x003926EC
	public int GetRow()
	{
		return (int)Math.Floor((double)this.GetPosition() / (double)this.BackpackWidth);
	}

	// Token: 0x0600C172 RID: 49522 RVA: 0x00394503 File Offset: 0x00392703
	public int GetColumn()
	{
		return this.GetPosition() % this.BackpackWidth;
	}

	// Token: 0x0600C173 RID: 49523 RVA: 0x00394512 File Offset: 0x00392712
	public List<int> GetGridFillPositionList()
	{
		if (this.FillPositionList.Count <= 0)
		{
			this.InitGridFillPositionList();
		}
		return this.FillPositionList;
	}

	// Token: 0x0600C174 RID: 49524 RVA: 0x00394530 File Offset: 0x00392730
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

	// Token: 0x0600C175 RID: 49525 RVA: 0x0039457C File Offset: 0x0039277C
	public string GetIconTexture()
	{
		return this.GetBaseConfig(this.ItemId).Value.Icon;
	}

	// Token: 0x0600C176 RID: 49526 RVA: 0x003945A8 File Offset: 0x003927A8
	public string GetIconBackpack()
	{
		return this.GetBaseConfig(this.ItemId).Value.IconBackpack;
	}

	// Token: 0x0600C177 RID: 49527 RVA: 0x003945D1 File Offset: 0x003927D1
	public bool GetIsSelected()
	{
		return this.IsSelected;
	}

	// Token: 0x0600C178 RID: 49528 RVA: 0x003945D9 File Offset: 0x003927D9
	public void SetIsSelected(bool value)
	{
		this.IsSelected = value;
	}

	// Token: 0x0600C179 RID: 49529 RVA: 0x003945E2 File Offset: 0x003927E2
	public bool GetNewInBackpack()
	{
		return this.IsNewInBackpack;
	}

	// Token: 0x0600C17A RID: 49530 RVA: 0x003945EA File Offset: 0x003927EA
	public void SetNewInBackpack(bool value)
	{
		this.IsNewInBackpack = value;
	}

	// Token: 0x0600C17B RID: 49531 RVA: 0x003945F4 File Offset: 0x003927F4
	public int GetTransPosIndex(int oldIndex)
	{
		bool isDragCross = this.IsDragCross;
		int num = (int)Math.Floor((double)oldIndex / (double)this.GetBaseGridHeight(isDragCross));
		return oldIndex % this.GetBaseGridHeight(isDragCross) * this.GetBaseGridWidth(isDragCross) + num;
	}

	// Token: 0x04006F01 RID: 28417
	private int IncId;

	// Token: 0x04006F02 RID: 28418
	private int ItemId;

	// Token: 0x04006F03 RID: 28419
	private EHonamiStoryItemType ItemType = EHonamiStoryItemType.Normal;

	// Token: 0x04006F04 RID: 28420
	protected int Position;

	// Token: 0x04006F05 RID: 28421
	protected int QualityId = -1;

	// Token: 0x04006F06 RID: 28422
	protected int SubType = -1;

	// Token: 0x04006F07 RID: 28423
	protected int SellPrice = -1;

	// Token: 0x04006F08 RID: 28424
	protected bool IsCross;

	// Token: 0x04006F09 RID: 28425
	protected bool OldCross;

	// Token: 0x04006F0A RID: 28426
	protected bool IsDragCross;

	// Token: 0x04006F0B RID: 28427
	protected List<int> FillPositionList = new List<int>();

	// Token: 0x04006F0C RID: 28428
	protected int BackpackWidth;

	// Token: 0x04006F0D RID: 28429
	protected int FuncValue;

	// Token: 0x04006F0E RID: 28430
	protected bool IsSelected;

	// Token: 0x04006F0F RID: 28431
	protected int BaseWidth = -1;

	// Token: 0x04006F10 RID: 28432
	protected int BaseHeight = -1;

	// Token: 0x04006F11 RID: 28433
	protected bool IsNewInBackpack;
}
