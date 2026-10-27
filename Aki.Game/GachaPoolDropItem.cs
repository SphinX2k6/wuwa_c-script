using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C85 RID: 7301
public class GachaPoolDropItem : UiPanelBase
{
	// Token: 0x0600DC49 RID: 56393 RVA: 0x00335B54 File Offset: 0x00333D54
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

	// Token: 0x0600DC4A RID: 56394 RVA: 0x00335B9C File Offset: 0x00333D9C
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

	// Token: 0x0400650F RID: 25871
	[Nullable(2)]
	public GachaPoolDrop Data;

	// Token: 0x0200825B RID: 33371
	private enum EGachaPoolDropItemDefine
	{
		// Token: 0x0402A887 RID: 174215
		TxtName
	}
}
