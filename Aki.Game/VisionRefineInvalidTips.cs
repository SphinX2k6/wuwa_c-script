using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200176B RID: 5995
public class VisionRefineInvalidTips : UiPanelBase
{
	// Token: 0x0600ADE1 RID: 44513 RVA: 0x00272DEC File Offset: 0x00270FEC
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

	// Token: 0x0600ADE2 RID: 44514 RVA: 0x00272E78 File Offset: 0x00271078
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

	// Token: 0x02007D62 RID: 32098
	private enum EComponent
	{
		// Token: 0x040290EC RID: 168172
		LockSprite,
		// Token: 0x040290ED RID: 168173
		LockDescriptionText,
		// Token: 0x040290EE RID: 168174
		FunctionButton
	}
}
