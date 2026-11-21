using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200400B RID: 16395
	internal class TextPanel : UiPanelBase
	{
		// Token: 0x0602980B RID: 169995 RVA: 0x00BB72CC File Offset: 0x00BB54CC
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

		// Token: 0x0602980C RID: 169996 RVA: 0x00BB7314 File Offset: 0x00BB5514
		[NullableContext(1)]
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
			FloatingSubtitleLanguageUtil.Instance.ApplySpaceMark(text2);
		}
	}
}
