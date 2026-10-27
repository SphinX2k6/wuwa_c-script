using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020033B4 RID: 13236
public class RedDotInventoryPhantom : RedDotBase
{
	// Token: 0x0601CB7D RID: 117629 RVA: 0x008084FC File Offset: 0x008066FC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB7E RID: 117630 RVA: 0x00808536 File Offset: 0x00806736
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB7F RID: 117631 RVA: 0x00808570 File Offset: 0x00806770
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Phantom);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601CB80 RID: 117632 RVA: 0x00808594 File Offset: 0x00806794
	[NullableContext(1)]
	private void OnAddPhantomItemList(IReadOnlyList<PhantomItem> weaponItem, bool isCatch)
	{
		base.EventCheck();
	}
}
