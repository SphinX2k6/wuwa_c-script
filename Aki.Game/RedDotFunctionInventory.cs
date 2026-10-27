using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02003397 RID: 13207
[NullableContext(1)]
[Nullable(0)]
public class RedDotFunctionInventory : RedDotBase
{
	// Token: 0x0601CAF0 RID: 117488 RVA: 0x00806FD0 File Offset: 0x008051D0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<IReadOnlyList<WeaponItem>, bool, bool>(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Add<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CAF1 RID: 117489 RVA: 0x00807050 File Offset: 0x00805250
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CAF2 RID: 117490 RVA: 0x008070CD File Offset: 0x008052CD
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CAF3 RID: 117491 RVA: 0x008070D5 File Offset: 0x008052D5
	private void OnAddWeaponItemList(IReadOnlyList<WeaponItem> weaponItem, bool bAddFromRole, bool bShowNewTips)
	{
		base.EventCheck();
	}

	// Token: 0x0601CAF4 RID: 117492 RVA: 0x008070DD File Offset: 0x008052DD
	private void OnAddPhantomItemList(IReadOnlyList<PhantomItem> phantomItemList, bool isCatch)
	{
		base.EventCheck();
	}

	// Token: 0x0601CAF5 RID: 117493 RVA: 0x008070E5 File Offset: 0x008052E5
	protected override bool OnCheck(int id)
	{
		return InventoryModel.Instance.HasRedDot();
	}
}
