using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017EC RID: 6124
[NullableContext(1)]
[Nullable(0)]
public class QteTipItem : UiPanelBase
{
	// Token: 0x0600EFEC RID: 61420 RVA: 0x004672EF File Offset: 0x004654EF
	public void Init(UUIItem rootItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_QteTips", rootItem, false);
	}

	// Token: 0x0600EFED RID: 61421 RVA: 0x00467300 File Offset: 0x00465500
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

	// Token: 0x0600EFEE RID: 61422 RVA: 0x00467348 File Offset: 0x00465548
	protected override void OnStart()
	{
		if (!string.IsNullOrEmpty(this.Tip))
		{
			this.Refresh(this.Tip);
		}
	}

	// Token: 0x0600EFEF RID: 61423 RVA: 0x00467363 File Offset: 0x00465563
	public void Refresh(string tip)
	{
		this.Tip = tip;
		if (!base.InAsyncLoading())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), tip, Array.Empty<object>());
		}
	}

	// Token: 0x04008797 RID: 34711
	private string Tip = string.Empty;

	// Token: 0x02007A0B RID: 31243
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027903 RID: 162051
		TxtTip
	}
}
