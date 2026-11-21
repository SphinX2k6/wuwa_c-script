using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002926 RID: 10534
public class RedDotInventoryPhantom : RedDotBase
{
	// Token: 0x0601A875 RID: 108661 RVA: 0x0082EAC0 File Offset: 0x0082CCC0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A876 RID: 108662 RVA: 0x0082EAFA File Offset: 0x0082CCFA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A877 RID: 108663 RVA: 0x0082EB34 File Offset: 0x0082CD34
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Phantom);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601A878 RID: 108664 RVA: 0x0082EB58 File Offset: 0x0082CD58
	[NullableContext(1)]
	private void OnAddPhantomItemList(IReadOnlyList<PhantomItem> weaponItem, bool isCatch)
	{
		base.EventCheck();
	}
}
