using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.PunishReport
{
	// Token: 0x02003727 RID: 14119
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportTargetListItemPanel : UiPanelBase
	{
		// Token: 0x06024BDB RID: 150491 RVA: 0x00A60EF4 File Offset: 0x00A5F0F4
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

		// Token: 0x06024BDC RID: 150492 RVA: 0x00A60FA0 File Offset: 0x00A5F1A0
		public void SetDescLocalNewTxt(string txtKey)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, txtKey, Array.Empty<object>());
		}

		// Token: 0x06024BDD RID: 150493 RVA: 0x00A60FC6 File Offset: 0x00A5F1C6
		public void SetDescTxt(string txt)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x06024BDE RID: 150494 RVA: 0x00A60FDB File Offset: 0x00A5F1DB
		public void SetNumTxt(string txt)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x06024BDF RID: 150495 RVA: 0x00A60FF0 File Offset: 0x00A5F1F0
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

		// Token: 0x02009471 RID: 38001
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E67E RID: 190078
			public const int TxtL = 0;

			// Token: 0x0402E67F RID: 190079
			public const int TexState = 1;

			// Token: 0x0402E680 RID: 190080
			public const int PnlGift = 2;

			// Token: 0x0402E681 RID: 190081
			public const int TxtLNum = 3;
		}
	}
}
