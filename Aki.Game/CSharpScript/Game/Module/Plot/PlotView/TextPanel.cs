using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200503C RID: 20540
	internal class TextPanel : UiPanelBase
	{
		// Token: 0x0603492F RID: 215343 RVA: 0x00C6A22C File Offset: 0x00C6842C
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

		// Token: 0x06034930 RID: 215344 RVA: 0x00C6A274 File Offset: 0x00C68474
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
