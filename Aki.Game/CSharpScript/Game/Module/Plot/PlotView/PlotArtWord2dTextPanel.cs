using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005049 RID: 20553
	public class PlotArtWord2dTextPanel : UiPanelBase
	{
		// Token: 0x0603499A RID: 215450 RVA: 0x00C6CA74 File Offset: 0x00C6AC74
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

		// Token: 0x0603499B RID: 215451 RVA: 0x00C6CABC File Offset: 0x00C6ACBC
		[NullableContext(1)]
		public void SetTextKey(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x0603499C RID: 215452 RVA: 0x00C6CAD8 File Offset: 0x00C6ACD8
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

		// Token: 0x0603499D RID: 215453 RVA: 0x00C6CB1C File Offset: 0x00C6AD1C
		public void SetTextAlpha(float alpha)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetAlpha(alpha);
		}

		// Token: 0x0603499E RID: 215454 RVA: 0x00C6CB30 File Offset: 0x00C6AD30
		public void ApplySpaceMark()
		{
			FloatingSubtitleLanguageUtil.Instance.ApplySpaceMark(base.GetText(0));
		}

		// Token: 0x0603499F RID: 215455 RVA: 0x00C6CB43 File Offset: 0x00C6AD43
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

		// Token: 0x0200B19D RID: 45469
		private enum EComponents
		{
			// Token: 0x04035DDE RID: 220638
			Text
		}
	}
}
