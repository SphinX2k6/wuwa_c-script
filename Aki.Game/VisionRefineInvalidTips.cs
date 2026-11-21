using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C24 RID: 3108
public class VisionRefineInvalidTips : UiPanelBase
{
	// Token: 0x060081C8 RID: 33224 RVA: 0x0027D2B0 File Offset: 0x0027B4B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060081C9 RID: 33225 RVA: 0x0027D33C File Offset: 0x0027B53C
	[NullableContext(1)]
	public void RefreshExternalByData(VisionRefineInvalidTipsData data)
	{
		UUIText text = base.GetText(1);
		if (data.LockDescriptionTextId != null)
		{
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text, data.LockDescriptionTextId, data.LockDescriptionTextArgs);
			return;
		}
		if (text != null)
		{
			text.SetUIActive(false);
		}
	}

	// Token: 0x02006EE8 RID: 28392
	private enum EComponent
	{
		// Token: 0x04024417 RID: 148503
		LockSprite,
		// Token: 0x04024418 RID: 148504
		LockDescriptionText,
		// Token: 0x04024419 RID: 148505
		FunctionButton
	}
}
