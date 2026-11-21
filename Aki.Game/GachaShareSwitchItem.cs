using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001AAE RID: 6830
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaShareSwitchItem : GridProxyAbstract<GachaShareSwitchData>
{
	// Token: 0x06010E71 RID: 69233 RVA: 0x004F54BC File Offset: 0x004F36BC
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

	// Token: 0x06010E72 RID: 69234 RVA: 0x004F554F File Offset: 0x004F374F
	private void OnClickToggle(EToggleState obj)
	{
		if (this.ToggleClickCb != null)
		{
			this.ToggleClickCb(this.SwitchData, base.GridIndex);
		}
	}

	// Token: 0x06010E73 RID: 69235 RVA: 0x004F5570 File Offset: 0x004F3770
	public void SetToggleClickCallback(Action<GachaShareSwitchData, int> cb)
	{
		this.ToggleClickCb = cb;
	}

	// Token: 0x06010E74 RID: 69236 RVA: 0x004F557C File Offset: 0x004F377C
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

	// Token: 0x06010E75 RID: 69237 RVA: 0x004F56A6 File Offset: 0x004F38A6
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010E76 RID: 69238 RVA: 0x004F56B9 File Offset: 0x004F38B9
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04009535 RID: 38197
	[Nullable(2)]
	private GachaShareSwitchData SwitchData;

	// Token: 0x04009536 RID: 38198
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GachaShareSwitchData, int> ToggleClickCb;

	// Token: 0x02007D5C RID: 32092
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028943 RID: 166211
		Toggle,
		// Token: 0x04028944 RID: 166212
		DefaultIcon,
		// Token: 0x04028945 RID: 166213
		WeaponIcon,
		// Token: 0x04028946 RID: 166214
		RoleIcon
	}
}
