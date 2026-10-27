using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x02001FB7 RID: 8119
public class PhantomItemData : AttributeItemData, IPhantomFilterData
{
	// Token: 0x0600FDC6 RID: 64966 RVA: 0x003D9418 File Offset: 0x003D7618
	public PhantomItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, uniqueId, functionValue, itemDataType)
	{
	}

	// Token: 0x0600FDC7 RID: 64967 RVA: 0x003D942C File Offset: 0x003D762C
	public void SetFetterGroupId(int id)
	{
		this.FetterGroupId = id;
	}

	// Token: 0x0600FDC8 RID: 64968 RVA: 0x003D9435 File Offset: 0x003D7635
	public void SetStackCount(int stackCount)
	{
		this.StackCount = stackCount;
	}

	// Token: 0x0600FDC9 RID: 64969 RVA: 0x003D943E File Offset: 0x003D763E
	public int GetStackCount()
	{
		return this.StackCount;
	}

	// Token: 0x0600FDCA RID: 64970 RVA: 0x003D9446 File Offset: 0x003D7646
	public bool IsStack()
	{
		return this.StackCount > 1;
	}

	// Token: 0x0600FDCB RID: 64971 RVA: 0x003D9451 File Offset: 0x003D7651
	public void SetAddTime(long addTime)
	{
		this.AddTime = addTime;
	}

	// Token: 0x0600FDCC RID: 64972 RVA: 0x003D945A File Offset: 0x003D765A
	public long GetAddTime()
	{
		return this.AddTime;
	}

	// Token: 0x0600FDCD RID: 64973 RVA: 0x003D9464 File Offset: 0x003D7664
	[NullableContext(1)]
	public override TItemConfig GetConfig()
	{
		PhantomItem? phantomItemConfig = InventoryConfig.Instance.GetPhantomItemConfig(this.ConfigId);
		if (phantomItemConfig == null)
		{
			return null;
		}
		return phantomItemConfig.GetValueOrDefault();
	}

	// Token: 0x1700135D RID: 4957
	// (get) Token: 0x0600FDCE RID: 64974 RVA: 0x003D949C File Offset: 0x003D769C
	public PhantomItem PhantomItem
	{
		get
		{
			return this.GetConfig().As<PhantomItem>().Value;
		}
	}

	// Token: 0x0600FDCF RID: 64975 RVA: 0x003D94BC File Offset: 0x003D76BC
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Phantom);
	}

	// Token: 0x0600FDD0 RID: 64976 RVA: 0x003D94C4 File Offset: 0x003D76C4
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Phantom);
	}

	// Token: 0x0600FDD1 RID: 64977 RVA: 0x003D94D0 File Offset: 0x003D76D0
	public override int GetQuality()
	{
		return this.PhantomItem.QualityId;
	}

	// Token: 0x0600FDD2 RID: 64978 RVA: 0x003D94EC File Offset: 0x003D76EC
	public override int GetSortIndex()
	{
		return this.PhantomItem.SortIndex;
	}

	// Token: 0x0600FDD3 RID: 64979 RVA: 0x003D9508 File Offset: 0x003D7708
	public override Span<int> GetItemAccess()
	{
		return this.PhantomItem.GetItemAccessBytes();
	}

	// Token: 0x0600FDD4 RID: 64980 RVA: 0x003D9523 File Offset: 0x003D7723
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600FDD5 RID: 64981 RVA: 0x003D9528 File Offset: 0x003D7728
	protected override void OnSetFunctionValue(int functionValue)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.UniqueId);
		if (phantomBattleData != null)
		{
			phantomBattleData.OnFunctionValueChange(functionValue);
		}
	}

	// Token: 0x0600FDD6 RID: 64982 RVA: 0x003D9550 File Offset: 0x003D7750
	[NullableContext(1)]
	public override string GetDefaultDownText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("VisionLevel"), null) ?? "";
	}

	// Token: 0x0600FDD7 RID: 64983 RVA: 0x003D9570 File Offset: 0x003D7770
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.PhantomItem.RedDotDisableRule;
	}

	// Token: 0x0600FDD8 RID: 64984 RVA: 0x003D958C File Offset: 0x003D778C
	public PhantomFetterGroup? GetFetterGroupConfig()
	{
		if (this.FetterGroupId != 0)
		{
			return new PhantomFetterGroup?(PhantomBattleConfig.Instance.GetFetterGroupById(this.FetterGroupId));
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.UniqueId);
		if (phantomBattleData == null)
		{
			return null;
		}
		return new PhantomFetterGroup?(phantomBattleData.GetFetterGroupConfig());
	}

	// Token: 0x0600FDD9 RID: 64985 RVA: 0x003D95E0 File Offset: 0x003D77E0
	[NullableContext(1)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		PhantomItem phantomItem = this.PhantomItem;
		InventoryModel instance = InventoryModel.Instance;
		int uniqueId = this.GetUniqueId();
		return new InventoryDefine.ItemViewDataInfo(phantomItem.ItemId, 1, 0, phantomItem.QualityId, this.GetIsLock(), this.GetIsDeprecated(), instance.IsNewAttributeItem(uniqueId), this.ItemDataType, this, instance.IsAttributeItemHasRedDot(uniqueId), viewMode, false, 0);
	}

	// Token: 0x04007594 RID: 30100
	private int FetterGroupId;

	// Token: 0x04007595 RID: 30101
	private int StackCount = 1;

	// Token: 0x04007596 RID: 30102
	private long AddTime;
}
