using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001FB6 RID: 8118
public class OrnamentItemData : ItemDataBase
{
	// Token: 0x1700135C RID: 4956
	// (get) Token: 0x0600FDB6 RID: 64950 RVA: 0x003D923C File Offset: 0x003D743C
	public Ornament Ornament
	{
		get
		{
			return this.GetConfig().As<Ornament>().Value;
		}
	}

	// Token: 0x0600FDB7 RID: 64951 RVA: 0x003D925C File Offset: 0x003D745C
	public OrnamentItemData(int configId, int count, InventoryDefine.EItemDataType itemDataType) : base(configId, count, itemDataType)
	{
	}

	// Token: 0x0600FDB8 RID: 64952 RVA: 0x003D9268 File Offset: 0x003D7468
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

	// Token: 0x0600FDB9 RID: 64953 RVA: 0x003D929D File Offset: 0x003D749D
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Special);
	}

	// Token: 0x0600FDBA RID: 64954 RVA: 0x003D92A5 File Offset: 0x003D74A5
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Ornament);
	}

	// Token: 0x0600FDBB RID: 64955 RVA: 0x003D92AE File Offset: 0x003D74AE
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600FDBC RID: 64956 RVA: 0x003D92B4 File Offset: 0x003D74B4
	public override int GetQuality()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.Ornament.QualityId;
	}

	// Token: 0x0600FDBD RID: 64957 RVA: 0x003D92DC File Offset: 0x003D74DC
	public override int GetSortIndex()
	{
		if (this.GetConfig() == null)
		{
			return 0;
		}
		return this.Ornament.SortIndex;
	}

	// Token: 0x0600FDBE RID: 64958 RVA: 0x003D9304 File Offset: 0x003D7504
	public override Span<int> GetItemAccess()
	{
		if (this.GetConfig() == null)
		{
			return Span<int>.Empty;
		}
		return this.Ornament.GetItemAccessArray();
	}

	// Token: 0x0600FDBF RID: 64959 RVA: 0x003D9332 File Offset: 0x003D7532
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600FDC0 RID: 64960 RVA: 0x003D9338 File Offset: 0x003D7538
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.Ornament.RedDotDisableRule;
	}

	// Token: 0x0600FDC1 RID: 64961 RVA: 0x003D9354 File Offset: 0x003D7554
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600FDC2 RID: 64962 RVA: 0x003D9374 File Offset: 0x003D7574
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0600FDC3 RID: 64963 RVA: 0x003D9378 File Offset: 0x003D7578
	public override bool GetIsShowUseButton()
	{
		return this.Ornament.ShowUseButton && RoleOrnamentModel.Instance.IsOwnOrnament(this.ConfigId);
	}

	// Token: 0x0600FDC4 RID: 64964 RVA: 0x003D93A7 File Offset: 0x003D75A7
	protected override bool OnIsShowInInventory()
	{
		return true;
	}

	// Token: 0x0600FDC5 RID: 64965 RVA: 0x003D93AC File Offset: 0x003D75AC
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
