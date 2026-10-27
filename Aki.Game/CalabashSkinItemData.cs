using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FB3 RID: 8115
public class CalabashSkinItemData : ItemDataBase
{
	// Token: 0x0600FD70 RID: 64880 RVA: 0x003D8B86 File Offset: 0x003D6D86
	public CalabashSkinItemData(int configId, int count, InventoryDefine.EItemDataType itemDataType) : base(configId, count, itemDataType)
	{
	}

	// Token: 0x0600FD71 RID: 64881 RVA: 0x003D8B91 File Offset: 0x003D6D91
	[NullableContext(2)]
	public override TItemConfig GetConfig()
	{
		return SkinConfig.Instance.GetCalabashSkinConfig(this.ConfigId);
	}

	// Token: 0x1700135B RID: 4955
	// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x003D8BA8 File Offset: 0x003D6DA8
	public CalabashSkin CalabashSkin
	{
		get
		{
			return this.GetConfig().As<CalabashSkin>().Value;
		}
	}

	// Token: 0x0600FD73 RID: 64883 RVA: 0x003D8BC8 File Offset: 0x003D6DC8
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		return new InventoryDefine.EItemMainTypeId?((InventoryDefine.EItemMainTypeId)this.CalabashSkin.MainTypeId);
	}

	// Token: 0x0600FD74 RID: 64884 RVA: 0x003D8BFC File Offset: 0x003D6DFC
	public override InventoryDefine.EItemType? GetType()
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		return new InventoryDefine.EItemType?((InventoryDefine.EItemType)this.CalabashSkin.ItemType);
	}

	// Token: 0x0600FD75 RID: 64885 RVA: 0x003D8C2E File Offset: 0x003D6E2E
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600FD76 RID: 64886 RVA: 0x003D8C34 File Offset: 0x003D6E34
	public override int GetQuality()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.CalabashSkin.QualityId;
	}

	// Token: 0x0600FD77 RID: 64887 RVA: 0x003D8C5C File Offset: 0x003D6E5C
	public override int GetSortIndex()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.CalabashSkin.SortIndex;
	}

	// Token: 0x0600FD78 RID: 64888 RVA: 0x003D8C84 File Offset: 0x003D6E84
	public override Span<int> GetItemAccess()
	{
		if (this.GetConfig() != null)
		{
			return this.CalabashSkin.GetItemAccessBytes();
		}
		return Span<int>.Empty;
	}

	// Token: 0x0600FD79 RID: 64889 RVA: 0x003D8CAD File Offset: 0x003D6EAD
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600FD7A RID: 64890 RVA: 0x003D8CB0 File Offset: 0x003D6EB0
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.CalabashSkin.RedDotDisableRule;
	}

	// Token: 0x0600FD7B RID: 64891 RVA: 0x003D8CCC File Offset: 0x003D6ECC
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600FD7C RID: 64892 RVA: 0x003D8CEC File Offset: 0x003D6EEC
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0600FD7D RID: 64893 RVA: 0x003D8CF0 File Offset: 0x003D6EF0
	public override bool GetIsShowUseButton()
	{
		return this.GetConfig().As<CalabashSkin>().Value.ShowUseButton;
	}

	// Token: 0x0600FD7E RID: 64894 RVA: 0x003D8D18 File Offset: 0x003D6F18
	protected override bool OnIsShowInInventory()
	{
		InventoryDefine.EItemType? type = this.GetType();
		InventoryDefine.EItemType eitemType = InventoryDefine.EItemType.Virtual;
		return !(type.GetValueOrDefault() == eitemType & type != null) && this.GetConfig().As<CalabashSkin>().Value.ShowInInventory;
	}

	// Token: 0x0600FD7F RID: 64895 RVA: 0x003D8D60 File Offset: 0x003D6F60
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
