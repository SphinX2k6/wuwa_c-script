using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020033B7 RID: 13239
public class RedDotInventoryWeapon : RedDotBase
{
	// Token: 0x0601CB8C RID: 117644 RVA: 0x0080879C File Offset: 0x0080699C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB8D RID: 117645 RVA: 0x008087D6 File Offset: 0x008069D6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB8E RID: 117646 RVA: 0x00808810 File Offset: 0x00806A10
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Weapon);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601CB8F RID: 117647 RVA: 0x00808834 File Offset: 0x00806A34
	[NullableContext(1)]
	private void OnAddWeaponItem(WeaponItem weaponItem, bool bAddFromRole, bool bShowNewTips)
	{
		base.EventCheck();
	}
}
