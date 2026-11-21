using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001475 RID: 5237
public class CalabashSkinItemData : ItemDataBase
{
	// Token: 0x0600D196 RID: 53654 RVA: 0x003E4562 File Offset: 0x003E2762
	public CalabashSkinItemData(int configId, int count, InventoryDefine.EItemDataType itemDataType) : base(configId, count, itemDataType)
	{
	}

	// Token: 0x0600D197 RID: 53655 RVA: 0x003E456D File Offset: 0x003E276D
	[NullableContext(2)]
	public override TItemConfig GetConfig()
	{
		return SkinConfig.Instance.GetCalabashSkinConfig(this.ConfigId);
	}

	// Token: 0x17001387 RID: 4999
	// (get) Token: 0x0600D198 RID: 53656 RVA: 0x003E4584 File Offset: 0x003E2784
	public CalabashSkin CalabashSkin
	{
		get
		{
			return this.GetConfig().As<CalabashSkin>().Value;
		}
	}

	// Token: 0x0600D199 RID: 53657 RVA: 0x003E45A4 File Offset: 0x003E27A4
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		return new InventoryDefine.EItemMainTypeId?((InventoryDefine.EItemMainTypeId)this.CalabashSkin.MainTypeId);
	}

	// Token: 0x0600D19A RID: 53658 RVA: 0x003E45D8 File Offset: 0x003E27D8
	public override InventoryDefine.EItemType? GetType()
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		return new InventoryDefine.EItemType?((InventoryDefine.EItemType)this.CalabashSkin.ItemType);
	}

	// Token: 0x0600D19B RID: 53659 RVA: 0x003E460A File Offset: 0x003E280A
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600D19C RID: 53660 RVA: 0x003E4610 File Offset: 0x003E2810
	public override int GetQuality()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.CalabashSkin.QualityId;
	}

	// Token: 0x0600D19D RID: 53661 RVA: 0x003E4638 File Offset: 0x003E2838
	public override int GetSortIndex()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.CalabashSkin.SortIndex;
	}

	// Token: 0x0600D19E RID: 53662 RVA: 0x003E4660 File Offset: 0x003E2860
	public override Span<int> GetItemAccess()
	{
		if (this.GetConfig() != null)
		{
			return this.CalabashSkin.GetItemAccessBytes();
		}
		return Span<int>.Empty;
	}

	// Token: 0x0600D19F RID: 53663 RVA: 0x003E4689 File Offset: 0x003E2889
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600D1A0 RID: 53664 RVA: 0x003E468C File Offset: 0x003E288C
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.CalabashSkin.RedDotDisableRule;
	}

	// Token: 0x0600D1A1 RID: 53665 RVA: 0x003E46A8 File Offset: 0x003E28A8
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600D1A2 RID: 53666 RVA: 0x003E46C8 File Offset: 0x003E28C8
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0600D1A3 RID: 53667 RVA: 0x003E46CC File Offset: 0x003E28CC
	public override bool GetIsShowUseButton()
	{
		return this.GetConfig().As<CalabashSkin>().Value.ShowUseButton;
	}

	// Token: 0x0600D1A4 RID: 53668 RVA: 0x003E46F4 File Offset: 0x003E28F4
	protected override bool OnIsShowInInventory()
	{
		InventoryDefine.EItemType? type = this.GetType();
		InventoryDefine.EItemType eitemType = InventoryDefine.EItemType.Virtual;
		return !(type.GetValueOrDefault() == eitemType & type != null) && this.GetConfig().As<CalabashSkin>().Value.ShowInInventory;
	}

	// Token: 0x0600D1A5 RID: 53669 RVA: 0x003E473C File Offset: 0x003E293C
	[NullableContext(1)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		CalabashSkin value = this.GetConfig().As<CalabashSkin>().Value;
		InventoryModel instance = InventoryModel.Instance;
		int uniqueId = this.GetUniqueId();
		return new InventoryDefine.ItemViewDataInfo(value.Id, 1, 0, value.QualityId, this.GetIsLock(), this.GetIsDeprecated(), instance.IsNewAttributeItem(uniqueId), this.ItemDataType, this, instance.IsCommonItemHasRedDot(uniqueId, 0), viewMode, false, 0);
	}
}
