using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200149B RID: 5275
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InventoryGiftItem : GridProxyAbstract<GiftItemData>
{
	// Token: 0x0600D2DD RID: 53981 RVA: 0x003E8BCB File Offset: 0x003E6DCB
	public void Initialize(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600D2DE RID: 53982 RVA: 0x003E8BDC File Offset: 0x003E6DDC
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

	// Token: 0x0600D2DF RID: 53983 RVA: 0x003E8D08 File Offset: 0x003E6F08
	private void OnClickReduce()
	{
		this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ReduceButton.RootUIComp.Get().SetUIActive(false);
		if (this.OnReduceFunction != null)
		{
			this.OnReduceFunction(this.ItemData);
		}
	}

	// Token: 0x0600D2E0 RID: 53984 RVA: 0x003E8D58 File Offset: 0x003E6F58
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

	// Token: 0x0600D2E1 RID: 53985 RVA: 0x003E8DB1 File Offset: 0x003E6FB1
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x0600D2E2 RID: 53986 RVA: 0x003E8DB9 File Offset: 0x003E6FB9
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

	// Token: 0x0600D2E3 RID: 53987 RVA: 0x003E8DF8 File Offset: 0x003E6FF8
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

	// Token: 0x0600D2E4 RID: 53988 RVA: 0x003E8EA9 File Offset: 0x003E70A9
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

	// Token: 0x0600D2E5 RID: 53989 RVA: 0x003E8ED4 File Offset: 0x003E70D4
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOn != null && this.ItemData != null)
		{
			this.SetSelected(this.IsSelectOn(this.ItemData), false);
		}
	}

	// Token: 0x0600D2E6 RID: 53990 RVA: 0x003E8F00 File Offset: 0x003E7100
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

	// Token: 0x0600D2E7 RID: 53991 RVA: 0x003E903C File Offset: 0x003E723C
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		this.Toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		this.ReduceButton.RootUIComp.Get().SetUIActive(bSelectOn);
	}

	// Token: 0x0600D2E8 RID: 53992 RVA: 0x003E9078 File Offset: 0x003E7278
	public void RefreshSelectState()
	{
		if (this.IsSelectOn != null && this.ItemData != null)
		{
			this.SetSelected(this.IsSelectOn(this.ItemData), false);
		}
	}

	// Token: 0x0600D2E9 RID: 53993 RVA: 0x003E90A2 File Offset: 0x003E72A2
	[NullableContext(1)]
	public void SetOnToggleStateChangeFunction(Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData> onToggleStateChangeFunction)
	{
		this.OnToggleStateChangeFunction = onToggleStateChangeFunction;
	}

	// Token: 0x0600D2EA RID: 53994 RVA: 0x003E90AB File Offset: 0x003E72AB
	[NullableContext(1)]
	public void SetOnReduceFunction(Action<GiftItemData> onReduceFunction)
	{
		this.OnReduceFunction = onReduceFunction;
	}

	// Token: 0x0600D2EB RID: 53995 RVA: 0x003E90B4 File Offset: 0x003E72B4
	[NullableContext(1)]
	public void SetIsSelectOn(Func<GiftItemData, bool> isSelectOnFunction)
	{
		this.IsSelectOn = isSelectOnFunction;
	}

	// Token: 0x040076A4 RID: 30372
	private UUIText ItemNameText;

	// Token: 0x040076A5 RID: 30373
	private UUIText ItemCountText;

	// Token: 0x040076A6 RID: 30374
	private UUIButtonComponent ReduceButton;

	// Token: 0x040076A7 RID: 30375
	private int? ItemConfigId;

	// Token: 0x040076A8 RID: 30376
	private UUIExtendToggle Toggle;

	// Token: 0x040076A9 RID: 30377
	private GiftItemData ItemData;

	// Token: 0x040076AA RID: 30378
	private InventoryGiftCellItem ItemGrid;

	// Token: 0x040076AB RID: 30379
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData> OnToggleStateChangeFunction;

	// Token: 0x040076AC RID: 30380
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GiftItemData> OnReduceFunction;

	// Token: 0x040076AD RID: 30381
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<GiftItemData, bool> IsSelectOn;

	// Token: 0x040076AE RID: 30382
	private UUISprite WeaponTypeIcon;

	// Token: 0x02007760 RID: 30560
	[NullableContext(0)]
	private enum EInventoryGiftItemType
	{
		// Token: 0x04026C2B RID: 158763
		ItemGridItem,
		// Token: 0x04026C2C RID: 158764
		ItemNameText,
		// Token: 0x04026C2D RID: 158765
		ItemCountText,
		// Token: 0x04026C2E RID: 158766
		ReduceButton,
		// Token: 0x04026C2F RID: 158767
		Toggle,
		// Token: 0x04026C30 RID: 158768
		WeaponTypeIcon
	}
}
