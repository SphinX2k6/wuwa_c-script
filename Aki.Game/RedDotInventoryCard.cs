using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020033AF RID: 13231
public class RedDotInventoryCard : RedDotBase
{
	// Token: 0x0601CB65 RID: 117605 RVA: 0x00808018 File Offset: 0x00806218
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB66 RID: 117606 RVA: 0x0080807C File Offset: 0x0080627C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnRemoveItemRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(base.EventCheck));
	}

	// Token: 0x0601CB67 RID: 117607 RVA: 0x008080E0 File Offset: 0x008062E0
	protected override bool OnCheck(int uId = 0)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = InventoryModel.Instance.GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId.Card);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0601CB68 RID: 117608 RVA: 0x00808104 File Offset: 0x00806304
	[NullableContext(1)]
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		base.EventCheck();
	}
}
