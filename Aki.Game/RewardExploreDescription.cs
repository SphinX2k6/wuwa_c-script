using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002010 RID: 8208
public class RewardExploreDescription : UiPanelBase
{
	// Token: 0x06010198 RID: 65944 RVA: 0x003EBD60 File Offset: 0x003E9F60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06010199 RID: 65945 RVA: 0x003EBDB4 File Offset: 0x003E9FB4
	[NullableContext(1)]
	public void Refresh(string descriptionTextId)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, Array.Empty<object>());
	}

	// Token: 0x02008611 RID: 34321
	private class EChildType
	{
		// Token: 0x0402BA1A RID: 178714
		public const int DescriptionText = 0;
	}
}
