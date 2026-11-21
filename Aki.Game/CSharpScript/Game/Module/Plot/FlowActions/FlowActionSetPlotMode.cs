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
	// Token: 0x020040A5 RID: 16549
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowActionSetPlotMode : FlowActionBase
	{
		// Token: 0x06029E3A RID: 171578 RVA: 0x00BD84C4 File Offset: 0x00BD66C4
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

		// Token: 0x06029E3B RID: 171579 RVA: 0x00BD8770 File Offset: 0x00BD6970
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

		// Token: 0x06029E3C RID: 171580 RVA: 0x00BD87BC File Offset: 0x00BD69BC
		private UniTask LoadTypeAsync()
		{
			FlowActionSetPlotMode.<LoadTypeAsync>d__12 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<LoadTypeAsync>d__12>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E3D RID: 171581 RVA: 0x00BD87F8 File Offset: 0x00BD69F8
		private UniTask WaitInteractTurnAndChangeRoleAsync()
		{
			FlowActionSetPlotMode.<WaitInteractTurnAndChangeRoleAsync>d__13 <WaitInteractTurnAndChangeRoleAsync>d__;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitInteractTurnAndChangeRoleAsync>d__.<>4__this = this;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>1__state = -1;
			<WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitInteractTurnAndChangeRoleAsync>d__13>(ref <WaitInteractTurnAndChangeRoleAsync>d__);
			return <WaitInteractTurnAndChangeRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E3E RID: 171582 RVA: 0x00BD883C File Offset: 0x00BD6A3C
		private UniTask OpenViewAsync()
		{
			FlowActionSetPlotMode.<OpenViewAsync>d__14 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<OpenViewAsync>d__14>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E3F RID: 171583 RVA: 0x00BD8880 File Offset: 0x00BD6A80
		private UniTask PreloadSequenceUiAsync()
		{
			FlowActionSetPlotMode.<PreloadSequenceUiAsync>d__15 <PreloadSequenceUiAsync>d__;
			<PreloadSequenceUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadSequenceUiAsync>d__.<>4__this = this;
			<PreloadSequenceUiAsync>d__.<>1__state = -1;
			<PreloadSequenceUiAsync>d__.<>t__builder.Start<FlowActionSetPlotMode.<PreloadSequenceUiAsync>d__15>(ref <PreloadSequenceUiAsync>d__);
			return <PreloadSequenceUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029E40 RID: 171584 RVA: 0x00BD88C4 File Offset: 0x00BD6AC4
		private UniTask WaitFadeIn()
		{
			FlowActionSetPlotMode.<WaitFadeIn>d__16 <WaitFadeIn>d__;
			<WaitFadeIn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFadeIn>d__.<>4__this = this;
			<WaitFadeIn>d__.<>1__state = -1;
			<WaitFadeIn>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitFadeIn>d__16>(ref <WaitFadeIn>d__);
			return <WaitFadeIn>d__.<>t__builder.Task;
		}

		// Token: 0x06029E41 RID: 171585 RVA: 0x00BD8908 File Offset: 0x00BD6B08
		private UniTask WaitInteractTurnPromise()
		{
			FlowActionSetPlotMode.<WaitInteractTurnPromise>d__17 <WaitInteractTurnPromise>d__;
			<WaitInteractTurnPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitInteractTurnPromise>d__.<>4__this = this;
			<WaitInteractTurnPromise>d__.<>1__state = -1;
			<WaitInteractTurnPromise>d__.<>t__builder.Start<FlowActionSetPlotMode.<WaitInteractTurnPromise>d__17>(ref <WaitInteractTurnPromise>d__);
			return <WaitInteractTurnPromise>d__.<>t__builder.Task;
		}

		// Token: 0x06029E42 RID: 171586 RVA: 0x00BD894C File Offset: 0x00BD6B4C
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

		// Token: 0x06029E43 RID: 171587 RVA: 0x00BD89B8 File Offset: 0x00BD6BB8
		private UniTask CheckPosSafe()
		{
			FlowActionSetPlotMode.<CheckPosSafe>d__19 <CheckPosSafe>d__;
			<CheckPosSafe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPosSafe>d__.<>4__this = this;
			<CheckPosSafe>d__.<>1__state = -1;
			<CheckPosSafe>d__.<>t__builder.Start<FlowActionSetPlotMode.<CheckPosSafe>d__19>(ref <CheckPosSafe>d__);
			return <CheckPosSafe>d__.<>t__builder.Task;
		}

		// Token: 0x06029E44 RID: 171588 RVA: 0x00BD89FC File Offset: 0x00BD6BFC
		private void OnTeleportComplete(TeleportContext context = null)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "剧情前保底传送 -结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			CustomPromise teleportPromise = this.TeleportPromise;
			this.TeleportPromise = null;
			teleportPromise.SetResult();
		}

		// Token: 0x06029E45 RID: 171589 RVA: 0x00BD8A38 File Offset: 0x00BD6C38
		protected override void OnInterruptExecute()
		{
			if (EventSystem.Instance.Has<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete)))
			{
				EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
				this.OnTeleportComplete(null);
			}
		}

		// Token: 0x06029E46 RID: 171590 RVA: 0x00BD8A88 File Offset: 0x00BD6C88
		protected override void OnBackgroundExecute()
		{
			SetPlotMode setPlotMode = this.ActionInfo.Params as SetPlotMode;
			PlotModel.Instance.PlotConfig.SetMode(setPlotMode, false);
			PlotModel.Instance.ApplyPlotConfig(this.DelayBlendInDialogueCamera);
			PlotModel.Instance.IsFadeIn = (setPlotMode.FastFadeIn != null);
			base.FinishExecute(true, true);
		}

		// Token: 0x04016D3F RID: 93503
		private const float GUARANTEED_WAIT_TIME = 3000f;

		// Token: 0x04016D40 RID: 93504
		private const float DEFAULT_FADE_DURATION = 0.5f;

		// Token: 0x04016D41 RID: 93505
		private const float SAFE_DISTANCE_SQAURED = 3000f;

		// Token: 0x04016D42 RID: 93506
		private bool DelayBlendInDialogueCamera;

		// Token: 0x04016D43 RID: 93507
		private CustomPromise WaitTurnPromise;

		// Token: 0x04016D44 RID: 93508
		private int WaitTurnTicker = -1;

		// Token: 0x04016D45 RID: 93509
		private float WaitTurnTime;

		// Token: 0x04016D46 RID: 93510
		private FadeInScreen NeedFade;

		// Token: 0x04016D47 RID: 93511
		private CustomPromise TeleportPromise;

		// Token: 0x04016D48 RID: 93512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> CacheNeedPreloadUiSequenceData;
	}
}
