using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.GamePlay.StreamingSource;
using AkiClient.Game.Aki.Sequence.Seq_BP.SeqStreamingSource;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.UiCamera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FF9 RID: 16377
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraAssistant : SeqBaseAssistant
	{
		// Token: 0x0602973B RID: 169787 RVA: 0x00BAF368 File Offset: 0x00BAD568
		[NullableContext(2)]
		public override void PreAllPlay(Action<bool> callback = null)
		{
			this.UpdateFollowSequencePlayerCameraAnchor();
			if (!this.Model.IsViewTargetControl)
			{
				return;
			}
			float 相机过渡时间 = this.Model.SequenceData.相机过渡时间;
			BP_CineCamera_C cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			UCineCameraComponent cineCameraComponent = cineCamera.GetCineCameraComponent();
			if (相机过渡时间 > 0f)
			{
				if (this.Model.SequenceData.约束宽高比)
				{
					if (!cineCameraComponent.bConstrainAspectRatio)
					{
						int num = 0;
						int num2 = 0;
						Global.CharacterController.GetViewportSize(ref num, ref num2);
						float num3 = (float)num / (float)num2;
						cineCameraComponent.bConstrainAspectRatio = true;
						cineCameraComponent.Filmback.SensorWidth = cineCameraComponent.Filmback.SensorHeight * num3;
					}
				}
				else if (cineCameraComponent.bConstrainAspectRatio)
				{
					PlotController.Instance.ManualAdaptAspectRatio((float)((int)(相机过渡时间 * 1000f)));
				}
			}
			float cameraBlendInTime = this.Model.SequenceData.CameraBlendInTime;
			SequenceCameraPlayerComponent component = CameraController.Instance.MainModel.SequenceCamera.GetComponent<SequenceCameraPlayerComponent>();
			if (component != null && component.GetIsInCinematic() && component != null && component.GetIfNeedWaitInPlot())
			{
				component.StopSequence();
			}
			bool 使用UI黑边 = this.Model.SequenceData.使用UI黑边;
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true);
			int num4 = 0;
			bool flag = currentValue.GetValueOrDefault() > num4 & currentValue != null;
			if (使用UI黑边 && cameraBlendInTime > 0f && flag)
			{
				this.Model.EnablingUiBlend = true;
				cineCameraComponent.bConstrainAspectRatio = false;
				EnterMovieModeParams param = new EnterMovieModeParams
				{
					BlendTime = cameraBlendInTime
				};
				MovieModeController.Instance.EnterMovieMode(param, delegate(bool success)
				{
					if (!success)
					{
						Log.Instance.Warn(ELogModule.Plot, ELogAuthor.HYF, "进入UI黑边失败", default(ReadOnlySpan<ValueTuple<string, object>>));
						this.Model.EnablingUiBlend = false;
					}
				});
			}
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, cameraBlendInTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
			this.ControllingView = true;
			if (this.Model.SequenceData.IsEnableDynamicStreamingSource)
			{
				this.DynamicStreamingSourceProxy = ActorSystem.Instance.Spawn<BP_KuroStreamingSourceProxy_Seq_C>(BP_KuroStreamingSourceProxy_Seq_C.StaticClass(), new FTransformDouble(), null);
				this.SwitchToDynamicStreamingSource(this.DynamicStreamingSourceProxy).Forget();
			}
			if (!PlotModel.Instance.PlotConfig.IsPreStreaming)
			{
				return;
			}
			if (this.PreLoadActor == null)
			{
				this.PreLoadActor = ActorSystem.Instance.Spawn<BP_StreamingSourceActor_C>(BP_StreamingSourceActor_C.StaticClass(), new FTransformDouble(), null);
			}
			if (this.CameraLoadActor == null)
			{
				this.CameraLoadActor = ActorSystem.Instance.Spawn<BP_StreamingSourceActor_C>(BP_StreamingSourceActor_C.StaticClass(), new FTransformDouble(), null);
				cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
				this.CameraLoadActor.K2_AttachToActor(cineCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
			}
		}

		// Token: 0x0602973C RID: 169788 RVA: 0x00BAF5F0 File Offset: 0x00BAD7F0
		public override void PreEachPlay()
		{
			if (!this.Model.IsViewTargetControl)
			{
				return;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			BP_CineCamera_C cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			FTransformDouble ftransformDouble = (this.Model.SubSeqIndex != 0) ? cineCamera.D_GetTransform() : CameraModel.Instance.MainModel.CameraTransform.Value;
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			CameraModel.Instance.MainModel.SequenceCamera.RegisterLevelSequenceActor(curLevelSeqActor);
			this.RegisteredLevelSequenceActor = curLevelSeqActor;
			if (this.Model.SequenceData.相机过渡时间 <= 0f || this.Model.SubSeqIndex != 0)
			{
				cineCamera.ResetSeqCineCamSetting();
			}
			tarray.Add(cineCamera);
			curLevelSeqActor.SetBindingByTag(SequenceDefine.CAMERA_TAG, tarray, false, true);
			if (this.Model.SequenceData.混入到相机首帧 && this.Model.SubSeqIndex == 0)
			{
				Transform transform = Transform.Create();
				FTransform ftransform = transform.ToUeTransformOld();
				ULevelSequence sequence = this.Model.CurLevelSeqActor.GetSequence();
				if (!UKuroSequenceRuntimeFunctionLibrary.GetFrameTransformByTag(sequence, SequenceDefine.CAMERA_TAG, UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(sequence), ref ftransform))
				{
					Log.Instance.Warn(ELogModule.Plot, ELogAuthor.HYF, "未能获取到Sequence起始帧的相机Transform，无法启用起始帧过渡", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					transform.FromUeTransform(ftransform);
					ftransformDouble = transform.ToUeTransform();
					if (this.Model.RelativeTransform != null)
					{
						Transform transform2 = Transform.Create();
						transform.ComposeTransforms(this.Model.RelativeTransform, transform2);
						ftransformDouble = transform2.ToUeTransform();
					}
				}
			}
			cineCamera.D_K2_SetActorTransform(ftransformDouble, false, null, true);
			BP_KuroStreamingSourceProxy_Seq_C dynamicStreamingSourceProxy = this.DynamicStreamingSourceProxy;
			if (dynamicStreamingSourceProxy == null || !dynamicStreamingSourceProxy.IsValid())
			{
				return;
			}
			TArray<AActor> tarray2 = new TArray<AActor>();
			tarray2.Empty(true);
			tarray2.Add(this.DynamicStreamingSourceProxy);
			this.Model.CurLevelSeqActor.SetBindingByTag(SequenceDefine.SeqStreamingSourceProxy_TAG, tarray2, false, true);
		}

		// Token: 0x0602973D RID: 169789 RVA: 0x00BAF7D4 File Offset: 0x00BAD9D4
		public override void EachStop()
		{
			if (this.RegisteredLevelSequenceActor != null)
			{
				CameraModel instance = CameraModel.Instance;
				if (instance != null)
				{
					SequenceCamera sequenceCamera = instance.MainModel.SequenceCamera;
					if (sequenceCamera != null)
					{
						sequenceCamera.UnregisterLevelSequenceActor(this.RegisteredLevelSequenceActor);
					}
				}
				this.RegisteredLevelSequenceActor = null;
			}
		}

		// Token: 0x0602973E RID: 169790 RVA: 0x00BAF80C File Offset: 0x00BADA0C
		[NullableContext(2)]
		public override void AllStop(Action<bool> callback = null)
		{
			this.EachStop();
			if (!this.Model.IsViewTargetControl)
			{
				return;
			}
			if (this.Model.IsSeamless && FlowController.Instance.CollectSeamlessFinalize(ESeamlessFinalizeFlag.ExitMovieMode))
			{
				return;
			}
			if (this.Model.Config.KeepCamera.GetValueOrDefault())
			{
				this.ControllingView = false;
				if (this.Model.EnablingUiBlend)
				{
					ExitMovieModeParams param = new ExitMovieModeParams
					{
						BlendTime = 0f
					};
					MovieModeController.Instance.ExitMovieMode(param, null);
					this.Model.EnablingUiBlend = false;
				}
				CameraModelInstance mainModel = CameraModel.Instance.MainModel;
				mainModel.SaveSeqCamera();
				SeqCameraThings savedSeqCameraThings = mainModel.GetSavedSeqCameraThings();
				if (savedSeqCameraThings == null)
				{
					Log.Instance.Error(ELogModule.Camera, ELogAuthor.BB, "读取Sequence相机信息时，信息不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
				orCreateCamera.SetWorldLocation(savedSeqCameraThings.CameraLocation);
				orCreateCamera.SetWorldRotation(savedSeqCameraThings.CameraRotation);
				UiCameraDisplayComponent uiCameraComponent = orCreateCamera.GetUiCameraComponent<UiCameraDisplayComponent>();
				uiCameraComponent.SetCameraAperture(savedSeqCameraThings.CurrentAperture);
				uiCameraComponent.SetCameraFocalDistance(savedSeqCameraThings.FocusSettings.ManualFocusDistance);
				uiCameraComponent.SetCameraFieldOfView(savedSeqCameraThings.FieldOfView);
				CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
				orCreateCamera.Enter(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null);
				return;
			}
			CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera.LookatTrackingSettings.bEnableLookAtTracking = false;
			if (this.Model.Config.ResetCamera.GetValueOrDefault())
			{
				CameraBlueprintFunctionLibrary.ResetFightCameraPitchAndArmLength();
			}
			else
			{
				FRotator rotation = CameraController.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera.K2_GetActorRotation();
				rotation.Roll = 0f;
				CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(rotation);
			}
			float cameraBlendOutTime = this.Model.SequenceData.CameraBlendOutTime;
			this.ControllingView = false;
			if (cameraBlendOutTime == 0f)
			{
				SequenceController.Instance.DisableMotionBlurAwhile();
			}
			else
			{
				this.DitherSuppressor.Begin(cameraBlendOutTime);
			}
			if (this.Model.EnablingUiBlend)
			{
				ExitMovieModeParams param2 = new ExitMovieModeParams
				{
					BlendTime = cameraBlendOutTime
				};
				MovieModeController.Instance.ExitMovieMode(param2, null);
				this.Model.EnablingUiBlend = false;
			}
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, cameraBlendOutTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		}

		// Token: 0x0602973F RID: 169791 RVA: 0x00BAFA70 File Offset: 0x00BADC70
		[NullableContext(0)]
		public override UniTask<bool> AllStopPromise()
		{
			CameraAssistant.<AllStopPromise>d__12 <AllStopPromise>d__;
			<AllStopPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<AllStopPromise>d__.<>4__this = this;
			<AllStopPromise>d__.<>1__state = -1;
			<AllStopPromise>d__.<>t__builder.Start<CameraAssistant.<AllStopPromise>d__12>(ref <AllStopPromise>d__);
			return <AllStopPromise>d__.<>t__builder.Task;
		}

		// Token: 0x06029740 RID: 169792 RVA: 0x00BAFAB4 File Offset: 0x00BADCB4
		public override void End()
		{
			CameraAssistant.ClearFightCameraAnchorOverride();
			if (!this.Model.IsViewTargetControl)
			{
				return;
			}
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraGuideAtOnce();
			if (this.PreLoadActor != null)
			{
				UWorldPartitionStreamingSourceComponent worldPartitionStreamingSource = this.PreLoadActor.WorldPartitionStreamingSource;
				if (worldPartitionStreamingSource != null)
				{
					worldPartitionStreamingSource.DisableStreamingSource();
				}
			}
			if (this.CameraLoadActor != null)
			{
				UWorldPartitionStreamingSourceComponent worldPartitionStreamingSource2 = this.CameraLoadActor.WorldPartitionStreamingSource;
				if (worldPartitionStreamingSource2 != null)
				{
					worldPartitionStreamingSource2.DisableStreamingSource();
				}
			}
			if (this.DynamicStreamingSourceProxy != null)
			{
				GameModeModel instance = GameModeModel.Instance;
				if (instance != null)
				{
					instance.DetachStreamingSourceFromActor();
				}
				ActorSystem.Instance.Put("CameraAssistant.DestroySeqDynamicStreamingSourceProxy", this.DynamicStreamingSourceProxy, null);
				GameModeModel.Instance.AttachStreamingSourcesToActor(RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined());
				this.ExitStreamingSourceBudgetMode();
				this.DynamicStreamingSourceProxy = null;
				MovementLockController.Instance.Unlock();
			}
			CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera.LookatTrackingSettings.bEnableLookAtTracking = false;
			foreach (KeyValuePair<string, UMatineeCameraShake> keyValuePair in this.CameraShake)
			{
				string key = keyValuePair.Key;
				UMatineeCameraShake value = keyValuePair.Value;
				Global.CharacterCameraManager.StopCameraShake(value, true);
			}
			this.CameraShake.Clear();
			if (this.ControllingView && !FlowController.Instance.CollectSeamlessFinalize(ESeamlessFinalizeFlag.ExitSequenceCamera))
			{
				CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
			}
			if (this.Model.EnablingUiBlend && !FlowController.Instance.CollectSeamlessFinalize(ESeamlessFinalizeFlag.ExitMovieMode))
			{
				ExitMovieModeParams param = new ExitMovieModeParams
				{
					BlendTime = 0f
				};
				MovieModeController.Instance.ExitMovieMode(param, null);
				this.Model.EnablingUiBlend = false;
			}
		}

		// Token: 0x06029741 RID: 169793 RVA: 0x00BAFC88 File Offset: 0x00BADE88
		private UniTask SwitchToDynamicStreamingSource(BP_KuroStreamingSourceProxy_Seq_C proxy)
		{
			CameraAssistant.<SwitchToDynamicStreamingSource>d__14 <SwitchToDynamicStreamingSource>d__;
			<SwitchToDynamicStreamingSource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchToDynamicStreamingSource>d__.<>4__this = this;
			<SwitchToDynamicStreamingSource>d__.proxy = proxy;
			<SwitchToDynamicStreamingSource>d__.<>1__state = -1;
			<SwitchToDynamicStreamingSource>d__.<>t__builder.Start<CameraAssistant.<SwitchToDynamicStreamingSource>d__14>(ref <SwitchToDynamicStreamingSource>d__);
			return <SwitchToDynamicStreamingSource>d__.<>t__builder.Task;
		}

		// Token: 0x06029742 RID: 169794 RVA: 0x00BAFCD3 File Offset: 0x00BADED3
		private void ExitStreamingSourceBudgetMode()
		{
			GameBudgetController.Instance.ExitMode(this.StreamingSourceBudgetToken);
			this.StreamingSourceBudgetToken = default(GameBudgetModeToken);
		}

		// Token: 0x06029743 RID: 169795 RVA: 0x00BAFCF4 File Offset: 0x00BADEF4
		public void UpdateFollowSequencePlayerCameraAnchor()
		{
			AActor aactor;
			if (this.Model.State == ESequenceState.Playing)
			{
				SequencePlayOptions playOptions = this.Model.PlayOptions;
				if (playOptions != null && playOptions.FollowSequencePlayer)
				{
					aactor = this.Model.SeqMainCharacter;
					goto IL_35;
				}
			}
			aactor = null;
			IL_35:
			AActor aactor2 = aactor;
			if (aactor2 == null || !aactor2.IsValid())
			{
				CameraAssistant.ClearFightCameraAnchorOverride();
				return;
			}
			FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
			if (fvectorDouble.X == this.Model.HidePos.X && fvectorDouble.Y == this.Model.HidePos.Y && fvectorDouble.Z == this.Model.HidePos.Z)
			{
				CameraAssistant.ClearFightCameraAnchorOverride();
				return;
			}
			this.FightCameraAnchorLocation.FromUeVector(fvectorDouble);
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera == null)
			{
				return;
			}
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			if (logicComponent == null)
			{
				return;
			}
			logicComponent.SetOverrideLocation(this.FightCameraAnchorLocation);
		}

		// Token: 0x06029744 RID: 169796 RVA: 0x00BAFDD9 File Offset: 0x00BADFD9
		private static void ClearFightCameraAnchorOverride()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera == null)
			{
				return;
			}
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			if (logicComponent == null)
			{
				return;
			}
			logicComponent.ClearOverrideLocation();
		}

		// Token: 0x06029745 RID: 169797 RVA: 0x00BAFDFE File Offset: 0x00BADFFE
		public void CalcPreloadLocation()
		{
		}

		// Token: 0x06029746 RID: 169798 RVA: 0x00BAFE00 File Offset: 0x00BAE000
		public void StartCameraShake(TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
		{
			TSoftClassPtr<UObject> tsoftClassPtr = cameraShakePtr.As<UObject>();
			if (!UKismetSystemLibrary.IsValidSoftClassReference(tsoftClassPtr))
			{
				return;
			}
			string path = cameraShakePtr.ToAssetPathName();
			if (this.CameraShake.ContainsKey(path))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<UClass>(path, delegate([Nullable(2)] UClass shakeClass, string _)
			{
				SequenceModel model = this.Model;
				if (model != null && model.IsPlaying && shakeClass != null)
				{
					UMatineeCameraShake umatineeCameraShake = Global.CharacterCameraManager.StartMatineeCameraShake(shakeClass, 1f, ECameraShakePlaySpace.CameraLocal, default(FRotator), 1f);
					if (umatineeCameraShake != null)
					{
						this.CameraShake[path] = umatineeCameraShake;
					}
				}
			}, 100, "js_undefined");
		}

		// Token: 0x06029747 RID: 169799 RVA: 0x00BAFE70 File Offset: 0x00BAE070
		public void StopCameraShake(TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
		{
			TSoftClassPtr<UObject> tsoftClassPtr = cameraShakePtr.As<UObject>();
			if (!UKismetSystemLibrary.IsValidSoftClassReference(tsoftClassPtr))
			{
				foreach (KeyValuePair<string, UMatineeCameraShake> keyValuePair in this.CameraShake)
				{
					UMatineeCameraShake value = keyValuePair.Value;
					Global.CharacterCameraManager.StopCameraShake(value, true);
				}
				this.CameraShake.Clear();
				return;
			}
			string key = cameraShakePtr.ToAssetPathName();
			UMatineeCameraShake shakeInstance;
			if (!this.CameraShake.TryGetValue(key, out shakeInstance))
			{
				return;
			}
			Global.CharacterCameraManager.StopCameraShake(shakeInstance, true);
			this.CameraShake.Remove(key);
		}

		// Token: 0x040169E6 RID: 92646
		private bool ControllingView;

		// Token: 0x040169E7 RID: 92647
		[Nullable(2)]
		private BP_StreamingSourceActor_C PreLoadActor;

		// Token: 0x040169E8 RID: 92648
		[Nullable(2)]
		private BP_StreamingSourceActor_C CameraLoadActor;

		// Token: 0x040169E9 RID: 92649
		private readonly Dictionary<string, UMatineeCameraShake> CameraShake = new Dictionary<string, UMatineeCameraShake>();

		// Token: 0x040169EA RID: 92650
		private readonly Vector FightCameraAnchorLocation = Vector.Create();

		// Token: 0x040169EB RID: 92651
		[Nullable(2)]
		private BP_KuroStreamingSourceProxy_Seq_C DynamicStreamingSourceProxy;

		// Token: 0x040169EC RID: 92652
		private GameBudgetModeToken StreamingSourceBudgetToken;

		// Token: 0x040169ED RID: 92653
		[Nullable(2)]
		private ALevelSequenceActor RegisteredLevelSequenceActor;

		// Token: 0x040169EE RID: 92654
		private readonly FightCameraDitherSuppressor DitherSuppressor = new FightCameraDitherSuppressor();
	}
}
