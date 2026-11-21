using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200104E RID: 4174
public class FloroRanchEntityDebugInfoItem : UiPanelBase
{
	// Token: 0x0600A626 RID: 42534 RVA: 0x0030E1B8 File Offset: 0x0030C3B8
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

	// Token: 0x0600A627 RID: 42535 RVA: 0x0030E200 File Offset: 0x0030C400
	[NullableContext(2)]
	public void Refresh(FloroRanchEntityBase entity)
	{
		UUIText text = base.GetText(0);
		if (entity == null)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		text.SetText(entity.DebugUiShowInfo(), true);
	}

	// Token: 0x020072A4 RID: 29348
	private class EComponent
	{
		// Token: 0x04025558 RID: 152920
		public const int InfoText = 0;
	}
}
