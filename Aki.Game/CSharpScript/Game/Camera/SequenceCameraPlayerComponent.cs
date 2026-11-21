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
	// Token: 0x02006464 RID: 25700
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceCameraPlayerComponent : EntityComponent
	{
		// Token: 0x170076D6 RID: 30422
		// (get) Token: 0x0603E6E5 RID: 255717 RVA: 0x0122762A File Offset: 0x0122582A
		public bool IsDitherEffectEnabled
		{
			get
			{
				return this.DitherEffectEnableSet.Count > 0;
			}
		}

		// Token: 0x170076D7 RID: 30423
		// (get) Token: 0x0603E6E6 RID: 255718 RVA: 0x0122763A File Offset: 0x0122583A
		[Nullable(2)]
		public CameraModelInstance CameraModel
		{
			[NullableContext(2)]
			get
			{
				return this.CameraModelInstanceInternal;
			}
		}

		// Token: 0x0603E6E7 RID: 255719 RVA: 0x01227642 File Offset: 0x01225842
		public void SetPlayCameraSequenceEnabled(bool enabled)
		{
			this.IsPlayCameraSequenceEnabled = enabled;
		}

		// Token: 0x0603E6E8 RID: 255720 RVA: 0x0122764B File Offset: 0x0122584B
		public void SetSeparateSequencePlayerLogicEnabled(bool enabled)
		{
			this.IsSeparateSequencePlayerLogicEnabled = enabled;
		}

		// Token: 0x0603E6E9 RID: 255721 RVA: 0x01227654 File Offset: 0x01225854
		[NullableContext(2)]
		public void SetPawn(APawn pawn)
		{
			TsBaseCharacter tsBaseCharacter = pawn as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				this.SetCharacter(tsBaseCharacter);
			}
		}

		// Token: 0x0603E6EA RID: 255722 RVA: 0x01227672 File Offset: 0x01225872
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

		// Token: 0x0603E6EB RID: 255723 RVA: 0x01227697 File Offset: 0x01225897
		[NullableContext(2)]
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E6EC RID: 255724 RVA: 0x012276B4 File Offset: 0x012258B4
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
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "进入Sequence相机，最小近裁面", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (disableMotionBlur)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
				}
			}
			EventSystem.Instance.Emit<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, settings.CameraSequence, target, this.CameraSequenceActor, CameraUtility.GetRootTransform(target), flag, settings.IsStopModify, this.CameraModelInstanceInternal.CameraName);
			return flag;
		}

		// Token: 0x0603E6ED RID: 255725 RVA: 0x0122794C File Offset: 0x01225B4C
		private void BindSkillEndEvent(bool isFinishBySkillInterrupt, int? skillEntityId, long? skillId)
		{
			this.UnBindSkillEndEvent();
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
			EventSystem.Instance.AddWithTarget<int, int>(entity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill));
		}

		// Token: 0x0603E6EE RID: 255726 RVA: 0x012279B4 File Offset: 0x01225BB4
		private void UnBindSkillEndEvent()
		{
			if (this.BindSkillEntity != null && EventSystem.Instance.HasWithTarget<int, int>(this.BindSkillEntity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill)))
			{
				EventSystem.Instance.RemoveWithTarget<int, int>(this.BindSkillEntity, EEventName.CharInterruptSkill, new Action<int, int>(this.OnCharInterruptSkill));
			}
			this.BindSkillEntity = null;
			this.BindSkillId = null;
		}

		// Token: 0x0603E6EF RID: 255727 RVA: 0x01227A1C File Offset: 0x01225C1C
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

		// Token: 0x0603E6F0 RID: 255728 RVA: 0x01227A7F File Offset: 0x01225C7F
		public void StopSequence()
		{
			this.SequenceStopInternal();
		}

		// Token: 0x0603E6F1 RID: 255729 RVA: 0x01227A87 File Offset: 0x01225C87
		public void SetBlendTime(float inBlendIn, float inBlendOut)
		{
			this.SequenceCameraBlendInTime = inBlendIn;
			this.SequenceCameraBlendOutTime = inBlendOut;
		}

		// Token: 0x0603E6F2 RID: 255730 RVA: 0x01227A97 File Offset: 0x01225C97
		[NullableContext(2)]
		public ALevelSequenceActor GetCurrentLevelSequenceActor()
		{
			return this.CameraSequenceActor;
		}

		// Token: 0x0603E6F3 RID: 255731 RVA: 0x01227A9F File Offset: 0x01225C9F
		public bool GetIsInCinematic()
		{
			return this.IsInCinematic;
		}

		// Token: 0x0603E6F4 RID: 255732 RVA: 0x01227AA7 File Offset: 0x01225CA7
		[NullableContext(2)]
		public TsBaseCharacter GetCharacter()
		{
			return this.Character;
		}

		// Token: 0x0603E6F5 RID: 255733 RVA: 0x01227AB0 File Offset: 0x01225CB0
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
			if (!string.IsNullOrEmpty(defaultFilmbackPresetName))
			{
				ucineCameraComponent2.SetFilmbackPresetByName(defaultFilmbackPresetName);
			}
			ucineCameraComponent2.bConstrainAspectRatio = false;
		}

		// Token: 0x0603E6F6 RID: 255734 RVA: 0x01227AFD File Offset: 0x01225CFD
		protected override bool OnStart()
		{
			this.InitTraceElements();
			this.DisplayComponent = base.Entity.GetComponent<SequenceCameraDisplayComponent>();
			return this.DisplayComponent.Valid;
		}

		// Token: 0x0603E6F7 RID: 255735 RVA: 0x01227B24 File Offset: 0x01225D24
		private void InitTraceElements()
		{
			this.SphereSingle = new UTraceSphereElement();
			this.SphereSingle.bIsSingle = true;
			this.SphereSingle.bIgnoreSelf = true;
			this.SphereSingle.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.SphereMultiply = new UTraceSphereElement();
			this.SphereMultiply.bIsSingle = false;
			this.SphereMultiply.bIgnoreSelf = true;
			this.SphereMultiply.ActorsToIgnore.Empty(true);
			for (int i = 0; i < this.IgnoreActors.Num(); i++)
			{
				this.SphereMultiply.ActorsToIgnore.Add(this.IgnoreActors.Get(i));
			}
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

		// Token: 0x0603E6F8 RID: 255736 RVA: 0x01227C9C File Offset: 0x01225E9C
		protected override bool OnEnd()
		{
			this.UnBindSkillEndEvent();
			this.DisplayComponent = null;
			this.BindingActors.Empty(true);
			if (this.CameraSequenceActor != null)
			{
				this.UnregisterMainLevelSequenceActor(this.CameraSequenceActor);
				ULevelSequencePlayer sequencePlayer = this.CameraSequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.OnStop.Clear();
				}
				ULevelSequencePlayer sequencePlayer2 = this.CameraSequenceActor.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.Stop();
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

		// Token: 0x0603E6F9 RID: 255737 RVA: 0x01227DF8 File Offset: 0x01225FF8
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
			this.UpdateSeparateSequencePlayers();
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

		// Token: 0x0603E6FA RID: 255738 RVA: 0x01227FC0 File Offset: 0x012261C0
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

		// Token: 0x0603E6FB RID: 255739 RVA: 0x01228027 File Offset: 0x01226227
		private TsBaseCharacter GetTargetCharacter()
		{
			return (this.Target ?? CameraController.Instance.GetCharacter()) as TsBaseCharacter;
		}

		// Token: 0x0603E6FC RID: 255740 RVA: 0x01228044 File Offset: 0x01226244
		private void UpdateSeparateSequencePlayers()
		{
			TsBaseCharacter character = this.Character;
			if (character == null || !character.IsValid())
			{
				return;
			}
			this.UpdateSeparateSequencePlayersFromMain(character, this.LockSocketName, this.IsEnableCollision);
		}

		// Token: 0x0603E6FD RID: 255741 RVA: 0x01228080 File Offset: 0x01226280
		private void UpdateSeparateSequencePlayersFromMain(TsBaseCharacter character, FName lockSocketName, bool isEnableCollision)
		{
			CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
			if (((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null) != "MainCamera")
			{
				return;
			}
			CameraModel instance = CSharpScript.Game.Camera.CameraModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ModelIterator(delegate(CameraModelInstance cameraModelInstance)
			{
				if (cameraModelInstance.CameraName == "MainCamera")
				{
					return;
				}
				SequenceCamera sequenceCamera = cameraModelInstance.SequenceCamera;
				SequenceCameraPlayerComponent sequenceCameraPlayerComponent = (sequenceCamera != null) ? sequenceCamera.PlayerComponent : null;
				if (sequenceCameraPlayerComponent == null)
				{
					return;
				}
				sequenceCameraPlayerComponent.UpdateFromMainSequence(character, lockSocketName, isEnableCollision);
			});
		}

		// Token: 0x0603E6FE RID: 255742 RVA: 0x012280E4 File Offset: 0x012262E4
		public void UpdateFromMainSequence(TsBaseCharacter character, FName lockSocketName, bool isEnableCollision)
		{
			if (this.IsSeparateSequencePlayerLogicEnabled)
			{
				CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
				if (!(((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null) == "MainCamera") && character.IsValid())
				{
					SequenceCameraDisplayComponent displayComponent = this.DisplayComponent;
					bool flag;
					if (displayComponent == null)
					{
						flag = true;
					}
					else
					{
						BP_CineCamera_C cineCamera = displayComponent.CineCamera;
						flag = !((cineCamera != null) ? new bool?(cineCamera.IsValid()) : null).GetValueOrDefault();
					}
					if (!flag)
					{
						this.Character = character;
						this.LockSocketName = lockSocketName;
						this.IsEnableCollision = isEnableCollision;
						this.ProcessSocketTransform();
						this.CheckCollision(false);
						return;
					}
				}
			}
		}

		// Token: 0x0603E6FF RID: 255743 RVA: 0x0122817A File Offset: 0x0122637A
		private void RegisterMainLevelSequenceActor(ALevelSequenceActor levelSequenceActor)
		{
			CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
			if (((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null) == "MainCamera")
			{
				SequenceCamera sequenceCamera = this.CameraModelInstanceInternal.SequenceCamera;
				if (sequenceCamera == null)
				{
					return;
				}
				sequenceCamera.RegisterLevelSequenceActor(levelSequenceActor);
			}
		}

		// Token: 0x0603E700 RID: 255744 RVA: 0x012281B0 File Offset: 0x012263B0
		private void UnregisterMainLevelSequenceActor(ALevelSequenceActor levelSequenceActor)
		{
			CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
			if (((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null) == "MainCamera")
			{
				SequenceCamera sequenceCamera = this.CameraModelInstanceInternal.SequenceCamera;
				if (sequenceCamera == null)
				{
					return;
				}
				sequenceCamera.UnregisterLevelSequenceActor(levelSequenceActor);
			}
		}

		// Token: 0x0603E701 RID: 255745 RVA: 0x012281E8 File Offset: 0x012263E8
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
			this.RegisterMainLevelSequenceActor(this.CameraSequenceActor);
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

		// Token: 0x0603E702 RID: 255746 RVA: 0x0122840C File Offset: 0x0122660C
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

		// Token: 0x0603E703 RID: 255747 RVA: 0x012284F0 File Offset: 0x012266F0
		private void BindActors()
		{
			if (this.CameraSequenceActor == null)
			{
				return;
			}
			this.BindingActors.Empty(true);
			this.BindingActors.Add(this.DisplayComponent.CineCamera);
			this.CameraSequenceActor.SetBindingByTag(SequenceCameraPlayerComponent.SequenceCamera, this.BindingActors, false, false);
			this.BindingActors.Empty(true);
			if (this.Character != null)
			{
				this.BindingCharacterActors.Empty(true);
				this.BindingCharacterActors.Add(this.Character);
				this.CameraSequenceActor.SetBindingByTag(SequenceCameraPlayerComponent.RoleTag, this.BindingCharacterActors, false, false);
				this.BindingCharacterActors.Empty(true);
			}
		}

		// Token: 0x0603E704 RID: 255748 RVA: 0x01228598 File Offset: 0x01226798
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

		// Token: 0x0603E705 RID: 255749 RVA: 0x012285DC File Offset: 0x012267DC
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

		// Token: 0x0603E706 RID: 255750 RVA: 0x01228734 File Offset: 0x01226934
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

		// Token: 0x0603E707 RID: 255751 RVA: 0x01228898 File Offset: 0x01226A98
		private void SequenceStopInternal()
		{
			this.UnBindSkillEndEvent();
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
				this.UnregisterMainLevelSequenceActor(this.CameraSequenceActor);
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

		// Token: 0x0603E708 RID: 255752 RVA: 0x01228C6C File Offset: 0x01226E6C
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

		// Token: 0x0603E709 RID: 255753 RVA: 0x01228CD4 File Offset: 0x01226ED4
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

		// Token: 0x0603E70A RID: 255754 RVA: 0x01228E38 File Offset: 0x01227038
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
				this.FrameAbstractRelativeCameraTransform = new FTransformDouble?(SequenceUtils.GetLevelSequenceTransform(this.CameraSequence, this.CameraTransformTrack, time).Inverse());
			}
			if (this.FrameAbstractRelativeCameraTransform == null)
			{
				return;
			}
			CharacterAnimationComponent component = this.Character.GetEntityNoBlueprint().GetComponent<CharacterAnimationComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			FTransformDouble value = this.FrameAbstractRelativeCameraTransform.Value;
			FTransformDouble ftransformDouble = this.DisplayComponent.CineCamera.D_GetTransform();
			FTransformDouble ftransformDouble2 = value * ftransformDouble;
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

		// Token: 0x0603E70B RID: 255755 RVA: 0x01228F40 File Offset: 0x01227140
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

		// Token: 0x0603E70C RID: 255756 RVA: 0x012290C8 File Offset: 0x012272C8
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

		// Token: 0x0603E70D RID: 255757 RVA: 0x01229144 File Offset: 0x01227344
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

		// Token: 0x0603E70E RID: 255758 RVA: 0x012291E8 File Offset: 0x012273E8
		private FTransformDouble ConstructTransform(FTransformDouble transform)
		{
			FQuat rotation = transform.GetRotation();
			FVectorDouble translation = transform.GetTranslation();
			FVector scale3D = transform.GetScale3D();
			return new FTransformDouble(ref rotation, ref translation, ref scale3D);
		}

		// Token: 0x0603E70F RID: 255759 RVA: 0x01229218 File Offset: 0x01227418
		protected override void OnChangeTimeDilation(float timeDilation)
		{
		}

		// Token: 0x0603E710 RID: 255760 RVA: 0x0122921C File Offset: 0x0122741C
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

		// Token: 0x0603E711 RID: 255761 RVA: 0x01229288 File Offset: 0x01227488
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
			this.CameraSphereTrace.ActorsToIgnore.Empty(true);
			for (int i = 0; i < this.IgnoreActors.Num(); i++)
			{
				this.CameraSphereTrace.ActorsToIgnore.Add(this.IgnoreActors.Get(i));
			}
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

		// Token: 0x0603E712 RID: 255762 RVA: 0x01229424 File Offset: 0x01227624
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
			this.CameraCheckSphereTrace.ActorsToIgnore.Empty(true);
			for (int i = 0; i < this.IgnoreActors.Num(); i++)
			{
				this.CameraCheckSphereTrace.ActorsToIgnore.Add(this.IgnoreActors.Get(i));
			}
			TraceElementCommon.Instance.SetStartLocation(this.CameraCheckSphereTrace, this.SourceLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraCheckSphereTrace, this.SourceLocation);
			this.CameraCheckSphereTrace.Radius = this.CheckRadius;
			return TraceElementCommon.Instance.SphereTrace(this.CameraCheckSphereTrace, "SequenceCameraPlayerComponent_ProcessHideShelterCharacter");
		}

		// Token: 0x0603E713 RID: 255763 RVA: 0x0122960E File Offset: 0x0122780E
		public FTransformDouble? GetBoneTransform(FName boneName)
		{
			return new FTransformDouble?(this.Character.Mesh.D_GetSocketTransform(boneName, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x0603E714 RID: 255764 RVA: 0x01229627 File Offset: 0x01227827
		public void SetDitherEffectEnable(ESequenceCameraDitherEffectEnum ditherEffectEnum)
		{
			this.DitherEffectEnableSet.Add(ditherEffectEnum);
		}

		// Token: 0x0603E715 RID: 255765 RVA: 0x01229636 File Offset: 0x01227836
		public void SetDitherEffectDisable(ESequenceCameraDitherEffectEnum ditherEffectEnum)
		{
			this.DitherEffectEnableSet.Remove(ditherEffectEnum);
		}

		// Token: 0x0603E716 RID: 255766 RVA: 0x01229645 File Offset: 0x01227845
		public void SetCameraCollisionState(bool isEnableCollision)
		{
			this.IsEnableCollision = isEnableCollision;
		}

		// Token: 0x0603E717 RID: 255767 RVA: 0x01229650 File Offset: 0x01227850
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

		// Token: 0x0603E718 RID: 255768 RVA: 0x012297B0 File Offset: 0x012279B0
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

		// Token: 0x0603E719 RID: 255769 RVA: 0x01229883 File Offset: 0x01227A83
		public bool GetIfNeedWaitInPlot()
		{
			return this.NeedWaitInPlot;
		}

		// Token: 0x0603E71A RID: 255770 RVA: 0x0122988B File Offset: 0x01227A8B
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0603E71B RID: 255771 RVA: 0x01229898 File Offset: 0x01227A98
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SequenceCameraPlayerComponent sequenceCameraPlayerComponent = (SequenceCameraPlayerComponent)componentTemplate;
			if (sequenceCameraPlayerComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.IgnoreActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.IgnoreActors), "IgnoreActors"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraSequence == null)
			{
				this.CameraSequence = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSequence), "CameraSequence"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraSequenceActor == null)
			{
				this.CameraSequenceActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSequenceActor), "CameraSequenceActor"))
			{
				return false;
			}
			this.PlayedTime = sequenceCameraPlayerComponent.PlayedTime;
			this.TimeLength = sequenceCameraPlayerComponent.TimeLength;
			this.PlaySpeed = sequenceCameraPlayerComponent.PlaySpeed;
			this.SequenceCameraBlendInTime = sequenceCameraPlayerComponent.SequenceCameraBlendInTime;
			this.SequenceCameraBlendOutTime = sequenceCameraPlayerComponent.SequenceCameraBlendOutTime;
			this.BlendingOutRestTime = sequenceCameraPlayerComponent.BlendingOutRestTime;
			if (sequenceCameraPlayerComponent.LevelSequenceData == null)
			{
				this.LevelSequenceData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LevelSequenceData), "LevelSequenceData"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.AnimInstance == null)
			{
				this.AnimInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimInstance), "AnimInstance"))
			{
				return false;
			}
			this.OriginRootTransform = sequenceCameraPlayerComponent.OriginRootTransform;
			this.OriginMeshRelativeTransform = sequenceCameraPlayerComponent.OriginMeshRelativeTransform;
			if (sequenceCameraPlayerComponent.CharacterMoveComponent == null)
			{
				this.CharacterMoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterMoveComponent), "CharacterMoveComponent"))
			{
				return false;
			}
			this.IsInCinematic = sequenceCameraPlayerComponent.IsInCinematic;
			this.IsHideHud = sequenceCameraPlayerComponent.IsHideHud;
			this.HideHudTime = sequenceCameraPlayerComponent.HideHudTime;
			if (sequenceCameraPlayerComponent.BindingActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingActors), "BindingActors"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.BindingCharacterActors != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BindingCharacterActors), "BindingCharacterActors"))
			{
				return false;
			}
			this.ResetAdditiveRotation = sequenceCameraPlayerComponent.ResetAdditiveRotation;
			this.ResetFightCameraOnStop = sequenceCameraPlayerComponent.ResetFightCameraOnStop;
			this.RecoverRotation = sequenceCameraPlayerComponent.RecoverRotation;
			this.IsRecoverRotation = sequenceCameraPlayerComponent.IsRecoverRotation;
			if (sequenceCameraPlayerComponent.Target == null)
			{
				this.Target = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Target), "Target"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.Character == null)
			{
				this.Character = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Character), "Character"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.OldCharacter == null)
			{
				this.OldCharacter = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OldCharacter), "OldCharacter"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.SphereSingle == null)
			{
				this.SphereSingle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SphereSingle), "SphereSingle"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.SphereMultiply == null)
			{
				this.SphereMultiply = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SphereMultiply), "SphereMultiply"))
			{
				return false;
			}
			this.SocketName = sequenceCameraPlayerComponent.SocketName;
			this.LockSocketName = sequenceCameraPlayerComponent.LockSocketName;
			if (sequenceCameraPlayerComponent.TransformOriginActor == null)
			{
				this.TransformOriginActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TransformOriginActor), "TransformOriginActor"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.RelativeLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RelativeLocation), "RelativeLocation"))
			{
				return false;
			}
			this.ShowLog = sequenceCameraPlayerComponent.ShowLog;
			this.CheckRadius = sequenceCameraPlayerComponent.CheckRadius;
			this.IsEnableCollision = sequenceCameraPlayerComponent.IsEnableCollision;
			this.IsSeparateSequencePlayerLogicEnabled = sequenceCameraPlayerComponent.IsSeparateSequencePlayerLogicEnabled;
			this.NeedWaitInPlot = sequenceCameraPlayerComponent.NeedWaitInPlot;
			this.IsPlayCameraSequenceEnabled = sequenceCameraPlayerComponent.IsPlayCameraSequenceEnabled;
			this.IsEnableFrameAbstract = sequenceCameraPlayerComponent.IsEnableFrameAbstract;
			this.FrameAbstractDelta = sequenceCameraPlayerComponent.FrameAbstractDelta;
			this.FrameAbstractTime = sequenceCameraPlayerComponent.FrameAbstractTime;
			if (sequenceCameraPlayerComponent.CameraTransformTrack == null)
			{
				this.CameraTransformTrack = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraTransformTrack), "CameraTransformTrack"))
			{
				return false;
			}
			this.FrameAbstractRelativeCameraTransform = sequenceCameraPlayerComponent.FrameAbstractRelativeCameraTransform;
			this.IsAttachToActor = sequenceCameraPlayerComponent.IsAttachToActor;
			if (sequenceCameraPlayerComponent.DitherEffectEnableSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<ESequenceCameraDitherEffectEnum>(this.DitherEffectEnableSet), "DitherEffectEnableSet"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.BindSkillEntity == null)
			{
				this.BindSkillEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BindSkillEntity), "BindSkillEntity"))
			{
				return false;
			}
			this.BindSkillId = sequenceCameraPlayerComponent.BindSkillId;
			if (sequenceCameraPlayerComponent.MeshRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MeshRotator), "MeshRotator"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			this.TmpTransformDouble = sequenceCameraPlayerComponent.TmpTransformDouble;
			if (sequenceCameraPlayerComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat), "TmpQuat"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraSphereTrace == null)
			{
				this.CameraSphereTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraSphereTrace), "CameraSphereTrace"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraCheckSphereTrace == null)
			{
				this.CameraCheckSphereTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraCheckSphereTrace), "CameraCheckSphereTrace"))
			{
				return false;
			}
			this.IsHit = sequenceCameraPlayerComponent.IsHit;
			if (sequenceCameraPlayerComponent.HitLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitLocation), "HitLocation"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraLocation), "CameraLocation"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraRotation), "CameraRotation"))
			{
				return false;
			}
			if (sequenceCameraPlayerComponent.CameraRotationInGravity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraRotationInGravity), "CameraRotationInGravity"))
			{
				return false;
			}
			this.SocketTransform = sequenceCameraPlayerComponent.SocketTransform;
			return (sequenceCameraPlayerComponent.SourceLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SourceLocation), "SourceLocation")) && (sequenceCameraPlayerComponent.SourceForward == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SourceForward), "SourceForward")) && (sequenceCameraPlayerComponent.HorizontalVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.HorizontalVector), "HorizontalVector")) && (sequenceCameraPlayerComponent.Up == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Up), "Up"));
		}

		// Token: 0x170076D8 RID: 30424
		// (get) Token: 0x0603E71C RID: 255772 RVA: 0x01229F55 File Offset: 0x01228155
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076D9 RID: 30425
		// (get) Token: 0x0603E71D RID: 255773 RVA: 0x01229F58 File Offset: 0x01228158
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076DA RID: 30426
		// (get) Token: 0x0603E71E RID: 255774 RVA: 0x01229F5B File Offset: 0x0122815B
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076DB RID: 30427
		// (get) Token: 0x0603E71F RID: 255775 RVA: 0x01229F5E File Offset: 0x0122815E
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076DC RID: 30428
		// (get) Token: 0x0603E720 RID: 255776 RVA: 0x01229F61 File Offset: 0x01228161
		public override bool NeedAfterTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076DD RID: 30429
		// (get) Token: 0x0603E721 RID: 255777 RVA: 0x01229F64 File Offset: 0x01228164
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04021454 RID: 136276
		private const string PROFILE_KEY1 = "SequenceCameraPlayerComponent_CheckCameraLocation";

		// Token: 0x04021455 RID: 136277
		private const string PROFILE_KEY2 = "SequenceCameraPlayerComponent_ProcessHideShelterCharacter";

		// Token: 0x04021456 RID: 136278
		private const double RELATIVE_LENGTH = 10000.0;

		// Token: 0x04021457 RID: 136279
		private const float MINI_FRAME_ABSTRACT_DELTA = 0.05f;

		// Token: 0x04021458 RID: 136280
		[StaticVariableRuleIgnore]
		private static readonly Stat SequenceTransformStat = Stat.Create("SequenceTransformStat", "", "");

		// Token: 0x04021459 RID: 136281
		private static readonly FName SequenceCamera = new FName("SequenceCamera");

		// Token: 0x0402145A RID: 136282
		private static readonly FName RoleTag = new FName("Role");

		// Token: 0x0402145B RID: 136283
		[Nullable(2)]
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x0402145C RID: 136284
		[Nullable(2)]
		private SequenceCameraDisplayComponent DisplayComponent;

		// Token: 0x0402145D RID: 136285
		private readonly TArray<AActor> IgnoreActors = new TArray<AActor>();

		// Token: 0x0402145E RID: 136286
		[Nullable(2)]
		private ULevelSequence CameraSequence;

		// Token: 0x0402145F RID: 136287
		[Nullable(2)]
		private ALevelSequenceActor CameraSequenceActor;

		// Token: 0x04021460 RID: 136288
		private float PlayedTime;

		// Token: 0x04021461 RID: 136289
		private float TimeLength;

		// Token: 0x04021462 RID: 136290
		private float PlaySpeed = 1f;

		// Token: 0x04021463 RID: 136291
		private float SequenceCameraBlendInTime = 1f;

		// Token: 0x04021464 RID: 136292
		private float SequenceCameraBlendOutTime = 1f;

		// Token: 0x04021465 RID: 136293
		private float BlendingOutRestTime;

		// Token: 0x04021466 RID: 136294
		[Nullable(2)]
		private UDefaultLevelSequenceInstanceData LevelSequenceData;

		// Token: 0x04021467 RID: 136295
		[Nullable(2)]
		private UKuroAnimInstanceRole AnimInstance;

		// Token: 0x04021468 RID: 136296
		private FTransformDouble? OriginRootTransform;

		// Token: 0x04021469 RID: 136297
		private FTransformDouble? OriginMeshRelativeTransform;

		// Token: 0x0402146A RID: 136298
		[Nullable(2)]
		private BaseMoveComponent CharacterMoveComponent;

		// Token: 0x0402146B RID: 136299
		private bool IsInCinematic;

		// Token: 0x0402146C RID: 136300
		private bool IsHideHud;

		// Token: 0x0402146D RID: 136301
		private float HideHudTime;

		// Token: 0x0402146E RID: 136302
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x0402146F RID: 136303
		private readonly TArray<AActor> BindingCharacterActors = new TArray<AActor>();

		// Token: 0x04021470 RID: 136304
		private FRotator? ResetAdditiveRotation;

		// Token: 0x04021471 RID: 136305
		private bool ResetFightCameraOnStop;

		// Token: 0x04021472 RID: 136306
		private FRotator? RecoverRotation;

		// Token: 0x04021473 RID: 136307
		private bool IsRecoverRotation;

		// Token: 0x04021474 RID: 136308
		[Nullable(2)]
		private TsBaseCharacter Target;

		// Token: 0x04021475 RID: 136309
		[Nullable(2)]
		private TsBaseCharacter Character;

		// Token: 0x04021476 RID: 136310
		[Nullable(2)]
		private TsBaseCharacter OldCharacter;

		// Token: 0x04021477 RID: 136311
		[Nullable(2)]
		private UTraceSphereElement SphereSingle;

		// Token: 0x04021478 RID: 136312
		[Nullable(2)]
		private UTraceSphereElement SphereMultiply;

		// Token: 0x04021479 RID: 136313
		private FName SocketName = FNameUtil.EMPTY;

		// Token: 0x0402147A RID: 136314
		private FName LockSocketName = FNameUtil.EMPTY;

		// Token: 0x0402147B RID: 136315
		[Nullable(2)]
		private AActor TransformOriginActor;

		// Token: 0x0402147C RID: 136316
		private readonly Vector RelativeLocation = Vector.Create(10000.0, 10000.0, 10000.0);

		// Token: 0x0402147D RID: 136317
		private bool ShowLog;

		// Token: 0x0402147E RID: 136318
		private float CheckRadius;

		// Token: 0x0402147F RID: 136319
		private bool IsEnableCollision = true;

		// Token: 0x04021480 RID: 136320
		private bool IsSeparateSequencePlayerLogicEnabled;

		// Token: 0x04021481 RID: 136321
		private bool NeedWaitInPlot;

		// Token: 0x04021482 RID: 136322
		private bool IsPlayCameraSequenceEnabled = true;

		// Token: 0x04021483 RID: 136323
		private bool IsEnableFrameAbstract;

		// Token: 0x04021484 RID: 136324
		private float FrameAbstractDelta;

		// Token: 0x04021485 RID: 136325
		private int FrameAbstractTime;

		// Token: 0x04021486 RID: 136326
		[Nullable(2)]
		private UMovieSceneTrack CameraTransformTrack;

		// Token: 0x04021487 RID: 136327
		private FTransformDouble? FrameAbstractRelativeCameraTransform;

		// Token: 0x04021488 RID: 136328
		private readonly bool DebugFrameAbstract;

		// Token: 0x04021489 RID: 136329
		private bool IsAttachToActor;

		// Token: 0x0402148A RID: 136330
		private readonly HashSet<ESequenceCameraDitherEffectEnum> DitherEffectEnableSet = new HashSet<ESequenceCameraDitherEffectEnum>();

		// Token: 0x0402148B RID: 136331
		[Nullable(2)]
		private Entity BindSkillEntity;

		// Token: 0x0402148C RID: 136332
		private long? BindSkillId;

		// Token: 0x0402148D RID: 136333
		private readonly Rotator MeshRotator = Rotator.Create(0f, -90f, 0f);

		// Token: 0x0402148E RID: 136334
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x0402148F RID: 136335
		private FTransformDouble TmpTransformDouble = new FTransformDouble();

		// Token: 0x04021490 RID: 136336
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x04021491 RID: 136337
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021492 RID: 136338
		[Nullable(2)]
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x04021493 RID: 136339
		[Nullable(2)]
		private UTraceSphereElement CameraCheckSphereTrace;

		// Token: 0x04021494 RID: 136340
		private bool IsHit;

		// Token: 0x04021495 RID: 136341
		private readonly Vector HitLocation = Vector.Create();

		// Token: 0x04021496 RID: 136342
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x04021497 RID: 136343
		private readonly Rotator CameraRotation = Rotator.Create();

		// Token: 0x04021498 RID: 136344
		private readonly Rotator CameraRotationInGravity = Rotator.Create();

		// Token: 0x04021499 RID: 136345
		private FTransformDouble? SocketTransform;

		// Token: 0x0402149A RID: 136346
		private readonly Vector SourceLocation = Vector.Create();

		// Token: 0x0402149B RID: 136347
		private readonly Vector SourceForward = Vector.Create();

		// Token: 0x0402149C RID: 136348
		private readonly Vector HorizontalVector = Vector.Create();

		// Token: 0x0402149D RID: 136349
		private readonly Vector Up = Vector.Create();
	}
}
