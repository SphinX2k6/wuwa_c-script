using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005548 RID: 21832
	public class MarkNameComponent : MarkPanelBase
	{
		// Token: 0x06037B6A RID: 228202 RVA: 0x00D38318 File Offset: 0x00D36518
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

		// Token: 0x06037B6B RID: 228203 RVA: 0x00D38360 File Offset: 0x00D36560
		protected override void OnBeforeShow()
		{
			this.UpdateName();
		}

		// Token: 0x06037B6C RID: 228204 RVA: 0x00D38368 File Offset: 0x00D36568
		[NullableContext(1)]
		public void SetNameParam(IMarkItemParam param)
		{
			this.Params = param;
			if (base.IsShowOrShowing)
			{
				this.UpdateName();
			}
		}

		// Token: 0x06037B6D RID: 228205 RVA: 0x00D38380 File Offset: 0x00D36580
		private void UpdateName()
		{
			if (this.Params == null)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (!ObjectUtils.IsValid(text))
			{
				return;
			}
			if (this.Params.FontSize != null)
			{
				text.SetFontSize((float)this.Params.FontSize.Value);
			}
			if (this.Params.AnchorOffset != null)
			{
				text.SetAnchorOffset(this.Params.AnchorOffset.Value);
			}
			if (this.Params.OutlineSize != null)
			{
				text.outlineSize = (int)this.Params.OutlineSize.Value;
			}
			if (this.Params.OutlineColor != null)
			{
				text.SetFontOutlineColor(this.Params.OutlineColor.Value);
			}
			text.SetText(this.Params.Txt, true);
		}

		// Token: 0x0401D448 RID: 119880
		[Nullable(2)]
		private IMarkItemParam Params;

		// Token: 0x0200B773 RID: 46963
		public static class EChildComponents
		{
			// Token: 0x040378A4 RID: 227492
			public const int NameText = 0;
		}
	}
}
