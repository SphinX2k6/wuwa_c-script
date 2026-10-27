using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8E RID: 8078
internal class ReputationTipsItem : UiPanelBase
{
	// Token: 0x0600FAAF RID: 64175 RVA: 0x003CBE8D File Offset: 0x003CA08D
	[NullableContext(1)]
	public ReputationTipsItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FAB0 RID: 64176 RVA: 0x003CBEA4 File Offset: 0x003CA0A4
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

	// Token: 0x0600FAB1 RID: 64177 RVA: 0x003CBF10 File Offset: 0x003CA110
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

	// Token: 0x02008578 RID: 34168
	private enum EReputationTipsItem
	{
		// Token: 0x0402B755 RID: 178005
		Value,
		// Token: 0x0402B756 RID: 178006
		Sprite
	}
}
