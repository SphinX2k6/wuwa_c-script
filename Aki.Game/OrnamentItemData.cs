using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001478 RID: 5240
public class OrnamentItemData : ItemDataBase
{
	// Token: 0x17001388 RID: 5000
	// (get) Token: 0x0600D1DC RID: 53724 RVA: 0x003E4C18 File Offset: 0x003E2E18
	public Ornament Ornament
	{
		get
		{
			return this.GetConfig().As<Ornament>().Value;
		}
	}

	// Token: 0x0600D1DD RID: 53725 RVA: 0x003E4C38 File Offset: 0x003E2E38
	public OrnamentItemData(int configId, int count, InventoryDefine.EItemDataType itemDataType) : base(configId, count, itemDataType)
	{
	}

	// Token: 0x0600D1DE RID: 53726 RVA: 0x003E4C44 File Offset: 0x003E2E44
	[NullableContext(2)]
	public override TItemConfig GetConfig()
	{
		Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(this.ConfigId);
		if (ornamentConfig == null)
		{
			return null;
		}
		return ornamentConfig.GetValueOrDefault();
	}

	// Token: 0x0600D1DF RID: 53727 RVA: 0x003E4C79 File Offset: 0x003E2E79
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Special);
	}

	// Token: 0x0600D1E0 RID: 53728 RVA: 0x003E4C81 File Offset: 0x003E2E81
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Ornament);
	}

	// Token: 0x0600D1E1 RID: 53729 RVA: 0x003E4C8A File Offset: 0x003E2E8A
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600D1E2 RID: 53730 RVA: 0x003E4C90 File Offset: 0x003E2E90
	public override int GetQuality()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.Ornament.QualityId;
	}

	// Token: 0x0600D1E3 RID: 53731 RVA: 0x003E4CB8 File Offset: 0x003E2EB8
	public override int GetSortIndex()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.Ornament.SortIndex;
	}

	// Token: 0x0600D1E4 RID: 53732 RVA: 0x003E4CE0 File Offset: 0x003E2EE0
	public override Span<int> GetItemAccess()
	{
		if (this.GetConfig() == null)
		{
			return Span<int>.Empty;
		}
		return this.Ornament.GetItemAccessArray();
	}

	// Token: 0x0600D1E5 RID: 53733 RVA: 0x003E4D0E File Offset: 0x003E2F0E
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600D1E6 RID: 53734 RVA: 0x003E4D14 File Offset: 0x003E2F14
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.Ornament.RedDotDisableRule;
	}

	// Token: 0x0600D1E7 RID: 53735 RVA: 0x003E4D30 File Offset: 0x003E2F30
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600D1E8 RID: 53736 RVA: 0x003E4D50 File Offset: 0x003E2F50
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0600D1E9 RID: 53737 RVA: 0x003E4D54 File Offset: 0x003E2F54
	public override bool GetIsShowUseButton()
	{
		return this.Ornament.ShowUseButton && RoleOrnamentModel.Instance.IsOwnOrnament(this.ConfigId);
	}

	// Token: 0x0600D1EA RID: 53738 RVA: 0x003E4D83 File Offset: 0x003E2F83
	protected override bool OnIsShowInInventory()
	{
		return true;
	}

	// Token: 0x0600D1EB RID: 53739 RVA: 0x003E4D88 File Offset: 0x003E2F88
	[NullableContext(1)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		InventoryModel instance = InventoryModel.Instance;
		int uniqueId = this.GetUniqueId();
		return new InventoryDefine.ItemViewDataInfo(this.Ornament.Id, 1, 0, this.Ornament.QualityId, this.GetIsLock(), this.GetIsDeprecated(), instance.IsNewAttributeItem(uniqueId), this.ItemDataType, this, instance.IsCommonItemHasRedDot(uniqueId, 0), viewMode, false, 0);
	}
}
