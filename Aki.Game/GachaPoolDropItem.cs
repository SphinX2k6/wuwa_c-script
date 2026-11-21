using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001144 RID: 4420
public class GachaPoolDropItem : UiPanelBase
{
	// Token: 0x0600B05F RID: 45151 RVA: 0x00341080 File Offset: 0x0033F280
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B060 RID: 45152 RVA: 0x003410C8 File Offset: 0x0033F2C8
	protected override void OnStart()
	{
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.Data.ItemId));
		string textStringId = this.Data.IsUp ? "GachaDropItemUp" : "GachaPoolDropItemNormal";
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.Data.ItemId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(roleInfoById.Value.Name, null)));
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponItem)
		{
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.Data.ItemId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(weaponConfigByItemId.Value.WeaponName, null)));
		}
	}

	// Token: 0x040065E1 RID: 26081
	[Nullable(2)]
	public GachaPoolDrop Data;

	// Token: 0x020073E3 RID: 29667
	private enum EGachaPoolDropItemDefine
	{
		// Token: 0x04025BA8 RID: 154536
		TxtName
	}
}
