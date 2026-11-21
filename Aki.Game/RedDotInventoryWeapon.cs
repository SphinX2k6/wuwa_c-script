using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002929 RID: 10537
public class RedDotInventoryWeapon : RedDotBase
{
	// Token: 0x0601A884 RID: 108676 RVA: 0x0082ED60 File Offset: 0x0082CF60
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A885 RID: 108677 RVA: 0x0082ED9A File Offset: 0x0082CF9A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A886 RID: 108678 RVA: 0x0082EDD4 File Offset: 0x0082CFD4
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Weapon);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601A887 RID: 108679 RVA: 0x0082EDF8 File Offset: 0x0082CFF8
	[NullableContext(1)]
	private void OnAddWeaponItem(WeaponItem weaponItem, bool bAddFromRole, bool bShowNewTips)
	{
		base.EventCheck();
	}
}
