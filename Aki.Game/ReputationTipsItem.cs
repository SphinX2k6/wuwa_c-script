using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001450 RID: 5200
internal class ReputationTipsItem : UiPanelBase
{
	// Token: 0x0600CECE RID: 52942 RVA: 0x003D79C1 File Offset: 0x003D5BC1
	[NullableContext(1)]
	public ReputationTipsItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CECF RID: 52943 RVA: 0x003D79D8 File Offset: 0x003D5BD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CED0 RID: 52944 RVA: 0x003D7A44 File Offset: 0x003D5C44
	public void UpdateItem(int itemId, int max)
	{
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		float fillAmount = (float)itemCountByConfigId / (float)max;
		LguiUtil.Instance.SetLocalText(base.GetText(0), "ReputationValue", new <>z__ReadOnlyArray<object>(new object[]
		{
			itemCountByConfigId,
			max
		}));
		base.GetSprite(1).SetFillAmount(fillAmount);
	}

	// Token: 0x020076FD RID: 30461
	private enum EReputationTipsItem
	{
		// Token: 0x04026A78 RID: 158328
		Value,
		// Token: 0x04026A79 RID: 158329
		Sprite
	}
}
