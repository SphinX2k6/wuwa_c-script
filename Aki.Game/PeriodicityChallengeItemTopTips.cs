using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016B4 RID: 5812
public class PeriodicityChallengeItemTopTips : UiPanelBase
{
	// Token: 0x0600A5C1 RID: 42433 RVA: 0x00250E68 File Offset: 0x0024F068
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5C2 RID: 42434 RVA: 0x00250ED1 File Offset: 0x0024F0D1
	[NullableContext(1)]
	public void Refresh(IPeriodicityChallengeTopTips data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTips, data.Args);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(data.TxtNum, true);
	}

	// Token: 0x02007C88 RID: 31880
	private enum ETipsDefine
	{
		// Token: 0x04028DB8 RID: 167352
		TxtTitle,
		// Token: 0x04028DB9 RID: 167353
		TxtNum
	}
}
