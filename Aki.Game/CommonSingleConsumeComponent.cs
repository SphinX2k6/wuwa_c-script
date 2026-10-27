using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001811 RID: 6161
[NullableContext(1)]
[Nullable(0)]
public class CommonSingleConsumeComponent : UiPanelBase
{
	// Token: 0x0600B4A8 RID: 46248 RVA: 0x0028C365 File Offset: 0x0028A565
	public CommonSingleConsumeComponent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B4A9 RID: 46249 RVA: 0x0028C384 File Offset: 0x0028A584
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x0600B4AA RID: 46250 RVA: 0x0028C44C File Offset: 0x0028A64C
	protected override void OnStart()
	{
		this.StrengthItem = new ButtonItem(base.GetItem(5));
		this.ConsumeItem = new ConsumeItem(base.GetItem(4), null);
	}

	// Token: 0x0600B4AB RID: 46251 RVA: 0x0028C486 File Offset: 0x0028A686
	protected override void OnBeforeDestroy()
	{
		this.StrengthItem.Destroy(null);
		this.StrengthItem = null;
	}

	// Token: 0x0600B4AC RID: 46252 RVA: 0x0028C49C File Offset: 0x0028A69C
	[NullableContext(2)]
	public void UpdateComponent(int moneyId, int costCount, TCommonSingleConsumeData singleConsumeData)
	{
		this.SetMaxState(false);
		ConsumeItemData data = null;
		if (singleConsumeData != null)
		{
			data = ConsumeItemUtil.GetConsumeItemData(singleConsumeData.ItemData, singleConsumeData.Count);
		}
		this.ConsumeItem.UpdateItem(data);
		UUIText text = base.GetText(1);
		UUITexture texture = base.GetTexture(0);
		UUIText text2 = base.GetText(3);
		int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(moneyId);
		this.EnoughMoney = UiComponentUtil.SetMoneyState(text, text2, costCount, playerMoney);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(moneyId);
		base.SetTextureByPath(itemConfigData.Icon, texture, null, null);
	}

	// Token: 0x0600B4AD RID: 46253 RVA: 0x0028C530 File Offset: 0x0028A730
	[NullableContext(2)]
	public void UpdateComponentOnlyConsume(TCommonSingleConsumeData singleConsumeData)
	{
		this.SetMaxState(false);
		base.GetItem(6).SetUIActive(false);
		ConsumeItemData data = null;
		if (singleConsumeData != null)
		{
			data = ConsumeItemUtil.GetConsumeItemData(singleConsumeData.ItemData, singleConsumeData.Count);
		}
		this.ConsumeItem.UpdateItem(data);
	}

	// Token: 0x0600B4AE RID: 46254 RVA: 0x0028C574 File Offset: 0x0028A774
	public void SetMaxState(bool inMax)
	{
		base.GetItem(6).SetUIActive(!inMax);
		base.GetItem(7).SetUIActive(!inMax);
		this.StrengthItem.SetEnableClick(!inMax);
		if (inMax)
		{
			this.StrengthItem.SetLocalText("ReachMaxLevelStage", Array.Empty<object>());
			return;
		}
		this.StrengthItem.SetLocalText("WeaponResonanceText", Array.Empty<object>());
	}

	// Token: 0x0600B4AF RID: 46255 RVA: 0x0028C5E0 File Offset: 0x0028A7E0
	public void SetStrengthFunction(TCommonSingleConsumeFunction strengthFunction)
	{
		this.StrengthItem.SetFunction(delegate(int dataId)
		{
			strengthFunction(new int?(dataId));
		});
	}

	// Token: 0x0600B4B0 RID: 46256 RVA: 0x0028C611 File Offset: 0x0028A811
	public void SetStrengthItemLocalText(string textId, params object[] args)
	{
		this.StrengthItem.SetLocalText(textId, args);
	}

	// Token: 0x0600B4B1 RID: 46257 RVA: 0x0028C620 File Offset: 0x0028A820
	public void SetConsumeFunction(TCommonSingleConsumeFunction consumeFunction)
	{
		this.ConsumeItem.SetButtonFunction(delegate(int? dataId, int? _)
		{
			consumeFunction(dataId);
		});
	}

	// Token: 0x0600B4B2 RID: 46258 RVA: 0x0028C651 File Offset: 0x0028A851
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x04005187 RID: 20871
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x04005188 RID: 20872
	[Nullable(2)]
	protected ConsumeItem ConsumeItem;

	// Token: 0x04005189 RID: 20873
	protected bool EnoughMoney = true;

	// Token: 0x02007DFF RID: 32255
	[NullableContext(0)]
	private enum ECommonSingleConsumeComponent
	{
		// Token: 0x040293BA RID: 168890
		ConsumeTexture,
		// Token: 0x040293BB RID: 168891
		ConsumeText,
		// Token: 0x040293BC RID: 168892
		OwnTexture,
		// Token: 0x040293BD RID: 168893
		OwnText,
		// Token: 0x040293BE RID: 168894
		MaterialItem,
		// Token: 0x040293BF RID: 168895
		StrengthItem,
		// Token: 0x040293C0 RID: 168896
		CostRootItem,
		// Token: 0x040293C1 RID: 168897
		MaterialRootItem
	}
}
