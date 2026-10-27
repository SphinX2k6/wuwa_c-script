using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D5 RID: 20693
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowActionSetPlotMode : FlowActionBase
	{
		// Token: 0x06034F41 RID: 216897 RVA: 0x00C8B1DC File Offset: 0x00C893DC
		protected unsafe override void OnExecute()
		{
			this.DelayBlendInDialogueCamera = this.Context.HasAdjustCamera;
			SetPlotMode setPlotMode = this.ActionInfo.Params as SetPlotMode;
			if (this.Context != null)
			{
				this.Context.TalkHistory.Clear();
			}
			PlotModel.Instance.PlotConfig.SetMode(setPlotMode, false);
			PlotModel.Instance.ApplyPlotConfig(this.DelayBlendInDialogueCamera);
			this.NeedFade = setPlotMode.FastFadeIn;
			this.Context.IsWaitRenderData = (!setPlotMode.NoUiEnterAnimation.GetValueOrDefault() && !this.Context.SeamlessPlot);
			SequenceModel.Instance.SkipUiWaiting = this.Context.SeamlessPlot;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "SetPlotMode";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Level", setPlotMode.Mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChangeRole", setPlotMode.IsSwitchMainRole);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DisableAutoFadeOut", setPlotMode.DisableAutoFadeOut);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UiParam uiParam = this.Context.UiParam;
			if (uiParam != null && uiParam.ViewName != null && !UiManager.Instance.IsViewShow(this.Context.UiParam.ViewName.Value))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "剧情界面所依赖的界面未打开，本段剧情跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.Context.UiParam.ViewName);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.Context.IsBackground = true;
				base.FinishExecute(true, true);
				return;
			}
			FlowContext context = this.Context;
			if (context != null && context.SeamlessPlot && !FlowLaunchResCheckHardCodingList.TempDisableSequenceInertiaKeeper.Contains(this.Context.FormatId) && (setPlotMode.Mode == EPlotLevel.LevelA.ToEnumString() || setPlotMode.Mode == EPlotLevel.LevelB.ToEnumString()))
			{
				PlotSequenceInertiaKeeper.Instance.Start("FlowActionSetPlotMode.OnExecute");
			}
			FlowContext context2 = this.Context;
			this.CacheNeedPreloadUiSequenceData = ((context2 != null) ? context2.NeedPreloadUiSequenceData : null);
			EventSystem.Instance.Emit(EEventName.OnExecuteAfterSetPlotMode);
			UniTask.WhenAll(new List<UniTask>
			{
				this.WaitInteractTurnAndChangeRoleAsync(),
				this.CheckPosSafe(),
				this.LoadTypeAsync(),
				this.HandleViewAsync(setPlotMode)
			}).Finally(delegate()
			{
				base.FinishExecute(true, true);
			}).Forget();
		}

		// Token: 0x06034F42 RID: 216898 RVA: 0x00C8B488 File Offset: 0x00C89688
		[NullableContext(1)]
		private UniTask HandleViewAsync(SetPlotMode inSetPlotMode)
		{
			FlowActionSetPlotMode.<HandleViewAsync>d__11 <HandleViewAsync>d__;
			<HandleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleViewAsync>d__.<>4__this = this;
			<HandleViewAsync>d__.inSetPlotMode = inSetPlotMode;
			<HandleViewAsync>d__.<>1__state = -1;
			<HandleViewAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<HandleViewAsync>d__11>(ref <HandleViewAsync>d__);
			return <HandleViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F43 RID: 216899 RVA: 0x00C8B4D4 File Offset: 0x00C896D4
		private UniTask LoadTypeAsync()
		{
			FlowActionSetPlotMode.<LoadTypeAsync>d__12 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<LoadTypeAsync>d__12>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F44 RID: 216900 RVA: 0x00C8B510 File Offset: 0x00C89710
		private UniTask WaitInteractTurnAndChangeRoleAsync()
		{
			FlowActionSetPlotMode.<WaitInteractTurnAndChangeRoleAsync>d__13 <WaitInteractTurnAndChangeRoleAsync>d__;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitInteractTurnAndChangeRoleAsync>d__.<>4__this = this;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>1__state = -1;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitInteractTurnAndChangeRoleAsync>d__13>(ref <WaitInteractTurnAndChangeRoleAsync>d__);
			return <WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F45 RID: 216901 RVA: 0x00C8B554 File Offset: 0x00C89754
		private UniTask OpenViewAsync()
		{
			FlowActionSetPlotMode.<OpenViewAsync>d__14 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<OpenViewAsync>d__14>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F46 RID: 216902 RVA: 0x00C8B598 File Offset: 0x00C89798
		private UniTask PreloadSequenceUiAsync()
		{
			FlowActionSetPlotMode.<PreloadSequenceUiAsync>d__15 <PreloadSequenceUiAsync>d__;
			<PreloadSequenceUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadSequenceUiAsync>d__.<>4__this = this;
			<PreloadSequenceUiAsync>d__.<>1__state = -1;
			<PreloadSequenceUiAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<PreloadSequenceUiAsync>d__15>(ref <PreloadSequenceUiAsync>d__);
			return <PreloadSequenceUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034F47 RID: 216903 RVA: 0x00C8B5DC File Offset: 0x00C897DC
		private UniTask WaitFadeIn()
		{
			FlowActionSetPlotMode.<WaitFadeIn>d__16 <WaitFadeIn>d__;
			<WaitFadeIn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFadeIn>d__.<>4__this = this;
			<WaitFadeIn>d__.<>1__state = -1;
			<WaitFadeIn>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitFadeIn>d__16>(ref <WaitFadeIn>d__);
			return <WaitFadeIn>d__.<>t__builder.Task;
		}

		// Token: 0x06034F48 RID: 216904 RVA: 0x00C8B620 File Offset: 0x00C89820
		private UniTask WaitInteractTurnPromise()
		{
			FlowActionSetPlotMode.<WaitInteractTurnPromise>d__17 <WaitInteractTurnPromise>d__;
			<WaitInteractTurnPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitInteractTurnPromise>d__.<>4__this = this;
			<WaitInteractTurnPromise>d__.<>1__state = -1;
			<WaitInteractTurnPromise>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitInteractTurnPromise>d__17>(ref <WaitInteractTurnPromise>d__);
			return <WaitInteractTurnPromise>d__.<>t__builder.Task;
		}

		// Token: 0x06034F49 RID: 216905 RVA: 0x00C8B664 File Offset: 0x00C89864
		private void OnCheckTurn(float deltaTime)
		{
			if (InteractionModel.Instance.IsInteractionTurning && this.WaitTurnTime < 3000f)
			{
				this.WaitTurnTime += deltaTime;
				return;
			}
			PlotController.Instance.RemoveTick(this.WaitTurnTicker);
			this.WaitTurnTime = 0f;
			this.WaitTurnTicker = -1;
			this.WaitTurnPromise.SetResult();
			this.WaitTurnPromise = null;
		}

		// Token: 0x06034F4A RID: 216906 RVA: 0x00C8B6D0 File Offset: 0x00C898D0
		private UniTask CheckPosSafe()
		{
			FlowActionSetPlotMode.<CheckPosSafe>d__19 <CheckPosSafe>d__;
			<CheckPosSafe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPosSafe>d__.<>4__this = this;
			<CheckPosSafe>d__.<>1__state = -1;
			<CheckPosSafe>d__.<>t__builder.Start<FlowActionSetPlotMode.<CheckPosSafe>d__19>(ref <CheckPosSafe>d__);
			return <CheckPosSafe>d__.<>t__builder.Task;
		}

		// Token: 0x06034F4B RID: 216907 RVA: 0x00C8B714 File Offset: 0x00C89914
		private void OnTeleportComplete(TeleportContext context = null)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "剧情前保底传送 -结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			CustomPromise teleportPromise = this.TeleportPromise;
			this.TeleportPromise = null;
			teleportPromise.SetResult();
		}

		// Token: 0x06034F4C RID: 216908 RVA: 0x00C8B750 File Offset: 0x00C89950
		protected override void OnInterruptExecute()
		{
			if (EventSystem.Instance.Has<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete)))
			{
				EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
				this.OnTeleportComplete(null);
			}
		}

		// Token: 0x06034F4D RID: 216909 RVA: 0x00C8B7A0 File Offset: 0x00C899A0
		protected override void OnBackgroundExecute()
		{
			SetPlotMode setPlotMode = this.ActionInfo.Params as SetPlotMode;
			PlotModel.Instance.PlotConfig.SetMode(setPlotMode, false);
			PlotModel.Instance.ApplyPlotConfig(this.DelayBlendInDialogueCamera);
			PlotModel.Instance.IsFadeIn = (setPlotMode.FastFadeIn != null);
			base.FinishExecute(true, true);
		}

		// Token: 0x0401C30E RID: 115470
		private const float GUARANTEED_WAIT_TIME = 3000f;

		// Token: 0x0401C30F RID: 115471
		private const float DEFAULT_FADE_DURATION = 0.5f;

		// Token: 0x0401C310 RID: 115472
		private const float SAFE_DISTANCE_SQAURED = 3000f;

		// Token: 0x0401C311 RID: 115473
		private bool DelayBlendInDialogueCamera;

		// Token: 0x0401C312 RID: 115474
		private CustomPromise WaitTurnPromise;

		// Token: 0x0401C313 RID: 115475
		private int WaitTurnTicker = -1;

		// Token: 0x0401C314 RID: 115476
		private float WaitTurnTime;

		// Token: 0x0401C315 RID: 115477
		private FadeInScreen NeedFade;

		// Token: 0x0401C316 RID: 115478
		private CustomPromise TeleportPromise;

		// Token: 0x0401C317 RID: 115479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> CacheNeedPreloadUiSequenceData;
	}
}
