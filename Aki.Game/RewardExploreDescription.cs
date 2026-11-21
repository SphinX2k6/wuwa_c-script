using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014E3 RID: 5347
public class RewardExploreDescription : UiPanelBase
{
	// Token: 0x0600D600 RID: 54784 RVA: 0x003F8358 File Offset: 0x003F6558
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

	// Token: 0x0600D601 RID: 54785 RVA: 0x003F83AC File Offset: 0x003F65AC
	[NullableContext(1)]
	public void Refresh(string descriptionTextId)
	{
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, Array.Empty<object>());
	}

	// Token: 0x02007798 RID: 30616
	private class EChildType
	{
		// Token: 0x04026D29 RID: 159017
		public const int DescriptionText = 0;
	}
}
