using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.PunishReport
{
	// Token: 0x020047F6 RID: 18422
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportTargetListItemPanel : UiPanelBase
	{
		// Token: 0x0603040B RID: 197643 RVA: 0x00B30F54 File Offset: 0x00B2F154
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603040C RID: 197644 RVA: 0x00B31000 File Offset: 0x00B2F200
		public void SetDescLocalNewTxt(string txtKey)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, txtKey, Array.Empty<object>());
		}

		// Token: 0x0603040D RID: 197645 RVA: 0x00B31026 File Offset: 0x00B2F226
		public void SetDescTxt(string txt)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x0603040E RID: 197646 RVA: 0x00B3103B File Offset: 0x00B2F23B
		public void SetNumTxt(string txt)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x0603040F RID: 197647 RVA: 0x00B31050 File Offset: 0x00B2F250
		public void SetState(EPunishReportTargetListItemPanelState state)
		{
			string text;
			switch (state)
			{
			case EPunishReportTargetListItemPanelState.Lock:
				text = "T_MapDifficultyLock";
				break;
			case EPunishReportTargetListItemPanelState.Empty:
				text = "T_MapDifficultyEmpty";
				break;
			case EPunishReportTargetListItemPanelState.Selected:
				text = "T_MapDifficultyTick";
				break;
			default:
				text = "";
				break;
			}
			string resourceId = text;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200AAC0 RID: 43712
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033EFB RID: 212731
			public const int TxtL = 0;

			// Token: 0x04033EFC RID: 212732
			public const int TexState = 1;

			// Token: 0x04033EFD RID: 212733
			public const int PnlGift = 2;

			// Token: 0x04033EFE RID: 212734
			public const int TxtLNum = 3;
		}
	}
}
