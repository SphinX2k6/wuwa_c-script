using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotSceneView
{
	// Token: 0x02004045 RID: 16453
	public class PlotSceneArtWordTextPanel : UiPanelBase
	{
		// Token: 0x06029B35 RID: 170805 RVA: 0x00BC96F4 File Offset: 0x00BC78F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029B36 RID: 170806 RVA: 0x00BC9760 File Offset: 0x00BC7960
		[NullableContext(1)]
		public void ApplyConfig(FloatingSubtitle3D config, string lineText, float fontSize)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(lineText, true);
			}
			if (!string.IsNullOrEmpty(config.Color) && text != null)
			{
				text.SetColor(FColor.FromHex(config.Color));
			}
			if (fontSize > 0f)
			{
				if (text != null)
				{
					text.SetFontSize(fontSize);
				}
				FloatingSubtitleLanguageUtil.Instance.EnableTextAdaptSize(text);
			}
			this.ApplyLayoutScale(text, FloatingSubtitleLanguageUtil.Instance.GetLayoutScale(fontSize));
			this.SpaceMarkWatcher.Start(text);
		}

		// Token: 0x06029B37 RID: 170807 RVA: 0x00BC97DE File Offset: 0x00BC79DE
		protected override void OnBeforeDestroy()
		{
			this.SpaceMarkWatcher.Stop();
		}

		// Token: 0x06029B38 RID: 170808 RVA: 0x00BC97EC File Offset: 0x00BC79EC
		[NullableContext(2)]
		private void ApplyLayoutScale(UUIText text, float scale)
		{
			if (text != null)
			{
				float value = this.BaseTextOffsetY.GetValueOrDefault();
				if (this.BaseTextOffsetY == null)
				{
					value = text.GetAnchorOffsetY();
					this.BaseTextOffsetY = new float?(value);
				}
				text.SetAnchorOffsetY(this.BaseTextOffsetY.Value * scale);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				float value = this.BasePivotOffsetY.GetValueOrDefault();
				if (this.BasePivotOffsetY == null)
				{
					value = item.GetAnchorOffsetY();
					this.BasePivotOffsetY = new float?(value);
				}
				item.SetAnchorOffsetY(this.BasePivotOffsetY.Value * scale);
			}
		}

		// Token: 0x04016C0A RID: 93194
		private float? BasePivotOffsetY;

		// Token: 0x04016C0B RID: 93195
		private float? BaseTextOffsetY;

		// Token: 0x04016C0C RID: 93196
		[Nullable(1)]
		private readonly FloatingSubtitleSpaceMarkWatcher SpaceMarkWatcher = new FloatingSubtitleSpaceMarkWatcher();

		// Token: 0x02009C4B RID: 40011
		private enum EComponents
		{
			// Token: 0x04030A2C RID: 199212
			Text,
			// Token: 0x04030A2D RID: 199213
			PnlPivot
		}
	}
}
