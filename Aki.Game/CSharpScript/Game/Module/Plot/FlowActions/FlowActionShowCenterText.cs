using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D8 RID: 20696
	public class FlowActionShowCenterText : FlowActionBase
	{
		// Token: 0x06034F57 RID: 216919 RVA: 0x00C8B8C4 File Offset: 0x00C89AC4
		protected unsafe override void OnExecute()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "黑屏白字行为不再维护，请策划使用ShowTalk形式的黑幕白字";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", this.Context.FormatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("action", this.ActionInfo.ActionId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			ShowCenterText inShowCenterText = this.ActionInfo.Params as ShowCenterText;
			PlotModel.Instance.ShowCenterText(inShowCenterText, new Action(this.OnShowCenterTextFinished));
		}

		// Token: 0x06034F58 RID: 216920 RVA: 0x00C8B965 File Offset: 0x00C89B65
		private void OnShowCenterTextFinished()
		{
			this.Runner.FinishShowCenterTextAction(delegate
			{
				base.FinishExecute(true, true);
			});
		}

		// Token: 0x06034F59 RID: 216921 RVA: 0x00C8B97E File Offset: 0x00C89B7E
		protected override void OnInterruptExecute()
		{
			EventSystem.Instance.Emit(EEventName.OnPlotTransitionRemoveCallback);
			if (UiManager.Instance.IsViewShow(EUiViewName.PlotTransitionView))
			{
				UiManager.Instance.CloseView(EUiViewName.PlotTransitionView, null);
			}
			base.FinishExecute(true, true);
		}
	}
}
