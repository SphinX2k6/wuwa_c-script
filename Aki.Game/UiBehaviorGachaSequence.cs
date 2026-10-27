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

// Token: 0x0200349D RID: 13469
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviorGachaSequence : IUiBehavior
{
	// Token: 0x0601D509 RID: 120073 RVA: 0x0082C1E4 File Offset: 0x0082A3E4
	public UniTask OnUiCreateAsync()
	{
		UiBehaviorGachaSequence.<OnUiCreateAsync>d__8 <OnUiCreateAsync>d__;
		<OnUiCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnUiCreateAsync>d__.<>1__state = -1;
		<OnUiCreateAsync>d__.<>t__builder.Start<UiBehaviorGachaSequence.<OnUiCreateAsync>d__8>(ref <OnUiCreateAsync>d__);
		return <OnUiCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601D50A RID: 120074 RVA: 0x0082C220 File Offset: 0x0082A420
	public void OnAfterUiStart()
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

	// Token: 0x0601D50B RID: 120075 RVA: 0x0082C2A6 File Offset: 0x0082A4A6
	public void OnAfterUiShow()
	{
	}

	// Token: 0x0601D50C RID: 120076 RVA: 0x0082C2A8 File Offset: 0x0082A4A8
	public void OnBeforeUiHide()
	{
	}

	// Token: 0x0601D50D RID: 120077 RVA: 0x0082C2AA File Offset: 0x0082A4AA
	public void BindUpdateInteractBp(BP_UpdateInteract_C bp)
	{
		this.UpdateInteractBp = bp;
		this.UpdateInteractBp.SetTickableWhenPaused(true);
	}

	// Token: 0x0601D50E RID: 120078 RVA: 0x0082C2BF File Offset: 0x0082A4BF
	public void BindSceneSequenceCamera(AActor camera)
	{
		this.SceneSequenceCamera = camera;
	}

	// Token: 0x0601D50F RID: 120079 RVA: 0x0082C2C8 File Offset: 0x0082A4C8
	public void BindEmptySequenceCamera(AActor camera)
	{
		this.SceneEmptyCamera = camera;
	}

	// Token: 0x0601D510 RID: 120080 RVA: 0x0082C2D4 File Offset: 0x0082A4D4
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

	// Token: 0x0601D511 RID: 120081 RVA: 0x0082C320 File Offset: 0x0082A520
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

	// Token: 0x0601D512 RID: 120082 RVA: 0x0082C36C File Offset: 0x0082A56C
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

	// Token: 0x0601D513 RID: 120083 RVA: 0x0082C488 File Offset: 0x0082A688
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
		this.RoleShowSequence.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(time, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Jump));
		this.RoleShowSequence.PlayTo(new FMovieSceneSequencePlaybackParams(time, 0f, "A", EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
		PersonalUtil.ApplyTickableWhenPausedOnRuntimeBindings(sequenceActor, true);
	}

	// Token: 0x0601D514 RID: 120084 RVA: 0x0082C6B8 File Offset: 0x0082A8B8
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

	// Token: 0x0601D515 RID: 120085 RVA: 0x0082C73C File Offset: 0x0082A93C
	public void StopCurrentSequence()
	{
		if (this.RoleShowSequence != null)
		{
			this.RoleShowSequence.Pause();
			this.RoleShowSequence.GoToEndAndStop(EUpdatePositionMethod.Play);
			AudioSystem.Instance.PostEvent("stop_gacha_role_audio");
		}
	}

	// Token: 0x0601D516 RID: 120086 RVA: 0x0082C770 File Offset: 0x0082A970
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

	// Token: 0x0601D517 RID: 120087 RVA: 0x0082C7C4 File Offset: 0x0082A9C4
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

	// Token: 0x0601D518 RID: 120088 RVA: 0x0082C844 File Offset: 0x0082AA44
	public void OnBeforeDestroy()
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

	// Token: 0x0400E701 RID: 59137
	private bool NeedProcessSkyBlending;

	// Token: 0x0400E702 RID: 59138
	private int OriginDepthOfFieldQuality;

	// Token: 0x0400E703 RID: 59139
	[Nullable(2)]
	public ULevelSequencePlayer RoleShowSequence;

	// Token: 0x0400E704 RID: 59140
	[Nullable(2)]
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x0400E705 RID: 59141
	[Nullable(2)]
	private AActor SceneEmptyCamera;

	// Token: 0x0400E706 RID: 59142
	[Nullable(2)]
	private AActor SceneSequenceCamera;

	// Token: 0x0400E707 RID: 59143
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, ALevelSequenceActor> LevelSequenceActorCache = new Dictionary<int, ALevelSequenceActor>();

	// Token: 0x0400E708 RID: 59144
	private readonly Dictionary<int, int> MeshStreamTaskMap = new Dictionary<int, int>();
}
