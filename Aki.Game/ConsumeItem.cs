using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CCC RID: 3276
[NullableContext(2)]
[Nullable(0)]
public class ConsumeItem : GridProxyAbstract<TCommonMultipleConsumeData>
{
	// Token: 0x060088A2 RID: 34978 RVA: 0x00296D79 File Offset: 0x00294F79
	public ConsumeItem(UUIItem uiItem = null, EUiViewName? belongView = null)
	{
		this.BelongView = belongView;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x00296D98 File Offset: 0x00294F98
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

	// Token: 0x060088A4 RID: 34980 RVA: 0x00296F4C File Offset: 0x0029514C
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

	// Token: 0x060088A5 RID: 34981 RVA: 0x00296FAC File Offset: 0x002951AC
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

	// Token: 0x060088A6 RID: 34982 RVA: 0x002970B4 File Offset: 0x002952B4
	public override void Refresh(TCommonMultipleConsumeData data, bool isSelected, int gridIndex)
	{
		ConsumeItemData data2 = null;
		if (data.ItemData != null)
		{
			data2 = ConsumeItemUtil.GetConsumeItemData(data.ItemData, data.Count);
		}
		this.UpdateItem(data2);
	}

	// Token: 0x060088A7 RID: 34983 RVA: 0x002970E8 File Offset: 0x002952E8
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

	// Token: 0x060088A8 RID: 34984 RVA: 0x00297151 File Offset: 0x00295351
	[NullableContext(1)]
	public void SetButtonFunction(TConsumeItemFunction buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x04005235 RID: 21045
	protected ConsumeItemData Data;

	// Token: 0x04005236 RID: 21046
	protected TConsumeItemFunction ButtonFunction;

	// Token: 0x04005237 RID: 21047
	public EUiViewName? BelongView;

	// Token: 0x02006F88 RID: 28552
	[NullableContext(0)]
	private class EConsumeItem
	{
		// Token: 0x040246EF RID: 149231
		public const int SelectedSprite = 0;

		// Token: 0x040246F0 RID: 149232
		public const int EmptyItem = 1;

		// Token: 0x040246F1 RID: 149233
		public const int MaterialItem = 2;

		// Token: 0x040246F2 RID: 149234
		public const int ChipSprite = 3;

		// Token: 0x040246F3 RID: 149235
		public const int IconTexture = 4;

		// Token: 0x040246F4 RID: 149236
		public const int QualitySprite = 5;

		// Token: 0x040246F5 RID: 149237
		public const int ResonanceText = 6;

		// Token: 0x040246F6 RID: 149238
		public const int ResonanceItem = 7;

		// Token: 0x040246F7 RID: 149239
		public const int BottomText = 8;

		// Token: 0x040246F8 RID: 149240
		public const int Button = 9;
	}
}
