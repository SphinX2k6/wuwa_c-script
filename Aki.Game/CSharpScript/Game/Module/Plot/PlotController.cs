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
	// Token: 0x02003FAA RID: 16298
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlotController : UiControllerBase
	{
		// Token: 0x060293BA RID: 168890 RVA: 0x00B945C4 File Offset: 0x00B927C4
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

		// Token: 0x060293BB RID: 168891 RVA: 0x00B9461C File Offset: 0x00B9281C
		protected override void OnTick(float delta)
		{
			this.TickAll(delta);
			PlotModel.Instance.PlotWeather.OnTick(delta);
			PlotModel.Instance.PlotTemplate.OnTick(delta);
			PlotModel.Instance.PlotCleanRange.OnTick((double)delta);
			PlotModel.Instance.PlotProgressSequence.OnTick(delta);
		}

		// Token: 0x060293BC RID: 168892 RVA: 0x00B94674 File Offset: 0x00B92874
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

		// Token: 0x060293BD RID: 168893 RVA: 0x00B947BC File Offset: 0x00B929BC
		public int AddTickPriority2(Action<float> handle)
		{
			this.TickPriority2HandleId++;
			this.TickGroupPriority2[this.TickPriority2HandleId] = handle;
			return this.TickPriority2HandleId;
		}

		// Token: 0x060293BE RID: 168894 RVA: 0x00B947E4 File Offset: 0x00B929E4
		public void RemoveTickPriority2(int id)
		{
			this.NextPriority2IdList.Remove(id);
			this.TickGroupPriority2.Remove(id);
		}

		// Token: 0x060293BF RID: 168895 RVA: 0x00B94800 File Offset: 0x00B92A00
		public int NextPriority2(Action<float> handle)
		{
			int num = this.AddTickPriority2(handle);
			this.NextPriority2IdList.Add(num);
			return num;
		}

		// Token: 0x060293C0 RID: 168896 RVA: 0x00B94824 File Offset: 0x00B92A24
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

		// Token: 0x060293C1 RID: 168897 RVA: 0x00B948F0 File Offset: 0x00B92AF0
		public int AddAfterTick(Action<float> handle)
		{
			this.AfterTickHandleId++;
			this.TickGroupAfterTick[this.AfterTickHandleId] = handle;
			return this.AfterTickHandleId;
		}

		// Token: 0x060293C2 RID: 168898 RVA: 0x00B94918 File Offset: 0x00B92B18
		public void RemoveAfterTick(int id)
		{
			this.NextAfterTickIdList.Remove(id);
			this.TickGroupAfterTick.Remove(id);
		}

		// Token: 0x060293C3 RID: 168899 RVA: 0x00B94934 File Offset: 0x00B92B34
		public int NextAfterTick(Action<float> handle)
		{
			int num = this.AddAfterTick(handle);
			this.NextAfterTickIdList.Add(num);
			return num;
		}

		// Token: 0x060293C4 RID: 168900 RVA: 0x00B94958 File Offset: 0x00B92B58
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

		// Token: 0x060293C5 RID: 168901 RVA: 0x00B94A6C File Offset: 0x00B92C6C
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

		// Token: 0x060293C6 RID: 168902 RVA: 0x00B94B74 File Offset: 0x00B92D74
		protected override bool OnClear()
		{
			this.ClearAnsPreloadGuaranteeCache();
			return true;
		}

		// Token: 0x060293C7 RID: 168903 RVA: 0x00B94B80 File Offset: 0x00B92D80
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

		// Token: 0x060293C8 RID: 168904 RVA: 0x00B94C34 File Offset: 0x00B92E34
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

		// Token: 0x060293C9 RID: 168905 RVA: 0x00B94CD5 File Offset: 0x00B92ED5
		private void OnBeforeLoadMap()
		{
			if (!PlotModel.Instance.IsInPlot)
			{
				return;
			}
			PlotModel.Instance.PlotResult.ResultCode = EPlotResultCode.Interrupt;
			FlowController.Instance.BackgroundFlow("加载地图前跳过当前剧情", false, false, false);
		}

		// Token: 0x060293CA RID: 168906 RVA: 0x00B94D06 File Offset: 0x00B92F06
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

		// Token: 0x060293CB RID: 168907 RVA: 0x00B94D39 File Offset: 0x00B92F39
		private void OnOpenLoading()
		{
			this.EndInteraction(false, false);
		}

		// Token: 0x060293CC RID: 168908 RVA: 0x00B94D44 File Offset: 0x00B92F44
		private void OnLeaveOnlineWorld()
		{
			if (PlotModel.Instance.IsInPlot)
			{
				FlowController.Instance.FinishFlow("退出联机时退出剧情", null, false);
				FlowController.Instance.ClearOnLeaveOnlineWorld();
			}
		}

		// Token: 0x060293CD RID: 168909 RVA: 0x00B94D80 File Offset: 0x00B92F80
		private void OnBattleStateChanged(bool bStart)
		{
			if (bStart && FlowController.Instance.IsInShowTalk() && PlotModel.Instance.PlotConfig.SkipTalkWhenFighting)
			{
				FlowController.Instance.FinishFlow("战斗状态改变结束剧情", null, false);
			}
		}

		// Token: 0x060293CE RID: 168910 RVA: 0x00B94DC6 File Offset: 0x00B92FC6
		public void OnChangeRole(EntityHandle newEntityHandle, EntityHandle oldEntityHandle)
		{
			if (PlotModel.Instance.IsInHighLevelPlot())
			{
				this.ProtectCurrentRole();
				return;
			}
			this.RemoveProtect(newEntityHandle.Entity, false);
		}

		// Token: 0x060293CF RID: 168911 RVA: 0x00B94DE8 File Offset: 0x00B92FE8
		private void OnUpdateSceneTeam()
		{
			if (SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault() == ETeamGroupType.Plot)
			{
				this.ProtectCurrentRole();
			}
		}

		// Token: 0x060293D0 RID: 168912 RVA: 0x00B94E04 File Offset: 0x00B93004
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

		// Token: 0x060293D1 RID: 168913 RVA: 0x00B94E6E File Offset: 0x00B9306E
		public void ChangeFormation()
		{
			this.PlotFormation.ChangeFormation();
		}

		// Token: 0x060293D2 RID: 168914 RVA: 0x00B94E7C File Offset: 0x00B9307C
		public UniTask CheckFormation()
		{
			PlotController.<CheckFormation>d__45 <CheckFormation>d__;
			<CheckFormation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckFormation>d__.<>4__this = this;
			<CheckFormation>d__.<>1__state = -1;
			<CheckFormation>d__.<>t__builder.Start<PlotController.<CheckFormation>d__45>(ref <CheckFormation>d__);
			return <CheckFormation>d__.<>t__builder.Task;
		}

		// Token: 0x060293D3 RID: 168915 RVA: 0x00B94EC0 File Offset: 0x00B930C0
		public UniTask CheckSwitchSubLevel()
		{
			PlotController.<CheckSwitchSubLevel>d__46 <CheckSwitchSubLevel>d__;
			<CheckSwitchSubLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckSwitchSubLevel>d__.<>4__this = this;
			<CheckSwitchSubLevel>d__.<>1__state = -1;
			<CheckSwitchSubLevel>d__.<>t__builder.Start<PlotController.<CheckSwitchSubLevel>d__46>(ref <CheckSwitchSubLevel>d__);
			return <CheckSwitchSubLevel>d__.<>t__builder.Task;
		}

		// Token: 0x060293D4 RID: 168916 RVA: 0x00B94F04 File Offset: 0x00B93104
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

		// Token: 0x060293D5 RID: 168917 RVA: 0x00B950AB File Offset: 0x00B932AB
		public void EnsureFormationMemoryMaskBeforePlotEnd()
		{
			this.PlotFormationMemory.EnsureMaskBeforePlotEnd();
		}

		// Token: 0x060293D6 RID: 168918 RVA: 0x00B950B8 File Offset: 0x00B932B8
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

		// Token: 0x060293D7 RID: 168919 RVA: 0x00B9536F File Offset: 0x00B9356F
		public void CloseAllUi(long? ownerId = null)
		{
			this.PlotViewManager.ClosePlotView(ownerId);
			this.PlotViewManager.CloseTipsView();
		}

		// Token: 0x060293D8 RID: 168920 RVA: 0x00B95388 File Offset: 0x00B93588
		public void ClearUi(long? ownerId = null)
		{
			this.PlotViewManager.ClearPlotSubtitle(ownerId);
		}

		// Token: 0x060293D9 RID: 168921 RVA: 0x00B95396 File Offset: 0x00B93596
		public void HideUi(bool isHidden, long? ownerId = null)
		{
			this.PlotViewManager.HidePlotUi(isHidden, ownerId);
		}

		// Token: 0x060293DA RID: 168922 RVA: 0x00B953A5 File Offset: 0x00B935A5
		public EUiViewName? GetCurrentViewName()
		{
			return this.PlotViewManager.GetCurrentViewName();
		}

		// Token: 0x060293DB RID: 168923 RVA: 0x00B953B2 File Offset: 0x00B935B2
		[NullableContext(2)]
		public void OpenPlotView(EUiViewName viewName, TCallback callback = null, UiParam param = null, long? ownerId = null)
		{
			this.PlotViewManager.OpenPlotView(viewName, callback, param, ownerId);
		}

		// Token: 0x060293DC RID: 168924 RVA: 0x00B953C4 File Offset: 0x00B935C4
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

		// Token: 0x060293DD RID: 168925 RVA: 0x00B9540A File Offset: 0x00B9360A
		public void WaitViewCallback(TCallback callback)
		{
			this.PlotViewManager.WaitOpenCallback(callback);
		}

		// Token: 0x060293DE RID: 168926 RVA: 0x00B95418 File Offset: 0x00B93618
		public void RemoveViewCallback(TCallback callback)
		{
			this.PlotViewManager.RemoveCallback(callback);
		}

		// Token: 0x060293DF RID: 168927 RVA: 0x00B95428 File Offset: 0x00B93628
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

		// Token: 0x060293E0 RID: 168928 RVA: 0x00B954CB File Offset: 0x00B936CB
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

		// Token: 0x060293E1 RID: 168929 RVA: 0x00B95508 File Offset: 0x00B93708
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

		// Token: 0x060293E2 RID: 168930 RVA: 0x00B95654 File Offset: 0x00B93854
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

		// Token: 0x060293E3 RID: 168931 RVA: 0x00B9569D File Offset: 0x00B9389D
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

		// Token: 0x060293E4 RID: 168932 RVA: 0x00B956D8 File Offset: 0x00B938D8
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

		// Token: 0x060293E5 RID: 168933 RVA: 0x00B957A8 File Offset: 0x00B939A8
		private void RemoveAllProtect()
		{
			foreach (int id in this.PlotProtectEntityIds)
			{
				Entity entity = EntitySystem.Instance.Get(id);
				this.RemoveProtect(entity, true);
			}
			this.PlotProtectEntityIds.Clear();
		}

		// Token: 0x060293E6 RID: 168934 RVA: 0x00B95814 File Offset: 0x00B93A14
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

		// Token: 0x060293E7 RID: 168935 RVA: 0x00B95898 File Offset: 0x00B93A98
		public bool IsEnableInteract()
		{
			return !PlotModel.Instance.IsInPlot || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD || PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelE;
		}

		// Token: 0x060293E8 RID: 168936 RVA: 0x00B958D6 File Offset: 0x00B93AD6
		public bool NeedInputRefresh()
		{
			return PlotModel.Instance.IsInPlot || PlotModel.Instance.PlotPendingList.Count > 0;
		}

		// Token: 0x060293E9 RID: 168937 RVA: 0x00B958F8 File Offset: 0x00B93AF8
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

		// Token: 0x060293EA RID: 168938 RVA: 0x00B95AC2 File Offset: 0x00B93CC2
		public void EndInteractionByInteractController(PawnInteractController interactController)
		{
			if (PlotModel.Instance.InteractController != interactController)
			{
				return;
			}
			this.EndInteraction(false, false);
		}

		// Token: 0x060293EB RID: 168939 RVA: 0x00B95ADC File Offset: 0x00B93CDC
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

		// Token: 0x060293EC RID: 168940 RVA: 0x00B95BB2 File Offset: 0x00B93DB2
		public void SetBackInteractionAfterFlow()
		{
			PlotModel.Instance.IsBackInteractionAfterFlow = true;
		}

		// Token: 0x060293ED RID: 168941 RVA: 0x00B95BC0 File Offset: 0x00B93DC0
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

		// Token: 0x060293EE RID: 168942 RVA: 0x00B95D68 File Offset: 0x00B93F68
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

		// Token: 0x060293EF RID: 168943 RVA: 0x00B95F14 File Offset: 0x00B94114
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

		// Token: 0x060293F0 RID: 168944 RVA: 0x00B96251 File Offset: 0x00B94451
		public void TriggerBlackSequence()
		{
			EventSystem.Instance.Emit(EEventName.TriggerBlackSequence);
		}

		// Token: 0x060293F1 RID: 168945 RVA: 0x00B96263 File Offset: 0x00B94463
		public void ChangeWeather(int weatherId, bool isInherit, float tweenTime)
		{
			if (!PlotModel.Instance.IsInPlot && !GlobalData.IsPlayInEditor)
			{
				return;
			}
			PlotModel.Instance.PlotWeather.ChangeWeather(weatherId, isInherit, tweenTime, 100);
		}

		// Token: 0x060293F2 RID: 168946 RVA: 0x00B9628D File Offset: 0x00B9448D
		public void ChangePlotTimeOfDay(bool isInherit, int startSecond, int endSecond = 0, int tweenSecond = 0)
		{
			if (!PlotModel.Instance.IsInPlot && !GlobalData.IsPlayInEditor)
			{
				return;
			}
			PlotModel.Instance.PlotTimeOfDay.SetTimeDuration(isInherit, startSecond, endSecond, tweenSecond);
		}

		// Token: 0x060293F3 RID: 168947 RVA: 0x00B962B7 File Offset: 0x00B944B7
		public void EnableViewControl(bool bEnable)
		{
			PlotModel.Instance.CanControlView = bEnable;
			PlotModel.Instance.UpdateLastViewControl();
			EventSystem.Instance.Emit<bool>(EEventName.PlotEnableControlView, bEnable);
		}

		// Token: 0x060293F4 RID: 168948 RVA: 0x00B962DF File Offset: 0x00B944DF
		private bool GetLastViewControl()
		{
			return PlotModel.Instance.GetLastViewControl();
		}

		// Token: 0x060293F5 RID: 168949 RVA: 0x00B962EC File Offset: 0x00B944EC
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

		// Token: 0x060293F6 RID: 168950 RVA: 0x00B96344 File Offset: 0x00B94544
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

		// Token: 0x060293F7 RID: 168951 RVA: 0x00B9638C File Offset: 0x00B9458C
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

		// Token: 0x060293F8 RID: 168952 RVA: 0x00B96468 File Offset: 0x00B94668
		public void TestOpenTick(Action handle)
		{
			this.TestId = this.AddTick(delegate(float delta)
			{
				handle();
			});
		}

		// Token: 0x060293F9 RID: 168953 RVA: 0x00B9649A File Offset: 0x00B9469A
		public void TestCloseTick()
		{
			this.RemoveTick(this.TestId);
		}

		// Token: 0x060293FA RID: 168954 RVA: 0x00B964A8 File Offset: 0x00B946A8
		public int AddTick(Action<float> handle)
		{
			this.TickHandleId++;
			this.TickCount++;
			this.TickGroup[this.TickHandleId] = handle;
			return this.TickHandleId;
		}

		// Token: 0x060293FB RID: 168955 RVA: 0x00B964DE File Offset: 0x00B946DE
		public void RemoveTick(int id)
		{
			if (this.TickGroup.Remove(id))
			{
				this.TickCount--;
			}
		}

		// Token: 0x060293FC RID: 168956 RVA: 0x00B964FC File Offset: 0x00B946FC
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

		// Token: 0x060293FD RID: 168957 RVA: 0x00B965D4 File Offset: 0x00B947D4
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

		// Token: 0x060293FE RID: 168958 RVA: 0x00B96750 File Offset: 0x00B94950
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

		// Token: 0x060293FF RID: 168959 RVA: 0x00B967CC File Offset: 0x00B949CC
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

		// Token: 0x06029400 RID: 168960 RVA: 0x00B96814 File Offset: 0x00B94A14
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

		// Token: 0x06029401 RID: 168961 RVA: 0x00B96884 File Offset: 0x00B94A84
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

		// Token: 0x06029402 RID: 168962 RVA: 0x00B96954 File Offset: 0x00B94B54
		public UniTask CreateAspectTransformView()
		{
			PlotController.<CreateAspectTransformView>d__94 <CreateAspectTransformView>d__;
			<CreateAspectTransformView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAspectTransformView>d__.<>1__state = -1;
			<CreateAspectTransformView>d__.<>t__builder.Start<PlotController.<CreateAspectTransformView>d__94>(ref <CreateAspectTransformView>d__);
			return <CreateAspectTransformView>d__.<>t__builder.Task;
		}

		// Token: 0x06029403 RID: 168963 RVA: 0x00B9698F File Offset: 0x00B94B8F
		public void RemoveAspectTransformView()
		{
			if (PlotModel.Instance.PlotAspectTransformView == null)
			{
				return;
			}
			PlotModel.Instance.PlotAspectTransformView.CloseMeAsync().Forget<bool>();
			PlotModel.Instance.PlotAspectTransformView = null;
		}

		// Token: 0x06029404 RID: 168964 RVA: 0x00B969BD File Offset: 0x00B94BBD
		public void ClearAnsPreloadGuaranteeCache()
		{
			this.PreloadPlotName = null;
			this.PreloadPlotId = null;
			this.PreloadStateId = null;
			this.TriggerMontage = null;
			this.TriggerAnimIns = null;
		}

		// Token: 0x06029405 RID: 168965 RVA: 0x00B969EC File Offset: 0x00B94BEC
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

		// Token: 0x06029406 RID: 168966 RVA: 0x00B96A68 File Offset: 0x00B94C68
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

		// Token: 0x06029407 RID: 168967 RVA: 0x00B96AA0 File Offset: 0x00B94CA0
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

		// Token: 0x06029408 RID: 168968 RVA: 0x00B96C08 File Offset: 0x00B94E08
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

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x06029409 RID: 168969 RVA: 0x00B96C64 File Offset: 0x00B94E64
		public static PlotController Instance
		{
			get
			{
				return PlotController._Instance;
			}
		}

		// Token: 0x0602940A RID: 168970 RVA: 0x00B96C6B File Offset: 0x00B94E6B
		public static PlotController GetOrCreateInstance()
		{
			if (PlotController._Instance == null)
			{
				PlotController.CreateInstance();
			}
			return PlotController._Instance;
		}

		// Token: 0x0602940B RID: 168971 RVA: 0x00B96C7F File Offset: 0x00B94E7F
		public static bool CreateInstance()
		{
			if (PlotController._Instance != null)
			{
				return true;
			}
			PlotController._Instance = new PlotController();
			return true;
		}

		// Token: 0x0602940C RID: 168972 RVA: 0x00B96C95 File Offset: 0x00B94E95
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602940D RID: 168973 RVA: 0x00B96C97 File Offset: 0x00B94E97
		public static void ResetStaticDefaultValue()
		{
			PlotController._Instance = null;
		}

		// Token: 0x0602940E RID: 168974 RVA: 0x00B96C9F File Offset: 0x00B94E9F
		static PlotController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotController.CreateStaticDefaultValue), new Action(PlotController.ResetStaticDefaultValue));
		}

		// Token: 0x04016711 RID: 91921
		public PlotViewManager PlotViewManager = new PlotViewManager();

		// Token: 0x04016712 RID: 91922
		private PlotFormation PlotFormation = new PlotFormation();

		// Token: 0x04016713 RID: 91923
		private PlotFormationMemory PlotFormationMemory = new PlotFormationMemory();

		// Token: 0x04016714 RID: 91924
		private PlotSwitchSubLevel PlotSwitchSubLevel = new PlotSwitchSubLevel();

		// Token: 0x04016715 RID: 91925
		private int PlotProtectTag = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身"];

		// Token: 0x04016716 RID: 91926
		private int PlotTag = GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.剧情中"];

		// Token: 0x04016717 RID: 91927
		private bool IsInPlotProtect;

		// Token: 0x04016718 RID: 91928
		private HashSet<int> PlotProtectEntityIds = new HashSet<int>();

		// Token: 0x04016719 RID: 91929
		private int TickHandleId;

		// Token: 0x0401671A RID: 91930
		private Dictionary<int, Action<float>> TickGroup = new Dictionary<int, Action<float>>();

		// Token: 0x0401671B RID: 91931
		private int TickCount;

		// Token: 0x0401671C RID: 91932
		private string CachePerfSightName = "";

		// Token: 0x0401671D RID: 91933
		private Dictionary<int, Action<float>> TickGroupPriority2 = new Dictionary<int, Action<float>>();

		// Token: 0x0401671E RID: 91934
		private List<int> TickGroupPriority2IdBuffer = new List<int>();

		// Token: 0x0401671F RID: 91935
		private HashSet<int> NextPriority2IdList = new HashSet<int>();

		// Token: 0x04016720 RID: 91936
		private int TickPriority2HandleId;

		// Token: 0x04016721 RID: 91937
		private readonly Dictionary<int, Action<float>> TickGroupAfterTick = new Dictionary<int, Action<float>>();

		// Token: 0x04016722 RID: 91938
		private readonly HashSet<int> NextAfterTickIdList = new HashSet<int>();

		// Token: 0x04016723 RID: 91939
		private int AfterTickHandleId;

		// Token: 0x04016724 RID: 91940
		[Nullable(2)]
		private AActor PlotStreamingSource;

		// Token: 0x04016725 RID: 91941
		[Nullable(2)]
		private AActor PlotIndependentStreamingSource;

		// Token: 0x04016726 RID: 91942
		public int TestId;

		// Token: 0x04016727 RID: 91943
		[Nullable(2)]
		private string PreloadPlotName;

		// Token: 0x04016728 RID: 91944
		private int? PreloadPlotId;

		// Token: 0x04016729 RID: 91945
		private int? PreloadStateId;

		// Token: 0x0401672A RID: 91946
		[Nullable(2)]
		private UAnimMontage TriggerMontage;

		// Token: 0x0401672B RID: 91947
		[Nullable(2)]
		private UAnimInstance TriggerAnimIns;

		// Token: 0x0401672C RID: 91948
		[Nullable(2)]
		private static PlotController _Instance;
	}
}
