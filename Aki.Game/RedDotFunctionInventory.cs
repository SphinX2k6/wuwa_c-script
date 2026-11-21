using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002909 RID: 10505
[NullableContext(1)]
[Nullable(0)]
public class RedDotFunctionInventory : RedDotBase
{
	// Token: 0x0601A7E8 RID: 108520 RVA: 0x0082D594 File Offset: 0x0082B794
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<IReadOnlyList<WeaponItem>, bool, bool>(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Add<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7E9 RID: 108521 RVA: 0x0082D614 File Offset: 0x0082B814
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7EA RID: 108522 RVA: 0x0082D691 File Offset: 0x0082B891
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		base.EventCheck();
	}

	// Token: 0x0601A7EB RID: 108523 RVA: 0x0082D699 File Offset: 0x0082B899
	private void OnAddWeaponItemList(IReadOnlyList<WeaponItem> weaponItem, bool bAddFromRole, bool bShowNewTips)
	{
		base.EventCheck();
	}

	// Token: 0x0601A7EC RID: 108524 RVA: 0x0082D6A1 File Offset: 0x0082B8A1
	private void OnAddPhantomItemList(IReadOnlyList<PhantomItem> phantomItemList, bool isCatch)
	{
		base.EventCheck();
	}

	// Token: 0x0601A7ED RID: 108525 RVA: 0x0082D6A9 File Offset: 0x0082B8A9
	protected override bool OnCheck(int id)
	{
		return InventoryModel.Instance.HasRedDot();
	}
}
