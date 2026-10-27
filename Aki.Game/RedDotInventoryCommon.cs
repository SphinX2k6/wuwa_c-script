using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020033B1 RID: 13233
public class RedDotInventoryCommon : RedDotBase
{
	// Token: 0x0601CB6F RID: 117615 RVA: 0x00808210 File Offset: 0x00806410
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB70 RID: 117616 RVA: 0x00808274 File Offset: 0x00806474
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB71 RID: 117617 RVA: 0x008082D8 File Offset: 0x008064D8
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Common);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}
}
