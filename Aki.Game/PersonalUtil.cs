using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023C1 RID: 9153
[NullableContext(1)]
[Nullable(0)]
public class PersonalUtil
{
	// Token: 0x060124DF RID: 74975 RVA: 0x00482054 File Offset: 0x00480254
	public static UniTask PreloadRoleSequence(int roleId, [Nullable(new byte[]
	{
		1,
		2
	})] Dictionary<int, ALevelSequenceActor> sequenceActorMap, Dictionary<int, int> meshStreamTaskIdMap)
	{
		PersonalUtil.<PreloadRoleSequence>d__0 <PreloadRoleSequence>d__;
		<PreloadRoleSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadRoleSequence>d__.roleId = roleId;
		<PreloadRoleSequence>d__.sequenceActorMap = sequenceActorMap;
		<PreloadRoleSequence>d__.meshStreamTaskIdMap = meshStreamTaskIdMap;
		<PreloadRoleSequence>d__.<>1__state = -1;
		<PreloadRoleSequence>d__.<>t__builder.Start<PersonalUtil.<PreloadRoleSequence>d__0>(ref <PreloadRoleSequence>d__);
		return <PreloadRoleSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060124E0 RID: 74976 RVA: 0x004820A8 File Offset: 0x004802A8
	[NullableContext(2)]
	public static void ApplyTickableWhenPausedOnRuntimeBindings(ALevelSequenceActor sequenceActor, bool retryNextTick = true)
	{
		if (sequenceActor == null || !sequenceActor.IsValid())
		{
			return;
		}
		TArray<UObject> bindingByTag = sequenceActor.GetBindingByTag(GachaScanView.SCENE_ROLE_TAG, true);
		if (bindingByTag.Num() == 0)
		{
			if (retryNextTick)
			{
				TimerSystem.GameplayTimeInstance.Next(delegate(float _)
				{
					PersonalUtil.ApplyTickableWhenPausedOnRuntimeBindings(sequenceActor, false);
				}, null, null);
			}
			return;
		}
		for (int i = 0; i < bindingByTag.Num(); i++)
		{
			AActor aactor = bindingByTag.Get(i) as AActor;
			if (aactor != null)
			{
				aactor.SetTickableWhenPaused(true);
				TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
				for (int j = 0; j < tarray.Num(); j++)
				{
					USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(j) as USkeletalMeshComponent;
					if (uskeletalMeshComponent != null)
					{
						uskeletalMeshComponent.SetTickableWhenPaused(true);
					}
				}
				BP_NpcCombinedMesh_C bp_NpcCombinedMesh_C = aactor as BP_NpcCombinedMesh_C;
				if (bp_NpcCombinedMesh_C != null)
				{
					bp_NpcCombinedMesh_C.SetSkelTickableWhenPaused(true);
				}
			}
		}
	}

	// Token: 0x060124E1 RID: 74977 RVA: 0x00482190 File Offset: 0x00480390
	public static void PlayRoleGachaSequence(IPersonalRoleSequencePlayContext context)
	{
		AActor sceneSequenceCamera = context.SceneSequenceCamera;
		BP_UpdateInteract_C updateInteractBp = context.UpdateInteractBp;
		int roleConfigId = context.RoleConfigId;
		ALevelSequenceActor sequenceActor = context.SequenceActor;
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleConfigId);
		if (gachaTextureInfo == null)
		{
			return;
		}
		UKuroSequencePerformanceManager.OpenKuroPerformanceMode(sequenceActor.GetSequence());
		CameraController.Instance.SetViewTarget(sceneSequenceCamera, "RoleNewJoinView.SceneSequenceCamera", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
		sequenceActor.bOverrideInstanceData = true;
		sequenceActor.SetTickableWhenPaused(!GameModeModel.Instance.IsMulti);
		FName scene_CAMERA_TAG = GachaScanView.SCENE_CAMERA_TAG;
		sequenceActor.AddBindingByTag(scene_CAMERA_TAG, sceneSequenceCamera, false, true);
		UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = (UDefaultLevelSequenceInstanceData)sequenceActor.DefaultInstanceData;
		FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
		udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
		if (!string.IsNullOrEmpty(gachaTextureInfo.Value.BindPoint))
		{
			udefaultLevelSequenceInstanceData.TransformOriginActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(gachaTextureInfo.Value.BindPoint).Value, ECollectActorType.UI);
		}
		else
		{
			FTransform transformOrigin2 = UKismetMathLibrary.Conv_TransformDoubleToTransform(UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("KuroUiSceneRoot").Value, ECollectActorType.UI).D_GetTransform());
			udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin2;
		}
		updateInteractBp.UpdateGachaShowItem(roleConfigId, Convert.ToByte(GachaConfig.Instance.GetRoleInfoById(roleConfigId).Value.QualityId));
		ULevelSequencePlayer sequencePlayer = sequenceActor.SequencePlayer;
		FFrameTime time = sequencePlayer.GetStartTime().Time;
		sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(time, 0f, string.Empty, EMovieScenePositionType.Frame, EUpdatePositionMethod.Jump));
		sequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(time, 0f, "A", EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
	}
}
