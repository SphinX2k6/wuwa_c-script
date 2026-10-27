using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001813 RID: 6163
[NullableContext(2)]
[Nullable(0)]
public class ConsumeItem : GridProxyAbstract<TCommonMultipleConsumeData>
{
	// Token: 0x0600B4B7 RID: 46263 RVA: 0x0028C659 File Offset: 0x0028A859
	public ConsumeItem(UUIItem uiItem = null, EUiViewName? belongView = null)
	{
		this.BelongView = belongView;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600B4B8 RID: 46264 RVA: 0x0028C678 File Offset: 0x0028A878
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B4B9 RID: 46265 RVA: 0x0028C82C File Offset: 0x0028AA2C
	private void ButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			TConsumeItemFunction buttonFunction = this.ButtonFunction;
			ConsumeItemData data = this.Data;
			int? incId = (data != null) ? new int?(data.IncId) : null;
			ConsumeItemData data2 = this.Data;
			buttonFunction(incId, (data2 != null) ? new int?(data2.ItemId) : null);
		}
	}

	// Token: 0x0600B4BA RID: 46266 RVA: 0x0028C88C File Offset: 0x0028AA8C
	protected void SetIconState()
	{
		InventoryDefine.GetItemData getItemData = new InventoryDefine.GetItemData(this.Data.ItemId, this.Data.IncId);
		ItemDataBase itemDataBase = InventoryModel.Instance.GetItemDataBase(getItemData)[0];
		UUITexture texture = base.GetTexture(4);
		base.SetItemIcon(texture, itemDataBase.GetConfigId(), this.BelongView, null);
		UUISprite sprite = base.GetSprite(5);
		base.SetItemQualityIcon(sprite, itemDataBase.GetConfigId(), this.BelongView, CommonDefine.EQualityIconType.BackgroundSprite, null);
		UUIText text = base.GetText(6);
		UUIItem item = base.GetItem(7);
		if (this.Data.ResonanceLevel != 0)
		{
			item.SetUIActive(true);
			text.SetText(this.Data.ResonanceLevel.ToString(), true);
		}
		else
		{
			item.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (!string.IsNullOrEmpty(this.Data.ChipPath))
		{
			sprite2.SetUIActive(true);
			this.SetSpriteByPath(this.Data.ChipPath, sprite2, false, null, null);
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x0600B4BB RID: 46267 RVA: 0x0028C994 File Offset: 0x0028AB94
	public override void Refresh(TCommonMultipleConsumeData data, bool isSelected, int gridIndex)
	{
		ConsumeItemData data2 = null;
		if (data.ItemData != null)
		{
			data2 = ConsumeItemUtil.GetConsumeItemData(data.ItemData, data.Count);
		}
		this.UpdateItem(data2);
	}

	// Token: 0x0600B4BC RID: 46268 RVA: 0x0028C9C8 File Offset: 0x0028ABC8
	public void UpdateItem(ConsumeItemData data)
	{
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(2);
		if (data == null)
		{
			this.Data = data;
			item.SetUIActive(true);
			item2.SetUIActive(false);
			return;
		}
		this.Data = data;
		this.SetIconState();
		item.SetUIActive(false);
		item2.SetUIActive(true);
		base.GetText(8).SetText(this.Data.BottomText, true);
	}

	// Token: 0x0600B4BD RID: 46269 RVA: 0x0028CA31 File Offset: 0x0028AC31
	[NullableContext(1)]
	public void SetButtonFunction(TConsumeItemFunction buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x0400518A RID: 20874
	protected ConsumeItemData Data;

	// Token: 0x0400518B RID: 20875
	protected TConsumeItemFunction ButtonFunction;

	// Token: 0x0400518C RID: 20876
	public EUiViewName? BelongView;

	// Token: 0x02007E02 RID: 32258
	[NullableContext(0)]
	private class EConsumeItem
	{
		// Token: 0x040293C4 RID: 168900
		public const int SelectedSprite = 0;

		// Token: 0x040293C5 RID: 168901
		public const int EmptyItem = 1;

		// Token: 0x040293C6 RID: 168902
		public const int MaterialItem = 2;

		// Token: 0x040293C7 RID: 168903
		public const int ChipSprite = 3;

		// Token: 0x040293C8 RID: 168904
		public const int IconTexture = 4;

		// Token: 0x040293C9 RID: 168905
		public const int QualitySprite = 5;

		// Token: 0x040293CA RID: 168906
		public const int ResonanceText = 6;

		// Token: 0x040293CB RID: 168907
		public const int ResonanceItem = 7;

		// Token: 0x040293CC RID: 168908
		public const int BottomText = 8;

		// Token: 0x040293CD RID: 168909
		public const int Button = 9;
	}
}
