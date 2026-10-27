using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200505E RID: 20574
	public class PlotReviewOptionItem : UiPanelBase
	{
		// Token: 0x06034A5A RID: 215642 RVA: 0x00C70D98 File Offset: 0x00C6EF98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034A5B RID: 215643 RVA: 0x00C70E04 File Offset: 0x00C6F004
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PlotReview_2", Array.Empty<object>());
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(1),
				ViewType = ETermExplanationViewType.Center,
				Group = new ETermExplanationGroup?(ETermExplanationGroup.PlotReview),
				ReportType = ETermExplanationReportType.PlotReview
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x06034A5C RID: 215644 RVA: 0x00C70E65 File Offset: 0x00C6F065
		protected override void OnBeforeHide()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
		}

		// Token: 0x06034A5D RID: 215645 RVA: 0x00C70E78 File Offset: 0x00C6F078
		[NullableContext(1)]
		public void Update(PlotReviewOptionItemData data, int index)
		{
			this.Data = data;
			this.Index = index;
			this.Refresh();
		}

		// Token: 0x06034A5E RID: 215646 RVA: 0x00C70E90 File Offset: 0x00C6F090
		public void Refresh()
		{
			ITalkItem talkItem = this.Data.TalkItem;
			if (talkItem == null)
			{
				return;
			}
			List<ITalkOption> options = talkItem.Options;
			if (options == null)
			{
				return;
			}
			int optionIndex = this.Data.OptionIndex;
			if (optionIndex < 0)
			{
				return;
			}
			ITalkOption talkOption = options[optionIndex];
			string text = PublicUtil.Instance.GetFlowConfigLocalText(talkOption.TidTalkOption);
			text = PlotModel.Instance.PlotTextReplacer.Replace(text, false);
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0401C0EF RID: 114927
		protected int Index = -1;

		// Token: 0x0401C0F0 RID: 114928
		[Nullable(2)]
		private PlotReviewOptionItemData Data;

		// Token: 0x0200B1C3 RID: 45507
		private static class EPlotReviewOptionItemComponent
		{
			// Token: 0x04035E8C RID: 220812
			public const int NameText = 0;

			// Token: 0x04035E8D RID: 220813
			public const int ContentText = 1;
		}
	}
}
