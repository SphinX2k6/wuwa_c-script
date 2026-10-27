using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002308 RID: 8968
[NullableContext(1)]
[Nullable(0)]
public class QteTipItem : UiPanelBase
{
	// Token: 0x06011B51 RID: 72529 RVA: 0x0045A4DF File Offset: 0x004586DF
	public void Init(UUIItem rootItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_QteTips", rootItem, false);
	}

	// Token: 0x06011B52 RID: 72530 RVA: 0x0045A4F0 File Offset: 0x004586F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011B53 RID: 72531 RVA: 0x0045A538 File Offset: 0x00458738
	protected override void OnStart()
	{
		if (!string.IsNullOrEmpty(this.Tip))
		{
			this.Refresh(this.Tip);
		}
	}

	// Token: 0x06011B54 RID: 72532 RVA: 0x0045A553 File Offset: 0x00458753
	public void Refresh(string tip)
	{
		this.Tip = tip;
		if (!base.InAsyncLoading())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), tip, Array.Empty<object>());
		}
	}

	// Token: 0x04008657 RID: 34391
	private string Tip = string.Empty;

	// Token: 0x02008885 RID: 34949
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402C5F5 RID: 181749
		TxtTip
	}
}
