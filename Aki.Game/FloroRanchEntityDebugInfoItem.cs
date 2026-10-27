using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B8F RID: 7055
public class FloroRanchEntityDebugInfoItem : UiPanelBase
{
	// Token: 0x0600D215 RID: 53781 RVA: 0x003030E0 File Offset: 0x003012E0
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

	// Token: 0x0600D216 RID: 53782 RVA: 0x00303128 File Offset: 0x00301328
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

	// Token: 0x02008116 RID: 33046
	private class EComponent
	{
		// Token: 0x0402A224 RID: 172580
		public const int InfoText = 0;
	}
}
