using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200402E RID: 16430
	public class PlotReviewOptionItem : UiPanelBase
	{
		// Token: 0x0602994D RID: 170317 RVA: 0x00BBE070 File Offset: 0x00BBC270
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

		// Token: 0x0602994E RID: 170318 RVA: 0x00BBE0DC File Offset: 0x00BBC2DC
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

		// Token: 0x0602994F RID: 170319 RVA: 0x00BBE13D File Offset: 0x00BBC33D
		protected override void OnBeforeHide()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
		}

		// Token: 0x06029950 RID: 170320 RVA: 0x00BBE150 File Offset: 0x00BBC350
		[NullableContext(1)]
		public void Update(PlotReviewOptionItemData data, int index)
		{
			this.Data = data;
			this.Index = index;
			this.Refresh();
		}

		// Token: 0x06029951 RID: 170321 RVA: 0x00BBE168 File Offset: 0x00BBC368
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

		// Token: 0x04016B1A RID: 92954
		protected int Index = -1;

		// Token: 0x04016B1B RID: 92955
		[Nullable(2)]
		private PlotReviewOptionItemData Data;

		// Token: 0x02009BFD RID: 39933
		private static class EPlotReviewOptionItemComponent
		{
			// Token: 0x040308E1 RID: 198881
			public const int NameText = 0;

			// Token: 0x040308E2 RID: 198882
			public const int ContentText = 1;
		}
	}
}
