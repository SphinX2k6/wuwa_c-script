using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x02001479 RID: 5241
public class PhantomItemData : AttributeItemData, IPhantomFilterData
{
	// Token: 0x0600D1EC RID: 53740 RVA: 0x003E4DF4 File Offset: 0x003E2FF4
	public PhantomItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, uniqueId, functionValue, itemDataType)
	{
	}

	// Token: 0x0600D1ED RID: 53741 RVA: 0x003E4E08 File Offset: 0x003E3008
	public void SetFetterGroupId(int id)
	{
		this.FetterGroupId = id;
	}

	// Token: 0x0600D1EE RID: 53742 RVA: 0x003E4E11 File Offset: 0x003E3011
	public void SetStackCount(int stackCount)
	{
		this.StackCount = stackCount;
	}

	// Token: 0x0600D1EF RID: 53743 RVA: 0x003E4E1A File Offset: 0x003E301A
	public int GetStackCount()
	{
		return this.StackCount;
	}

	// Token: 0x0600D1F0 RID: 53744 RVA: 0x003E4E22 File Offset: 0x003E3022
	public bool IsStack()
	{
		return this.StackCount > 1;
	}

	// Token: 0x0600D1F1 RID: 53745 RVA: 0x003E4E2D File Offset: 0x003E302D
	public void SetAddTime(long addTime)
	{
		this.AddTime = addTime;
	}

	// Token: 0x0600D1F2 RID: 53746 RVA: 0x003E4E36 File Offset: 0x003E3036
	public long GetAddTime()
	{
		return this.AddTime;
	}

	// Token: 0x0600D1F3 RID: 53747 RVA: 0x003E4E40 File Offset: 0x003E3040
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

	// Token: 0x17001389 RID: 5001
	// (get) Token: 0x0600D1F4 RID: 53748 RVA: 0x003E4E78 File Offset: 0x003E3078
	public PhantomItem PhantomItem
	{
		get
		{
			return this.GetConfig().As<PhantomItem>().Value;
		}
	}

	// Token: 0x0600D1F5 RID: 53749 RVA: 0x003E4E98 File Offset: 0x003E3098
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Phantom);
	}

	// Token: 0x0600D1F6 RID: 53750 RVA: 0x003E4EA0 File Offset: 0x003E30A0
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Phantom);
	}

	// Token: 0x0600D1F7 RID: 53751 RVA: 0x003E4EAC File Offset: 0x003E30AC
	public override int GetQuality()
	{
		return this.PhantomItem.QualityId;
	}

	// Token: 0x0600D1F8 RID: 53752 RVA: 0x003E4EC8 File Offset: 0x003E30C8
	public override int GetSortIndex()
	{
		return this.PhantomItem.SortIndex;
	}

	// Token: 0x0600D1F9 RID: 53753 RVA: 0x003E4EE4 File Offset: 0x003E30E4
	public override Span<int> GetItemAccess()
	{
		return this.PhantomItem.GetItemAccessBytes();
	}

	// Token: 0x0600D1FA RID: 53754 RVA: 0x003E4EFF File Offset: 0x003E30FF
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600D1FB RID: 53755 RVA: 0x003E4F04 File Offset: 0x003E3104
	protected override void OnSetFunctionValue(int functionValue)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.UniqueId);
		if (phantomBattleData != null)
		{
			phantomBattleData.OnFunctionValueChange(functionValue);
		}
	}

	// Token: 0x0600D1FC RID: 53756 RVA: 0x003E4F2C File Offset: 0x003E312C
	[NullableContext(1)]
	public override string GetDefaultDownText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("VisionLevel"), null) ?? "";
	}

	// Token: 0x0600D1FD RID: 53757 RVA: 0x003E4F4C File Offset: 0x003E314C
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.PhantomItem.RedDotDisableRule;
	}

	// Token: 0x0600D1FE RID: 53758 RVA: 0x003E4F68 File Offset: 0x003E3168
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

	// Token: 0x0600D1FF RID: 53759 RVA: 0x003E4FBC File Offset: 0x003E31BC
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

	// Token: 0x04007676 RID: 30326
	private int FetterGroupId;

	// Token: 0x04007677 RID: 30327
	private int StackCount = 1;

	// Token: 0x04007678 RID: 30328
	private long AddTime;
}
