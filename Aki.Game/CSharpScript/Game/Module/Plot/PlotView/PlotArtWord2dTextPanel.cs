using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004018 RID: 16408
	public class PlotArtWord2dTextPanel : UiPanelBase
	{
		// Token: 0x0602987C RID: 170108 RVA: 0x00BB9BE0 File Offset: 0x00BB7DE0
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

		// Token: 0x0602987D RID: 170109 RVA: 0x00BB9C28 File Offset: 0x00BB7E28
		[NullableContext(1)]
		public void SetTextKey(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x0602987E RID: 170110 RVA: 0x00BB9C44 File Offset: 0x00BB7E44
		public void ApplyLanguageScale(float scale)
		{
			if (Math.Abs(scale - 1f) < 0.0001f)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			float num = text.GetSize() * scale;
			text.SetFontSize(num);
			text.SetWidth(num);
		}

		// Token: 0x0602987F RID: 170111 RVA: 0x00BB9C88 File Offset: 0x00BB7E88
		public void SetTextAlpha(float alpha)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetAlpha(alpha);
		}

		// Token: 0x06029880 RID: 170112 RVA: 0x00BB9C9C File Offset: 0x00BB7E9C
		public void ApplySpaceMark()
		{
			FloatingSubtitleLanguageUtil.Instance.ApplySpaceMark(base.GetText(0));
		}

		// Token: 0x06029881 RID: 170113 RVA: 0x00BB9CAF File Offset: 0x00BB7EAF
		[NullableContext(2)]
		public AActor GetTextActor()
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return null;
			}
			return text.GetOwner();
		}

		// Token: 0x02009BD7 RID: 39895
		private enum EComponents
		{
			// Token: 0x04030833 RID: 198707
			Text
		}
	}
}
