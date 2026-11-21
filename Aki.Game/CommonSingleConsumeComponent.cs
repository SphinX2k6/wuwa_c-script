using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CCA RID: 3274
[NullableContext(1)]
[Nullable(0)]
public class CommonSingleConsumeComponent : UiPanelBase
{
	// Token: 0x06008893 RID: 34963 RVA: 0x00296A85 File Offset: 0x00294C85
	public CommonSingleConsumeComponent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x00296AA4 File Offset: 0x00294CA4
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

	// Token: 0x06008895 RID: 34965 RVA: 0x00296B6C File Offset: 0x00294D6C
	protected override void OnStart()
	{
		this.StrengthItem = new ButtonItem(base.GetItem(5));
		this.ConsumeItem = new ConsumeItem(base.GetItem(4), null);
	}

	// Token: 0x06008896 RID: 34966 RVA: 0x00296BA6 File Offset: 0x00294DA6
	protected override void OnBeforeDestroy()
	{
		this.StrengthItem.Destroy(null);
		this.StrengthItem = null;
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x00296BBC File Offset: 0x00294DBC
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

	// Token: 0x06008898 RID: 34968 RVA: 0x00296C50 File Offset: 0x00294E50
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

	// Token: 0x06008899 RID: 34969 RVA: 0x00296C94 File Offset: 0x00294E94
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

	// Token: 0x0600889A RID: 34970 RVA: 0x00296D00 File Offset: 0x00294F00
	public void SetStrengthFunction(TCommonSingleConsumeFunction strengthFunction)
	{
		this.StrengthItem.SetFunction(delegate(int dataId)
		{
			strengthFunction(new int?(dataId));
		});
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x00296D31 File Offset: 0x00294F31
	public void SetStrengthItemLocalText(string textId, params object[] args)
	{
		this.StrengthItem.SetLocalText(textId, args);
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x00296D40 File Offset: 0x00294F40
	public void SetConsumeFunction(TCommonSingleConsumeFunction consumeFunction)
	{
		this.ConsumeItem.SetButtonFunction(delegate(int? dataId, int? _)
		{
			consumeFunction(dataId);
		});
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x00296D71 File Offset: 0x00294F71
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x04005232 RID: 21042
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x04005233 RID: 21043
	[Nullable(2)]
	protected ConsumeItem ConsumeItem;

	// Token: 0x04005234 RID: 21044
	protected bool EnoughMoney = true;

	// Token: 0x02006F85 RID: 28549
	[NullableContext(0)]
	private enum ECommonSingleConsumeComponent
	{
		// Token: 0x040246E5 RID: 149221
		ConsumeTexture,
		// Token: 0x040246E6 RID: 149222
		ConsumeText,
		// Token: 0x040246E7 RID: 149223
		OwnTexture,
		// Token: 0x040246E8 RID: 149224
		OwnText,
		// Token: 0x040246E9 RID: 149225
		MaterialItem,
		// Token: 0x040246EA RID: 149226
		StrengthItem,
		// Token: 0x040246EB RID: 149227
		CostRootItem,
		// Token: 0x040246EC RID: 149228
		MaterialRootItem
	}
}
