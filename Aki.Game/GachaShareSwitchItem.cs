using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025C3 RID: 9667
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaShareSwitchItem : GridProxyAbstract<GachaShareSwitchData>
{
	// Token: 0x06013991 RID: 80273 RVA: 0x004E68BC File Offset: 0x004E4ABC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06013992 RID: 80274 RVA: 0x004E694F File Offset: 0x004E4B4F
	private void OnClickToggle(EToggleState obj)
	{
		if (this.ToggleClickCb != null)
		{
			this.ToggleClickCb(this.SwitchData, base.GridIndex);
		}
	}

	// Token: 0x06013993 RID: 80275 RVA: 0x004E6970 File Offset: 0x004E4B70
	public void SetToggleClickCallback(Action<GachaShareSwitchData, int> cb)
	{
		this.ToggleClickCb = cb;
	}

	// Token: 0x06013994 RID: 80276 RVA: 0x004E697C File Offset: 0x004E4B7C
	public override void Refresh(GachaShareSwitchData switchData, bool isSelected, int gridIndex)
	{
		this.SwitchData = switchData;
		base.GridIndex = gridIndex;
		if (switchData.TenGachaInfo != null)
		{
			base.GetItem(1).SetUIActive(true);
			base.GetTexture(3).SetUIActive(false);
			base.GetTexture(2).SetUIActive(false);
			return;
		}
		int itemId = switchData.GachaInfo.Proto_GachaReward.ItemId;
		base.GetItem(1).SetUIActive(false);
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
		base.GetTexture(3).SetUIActive(itemIdType == InventoryDefine.EItemDataType.RoleItem);
		base.GetTexture(2).SetUIActive(itemIdType == InventoryDefine.EItemDataType.WeaponItem);
		if (itemIdType == InventoryDefine.EItemDataType.RoleItem)
		{
			string card = RoleConfig.Instance.GetRoleConfig(itemId).Value.Card;
			base.SetTextureByPath(card, base.GetTexture(3), null, null);
		}
		else if (itemIdType == InventoryDefine.EItemDataType.WeaponItem)
		{
			string icon = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.Icon;
			base.SetTextureByPath(icon, base.GetTexture(2), null, null);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013995 RID: 80277 RVA: 0x004E6AA6 File Offset: 0x004E4CA6
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06013996 RID: 80278 RVA: 0x004E6AB9 File Offset: 0x004E4CB9
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040093DF RID: 37855
	[Nullable(2)]
	private GachaShareSwitchData SwitchData;

	// Token: 0x040093E0 RID: 37856
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GachaShareSwitchData, int> ToggleClickCb;

	// Token: 0x02008BD4 RID: 35796
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D62E RID: 185902
		Toggle,
		// Token: 0x0402D62F RID: 185903
		DefaultIcon,
		// Token: 0x0402D630 RID: 185904
		WeaponIcon,
		// Token: 0x0402D631 RID: 185905
		RoleIcon
	}
}
