using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FC8 RID: 8136
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InventoryGiftItem : GridProxyAbstract<GiftItemData>
{
	// Token: 0x0600FE75 RID: 65141 RVA: 0x003DC5EF File Offset: 0x003DA7EF
	public void Initialize(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600FE76 RID: 65142 RVA: 0x003DC600 File Offset: 0x003DA800
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickReduce));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FE77 RID: 65143 RVA: 0x003DC72C File Offset: 0x003DA92C
	private void OnClickReduce()
	{
		this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ReduceButton.RootUIComp.Get().SetUIActive(false);
		if (this.OnReduceFunction != null)
		{
			this.OnReduceFunction(this.ItemData);
		}
	}

	// Token: 0x0600FE78 RID: 65144 RVA: 0x003DC77C File Offset: 0x003DA97C
	private void OnToggleStateChange(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		if (this.ReduceButton != null)
		{
			this.ReduceButton.RootUIComp.Get().SetUIActive(flag);
		}
		if (this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(this.Toggle, this.ReduceButton, flag, this.ItemData);
		}
	}

	// Token: 0x0600FE79 RID: 65145 RVA: 0x003DC7D5 File Offset: 0x003DA9D5
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x0600FE7A RID: 65146 RVA: 0x003DC7DD File Offset: 0x003DA9DD
	protected override void OnBeforeDestroy()
	{
		this.ItemNameText = null;
		this.ItemCountText = null;
		this.ReduceButton = null;
		this.ItemConfigId = null;
		this.Toggle = null;
		this.ItemData = null;
		this.ItemGrid = null;
		this.WeaponTypeIcon = null;
	}

	// Token: 0x0600FE7B RID: 65147 RVA: 0x003DC81C File Offset: 0x003DAA1C
	private void InitView()
	{
		this.ItemNameText = base.GetText(1);
		this.ItemCountText = base.GetText(2);
		this.Toggle = base.GetExtendToggle(4);
		this.Toggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		this.ReduceButton = base.GetButton(3);
		this.ReduceButton.RootUIComp.Get().SetUIActive(false);
		this.ItemGrid = new InventoryGiftCellItem();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.WeaponTypeIcon = base.GetSprite(5);
		this.WeaponTypeIcon.SetUIActive(false);
	}

	// Token: 0x0600FE7C RID: 65148 RVA: 0x003DC8CD File Offset: 0x003DAACD
	[NullableContext(1)]
	public override void Refresh(GiftItemData data, bool isSelect, int gridIndex)
	{
		this.ItemData = data;
		this.RefreshItem(data);
		if (this.IsSelectOn != null)
		{
			this.SetSelected(this.IsSelectOn(data), false);
		}
	}

	// Token: 0x0600FE7D RID: 65149 RVA: 0x003DC8F8 File Offset: 0x003DAAF8
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOn != null && this.ItemData != null)
		{
			this.SetSelected(this.IsSelectOn(this.ItemData), false);
		}
	}

	// Token: 0x0600FE7E RID: 65150 RVA: 0x003DC924 File Offset: 0x003DAB24
	[NullableContext(1)]
	public void RefreshItem(GiftItemData data)
	{
		this.ItemConfigId = new int?(data.ItemId);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemConfigId.Value);
		string newText = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null) ?? "";
		this.ItemNameText.SetText(newText, true);
		LguiUtil.Instance.SetLocalText(this.ItemCountText, "Quantity", new <>z__ReadOnlySingleElementList<object>(data.ItemCount));
		this.ItemGrid.RefreshByConfigId(data);
		this.WeaponTypeIcon.SetUIActive(false);
		if (itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Weapon)
		{
			IEnumerable<Mapping> weaponConfList = MappingConfig.Instance.GetWeaponConfList();
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.ItemConfigId.Value);
			foreach (Mapping mapping in weaponConfList)
			{
				if (weaponConfigByItemId.Value.WeaponType == mapping.Value)
				{
					this.WeaponTypeIcon.SetUIActive(true);
					this.SetSpriteByPath(mapping.Icon, this.WeaponTypeIcon, false, null, null);
					break;
				}
			}
		}
	}

	// Token: 0x0600FE7F RID: 65151 RVA: 0x003DCA60 File Offset: 0x003DAC60
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		this.Toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		this.ReduceButton.RootUIComp.Get().SetUIActive(bSelectOn);
	}

	// Token: 0x0600FE80 RID: 65152 RVA: 0x003DCA9C File Offset: 0x003DAC9C
	public void RefreshSelectState()
	{
		if (this.IsSelectOn != null && this.ItemData != null)
		{
			this.SetSelected(this.IsSelectOn(this.ItemData), false);
		}
	}

	// Token: 0x0600FE81 RID: 65153 RVA: 0x003DCAC6 File Offset: 0x003DACC6
	[NullableContext(1)]
	public void SetOnToggleStateChangeFunction(Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData> onToggleStateChangeFunction)
	{
		this.OnToggleStateChangeFunction = onToggleStateChangeFunction;
	}

	// Token: 0x0600FE82 RID: 65154 RVA: 0x003DCACF File Offset: 0x003DACCF
	[NullableContext(1)]
	public void SetOnReduceFunction(Action<GiftItemData> onReduceFunction)
	{
		this.OnReduceFunction = onReduceFunction;
	}

	// Token: 0x0600FE83 RID: 65155 RVA: 0x003DCAD8 File Offset: 0x003DACD8
	[NullableContext(1)]
	public void SetIsSelectOn(Func<GiftItemData, bool> isSelectOnFunction)
	{
		this.IsSelectOn = isSelectOnFunction;
	}

	// Token: 0x040075BB RID: 30139
	private UUIText ItemNameText;

	// Token: 0x040075BC RID: 30140
	private UUIText ItemCountText;

	// Token: 0x040075BD RID: 30141
	private UUIButtonComponent ReduceButton;

	// Token: 0x040075BE RID: 30142
	private int? ItemConfigId;

	// Token: 0x040075BF RID: 30143
	private UUIExtendToggle Toggle;

	// Token: 0x040075C0 RID: 30144
	private GiftItemData ItemData;

	// Token: 0x040075C1 RID: 30145
	private InventoryGiftCellItem ItemGrid;

	// Token: 0x040075C2 RID: 30146
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData> OnToggleStateChangeFunction;

	// Token: 0x040075C3 RID: 30147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GiftItemData> OnReduceFunction;

	// Token: 0x040075C4 RID: 30148
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<GiftItemData, bool> IsSelectOn;

	// Token: 0x040075C5 RID: 30149
	private UUISprite WeaponTypeIcon;

	// Token: 0x020085D9 RID: 34265
	[NullableContext(0)]
	private enum EInventoryGiftItemType
	{
		// Token: 0x0402B91C RID: 178460
		ItemGridItem,
		// Token: 0x0402B91D RID: 178461
		ItemNameText,
		// Token: 0x0402B91E RID: 178462
		ItemCountText,
		// Token: 0x0402B91F RID: 178463
		ReduceButton,
		// Token: 0x0402B920 RID: 178464
		Toggle,
		// Token: 0x0402B921 RID: 178465
		WeaponTypeIcon
	}
}
