using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotSceneView
{
	// Token: 0x02005075 RID: 20597
	public class PlotSceneArtWordTextPanel : UiPanelBase
	{
		// Token: 0x06034C40 RID: 216128 RVA: 0x00C7C31C File Offset: 0x00C7A51C
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

		// Token: 0x06034C41 RID: 216129 RVA: 0x00C7C388 File Offset: 0x00C7A588
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

		// Token: 0x06034C42 RID: 216130 RVA: 0x00C7C406 File Offset: 0x00C7A606
		protected override void OnBeforeDestroy()
		{
			this.SpaceMarkWatcher.Stop();
		}

		// Token: 0x06034C43 RID: 216131 RVA: 0x00C7C414 File Offset: 0x00C7A614
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

		// Token: 0x0401C1DF RID: 115167
		private float? BasePivotOffsetY;

		// Token: 0x0401C1E0 RID: 115168
		private float? BaseTextOffsetY;

		// Token: 0x0401C1E1 RID: 115169
		[Nullable(1)]
		private readonly FloatingSubtitleSpaceMarkWatcher SpaceMarkWatcher = new FloatingSubtitleSpaceMarkWatcher();

		// Token: 0x0200B212 RID: 45586
		private enum EComponents
		{
			// Token: 0x04035FD8 RID: 221144
			Text,
			// Token: 0x04035FD9 RID: 221145
			PnlPivot
		}
	}
}
