using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451A RID: 17690
	public class MarkNameComponent : MarkPanelBase
	{
		// Token: 0x0602CA39 RID: 182841 RVA: 0x00C85DEC File Offset: 0x00C83FEC
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

		// Token: 0x0602CA3A RID: 182842 RVA: 0x00C85E34 File Offset: 0x00C84034
		protected override void OnBeforeShow()
		{
			this.UpdateName();
		}

		// Token: 0x0602CA3B RID: 182843 RVA: 0x00C85E3C File Offset: 0x00C8403C
		[NullableContext(1)]
		public void SetNameParam(IMarkItemParam param)
		{
			this.Params = param;
			if (base.IsShowOrShowing)
			{
				this.UpdateName();
			}
		}

		// Token: 0x0602CA3C RID: 182844 RVA: 0x00C85E54 File Offset: 0x00C84054
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
			text.SetFontSize((float)this.Params.FontSize.GetValueOrDefault(38));
			text.SetAnchorOffset(this.Params.AnchorOffset ?? MarkNameComponent.DefaultAnchorOffset);
			text.outlineSize = ((this.Params.OutlineSize != null) ? ((int)this.Params.OutlineSize.Value) : 0);
			if (this.Params.OutlineColor != null)
			{
				text.SetFontOutlineColor(this.Params.OutlineColor.Value);
			}
			text.SetText(this.Params.Txt, true);
		}

		// Token: 0x04017ECE RID: 97998
		[Nullable(2)]
		private IMarkItemParam Params;

		// Token: 0x04017ECF RID: 97999
		private const int DEFAULT_FONT_SIZE = 38;

		// Token: 0x04017ED0 RID: 98000
		private const int DEFAULT_OUTLINE_SIZE = 0;

		// Token: 0x04017ED1 RID: 98001
		private static readonly FVector2D DefaultAnchorOffset = new FVector2D(0f, 0f);

		// Token: 0x0200A19E RID: 41374
		public static class EChildComponents
		{
			// Token: 0x040322CF RID: 205519
			public const int NameText = 0;
		}
	}
}
