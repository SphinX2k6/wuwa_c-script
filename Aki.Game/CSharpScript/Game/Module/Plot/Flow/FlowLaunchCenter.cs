using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200406C RID: 16492
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowLaunchCenter : ControllerAssistantBase, IStaticVariableResetter
	{
		// Token: 0x06029D1E RID: 171294 RVA: 0x00BD037F File Offset: 0x00BCE57F
		protected override void OnDestroy()
		{
		}

		// Token: 0x06029D1F RID: 171295 RVA: 0x00BD0381 File Offset: 0x00BCE581
		static FlowLaunchCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowLaunchCenter.CreateStaticDefaultValue), new Action(FlowLaunchCenter.ResetStaticDefaultValue));
		}

		// Token: 0x06029D20 RID: 171296 RVA: 0x00BD03A0 File Offset: 0x00BCE5A0
		public static void CreateStaticDefaultValue()
		{
			FlowLaunchCenter.LocalFlowIncId = -1;
		}

		// Token: 0x06029D21 RID: 171297 RVA: 0x00BD03A8 File Offset: 0x00BCE5A8
		public static void ResetStaticDefaultValue()
		{
			FlowLaunchCenter.LocalFlowIncId = -1;
		}

		// Token: 0x06029D22 RID: 171298 RVA: 0x00BD03B0 File Offset: 0x00BCE5B0
		protected override void OnInit()
		{
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.LoadingDone, "场景未加载完", this.OnCheckLoading));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.UiReady, "界面检查不通过", new Func<float, PlotInfo, bool>(this.OnCheckUi)));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.TeleportDone, "传送未完成", this.OnCheckTeleport));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.AllPlayerAlive, "死亡或者队伍没人", this.OnCheckAllPlayerAlive));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.CurPlayerAlive, "当前角色死亡", this.OnCheckCurPlayerAlive));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.FormationReady, "编队未准备好", new Func<float, PlotInfo, bool>(this.OnCheckFormation)));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.CharAnimReady, "人物动作还没回正", new Func<float, PlotInfo, bool>(this.OnCheckCharAnim)));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.PreloadReady, "预加载未完成", this.OnCheckPreload));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.PlotCaption, "处于报幕中", this.OnCheckPlotCaption));
			this.CheckList.Add(new ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>(FlowLaunchCenter.ECheckType.TransitionFlowWaitWorldDoneEnd, "个别传送过渡Seq要在WorldDoneEnd后", new Func<float, PlotInfo, bool>(this.OnCheckTransitionFlowWaitWorldDoneEnd)));
			for (int i = 0; i < this.CheckList.Count; i++)
			{
				if (this.CheckList[i].Item1 != (FlowLaunchCenter.ECheckType)i)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "剧情开始检查队列顺序错误";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", i);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x06029D23 RID: 171299 RVA: 0x00BD0544 File Offset: 0x00BCE744
		[NullableContext(2)]
		public unsafe long StartFlow([Nullable(1)] string flowListName, int flowId, int stateId, GeneralContext context = null, long flowIncId = -1L, bool isServerNotify = false, bool isAsync = false, UiParam uiParam = null, bool canBeAbandoned = false, bool isSkip = false, Vector pos = null, Action callback = null, bool isTeleportTransition = false)
		{
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowListName, flowId, stateId);
			if (flowStateActions == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[StartFlow] 无法找到对应剧情的状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", flowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", flowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", stateId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return 0L;
			}
			long num = isServerNotify ? flowIncId : ((long)FlowLaunchCenter.LocalFlowIncId--);
			GeneralContext context2 = (context != null) ? GeneralContext.Copy(context) : null;
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Plot;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "StartFlow";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FLowIncId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowListName", flowListName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FlowId", flowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("StateId", stateId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			EventSystem.Instance.Emit<long>(EEventName.OnStartFlow, num);
			bool? flowStateKeepMusic = FlowConfig.Instance.GetFlowStateKeepMusic(flowListName, flowId, stateId);
			IStateProgramSpecialProcessChangeTeamOptimization flowProgramSpecialProcess = FlowConfig.Instance.GetFlowProgramSpecialProcess(flowListName, flowId, stateId);
			bool? flowNeedLoad = FlowConfig.Instance.GetFlowNeedLoad(flowListName, flowId, stateId);
			bool flag = AutoRunModel.Instance.IsInLogicTreeGmMode() || PlotModel.Instance.IsMuteAllPlot || isSkip;
			if (flowNeedLoad.GetValueOrDefault() && !flag)
			{
				PreloadControllerNew.Instance.PreloadPlot(flowListName, flowId, stateId, 999);
				PreloadControllerNew.Instance.PreloadPlotUi(flowListName, flowId, stateId);
			}
			PlotInfo plotInfo = PlotInfo.Create();
			plotInfo.Init(isServerNotify, num, flowListName, flowId, stateId, flowStateActions, flowStateKeepMusic.GetValueOrDefault(), context2, isAsync, uiParam, canBeAbandoned, isSkip, pos, flowNeedLoad.GetValueOrDefault(), callback, isTeleportTransition, flowProgramSpecialProcess);
			PlotModel.Instance.IsTeleportTransitionSeq = isTeleportTransition;
			if (this.CheckStateCanPlay(plotInfo, 0f))
			{
				this.StartFlowByPlotInfo(plotInfo);
			}
			else
			{
				PlotModel.Instance.PendingPlot(plotInfo);
				this.NeedPlay = true;
				FlowController.Instance.CheckDisableInput(new EPlotLevel?(plotInfo.PlotLevel), plotInfo.Seamless, FlowLaunchResCheckHardCodingList.TempDisableSequenceInertiaKeeper.Contains(plotInfo.FormatId));
			}
			PlotModel.Instance.AnsPreloadMark = false;
			PlotController.Instance.ClearAnsPreloadGuaranteeCache();
			return num;
		}

		// Token: 0x06029D24 RID: 171300 RVA: 0x00BD07CC File Offset: 0x00BCE9CC
		public unsafe void StartPlotNetworkPending()
		{
			if (PlotModel.Instance.IsInPlot)
			{
				return;
			}
			if (PlotModel.Instance.PlotPendingList.Count == 0)
			{
				return;
			}
			PlotInfo plotInfo = PlotModel.Instance.PlotPendingList[0];
			if (!this.CheckStateCanPlay(plotInfo, 0f))
			{
				this.NeedPlay = true;
				return;
			}
			PlotModel.Instance.PlotPendingList.RemoveAt(0);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "开始缓存的剧情";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowIncId", plotInfo.FlowIncId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowListName", plotInfo.FlowListName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", plotInfo.FlowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("StateID", plotInfo.StateId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.StartFlowByPlotInfo(plotInfo);
		}

		// Token: 0x06029D25 RID: 171301 RVA: 0x00BD08DC File Offset: 0x00BCEADC
		public unsafe void Tick(float delta)
		{
			if (!this.NeedPlay)
			{
				return;
			}
			PlotInfo plotInfo = (PlotModel.Instance.PlotPendingList.Count > 0) ? PlotModel.Instance.PlotPendingList[0] : null;
			if (plotInfo == null)
			{
				this.NeedPlay = false;
				return;
			}
			if (this.CheckStateCanPlay(plotInfo, delta))
			{
				PlotModel.Instance.PlotPendingList.RemoveAt(0);
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "开始缓存的剧情";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowIncId", plotInfo.FlowIncId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowListName", plotInfo.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", plotInfo.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("StateID", plotInfo.StateId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				this.NeedPlay = false;
				this.StartFlowByPlotInfo(plotInfo);
			}
		}

		// Token: 0x06029D26 RID: 171302 RVA: 0x00BD09F4 File Offset: 0x00BCEBF4
		private unsafe bool CheckStateCanPlay(PlotInfo plotInfo, float deltaTime = 0f)
		{
			if (plotInfo.IsBreakdown)
			{
				this.CurCheckType = FlowLaunchCenter.ECheckType.None;
				return true;
			}
			if (this.CurCheckType != FlowLaunchCenter.ECheckType.None && !this.CheckList[(int)this.CurCheckType].Item3(deltaTime, plotInfo))
			{
				return false;
			}
			foreach (ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>> valueTuple in this.CheckList)
			{
				if (valueTuple.Item1 != this.CurCheckType && !valueTuple.Item3(deltaTime, plotInfo))
				{
					this.CurCheckType = valueTuple.Item1;
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "剧情开始检查不通过";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", valueTuple.Item2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", plotInfo.FlowIncId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
			}
			this.CurCheckType = FlowLaunchCenter.ECheckType.None;
			return true;
		}

		// Token: 0x06029D27 RID: 171303 RVA: 0x00BD0B20 File Offset: 0x00BCED20
		private unsafe bool OnCheckUi(float delta, PlotInfo plotInfo)
		{
			if (BlackScreenFadeController.Instance.GetIsFadeIn() && BlackScreenFadeController.Instance.CheckIfInCommon())
			{
				this.UiCheckTime = 0f;
				return true;
			}
			if (plotInfo.Seamless)
			{
				return true;
			}
			UiParam uiParam = plotInfo.UiParam;
			if (uiParam != null && uiParam.ViewName != null)
			{
				EUiViewName? euiViewName = (plotInfo.UiParam.ViewName == EUiViewName.BattleView) ? new EUiViewName?(UiModel.Instance.MainViewName) : plotInfo.UiParam.ViewName;
				if (UiManager.Instance.IsViewShow(euiViewName.Value))
				{
					this.UiCheckTime = 0f;
					return true;
				}
				this.UiCheckTime += delta;
				if (plotInfo.CanBeAbandoned || this.UiCheckTime >= 20000f)
				{
					plotInfo.IsBreakdown = true;
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "剧情检查条件不通过，且允许被舍弃，丢了";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("incId", plotInfo.FlowIncId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowListName", plotInfo.FlowListName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("flowId", plotInfo.FlowId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stateId", plotInfo.StateId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					this.UiCheckTime = 0f;
					return true;
				}
				return false;
			}
			else
			{
				UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Plot);
				EUiViewName? euiViewName2;
				if (topView == null)
				{
					euiViewName2 = null;
				}
				else
				{
					UiViewInfo viewInfo = topView.ViewInfo;
					euiViewName2 = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
				}
				EUiViewName? euiViewName3 = euiViewName2;
				EUiViewName? euiViewName4;
				if (euiViewName3 == null)
				{
					UiViewBase topView2 = UiModel.Instance.GetTopView(ELayerType.Normal);
					if (topView2 == null)
					{
						euiViewName4 = null;
					}
					else
					{
						UiViewInfo viewInfo2 = topView2.ViewInfo;
						euiViewName4 = ((viewInfo2 != null) ? new EUiViewName?(viewInfo2.Name) : null);
					}
				}
				else
				{
					euiViewName4 = euiViewName3;
				}
				EUiViewName? euiViewName5 = euiViewName4;
				if (euiViewName5 == null)
				{
					return false;
				}
				if (this.EnableView.Contains(euiViewName5.Value))
				{
					return UiManager.Instance.IsViewShow(euiViewName5.Value);
				}
				return UiManager.Instance.CheckIfCanShowPlotView() || ScreenEffectModel.Instance.GetIsGeneralScreenEffectActive();
			}
		}

		// Token: 0x06029D28 RID: 171304 RVA: 0x00BD0D9E File Offset: 0x00BCEF9E
		private bool OnCheckFormation(float delta, PlotInfo plotInfo)
		{
			return AutoRunModel.Instance.IsInLogicTreeGmMode() || this.TempSkipFormationCheck.Contains(plotInfo.FormatId) || SceneTeamModel.Instance.IsTeamReady;
		}

		// Token: 0x06029D29 RID: 171305 RVA: 0x00BD0DD0 File Offset: 0x00BCEFD0
		private bool OnCheckCharAnim(float delta, PlotInfo plotInfo)
		{
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				return true;
			}
			if (plotInfo.PlotLevel != EPlotLevel.LevelC && !plotInfo.IsWaitAnim)
			{
				return true;
			}
			if (this.DeltaForCalm > PlotModel.Instance.PlotGlobalConfig.WaitCalmTime)
			{
				this.DeltaForCalm = 0f;
				return true;
			}
			BaseTagComponent baseTagComponent = SceneTeamModel.Instance.GetCurrentEntity.Entity.CheckGetComponent<BaseTagComponent>();
			if (baseTagComponent == null || !baseTagComponent.Valid)
			{
				this.DeltaForCalm = 0f;
				return true;
			}
			if (!baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
			{
				this.DeltaForCalm = 0f;
				return true;
			}
			this.DeltaForCalm += delta;
			return false;
		}

		// Token: 0x06029D2A RID: 171306 RVA: 0x00BD0E88 File Offset: 0x00BCF088
		private bool OnCheckTransitionFlowWaitWorldDoneEnd(float delta, PlotInfo plotInfo)
		{
			if (!this.TransitionFlowNeedWaitForWorldDoneEnd.Contains(plotInfo.FormatId))
			{
				return true;
			}
			ELoadingPhase loadingPhase = GameModeModel.Instance.LoadingPhase;
			return loadingPhase <= ELoadingPhase.Finished || loadingPhase >= ELoadingPhase.WorldDoneEnd;
		}

		// Token: 0x06029D2B RID: 171307 RVA: 0x00BD0EC3 File Offset: 0x00BCF0C3
		public static void ApplyTemporaryLowQuality()
		{
			GameSettingsUtils.ApplyImageQualityOnly(0);
			GameSettingsUtils.ApplyVegetationDensity(0);
			GameSettingsUtils.ApplySkinDamageMode(0);
			GameSettingsUtils.ApplyBloomEnable(0);
			GameSettingsUtils.ApplyImageDetail(0);
			GameSettingsUtils.ApplyNiagaraQuality(0);
			GameSettingsUtils.ApplyMobileResolution(0);
		}

		// Token: 0x06029D2C RID: 171308 RVA: 0x00BD0EF8 File Offset: 0x00BCF0F8
		public static void ReApplyTemporaryLowQuality()
		{
			GameSettingsManager.Instance.ReApply(EFunction.IMAGEQUALITY, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.VegetationDensity, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.SkinDamageMode, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.BLOOM, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.IMAGEDETAIL, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.SHADOWQUALITY, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.NIAGARAQUALITY, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.MOBILERESOLUTION, EGameSettingsApplyReason.AnyTime, true);
		}

		// Token: 0x06029D2D RID: 171309 RVA: 0x00BD0F88 File Offset: 0x00BCF188
		private unsafe void StartFlowByPlotInfo(PlotInfo plotInfo)
		{
			if (PlotModel.Instance.IsInInteraction)
			{
				PlotController.Instance.EndInteraction(true, false);
			}
			if (!PlotModel.Instance.CheckCanPlayNow(plotInfo))
			{
				return;
			}
			PlotController.Instance.OnStartPlotNetwork(plotInfo);
			bool flag = AutoRunModel.Instance.IsInLogicTreeGmMode() || PlotModel.Instance.IsMuteAllPlot || plotInfo.IsBackground;
			if (flag)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "剧情开始时被跳过";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsInLogicTreeGmMode", AutoRunModel.Instance.IsInLogicTreeGmMode());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsMuteAllPlot", PlotModel.Instance.IsMuteAllPlot);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsBackground", plotInfo.IsBackground);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			FlowContext flowContext = FlowContext.Create();
			flowContext.Init(plotInfo, flag);
			if (this.TempEnablePlotStreamingSource.Contains(flowContext.FormatId))
			{
				PlotController.Instance.TogglePlotStreamingSource(true);
			}
			Vector vector;
			if (this.IndependentStreamingSource.TryGetValue(flowContext.FormatId, out vector))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.HWK;
				string message2 = "使用独立流源Start";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("id", flowContext.FormatId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("pos", vector);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				PlotController.Instance.TogglePlotIndependentStreaming(true, vector);
			}
			bool tempEnableWorldOrigin = !flag && !plotInfo.IsBreakdown && this.TempEnableWorldOrigin.Contains(flowContext.FormatId) && !WorldController.Instance.EnableWorldOrigin;
			if (tempEnableWorldOrigin)
			{
				WorldController.Instance.SetEnableWorldOriginForPlot(true, flowContext.FormatId);
			}
			if (FlowLaunchResCheckHardCodingList.TempDisableWorldOffsetZ.Contains(flowContext.FormatId))
			{
				WorldController.Instance.SetEnableZAxisOffset(false, "剧情流程开始");
			}
			if (Info.Instance.IsLowMemoryDevice && this.LowQualityPlot.Contains(flowContext.FormatId))
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Plot;
				ELogAuthor author3 = ELogAuthor.FZX;
				string message3 = "LowQualityPlot";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", flowContext.FormatId);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				FlowLaunchCenter.ApplyTemporaryLowQuality();
			}
			if (this.DebugProtectedPlot.Contains(flowContext.FormatId))
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.Plot;
				ELogAuthor author4 = ELogAuthor.FZX;
				string message4 = "DebugProtectedPlot";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", flowContext.FormatId);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.DebugProtectedPlotTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					PlotController.Instance.CloseAllUi(null);
					FlowController.Instance.BackgroundFlow("DebugProtectedPlot", true, false, false);
				}, 30000f, null, null, true, 1f);
			}
			BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
			if (bpEventManager != null)
			{
				bpEventManager.演出状态改变时.Broadcast(flowContext.FormatId, EPlotState.Start);
			}
			FlowController.Instance.ExecuteActions(plotInfo.StateActions, flowContext, delegate
			{
				if (this.TempEnablePlotStreamingSource.Contains(flowContext.FormatId))
				{
					PlotController.Instance.TogglePlotStreamingSource(false);
				}
				if (this.IndependentStreamingSource.ContainsKey(flowContext.FormatId))
				{
					PlotController.Instance.TogglePlotIndependentStreaming(false, null);
					global::Log instance5 = global::Log.Instance;
					ELogModule module5 = ELogModule.Plot;
					ELogAuthor author5 = ELogAuthor.HWK;
					string message5 = "使用独立流源End";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", flowContext.FormatId);
					instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
				if (FlowLaunchResCheckHardCodingList.TempDisableWorldOffsetZ.Contains(flowContext.FormatId))
				{
					WorldController.Instance.SetEnableZAxisOffset(true, "剧情流程结束");
				}
				if (tempEnableWorldOrigin)
				{
					WorldController.Instance.SetEnableWorldOriginForPlot(false, flowContext.FormatId);
				}
				if (Info.Instance.IsLowMemoryDevice && this.LowQualityPlot.Contains(flowContext.FormatId))
				{
					global::Log instance6 = global::Log.Instance;
					ELogModule module6 = ELogModule.Plot;
					ELogAuthor author6 = ELogAuthor.FZX;
					string message6 = "LowQualityPlot恢复";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("id", flowContext.FormatId);
					instance6.Info(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					FlowLaunchCenter.ReApplyTemporaryLowQuality();
				}
				TimerHandle debugProtectedPlotTimer = this.DebugProtectedPlotTimer;
				if (debugProtectedPlotTimer != null)
				{
					debugProtectedPlotTimer.Remove();
				}
				this.DebugProtectedPlotTimer = null;
				PlotController.Instance.OnEndPlotNetwork();
				BP_EventManager_C bpEventManager2 = GlobalData.BpEventManager;
				if (bpEventManager2 != null)
				{
					bpEventManager2.演出状态改变时.Broadcast(flowContext.FormatId, EPlotState.End);
				}
				if (flowContext.Callback != null)
				{
					flowContext.Callback();
					flowContext.Callback = null;
					global::Log instance7 = global::Log.Instance;
					ELogModule module7 = ELogModule.Plot;
					ELogAuthor author7 = ELogAuthor.JYS;
					string message7 = "执行了flowContext的Callback";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("incId", flowContext.FlowIncId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("id", flowContext.FormatId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("IsSkip", flowContext.IsBackground);
					instance7.Info(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				}
				global::Log instance8 = global::Log.Instance;
				ELogModule module8 = ELogModule.Plot;
				ELogAuthor author8 = ELogAuthor.FZX;
				string message8 = "EndFlow";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("incId", flowContext.FlowIncId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("id", flowContext.FormatId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("IsSkip", flowContext.IsBackground);
				instance8.Info(module8, author8, message8, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				flowContext.Recycle();
				this.StartPlotNetworkPending();
			});
			plotInfo.Recycle();
		}

		// Token: 0x04016CEA RID: 93418
		private static int LocalFlowIncId;

		// Token: 0x04016CEB RID: 93419
		private bool NeedPlay;

		// Token: 0x04016CEC RID: 93420
		private float DeltaForCalm;

		// Token: 0x04016CED RID: 93421
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1
		})]
		private readonly List<ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>> CheckList = new List<ValueTuple<FlowLaunchCenter.ECheckType, string, Func<float, PlotInfo, bool>>>();

		// Token: 0x04016CEE RID: 93422
		private FlowLaunchCenter.ECheckType CurCheckType = FlowLaunchCenter.ECheckType.None;

		// Token: 0x04016CEF RID: 93423
		private readonly Func<float, PlotInfo, bool> OnCheckLoading = delegate(float delta, PlotInfo plotInfo)
		{
			if (plotInfo.IsTeleportTransition)
			{
				return true;
			}
			if (LoadingModel.Instance.IsLoading || !GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				if (plotInfo.FadeBegin != null)
				{
					global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "Loading期间准备播剧情，提前打开黑幕", default(ReadOnlySpan<ValueTuple<string, object>>));
					LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "Flow_CheckLoading", null, new object[]
					{
						0,
						plotInfo.FadeBegin,
						false,
						false
					});
					plotInfo.FadeBegin = null;
				}
				return false;
			}
			return true;
		};

		// Token: 0x04016CF0 RID: 93424
		private readonly HashSet<EUiViewName> EnableView = new HashSet<EUiViewName>
		{
			EUiViewName.PlotView,
			EUiViewName.PlotSubtitleView
		};

		// Token: 0x04016CF1 RID: 93425
		private float UiCheckTime;

		// Token: 0x04016CF2 RID: 93426
		private readonly Func<float, PlotInfo, bool> OnCheckTeleport = (float delta, PlotInfo plotInfo) => plotInfo.IsTeleportTransition || !TeleportModel.Instance.IsTeleport;

		// Token: 0x04016CF3 RID: 93427
		private readonly Func<float, PlotInfo, bool> OnCheckAllPlayerAlive = (float delta, PlotInfo plotInfo) => AutoRunModel.Instance.IsInLogicTreeGmMode() || !SceneTeamModel.Instance.IsAllDid();

		// Token: 0x04016CF4 RID: 93428
		private readonly Func<float, PlotInfo, bool> OnCheckCurPlayerAlive = delegate(float delta, PlotInfo plotInfo)
		{
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				return true;
			}
			SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
			return getCurrentTeamItem != null && !getCurrentTeamItem.IsDead();
		};

		// Token: 0x04016CF5 RID: 93429
		private readonly Func<float, PlotInfo, bool> OnCheckPreload = delegate(float delta, PlotInfo plotInfo)
		{
			ELoadResultType eloadResultType;
			return !plotInfo.CheckPreload || ((!PreloadModelNew.Instance.PlotAssetManager.LoadStateMap.TryGetValue(plotInfo.FormatId, out eloadResultType) || eloadResultType != ELoadResultType.Loading) && !PreloadModelNew.Instance.PlotUiAssetManager.IsLoading(plotInfo.FormatId) && !PreloadModelNew.Instance.PlotUiAssetManager.IsHanging(plotInfo.FormatId));
		};

		// Token: 0x04016CF6 RID: 93430
		private readonly Func<float, PlotInfo, bool> OnCheckPlotCaption = (float delta, PlotInfo plotInfo) => !PlotCaptionImageController.Instance.IsInPlotCaption;

		// Token: 0x04016CF7 RID: 93431
		private readonly HashSet<string> TempEnablePlotStreamingSource = new HashSet<string>
		{
			"剧情_2_6_狄斯台地主线_上半_1,25,1",
			"剧情_2_0_黎那汐塔主线_第一幕,1,1"
		};

		// Token: 0x04016CF8 RID: 93432
		private readonly HashSet<string> TempEnableWorldOrigin = new HashSet<string>
		{
			"剧情_3_7_一级POI_愧心域,50,1"
		};

		// Token: 0x04016CF9 RID: 93433
		private readonly Dictionary<string, Vector> IndependentStreamingSource = new Dictionary<string, Vector>
		{
			{
				"剧情_2_5_隐海试验场_声骸培养场,1,23",
				Vector.Create(194400.0, 155500.0, -165850.0)
			},
			{
				"剧情_2_5_隐海试验场_声骸培养场,1,9",
				Vector.Create(161705.0, 133164.0, -166068.0)
			},
			{
				"剧情_2_5_隐海试验场_声骸培养场,6,1",
				Vector.Create(345600.0, -6581.0, -165980.0)
			}
		};

		// Token: 0x04016CFA RID: 93434
		private readonly HashSet<string> LowQualityPlot = new HashSet<string>
		{
			"剧情_3_0_主线_拉海洛主线_上半_1,35,1"
		};

		// Token: 0x04016CFB RID: 93435
		private readonly HashSet<string> TransitionFlowNeedWaitForWorldDoneEnd = new HashSet<string>
		{
			"剧情_3_4_拉海洛主线,13,1",
			"剧情_3_4_拉海洛主线,6,2"
		};

		// Token: 0x04016CFC RID: 93436
		private readonly HashSet<string> TempSkipFormationCheck = new HashSet<string>
		{
			"剧情_3_5_穗穗线_玩法副本_1,2,18",
			"剧情_3_5_穗穗线_玩法副本_1,1,9"
		};

		// Token: 0x04016CFD RID: 93437
		private readonly HashSet<string> DebugProtectedPlot = new HashSet<string>
		{
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,1",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,2",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,3",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,4",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,5",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,6",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,7",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,8",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,9",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,11",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,12",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,13",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,14",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,15",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,16",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,17",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,18",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,22",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,23",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,24",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,25",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,26",
			"剧情_2_7_狄斯台地主线_上半_巡游天国,33,27",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,1,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,1,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,1,3",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,1,4",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,2,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,2,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,3,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,3,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,4,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,4,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,5,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,5,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,6,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,6,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,6,3",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,6,4",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,7,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,7,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,8,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,8,2",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,9,1",
			"剧情_2.8_穗波怪异物语（战中语音对话文本）,9,2"
		};

		// Token: 0x04016CFE RID: 93438
		[Nullable(2)]
		private TimerHandle DebugProtectedPlotTimer;

		// Token: 0x02009C5F RID: 40031
		[NullableContext(0)]
		private enum ECheckType
		{
			// Token: 0x04030AAF RID: 199343
			LoadingDone,
			// Token: 0x04030AB0 RID: 199344
			UiReady,
			// Token: 0x04030AB1 RID: 199345
			TeleportDone,
			// Token: 0x04030AB2 RID: 199346
			AllPlayerAlive,
			// Token: 0x04030AB3 RID: 199347
			CurPlayerAlive,
			// Token: 0x04030AB4 RID: 199348
			FormationReady,
			// Token: 0x04030AB5 RID: 199349
			CharAnimReady,
			// Token: 0x04030AB6 RID: 199350
			PreloadReady,
			// Token: 0x04030AB7 RID: 199351
			PlotCaption,
			// Token: 0x04030AB8 RID: 199352
			TransitionFlowWaitWorldDoneEnd,
			// Token: 0x04030AB9 RID: 199353
			None
		}
	}
}
