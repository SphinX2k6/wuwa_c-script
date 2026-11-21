using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B6C RID: 2924
public class PeriodicityChallengeItemTopTips : UiPanelBase
{
	// Token: 0x060079A1 RID: 31137 RVA: 0x0025B278 File Offset: 0x00259478
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

	// Token: 0x060079A2 RID: 31138 RVA: 0x0025B2E1 File Offset: 0x002594E1
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

	// Token: 0x02006E0D RID: 28173
	private enum ETipsDefine
	{
		// Token: 0x040240E1 RID: 147681
		TxtTitle,
		// Token: 0x040240E2 RID: 147682
		TxtNum
	}
}
