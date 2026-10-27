using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.TimeTrackControl;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02006A0F RID: 27151
	[NullableContext(2)]
	[Nullable(0)]
	public class SimpleLevelSequenceActor
	{
		// Token: 0x060438A1 RID: 276641 RVA: 0x01084468 File Offset: 0x01082668
		[NullableContext(1)]
		public SimpleLevelSequenceActor(ULevelSequence levelSequence)
		{
			FRotator frotator = new FRotator(0f, 0f, 0f);
			FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			this.TempTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			base..ctor();
			this.LevelSequence = levelSequence;
			if (levelSequence.HasBindingTag(SimpleLevelSequenceActorConstants.CAMERA_TAG, true))
			{
				this.HasCameraTrack = true;
			}
			else
			{
				this.HasCameraTrack = false;
			}
			this.GenerateDirector();
		}

		// Token: 0x060438A2 RID: 276642 RVA: 0x010845EB File Offset: 0x010827EB
		public void AddOnPauseCallback(Action callback)
		{
			this.OnPauseCallback = callback;
		}

		// Token: 0x060438A3 RID: 276643 RVA: 0x010845F4 File Offset: 0x010827F4
		public void ClearOnPausedCallback()
		{
			this.OnPauseCallback = null;
		}

		// Token: 0x060438A4 RID: 276644 RVA: 0x010845FD File Offset: 0x010827FD
		public void AddOnStopCallback(Action<bool> callback)
		{
			this.OnStopCallback = callback;
		}

		// Token: 0x060438A5 RID: 276645 RVA: 0x01084606 File Offset: 0x01082806
		public void ClearOnStopCallback()
		{
			this.OnStopCallback = null;
		}

		// Token: 0x060438A6 RID: 276646 RVA: 0x0108460F File Offset: 0x0108280F
		public void AddOnFinishedCallback(Action callback)
		{
			this.OnFinishedCallback = callback;
		}

		// Token: 0x060438A7 RID: 276647 RVA: 0x01084618 File Offset: 0x01082818
		public void ClearOnFinishedCallback()
		{
			this.OnFinishedCallback = null;
		}

		// Token: 0x060438A8 RID: 276648 RVA: 0x01084621 File Offset: 0x01082821
		public void UpdateSettings(bool? inSettings)
		{
			this.IsKeepUi = inSettings.GetValueOrDefault();
		}

		// Token: 0x060438A9 RID: 276649 RVA: 0x01084630 File Offset: 0x01082830
		public void SetCanPlayInLoading(bool canPlay)
		{
			this.CanPlayInLoading = canPlay;
		}

		// Token: 0x060438AA RID: 276650 RVA: 0x01084639 File Offset: 0x01082839
		public UMovieSceneSequencePlayer GetPlayer()
		{
			ALevelSequenceActor director = this.Director;
			if (director == null)
			{
				return null;
			}
			return director.SequencePlayer;
		}

		// Token: 0x060438AB RID: 276651 RVA: 0x0108464C File Offset: 0x0108284C
		public ALevelSequenceActor GetSequenceActor()
		{
			return this.Director;
		}

		// Token: 0x060438AC RID: 276652 RVA: 0x01084654 File Offset: 0x01082854
		public bool IsDirectorValid()
		{
			ALevelSequenceActor director = this.Director;
			return director != null && director.IsValid();
		}

		// Token: 0x060438AD RID: 276653 RVA: 0x01084667 File Offset: 0x01082867
		public void SetTransformOriginActor(AActor actor)
		{
			if (this.Director == null)
			{
				return;
			}
			this.Director.bOverrideInstanceData = true;
			if (this.CameraSequenceData != null)
			{
				this.CameraSequenceData.TransformOriginActor = actor;
			}
		}

		// Token: 0x060438AE RID: 276654 RVA: 0x01084692 File Offset: 0x01082892
		public bool IsPlaying()
		{
			if (this.IsPause)
			{
				return false;
			}
			if (this.ItsWay == EWayType.Default)
			{
				return true;
			}
			UMovieSceneSequencePlayer player = this.GetPlayer();
			return player != null && player.IsPlaying();
		}

		// Token: 0x060438AF RID: 276655 RVA: 0x010846BC File Offset: 0x010828BC
		public bool ForceSwitchSceneCamera(bool isEnter)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:失败，!this.Director?.IsValid()", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!this.HasCameraTrack)
			{
				global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:失败，!this.HasCameraTrack", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.UiSequence = true;
			if (isEnter)
			{
				this.IsForcedSceneCamera = true;
				this.EnterSceneCamera(delegate
				{
					UiManager.Instance.OpenView(EUiViewName.TimeTrackControlView, null, delegate(bool result, int _)
					{
						if (!result)
						{
							global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:失败，OpenView(EUiViewName.TimeTrackControlView", default(ReadOnlySpan<ValueTuple<string, object>>));
							TsInteractionUtils.ClearCurrentOpenViewName();
							TimeTrackController.Instance.HandleTimeTrackControlViewClose();
							TimeTrackController.Instance.FinishCallback(false);
							return;
						}
						if (!CameraController.Instance.MainModel.IsToSceneCameraMode())
						{
							global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:失败，IsToSceneCameraMode", default(ReadOnlySpan<ValueTuple<string, object>>));
							TsInteractionUtils.ClearCurrentOpenViewName();
							TimeTrackController.Instance.HandleTimeTrackControlViewClose();
							UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TimeTrackControlView);
							if (viewByName != null)
							{
								viewByName.CloseMe(null);
							}
							TimeTrackController.Instance.FinishCallback(false);
						}
					});
				});
			}
			else
			{
				this.IsForcedSceneCamera = false;
				this.ExitSceneCamera();
			}
			return true;
		}

		// Token: 0x060438B0 RID: 276656 RVA: 0x0108476C File Offset: 0x0108296C
		public void SetOriginTransform()
		{
			if (this.Director == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = new FVectorDouble();
			ULevelSequence sequence = this.Director.GetSequence();
			if (sequence == null || !sequence.D_GetCenterOffset(ref fvectorDouble))
			{
				fvectorDouble.Set(0.0, 0.0, 0.0);
			}
			this.Director.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.Director.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			if (udefaultLevelSequenceInstanceData != null)
			{
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData2 = udefaultLevelSequenceInstanceData;
				FVector fvector = new FVector((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z);
				udefaultLevelSequenceInstanceData2.TransformOrigin = new FTransform(ref fvector);
			}
		}

		// Token: 0x060438B1 RID: 276657 RVA: 0x01084810 File Offset: 0x01082A10
		[NullableContext(1)]
		public void PlaySequence(DefaultLevelSequencePlayParam playParam)
		{
			ALevelSequenceActor director = this.Director;
			FQualifiedFrameTime fqualifiedFrameTime;
			if (director == null)
			{
				fqualifiedFrameTime = null;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer = director.SequencePlayer;
				fqualifiedFrameTime = ((sequencePlayer != null) ? sequencePlayer.GetEndTime() : null);
			}
			FQualifiedFrameTime fqualifiedFrameTime2 = fqualifiedFrameTime;
			this.FadeInInTime = playParam.InTime;
			this.FadeInOutTime = playParam.OutTime;
			this.Character = playParam.Target;
			this.DefaultPlayParam = playParam;
			this.DefaultPlayParam.DelayUpdateFrame = 0;
			this.DefaultPlayParam.PlayedTime = 0f;
			this.DefaultPlayParam.TimeLength = ((fqualifiedFrameTime2 == null) ? 0f : (((float)fqualifiedFrameTime2.Time.FrameNumber.Value + fqualifiedFrameTime2.Time.SubFrame) * (float)fqualifiedFrameTime2.Rate.Denominator / (float)fqualifiedFrameTime2.Rate.Numerator));
			this.ItsWay = EWayType.Default;
			this.IsKeepUi = true;
			this.ForceTickOneFrameEventPause = true;
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438B2 RID: 276658 RVA: 0x010848F0 File Offset: 0x01082AF0
		[NullableContext(1)]
		public void PlayToMarkOld(string mark, float inTime, float outTime, bool jumpToEnd)
		{
			if (!this.CheckMarkValid(mark))
			{
				return;
			}
			this.Mark = mark;
			this.FadeInInTime = inTime;
			this.FadeOutOutTime = outTime;
			this.JumpToEnd = jumpToEnd;
			this.ItsWay = EWayType.Normal;
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438B3 RID: 276659 RVA: 0x01084928 File Offset: 0x01082B28
		[NullableContext(1)]
		public void PlayToMark(string mark, [Nullable(2)] RefCompDefine.TransitStruct tempInTransit, [Nullable(2)] RefCompDefine.TransitStruct tempOutTransit, RefCompDefine.PlayRateStruct playRateTransition, bool jumpToEnd)
		{
			if (!this.CheckMarkValid(mark))
			{
				return;
			}
			this.Mark = mark;
			if (tempInTransit != null)
			{
				this.TransitInType = tempInTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitInType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
						this.FadeInInTime = tempInTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeInOutTime = tempInTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
						this.InMask = tempInTransit.Mask;
					}
				}
				else
				{
					this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInOutTime = 0f;
					this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
				}
			}
			if (tempOutTransit != null)
			{
				this.TransitOutType = tempOutTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitOutType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
						this.FadeOutInTime = tempOutTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeOutOutTime = tempOutTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
						this.OutMask = tempOutTransit.Mask;
					}
				}
				else
				{
					this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.FadeOutInTime = 0f;
					this.FadeOutOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
				}
			}
			this.JumpToEnd = jumpToEnd;
			this.PlayRateTransition = playRateTransition;
			this.ItsWay = EWayType.Normal;
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438B4 RID: 276660 RVA: 0x01084AD0 File Offset: 0x01082CD0
		[NullableContext(1)]
		public void PlayLoopBetweenMarks(ILoopRange loopRange, bool bReverse, [Nullable(2)] RefCompDefine.TransitStruct tempInTransit, [Nullable(2)] RefCompDefine.TransitStruct tempOutTransit, RefCompDefine.PlayRateStruct playRateTransition, bool jumpToEnd)
		{
			this.LoopStartMark = (bReverse ? loopRange.RightMark : loopRange.LeftMark);
			this.Mark = (bReverse ? loopRange.LeftMark : loopRange.RightMark);
			if (tempInTransit != null)
			{
				this.TransitInType = tempInTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitInType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
						this.FadeInInTime = tempInTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeInOutTime = tempInTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
						this.InMask = tempInTransit.Mask;
					}
				}
				else
				{
					this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInOutTime = 0f;
					this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
				}
			}
			if (tempOutTransit != null)
			{
				this.TransitOutType = tempOutTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitOutType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
						this.FadeOutInTime = tempOutTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeOutOutTime = tempOutTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
						this.OutMask = tempOutTransit.Mask;
					}
				}
				else
				{
					this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.FadeOutInTime = 0f;
					this.FadeOutOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
				}
			}
			this.PlayRateTransition = playRateTransition;
			this.JumpToEnd = jumpToEnd;
			this.ItsWay = EWayType.LoopBetweenMarks;
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438B5 RID: 276661 RVA: 0x01084C9C File Offset: 0x01082E9C
		public void PlayLoop(bool bReverse, int numLoops, RefCompDefine.TransitStruct tempInTransit, RefCompDefine.TransitStruct tempOutTransit, [Nullable(1)] RefCompDefine.PlayRateStruct playRateTransition)
		{
			this.Mark = "";
			if (tempInTransit != null)
			{
				this.TransitInType = tempInTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitInType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
						this.FadeInInTime = tempInTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeInOutTime = tempInTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
						this.InMask = tempInTransit.Mask;
					}
				}
				else
				{
					this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInOutTime = 0f;
					this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
				}
			}
			if (tempOutTransit != null)
			{
				this.TransitOutType = tempOutTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitOutType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
						this.FadeOutInTime = tempOutTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeOutOutTime = tempOutTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
						this.OutMask = tempOutTransit.Mask;
					}
				}
				else
				{
					this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.FadeOutInTime = 0f;
					this.FadeOutOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
				}
			}
			this.PlayRateTransition = playRateTransition;
			this.ReversedLoop = bReverse;
			this.NumLoops = numLoops;
			this.ItsWay = EWayType.Loop;
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438B6 RID: 276662 RVA: 0x01084E4C File Offset: 0x0108304C
		private void CheckIsLoadingClosed()
		{
			if (!this.CanPlayInLoading && !GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				if (!EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.DoPlay)))
				{
					EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.DoPlay));
					return;
				}
			}
			else
			{
				this.DoPlay();
			}
		}

		// Token: 0x060438B7 RID: 276663 RVA: 0x01084EB0 File Offset: 0x010830B0
		private void DoPlay()
		{
			SequenceCameraPlayerComponent component = CameraController.Instance.MainModel.SequenceCamera.GetComponent<SequenceCameraPlayerComponent>();
			if (component != null && component.GetIsInCinematic())
			{
				this.PlayLevelSequence();
				return;
			}
			if (this.UiSequence)
			{
				this.PlayLevelSequence();
				return;
			}
			if (this.JumpToEnd || !this.HasCameraTrack)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelSequencePlayer;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "DoPlayToMark为JumpToEnd或者没有camera轨道";
				string item = "CameraMode";
				CameraModel instance2 = CameraModel.Instance;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (instance2 != null) ? instance2.MainModel.CameraMode : null);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.PlayLevelSequence();
				return;
			}
			if (!this.CameraBindFinished)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelSequencePlayer;
				ELogAuthor author2 = ELogAuthor.JYS;
				string message2 = "DoPlayToMark首次绑定";
				string item2 = "CameraMode";
				CameraModel instance4 = CameraModel.Instance;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (instance4 != null) ? instance4.MainModel.CameraMode : null);
				instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				if (this.TransitInType == ELevelSequenceTransition.Mask)
				{
					this.GenerateBlackScreen(this.InMask, this.DurationInTime, this.FadeInInTime, this.FadeInOutTime, delegate
					{
						this.EnterSceneCamera(null);
					}, new Action(this.PlayLevelSequence));
					return;
				}
				this.EnterSceneCamera(new Action(this.PlayLevelSequence));
				return;
			}
			else
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module3 = ELogModule.LevelSequencePlayer;
				ELogAuthor author3 = ELogAuthor.JYS;
				string message3 = "DoPlayToMark非首次绑定";
				string item3 = "CameraMode";
				CameraModel instance6 = CameraModel.Instance;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (instance6 != null) ? instance6.MainModel.CameraMode : null);
				instance5.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				if (this.TransitInType == ELevelSequenceTransition.Mask)
				{
					this.GenerateBlackScreen(this.InMask, this.DurationInTime, this.FadeInInTime, this.FadeInOutTime, delegate
					{
						this.EnterSceneCamera(null);
					}, new Action(this.PlayLevelSequence));
					return;
				}
				this.EnterSceneCamera(new Action(this.PlayLevelSequence));
				return;
			}
		}

		// Token: 0x060438B8 RID: 276664 RVA: 0x01085098 File Offset: 0x01083298
		public void PlayLevelSequence()
		{
			switch (this.ItsWay)
			{
			case EWayType.Default:
				this.PlayDefaultLevelSequence();
				return;
			case EWayType.Normal:
			case EWayType.GotoEndAndTransport:
				this.PlayLevelsequenceToMark(this.Mark, this.JumpToEnd);
				return;
			case EWayType.Loop:
				this.PlayLevelsequenceLooping(this.ReversedLoop, this.NumLoops);
				return;
			case EWayType.LoopBetweenMarks:
				this.PlayLevelsequenceLoopingBetweenMark(this.JumpToEnd);
				return;
			default:
				return;
			}
		}

		// Token: 0x060438B9 RID: 276665 RVA: 0x01085100 File Offset: 0x01083300
		private void PlayDefaultLevelSequence()
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				return;
			}
			this.Director.bOverrideInstanceData = true;
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsValid())
			{
				TsBaseCharacter character = this.Character;
				if (character != null && character.IsValid())
				{
					if (this.DefaultPlayParam == null)
					{
						return;
					}
					if (this.TransformOriginActor == null)
					{
						this.TransformOriginActor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
						AActor transformOriginActor = this.TransformOriginActor;
						TSubclassOf<UActorComponent> @class = USceneComponent.StaticClass();
						bool bManualAttachment = false;
						FTransformDouble ftransformDouble = this.TransformOriginActor.D_GetTransform();
						transformOriginActor.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, default(FName));
					}
					Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.DefaultLevelSequenceAfterTick), "SimpleLevelSequenceActor", ETickingGroup.TG_PostPhysics, false, 0, false);
					this.DefaultPlayAfterTickId = ticker.Id;
					this.DefaultPlayParam.InitPlayerRotator.DeepCopy(this.Character.CharacterActorComponent.ActorRotationProxy);
					this.DefaultPlayParam.InitPlayerFloorLocation.DeepCopy(this.Character.CharacterActorComponent.FloorLocation);
					sequencePlayer.Play();
					sequencePlayer.SetPlayRate(0f);
					sequencePlayer.Pause();
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Interaction;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "LevelSequence默认播放";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
			}
		}

		// Token: 0x060438BA RID: 276666 RVA: 0x0108527C File Offset: 0x0108347C
		[NullableContext(1)]
		private unsafe void PlayLevelsequenceToMark(string mark, bool jumpToEnd)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				return;
			}
			this.Director.bOverrideInstanceData = true;
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			if (this.LastPlayRateEaseHandleId != 0)
			{
				UKuroSequenceRuntimeFunctionLibrary.StopEasingPlayRate(this.Director, this.LastPlayRateEaseHandleId, false);
				this.LastPlayRateEaseHandleId = 0;
			}
			if (jumpToEnd)
			{
				sequencePlayer.Play();
				sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, mark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Jump));
				RefCompDefine.PlayRateStruct playRateTransition = this.PlayRateTransition;
				this.CurPlayRate = ((playRateTransition != null) ? playRateTransition.PlayRateAbs : null).GetValueOrDefault(1f);
				ULevelSequencePlayer sequencePlayer2 = this.Director.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
				}
				sequencePlayer.Pause();
			}
			else
			{
				EWayType itsWay = this.ItsWay;
				if (itsWay != EWayType.Normal)
				{
					if (itsWay == EWayType.GotoEndAndTransport)
					{
						sequencePlayer.PlayTo_Circle(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, mark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play), true, true);
						RefCompDefine.PlayRateStruct playRateTransition2 = this.PlayRateTransition;
						this.CurPlayRate = ((playRateTransition2 != null) ? playRateTransition2.PlayRateAbs : null).GetValueOrDefault(1f);
						RefCompDefine.PlayRateStruct playRateTransition3 = this.PlayRateTransition;
						float? num = (playRateTransition3 != null) ? playRateTransition3.EaseDuration : null;
						bool flag = num == null || num.GetValueOrDefault() == 0f;
						if (flag)
						{
							ULevelSequencePlayer sequencePlayer3 = this.Director.SequencePlayer;
							if (sequencePlayer3 != null)
							{
								sequencePlayer3.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
							}
						}
						else
						{
							this.LastPlayRateEaseHandleId = UKuroSequenceRuntimeFunctionLibrary.EasePlayRateTo(this.Director, this.CustomTimeDilation * this.CurPlayRate, this.PlayRateTransition.EaseType, this.PlayRateTransition.EaseDuration.Value, this.PlayRateTransition.EaseExponent.Value);
						}
					}
				}
				else
				{
					sequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, mark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
					RefCompDefine.PlayRateStruct playRateTransition4 = this.PlayRateTransition;
					this.CurPlayRate = ((playRateTransition4 != null) ? playRateTransition4.PlayRateAbs : null).GetValueOrDefault(1f);
					RefCompDefine.PlayRateStruct playRateTransition5 = this.PlayRateTransition;
					float? num = (playRateTransition5 != null) ? playRateTransition5.EaseDuration : null;
					bool flag = num == null || num.GetValueOrDefault() == 0f;
					if (flag)
					{
						ULevelSequencePlayer sequencePlayer4 = this.Director.SequencePlayer;
						if (sequencePlayer4 != null)
						{
							sequencePlayer4.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
						}
					}
					else
					{
						this.LastPlayRateEaseHandleId = UKuroSequenceRuntimeFunctionLibrary.EasePlayRateTo(this.Director, this.CustomTimeDilation * this.CurPlayRate, this.PlayRateTransition.EaseType, this.PlayRateTransition.EaseDuration.Value, this.PlayRateTransition.EaseExponent.Value);
					}
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "LevelSequence播放至对应mark";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mark", mark);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060438BB RID: 276667 RVA: 0x010855CC File Offset: 0x010837CC
		private unsafe void PlayLevelsequenceLooping(bool bReverse, int numLoops)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				return;
			}
			this.Director.bOverrideInstanceData = true;
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			if (this.LastPlayRateEaseHandleId != 0)
			{
				UKuroSequenceRuntimeFunctionLibrary.StopEasingPlayRate(this.Director, this.LastPlayRateEaseHandleId, false);
				this.LastPlayRateEaseHandleId = 0;
			}
			if (this.ItsWay == EWayType.Loop)
			{
				if (!bReverse)
				{
					sequencePlayer.PlayLooping(numLoops);
				}
				else
				{
					sequencePlayer.PlayReverseLooping(numLoops);
				}
				RefCompDefine.PlayRateStruct playRateTransition = this.PlayRateTransition;
				this.CurPlayRate = ((playRateTransition != null) ? playRateTransition.PlayRateAbs : null).GetValueOrDefault(1f);
				RefCompDefine.PlayRateStruct playRateTransition2 = this.PlayRateTransition;
				float? num = (playRateTransition2 != null) ? playRateTransition2.EaseDuration : null;
				bool flag = num == null || num.GetValueOrDefault() == 0f;
				if (flag)
				{
					ULevelSequencePlayer sequencePlayer2 = this.Director.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
					}
				}
				else
				{
					this.LastPlayRateEaseHandleId = UKuroSequenceRuntimeFunctionLibrary.EasePlayRateTo(this.Director, this.CustomTimeDilation * this.CurPlayRate, this.PlayRateTransition.EaseType, this.PlayRateTransition.EaseDuration.Value, this.PlayRateTransition.EaseExponent.Value);
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Interaction;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "LevelSequence循环播放";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bReverse", bReverse);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("numLoops", numLoops);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x060438BC RID: 276668 RVA: 0x010857B0 File Offset: 0x010839B0
		private void PlayLevelsequenceLoopingBetweenMark(bool jumpToEnd)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				return;
			}
			this.Director.bOverrideInstanceData = true;
			ULevelSequencePlayer player = this.Director.SequencePlayer;
			ULevelSequencePlayer player2 = player;
			if (player2 == null || !player2.IsValid())
			{
				return;
			}
			if (this.LastPlayRateEaseHandleId != 0)
			{
				UKuroSequenceRuntimeFunctionLibrary.StopEasingPlayRate(this.Director, this.LastPlayRateEaseHandleId, false);
				this.LastPlayRateEaseHandleId = 0;
			}
			RefCompDefine.PlayRateStruct playRateTransition = this.PlayRateTransition;
			this.CurPlayRate = ((playRateTransition != null) ? playRateTransition.PlayRateAbs : null).GetValueOrDefault(1f);
			RefCompDefine.PlayRateStruct playRateTransition2 = this.PlayRateTransition;
			float? num = (playRateTransition2 != null) ? playRateTransition2.EaseDuration : null;
			bool flag = num == null || num.GetValueOrDefault() == 0f;
			if (flag)
			{
				ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
				}
			}
			else
			{
				this.LastPlayRateEaseHandleId = UKuroSequenceRuntimeFunctionLibrary.EasePlayRateTo(this.Director, this.CustomTimeDilation * this.CurPlayRate, this.PlayRateTransition.EaseType, this.PlayRateTransition.EaseDuration.Value, this.PlayRateTransition.EaseExponent.Value);
			}
			double? markValue = this.GetMarkValue(this.LoopStartMark);
			double? markValue2 = this.GetMarkValue(this.Mark);
			if (markValue == null || markValue2 == null)
			{
				return;
			}
			double? num2 = markValue;
			double? num3 = markValue2;
			if (num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null))
			{
				return;
			}
			double num4 = (double)this.GetCurrentFrame();
			num3 = markValue;
			num2 = markValue2;
			bool flag2;
			if (num3.GetValueOrDefault() < num2.GetValueOrDefault() & (num3 != null & num2 != null))
			{
				double num5 = num4;
				num2 = markValue2;
				if (num5 > num2.GetValueOrDefault() & num2 != null)
				{
					flag2 = true;
					goto IL_23A;
				}
			}
			num2 = markValue;
			num3 = markValue2;
			if (num2.GetValueOrDefault() > num3.GetValueOrDefault() & (num2 != null & num3 != null))
			{
				double num6 = num4;
				num3 = markValue2;
				flag2 = (num6 < num3.GetValueOrDefault() & num3 != null);
			}
			else
			{
				flag2 = false;
			}
			IL_23A:
			bool flag3 = flag2;
			if (!this.JumpToEnd && !flag3)
			{
				player.PlayTo_Loop(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, this.Mark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play), this.LoopStartMark);
				return;
			}
			this.AddOnPauseCallback(delegate
			{
				this.ClearOnPausedCallback();
				player.PlayTo_Loop(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, this.Mark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play), this.LoopStartMark);
			});
			FMovieSceneSequencePlaybackParams fmovieSceneSequencePlaybackParams = new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, this.LoopStartMark, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Jump);
			if (this.JumpToEnd)
			{
				player.Play();
				player.SetPlaybackPosition(fmovieSceneSequencePlaybackParams);
				player.Pause();
				return;
			}
			player.PlayTo(fmovieSceneSequencePlaybackParams);
		}

		// Token: 0x060438BD RID: 276669 RVA: 0x01085A94 File Offset: 0x01083C94
		private void GenerateDirector()
		{
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bDisableMovementInput = false;
			fmovieSceneSequencePlaybackSettings.bDisableLookAtInput = false;
			this.Director = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null, false) as ALevelSequenceActor);
			this.Director.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.Director.SetSequence(this.LevelSequence);
			this.CameraSequenceData = (this.Director.DefaultInstanceData as UDefaultLevelSequenceInstanceData);
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			sequencePlayer.OnPause.Add(new Action(this.OnSequencePause));
			sequencePlayer.OnStop.Add(new Action(this.OnSequenceStop));
			sequencePlayer.OnFinished.Add(new Action(this.OnSequenceFinish));
		}

		// Token: 0x060438BE RID: 276670 RVA: 0x01085B6C File Offset: 0x01083D6C
		private void GenerateSphereTrace()
		{
			UTraceSphereElement cameraSphereTrace = this.CameraSphereTrace;
			if (cameraSphereTrace != null && cameraSphereTrace.IsValid())
			{
				return;
			}
			this.CameraSphereTrace = new UTraceSphereElement();
			this.CameraSphereTrace.bIsSingle = false;
			this.CameraSphereTrace.bTraceComplex = false;
			this.CameraSphereTrace.bIgnoreSelf = true;
			this.CameraSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraSphereTrace.Radius = 10f;
			this.CameraSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
		}

		// Token: 0x060438BF RID: 276671 RVA: 0x01085BF0 File Offset: 0x01083DF0
		private void OnSequenceStop()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "SimpleLevelSequenceActor OnSequenceStop";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<bool> onStopCallback = this.OnStopCallback;
			if (onStopCallback != null)
			{
				onStopCallback(this.IsSequenceStopWithFinish);
			}
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid() || this.JumpToEnd)
			{
				return;
			}
			if (this.TransitOutType == ELevelSequenceTransition.Mask && !this.UiSequence)
			{
				this.GenerateBlackScreen(this.OutMask, this.DurationOutTime, this.FadeOutInTime, this.FadeOutOutTime, delegate
				{
					CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, null, new ELevelSequenceTransition?(this.TransitOutType));
				}, new Action(this.OnPlayEnd));
				return;
			}
			this.OnPlayEnd();
		}

		// Token: 0x060438C0 RID: 276672 RVA: 0x01085CB0 File Offset: 0x01083EB0
		private void OnSequencePause()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "SimpleLevelSequenceActor OnSequencePause";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action onPauseCallback = this.OnPauseCallback;
			if (onPauseCallback != null)
			{
				onPauseCallback();
			}
			if (this.JumpToEnd || this.ItsWay == EWayType.Default)
			{
				return;
			}
			if (this.TransitOutType == ELevelSequenceTransition.Mask && !this.UiSequence)
			{
				this.GenerateBlackScreen(this.OutMask, this.DurationOutTime, this.FadeOutInTime, this.FadeOutOutTime, delegate
				{
					CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, null, new ELevelSequenceTransition?(this.TransitOutType));
				}, new Action(this.OnPlayEnd));
				return;
			}
			this.OnPlayEnd();
		}

		// Token: 0x060438C1 RID: 276673 RVA: 0x01085D5C File Offset: 0x01083F5C
		private void OnSequenceFinish()
		{
			Action onFinishedCallback = this.OnFinishedCallback;
			if (onFinishedCallback != null)
			{
				onFinishedCallback();
			}
			if (this.JumpToEnd)
			{
				return;
			}
			if (this.TransitOutType == ELevelSequenceTransition.Mask && !this.UiSequence)
			{
				this.GenerateBlackScreen(this.OutMask, this.DurationOutTime, this.FadeOutInTime, this.FadeOutOutTime, delegate
				{
					CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, null, new ELevelSequenceTransition?(this.TransitOutType));
				}, new Action(this.OnPlayEnd));
				return;
			}
			this.OnPlayEnd();
		}

		// Token: 0x060438C2 RID: 276674 RVA: 0x01085DD1 File Offset: 0x01083FD1
		private void OnPlayEnd()
		{
			Global.CharacterCameraManager.FadeAmount = 0f;
			if (this.HasCameraTrack)
			{
				if (StaticSceneModel.Instance.IsNotAutoExitSceneCamera && this.IsForcedSceneCamera)
				{
					return;
				}
				if (this.UiSequence)
				{
					return;
				}
				this.ExitSceneCamera();
			}
		}

		// Token: 0x060438C3 RID: 276675 RVA: 0x01085E10 File Offset: 0x01084010
		[NullableContext(1)]
		private unsafe bool CheckMarkValid(string mark)
		{
			UMovieScene movieScene = this.LevelSequence.GetMovieScene();
			bool flag = false;
			if (movieScene != null)
			{
				for (int i = 0; i < movieScene.MarkedFrames.Num(); i++)
				{
					if (movieScene.MarkedFrames.Get(i).Label == mark)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "mark配置不合法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelSequence", this.LevelSequence);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mark", mark);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return true;
		}

		// Token: 0x060438C4 RID: 276676 RVA: 0x01085EC4 File Offset: 0x010840C4
		private void EnterSceneCamera(Action enterCameraCb = null)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid())
			{
				global::Log.Instance.Warn(ELogModule.LevelSequencePlayer, ELogAuthor.JYS, "SimpleLevelSeqeunce:EnterSceneCamera Director为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action enterCameraCb2 = enterCameraCb;
				if (enterCameraCb2 == null)
				{
					return;
				}
				enterCameraCb2();
				return;
			}
			else if (PlotModel.Instance.IsInHighLevelPlot())
			{
				global::Log.Instance.Warn(ELogModule.Camera, ELogAuthor.JYS, "SimpleLevelSeqeunce:演出中触发了场景镜头切换 请检查配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action enterCameraCb3 = enterCameraCb;
				if (enterCameraCb3 == null)
				{
					return;
				}
				enterCameraCb3();
				return;
			}
			else
			{
				if (!this.IsKeepUi && !StaticSceneModel.Instance.IsForceKeepUi && !this.IsPlaying())
				{
					CameraController.Instance.MainModel.SceneCamera.DisplayComponent.SetUiActive(false);
				}
				SceneSubCamera sceneCamera = this.SceneCamera;
				if (sceneCamera == null || !sceneCamera.IsBinding)
				{
					this.SceneCamera = CameraController.Instance.MainModel.SceneCamera.DisplayComponent.GetUnBoundSceneCamera(ESceneSubCameraType.Sequence);
					this.SceneCamera.IsKeepUi = this.IsKeepUi;
					if (!this.TransitInValid)
					{
						this.SceneCamera.FadeIn = 0f;
					}
					else
					{
						this.SceneCamera.FadeIn = ((this.FadeInInTime != 0f) ? this.FadeInInTime : this.DurationInTime);
					}
					if (!this.TransitOutValid)
					{
						this.SceneCamera.FadeOut = 0f;
					}
					else
					{
						this.SceneCamera.FadeOut = ((this.FadeOutOutTime != 0f) ? this.FadeOutOutTime : this.DurationOutTime);
					}
				}
				this.BindingActors.Empty(true);
				this.BindingActors.Add(this.SceneCamera.Camera);
				this.Director.SetBindingByTag(SimpleLevelSequenceActorConstants.CAMERA_TAG, this.BindingActors, true, false);
				ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
				ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
				if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
				{
					this.CameraBindFinished = true;
					this.SceneCamera.IsBinding = true;
					CameraController.Instance.MainModel.SceneCamera.PlayerComponent.EnterSceneSubCamera(this.SceneCamera, null);
					Action enterCameraCb4 = enterCameraCb;
					if (enterCameraCb4 == null)
					{
						return;
					}
					enterCameraCb4();
					return;
				}
				else
				{
					if (!this.UiSequence)
					{
						CameraController.Instance.EnterCameraMode(ECustomCameraMode.Scene, (this.TransitInType == ELevelSequenceTransition.Mask) ? 0f : this.FadeInInTime, UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
						Action enterCameraCb5 = enterCameraCb;
						if (enterCameraCb5 != null)
						{
							enterCameraCb5();
						}
						this.CameraBindFinished = true;
						this.SceneCamera.IsBinding = true;
						return;
					}
					if (this.TransitInType == ELevelSequenceTransition.Mask)
					{
						Action <>9__2;
						this.GenerateBlackScreen(this.InMask, this.DurationInTime, this.FadeInInTime, this.FadeInOutTime, delegate
						{
							CameraController instance = CameraController.Instance;
							ECustomCameraMode mode = ECustomCameraMode.Scene;
							float blendTime = 0f;
							UnrealEngine.EViewTargetBlendFunction blendFunction = UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear;
							float blendExp = 0f;
							Action callback;
							if ((callback = <>9__2) == null)
							{
								callback = (<>9__2 = delegate()
								{
									if (!CameraController.Instance.MainModel.IsToSceneCameraMode())
									{
										TsInteractionUtils.ClearCurrentOpenViewName();
										TimeTrackController.Instance.HandleTimeTrackControlViewClose();
										return;
									}
									Action enterCameraCb6 = enterCameraCb;
									if (enterCameraCb6 == null)
									{
										return;
									}
									enterCameraCb6();
								});
							}
							instance.EnterCameraMode(mode, blendTime, blendFunction, blendExp, callback, true, "MainCamera", null);
						}, null);
						return;
					}
					CameraController.Instance.EnterCameraMode(ECustomCameraMode.Scene, this.FadeInInTime, UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear, 0f, delegate
					{
						if (!CameraController.Instance.MainModel.IsToSceneCameraMode())
						{
							TsInteractionUtils.ClearCurrentOpenViewName();
							TimeTrackController.Instance.HandleTimeTrackControlViewClose();
							return;
						}
						Action enterCameraCb6 = enterCameraCb;
						if (enterCameraCb6 == null)
						{
							return;
						}
						enterCameraCb6();
					}, true, "MainCamera", null);
					return;
				}
			}
		}

		// Token: 0x060438C5 RID: 276677 RVA: 0x010861C0 File Offset: 0x010843C0
		private void ExitSceneCamera()
		{
			this.Director.ResetBindings();
			this.CameraBindFinished = false;
			SceneSubCamera sceneCamera = this.SceneCamera;
			if (sceneCamera == null || !sceneCamera.IsBinding)
			{
				this.OnExit();
				return;
			}
			if (this.UiSequence)
			{
				if (this.TransitOutType == ELevelSequenceTransition.Mask)
				{
					this.GenerateBlackScreen(this.InMask, this.DurationInTime, this.FadeInInTime, this.FadeInOutTime, delegate
					{
						this.SceneCamera.FadeOut = 0f;
						CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, new Action(this.OnExit), new ELevelSequenceTransition?(this.TransitOutType));
					}, null);
					return;
				}
				this.SceneCamera.FadeOut = ((this.FadeOutOutTime != 0f) ? this.FadeOutOutTime : this.DurationOutTime);
				CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, new Action(this.OnExit), new ELevelSequenceTransition?(this.TransitOutType));
				return;
			}
			else
			{
				if (this.TransitOutType == ELevelSequenceTransition.Mask)
				{
					this.OnExit();
					return;
				}
				CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, new Action(this.OnExit), new ELevelSequenceTransition?(this.TransitOutType));
				return;
			}
		}

		// Token: 0x060438C6 RID: 276678 RVA: 0x010862E0 File Offset: 0x010844E0
		private void OnExit()
		{
			this.SceneCamera = null;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraInputController.Unlock(this);
			this.LockBySimpleLevelSequence = false;
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.SimpleLevelSequence, "SimpleLevelSequenceProcess", null, null);
			if (this.DefaultPlayAfterTickId != -1)
			{
				TickSystem.Instance.Remove(this.DefaultPlayAfterTickId);
				this.DefaultPlayAfterTickId = -1;
			}
			if (this.DefaultPlayParam != null && this.DefaultPlayParam.BindSetting.IsBindToTarget())
			{
				AActor transformOriginActor = this.TransformOriginActor;
				if (transformOriginActor != null)
				{
					transformOriginActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
			}
			this.DefaultPlayParam = null;
			if (this.IsKeepUi || StaticSceneModel.Instance.IsForceKeepUi)
			{
				return;
			}
			CameraController.Instance.MainModel.SceneCamera.DisplayComponent.SetUiActive(true);
		}

		// Token: 0x060438C7 RID: 276679 RVA: 0x010863BC File Offset: 0x010845BC
		private void GenerateBlackScreen(ETransitionMask? mask, float durationTime, float fadeInTime, float fadeOutTime, Action camCb = null, Action seqCb = null)
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraInputController.Lock(this);
			this.LockBySimpleLevelSequence = true;
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.SimpleLevelSequence;
			ELoadingPerform perform = ELoadingPerform.CameraFade;
			string context = "SimpleLevelSequenceProcess";
			TTimerAction <>9__1;
			Action callback = delegate()
			{
				Action camCb2 = camCb;
				if (camCb2 != null)
				{
					camCb2();
				}
				if (durationTime <= 0f)
				{
					Action seqCb2 = seqCb;
					if (seqCb2 != null)
					{
						seqCb2();
					}
					LevelLoadingController.Instance.CloseLoading(ELoadingReason.SimpleLevelSequence, "SimpleLevelSequenceProcess", null, new float?(fadeOutTime));
					return;
				}
				TimerSystemInstance instance2 = TimerSystem.Instance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						Action seqCb3 = seqCb;
						if (seqCb3 != null)
						{
							seqCb3();
						}
						LevelLoadingController.Instance.CloseLoading(ELoadingReason.SimpleLevelSequence, "SimpleLevelSequenceProcess", null, new float?(fadeOutTime));
					});
				}
				instance2.Delay(action, durationTime * 1000f, null, null, true, 1f);
			};
			object[] array = new object[2];
			array[0] = fadeInTime;
			int num = 1;
			ETransitionMask? etransitionMask = mask;
			ETransitionMask etransitionMask2 = ETransitionMask.BlackMask;
			array[num] = ((etransitionMask.GetValueOrDefault() == etransitionMask2 & etransitionMask != null) ? EFadeInScreenShowType.Black : EFadeInScreenShowType.White);
			instance.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
		}

		// Token: 0x060438C8 RID: 276680 RVA: 0x01086464 File Offset: 0x01084664
		[NullableContext(1)]
		public void SetSequenceData(ULevelSequence inSeq)
		{
			if (inSeq == this.LevelSequence)
			{
				return;
			}
			this.LevelSequence = inSeq;
			this.Director.SetSequence(inSeq);
		}

		// Token: 0x060438C9 RID: 276681 RVA: 0x01086484 File Offset: 0x01084684
		public void Clear()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.DoPlay)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.DoPlay));
			}
			if (this.SceneCamera != null)
			{
				if (this.SceneCamera.IsBinding)
				{
					if (!this.IsKeepUi && !StaticSceneModel.Instance.IsForceKeepUi && !this.IsForcedSceneCamera)
					{
						CameraController.Instance.MainModel.SceneCamera.DisplayComponent.SetUiActive(true);
					}
					CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.SceneCamera, null, null);
				}
				CameraController.Instance.MainModel.SceneCamera.DisplayComponent.RemoveBoundSceneCamera(this.SceneCamera);
			}
			if (this.LastPlayRateEaseHandleId != 0)
			{
				ALevelSequenceActor director = this.Director;
				if (director != null && director.IsValid())
				{
					UKuroSequenceRuntimeFunctionLibrary.StopEasingPlayRate(this.Director, this.LastPlayRateEaseHandleId, false);
				}
				this.LastPlayRateEaseHandleId = 0;
			}
			ALevelSequenceActor director2 = this.Director;
			if (director2 != null && director2.IsValid())
			{
				ALevelSequenceActor tmp = this.Director;
				ULevelSequencePlayer sequencePlayer = tmp.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.Stop();
				}
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("SimpleLevelSequenceActor.Clear", tmp, null);
				}, null, null);
				this.Director = null;
			}
			UTraceSphereElement cameraSphereTrace = this.CameraSphereTrace;
			if (cameraSphereTrace != null && cameraSphereTrace.IsValid())
			{
				this.CameraSphereTrace.Dispose();
				this.CameraSphereTrace = null;
			}
			if (this.LockBySimpleLevelSequence)
			{
				CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraInputController.Unlock(this);
				this.LockBySimpleLevelSequence = false;
			}
			this.ClearOnPausedCallback();
		}

		// Token: 0x060438CA RID: 276682 RVA: 0x0108664C File Offset: 0x0108484C
		[NullableContext(1)]
		public void PlayToMarkByCheckWay(string mark, [Nullable(2)] RefCompDefine.TransitStruct tempInTransit, [Nullable(2)] RefCompDefine.TransitStruct tempOutTransit, RefCompDefine.PlayRateStruct playRateTransition, bool jumpToEnd)
		{
			if (!this.CheckMarkValid(mark))
			{
				return;
			}
			this.Mark = mark;
			if (tempInTransit != null)
			{
				this.TransitInType = tempInTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitInType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
						this.FadeInInTime = tempInTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeInOutTime = tempInTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
						this.InMask = tempInTransit.Mask;
					}
				}
				else
				{
					this.DurationInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInInTime = tempInTransit.Duration.GetValueOrDefault();
					this.FadeInOutTime = 0f;
					this.TransitInValid = tempInTransit.IsValid.GetValueOrDefault();
				}
			}
			if (tempOutTransit != null)
			{
				this.TransitOutType = tempOutTransit.TransitType;
				ELevelSequenceTransition elevelSequenceTransition = this.TransitOutType;
				if (elevelSequenceTransition != ELevelSequenceTransition.Camera)
				{
					if (elevelSequenceTransition == ELevelSequenceTransition.Mask)
					{
						this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
						this.FadeOutInTime = tempOutTransit.TransitFadeIn.GetValueOrDefault();
						this.FadeOutOutTime = tempOutTransit.TransitFadeOut.GetValueOrDefault();
						this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
						this.OutMask = tempOutTransit.Mask;
					}
				}
				else
				{
					this.DurationOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.FadeOutInTime = 0f;
					this.FadeOutOutTime = tempOutTransit.Duration.GetValueOrDefault();
					this.TransitOutValid = tempOutTransit.IsValid.GetValueOrDefault();
				}
			}
			this.JumpToEnd = jumpToEnd;
			this.PlayRateTransition = playRateTransition;
			this.CheckLatestWay();
			this.CheckIsLoadingClosed();
		}

		// Token: 0x060438CB RID: 276683 RVA: 0x010867F0 File Offset: 0x010849F0
		[NullableContext(1)]
		public double? GetMarkValue(string mark)
		{
			UMovieScene movieScene = this.LevelSequence.GetMovieScene();
			for (int i = 0; i < movieScene.MarkedFrames.Num(); i++)
			{
				if (movieScene.MarkedFrames.Get(i).Label == mark)
				{
					return new double?(this.ChangeToFrame((long)movieScene.MarkedFrames.Get(i).FrameNumber.Value));
				}
			}
			return null;
		}

		// Token: 0x060438CC RID: 276684 RVA: 0x01086864 File Offset: 0x01084A64
		public void CheckLatestWay()
		{
			if (this.LevelSequence.GetMovieScene() == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			double value = this.GetMarkValue(this.Mark).Value;
			long num = (long)sequencePlayer.GetStartTime().Time.FrameNumber.Value;
			long num2 = (long)sequencePlayer.GetEndTime().Time.FrameNumber.Value;
			long num3 = (long)sequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
			if (Math.Abs(value - (double)num3) > Math.Abs((double)(num2 - num) - Math.Abs(value - (double)num3)))
			{
				this.ItsWay = EWayType.GotoEndAndTransport;
				return;
			}
			this.ItsWay = EWayType.Normal;
		}

		// Token: 0x060438CD RID: 276685 RVA: 0x01086914 File Offset: 0x01084B14
		private double ChangeToFrame(long num)
		{
			UMovieScene movieScene = this.LevelSequence.GetMovieScene();
			return (double)(num * (long)movieScene.DisplayRate.Numerator / (long)movieScene.TickResolution.Numerator);
		}

		// Token: 0x060438CE RID: 276686 RVA: 0x01086949 File Offset: 0x01084B49
		public void SetTimeDilation(float customTimeDilation)
		{
			if (this.CustomTimeDilation != customTimeDilation)
			{
				this.CustomTimeDilation = customTimeDilation;
				this.UpdateTimeDilation();
			}
		}

		// Token: 0x060438CF RID: 276687 RVA: 0x01086964 File Offset: 0x01084B64
		private void UpdateTimeDilation()
		{
			if (this.LastPlayRateEaseHandleId != 0)
			{
				UKuroSequenceRuntimeFunctionLibrary.StopEasingPlayRate(this.Director, this.LastPlayRateEaseHandleId, false);
				this.LastPlayRateEaseHandleId = 0;
			}
			this.Director.SequencePlayer.SetPlayRate(this.CustomTimeDilation * this.CurPlayRate);
		}

		// Token: 0x060438D0 RID: 276688 RVA: 0x010869B0 File Offset: 0x01084BB0
		public int GetCurrentFrame()
		{
			if (this.Director == null)
			{
				return 0;
			}
			return this.Director.SequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
		}

		// Token: 0x060438D1 RID: 276689 RVA: 0x010869DB File Offset: 0x01084BDB
		public bool IsReversePlay()
		{
			return this.ReversedLoop;
		}

		// Token: 0x060438D2 RID: 276690 RVA: 0x010869E3 File Offset: 0x01084BE3
		public void StopSequence()
		{
			if (this.Director == null)
			{
				return;
			}
			this.Director.SequencePlayer.Stop();
		}

		// Token: 0x060438D3 RID: 276691 RVA: 0x010869FE File Offset: 0x01084BFE
		public void Pause()
		{
			if (this.Director == null)
			{
				return;
			}
			this.IsPause = true;
			if (this.ItsWay == EWayType.Default)
			{
				return;
			}
			this.Director.SequencePlayer.Pause();
		}

		// Token: 0x060438D4 RID: 276692 RVA: 0x01086A29 File Offset: 0x01084C29
		public void Resume()
		{
			if (this.Director == null)
			{
				return;
			}
			this.IsPause = false;
			if (this.ItsWay == EWayType.Default)
			{
				return;
			}
			this.Director.SequencePlayer.Play();
		}

		// Token: 0x060438D5 RID: 276693 RVA: 0x01086A54 File Offset: 0x01084C54
		private void DefaultLevelSequenceAfterTick(float delta)
		{
			ALevelSequenceActor director = this.Director;
			if (director == null || !director.IsValid() || (this.IsPause && !this.ForceTickOneFrameEventPause))
			{
				return;
			}
			this.ForceTickOneFrameEventPause = false;
			this.Director.bOverrideInstanceData = true;
			ULevelSequencePlayer sequencePlayer = this.Director.SequencePlayer;
			this.Character = Global.BaseCharacter;
			if (sequencePlayer != null && sequencePlayer.IsValid())
			{
				TsBaseCharacter character = this.Character;
				if (character != null && character.IsValid())
				{
					if (this.DefaultPlayParam == null)
					{
						return;
					}
					BindTargetSetting bindSetting = this.DefaultPlayParam.BindSetting;
					if (bindSetting.IsBindToTarget())
					{
						this.TempVector.DeepCopy(bindSetting.AttachLocationOffset);
						FName fname = FNameUtil.IsNothing(bindSetting.AttachSocketName) ? CharacterNameDefines.Instance.ROOT : bindSetting.AttachSocketName;
						FVectorDouble fvectorDouble;
						if (fname != CharacterNameDefines.Instance.ROOT)
						{
							FTransformDouble ftransformDouble = this.Character.Mesh.D_GetSocketTransform(fname, ERelativeTransformSpace.RTS_Component);
							FTransformDouble ftransformDouble2 = this.Character.Mesh.D_GetSocketTransform(CharacterNameDefines.Instance.ROOT, ERelativeTransformSpace.RTS_Component);
							fvectorDouble = ftransformDouble.GetLocation();
							FVectorDouble fvectorDouble2 = ftransformDouble2.TransformPosition(fvectorDouble);
							this.TempVector2.DeepCopy(fvectorDouble2);
							this.TempVector.AdditionEqual(this.TempVector2);
						}
						CharacterActorComponent characterActorComponent = this.Character.CharacterActorComponent;
						this.TempRotator.DeepCopy(characterActorComponent.ActorRotationProxy);
						this.TempRotator.Pitch = 0f;
						this.TempRotator.Roll = 0f;
						this.TempRotator.Quaternion(this.TempQuat);
						this.TempQuat.RotateVector(this.TempVector, this.TempVector);
						this.TempVector.AdditionEqual(characterActorComponent.FloorLocation);
						this.TempRotator.AdditionEqual(bindSetting.AttachRotatorOffset);
						this.TempRotator.Quaternion(this.TempQuat);
						if (!this.DefaultPlayParam.HasLastFrameFloorLocationZ)
						{
							this.DefaultPlayParam.HasLastFrameFloorLocationZ = true;
							this.DefaultPlayParam.LastFrameFloorLocationZ = this.TempVector.Z;
						}
						double num = this.DefaultPlayParam.LastFrameFloorLocationZ;
						if (Math.Abs(num - this.TempVector.Z) >= (double)this.DefaultPlayParam.SmoothDelta)
						{
							num = MathUtils.Instance.Lerp(num, this.TempVector.Z, (double)MathUtils.Instance.Clamp(this.DefaultPlayParam.SmoothFactor * delta * 0.001f, 0f, 1f));
							this.DefaultPlayParam.LastFrameFloorLocationZ = num;
						}
						this.TempVector2.DeepCopy(this.TempVector);
						this.TempVector2.Z = num;
						fvectorDouble = this.TempVector2.ToUeVector(false);
						this.TempTransform.SetLocation(fvectorDouble);
						FQuat fquat = this.TempQuat.ToUeQuat();
						this.TempTransform.SetRotation(fquat);
						this.CameraSequenceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(this.TempTransform);
					}
					else if (bindSetting.IsBindToTargetAndPutWorld())
					{
						this.TempRotator.DeepCopy(this.DefaultPlayParam.InitPlayerRotator);
						this.TempRotator.Roll = 0f;
						this.TempRotator.Quaternion(this.TempQuat);
						this.TempQuat.RotateVector(bindSetting.SpecificLocationOffset, this.TempVector);
						this.TempVector.AdditionEqual(this.DefaultPlayParam.InitPlayerFloorLocation);
						this.TempRotator.AdditionEqual(bindSetting.SpecificRotatorOffset);
						this.TempRotator.Quaternion(this.TempQuat);
						this.CameraSequenceData.TransformOriginActor = null;
						FVectorDouble fvectorDouble = this.TempVector.ToUeVector(false);
						this.TempTransform.SetLocation(fvectorDouble);
						FQuat fquat = this.TempQuat.ToUeQuat();
						this.TempTransform.SetRotation(fquat);
						this.CameraSequenceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(this.TempTransform);
					}
					else if (bindSetting.IsBindToWorld())
					{
						bindSetting.WorldRotation.Quaternion(this.TempQuat);
						FVectorDouble fvectorDouble = bindSetting.WorldLocation.ToUeVector(false);
						this.TempTransform.SetLocation(fvectorDouble);
						FQuat fquat = this.TempQuat.ToUeQuat();
						this.TempTransform.SetRotation(fquat);
						this.CameraSequenceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(this.TempTransform);
					}
					this.DefaultPlayParam.PlayedTime += delta * 0.001f;
					sequencePlayer.PlayToSeconds(this.DefaultPlayParam.PlayedTime);
					if (this.DefaultPlayParam.DelayUpdateFrame == this.DefaultPlayParam.MaxDelayUpdateFrame)
					{
						Rotator cameraActorRotator = this.CameraActorRotator;
						FRotator frotator = this.SceneCamera.Camera.K2_GetActorRotation();
						cameraActorRotator.DeepCopy(frotator);
					}
					if (this.DefaultPlayParam.FollowSetting.IsFollowTarget && this.DefaultPlayParam.DelayUpdateFrame >= this.DefaultPlayParam.MaxDelayUpdateFrame)
					{
						this.TempVector2.DeepCopy(this.Character.CharacterActorComponent.FloorLocation);
						Vector tempVector = this.TempVector3;
						FVectorDouble fvectorDouble = this.SceneCamera.Camera.D_K2_GetActorLocation();
						tempVector.DeepCopy(fvectorDouble);
						this.TempVector2.SubtractionEqual(this.TempVector3);
						this.TempVector2.Normalize(9.99999993922529E-09);
						this.TempVector2.Rotation(this.TempRotator);
						this.CameraActorRotator.Vector(this.TempVector4);
						if (this.DefaultPlayParam.FollowSetting.IsFollowTargetAngle)
						{
							Quat.FindBetween(this.TempVector2, this.TempVector4, this.TempQuat);
							float num2 = (float)(Math.Acos(Vector.DotProduct(this.TempVector2, this.TempVector4)) * 57.295780181884766);
							float num3 = this.DefaultPlayParam.FollowSetting.AngleFollowSpeed * delta * 0.001f;
							float num4 = (num3 > 1f || num3 < 0f) ? num2 : (num2 * num3);
							float alpha = MathUtils.Instance.Clamp(num4 / num2, 0f, 1f);
							MathUtils.Instance.SqLerpVector(this.TempVector4, this.TempVector2, alpha, this.TempVector2);
							this.TempVector2.Rotation(this.CameraActorRotator);
						}
						else if (this.DefaultPlayParam.FollowSetting.IsFollowTargetPitch)
						{
							float pitch = this.TempRotator.Pitch;
							float pitch2 = this.CameraActorRotator.Pitch;
							float num5 = MathUtils.Instance.WrapAngle(pitch - pitch2);
							float num6 = this.DefaultPlayParam.FollowSetting.PitchFollowSpeed * delta * 0.001f;
							float num7 = (num6 > 1f || num6 < 0f) ? num5 : (num5 * num6);
							this.CameraActorRotator.Pitch = MathUtils.Instance.WrapAngle(pitch2 + num7);
						}
						else if (this.DefaultPlayParam.FollowSetting.IsFollowTargetYaw)
						{
							float yaw = this.TempRotator.Yaw;
							float yaw2 = this.CameraActorRotator.Yaw;
							float num8 = MathUtils.Instance.WrapAngle(yaw - yaw2);
							float num9 = this.DefaultPlayParam.FollowSetting.YawFollowSpeed * delta * 0.001f;
							double num10 = (double)((num9 > 1f || num9 < 0f) ? num8 : (num8 * num9));
							this.CameraActorRotator.Yaw = (float)MathUtils.Instance.WrapAngle((double)yaw2 + num10);
						}
						this.SceneCamera.Camera.K2_SetActorRotation(this.CameraActorRotator.ToUeRotator(), true);
					}
					this.DefaultPlayParam.DelayUpdateFrame++;
					if (this.ProcessCollistion())
					{
						this.IsSequenceStopWithFinish = true;
						this.StopSequence();
					}
					if (this.DefaultPlayParam.PlayedTime >= this.DefaultPlayParam.TimeLength)
					{
						this.IsSequenceStopWithFinish = true;
						this.StopSequence();
					}
					return;
				}
			}
		}

		// Token: 0x060438D6 RID: 276694 RVA: 0x01087228 File Offset: 0x01085428
		private bool ProcessCollistion()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null && baseCharacter.IsValid())
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent != null && characterActorComponent.Valid)
				{
					SceneSubCamera sceneCamera = this.SceneCamera;
					bool flag;
					if (sceneCamera == null)
					{
						flag = true;
					}
					else
					{
						BP_CineCamera_C camera = sceneCamera.Camera;
						flag = !((camera != null) ? new bool?(camera.IsValid()) : null).GetValueOrDefault();
					}
					if (!flag)
					{
						this.GenerateSphereTrace();
						this.CameraSphereTrace.ActorsToIgnore.Empty(true);
						this.CameraSphereTrace.ActorsToIgnore.Add(baseCharacter);
						Vector tempVector = this.TempVector;
						FVectorDouble fvectorDouble = this.SceneCamera.Camera.D_K2_GetActorLocation();
						tempVector.FromUeVector(fvectorDouble);
						TraceElementCommon.Instance.SetStartLocation(this.CameraSphereTrace, baseCharacter.CharacterActorComponent.ActorLocationProxy);
						TraceElementCommon.Instance.SetEndLocation(this.CameraSphereTrace, this.TempVector);
						return TraceElementCommon.Instance.SphereTrace(this.CameraSphereTrace, "SimpleLevelSequenceActor_CheckCollision_Camera");
					}
				}
			}
			return false;
		}

		// Token: 0x04023430 RID: 144432
		private ULevelSequence LevelSequence;

		// Token: 0x04023431 RID: 144433
		private ALevelSequenceActor Director;

		// Token: 0x04023432 RID: 144434
		private AActor TransformOriginActor;

		// Token: 0x04023433 RID: 144435
		private UDefaultLevelSequenceInstanceData CameraSequenceData;

		// Token: 0x04023434 RID: 144436
		private TsBaseCharacter Character;

		// Token: 0x04023435 RID: 144437
		[Nullable(1)]
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x04023436 RID: 144438
		private float FadeInInTime;

		// Token: 0x04023437 RID: 144439
		private float FadeInOutTime;

		// Token: 0x04023438 RID: 144440
		private float FadeOutInTime;

		// Token: 0x04023439 RID: 144441
		private float FadeOutOutTime;

		// Token: 0x0402343A RID: 144442
		private float DurationInTime;

		// Token: 0x0402343B RID: 144443
		private float DurationOutTime;

		// Token: 0x0402343C RID: 144444
		private ELevelSequenceTransition TransitInType;

		// Token: 0x0402343D RID: 144445
		private ELevelSequenceTransition TransitOutType;

		// Token: 0x0402343E RID: 144446
		private bool TransitInValid;

		// Token: 0x0402343F RID: 144447
		private bool TransitOutValid;

		// Token: 0x04023440 RID: 144448
		private readonly bool HasCameraTrack;

		// Token: 0x04023441 RID: 144449
		private bool JumpToEnd;

		// Token: 0x04023442 RID: 144450
		[Nullable(1)]
		private string Mark = "";

		// Token: 0x04023443 RID: 144451
		[Nullable(1)]
		private string LoopStartMark = "";

		// Token: 0x04023444 RID: 144452
		private bool ReversedLoop;

		// Token: 0x04023445 RID: 144453
		private int NumLoops = -1;

		// Token: 0x04023446 RID: 144454
		private float CurPlayRate = 1f;

		// Token: 0x04023447 RID: 144455
		private RefCompDefine.PlayRateStruct PlayRateTransition;

		// Token: 0x04023448 RID: 144456
		private int LastPlayRateEaseHandleId;

		// Token: 0x04023449 RID: 144457
		private bool CameraBindFinished;

		// Token: 0x0402344A RID: 144458
		private bool IsKeepUi;

		// Token: 0x0402344B RID: 144459
		private bool CanPlayInLoading;

		// Token: 0x0402344C RID: 144460
		private bool IsPause;

		// Token: 0x0402344D RID: 144461
		private bool ForceTickOneFrameEventPause;

		// Token: 0x0402344E RID: 144462
		private EWayType ItsWay = EWayType.Normal;

		// Token: 0x0402344F RID: 144463
		private SceneSubCamera SceneCamera;

		// Token: 0x04023450 RID: 144464
		private bool IsForcedSceneCamera;

		// Token: 0x04023451 RID: 144465
		private ETransitionMask? InMask = new ETransitionMask?(ETransitionMask.BlackMask);

		// Token: 0x04023452 RID: 144466
		private ETransitionMask? OutMask = new ETransitionMask?(ETransitionMask.BlackMask);

		// Token: 0x04023453 RID: 144467
		private bool LockBySimpleLevelSequence;

		// Token: 0x04023454 RID: 144468
		private float CustomTimeDilation = 1f;

		// Token: 0x04023455 RID: 144469
		private bool UiSequence;

		// Token: 0x04023456 RID: 144470
		private DefaultLevelSequencePlayParam DefaultPlayParam;

		// Token: 0x04023457 RID: 144471
		private int DefaultPlayAfterTickId = -1;

		// Token: 0x04023458 RID: 144472
		private bool IsSequenceStopWithFinish;

		// Token: 0x04023459 RID: 144473
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x0402345A RID: 144474
		[Nullable(1)]
		private readonly Rotator CameraActorRotator = Rotator.Create();

		// Token: 0x0402345B RID: 144475
		[Nullable(1)]
		private readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x0402345C RID: 144476
		[Nullable(1)]
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402345D RID: 144477
		[Nullable(1)]
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0402345E RID: 144478
		[Nullable(1)]
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x0402345F RID: 144479
		[Nullable(1)]
		private readonly Vector TempVector3 = Vector.Create();

		// Token: 0x04023460 RID: 144480
		[Nullable(1)]
		private readonly Vector TempVector4 = Vector.Create();

		// Token: 0x04023461 RID: 144481
		private FTransformDouble TempTransform;

		// Token: 0x04023462 RID: 144482
		private Action OnPauseCallback;

		// Token: 0x04023463 RID: 144483
		private Action<bool> OnStopCallback;

		// Token: 0x04023464 RID: 144484
		private Action OnFinishedCallback;
	}
}
