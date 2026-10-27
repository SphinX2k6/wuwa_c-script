using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020033B6 RID: 13238
public class RedDotInventoryVirtual : RedDotBase
{
	// Token: 0x0601CB87 RID: 117639 RVA: 0x008086A0 File Offset: 0x008068A0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB88 RID: 117640 RVA: 0x00808704 File Offset: 0x00806904
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB89 RID: 117641 RVA: 0x00808768 File Offset: 0x00806968
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Virtual);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601CB8A RID: 117642 RVA: 0x0080878C File Offset: 0x0080698C
	[NullableContext(1)]
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		base.EventCheck();
	}
}
