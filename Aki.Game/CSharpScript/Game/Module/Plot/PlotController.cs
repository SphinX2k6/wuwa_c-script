using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.GravityFlip;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE0 RID: 20448
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlotController : UiControllerBase
	{
		// Token: 0x06034531 RID: 214321 RVA: 0x00C4A57C File Offset: 0x00C4877C
		protected override bool OnInit()
		{
			this.IsInPlotProtect = false;
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(PlotModel.Instance.PlotGlobalConfig.PlotGoBattleMaterialPath, delegate([Nullable(2)] PD_CharacterControllerData_C effect, string _)
			{
				if (effect == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "剧情切人效果资产加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", PlotModel.Instance.PlotGlobalConfig.PlotGoBattleMaterialPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				PlotModel.Instance.GoBattleMaterial = effect;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x06034532 RID: 214322 RVA: 0x00C4A5D4 File Offset: 0x00C487D4
		protected override void OnTick(float delta)
		{
			this.TickAll(delta);
			PlotModel.Instance.PlotWeather.OnTick(delta);
			PlotModel.Instance.PlotTemplate.OnTick(delta);
			PlotModel.Instance.PlotCleanRange.OnTick((double)delta);
			PlotModel.Instance.PlotProgressSequence.OnTick(delta);
		}

		// Token: 0x06034533 RID: 214323 RVA: 0x00C4A62C File Offset: 0x00C4882C
		public unsafe void TickPriority2(float delta)
		{
			if (this.TickGroupPriority2.Count <= 0)
			{
				return;
			}
			this.TickGroupPriority2IdBuffer.Clear();
			this.TickGroupPriority2IdBuffer.AddRange(this.NextPriority2IdList);
			for (int i = 0; i < this.TickGroupPriority2IdBuffer.Count; i++)
			{
				int num = this.TickGroupPriority2IdBuffer[i];
				try
				{
					this.TickGroupPriority2[num](delta);
				}
				catch (Exception item)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "PlotController TickPriority2 异常";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			if (this.TickGroupPriority2IdBuffer.Count > 0)
			{
				foreach (int num2 in this.TickGroupPriority2IdBuffer)
				{
					this.TickGroupPriority2.Remove(num2);
					this.NextPriority2IdList.Remove(num2);
				}
			}
		}

		// Token: 0x06034534 RID: 214324 RVA: 0x00C4A774 File Offset: 0x00C48974
		public int AddTickPriority2(Action<float> handle)
		{
			this.TickPriority2HandleId++;
			this.TickGroupPriority2[this.TickPriority2HandleId] = handle;
			return this.TickPriority2HandleId;
		}

		// Token: 0x06034535 RID: 214325 RVA: 0x00C4A79C File Offset: 0x00C4899C
		public void RemoveTickPriority2(int id)
		{
			this.NextPriority2IdList.Remove(id);
			this.TickGroupPriority2.Remove(id);
		}

		// Token: 0x06034536 RID: 214326 RVA: 0x00C4A7B8 File Offset: 0x00C489B8
		public int NextPriority2(Action<float> handle)
		{
			int num = this.AddTickPriority2(handle);
			this.NextPriority2IdList.Add(num);
			return num;
		}

		// Token: 0x06034537 RID: 214327 RVA: 0x00C4A7DC File Offset: 0x00C489DC
		public new void AfterTick(float delta)
		{
			if (this.TickGroupAfterTick.Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<int, Action<float>> keyValuePair in this.TickGroupAfterTick)
			{
				keyValuePair.Value(delta);
			}
			if (this.NextAfterTickIdList.Count > 0)
			{
				foreach (int key in this.NextAfterTickIdList)
				{
					this.TickGroupAfterTick.Remove(key);
				}
				this.NextAfterTickIdList.Clear();
			}
		}

		// Token: 0x06034538 RID: 214328 RVA: 0x00C4A8A8 File Offset: 0x00C48AA8
		public int AddAfterTick(Action<float> handle)
		{
			this.AfterTickHandleId++;
			this.TickGroupAfterTick[this.AfterTickHandleId] = handle;
			return this.AfterTickHandleId;
		}

		// Token: 0x06034539 RID: 214329 RVA: 0x00C4A8D0 File Offset: 0x00C48AD0
		public void RemoveAfterTick(int id)
		{
			this.NextAfterTickIdList.Remove(id);
			this.TickGroupAfterTick.Remove(id);
		}

		// Token: 0x0603453A RID: 214330 RVA: 0x00C4A8EC File Offset: 0x00C48AEC
		public int NextAfterTick(Action<float> handle)
		{
			int num = this.AddAfterTick(handle);
			this.NextAfterTickIdList.Add(num);
			return num;
		}

		// Token: 0x0603453B RID: 214331 RVA: 0x00C4A910 File Offset: 0x00C48B10
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			EventSystem.Instance.Add<int>(EEventName.GeneralLogicTreePrepareRollback, new Action<int>(this.ObBtBack));
			Net.Instance.Register(ENotifyMessageId.RemovePreloadFlowsNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerNotifyRemovePreloadFlows));
			this.PlotViewManager.RegisterEvent();
		}

		// Token: 0x0603453C RID: 214332 RVA: 0x00C4AA24 File Offset: 0x00C48C24
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			EventSystem.Instance.Remove<int>(EEventName.GeneralLogicTreePrepareRollback, new Action<int>(this.ObBtBack));
			Net.Instance.UnRegister(ENotifyMessageId.RemovePreloadFlowsNotify);
			this.PlotViewManager.UnRegisterEvent();
		}

		// Token: 0x0603453D RID: 214333 RVA: 0x00C4AB2C File Offset: 0x00C48D2C
		protected override bool OnClear()
		{
			this.ClearAnsPreloadGuaranteeCache();
			return true;
		}

		// Token: 0x0603453E RID: 214334 RVA: 0x00C4AB38 File Offset: 0x00C48D38
		public void TogglePlotStreamingSource(bool enable)
		{
			AActor cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			if (this.PlotStreamingSource == null || !this.PlotStreamingSource.IsValid())
			{
				GameModeModel instance = GameModeModel.Instance;
				this.PlotStreamingSource = ((instance != null) ? instance.CreateShapedStreamingSource(100, 1f) : null);
				if (this.PlotStreamingSource != null)
				{
					this.PlotStreamingSource.K2_AttachToActor(cineCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
				}
			}
			AActor plotStreamingSource = this.PlotStreamingSource;
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = ((plotStreamingSource != null) ? plotStreamingSource.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) : null) as UWorldPartitionStreamingSourceComponent;
			if (enable)
			{
				if (uworldPartitionStreamingSourceComponent != null)
				{
					uworldPartitionStreamingSourceComponent.EnableStreamingSource();
				}
				return;
			}
			if (uworldPartitionStreamingSourceComponent != null)
			{
				uworldPartitionStreamingSourceComponent.DisableStreamingSource();
			}
		}

		// Token: 0x0603453F RID: 214335 RVA: 0x00C4ABEC File Offset: 0x00C48DEC
		[NullableContext(2)]
		public void TogglePlotIndependentStreaming(bool enable, global::Vector position = null)
		{
			if (this.PlotIndependentStreamingSource == null || !this.PlotIndependentStreamingSource.IsValid())
			{
				GameModeModel instance = GameModeModel.Instance;
				this.PlotIndependentStreamingSource = ((instance != null) ? instance.CreateShapedStreamingSource(360, 1f) : null);
			}
			AActor plotIndependentStreamingSource = this.PlotIndependentStreamingSource;
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = ((plotIndependentStreamingSource != null) ? plotIndependentStreamingSource.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) : null) as UWorldPartitionStreamingSourceComponent;
			if (enable && position != null)
			{
				FHitResult fhitResult = new FHitResult();
				AActor plotIndependentStreamingSource2 = this.PlotIndependentStreamingSource;
				if (plotIndependentStreamingSource2 != null)
				{
					plotIndependentStreamingSource2.D_K2_SetActorLocation(position.ToUeVector(false), false, ref fhitResult, false);
				}
				if (uworldPartitionStreamingSourceComponent != null)
				{
					uworldPartitionStreamingSourceComponent.EnableStreamingSource();
				}
				return;
			}
			if (uworldPartitionStreamingSourceComponent != null)
			{
				uworldPartitionStreamingSourceComponent.DisableStreamingSource();
			}
		}

		// Token: 0x06034540 RID: 214336 RVA: 0x00C4AC8D File Offset: 0x00C48E8D
		private void OnBeforeLoadMap()
		{
			if (!PlotModel.Instance.IsInPlot)
			{
				return;
			}
			PlotModel.Instance.PlotResult.ResultCode = EPlotResultCode.Interrupt;
			FlowController.Instance.BackgroundFlow("加载地图前跳过当前剧情", false, false, false);
		}

		// Token: 0x06034541 RID: 214337 RVA: 0x00C4ACBE File Offset: 0x00C48EBE
		private void OnWorldDone()
		{
			if (PlotModel.Instance.IsInPlot)
			{
				return;
			}
			SceneTeamModel instance = SceneTeamModel.Instance;
			Entity entity;
			if (instance == null)
			{
				entity = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				entity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			this.RemoveProtect(entity, false);
		}

		// Token: 0x06034542 RID: 214338 RVA: 0x00C4ACF1 File Offset: 0x00C48EF1
		private void OnOpenLoading()
		{
			this.EndInteraction(false, false);
		}

		// Token: 0x06034543 RID: 214339 RVA: 0x00C4ACFC File Offset: 0x00C48EFC
		private void OnLeaveOnlineWorld()
		{
			if (PlotModel.Instance.IsInPlot)
			{
				FlowController.Instance.FinishFlow("退出联机时退出剧情", null, false);
				FlowController.Instance.ClearOnLeaveOnlineWorld();
			}
		}

		// Token: 0x06034544 RID: 214340 RVA: 0x00C4AD38 File Offset: 0x00C48F38
		private void OnBattleStateChanged(bool bStart)
		{
			if (bStart && FlowController.Instance.IsInShowTalk() && PlotModel.Instance.PlotConfig.SkipTalkWhenFighting)
			{
				FlowController.Instance.FinishFlow("战斗状态改变结束剧情", null, false);
			}
		}

		// Token: 0x06034545 RID: 214341 RVA: 0x00C4AD7E File Offset: 0x00C48F7E
		public void OnChangeRole(EntityHandle newEntityHandle, EntityHandle oldEntityHandle)
		{
			if (PlotModel.Instance.IsInHighLevelPlot())
			{
				this.ProtectCurrentRole();
				return;
			}
			this.RemoveProtect(newEntityHandle.Entity, false);
		}

		// Token: 0x06034546 RID: 214342 RVA: 0x00C4ADA0 File Offset: 0x00C48FA0
		private void OnUpdateSceneTeam()
		{
			if (SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault() == ETeamGroupType.Plot)
			{
				this.ProtectCurrentRole();
			}
		}

		// Token: 0x06034547 RID: 214343 RVA: 0x00C4ADBC File Offset: 0x00C48FBC
		private void ObBtBack(int treeId)
		{
			if (!PlotModel.Instance.IsInPlot)
			{
				return;
			}
			GeneralContext curContext = PlotModel.Instance.CurContext;
			if (curContext != null && curContext.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree && ((GeneralLogicTreeContext)PlotModel.Instance.CurContext).TreeConfigId == treeId)
			{
				FlowController.Instance.FinishFlow("任务树回退打断剧情", null, false);
			}
		}

		// Token: 0x06034548 RID: 214344 RVA: 0x00C4AE26 File Offset: 0x00C49026
		public void ChangeFormation()
		{
			this.PlotFormation.ChangeFormation();
		}

		// Token: 0x06034549 RID: 214345 RVA: 0x00C4AE34 File Offset: 0x00C49034
		public UniTask CheckFormation()
		{
			PlotController.<CheckFormation>d__45 <CheckFormation>d__;
			<CheckFormation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckFormation>d__.<>4__this = this;
			<CheckFormation>d__.<>1__state = -1;
			<CheckFormation>d__.<>t__builder.Start<PlotController.<CheckFormation>d__45>(ref <CheckFormation>d__);
			return <CheckFormation>d__.<>t__builder.Task;
		}

		// Token: 0x0603454A RID: 214346 RVA: 0x00C4AE78 File Offset: 0x00C49078
		public UniTask CheckSwitchSubLevel()
		{
			PlotController.<CheckSwitchSubLevel>d__46 <CheckSwitchSubLevel>d__;
			<CheckSwitchSubLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckSwitchSubLevel>d__.<>4__this = this;
			<CheckSwitchSubLevel>d__.<>1__state = -1;
			<CheckSwitchSubLevel>d__.<>t__builder.Start<PlotController.<CheckSwitchSubLevel>d__46>(ref <CheckSwitchSubLevel>d__);
			return <CheckSwitchSubLevel>d__.<>t__builder.Task;
		}

		// Token: 0x0603454B RID: 214347 RVA: 0x00C4AEBC File Offset: 0x00C490BC
		public void OnStartPlotNetwork(PlotInfo plotInfo)
		{
			PlotModel.Instance.PlotConfig.ResetForPlotLifecycle();
			if (PerfSightController.IsEnable)
			{
				FKuroPerfSightHelper.BeginExtTag("Plot");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Plot_");
				defaultInterpolatedStringHandler.AppendFormatted(plotInfo.FlowListName);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(plotInfo.FlowId);
				this.CachePerfSightName = defaultInterpolatedStringHandler.ToStringAndClear();
				FKuroPerfSightHelper.BeginExtTag(this.CachePerfSightName);
			}
			PlotModel.Instance.IsInPlot = true;
			PlotModel.Instance.PlotStartFrame = Time.Instance.Frame;
			PlotModel.Instance.FlowListName = plotInfo.FlowListName;
			PlotModel.Instance.CurContext = plotInfo.Context;
			PlotModel.Instance.IsServerNotify = new bool?(plotInfo.IsServerNotify);
			PlotModel.Instance.IsAsync = new bool?(plotInfo.IsAsync);
			PlotModel.Instance.KeepBgAudio = plotInfo.KeepMusic;
			PlotModel.Instance.PlotResult.Reset();
			PlotModel.Instance.PlotResult.FlowListName = plotInfo.FlowListName;
			PlotModel.Instance.PlotResult.FlowId = new int?(plotInfo.FlowId);
			PlotModel.Instance.PlotResult.StateId = plotInfo.StateId;
			PlotModel.Instance.PlotResult.FlowIncId = new long?(plotInfo.FlowIncId);
			if (!plotInfo.IsBackground && (plotInfo.PlotLevel == EPlotLevel.LevelA || plotInfo.PlotLevel == EPlotLevel.LevelB))
			{
				PlotModel.Instance.SetInPlotGameBudget(true);
			}
			EventSystem.Instance.Emit<PlotInfo>(EEventName.PlotNetworkStart, plotInfo);
			this.PlotFormationMemory.Enter(plotInfo);
		}

		// Token: 0x0603454C RID: 214348 RVA: 0x00C4B063 File Offset: 0x00C49263
		public void EnsureFormationMemoryMaskBeforePlotEnd()
		{
			this.PlotFormationMemory.EnsureMaskBeforePlotEnd();
		}

		// Token: 0x0603454D RID: 214349 RVA: 0x00C4B070 File Offset: 0x00C49270
		public void OnEndPlotNetwork()
		{
			PlotSequenceInertiaKeeper.Instance.Stop("PlotController.OnEndPlotNetwork");
			if (PerfSightController.IsEnable)
			{
				FKuroPerfSightHelper.EndExtTag("Plot");
				FKuroPerfSightHelper.EndExtTag(this.CachePerfSightName);
				this.CachePerfSightName = "";
			}
			PlotModel.Instance.KeepBgAudio = false;
			PlotModel.Instance.ResetAudioState();
			PlotModel.Instance.IsInPlot = false;
			this.PlotFormationMemory.Restore();
			PlotModel.Instance.FinishMontage();
			SequenceController.Instance.ManualFinish();
			PlotModel.Instance.SetRender(false);
			PlotModel.Instance.SetInPlotGameBudget(false);
			PlotModel.Instance.FinishTemplate();
			PlotModel.Instance.PlotWeather.OnPlotEnd();
			PlotModel.Instance.PlotTimeOfDay.OnPlotEnd();
			PlotModel.Instance.PlotCleanRange.Close();
			PlotModel.Instance.PlotAvg.OnPlotEnd();
			PlotModel.Instance.ClearOptionReadState();
			PlotModel.Instance.PlotConfig.DisableInput = false;
			PlotModel.Instance.IsTipsViewShowed = false;
			PlotModel.Instance.CurTalkItem = null;
			PlotModel.Instance.CurShowTalk = null;
			PlotModel.Instance.TimeLimitedOptionTag = false;
			PlotModel.Instance.IsTeleportTransitionSeq = false;
			Global.CharacterCameraManager.FadeAmount = 0f;
			CameraController.Instance.ExitDialogMode("MainCamera");
			InputDistributeController.Instance.RefreshInputTag();
			this.TogglePlotProtect(false);
			this.EnableViewControl(false);
			if (PlotModel.Instance.HasEnterMovieMode)
			{
				PlotModel.Instance.HasEnterMovieMode = false;
				MovieModeController.Instance.ExitMovieMode(new ExitMovieModeParams
				{
					BlendTime = 0f
				}, null);
			}
			PlotResultInfo plotResult = PlotModel.Instance.PlotResult;
			EventSystem.Instance.Emit<PlotResultInfo>(EEventName.PlotNetworkEnd, plotResult);
			if (UiManager.Instance.IsViewOpen(EUiViewName.MusicSubtitleView))
			{
				UiManager.Instance.CloseView(EUiViewName.MusicSubtitleView, null);
			}
			PreloadControllerNew.Instance.RemovePlot(plotResult.FlowListName ?? string.Empty, plotResult.FlowId.GetValueOrDefault(), plotResult.StateId.GetValueOrDefault());
			PreloadModelNew.Instance.PlotUiAssetManager.RemovePlotUiAsset(plotResult.FormatId);
			PreloadModelNew.Instance.PlotUiAssetManager.CancelHangingTask(plotResult.FormatId);
			plotResult.Reset();
			PlotModel.Instance.ClearContext();
			PlotModel.Instance.PlotTextReplacer.Clear();
			PlotModel.Instance.PlotConfig.ResetForPlotLifecycle();
			if (PlotModel.Instance.PlotPendingList.Count > 0)
			{
				PlotModel.Instance.IsBackInteractionAfterFlow = false;
				this.EndInteraction(true, false);
				return;
			}
			if (PlotModel.Instance.IsBackInteractionAfterFlow)
			{
				PlotModel.Instance.IsBackInteractionAfterFlow = false;
				this.TriggerInteraction(true);
			}
			SequenceModel.Instance.SkipUiWaiting = false;
			PlotModel.Instance.SeamlessLockState = false;
		}

		// Token: 0x0603454E RID: 214350 RVA: 0x00C4B327 File Offset: 0x00C49527
		public void CloseAllUi(long? ownerId = null)
		{
			this.PlotViewManager.ClosePlotView(ownerId);
			this.PlotViewManager.CloseTipsView();
		}

		// Token: 0x0603454F RID: 214351 RVA: 0x00C4B340 File Offset: 0x00C49540
		public void ClearUi(long? ownerId = null)
		{
			this.PlotViewManager.ClearPlotSubtitle(ownerId);
		}

		// Token: 0x06034550 RID: 214352 RVA: 0x00C4B34E File Offset: 0x00C4954E
		public void HideUi(bool isHidden, long? ownerId = null)
		{
			this.PlotViewManager.HidePlotUi(isHidden, ownerId);
		}

		// Token: 0x06034551 RID: 214353 RVA: 0x00C4B35D File Offset: 0x00C4955D
		public EUiViewName? GetCurrentViewName()
		{
			return this.PlotViewManager.GetCurrentViewName();
		}

		// Token: 0x06034552 RID: 214354 RVA: 0x00C4B36A File Offset: 0x00C4956A
		[NullableContext(2)]
		public void OpenPlotView(EUiViewName viewName, TCallback callback = null, UiParam param = null, long? ownerId = null)
		{
			this.PlotViewManager.OpenPlotView(viewName, callback, param, ownerId);
		}

		// Token: 0x06034553 RID: 214355 RVA: 0x00C4B37C File Offset: 0x00C4957C
		[NullableContext(2)]
		public void OpenCurrentPlotView(TCallback callback = null, UiParam param = null, long? ownerId = null)
		{
			EUiViewName? plotViewName = PlotModel.Instance.PlotConfig.PlotViewName;
			if (plotViewName != null)
			{
				this.PlotViewManager.OpenPlotView(plotViewName.Value, callback, param, ownerId);
				return;
			}
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06034554 RID: 214356 RVA: 0x00C4B3C2 File Offset: 0x00C495C2
		public void WaitViewCallback(TCallback callback)
		{
			this.PlotViewManager.WaitOpenCallback(callback);
		}

		// Token: 0x06034555 RID: 214357 RVA: 0x00C4B3D0 File Offset: 0x00C495D0
		public void RemoveViewCallback(TCallback callback)
		{
			this.PlotViewManager.RemoveCallback(callback);
		}

		// Token: 0x06034556 RID: 214358 RVA: 0x00C4B3E0 File Offset: 0x00C495E0
		public void HandleShowCenterText(bool isPopView)
		{
			EUiViewName euiViewName = isPopView ? EUiViewName.PlotTransitionViewPop : EUiViewName.PlotTransitionView;
			if (UiManager.Instance.IsViewShow(euiViewName))
			{
				EventSystem.Instance.Emit(EEventName.UpdatePlotCenterText);
				return;
			}
			if (UiManager.Instance.IsViewOpen(euiViewName))
			{
				return;
			}
			if (isPopView)
			{
				UiManager.Instance.OpenView(euiViewName, null, delegate(bool _1, int _2)
				{
					EventSystem.Instance.Emit(EEventName.UpdatePlotCenterText);
				});
				return;
			}
			UiManager.Instance.OpenViewByPlot(euiViewName, null, delegate(bool _1, int _2)
			{
				EventSystem.Instance.Emit(EEventName.UpdatePlotCenterText);
			});
		}

		// Token: 0x06034557 RID: 214359 RVA: 0x00C4B483 File Offset: 0x00C49683
		public bool ShowTipsView(ITalkItem talkItem, EPromptStyle style, UiParam uiParam)
		{
			PlotModel.Instance.CurTalkItem = talkItem;
			if (this.PlotViewManager.UpdateTipsSubtitle(talkItem))
			{
				return true;
			}
			PlotModel.Instance.IsTipsViewShowed = true;
			this.PlotViewManager.OpenTipsView(style, uiParam).Forget();
			return true;
		}

		// Token: 0x06034558 RID: 214360 RVA: 0x00C4B4C0 File Offset: 0x00C496C0
		public void ShowSystemOption(ITalkItem talkItem, Action<int, List<ActionInfo>> callback)
		{
			ITalkItemSystemOption config = talkItem as ITalkItemSystemOption;
			ITalkItemSystemOption config2 = config;
			if (config2 != null && config2.OptionConfig.Type == ESystemOptionType.RogueRandomEvent)
			{
				IRogueRandomEventOption rogueRandomEventOption = config.OptionConfig as IRogueRandomEventOption;
				IRoguelikeRandomEventOpenParam param = new RoguelikeRandomEventOpenParam
				{
					BindId = rogueRandomEventOption.EventId,
					SelectCallback = delegate(int index)
					{
						callback(config.Options.FindIndex(delegate(ITalkOption option)
						{
							int? optionId = (option.TypeParams as ITalkOptionRogueRandomEvent).OptionId;
							int index = index;
							return optionId.GetValueOrDefault() == index & optionId != null;
						}), config.Options.Find(delegate(ITalkOption option)
						{
							int? optionId = (option.TypeParams as ITalkOptionRogueRandomEvent).OptionId;
							int index = index;
							return optionId.GetValueOrDefault() == index & optionId != null;
						}).Actions);
					}
				};
				UiManager.Instance.OpenView(EUiViewName.RoguelikeRandomEventView, param, null);
				return;
			}
			if (config.OptionConfig.Type != ESystemOptionType.GravityControl)
			{
				if (config.OptionConfig.Type == ESystemOptionType.PermanentRogueRandomEvent)
				{
					IPermanentRogueRandomEvent permanentRogueRandomEvent = config.OptionConfig as IPermanentRogueRandomEvent;
					if (permanentRogueRandomEvent != null)
					{
						IRoguelikeRandomEventOpenParam param2 = new RoguelikeRandomEventOpenParam
						{
							BindId = permanentRogueRandomEvent.EventId,
							SelectCallback = delegate(int index)
							{
								callback(config.Options.FindIndex(delegate(ITalkOption option)
								{
									int? optionId = (option.TypeParams as ITalkOptionRogueRandomEvent).OptionId;
									int index = index;
									return optionId.GetValueOrDefault() == index & optionId != null;
								}), config.Options.Find(delegate(ITalkOption option)
								{
									int? optionId = (option.TypeParams as ITalkOptionRogueRandomEvent).OptionId;
									int index = index;
									return optionId.GetValueOrDefault() == index & optionId != null;
								}).Actions);
							}
						};
						UiManager.Instance.OpenView(EUiViewName.RoguelikeRandomEventView, param2, null);
					}
				}
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.GravityFlipView))
			{
				EventSystem.Instance.Emit(EEventName.OnGravityFlipAnimFinish);
				return;
			}
			IGravityFlipViewOpenParam param3 = new GravityFlipViewOpenParam
			{
				SelectCallback = delegate(int index)
				{
					callback(index, new List<ActionInfo>());
				}
			};
			UiManager.Instance.OpenView(EUiViewName.GravityFlipView, param3, null);
		}

		// Token: 0x06034559 RID: 214361 RVA: 0x00C4B60C File Offset: 0x00C4980C
		public void HandleSeqPlayerInput(bool inDisableInput, bool inDisableLookupInput)
		{
			if (GlobalData.GameInstance != null)
			{
				bool baseCharacter = Global.BaseCharacter != null;
				APlayerController characterController = Global.CharacterController;
				if (!baseCharacter || characterController == null)
				{
					return;
				}
				if (!inDisableInput)
				{
					InputDistributeModel.Instance.SetInputDistributeTag("FightInputRoot");
				}
				InteractionModel.Instance.SetInteractionHintDisable(inDisableInput);
				characterController.SetIgnoreLookInput(inDisableLookupInput);
			}
		}

		// Token: 0x0603455A RID: 214362 RVA: 0x00C4B655 File Offset: 0x00C49855
		public void TogglePlotProtect(bool inEnable)
		{
			if (this.IsInPlotProtect != inEnable)
			{
				this.IsInPlotProtect = inEnable;
				if (inEnable)
				{
					PlotModel.Instance.SaveCharacterLockOn();
				}
				else
				{
					PlotModel.Instance.RevertCharacterLockOn();
				}
			}
			if (inEnable)
			{
				this.ProtectCurrentRole();
				return;
			}
			this.RemoveAllProtect();
		}

		// Token: 0x0603455B RID: 214363 RVA: 0x00C4B690 File Offset: 0x00C49890
		public void ProtectCurrentRole()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !this.PlotProtectEntityIds.Add(getCurrentEntity.Id))
			{
				return;
			}
			CharacterBuffComponent characterBuffComponent;
			if (getCurrentEntity == null)
			{
				characterBuffComponent = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				characterBuffComponent = ((entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null);
			}
			CharacterBuffComponent characterBuffComponent2 = characterBuffComponent;
			BaseTagComponent baseTagComponent;
			if (getCurrentEntity == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity2 = getCurrentEntity.Entity;
				baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 != null)
			{
				if (!baseTagComponent2.HasTag(this.PlotProtectTag))
				{
					baseTagComponent2.AddTag(new int?(this.PlotProtectTag));
				}
				if (!baseTagComponent2.HasTag(this.PlotTag))
				{
					baseTagComponent2.AddTag(new int?(this.PlotTag));
				}
			}
			if (characterBuffComponent2 != null)
			{
				characterBuffComponent2.AddBuff(3037L, new AddBuffParam
				{
					InstigatorId = characterBuffComponent2.CreatureDataId,
					Reason = "PlotController.ProtectCurrentRole"
				});
			}
		}

		// Token: 0x0603455C RID: 214364 RVA: 0x00C4B760 File Offset: 0x00C49960
		private void RemoveAllProtect()
		{
			foreach (int id in this.PlotProtectEntityIds)
			{
				Entity entity = EntitySystem.Instance.Get(id);
				this.RemoveProtect(entity, true);
			}
			this.PlotProtectEntityIds.Clear();
		}

		// Token: 0x0603455D RID: 214365 RVA: 0x00C4B7CC File Offset: 0x00C499CC
		[NullableContext(2)]
		private void RemoveProtect(Entity entity, bool removeTag)
		{
			object obj = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (removeTag)
			{
				if (baseTagComponent != null)
				{
					baseTagComponent.RemoveTag(new int?(this.PlotProtectTag));
				}
				if (baseTagComponent != null)
				{
					baseTagComponent.RemoveTag(new int?(this.PlotTag));
				}
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2.RemoveBuff(3037L, -1, "PlotController.RemoveProtect", null, null, null);
		}

		// Token: 0x0603455E RID: 214366 RVA: 0x00C4B850 File Offset: 0x00C49A50
		public bool IsEnableInteract()
		{
			return !PlotModel.Instance.IsInPlot || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelE;
		}

		// Token: 0x0603455F RID: 214367 RVA: 0x00C4B88E File Offset: 0x00C49A8E
		public bool NeedInputRefresh()
		{
			return PlotModel.Instance.IsInPlot || PlotModel.Instance.PlotPendingList.Count > 0;
		}

		// Token: 0x06034560 RID: 214368 RVA: 0x00C4B8B0 File Offset: 0x00C49AB0
		public bool TriggerInteraction(bool showOption = true)
		{
			if (!PlotModel.Instance.IsInPlot)
			{
				PlotModel.Instance.IsInInteraction = true;
				PlotModel.Instance.PlotConfig.SetMode(new SetPlotMode
				{
					Mode = EPlotMode.LevelC.ToEnumString(),
					IsSwitchMainRole = new bool?(false),
					UseFlowCamera = new bool?(true)
				}, true);
				PlotModel.Instance.ApplyPlotConfig(false);
				int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
				if (currentInteractEntityId != null)
				{
					EntityHandle entityById = CreatureModel.Instance.GetEntityById(currentInteractEntityId.Value);
					if (entityById == null)
					{
						this.EndInteraction(false, false);
						return false;
					}
					WorldEntity entity = entityById.Entity;
					PawnInteractNewComponent pawnInteractNewComponent = (entity != null) ? entity.GetComponent<PawnInteractNewComponent>() : null;
					if (pawnInteractNewComponent == null)
					{
						this.EndInteraction(false, false);
						return false;
					}
					if (!pawnInteractNewComponent.IsPawnInteractive())
					{
						this.EndInteraction(false, false);
						return false;
					}
					PlotModel.Instance.CurrentInteractEntity = entityById;
					EventSystem.Instance.EmitWithTarget(entityById.Entity, EEventName.OnInteractPlotStart);
					PawnInteractController pawnInteractController = pawnInteractNewComponent.GetInteractController();
					PlotModel.Instance.InteractController = pawnInteractController;
					this.OpenPlotView(EUiViewName.PlotView, delegate(bool result)
					{
						if (showOption && result && PlotModel.Instance.IsInInteraction)
						{
							EventSystem.Instance.Emit<PawnInteractController>(EEventName.TriggerPlotInteraction, pawnInteractController);
						}
						if (result)
						{
							EventSystem.Instance.Emit(EEventName.PlotInteractViewOpen);
							return;
						}
						this.EndInteraction(false, false);
					}, null, null);
				}
				else
				{
					this.EndInteraction(false, false);
					global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.CFT, "交互目标为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return true;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelE)
			{
				PlotModel.Instance.IsInInteraction = true;
				this.SetBackInteractionAfterFlow();
				FlowController.Instance.FinishFlow("触发交互结束剧情", null, false);
				return true;
			}
			return false;
		}

		// Token: 0x06034561 RID: 214369 RVA: 0x00C4BA7A File Offset: 0x00C49C7A
		public void EndInteractionByInteractController(PawnInteractController interactController)
		{
			if (PlotModel.Instance.InteractController != interactController)
			{
				return;
			}
			this.EndInteraction(false, false);
		}

		// Token: 0x06034562 RID: 214370 RVA: 0x00C4BA94 File Offset: 0x00C49C94
		public void EndInteraction(bool isPlayFlow = false, bool isForce = false)
		{
			if (!PlotModel.Instance.IsInInteraction && !isForce)
			{
				return;
			}
			PlotModel.Instance.IsInInteraction = false;
			PlotModel.Instance.InteractController = null;
			if (!isPlayFlow)
			{
				PlotModel.Instance.ResetAudioState();
				CameraController.Instance.ExitDialogMode("MainCamera");
				this.CloseAllUi(null);
				InputDistributeController.Instance.RefreshInputTag();
				this.TogglePlotProtect(false);
			}
			else
			{
				this.ClearUi(null);
			}
			if (PlotModel.Instance.CurrentInteractEntity == null)
			{
				global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WLJ, "当前交互目标为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.EmitWithTarget(PlotModel.Instance.CurrentInteractEntity.Entity, EEventName.OnInteractPlotEnd);
			PlotModel.Instance.CurrentInteractEntity = null;
		}

		// Token: 0x06034563 RID: 214371 RVA: 0x00C4BB6A File Offset: 0x00C49D6A
		public void SetBackInteractionAfterFlow()
		{
			PlotModel.Instance.IsBackInteractionAfterFlow = true;
		}

		// Token: 0x06034564 RID: 214372 RVA: 0x00C4BB78 File Offset: 0x00C49D78
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public unsafe List<ITalkItem> GetTalkItemsOfFlow(PlayFlow flow)
		{
			if (flow == null)
			{
				return null;
			}
			IReadOnlyList<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flow.FlowListName, flow.FlowId, flow.StateId);
			if (flowStateActions == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotController.StartPlotNetwork] 无法找到对应剧情的状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			ActionInfo actionInfo = null;
			foreach (ActionInfo actionInfo2 in flowStateActions)
			{
				if (actionInfo2.Name == EAction.ShowTalk)
				{
					actionInfo = actionInfo2;
					break;
				}
			}
			if (actionInfo == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[PlotController.StartPlotNetwork] 无法找到对应剧情的ShowTalk行为";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return null;
			}
			ShowTalk showTalk = actionInfo.Params as ShowTalk;
			if (showTalk == null)
			{
				return null;
			}
			return showTalk.TalkItems;
		}

		// Token: 0x06034565 RID: 214373 RVA: 0x00C4BD20 File Offset: 0x00C49F20
		[NullableContext(2)]
		public unsafe string GetTalkItemsOfCenterText(PlayFlow flow)
		{
			if (flow == null)
			{
				return null;
			}
			IReadOnlyList<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flow.FlowListName, flow.FlowId, flow.StateId);
			if (flowStateActions == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "[PlotController.StartPlotNetwork] 无法找到对应剧情的状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			ActionInfo actionInfo = null;
			foreach (ActionInfo actionInfo2 in flowStateActions)
			{
				if (actionInfo2.Name == EAction.ShowCenterText)
				{
					actionInfo = actionInfo2;
					break;
				}
			}
			if (actionInfo == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.JYS;
				string message2 = "[PlotController.StartPlotNetwork] 无法找到对应剧情的ShowCenterText行为";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FlowListName", flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", flow.StateId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return null;
			}
			ShowCenterText showCenterText = actionInfo.Params as ShowCenterText;
			if (showCenterText == null)
			{
				return null;
			}
			return showCenterText.TidCenterText;
		}

		// Token: 0x06034566 RID: 214374 RVA: 0x00C4BECC File Offset: 0x00C4A0CC
		[NullableContext(2)]
		public unsafe ShowCenterText GetTalkItemsOfCenterTextForTeleport()
		{
			PlotFlow playFlow = PlotModel.Instance.PlayFlow;
			if (playFlow == null)
			{
				return null;
			}
			IReadOnlyList<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(playFlow.FlowListName ?? string.Empty, playFlow.FlowId.GetValueOrDefault(), playFlow.StateId.GetValueOrDefault());
			if (flowStateActions == null || flowStateActions.Count <= 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "[PlotController.StartPlotNetwork] 无法找到对应剧情的状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowListName", playFlow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", playFlow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StateId", playFlow.StateId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
			ActionInfo actionInfo = flowStateActions[0];
			if (actionInfo == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.JYS;
				string message2 = "[PlotController.StartPlotNetwork] 无法找到对应剧情的ShowCenterText行为";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("FlowListName", playFlow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", playFlow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", playFlow.StateId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return null;
			}
			if (actionInfo.Name == EAction.ShowCenterText)
			{
				return actionInfo.Params as ShowCenterText;
			}
			if (actionInfo.Name == EAction.ShowTalk)
			{
				ShowTalk showTalk = actionInfo.Params as ShowTalk;
				if (showTalk != null && showTalk.TalkItems.Count > 0 && showTalk.TalkItems[0].Type.GetValueOrDefault() == ETalkItemType.CenterText)
				{
					ITalkItemCenterText talkItemCenterText = showTalk.TalkItems[0] as ITalkItemCenterText;
					ShowCenterText showCenterText = new ShowCenterText();
					float? totalTime;
					if (talkItemCenterText == null)
					{
						totalTime = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig = talkItemCenterText.CenterTextConfig;
						totalTime = ((centerTextConfig != null) ? centerTextConfig.TotalTime : null);
					}
					showCenterText.TotalTime = totalTime;
					ITextStyle textStyle;
					if (talkItemCenterText == null)
					{
						textStyle = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig2 = talkItemCenterText.CenterTextConfig;
						textStyle = ((centerTextConfig2 != null) ? centerTextConfig2.TextStyle : null);
					}
					showCenterText.TextStyle = textStyle;
					string bgImageId;
					if (talkItemCenterText == null)
					{
						bgImageId = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig3 = talkItemCenterText.CenterTextConfig;
						bgImageId = ((centerTextConfig3 != null) ? centerTextConfig3.BgImageId : null);
					}
					showCenterText.BgImageId = bgImageId;
					bool? isMulLine;
					if (talkItemCenterText == null)
					{
						isMulLine = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig4 = talkItemCenterText.CenterTextConfig;
						isMulLine = ((centerTextConfig4 != null) ? centerTextConfig4.IsMulLine : null);
					}
					showCenterText.IsMulLine = isMulLine;
					bool? isManualNext;
					if (talkItemCenterText == null)
					{
						isManualNext = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig5 = talkItemCenterText.CenterTextConfig;
						isManualNext = ((centerTextConfig5 != null) ? centerTextConfig5.IsManualNext : null);
					}
					showCenterText.IsManualNext = isManualNext;
					bool? isCancelAutoLine;
					if (talkItemCenterText == null)
					{
						isCancelAutoLine = null;
					}
					else
					{
						IShowCenterTextParams centerTextConfig6 = talkItemCenterText.CenterTextConfig;
						isCancelAutoLine = ((centerTextConfig6 != null) ? centerTextConfig6.IsCancelAutoLine : null);
					}
					showCenterText.IsCancelAutoLine = isCancelAutoLine;
					showCenterText.TextId = showTalk.TalkItems[0].TextId.GetValueOrDefault(1);
					showCenterText.TidCenterText = showTalk.TalkItems[0].TidTalk;
					return showCenterText;
				}
			}
			return null;
		}

		// Token: 0x06034567 RID: 214375 RVA: 0x00C4C209 File Offset: 0x00C4A409
		public void TriggerBlackSequence()
		{
			EventSystem.Instance.Emit(EEventName.TriggerBlackSequence);
		}

		// Token: 0x06034568 RID: 214376 RVA: 0x00C4C21B File Offset: 0x00C4A41B
		public void ChangeWeather(int weatherId, bool isInherit, float tweenTime)
		{
			if (!PlotModel.Instance.IsInPlot && !GlobalData.IsPlayInEditor)
			{
				return;
			}
			PlotModel.Instance.PlotWeather.ChangeWeather(weatherId, isInherit, tweenTime, 100);
		}

		// Token: 0x06034569 RID: 214377 RVA: 0x00C4C245 File Offset: 0x00C4A445
		public void ChangePlotTimeOfDay(bool isInherit, int startSecond, int endSecond = 0, int tweenSecond = 0)
		{
			if (!PlotModel.Instance.IsInPlot && !GlobalData.IsPlayInEditor)
			{
				return;
			}
			PlotModel.Instance.PlotTimeOfDay.SetTimeDuration(isInherit, startSecond, endSecond, tweenSecond);
		}

		// Token: 0x0603456A RID: 214378 RVA: 0x00C4C26F File Offset: 0x00C4A46F
		public void EnableViewControl(bool bEnable)
		{
			PlotModel.Instance.CanControlView = bEnable;
			PlotModel.Instance.UpdateLastViewControl();
			EventSystem.Instance.Emit<bool>(EEventName.PlotEnableControlView, bEnable);
		}

		// Token: 0x0603456B RID: 214379 RVA: 0x00C4C297 File Offset: 0x00C4A497
		private bool GetLastViewControl()
		{
			return PlotModel.Instance.GetLastViewControl();
		}

		// Token: 0x0603456C RID: 214380 RVA: 0x00C4C2A4 File Offset: 0x00C4A4A4
		public void UpdateViewControl(bool bEnable)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[ViewControl]UpdateViewControl";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", bEnable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			PlotModel.Instance.CanControlView = bEnable;
			EventSystem.Instance.Emit<bool>(EEventName.PlotEnableControlView, bEnable);
		}

		// Token: 0x0603456D RID: 214381 RVA: 0x00C4C2FC File Offset: 0x00C4A4FC
		public void ResetViewControl()
		{
			bool lastViewControl = this.GetLastViewControl();
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[ViewControl]ResetViewControl";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", lastViewControl);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.EnableViewControl(lastViewControl);
		}

		// Token: 0x0603456E RID: 214382 RVA: 0x00C4C344 File Offset: 0x00C4A544
		public void HideSummonedEntity()
		{
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
			{
				if (entityHandle != null && entityHandle.Valid)
				{
					WorldEntity entity = entityHandle.Entity;
					foreach (long num in ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null).CustomServerEntityIds)
					{
						int num2 = (int)num;
						EntityHandle entity2 = CreatureModel.Instance.GetEntity((long)num2);
						if (entity2 != null && entity2.Valid)
						{
							CreatureController.Instance.SetEntityEnable(entity2.Entity, false, "剧情隐藏伴生物", false);
						}
					}
				}
			}
		}

		// Token: 0x0603456F RID: 214383 RVA: 0x00C4C420 File Offset: 0x00C4A620
		public void TestOpenTick(Action handle)
		{
			this.TestId = this.AddTick(delegate(float delta)
			{
				handle();
			});
		}

		// Token: 0x06034570 RID: 214384 RVA: 0x00C4C452 File Offset: 0x00C4A652
		public void TestCloseTick()
		{
			this.RemoveTick(this.TestId);
		}

		// Token: 0x06034571 RID: 214385 RVA: 0x00C4C460 File Offset: 0x00C4A660
		public int AddTick(Action<float> handle)
		{
			this.TickHandleId++;
			this.TickCount++;
			this.TickGroup[this.TickHandleId] = handle;
			return this.TickHandleId;
		}

		// Token: 0x06034572 RID: 214386 RVA: 0x00C4C496 File Offset: 0x00C4A696
		public void RemoveTick(int id)
		{
			if (this.TickGroup.Remove(id))
			{
				this.TickCount--;
			}
		}

		// Token: 0x06034573 RID: 214387 RVA: 0x00C4C4B4 File Offset: 0x00C4A6B4
		public unsafe void TickAll(float delta)
		{
			if (this.TickCount <= 0)
			{
				return;
			}
			foreach (KeyValuePair<int, Action<float>> keyValuePair in this.TickGroup)
			{
				try
				{
					keyValuePair.Value(delta);
				}
				catch (Exception item)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "PlotModel Tick 异常";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", keyValuePair.Key);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x06034574 RID: 214388 RVA: 0x00C4C58C File Offset: 0x00C4A78C
		[NullableContext(2)]
		public SceneTeamItem FindMainRoleTeamItem()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId);
				if (baseRoleId != 0 && RoleModel.Instance.IsMainRole(baseRoleId))
				{
					PlayerInfoModel instance = PlayerInfoModel.Instance;
					bool flag;
					if (instance == null)
					{
						flag = true;
					}
					else
					{
						instance.GetPlayerGender();
						flag = false;
					}
					if (!flag)
					{
						MainRoleConfig? mainRoleById = RoleConfig.Instance.GetMainRoleById(baseRoleId);
						int? num = (mainRoleById != null) ? new int?(mainRoleById.GetValueOrDefault().Gender) : null;
						int playerGender = (int)PlayerInfoModel.Instance.GetPlayerGender();
						if ((num.GetValueOrDefault() == playerGender & num != null) && !sceneTeamItem.IsDead())
						{
							RoleDataBase roleDataBase = RoleConfig.Instance.IsTrialRole(sceneTeamItem.GetConfigId) ? RoleModel.Instance.GetRoleRobotData(sceneTeamItem.GetConfigId) : RoleModel.Instance.GetRoleInstanceById(sceneTeamItem.GetConfigId);
							if (roleDataBase != null)
							{
								int roleSkinId = roleDataBase.GetRoleSkinId();
								if (RoleSkinModel.Instance.GetRoleSkinData(roleSkinId).GetRoleSkinConfig().GroupId != PlotModel.Instance.PlotConfig.PlayerSkinId)
								{
									continue;
								}
							}
							return sceneTeamItem;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06034575 RID: 214389 RVA: 0x00C4C708 File Offset: 0x00C4A908
		[NullableContext(2)]
		public SceneTeamItem FindMainRoleTeamItemForFormationMemory()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId);
				if (baseRoleId != 0 && RoleModel.Instance.IsMainRole(baseRoleId))
				{
					return sceneTeamItem;
				}
			}
			return null;
		}

		// Token: 0x06034576 RID: 214390 RVA: 0x00C4C784 File Offset: 0x00C4A984
		public void RequestChangeRole()
		{
			SceneTeamItem sceneTeamItem = this.FindMainRoleTeamItem();
			if (sceneTeamItem == null)
			{
				return;
			}
			SceneTeamController.Instance.RequestChangeRole(sceneTeamItem.GetCreatureDataId(), new RequestChangeRoleParams
			{
				GoBattleInvincible = new bool?(true),
				CanUseGoBattleSkill = new bool?(false)
			});
		}

		// Token: 0x06034577 RID: 214391 RVA: 0x00C4C7CC File Offset: 0x00C4A9CC
		public void RestoreChangeRole()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(playerId);
			SceneTeamRole sceneTeamRole;
			if (teamPlayerData == null)
			{
				sceneTeamRole = null;
			}
			else
			{
				SceneTeamGroup group = teamPlayerData.GetGroup(ETeamGroupType.Battle);
				sceneTeamRole = ((group != null) ? group.GetCurrentRole() : null);
			}
			SceneTeamRole sceneTeamRole2 = sceneTeamRole;
			if (sceneTeamRole2 == null)
			{
				return;
			}
			SceneTeamController.Instance.RequestChangeRole(sceneTeamRole2.CreatureDataId, new RequestChangeRoleParams
			{
				GoBattleInvincible = new bool?(true),
				CanUseGoBattleSkill = new bool?(false)
			});
		}

		// Token: 0x06034578 RID: 214392 RVA: 0x00C4C83C File Offset: 0x00C4AA3C
		public void ManualAdaptAspectRatio(float time)
		{
			PlotAspectTransformView plotAspectTransformView = PlotModel.Instance.PlotAspectTransformView;
			if (plotAspectTransformView == null || !plotAspectTransformView.IsShowing)
			{
				return;
			}
			UCineCameraComponent cineCameraComponent = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera.GetCineCameraComponent();
			int num = 0;
			int num2 = 0;
			Global.CharacterController.GetViewportSize(ref num, ref num2);
			float num3 = (float)num;
			float num4 = (float)num2;
			float num5 = num3 / num4;
			PlotAspectTransformView plotAspectTransformView2 = PlotModel.Instance.PlotAspectTransformView;
			if (plotAspectTransformView2 != null)
			{
				plotAspectTransformView2.EnableAutoBlendOut(time);
			}
			cineCameraComponent.bConstrainAspectRatio = false;
			if (cineCameraComponent.Filmback.SensorWidth / cineCameraComponent.Filmback.SensorHeight < num5)
			{
				cineCameraComponent.Filmback.SensorWidth = cineCameraComponent.Filmback.SensorHeight * num5;
				return;
			}
			cineCameraComponent.Filmback.SensorHeight = cineCameraComponent.Filmback.SensorWidth / num5;
		}

		// Token: 0x06034579 RID: 214393 RVA: 0x00C4C90C File Offset: 0x00C4AB0C
		public UniTask CreateAspectTransformView()
		{
			PlotController.<CreateAspectTransformView>d__94 <CreateAspectTransformView>d__;
			<CreateAspectTransformView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAspectTransformView>d__.<>1__state = -1;
			<CreateAspectTransformView>d__.<>t__builder.Start<PlotController.<CreateAspectTransformView>d__94>(ref <CreateAspectTransformView>d__);
			return <CreateAspectTransformView>d__.<>t__builder.Task;
		}

		// Token: 0x0603457A RID: 214394 RVA: 0x00C4C947 File Offset: 0x00C4AB47
		public void RemoveAspectTransformView()
		{
			if (PlotModel.Instance.PlotAspectTransformView == null)
			{
				return;
			}
			PlotModel.Instance.PlotAspectTransformView.CloseMeAsync().Forget<bool>();
			PlotModel.Instance.PlotAspectTransformView = null;
		}

		// Token: 0x0603457B RID: 214395 RVA: 0x00C4C975 File Offset: 0x00C4AB75
		public void ClearAnsPreloadGuaranteeCache()
		{
			this.PreloadPlotName = null;
			this.PreloadPlotId = null;
			this.PreloadStateId = null;
			this.TriggerMontage = null;
			this.TriggerAnimIns = null;
		}

		// Token: 0x0603457C RID: 214396 RVA: 0x00C4C9A4 File Offset: 0x00C4ABA4
		public void RegisterOnMontageEnd(string plotName, int plotId, int plotStateId, [Nullable(2)] UAnimInstance animIns)
		{
			if (animIns == null)
			{
				return;
			}
			this.TriggerMontage = animIns.GetCurrentActiveMontage();
			this.TriggerAnimIns = animIns;
			this.RemovePreloadOnMontageEndImp();
			animIns.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.RemovePreloadOnMontageEnd));
			animIns.OnMontageEnded.Add(new Action<UAnimMontage, bool>(this.RemovePreloadOnMontageEnd));
			this.PreloadPlotName = plotName;
			this.PreloadPlotId = new int?(plotId);
			this.PreloadStateId = new int?(plotStateId);
		}

		// Token: 0x0603457D RID: 214397 RVA: 0x00C4CA20 File Offset: 0x00C4AC20
		[NullableContext(2)]
		private void RemovePreloadOnMontageEnd(UAnimMontage montage, bool isInterrupted)
		{
			if (montage == null || montage != this.TriggerMontage)
			{
				return;
			}
			UAnimInstance triggerAnimIns = this.TriggerAnimIns;
			if (triggerAnimIns != null)
			{
				triggerAnimIns.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.RemovePreloadOnMontageEnd));
			}
			this.RemovePreloadOnMontageEndImp();
		}

		// Token: 0x0603457E RID: 214398 RVA: 0x00C4CA58 File Offset: 0x00C4AC58
		private void RemovePreloadOnMontageEndImp()
		{
			if (!PlotModel.Instance.AnsPreloadMark)
			{
				this.PreloadPlotName = null;
				this.PreloadPlotId = null;
				this.PreloadStateId = null;
				return;
			}
			if (this.PreloadPlotName == null || this.PreloadPlotId == null || this.PreloadStateId == null)
			{
				return;
			}
			PreloadControllerNew.Instance.RemovePlot(this.PreloadPlotName, this.PreloadPlotId.Value, this.PreloadStateId.Value);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(this.PreloadPlotName);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PreloadPlotId.Value);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PreloadStateId.Value);
			string plotId = defaultInterpolatedStringHandler.ToStringAndClear();
			PreloadModelNew.Instance.PlotUiAssetManager.RemovePlotUiAsset(plotId);
			this.CloseAllUi(null);
			SequenceModel.Instance.SkipUiWaiting = false;
			PlotModel.Instance.SeamlessLockState = false;
			PlotModel.Instance.AnsPreloadMark = false;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "TsAnimNotifyStatePreloadPlot ANS结束时演出未触发, 卸载预加载的资源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotName", this.PreloadPlotName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PreloadPlotName = null;
			this.PreloadPlotId = null;
			this.PreloadStateId = null;
		}

		// Token: 0x0603457F RID: 214399 RVA: 0x00C4CBC0 File Offset: 0x00C4ADC0
		[NullableContext(2)]
		private void OnServerNotifyRemovePreloadFlows(IMessage msg, Net.CallbackStatus _)
		{
			RemovePreloadFlowsNotify removePreloadFlowsNotify = (RemovePreloadFlowsNotify)msg;
			PreloadControllerNew.Instance.RemovePlot(removePreloadFlowsNotify.FlowListName, removePreloadFlowsNotify.FlowId, removePreloadFlowsNotify.StateId);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "收到服务器通知移除预加载的剧情";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Plot", removePreloadFlowsNotify.FlowGuid);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x17007FC2 RID: 32706
		// (get) Token: 0x06034580 RID: 214400 RVA: 0x00C4CC1C File Offset: 0x00C4AE1C
		public static PlotController Instance
		{
			get
			{
				return PlotController._Instance;
			}
		}

		// Token: 0x06034581 RID: 214401 RVA: 0x00C4CC23 File Offset: 0x00C4AE23
		public static PlotController GetOrCreateInstance()
		{
			if (PlotController._Instance == null)
			{
				PlotController.CreateInstance();
			}
			return PlotController._Instance;
		}

		// Token: 0x06034582 RID: 214402 RVA: 0x00C4CC37 File Offset: 0x00C4AE37
		public static bool CreateInstance()
		{
			if (PlotController._Instance != null)
			{
				return true;
			}
			PlotController._Instance = new PlotController();
			return true;
		}

		// Token: 0x06034583 RID: 214403 RVA: 0x00C4CC4D File Offset: 0x00C4AE4D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034584 RID: 214404 RVA: 0x00C4CC4F File Offset: 0x00C4AE4F
		public static void ResetStaticDefaultValue()
		{
			PlotController._Instance = null;
		}

		// Token: 0x06034585 RID: 214405 RVA: 0x00C4CC57 File Offset: 0x00C4AE57
		static PlotController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotController.CreateStaticDefaultValue), new Action(PlotController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD36 RID: 113974
		public PlotViewManager PlotViewManager = new PlotViewManager();

		// Token: 0x0401BD37 RID: 113975
		private PlotFormation PlotFormation = new PlotFormation();

		// Token: 0x0401BD38 RID: 113976
		private PlotFormationMemory PlotFormationMemory = new PlotFormationMemory();

		// Token: 0x0401BD39 RID: 113977
		private PlotSwitchSubLevel PlotSwitchSubLevel = new PlotSwitchSubLevel();

		// Token: 0x0401BD3A RID: 113978
		private int PlotProtectTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身"];

		// Token: 0x0401BD3B RID: 113979
		private int PlotTag = GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.剧情中"];

		// Token: 0x0401BD3C RID: 113980
		private bool IsInPlotProtect;

		// Token: 0x0401BD3D RID: 113981
		private HashSet<int> PlotProtectEntityIds = new HashSet<int>();

		// Token: 0x0401BD3E RID: 113982
		private int TickHandleId;

		// Token: 0x0401BD3F RID: 113983
		private Dictionary<int, Action<float>> TickGroup = new Dictionary<int, Action<float>>();

		// Token: 0x0401BD40 RID: 113984
		private int TickCount;

		// Token: 0x0401BD41 RID: 113985
		private string CachePerfSightName = "";

		// Token: 0x0401BD42 RID: 113986
		private Dictionary<int, Action<float>> TickGroupPriority2 = new Dictionary<int, Action<float>>();

		// Token: 0x0401BD43 RID: 113987
		private List<int> TickGroupPriority2IdBuffer = new List<int>();

		// Token: 0x0401BD44 RID: 113988
		private HashSet<int> NextPriority2IdList = new HashSet<int>();

		// Token: 0x0401BD45 RID: 113989
		private int TickPriority2HandleId;

		// Token: 0x0401BD46 RID: 113990
		private readonly Dictionary<int, Action<float>> TickGroupAfterTick = new Dictionary<int, Action<float>>();

		// Token: 0x0401BD47 RID: 113991
		private readonly HashSet<int> NextAfterTickIdList = new HashSet<int>();

		// Token: 0x0401BD48 RID: 113992
		private int AfterTickHandleId;

		// Token: 0x0401BD49 RID: 113993
		[Nullable(2)]
		private AActor PlotStreamingSource;

		// Token: 0x0401BD4A RID: 113994
		[Nullable(2)]
		private AActor PlotIndependentStreamingSource;

		// Token: 0x0401BD4B RID: 113995
		public int TestId;

		// Token: 0x0401BD4C RID: 113996
		[Nullable(2)]
		private string PreloadPlotName;

		// Token: 0x0401BD4D RID: 113997
		private int? PreloadPlotId;

		// Token: 0x0401BD4E RID: 113998
		private int? PreloadStateId;

		// Token: 0x0401BD4F RID: 113999
		[Nullable(2)]
		private UAnimMontage TriggerMontage;

		// Token: 0x0401BD50 RID: 114000
		[Nullable(2)]
		private UAnimInstance TriggerAnimIns;

		// Token: 0x0401BD51 RID: 114001
		[Nullable(2)]
		private static PlotController _Instance;
	}
}
