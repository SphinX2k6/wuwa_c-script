using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072E1 RID: 29409
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceCameraPlayerComponent : EntityComponent
	{
		// Token: 0x17009F46 RID: 40774
		// (get) Token: 0x060482AE RID: 295598 RVA: 0x01284B78 File Offset: 0x01282D78
		public bool IsDitherEffectEnabled
		{
			get
			{
				return this.DitherEffectEnableSet.Count > 0;
			}
		}

		// Token: 0x060482AF RID: 295599 RVA: 0x01284B88 File Offset: 0x01282D88
		public void SetPlayCameraSequenceEnabled(bool enabled)
		{
			this.IsPlayCameraSequenceEnabled = enabled;
		}

		// Token: 0x060482B0 RID: 295600 RVA: 0x01284B91 File Offset: 0x01282D91
		public void SetDitherEffectEnable(ESequenceCameraDitherEffectEnum ditherEffectEnum)
		{
			this.DitherEffectEnableSet.Add(ditherEffectEnum);
		}

		// Token: 0x060482B1 RID: 295601 RVA: 0x01284BA0 File Offset: 0x01282DA0
		public void SetDitherEffectDisable(ESequenceCameraDitherEffectEnum ditherEffectEnum)
		{
			this.DitherEffectEnableSet.Remove(ditherEffectEnum);
		}

		// Token: 0x060482B2 RID: 295602 RVA: 0x01284BB0 File Offset: 0x01282DB0
		[NullableContext(2)]
		public void SetPawn(APawn pawn)
		{
			TsBaseCharacter tsBaseCharacter = pawn as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				this.SetCharacter(tsBaseCharacter);
			}
		}

		// Token: 0x060482B3 RID: 295603 RVA: 0x01284BCE File Offset: 0x01282DCE
		public void SetCharacter(TsBaseCharacter character)
		{
			TsBaseCharacter oldCharacter = this.OldCharacter;
			if (oldCharacter != null && oldCharacter.IsValid())
			{
				this.OldCharacter = character;
				return;
			}
			this.Character = character;
		}

		// Token: 0x060482B4 RID: 295604 RVA: 0x01284BF3 File Offset: 0x01282DF3
		[NullableContext(2)]
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x060482B5 RID: 295605 RVA: 0x01284C10 File Offset: 0x01282E10
		public bool PlayCameraSequence(SSequenceCamera_Settings settings, bool resetFightCamera, FRotator additiveRotation, TsBaseCharacter target, FName socketName, FName lockSocketName, FVector relativeLocation, float radius, bool isShowLine, bool ignoreCharacterCollision = false, bool disableMovementInput = true, bool disableLookAtInput = true, bool disableMotionBlur = false, bool isIgnoreInitialSphereDetect = false, [Nullable(2)] SSequenceCamera_SpecificConfig specificConfig = null, int? skillEntityId = null, long? skillId = null)
		{
			if (!this.IsPlayCameraSequenceEnabled)
			{
				return false;
			}
			if (this.IsInCinematic)
			{
				if (!this.CheckBreakSequence(this.Character, target))
				{
					return false;
				}
				this.StopSequence();
			}
			if (this.DisplayComponent.CineCamera.GetAttachParentActor() != null)
			{
				this.DisplayComponent.CineCamera.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.ShowLog = isShowLine;
			this.RelativeLocation.FromUeVector(relativeLocation);
			this.CheckRadius = radius;
			this.OldCharacter = this.Character;
			this.Character = target;
			this.LockSocketName = lockSocketName;
			this.SocketName = socketName;
			this.IsEnableFrameAbstract = (settings.FrameAbstract.EnableFrameAbstract && settings.FrameAbstract.EnableFrameAbstractDelta > 0.05f);
			this.FrameAbstractDelta = settings.FrameAbstract.EnableFrameAbstractDelta;
			this.FrameAbstractTime = -1;
			this.CameraTransformTrack = (this.IsEnableFrameAbstract ? SequenceUtils.GetLevelSequenceTransformTrack(settings.CameraSequence, SequenceCameraPlayerComponent.SequenceCamera) : null);
			this.IsAttachToActor = this.IsEnableFrameAbstract;
			if (!this.IsAttachToActor && !FNameUtil.IsEmpty(new FName?(this.SocketName)))
			{
				AActor transformOriginActor = this.TransformOriginActor;
				if (transformOriginActor == null || !transformOriginActor.IsValid())
				{
					this.TransformOriginActor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
					if (this.TransformOriginActor.K2_GetRootComponent() == null)
					{
						AActor transformOriginActor2 = this.TransformOriginActor;
						TSubclassOf<UActorComponent> @class = USceneComponent.StaticClass();
						bool bManualAttachment = false;
						FTransformDouble ftransformDouble = this.TransformOriginActor.D_GetTransform();
						transformOriginActor2.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, default(FName));
					}
				}
				this.TransformOriginActor.K2_AttachToComponent(this.Character.Mesh, this.SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
			}
			this.SetupCameraSequence(settings, disableMovementInput, disableLookAtInput, specificConfig);
			bool flag = this.Play(isIgnoreInitialSphereDetect, ignoreCharacterCollision);
			this.ResetFightCameraOnStop = resetFightCamera;
			this.ResetAdditiveRotation = new FRotator?(additiveRotation);
			if (flag)
			{
				this.BindSkillEndEvent(settings.IsFinishBySkillInterrupt, skillEntityId, skillId);
				this.HideHud(settings);
				EventSystem.Instance.Emit<bool, string>(EEventName.OnSequenceCameraStatus, true, this.CameraModelInstanceInternal.CameraName);
				CameraNearClipController.Instance.EnableSequenceCameraPlayerComponentNearClip(1f);
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.ZWY, "进入Sequence相机，最小近裁面", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (disableMotionBlur)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
				}
			}
			EventSystem.Instance.Emit<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, settings.CameraSequence, target, this.CameraSequenceActor, CameraUtility.GetRootTransform(target), flag, settings.IsStopModify, this.CameraModelInstanceInternal.CameraName);
			return flag;
		}

		// Token: 0x060482B6 RID: 295606 RVA: 0x01284EA8 File Offset: 0x012830A8
		private void BindSkillEndEvent(bool isFinishBySkillInterrupt, int? skillEntityId, long? skillId)
		{
			this.UnbindSkillEndEvent();
			if (skillEntityId == null || skillId == null)
			{
				return;
			}
			if (!isFinishBySkillInterrupt)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(skillEntityId.Value);
			if (entity == null)
			{
				return;
			}
			this.BindSkillEntity = entity;
			this.BindSkillId = skillId;
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill));
		}

		// Token: 0x060482B7 RID: 295607 RVA: 0x01284F10 File Offset: 0x01283110
		private void UnbindSkillEndEvent()
		{
			if (this.BindSkillEntity != null && EventSystem.Instance.HasWithTarget(this.BindSkillEntity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill)))
			{
				EventSystem.Instance.RemoveWithTarget(this.BindSkillEntity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill));
			}
			this.BindSkillEntity = null;
			this.BindSkillId = null;
		}

		// Token: 0x060482B8 RID: 295608 RVA: 0x01284F78 File Offset: 0x01283178
		private void OnCharInterruptSkill(int skillEntityId, int skillId)
		{
			if (this.BindSkillEntity != null && this.BindSkillEntity.Id == skillEntityId)
			{
				long? bindSkillId = this.BindSkillId;
				long num = (long)skillId;
				if (bindSkillId.GetValueOrDefault() == num & bindSkillId != null)
				{
					Log.Instance.Info(ELogModule.Camera, ELogAuthor.ZJL, "绑定的技能被打断，停止Sequence相机", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.StopSequence();
				}
			}
		}

		// Token: 0x060482B9 RID: 295609 RVA: 0x01284FDB File Offset: 0x012831DB
		public void StopSequence()
		{
			this.SequenceStopInternal();
		}

		// Token: 0x060482BA RID: 295610 RVA: 0x01284FE3 File Offset: 0x012831E3
		public void SetBlendTime(float inBlendIn, float inBlendOut)
		{
			this.SequenceCameraBlendInTime = inBlendIn;
			this.SequenceCameraBlendOutTime = inBlendOut;
		}

		// Token: 0x060482BB RID: 295611 RVA: 0x01284FF3 File Offset: 0x012831F3
		[NullableContext(2)]
		public ALevelSequenceActor GetCurrentLevelSequenceActor()
		{
			return this.CameraSequenceActor;
		}

		// Token: 0x060482BC RID: 295612 RVA: 0x01284FFB File Offset: 0x012831FB
		public bool GetIsInCinematic()
		{
			return this.IsInCinematic;
		}

		// Token: 0x060482BD RID: 295613 RVA: 0x01285003 File Offset: 0x01283203
		[NullableContext(2)]
		public TsBaseCharacter GetCharacter()
		{
			return this.Character;
		}

		// Token: 0x060482BE RID: 295614 RVA: 0x0128500C File Offset: 0x0128320C
		public void ResetCameraRatioSetting()
		{
			SequenceCameraDisplayComponent displayComponent = this.DisplayComponent;
			UCineCameraComponent ucineCameraComponent;
			if (displayComponent == null)
			{
				ucineCameraComponent = null;
			}
			else
			{
				BP_CineCamera_C cineCamera = displayComponent.CineCamera;
				ucineCameraComponent = ((cineCamera != null) ? cineCamera.GetCineCameraComponent() : null);
			}
			UCineCameraComponent ucineCameraComponent2 = ucineCameraComponent;
			if (ucineCameraComponent2 == null)
			{
				return;
			}
			string defaultFilmbackPresetName = ucineCameraComponent2.GetDefaultFilmbackPresetName();
			ucineCameraComponent2.SetFilmbackPresetByName(defaultFilmbackPresetName);
			ucineCameraComponent2.bConstrainAspectRatio = false;
		}

		// Token: 0x060482BF RID: 295615 RVA: 0x01285051 File Offset: 0x01283251
		protected override bool OnStart()
		{
			this.InitTraceElements();
			this.DisplayComponent = base.Entity.GetComponent<SequenceCameraDisplayComponent>();
			return this.DisplayComponent.Valid;
		}

		// Token: 0x060482C0 RID: 295616 RVA: 0x01285078 File Offset: 0x01283278
		private void InitTraceElements()
		{
			this.SphereSingle = new UTraceSphereElement();
			this.SphereSingle.bIsSingle = true;
			this.SphereSingle.bIgnoreSelf = true;
			this.SphereSingle.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.SphereMultiply = new UTraceSphereElement();
			this.SphereMultiply.bIsSingle = false;
			this.SphereMultiply.bIgnoreSelf = true;
			this.SphereMultiply.ActorsToIgnore = this.IgnoreActors;
			this.SphereMultiply.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.SphereMultiply.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			this.SphereMultiply.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.CameraSphereTrace = new UTraceSphereElement();
			this.CameraSphereTrace.bIsSingle = true;
			this.CameraSphereTrace.bIgnoreSelf = true;
			this.CameraSphereTrace.bTraceComplex = true;
			this.CameraSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.CameraCheckSphereTrace = new UTraceSphereElement();
			this.CameraCheckSphereTrace.bIsSingle = true;
			this.CameraCheckSphereTrace.bIgnoreSelf = true;
			this.CameraCheckSphereTrace.bTraceComplex = true;
			if (this.ShowLog)
			{
				this.CameraCheckSphereTrace.DrawTime = 5f;
				this.CameraCheckSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			}
			this.CameraCheckSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
		}

		// Token: 0x060482C1 RID: 295617 RVA: 0x012851C0 File Offset: 0x012833C0
		protected override bool OnEnd()
		{
			this.UnbindSkillEndEvent();
			this.DisplayComponent = null;
			this.BindingActors.Empty(true);
			if (this.CameraSequenceActor != null)
			{
				ULevelSequencePlayer sequencePlayer = this.CameraSequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.OnStop.Clear();
				}
				ALevelSequenceActor tmp = this.CameraSequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("SequenceCameraPlayerComponent.OnEnd", tmp, null);
				}, null, null);
				this.CameraSequenceActor = null;
			}
			this.CameraSequence = null;
			this.LevelSequenceData = null;
			this.AnimInstance = null;
			this.OriginRootTransform = null;
			this.CharacterMoveComponent = null;
			this.SequenceCameraBlendInTime = 1f;
			this.SequenceCameraBlendOutTime = 1f;
			this.NeedWaitInPlot = false;
			this.IsInCinematic = false;
			if (this.IsHideHud)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.CameraSeq, 0);
				UiLayer.Instance.SetLayerRenderable(ELayerType.Float, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Pop, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Guide, true, "SeqCamera");
				EventSystem.Instance.Emit<bool, string>(EEventName.OnCameraSequenceSetUiVisible, true, this.CameraModelInstanceInternal.CameraName);
			}
			return true;
		}

		// Token: 0x060482C2 RID: 295618 RVA: 0x012852FC File Offset: 0x012834FC
		protected override void OnAfterTick(float delta)
		{
			if (this.CameraSequenceActor != null)
			{
				TsBaseCharacter character = this.Character;
				if (character == null || !character.IsValid() || !this.GetTargetCharacter().IsValid())
				{
					this.StopSequence();
					return;
				}
				int entityIdNoBlueprint = this.Character.GetEntityIdNoBlueprint();
				if (entityIdNoBlueprint == 0 || EntitySystem.Instance.Get(entityIdNoBlueprint) == null)
				{
					this.StopSequence();
					return;
				}
			}
			if (this.LevelSequenceData == null || this.AnimInstance == null || this.OriginRootTransform == null)
			{
				if (this.BlendingOutRestTime > 0f)
				{
					this.BlendingOutRestTime = Math.Max(0f, this.BlendingOutRestTime - delta * 0.001f);
					this.ProcessSocketTransform();
					this.CheckCollision(true);
				}
				return;
			}
			this.ProcessPlatformMoving();
			this.ProcessTimeScale();
			this.PlayedTime += delta * 0.001f * this.PlaySpeed;
			this.CameraSequenceActor.SequencePlayer.PlayToSeconds(this.PlayedTime);
			this.ProcessSocketTransform();
			this.ProcessIkOffset();
			this.ProcessMeshPosition();
			this.CheckCollision(false);
			this.ProcessDitherEffect();
			if (this.PlayedTime >= this.TimeLength)
			{
				this.SequenceStopInternal();
				return;
			}
			if (this.IsHideHud && this.HideHudTime > 0f && this.PlayedTime >= this.HideHudTime)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.CameraSeq, 0);
				UiLayer.Instance.SetLayerRenderable(ELayerType.Float, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Pop, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Guide, true, "SeqCamera");
				EventSystem.Instance.Emit<bool, string>(EEventName.OnCameraSequenceSetUiVisible, true, this.CameraModelInstanceInternal.CameraName);
				this.IsHideHud = false;
			}
		}

		// Token: 0x060482C3 RID: 295619 RVA: 0x012854BC File Offset: 0x012836BC
		private void ProcessTimeScale()
		{
			TsBaseCharacter character = this.Character;
			float? num;
			if (character == null)
			{
				num = null;
			}
			else
			{
				Entity entityNoBlueprint = character.GetEntityNoBlueprint();
				if (entityNoBlueprint == null)
				{
					num = null;
				}
				else
				{
					PawnTimeScaleComponent component = entityNoBlueprint.GetComponent<PawnTimeScaleComponent>();
					num = ((component != null) ? new float?(component.CurrentTimeScale) : null);
				}
			}
			float? num2 = num;
			this.PlaySpeed = num2.GetValueOrDefault(1f);
		}

		// Token: 0x060482C4 RID: 295620 RVA: 0x01285523 File Offset: 0x01283723
		private TsBaseCharacter GetTargetCharacter()
		{
			return (this.Target ?? CameraController.Instance.GetCharacter()) as TsBaseCharacter;
		}

		// Token: 0x060482C5 RID: 295621 RVA: 0x01285540 File Offset: 0x01283740
		private void SetupCameraSequence(SSequenceCamera_Settings settings, bool disableMovementInput = true, bool disableLookAtInput = true, [Nullable(2)] SSequenceCamera_SpecificConfig specificConfig = null)
		{
			this.IsEnableCollision = true;
			this.SequenceCameraBlendInTime = settings.BlendInTime;
			this.SequenceCameraBlendOutTime = settings.BlendOutTime;
			this.NeedWaitInPlot = settings.NeedWaitInPlot;
			this.CameraSequence = settings.CameraSequence;
			if (this.CameraSequence == null)
			{
				return;
			}
			this.ResetCameraRatioSetting();
			SequenceCameraDisplayComponent displayComponent = this.DisplayComponent;
			if (displayComponent != null)
			{
				BP_CineCamera_C cineCamera = displayComponent.CineCamera;
				if (cineCamera != null)
				{
					cineCamera.ResetSeqCineCamSetting();
				}
			}
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bDisableMovementInput = disableMovementInput;
			fmovieSceneSequencePlaybackSettings.bDisableLookAtInput = disableLookAtInput;
			this.CameraSequenceActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null, false) as ALevelSequenceActor);
			this.CameraSequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.CameraSequenceActor.SetSequence(this.CameraSequence);
			FQualifiedFrameTime startTime = this.CameraSequenceActor.SequencePlayer.GetStartTime();
			this.PlayedTime = ((float)startTime.Time.FrameNumber.Value + startTime.Time.SubFrame) * (float)startTime.Rate.Denominator / (float)startTime.Rate.Numerator;
			FQualifiedFrameTime endTime = this.CameraSequenceActor.SequencePlayer.GetEndTime();
			this.TimeLength = ((float)endTime.Time.FrameNumber.Value + endTime.Time.SubFrame) * (float)endTime.Rate.Denominator / (float)endTime.Rate.Numerator;
			if (settings.EnableSpecificSequenceTime)
			{
				this.TimeLength = Math.Min(this.TimeLength, settings.SpecificSequenceTime);
			}
			this.IsRecoverRotation = false;
			if (specificConfig != null)
			{
				this.TimeLength = Math.Min(this.TimeLength, specificConfig.OverrideSequenceTime);
				this.SequenceCameraBlendOutTime = specificConfig.OverrideBlendOutTime;
				if (specificConfig.IsRecoverRotation)
				{
					this.IsRecoverRotation = true;
					Rotator cameraRotator = this.CameraModelInstanceInternal.CameraRotator;
					this.RecoverRotation = new FRotator?(new FRotator(cameraRotator.Pitch, cameraRotator.Yaw, cameraRotator.Roll));
				}
			}
			this.SphereSingle.WorldContextObject = GlobalData.World;
			this.SphereMultiply.WorldContextObject = GlobalData.World;
			this.BindActors();
		}

		// Token: 0x060482C6 RID: 295622 RVA: 0x01285758 File Offset: 0x01283958
		private void HideHud(SSequenceCamera_Settings settings)
		{
			this.IsHideHud = settings.IsHideHud;
			if (this.IsHideHud)
			{
				this.HideHudTime = settings.HideHudTime;
				TArray<TEnumAsByte<EBattleUIChild>> visibleChild = settings.VisibleChild;
				int num = visibleChild.Num();
				if (num <= 0)
				{
					BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.CameraSeq, null, 0);
				}
				else
				{
					List<EBattleUiChild> list = new List<EBattleUiChild>();
					for (int i = 0; i < num; i++)
					{
						list.Add((EBattleUiChild)visibleChild.Get(i));
					}
					BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.CameraSeq, list, 0);
				}
				UiLayer.Instance.SetLayerRenderable(ELayerType.Float, false, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Pop, false, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Guide, false, "SeqCamera");
				EventSystem.Instance.Emit<bool, string>(EEventName.OnCameraSequenceSetUiVisible, false, this.CameraModelInstanceInternal.CameraName);
			}
		}

		// Token: 0x060482C7 RID: 295623 RVA: 0x0128583C File Offset: 0x01283A3C
		private void BindActors()
		{
			if (this.CameraSequenceActor == null)
			{
				return;
			}
			this.BindingActors.Add(this.DisplayComponent.CineCamera);
			this.CameraSequenceActor.SetBindingByTag(SequenceCameraPlayerComponent.SequenceCamera, this.BindingActors, false, false);
			this.BindingActors.Empty(true);
			if (this.Character != null)
			{
				this.BindingCharacterActors.Add(this.Character);
				this.CameraSequenceActor.SetBindingByTag(SequenceCameraPlayerComponent.RoleTag, this.BindingCharacterActors, false, false);
				this.BindingCharacterActors.Empty(true);
			}
		}

		// Token: 0x060482C8 RID: 295624 RVA: 0x012858CC File Offset: 0x01283ACC
		private bool Play(bool isIgnoreInitialSphereDetect, bool ignoreCharacterCollision)
		{
			bool result = false;
			if (!isIgnoreInitialSphereDetect && (this.CheckCameraLocation(ignoreCharacterCollision) || this.CheckSphereCollision()))
			{
				this.SequenceStopInternal();
			}
			else if (this.ActivateCamera())
			{
				this.PlaySequence();
				result = true;
			}
			else
			{
				this.SequenceStopInternal();
			}
			return result;
		}

		// Token: 0x060482C9 RID: 295625 RVA: 0x01285910 File Offset: 0x01283B10
		private bool CheckCameraLocation(bool ignoreCharacterCollision)
		{
			UMovieScene3DTransformTrack umovieScene3DTransformTrack = UKuroStaticLibrary.GetTrackByClass(UKuroStaticLibrary.GetSequenceTracksForObjectBindingID(this.CameraSequenceActor, SequenceCameraPlayerComponent.SequenceCamera), UMovieScene3DTransformTrack.StaticClass()) as UMovieScene3DTransformTrack;
			if (umovieScene3DTransformTrack == null)
			{
				return false;
			}
			FVectorDouble fvectorDouble = UKuroStaticLibrary.D_GetFirstLocationFromSeqTrack(umovieScene3DTransformTrack);
			TsBaseCharacter targetCharacter = this.GetTargetCharacter();
			FVectorDouble fvectorDouble2 = CameraUtility.GetRootTransform(targetCharacter).TransformPosition(fvectorDouble);
			this.SphereSingle.Radius = this.CameraModelInstanceInternal.FightCamera.LogicComponent.CollisionProbeSize;
			this.SphereSingle.ActorsToIgnore.Empty(true);
			if (ignoreCharacterCollision)
			{
				this.SphereSingle.ActorsToIgnore.Add(CameraController.Instance.GetCharacter());
			}
			TraceElementCommon.Instance.SetStartLocation(this.SphereSingle, fvectorDouble2);
			TraceElementCommon.Instance.SetEndLocation(this.SphereSingle, fvectorDouble2);
			bool flag = TraceElementCommon.Instance.SphereTrace(this.SphereSingle, "SequenceCameraPlayerComponent_CheckCameraLocation");
			if (flag)
			{
				UKuroHitResult hitResult = this.SphereSingle.HitResult;
				TWeakObjectPtr<AActor>? tweakObjectPtr = (hitResult != null) ? new TWeakObjectPtr<AActor>?(hitResult.Actors.Get(0)) : null;
				if (((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null) == targetCharacter)
				{
					Log.Instance.Warn(ELogModule.Camera, ELogAuthor.LJM, "Seq相机初始位置与角色碰撞，请检查Seq的相机初始位置", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
			}
			return flag;
		}

		// Token: 0x060482CA RID: 295626 RVA: 0x01285A68 File Offset: 0x01283C68
		private bool ActivateCamera()
		{
			if (this.CameraSequence == null)
			{
				return false;
			}
			TsBaseCharacter targetCharacter = this.GetTargetCharacter();
			if (targetCharacter == null)
			{
				return false;
			}
			if (this.CameraSequenceActor == null)
			{
				return false;
			}
			CharacterAnimationComponent component = targetCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
			if (component != null && component.Valid)
			{
				component.StopModelBuffer();
			}
			this.CameraSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.CameraSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			if (udefaultLevelSequenceInstanceData == null)
			{
				return false;
			}
			this.LevelSequenceData = udefaultLevelSequenceInstanceData;
			this.OriginRootTransform = new FTransformDouble?(CameraUtility.GetRootTransform(targetCharacter));
			BaseMoveComponent characterMoveComponent;
			if (targetCharacter == null)
			{
				characterMoveComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = targetCharacter.CharacterActorComponent;
				characterMoveComponent = ((characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<BaseMoveComponent>() : null);
			}
			this.CharacterMoveComponent = characterMoveComponent;
			if (component != null && component.Valid)
			{
				UAnimInstance mainAnimInstance = component.MainAnimInstance;
				if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ANIM_INSTANCE_ROLE))
				{
					this.AnimInstance = (mainAnimInstance as UKuroAnimInstanceRole);
				}
			}
			else
			{
				this.AnimInstance = null;
			}
			FTransformDouble? originMeshRelativeTransform;
			if (component == null)
			{
				originMeshRelativeTransform = null;
			}
			else
			{
				TsBaseCharacter actor = component.Actor;
				if (actor == null)
				{
					originMeshRelativeTransform = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actor.Mesh;
					originMeshRelativeTransform = ((mesh != null) ? new FTransformDouble?(mesh.D_GetRelativeTransform()) : null);
				}
			}
			this.OriginMeshRelativeTransform = originMeshRelativeTransform;
			this.ProcessIkOffset();
			ULevelSequencePlayer sequencePlayer = this.CameraSequenceActor.SequencePlayer;
			sequencePlayer.Play();
			sequencePlayer.SetPlayRate(0f);
			sequencePlayer.Pause();
			sequencePlayer.JumpToSeconds(this.PlayedTime);
			return true;
		}

		// Token: 0x060482CB RID: 295627 RVA: 0x01285BCC File Offset: 0x01283DCC
		private void SequenceStopInternal()
		{
			this.UnbindSkillEndEvent();
			if (this.IsEnableFrameAbstract && this.OriginMeshRelativeTransform != null)
			{
				TsBaseCharacter character = this.Character;
				CharacterAnimationComponent characterAnimationComponent;
				if (character == null)
				{
					characterAnimationComponent = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
					characterAnimationComponent = ((characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>() : null);
				}
				CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
				if (characterAnimationComponent2 != null && characterAnimationComponent2.Valid)
				{
					USkeletalMeshComponent mesh = characterAnimationComponent2.Actor.Mesh;
					if (mesh != null)
					{
						FTransformDouble value = this.OriginMeshRelativeTransform.Value;
						mesh.D_K2_SetRelativeTransform(value, false, ref WorldGlobal.SweepHitResult, true);
					}
				}
			}
			if (this.ResetFightCameraOnStop)
			{
				this.CameraModelInstanceInternal.FightCamera.LogicComponent.ResetArmLengthAndRotation(this.ResetAdditiveRotation.Value);
				if (this.IsRecoverRotation)
				{
					this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetRotation(this.RecoverRotation.Value);
					this.IsRecoverRotation = false;
				}
			}
			else
			{
				this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetRotation(this.CameraModelInstanceInternal.SequenceCamera.DisplayComponent.CineCamera.K2_GetActorRotation());
			}
			FightCamera fightCamera = this.CameraModelInstanceInternal.FightCamera;
			bool flag;
			if (fightCamera == null)
			{
				flag = (null != null);
			}
			else
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				flag = (((logicComponent != null) ? logicComponent.CameraCollision : null) != null);
			}
			if (flag)
			{
				this.CameraModelInstanceInternal.FightCamera.LogicComponent.UnlockCameraNpcDither(ENpcDitherLockType.SequenceCameraPlayer);
			}
			bool seamlessLockState = PlotModel.Instance.SeamlessLockState;
			this.ShowLog = false;
			this.IsInCinematic = false;
			if (this.IsHideHud)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.CameraSeq, 0);
				UiLayer.Instance.SetLayerRenderable(ELayerType.Float, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Pop, true, "SeqCamera");
				UiLayer.Instance.SetLayerRenderable(ELayerType.Guide, true, "SeqCamera");
				EventSystem.Instance.Emit<bool, string>(EEventName.OnCameraSequenceSetUiVisible, true, this.CameraModelInstanceInternal.CameraName);
				this.IsHideHud = false;
			}
			this.SequenceCameraBlendOutTime = ((!this.IsHit) ? this.SequenceCameraBlendOutTime : 0f);
			if (!seamlessLockState)
			{
				CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, this.SequenceCameraBlendOutTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, this.CameraModelInstanceInternal.CameraName, null);
			}
			else
			{
				APlayerCameraManager playerCameraManager = CameraController.Instance.GetPlayerCameraManager("MainCamera");
				if (playerCameraManager != null)
				{
					AActor newViewTarget = null;
					FViewTargetTransitionParams defaultViewTargetTransitionParams = CameraController.Instance.GetDefaultViewTargetTransitionParams();
					playerCameraManager.ResetViewTarget(newViewTarget, defaultViewTargetTransitionParams);
				}
				CameraController.Instance.ResetViewTarget(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, this.CameraModelInstanceInternal.CameraName, null);
			}
			this.CameraModelInstanceInternal.FightCamera.LogicComponent.ForceTickOutSide();
			this.BlendingOutRestTime = this.SequenceCameraBlendOutTime;
			if (this.CameraSequenceActor != null)
			{
				this.CameraSequenceActor.SequencePlayer.Stop();
				this.CameraSequenceActor.PlaybackSettings.bDisableMovementInput = false;
				this.CameraSequenceActor.PlaybackSettings.bDisableLookAtInput = false;
				ALevelSequenceActor tmp = this.CameraSequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("SequenceCameraPlayerComponent.SequenceStopInternal", tmp, null);
				}, null, null);
				this.CameraSequenceActor = null;
			}
			this.CameraSequence = null;
			TsBaseCharacter character2 = this.Character;
			if (character2 != null && character2.IsValid())
			{
				CharRenderingComponent charRenderingComponent = this.Character.CharRenderingComponent;
				if (charRenderingComponent != null)
				{
					charRenderingComponent.OnFinalizedLevelSequence();
				}
			}
			this.NeedWaitInPlot = false;
			this.LevelSequenceData = null;
			this.AnimInstance = null;
			this.OriginRootTransform = null;
			this.OriginMeshRelativeTransform = null;
			this.Target = null;
			if (!FNameUtil.IsEmpty(new FName?(this.SocketName)))
			{
				AActor transformOriginActor = this.TransformOriginActor;
				if (transformOriginActor != null && transformOriginActor.IsValid())
				{
					this.TransformOriginActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
			}
			this.SocketName = FNameUtil.EMPTY;
			EventSystem.Instance.Emit<bool, string>(EEventName.OnSequenceCameraStatus, false, this.CameraModelInstanceInternal.CameraName);
			CameraNearClipController.Instance.ClearSequenceCameraPlayerComponentNearClip();
			GameSettingsManager.Instance.ReApply(EFunction.MOTIONBLUR, EGameSettingsApplyReason.AnyTime, true);
		}

		// Token: 0x060482CC RID: 295628 RVA: 0x01285F94 File Offset: 0x01284194
		private void ProcessPlatformMoving()
		{
			if (!this.CharacterMoveComponent.HasDeltaBaseMovementData)
			{
				return;
			}
			FTransformDouble value = this.OriginRootTransform.Value;
			FVectorDouble value2 = this.CharacterMoveComponent.DeltaBaseMovementOffset.Value;
			value.AddToTranslation(value2);
			FQuat fquat = this.CharacterMoveComponent.DeltaBaseMovementQuat.ToUeQuat();
			value.ConcatenateRotation(fquat);
			this.OriginRootTransform = new FTransformDouble?(value);
		}

		// Token: 0x060482CD RID: 295629 RVA: 0x01285FFC File Offset: 0x012841FC
		private void ProcessIkOffset()
		{
			if (this.IsAttachToActor)
			{
				FTransformDouble actorTransform = this.Character.CharacterActorComponent.ActorTransform;
				FVectorDouble translation = actorTransform.GetTranslation();
				this.TmpTransformDouble.SetLocation(translation);
				FQuat fquat = actorTransform.GetRotation();
				this.TmpTransformDouble.SetRotation(fquat);
				FVector scale3D = actorTransform.GetScale3D();
				this.TmpTransformDouble.SetScale3D(scale3D);
				CameraUtility.GetRotatorInGravity(this.MeshRotator, this.TmpRotator);
				this.TmpRotator.Quaternion(this.TmpQuat);
				fquat = this.TmpQuat.ToUeQuat();
				this.TmpTransformDouble.ConcatenateRotation(fquat);
				FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(this.TmpTransformDouble);
				this.LevelSequenceData.TransformOrigin = transformOrigin;
				return;
			}
			if (FNameUtil.IsEmpty(new FName?(this.SocketName)))
			{
				FTransform transformOrigin2 = UKismetMathLibrary.Conv_TransformDoubleToTransform(this.ConstructTransform(this.OriginRootTransform.Value));
				this.LevelSequenceData.TransformOrigin = transformOrigin2;
				return;
			}
			AActor transformOriginActor = this.TransformOriginActor;
			if (transformOriginActor != null && transformOriginActor.IsValid())
			{
				this.LevelSequenceData.TransformOriginActor = this.TransformOriginActor;
				SequenceCameraDisplayComponent displayComponent = this.DisplayComponent;
				if (((displayComponent != null) ? displayComponent.CineCamera : null) == null)
				{
					return;
				}
				FVectorDouble newLocation = this.DisplayComponent.CineCamera.D_K2_GetActorLocation();
				FHitResult fhitResult = new FHitResult();
				this.DisplayComponent.CineCamera.D_K2_SetActorLocation(newLocation, false, ref fhitResult, false);
			}
		}

		// Token: 0x060482CE RID: 295630 RVA: 0x01286160 File Offset: 0x01284360
		private void ProcessMeshPosition()
		{
			if (!this.IsEnableFrameAbstract || this.CameraTransformTrack == null || this.Character == null || this.FrameAbstractDelta < 0.05f)
			{
				return;
			}
			int num = (int)Math.Floor((double)(this.PlayedTime / this.FrameAbstractDelta));
			if (num != this.FrameAbstractTime)
			{
				this.FrameAbstractTime = num;
				float time = (float)num * this.FrameAbstractDelta;
				this.FrameAbstractRelativeCameraTransform = SequenceUtils.GetLevelSequenceTransform(this.CameraSequence, this.CameraTransformTrack, time).Inverse();
			}
			CharacterAnimationComponent component = this.Character.GetEntityNoBlueprint().GetComponent<CharacterAnimationComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			FTransformDouble ftransformDouble = this.DisplayComponent.CineCamera.D_GetTransform();
			FTransformDouble ftransformDouble2 = this.FrameAbstractRelativeCameraTransform * ftransformDouble;
			TsBaseCharacter actor = component.Actor;
			if (actor == null)
			{
				return;
			}
			USkeletalMeshComponent mesh = actor.Mesh;
			if (mesh == null)
			{
				return;
			}
			mesh.D_K2_SetWorldTransform(ftransformDouble2, false, ref WorldGlobal.SweepHitResult, true);
		}

		// Token: 0x060482CF RID: 295631 RVA: 0x0128624C File Offset: 0x0128444C
		private void ProcessDitherEffect()
		{
			if (!this.IsDitherEffectEnabled)
			{
				return;
			}
			TsBaseCharacter character = this.Character;
			if (character == null || !character.IsValid())
			{
				return;
			}
			if (this.SocketTransform == null || !this.SocketTransform.GetValueOrDefault().IsValid())
			{
				return;
			}
			FightCamera fightCamera = this.CameraModelInstanceInternal.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
			if (fightCameraLogicComponent == null)
			{
				return;
			}
			Vector tmpVector = this.TmpVector;
			FVectorDouble fvectorDouble = this.SocketTransform.Value.GetLocation();
			tmpVector.DeepCopy(fvectorDouble);
			Vector cameraLocation = this.CameraLocation;
			fvectorDouble = this.DisplayComponent.CineCamera.D_K2_GetActorLocation();
			cameraLocation.DeepCopy(fvectorDouble);
			Rotator cameraRotation = this.CameraRotation;
			FRotator frotator = this.DisplayComponent.CineCamera.K2_GetActorRotation();
			cameraRotation.DeepCopy(frotator);
			CameraUtility.GetRotatorInGravity(this.CameraRotation, this.CameraRotationInGravity);
			double num = Vector.DistSquared(this.TmpVector, this.CameraLocation);
			float outRangeB = 0.01f;
			float val = 1f;
			if (num < (double)fightCameraLogicComponent.StartHideDistanceSquared)
			{
				val = MathUtils.Instance.RangeClamp((float)Math.Sqrt(num), fightCameraLogicComponent.StartHideDistance, fightCameraLogicComponent.CompleteHideDistance, fightCameraLogicComponent.StartDitherValue, outRangeB);
			}
			float pitch = this.CameraRotationInGravity.Pitch;
			float val2 = 1f;
			if (pitch > fightCameraLogicComponent.StartHidePitch)
			{
				val2 = MathUtils.Instance.RangeClamp(pitch, fightCameraLogicComponent.StartHidePitch, fightCameraLogicComponent.CompleteHidePitch, fightCameraLogicComponent.StartDitherValue, outRangeB);
			}
			float dither = Math.Min(val, val2);
			this.Character.SetDitherEffect(dither, ECharacterDitherType.Fight);
		}

		// Token: 0x060482D0 RID: 295632 RVA: 0x012863D4 File Offset: 0x012845D4
		[NullableContext(2)]
		private bool CheckBreakSequence(TsBaseCharacter character, TsBaseCharacter target)
		{
			if (target == null || !target.IsValid())
			{
				return false;
			}
			if (character == null || !character.IsValid())
			{
				return true;
			}
			if (character == target)
			{
				return true;
			}
			Entity entityNoBlueprint = character.GetEntityNoBlueprint();
			object obj = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
			Entity entityNoBlueprint2 = target.GetEntityNoBlueprint();
			CreatureDataComponent creatureDataComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<CreatureDataComponent>() : null;
			object obj2 = obj;
			return obj2 != null && obj2.IsRole() && creatureDataComponent != null && creatureDataComponent.IsMonster();
		}

		// Token: 0x060482D1 RID: 295633 RVA: 0x01286450 File Offset: 0x01284650
		private void PlaySequence()
		{
			this.IgnoreActors.Empty(true);
			this.IgnoreActors.Add(CameraController.Instance.GetCharacter());
			if (this.Target != null)
			{
				this.IgnoreActors.Add(this.Target);
			}
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, this.SequenceCameraBlendInTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, this.CameraModelInstanceInternal.CameraName, null);
			FightCamera fightCamera = this.CameraModelInstanceInternal.FightCamera;
			if (((fightCamera != null) ? fightCamera.LogicComponent : null) != null)
			{
				this.CameraModelInstanceInternal.FightCamera.LogicComponent.LockCameraNpcDither(ENpcDitherLockType.SequenceCameraPlayer);
			}
			this.IsInCinematic = true;
		}

		// Token: 0x060482D2 RID: 295634 RVA: 0x012864F4 File Offset: 0x012846F4
		private FTransformDouble ConstructTransform(FTransformDouble transform)
		{
			FQuat rotation = transform.GetRotation();
			FVectorDouble translation = transform.GetTranslation();
			FVector scale3D = transform.GetScale3D();
			return new FTransformDouble(ref rotation, ref translation, ref scale3D);
		}

		// Token: 0x060482D3 RID: 295635 RVA: 0x01286524 File Offset: 0x01284724
		protected override void OnChangeTimeDilation(float timeDilation)
		{
		}

		// Token: 0x060482D4 RID: 295636 RVA: 0x01286528 File Offset: 0x01284728
		private void ProcessSocketTransform()
		{
			TsBaseCharacter character = this.Character;
			if (character == null || !character.IsValid())
			{
				return;
			}
			if (FNameUtil.IsEmpty(new FName?(this.LockSocketName)))
			{
				CharacterAnimationComponent component = this.Character.GetEntityNoBlueprint().GetComponent<CharacterAnimationComponent>();
				this.SocketTransform = new FTransformDouble?(component.GetCameraTransform());
				return;
			}
			this.SocketTransform = this.GetBoneTransform(this.LockSocketName);
		}

		// Token: 0x060482D5 RID: 295637 RVA: 0x01286594 File Offset: 0x01284794
		public void CheckCollision(bool isBlendOut)
		{
			if (this.SocketTransform == null || !this.SocketTransform.GetValueOrDefault().IsValid())
			{
				Log.Instance.Error(ELogModule.Character, ELogAuthor.ZQ, "CheckCollision  SocketTransform 不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CameraSphereTrace.WorldContextObject = GlobalData.World;
			this.IgnoreActors.Empty(true);
			this.IgnoreActors.Add(CameraController.Instance.GetCharacter());
			this.CameraSphereTrace.ActorsToIgnore = this.IgnoreActors;
			TraceElementCommon.Instance.SetStartLocation(this.CameraSphereTrace, this.SocketTransform.Value.GetLocation());
			Vector cameraLocation = this.CameraLocation;
			FVectorDouble fvectorDouble = this.DisplayComponent.CineCamera.D_K2_GetActorLocation();
			cameraLocation.DeepCopy(fvectorDouble);
			TraceElementCommon.Instance.SetEndLocation(this.CameraSphereTrace, this.CameraLocation);
			this.CameraSphereTrace.Radius = 10f;
			this.IsHit = TraceElementCommon.Instance.SphereTrace(this.CameraSphereTrace, "SequenceCameraPlayerComponent_ProcessHideShelterCharacter");
			if (this.IsHit && (isBlendOut || this.IsEnableCollision))
			{
				TraceElementCommon.Instance.GetHitLocation(this.CameraSphereTrace.HitResult, 0, this.HitLocation);
				this.DisplayComponent.CineCamera.D_K2_SetActorLocation(this.HitLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x060482D6 RID: 295638 RVA: 0x01286700 File Offset: 0x01284900
		public bool CheckSphereCollision()
		{
			if (this.CheckRadius == 0f)
			{
				return false;
			}
			this.CameraCheckSphereTrace.WorldContextObject = GlobalData.World;
			CharacterAnimationComponent component = this.Character.GetEntityNoBlueprint().GetComponent<CharacterAnimationComponent>();
			this.SocketTransform = new FTransformDouble?(component.GetCameraTransform());
			component.GetCameraPosition(this.SourceLocation);
			this.SourceForward.DeepCopy(this.Character.CharacterActorComponent.ActorForwardProxy);
			this.SourceForward.Multiply(this.RelativeLocation.X, this.SourceForward);
			this.HorizontalVector.DeepCopy(Vector.OneVectorProxy);
			this.HorizontalVector.Multiply(this.RelativeLocation.Y, this.HorizontalVector);
			this.Up.DeepCopy(Vector.UpVectorProxy);
			this.Up.Multiply(this.RelativeLocation.Z, this.Up);
			this.SourceLocation.Addition(this.SourceForward, this.SourceLocation);
			this.SourceLocation.Addition(this.HorizontalVector, this.SourceLocation);
			this.SourceLocation.Addition(this.Up, this.SourceLocation);
			this.IgnoreActors.Empty(true);
			this.IgnoreActors.Add(CameraController.Instance.GetCharacter());
			this.CameraCheckSphereTrace.ActorsToIgnore = this.IgnoreActors;
			TraceElementCommon.Instance.SetStartLocation(this.CameraCheckSphereTrace, this.SourceLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraCheckSphereTrace, this.SourceLocation);
			this.CameraCheckSphereTrace.Radius = this.CheckRadius;
			return TraceElementCommon.Instance.SphereTrace(this.CameraCheckSphereTrace, "SequenceCameraPlayerComponent_ProcessHideShelterCharacter");
		}

		// Token: 0x060482D7 RID: 295639 RVA: 0x012868B8 File Offset: 0x01284AB8
		public FTransformDouble? GetBoneTransform(FName boneName)
		{
			return new FTransformDouble?(this.Character.Mesh.D_GetSocketTransform(boneName, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x060482D8 RID: 295640 RVA: 0x012868D1 File Offset: 0x01284AD1
		public void SetCameraCollisionState(bool isEnableCollision)
		{
			this.IsEnableCollision = isEnableCollision;
		}

		// Token: 0x060482D9 RID: 295641 RVA: 0x012868DC File Offset: 0x01284ADC
		protected void DrawCube(FTransformDouble transform, float duration, float colorValue)
		{
			FLinearColor lineColor = new FLinearColor(colorValue, colorValue, colorValue, colorValue);
			FVectorDouble location = transform.GetLocation();
			FVector fvector = new FVector(10f, 10f, 10f);
			FVectorDouble extent = new FVectorDouble((double)fvector.X * 0.5, (double)fvector.Y * 0.5, (double)fvector.Z * 0.5);
			FRotator rotation = transform.Rotator();
			int num = 30;
			UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, location, extent, lineColor, rotation, duration, (float)num);
			FVectorDouble lineStart = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(0.5, 0.5, 0.5));
			FVectorDouble lineEnd = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(-0.5, -0.5, -0.5));
			int num2 = 15;
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart, lineEnd, lineColor, duration, (float)num2);
			FVectorDouble lineStart2 = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(0.5, -0.5, 0.5));
			FVectorDouble lineEnd2 = UKismetMathLibrary.D_TransformLocation(transform, new FVectorDouble(-0.5, 0.5, 0.5));
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart2, lineEnd2, lineColor, duration, (float)num2);
		}

		// Token: 0x060482DA RID: 295642 RVA: 0x01286A3C File Offset: 0x01284C3C
		public SeqCameraThings SaveSeqCamera()
		{
			return new SeqCameraThings
			{
				CameraLocation = this.DisplayComponent.CineCamera.D_K2_GetActorLocation(),
				CameraRotation = this.DisplayComponent.CineCamera.K2_GetActorRotation(),
				OriginRootTransform = this.OriginRootTransform,
				ConstrainAspectRatio = this.DisplayComponent.CineCamera.Constrain_Aspect_Ratio,
				CurrentAperture = this.DisplayComponent.CineCamera.Current_Aperture,
				CurrentFocalLength = this.DisplayComponent.CineCamera.Current_Focal_Length,
				FocusSettings = this.DisplayComponent.CineCamera.Focus_Settings,
				LensSettings = this.DisplayComponent.CineCamera.Lens_Settings,
				FieldOfView = this.DisplayComponent.CineCamera.GetCineCameraComponent().FieldOfView
			};
		}

		// Token: 0x060482DB RID: 295643 RVA: 0x01286B0F File Offset: 0x01284D0F
		public bool GetIfNeedWaitInPlot()
		{
			return this.NeedWaitInPlot;
		}

		// Token: 0x060482DC RID: 295644 RVA: 0x01286B17 File Offset: 0x01284D17
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x060482DD RID: 295645 RVA: 0x01286B24 File Offset: 0x01284D24
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent = (SequenceCameraPlayerComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (sequenceCameraPlayerComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisplayComponent"))
			{
				if (sequenceCameraPlayerComponent.DisplayComponent == null)
				{
					this.DisplayComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SequenceCameraDisplayComponent>(this.DisplayComponent), "DisplayComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IgnoreActors") && sequenceCameraPlayerComponent.IgnoreActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.IgnoreActors), "IgnoreActors"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraSequence"))
			{
				if (sequenceCameraPlayerComponent.CameraSequence == null)
				{
					this.CameraSequence = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ULevelSequence>(this.CameraSequence), "CameraSequence"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraSequenceActor"))
			{
				if (sequenceCameraPlayerComponent.CameraSequenceActor == null)
				{
					this.CameraSequenceActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ALevelSequenceActor>(this.CameraSequenceActor), "CameraSequenceActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PlayedTime"))
			{
				this.PlayedTime = sequenceCameraPlayerComponent.PlayedTime;
			}
			if (base.CanResetComponentProperty("TimeLength"))
			{
				this.TimeLength = sequenceCameraPlayerComponent.TimeLength;
			}
			if (base.CanResetComponentProperty("PlaySpeed"))
			{
				this.PlaySpeed = sequenceCameraPlayerComponent.PlaySpeed;
			}
			if (base.CanResetComponentProperty("SequenceCameraBlendInTime"))
			{
				this.SequenceCameraBlendInTime = sequenceCameraPlayerComponent.SequenceCameraBlendInTime;
			}
			if (base.CanResetComponentProperty("SequenceCameraBlendOutTime"))
			{
				this.SequenceCameraBlendOutTime = sequenceCameraPlayerComponent.SequenceCameraBlendOutTime;
			}
			if (base.CanResetComponentProperty("BlendingOutRestTime"))
			{
				this.BlendingOutRestTime = sequenceCameraPlayerComponent.BlendingOutRestTime;
			}
			if (base.CanResetComponentProperty("LevelSequenceData"))
			{
				if (sequenceCameraPlayerComponent.LevelSequenceData == null)
				{
					this.LevelSequenceData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UDefaultLevelSequenceInstanceData>(this.LevelSequenceData), "LevelSequenceData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimInstance"))
			{
				if (sequenceCameraPlayerComponent.AnimInstance == null)
				{
					this.AnimInstance = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroAnimInstanceRole>(this.AnimInstance), "AnimInstance"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OriginRootTransform"))
			{
				this.OriginRootTransform = sequenceCameraPlayerComponent.OriginRootTransform;
			}
			if (base.CanResetComponentProperty("OriginMeshRelativeTransform"))
			{
				this.OriginMeshRelativeTransform = sequenceCameraPlayerComponent.OriginMeshRelativeTransform;
			}
			if (base.CanResetComponentProperty("CharacterMoveComponent"))
			{
				if (sequenceCameraPlayerComponent.CharacterMoveComponent == null)
				{
					this.CharacterMoveComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.CharacterMoveComponent), "CharacterMoveComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInCinematic"))
			{
				this.IsInCinematic = sequenceCameraPlayerComponent.IsInCinematic;
			}
			if (base.CanResetComponentProperty("IsHideHud"))
			{
				this.IsHideHud = sequenceCameraPlayerComponent.IsHideHud;
			}
			if (base.CanResetComponentProperty("HideHudTime"))
			{
				this.HideHudTime = sequenceCameraPlayerComponent.HideHudTime;
			}
			if (base.CanResetComponentProperty("BindingActors") && sequenceCameraPlayerComponent.BindingActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingActors), "BindingActors"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("BindingCharacterActors") && sequenceCameraPlayerComponent.BindingCharacterActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingCharacterActors), "BindingCharacterActors"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ResetAdditiveRotation"))
			{
				this.ResetAdditiveRotation = sequenceCameraPlayerComponent.ResetAdditiveRotation;
			}
			if (base.CanResetComponentProperty("ResetFightCameraOnStop"))
			{
				this.ResetFightCameraOnStop = sequenceCameraPlayerComponent.ResetFightCameraOnStop;
			}
			if (base.CanResetComponentProperty("RecoverRotation"))
			{
				this.RecoverRotation = sequenceCameraPlayerComponent.RecoverRotation;
			}
			if (base.CanResetComponentProperty("IsRecoverRotation"))
			{
				this.IsRecoverRotation = sequenceCameraPlayerComponent.IsRecoverRotation;
			}
			if (base.CanResetComponentProperty("Target"))
			{
				if (sequenceCameraPlayerComponent.Target == null)
				{
					this.Target = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.Target), "Target"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Character"))
			{
				if (sequenceCameraPlayerComponent.Character == null)
				{
					this.Character = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.Character), "Character"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OldCharacter"))
			{
				if (sequenceCameraPlayerComponent.OldCharacter == null)
				{
					this.OldCharacter = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.OldCharacter), "OldCharacter"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SphereSingle"))
			{
				if (sequenceCameraPlayerComponent.SphereSingle == null)
				{
					this.SphereSingle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.SphereSingle), "SphereSingle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SphereMultiply"))
			{
				if (sequenceCameraPlayerComponent.SphereMultiply == null)
				{
					this.SphereMultiply = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.SphereMultiply), "SphereMultiply"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SocketName"))
			{
				this.SocketName = sequenceCameraPlayerComponent.SocketName;
			}
			if (base.CanResetComponentProperty("LockSocketName"))
			{
				this.LockSocketName = sequenceCameraPlayerComponent.LockSocketName;
			}
			if (base.CanResetComponentProperty("TransformOriginActor"))
			{
				if (sequenceCameraPlayerComponent.TransformOriginActor == null)
				{
					this.TransformOriginActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.TransformOriginActor), "TransformOriginActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RelativeLocation") && sequenceCameraPlayerComponent.RelativeLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.RelativeLocation), "RelativeLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ShowLog"))
			{
				this.ShowLog = sequenceCameraPlayerComponent.ShowLog;
			}
			if (base.CanResetComponentProperty("CheckRadius"))
			{
				this.CheckRadius = sequenceCameraPlayerComponent.CheckRadius;
			}
			if (base.CanResetComponentProperty("IsEnableCollision"))
			{
				this.IsEnableCollision = sequenceCameraPlayerComponent.IsEnableCollision;
			}
			if (base.CanResetComponentProperty("NeedWaitInPlot"))
			{
				this.NeedWaitInPlot = sequenceCameraPlayerComponent.NeedWaitInPlot;
			}
			if (base.CanResetComponentProperty("IsPlayCameraSequenceEnabled"))
			{
				this.IsPlayCameraSequenceEnabled = sequenceCameraPlayerComponent.IsPlayCameraSequenceEnabled;
			}
			if (base.CanResetComponentProperty("IsEnableFrameAbstract"))
			{
				this.IsEnableFrameAbstract = sequenceCameraPlayerComponent.IsEnableFrameAbstract;
			}
			if (base.CanResetComponentProperty("FrameAbstractDelta"))
			{
				this.FrameAbstractDelta = sequenceCameraPlayerComponent.FrameAbstractDelta;
			}
			if (base.CanResetComponentProperty("FrameAbstractTime"))
			{
				this.FrameAbstractTime = sequenceCameraPlayerComponent.FrameAbstractTime;
			}
			if (base.CanResetComponentProperty("CameraTransformTrack"))
			{
				if (sequenceCameraPlayerComponent.CameraTransformTrack == null)
				{
					this.CameraTransformTrack = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UMovieSceneTrack>(this.CameraTransformTrack), "CameraTransformTrack"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FrameAbstractRelativeCameraTransform"))
			{
				this.FrameAbstractRelativeCameraTransform = sequenceCameraPlayerComponent.FrameAbstractRelativeCameraTransform;
			}
			if (base.CanResetComponentProperty("IsAttachToActor"))
			{
				this.IsAttachToActor = sequenceCameraPlayerComponent.IsAttachToActor;
			}
			if (base.CanResetComponentProperty("DitherEffectEnableSet") && sequenceCameraPlayerComponent.DitherEffectEnableSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<ESequenceCameraDitherEffectEnum>(this.DitherEffectEnableSet), "DitherEffectEnableSet"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("BindSkillEntity"))
			{
				if (sequenceCameraPlayerComponent.BindSkillEntity == null)
				{
					this.BindSkillEntity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.BindSkillEntity), "BindSkillEntity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BindSkillId"))
			{
				this.BindSkillId = sequenceCameraPlayerComponent.BindSkillId;
			}
			if (base.CanResetComponentProperty("MeshRotator") && sequenceCameraPlayerComponent.MeshRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.MeshRotator), "MeshRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector") && sequenceCameraPlayerComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpTransformDouble"))
			{
				this.TmpTransformDouble = sequenceCameraPlayerComponent.TmpTransformDouble;
			}
			if (base.CanResetComponentProperty("TmpRotator") && sequenceCameraPlayerComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator), "TmpRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpQuat") && sequenceCameraPlayerComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat), "TmpQuat"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraSphereTrace"))
			{
				if (sequenceCameraPlayerComponent.CameraSphereTrace == null)
				{
					this.CameraSphereTrace = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.CameraSphereTrace), "CameraSphereTrace"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraCheckSphereTrace"))
			{
				if (sequenceCameraPlayerComponent.CameraCheckSphereTrace == null)
				{
					this.CameraCheckSphereTrace = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.CameraCheckSphereTrace), "CameraCheckSphereTrace"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsHit"))
			{
				this.IsHit = sequenceCameraPlayerComponent.IsHit;
			}
			if (base.CanResetComponentProperty("HitLocation") && sequenceCameraPlayerComponent.HitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.HitLocation), "HitLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraLocation") && sequenceCameraPlayerComponent.CameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CameraLocation), "CameraLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraRotation") && sequenceCameraPlayerComponent.CameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.CameraRotation), "CameraRotation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CameraRotationInGravity") && sequenceCameraPlayerComponent.CameraRotationInGravity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.CameraRotationInGravity), "CameraRotationInGravity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("SocketTransform"))
			{
				this.SocketTransform = sequenceCameraPlayerComponent.SocketTransform;
			}
			return (!base.CanResetComponentProperty("SourceLocation") || sequenceCameraPlayerComponent.SourceLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SourceLocation), "SourceLocation")) && (!base.CanResetComponentProperty("SourceForward") || sequenceCameraPlayerComponent.SourceForward == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SourceForward), "SourceForward")) && (!base.CanResetComponentProperty("HorizontalVector") || sequenceCameraPlayerComponent.HorizontalVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.HorizontalVector), "HorizontalVector")) && (!base.CanResetComponentProperty("Up") || sequenceCameraPlayerComponent.Up == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.Up), "Up"));
		}

		// Token: 0x0402616A RID: 156010
		private const string PROFILE_KEY1 = "SequenceCameraPlayerComponent_CheckCameraLocation";

		// Token: 0x0402616B RID: 156011
		private const string PROFILE_KEY2 = "SequenceCameraPlayerComponent_ProcessHideShelterCharacter";

		// Token: 0x0402616C RID: 156012
		private const double RELATIVE_LENGTH = 10000.0;

		// Token: 0x0402616D RID: 156013
		private const float MINI_FRAME_ABSTRACT_DELTA = 0.05f;

		// Token: 0x0402616E RID: 156014
		[StaticVariableRuleIgnore]
		private static readonly Stat SequenceTransformStat = Stat.Create("SequenceTransformStat", "", "");

		// Token: 0x0402616F RID: 156015
		private static readonly FName SequenceCamera = new FName("SequenceCamera");

		// Token: 0x04026170 RID: 156016
		private static readonly FName RoleTag = new FName("Role");

		// Token: 0x04026171 RID: 156017
		[Nullable(2)]
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04026172 RID: 156018
		[Nullable(2)]
		private SequenceCameraDisplayComponent DisplayComponent;

		// Token: 0x04026173 RID: 156019
		private readonly TArray<AActor> IgnoreActors = new TArray<AActor>();

		// Token: 0x04026174 RID: 156020
		[Nullable(2)]
		private ULevelSequence CameraSequence;

		// Token: 0x04026175 RID: 156021
		[Nullable(2)]
		private ALevelSequenceActor CameraSequenceActor;

		// Token: 0x04026176 RID: 156022
		private float PlayedTime;

		// Token: 0x04026177 RID: 156023
		private float TimeLength;

		// Token: 0x04026178 RID: 156024
		private float PlaySpeed = 1f;

		// Token: 0x04026179 RID: 156025
		private float SequenceCameraBlendInTime = 1f;

		// Token: 0x0402617A RID: 156026
		private float SequenceCameraBlendOutTime = 1f;

		// Token: 0x0402617B RID: 156027
		private float BlendingOutRestTime;

		// Token: 0x0402617C RID: 156028
		[Nullable(2)]
		private UDefaultLevelSequenceInstanceData LevelSequenceData;

		// Token: 0x0402617D RID: 156029
		[Nullable(2)]
		private UKuroAnimInstanceRole AnimInstance;

		// Token: 0x0402617E RID: 156030
		private FTransformDouble? OriginRootTransform;

		// Token: 0x0402617F RID: 156031
		private FTransformDouble? OriginMeshRelativeTransform;

		// Token: 0x04026180 RID: 156032
		[Nullable(2)]
		private BaseMoveComponent CharacterMoveComponent;

		// Token: 0x04026181 RID: 156033
		private bool IsInCinematic;

		// Token: 0x04026182 RID: 156034
		private bool IsHideHud;

		// Token: 0x04026183 RID: 156035
		private float HideHudTime;

		// Token: 0x04026184 RID: 156036
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x04026185 RID: 156037
		private readonly TArray<AActor> BindingCharacterActors = new TArray<AActor>();

		// Token: 0x04026186 RID: 156038
		private FRotator? ResetAdditiveRotation;

		// Token: 0x04026187 RID: 156039
		private bool ResetFightCameraOnStop;

		// Token: 0x04026188 RID: 156040
		private FRotator? RecoverRotation;

		// Token: 0x04026189 RID: 156041
		private bool IsRecoverRotation;

		// Token: 0x0402618A RID: 156042
		[Nullable(2)]
		private TsBaseCharacter Target;

		// Token: 0x0402618B RID: 156043
		[Nullable(2)]
		private TsBaseCharacter Character;

		// Token: 0x0402618C RID: 156044
		[Nullable(2)]
		private TsBaseCharacter OldCharacter;

		// Token: 0x0402618D RID: 156045
		[Nullable(2)]
		private UTraceSphereElement SphereSingle;

		// Token: 0x0402618E RID: 156046
		[Nullable(2)]
		private UTraceSphereElement SphereMultiply;

		// Token: 0x0402618F RID: 156047
		private FName SocketName = FNameUtil.EMPTY;

		// Token: 0x04026190 RID: 156048
		private FName LockSocketName = FNameUtil.EMPTY;

		// Token: 0x04026191 RID: 156049
		[Nullable(2)]
		private AActor TransformOriginActor;

		// Token: 0x04026192 RID: 156050
		private readonly Vector RelativeLocation = Vector.Create(10000.0, 10000.0, 10000.0);

		// Token: 0x04026193 RID: 156051
		private bool ShowLog;

		// Token: 0x04026194 RID: 156052
		private float CheckRadius;

		// Token: 0x04026195 RID: 156053
		private bool IsEnableCollision = true;

		// Token: 0x04026196 RID: 156054
		private bool NeedWaitInPlot;

		// Token: 0x04026197 RID: 156055
		private bool IsPlayCameraSequenceEnabled = true;

		// Token: 0x04026198 RID: 156056
		private bool IsEnableFrameAbstract;

		// Token: 0x04026199 RID: 156057
		private float FrameAbstractDelta;

		// Token: 0x0402619A RID: 156058
		private int FrameAbstractTime;

		// Token: 0x0402619B RID: 156059
		[Nullable(2)]
		private UMovieSceneTrack CameraTransformTrack;

		// Token: 0x0402619C RID: 156060
		private FTransformDouble FrameAbstractRelativeCameraTransform;

		// Token: 0x0402619D RID: 156061
		private readonly bool DebugFrameAbstract;

		// Token: 0x0402619E RID: 156062
		private bool IsAttachToActor;

		// Token: 0x0402619F RID: 156063
		private readonly HashSet<ESequenceCameraDitherEffectEnum> DitherEffectEnableSet = new HashSet<ESequenceCameraDitherEffectEnum>();

		// Token: 0x040261A0 RID: 156064
		[Nullable(2)]
		private Entity BindSkillEntity;

		// Token: 0x040261A1 RID: 156065
		private long? BindSkillId;

		// Token: 0x040261A2 RID: 156066
		private readonly Rotator MeshRotator = Rotator.Create(0f, -90f, 0f);

		// Token: 0x040261A3 RID: 156067
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x040261A4 RID: 156068
		private FTransformDouble TmpTransformDouble = new FTransformDouble();

		// Token: 0x040261A5 RID: 156069
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x040261A6 RID: 156070
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040261A7 RID: 156071
		[Nullable(2)]
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x040261A8 RID: 156072
		[Nullable(2)]
		private UTraceSphereElement CameraCheckSphereTrace;

		// Token: 0x040261A9 RID: 156073
		private bool IsHit;

		// Token: 0x040261AA RID: 156074
		private readonly Vector HitLocation = Vector.Create();

		// Token: 0x040261AB RID: 156075
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x040261AC RID: 156076
		private readonly Rotator CameraRotation = Rotator.Create();

		// Token: 0x040261AD RID: 156077
		private readonly Rotator CameraRotationInGravity = Rotator.Create();

		// Token: 0x040261AE RID: 156078
		private FTransformDouble? SocketTransform;

		// Token: 0x040261AF RID: 156079
		private readonly Vector SourceLocation = Vector.Create();

		// Token: 0x040261B0 RID: 156080
		private readonly Vector SourceForward = Vector.Create();

		// Token: 0x040261B1 RID: 156081
		private readonly Vector HorizontalVector = Vector.Create();

		// Token: 0x040261B2 RID: 156082
		private readonly Vector Up = Vector.Create();
	}
}
