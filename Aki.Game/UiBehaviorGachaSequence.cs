using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A11 RID: 10769
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviorGachaSequence : IUiBehavior
{
	// Token: 0x0601B206 RID: 111110 RVA: 0x00853294 File Offset: 0x00851494
	public UniTask OnUiCreateAsync()
	{
		UiBehaviorGachaSequence.<OnUiCreateAsync>d__8 <OnUiCreateAsync>d__;
		<OnUiCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnUiCreateAsync>d__.<>1__state = -1;
		<OnUiCreateAsync>d__.<>t__builder.Start<UiBehaviorGachaSequence.<OnUiCreateAsync>d__8>(ref <OnUiCreateAsync>d__);
		return <OnUiCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601B207 RID: 111111 RVA: 0x008532D0 File Offset: 0x008514D0
	public void OnUiStart()
	{
		this.NeedProcessSkyBlending = (UKismetSystemLibrary.GetConsoleVariableIntValue("r.SkyBlending.AllowSettingLerpPerFrame") == 0);
		if (this.NeedProcessSkyBlending)
		{
			UKuroSequencePerformanceManager.SimpleExecuteCommand("r.SkyBlending.AllowSettingLerpPerFrame 1");
		}
		if (Info.Instance.IsMacPlatform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.AllowHardwareOcclusion 0", null);
		}
		if (Info.Instance.IsLowMemoryDevice)
		{
			this.OriginDepthOfFieldQuality = UKismetSystemLibrary.GetConsoleVariableIntValue("r.DepthOfFieldQuality");
			if (this.OriginDepthOfFieldQuality != 0)
			{
				UKuroSequencePerformanceManager.SimpleExecuteCommand("r.DepthOfFieldQuality 0");
			}
		}
		MenuController.Instance.CloseAllFilter();
	}

	// Token: 0x0601B208 RID: 111112 RVA: 0x00853356 File Offset: 0x00851556
	public void OnUiShow()
	{
	}

	// Token: 0x0601B209 RID: 111113 RVA: 0x00853358 File Offset: 0x00851558
	public void OnUiHide()
	{
	}

	// Token: 0x0601B20A RID: 111114 RVA: 0x0085335A File Offset: 0x0085155A
	public void BindUpdateInteractBp(BP_UpdateInteract_C bp)
	{
		this.UpdateInteractBp = bp;
		this.UpdateInteractBp.SetTickableWhenPaused(true);
	}

	// Token: 0x0601B20B RID: 111115 RVA: 0x0085336F File Offset: 0x0085156F
	public void BindSceneSequenceCamera(AActor camera)
	{
		this.SceneSequenceCamera = camera;
	}

	// Token: 0x0601B20C RID: 111116 RVA: 0x00853378 File Offset: 0x00851578
	public void BindEmptySequenceCamera(AActor camera)
	{
		this.SceneEmptyCamera = camera;
	}

	// Token: 0x0601B20D RID: 111117 RVA: 0x00853384 File Offset: 0x00851584
	public UniTask PreloadLevelSequenceList(List<int> roleIdList)
	{
		UiBehaviorGachaSequence.<PreloadLevelSequenceList>d__15 <PreloadLevelSequenceList>d__;
		<PreloadLevelSequenceList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadLevelSequenceList>d__.<>4__this = this;
		<PreloadLevelSequenceList>d__.roleIdList = roleIdList;
		<PreloadLevelSequenceList>d__.<>1__state = -1;
		<PreloadLevelSequenceList>d__.<>t__builder.Start<UiBehaviorGachaSequence.<PreloadLevelSequenceList>d__15>(ref <PreloadLevelSequenceList>d__);
		return <PreloadLevelSequenceList>d__.<>t__builder.Task;
	}

	// Token: 0x0601B20E RID: 111118 RVA: 0x008533D0 File Offset: 0x008515D0
	public UniTask PreLoadLevelSequence(int roleId)
	{
		UiBehaviorGachaSequence.<PreLoadLevelSequence>d__16 <PreLoadLevelSequence>d__;
		<PreLoadLevelSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreLoadLevelSequence>d__.<>4__this = this;
		<PreLoadLevelSequence>d__.roleId = roleId;
		<PreLoadLevelSequence>d__.<>1__state = -1;
		<PreLoadLevelSequence>d__.<>t__builder.Start<UiBehaviorGachaSequence.<PreLoadLevelSequence>d__16>(ref <PreLoadLevelSequence>d__);
		return <PreLoadLevelSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0601B20F RID: 111119 RVA: 0x0085341C File Offset: 0x0085161C
	public void PlayRoleSequence(int roleId, int releaseRoleIdAfterPlay = 0)
	{
		if (roleId <= 0)
		{
			return;
		}
		ALevelSequenceActor sequenceActor;
		if (!this.LevelSequenceActorCache.TryGetValue(roleId, out sequenceActor) || sequenceActor == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GachaSequencePlayer;
			ELogAuthor author = ELogAuthor.BB;
			string message = "UiBehaviorGachaSequence 未找到SequenceActor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.RoleShowSequence != null)
		{
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.PersonalRootView, true);
			UAkComponent target = null;
			TTimerAction <>9__1;
			AudioSystem.Instance.PostEvent("stop_gacha_role_audio", target, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						ULevelSequencePlayer roleShowSequence = this.RoleShowSequence;
						if (roleShowSequence != null)
						{
							roleShowSequence.Pause();
						}
						ULevelSequencePlayer roleShowSequence2 = this.RoleShowSequence;
						if (roleShowSequence2 != null)
						{
							roleShowSequence2.GoToEndAndStop(EUpdatePositionMethod.Play);
						}
						TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
						TTimerAction action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate(float _)
							{
								this.StartPlaySequence(roleId, sequenceActor);
								UiLayer.Instance.SetShowMaskLayer(EUiViewName.PersonalRootView, false);
								if (releaseRoleIdAfterPlay > 0 && releaseRoleIdAfterPlay != roleId)
								{
									this.ReleaseLevelSequenceActor(releaseRoleIdAfterPlay);
								}
							});
						}
						gameplayTimeInstance.Next(action, null, null);
					}
				}
			}));
			return;
		}
		this.StartPlaySequence(roleId, sequenceActor);
		if (releaseRoleIdAfterPlay > 0 && releaseRoleIdAfterPlay != roleId)
		{
			this.ReleaseLevelSequenceActor(releaseRoleIdAfterPlay);
		}
	}

	// Token: 0x0601B210 RID: 111120 RVA: 0x00853538 File Offset: 0x00851738
	private void StartPlaySequence(int roleId, ALevelSequenceActor sequenceActor)
	{
		if (this.SceneSequenceCamera == null)
		{
			Log.Instance.Error(ELogModule.GachaSequencePlayer, ELogAuthor.BB, "未设置SceneSequenceCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleId);
		if (gachaTextureInfo == null)
		{
			return;
		}
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("PlaySequence");
		ULevelSequence sequence = sequenceActor.GetSequence();
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
		UKuroSequencePerformanceManager.OpenKuroPerformanceMode(sequence);
		CameraController.Instance.SetViewTarget(this.SceneSequenceCamera, "UiBehaviorGachaSequence", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		sequenceActor.bOverrideInstanceData = true;
		sequenceActor.SetTickableWhenPaused(!GameModeModel.Instance.IsMulti);
		sequenceActor.AddBindingByTag(GachaScanView.SCENE_CAMERA_TAG, this.SceneSequenceCamera, false, true);
		UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = sequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
		if (udefaultLevelSequenceInstanceData == null)
		{
			return;
		}
		FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
		udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
		if (gachaTextureInfo.Value.BindPoint != null && gachaTextureInfo.Value.BindPoint.Length > 0)
		{
			udefaultLevelSequenceInstanceData.TransformOriginActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(gachaTextureInfo.Value.BindPoint).Value, ECollectActorType.UI);
		}
		else
		{
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("KuroUiSceneRoot").Value, ECollectActorType.UI);
			if (actorWithTag != null)
			{
				FTransform transformOrigin2 = UKismetMathLibrary.Conv_TransformDoubleToTransform(actorWithTag.D_GetTransform());
				udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin2;
			}
		}
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(roleId);
		if (roleInfoById == null)
		{
			return;
		}
		BP_UpdateInteract_C updateInteractBp = this.UpdateInteractBp;
		if (updateInteractBp != null)
		{
			updateInteractBp.UpdateGachaShowItem(roleId, (byte)roleInfoById.Value.QualityId);
		}
		this.RoleShowSequence = sequenceActor.SequencePlayer;
		if (this.RoleShowSequence == null)
		{
			return;
		}
		FFrameTime time = this.RoleShowSequence.GetStartTime().Time;
		this.RoleShowSequence.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
		{
			Frame = time,
			PositionType = EMovieScenePositionType.Frame,
			UpdateMethod = EUpdatePositionMethod.Jump
		});
		this.RoleShowSequence.PlayToWithEventSweep(new FMovieSceneSequencePlaybackParams
		{
			Frame = time,
			MarkedFrame = "A",
			PositionType = EMovieScenePositionType.MarkedFrame,
			UpdateMethod = EUpdatePositionMethod.Play
		});
		PersonalUtil.ApplyTickableWhenPausedOnRuntimeBindings(sequenceActor, true);
	}

	// Token: 0x0601B211 RID: 111121 RVA: 0x00853784 File Offset: 0x00851984
	public void PlayEmptySequence()
	{
		if (this.SceneEmptyCamera == null)
		{
			Log.Instance.Error(ELogModule.GachaSequencePlayer, ELogAuthor.BB, "未设置SceneEmptyCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.StopCurrentSequence();
		BP_UpdateInteract_C updateInteractBp = this.UpdateInteractBp;
		if (updateInteractBp != null)
		{
			updateInteractBp.UpdateGachaShowItem(3, 4);
		}
		CameraController.Instance.SetViewTarget(this.SceneEmptyCamera, "RoleNewJoinView.SceneEmptyCamera", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
	}

	// Token: 0x0601B212 RID: 111122 RVA: 0x00853808 File Offset: 0x00851A08
	public void StopCurrentSequence()
	{
		if (this.RoleShowSequence != null)
		{
			this.RoleShowSequence.Pause();
			this.RoleShowSequence.GoToEndAndStop(EUpdatePositionMethod.Play);
			AudioSystem.Instance.PostEvent("stop_gacha_role_audio");
		}
	}

	// Token: 0x0601B213 RID: 111123 RVA: 0x0085383C File Offset: 0x00851A3C
	public void SetSequencePlayBackSetting(int roleId, FMovieSceneSequencePlaybackSettings setting)
	{
		ALevelSequenceActor alevelSequenceActor;
		if (!this.LevelSequenceActorCache.TryGetValue(roleId, out alevelSequenceActor) || alevelSequenceActor == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GachaSequencePlayer;
			ELogAuthor author = ELogAuthor.BB;
			string message = "UiBehaviorGachaSequence 未找到SequenceActor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		alevelSequenceActor.PlaybackSettings = setting;
	}

	// Token: 0x0601B214 RID: 111124 RVA: 0x00853890 File Offset: 0x00851A90
	public void ReleaseLevelSequenceActor(int roleId)
	{
		ALevelSequenceActor alevelSequenceActor;
		this.LevelSequenceActorCache.TryGetValue(roleId, out alevelSequenceActor);
		if (alevelSequenceActor == null)
		{
			return;
		}
		ULevelSequence sequence = alevelSequenceActor.GetSequence();
		if (sequence != null)
		{
			UKuroSequenceRuntimeFunctionLibrary.HandleSeqTexStreaming(sequence, false, true);
		}
		UKuroActorManager.DestroyActor(alevelSequenceActor);
		this.LevelSequenceActorCache.Remove(roleId);
		if (this.MeshStreamTaskMap.ContainsKey(roleId))
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.MeshStreamTaskMap.GetValueOrNull(roleId).Value);
			this.MeshStreamTaskMap.Remove(roleId);
		}
	}

	// Token: 0x0601B215 RID: 111125 RVA: 0x00853910 File Offset: 0x00851B10
	public void OnDestroy()
	{
		this.StopCurrentSequence();
		BP_UpdateInteract_C updateInteractBp = this.UpdateInteractBp;
		if (updateInteractBp != null)
		{
			updateInteractBp.EndGachaScene();
		}
		foreach (ALevelSequenceActor alevelSequenceActor in this.LevelSequenceActorCache.Values)
		{
			if (alevelSequenceActor != null)
			{
				ULevelSequence sequence = alevelSequenceActor.GetSequence();
				if (sequence != null)
				{
					UKuroSequenceRuntimeFunctionLibrary.HandleSeqTexStreaming(sequence, false, true);
				}
				UKuroActorManager.DestroyActor(alevelSequenceActor);
			}
		}
		this.LevelSequenceActorCache.Clear();
		foreach (int taskId in this.MeshStreamTaskMap.Values)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(taskId);
		}
		this.MeshStreamTaskMap.Clear();
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("PlaySequence");
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
		if (this.NeedProcessSkyBlending)
		{
			UKuroSequencePerformanceManager.SimpleExecuteCommand("r.SkyBlending.AllowSettingLerpPerFrame 0");
		}
		if (Info.Instance.IsMacPlatform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.AllowHardwareOcclusion 1", null);
		}
		if (Info.Instance.IsLowMemoryDevice && this.OriginDepthOfFieldQuality != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.DepthOfFieldQuality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.OriginDepthOfFieldQuality);
			UKuroSequencePerformanceManager.SimpleExecuteCommand(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		MenuController.Instance.OpenAllFilter();
	}

	// Token: 0x0400EBB5 RID: 60341
	private bool NeedProcessSkyBlending;

	// Token: 0x0400EBB6 RID: 60342
	private int OriginDepthOfFieldQuality;

	// Token: 0x0400EBB7 RID: 60343
	[Nullable(2)]
	public ULevelSequencePlayer RoleShowSequence;

	// Token: 0x0400EBB8 RID: 60344
	[Nullable(2)]
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x0400EBB9 RID: 60345
	[Nullable(2)]
	private AActor SceneEmptyCamera;

	// Token: 0x0400EBBA RID: 60346
	[Nullable(2)]
	private AActor SceneSequenceCamera;

	// Token: 0x0400EBBB RID: 60347
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, ALevelSequenceActor> LevelSequenceActorCache = new Dictionary<int, ALevelSequenceActor>();

	// Token: 0x0400EBBC RID: 60348
	private readonly Dictionary<int, int> MeshStreamTaskMap = new Dictionary<int, int>();
}
