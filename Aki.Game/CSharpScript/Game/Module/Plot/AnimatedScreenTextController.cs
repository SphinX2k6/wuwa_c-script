using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003F9C RID: 16284
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class AnimatedScreenTextController : ControllerBase
	{
		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x06029323 RID: 168739 RVA: 0x00B911D2 File Offset: 0x00B8F3D2
		public bool UiTextDebugEnable
		{
			get
			{
				return this.UiTextDebugEnableInternal;
			}
		}

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06029324 RID: 168740 RVA: 0x00B911DA File Offset: 0x00B8F3DA
		public float? UiTextDebugFixedDuration
		{
			get
			{
				return this.UiTextDebugFixedDurationInternal;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x06029325 RID: 168741 RVA: 0x00B911E2 File Offset: 0x00B8F3E2
		public bool UiTextDebugShowWidthHeightRatio
		{
			get
			{
				return this.UiTextDebugShowWidthHeightRatioInternal;
			}
		}

		// Token: 0x06029326 RID: 168742 RVA: 0x00B911EA File Offset: 0x00B8F3EA
		protected override bool OnInit()
		{
			this.PendingParams = null;
			this.IsClosing = false;
			this.UiTextDebugEnableInternal = false;
			this.UiTextDebugFixedDurationInternal = null;
			this.UiTextDebugShowWidthHeightRatioInternal = false;
			return true;
		}

		// Token: 0x06029327 RID: 168743 RVA: 0x00B91218 File Offset: 0x00B8F418
		[return: TupleElementNames(new string[]
		{
			"PlotMode",
			"ShowTalk"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public unsafe ValueTuple<SetPlotMode, ShowTalk>? ParseFlow(PlayFlow flow)
		{
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flow.FlowListName, flow.FlowId, flow.StateId);
			if (flowStateActions == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.ZHZ;
				string message = "[AnimatedScreenTextController] 获取TalkItem失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			SetPlotMode setPlotMode = null;
			ShowTalk showTalk = null;
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.SetPlotMode)
				{
					setPlotMode = (actionInfo.Params as SetPlotMode);
				}
				if (actionInfo.Name == EAction.ShowTalk)
				{
					showTalk = (actionInfo.Params as ShowTalk);
				}
			}
			if (setPlotMode == null || showTalk == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.ZHZ;
				string message2 = "[AnimatedScreenTextController] 字幕流程缺少SetPlotMode或ShowTalk";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return null;
			}
			return new ValueTuple<SetPlotMode, ShowTalk>?(new ValueTuple<SetPlotMode, ShowTalk>(setPlotMode, showTalk));
		}

		// Token: 0x06029328 RID: 168744 RVA: 0x00B913EC File Offset: 0x00B8F5EC
		public unsafe void PlayByFlow(PlayFlow flow)
		{
			ValueTuple<SetPlotMode, ShowTalk>? valueTuple = this.ParseFlow(flow);
			if (valueTuple == null)
			{
				return;
			}
			IPlotModeUiStyleLevelD uiStyle = valueTuple.Value.Item1.UiStyle;
			IUiStyleBaseOfLevelD uiStyleBaseOfLevelD = (uiStyle != null) ? uiStyle.UiStyle : null;
			if (uiStyleBaseOfLevelD == null || uiStyleBaseOfLevelD.Type != EUiStyleTypeOfLevelD.PlayPiano)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.ZHZ;
				string message = "[AnimatedScreenTextController] 字幕流程缺少钢琴玩法UI样式";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			IUiStylePlayPianoOfLevelD uiStyle2 = (IUiStylePlayPianoOfLevelD)uiStyleBaseOfLevelD;
			this.Play(new AnimatedScreenTextParams(valueTuple.Value.Item2.TalkItems, uiStyle2));
		}

		// Token: 0x06029329 RID: 168745 RVA: 0x00B914EC File Offset: 0x00B8F6EC
		public void Play(AnimatedScreenTextParams @params)
		{
			AnimatedScreenTextView animatedScreenTextView = UiManager.Instance.GetViewByName(EUiViewName.AnimatedScreenTextView) as AnimatedScreenTextView;
			if (animatedScreenTextView != null && animatedScreenTextView.TryEnqueue(@params))
			{
				return;
			}
			this.PendingParams = @params;
			if (this.IsClosing)
			{
				return;
			}
			if (animatedScreenTextView != null)
			{
				this.CloseView(animatedScreenTextView);
				return;
			}
			this.OpenPendingView();
		}

		// Token: 0x0602932A RID: 168746 RVA: 0x00B9153C File Offset: 0x00B8F73C
		public void Stop()
		{
			this.PendingParams = null;
			if (this.IsClosing)
			{
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.AnimatedScreenTextView);
			if (viewByName != null)
			{
				this.CloseView(viewByName);
			}
		}

		// Token: 0x0602932B RID: 168747 RVA: 0x00B91574 File Offset: 0x00B8F774
		private void CloseView(UiViewBase view)
		{
			this.IsClosing = true;
			if (view.ClosePromise != null)
			{
				view.ClosePromise.Promise.ContinueWith(new Action(this.OnViewClosed));
				return;
			}
			UiManager.Instance.CloseViewById(view.GetViewId(), delegate(bool _)
			{
				this.OnViewClosed();
			});
		}

		// Token: 0x0602932C RID: 168748 RVA: 0x00B915CA File Offset: 0x00B8F7CA
		private void OnViewClosed()
		{
			this.IsClosing = false;
			this.OpenPendingView();
		}

		// Token: 0x0602932D RID: 168749 RVA: 0x00B915DC File Offset: 0x00B8F7DC
		private void OpenPendingView()
		{
			AnimatedScreenTextParams pendingParams = this.PendingParams;
			this.PendingParams = null;
			if (pendingParams != null)
			{
				UiManager.Instance.OpenView(EUiViewName.AnimatedScreenTextView, pendingParams, null);
			}
		}

		// Token: 0x0602932E RID: 168750 RVA: 0x00B9160B File Offset: 0x00B8F80B
		protected override bool OnLeaveLevel()
		{
			this.IsClosing = false;
			this.PendingParams = null;
			return true;
		}

		// Token: 0x0602932F RID: 168751 RVA: 0x00B9161C File Offset: 0x00B8F81C
		protected override bool OnClear()
		{
			this.IsClosing = false;
			this.PendingParams = null;
			this.UiTextDebugEnableInternal = false;
			this.UiTextDebugFixedDurationInternal = null;
			this.UiTextDebugShowWidthHeightRatioInternal = false;
			return true;
		}

		// Token: 0x06029330 RID: 168752 RVA: 0x00B91647 File Offset: 0x00B8F847
		public void SetUiTextDebugEnable(bool enable, float duration)
		{
			this.UiTextDebugEnableInternal = enable;
			this.UiTextDebugFixedDurationInternal = new float?(duration * 1000f);
			EventSystem.Instance.EmitWithTarget<bool, float>(this, EEventName.OnUiTextEnableUseDebugFixedDuration, enable, this.UiTextDebugFixedDurationInternal.Value);
		}

		// Token: 0x06029331 RID: 168753 RVA: 0x00B9167F File Offset: 0x00B8F87F
		public void SetUiTextDebugShowWidthHeightRatio(bool enable)
		{
			this.UiTextDebugShowWidthHeightRatioInternal = enable;
		}

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06029332 RID: 168754 RVA: 0x00B91688 File Offset: 0x00B8F888
		public static AnimatedScreenTextController Instance
		{
			get
			{
				return AnimatedScreenTextController._Instance;
			}
		}

		// Token: 0x06029333 RID: 168755 RVA: 0x00B9168F File Offset: 0x00B8F88F
		public static AnimatedScreenTextController GetOrCreateInstance()
		{
			if (AnimatedScreenTextController._Instance == null)
			{
				AnimatedScreenTextController.CreateInstance();
			}
			return AnimatedScreenTextController._Instance;
		}

		// Token: 0x06029334 RID: 168756 RVA: 0x00B916A3 File Offset: 0x00B8F8A3
		public static bool CreateInstance()
		{
			if (AnimatedScreenTextController._Instance != null)
			{
				return true;
			}
			AnimatedScreenTextController._Instance = new AnimatedScreenTextController();
			return true;
		}

		// Token: 0x06029335 RID: 168757 RVA: 0x00B916B9 File Offset: 0x00B8F8B9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029336 RID: 168758 RVA: 0x00B916BB File Offset: 0x00B8F8BB
		public static void ResetStaticDefaultValue()
		{
			AnimatedScreenTextController._Instance = null;
		}

		// Token: 0x06029337 RID: 168759 RVA: 0x00B916C3 File Offset: 0x00B8F8C3
		static AnimatedScreenTextController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnimatedScreenTextController.CreateStaticDefaultValue), new Action(AnimatedScreenTextController.ResetStaticDefaultValue));
		}

		// Token: 0x040166D4 RID: 91860
		[Nullable(2)]
		private AnimatedScreenTextParams PendingParams;

		// Token: 0x040166D5 RID: 91861
		private bool IsClosing;

		// Token: 0x040166D6 RID: 91862
		private bool UiTextDebugEnableInternal;

		// Token: 0x040166D7 RID: 91863
		private float? UiTextDebugFixedDurationInternal;

		// Token: 0x040166D8 RID: 91864
		private bool UiTextDebugShowWidthHeightRatioInternal;

		// Token: 0x040166D9 RID: 91865
		[Nullable(2)]
		private static AnimatedScreenTextController _Instance;
	}
}
