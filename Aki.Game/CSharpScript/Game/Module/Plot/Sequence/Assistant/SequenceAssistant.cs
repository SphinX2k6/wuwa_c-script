using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005035 RID: 20533
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceAssistant : SeqBaseAssistant
	{
		// Token: 0x060348D5 RID: 215253 RVA: 0x00C65C24 File Offset: 0x00C63E24
		[NullableContext(2)]
		public override void Load(Action<bool> callback = null)
		{
			PlaySequenceData config = this.Model.Config;
			if (StringUtils.IsEmpty((config != null) ? config.Path : null))
			{
				FlowController.Instance.LogError("剧情SequenceDA路径为空，检查配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				callback(false);
				return;
			}
			this.SeqDataLoadingId = PreloadModelNew.Instance.PlotAssetManager.GetAsset<BP_SequenceData_C>(this.Model.Config.Path, delegate([Nullable(2)] BP_SequenceData_C data, string _)
			{
				this.SeqDataLoadingId = -1;
				if (!ObjectUtils.IsValid(data))
				{
					global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.ZWY, "DA加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					callback(false);
					return;
				}
				this.Model.SequenceData = data;
				this.SeqDataLoadingId = -1;
				callback(true);
			});
		}

		// Token: 0x060348D6 RID: 215254 RVA: 0x00C65CBC File Offset: 0x00C63EBC
		[NullableContext(2)]
		public unsafe override void PreAllPlay(Action<bool> callback = null)
		{
			if (this.Model.EndLeastTime == null)
			{
				this.Model.EndLeastTime = new float?(PlotModel.Instance.PlotGlobalConfig.SequenceEndLeastTime);
				float? endLeastTime = this.Model.EndLeastTime;
				double? num = (endLeastTime != null) ? new double?((double)endLeastTime.GetValueOrDefault()) : null;
				double num2 = 20.0 * TimeUtil.Instance.Millisecond;
				if (num.GetValueOrDefault() < num2 & num != null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "配置的最后一句话淡出时间不能小于最小时间";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurTime", this.Model.EndLeastTime);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MinTime", 20.0 * TimeUtil.Instance.Millisecond);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.Model.EndLeastTime = new float?((float)1);
				}
			}
			this.Model.DurationOffset = new float?(0f);
			this.ReadOriginTransform();
			if (this.Model.UseRuntimeData)
			{
				this.ReadFadeEndRuntime();
			}
			else
			{
				this.ReadFadeEnd();
			}
			if (this.Model.SequenceData.SaveFinalTransform)
			{
				if (this.Model.UseRuntimeData)
				{
					this.ReadFinalPositionRuntime();
				}
				else
				{
					this.ReadFinalPos();
				}
			}
			EPlotSequenceType? type = this.Model.Type;
			EPlotSequenceType eplotSequenceType = EPlotSequenceType.过场;
			if (type.GetValueOrDefault() == eplotSequenceType & type != null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "过场生成SubSeuqenceMap", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.MakeSubSequenceMap();
			}
			this.AspectLoadingTime = 0;
			ULevelSequence currentSequence = SequenceModel.Instance.GetCurrentSequence();
			if (this.CheckSequenceConstrainAspect(currentSequence))
			{
				PlotModel.Instance.LastPlotAspect = 2.38f;
			}
			else
			{
				PlotModel.Instance.LastPlotAspect = 1.77f;
			}
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true);
			int num3 = 0;
			if ((currentValue.GetValueOrDefault() > num3 & currentValue != null) && BlackScreenFadeController.Instance.ChangeAspect(PlotModel.Instance.LastPlotAspect, null))
			{
				int valueOrDefault = ConfigCommonParamById.GetIntConfig("BlackScreenFadeLerpFullTime").GetValueOrDefault(3);
				this.AspectLoadingTime = valueOrDefault;
			}
		}

		// Token: 0x060348D7 RID: 215255 RVA: 0x00C65F34 File Offset: 0x00C64134
		public override void PreEachPlay()
		{
			if (!ObjectUtils.IsValid(this.Model.GetCurrentSequence()))
			{
				FlowController instance = FlowController.Instance;
				string text = "剧情Sequence失效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", this.Model.SubSeqIndex);
				instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsSequencePlay = true;
			this.Reattach();
			this.MuteUnusedTrack();
			this.CreateSequencePlayer();
			this.SetOriginTransform();
			if (this.Model.UseRuntimeData)
			{
				this.ReadDataRuntime();
				return;
			}
			this.ReadBakedSeqFrameInfo();
		}

		// Token: 0x060348D8 RID: 215256 RVA: 0x00C65FC0 File Offset: 0x00C641C0
		public void Play(Action endCallback)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "开始播放剧情Sequence：";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Model.CurLevelSeqActor.GetSequence());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			int aspectLoadingTime = this.AspectLoadingTime;
			this.AspectLoadingTime = 0;
			if (aspectLoadingTime > 0)
			{
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "PlaySequence", delegate
				{
					this.PlaySequence(endCallback);
				}, new float?((float)aspectLoadingTime));
				return;
			}
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "PlaySequence", null, new float?(0f));
			this.PlaySequence(endCallback);
		}

		// Token: 0x060348D9 RID: 215257 RVA: 0x00C66074 File Offset: 0x00C64274
		private void PlaySequence(Action endCallback)
		{
			this.Model.NeedsQueueLatentAction = new bool?(true);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in this.Model.CurSubtitleStartFrames)
			{
				hashSet.Add(item);
			}
			foreach (int item2 in this.Model.CurSubtitleEndFrames)
			{
				hashSet.Add(item2);
			}
			foreach (int item3 in this.Model.QteKeyFrames)
			{
				hashSet.Add(item3);
			}
			foreach (int item4 in this.Model.GetCurKeyFrames())
			{
				hashSet.Add(item4);
			}
			TArray<int> tarray = new TArray<int>();
			foreach (int value in hashSet)
			{
				tarray.Add(value);
			}
			this.Model.CurLevelSeqActor.SequencePlayer.SetKeyFrames(tarray);
			if (this.Model.TwiceAnimFlag)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
				this.Model.CurLevelSeqActor.SequencePlayer.Play();
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
			}
			else
			{
				this.Model.CurLevelSeqActor.SequencePlayer.Play();
			}
			SequenceController.Instance.TriggerCutChange();
			SequenceModel model = this.Model;
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			model.TalkNpcList = ((curLevelSeqActor != null) ? curLevelSeqActor.GetBindingByTag(SequenceDefine.TALK_NPC_TAG, true) : null);
			this.Model.NeedsQueueLatentAction = new bool?(false);
			this.Model.RunLatentActions();
			this.Model.IsPaused = new bool?(false);
			this.OnStopCallBack = endCallback;
			this.Model.CurLevelSeqActor.SequencePlayer.OnStop.Add(endCallback);
		}

		// Token: 0x060348DA RID: 215258 RVA: 0x00C662FC File Offset: 0x00C644FC
		public override void EachStop()
		{
			SequenceController.Instance.FlushDialogueState();
			this.StopAcceleratingSkip();
			this.IsSequencePlay = false;
			this.Model.CurLevelSeqActor.SequencePlayer.OnStop.Clear();
			this.OnStopCallBack = null;
			this.Model.CurLevelSeqActor.SequencePlayer.ClearKeyFrames();
			this.Model.CurLevelSeqActor.ResetBindings();
			ActorSystem.Instance.Put("SequenceAssistant.EachStop", this.Model.CurLevelSeqActor, null);
			this.Model.CurLevelSeqActor = null;
			this.Model.TalkNpcList = null;
			SequenceModel model = this.Model;
			float? durationOffset = model.DurationOffset;
			int? curEndFrame = this.Model.CurEndFrame;
			int? curStartFrame = this.Model.CurStartFrame;
			model.DurationOffset = durationOffset + ((curEndFrame != null & curStartFrame != null) ? new float?((float)(curEndFrame.GetValueOrDefault() - curStartFrame.GetValueOrDefault())) : null) / this.Model.CurFrameRate;
			this.ClearFrameInfo();
		}

		// Token: 0x060348DB RID: 215259 RVA: 0x00C6646D File Offset: 0x00C6466D
		[NullableContext(2)]
		public override void AllStop(Action<bool> callback = null)
		{
		}

		// Token: 0x060348DC RID: 215260 RVA: 0x00C66470 File Offset: 0x00C64670
		public override void End()
		{
			if (this.SeqDataLoadingId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SeqDataLoadingId);
				this.SeqDataLoadingId = -1;
			}
			if (this.IsSequencePlay)
			{
				this.StopAcceleratingSkip();
				this.Model.CurLevelSeqActor.SequencePlayer.OnStop.Clear();
				this.Model.CurLevelSeqActor.SequencePlayer.GoToEndAndStop(EUpdatePositionMethod.Play);
				this.Model.CurLevelSeqActor.ResetBindings();
				ActorSystem.Instance.Put("SequenceAssistant.End", this.Model.CurLevelSeqActor, null);
				this.Model.CurLevelSeqActor = null;
			}
			if (this.LastSubtitleDelay != null)
			{
				this.LastSubtitleDelay.Remove();
			}
			this.Model.RelativeTransform = null;
			this.Model.DurationOffset = new float?(0f);
			this.IsSequencePlay = false;
			this.ClearFrameInfo();
			this.PauseReasonSet.Clear();
			this.NeedGoToNextFrameWhenResume = false;
			this.SubSequenceMap.Clear();
		}

		// Token: 0x060348DD RID: 215261 RVA: 0x00C66574 File Offset: 0x00C64774
		private void Reattach()
		{
			TArray<FName> tarray = new TArray<FName>();
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			LoginDefine.ELoginSex value = (LoginDefine.ELoginSex)PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Sex).Value;
			if (value != LoginDefine.ELoginSex.Girl)
			{
				if (value == LoginDefine.ELoginSex.Boy)
				{
					tarray.Add(SequenceDefine.MALE_TAG);
				}
				else
				{
					global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "Reattach获取不到性别", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			else
			{
				tarray.Add(SequenceDefine.FEMALE_TAG);
			}
			tarray.Add(SequenceDefine.HERO_TAG);
			UKuroSequenceRuntimeFunctionLibrary.SearchAttachAndReattach(currentSequence, tarray, SequenceDefine.FREEATTACH_TAG);
			UKuroSequenceRuntimeFunctionLibrary.ResetMovieSceneCompiledData(currentSequence);
			TArray<UMovieSceneTrack> masterTracks = currentSequence.MovieScene.MasterTracks;
			int num = (masterTracks != null) ? masterTracks.Num() : 0;
			for (int i = 0; i < num; i++)
			{
				UMovieSceneTrack umovieSceneTrack = masterTracks.Get(i);
				if (umovieSceneTrack is UMovieSceneSubTrack)
				{
					TArray<UMovieSceneSection> sections = ((UMovieSceneSubTrack)umovieSceneTrack).Sections;
					int num2 = (sections != null) ? sections.Num() : 0;
					for (int j = 0; j < num2; j++)
					{
						UMovieSceneSection umovieSceneSection = sections.Get(j);
						if (umovieSceneSection is UMovieSceneSubSection)
						{
							UMovieSceneSubSection umovieSceneSubSection = umovieSceneSection as UMovieSceneSubSection;
							UKuroSequenceRuntimeFunctionLibrary.SearchAttachAndReattach(umovieSceneSubSection.SubSequence, tarray, SequenceDefine.FREEATTACH_TAG);
							UKuroSequenceRuntimeFunctionLibrary.ResetMovieSceneCompiledData(umovieSceneSubSection.SubSequence);
						}
					}
				}
			}
		}

		// Token: 0x060348DE RID: 215262 RVA: 0x00C666AC File Offset: 0x00C648AC
		private void MuteUnusedTrack()
		{
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Sex);
			bool flag = this.CheckSequenceConstrainAspect(currentSequence);
			bool flag2 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.FlowAdaptation, 0, true) > 0 && !SequenceModel.Instance.EnablingUiBlend;
			this.Model.IsConstrainAspectActive = (flag && flag2);
			if (flag2)
			{
				UKuroSequenceRuntimeFunctionLibrary.MuteTrackByName(currentSequence, SequenceAssistant.CONSTRAIN, false);
			}
			else
			{
				UKuroSequenceRuntimeFunctionLibrary.MuteTrackByName(currentSequence, SequenceAssistant.CONSTRAIN, true);
			}
			LoginDefine.ELoginSex value = (LoginDefine.ELoginSex)numberPropById.Value;
			if (value != LoginDefine.ELoginSex.Girl)
			{
				if (value == LoginDefine.ELoginSex.Boy)
				{
					UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.MALE_TAG, false);
					UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.FEMALE_TAG, true);
				}
				else
				{
					global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "剧情Seq播放时无法获取性别", default(ReadOnlySpan<ValueTuple<string, object>>));
					UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.FEMALE_TAG, true);
					UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.MALE_TAG, true);
				}
			}
			else
			{
				UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.FEMALE_TAG, false);
				UKuroSequenceRuntimeFunctionLibrary.MuteTrackByTag(currentSequence, SequenceDefine.MALE_TAG, true);
			}
			UKuroSequenceRuntimeFunctionLibrary.ResetMovieSceneCompiledData(currentSequence);
			TArray<UMovieSceneTrack> masterTracks = currentSequence.MovieScene.MasterTracks;
			int num = (masterTracks != null) ? masterTracks.Num() : 0;
			for (int i = 0; i < num; i++)
			{
				UMovieSceneTrack umovieSceneTrack = masterTracks.Get(i);
				if (umovieSceneTrack is UMovieSceneSubTrack)
				{
					TArray<UMovieSceneSection> sections = ((UMovieSceneSubTrack)umovieSceneTrack).Sections;
					int num2 = (sections != null) ? sections.Num() : 0;
					for (int j = 0; j < num2; j++)
					{
						UMovieSceneSection umovieSceneSection = sections.Get(j);
						if (umovieSceneSection is UMovieSceneSubSection)
						{
							UKuroSequenceRuntimeFunctionLibrary.ResetMovieSceneCompiledData((umovieSceneSection as UMovieSceneSubSection).SubSequence);
						}
					}
				}
			}
		}

		// Token: 0x060348DF RID: 215263 RVA: 0x00C66844 File Offset: 0x00C64A44
		private void CreateSequencePlayer()
		{
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			ALevelSequenceActor alevelSequenceActor = ActorSystem.Instance.Spawn(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null) as ALevelSequenceActor;
			alevelSequenceActor.PlaybackSettings = new FMovieSceneSequencePlaybackSettings
			{
				PlayRate = this.Model.PlayRate,
				bDisableCameraCuts = !this.Model.IsViewTargetControl
			};
			alevelSequenceActor.SetSequence(currentSequence);
			this.Model.CurLevelSeqActor = alevelSequenceActor;
			ULevelSequencePlayer sequencePlayer = this.Model.CurLevelSeqActor.SequencePlayer;
			this.Model.CurStartFrame = new int?(sequencePlayer.GetStartTime().Time.FrameNumber.Value);
			this.Model.CurEndFrame = new int?(sequencePlayer.GetEndTime().Time.FrameNumber.Value);
			FFrameRate frameRate = sequencePlayer.GetFrameRate();
			this.Model.CurFrameRate = new float?((float)(frameRate.Numerator / frameRate.Denominator));
			int? curStartFrame = this.Model.CurStartFrame;
			int num = 0;
			if (!(curStartFrame.GetValueOrDefault() == num & curStartFrame != null))
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.CFT, "剧情Seq开始帧不规范，编号不是0", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x060348E0 RID: 215264 RVA: 0x00C66984 File Offset: 0x00C64B84
		private unsafe void ReadOriginTransform()
		{
			FTransformDouble? ftransformDouble = null;
			if (!this.Model.SequenceData.是否固定起始点)
			{
				FTransformDouble? ftransformDouble2 = null;
				if (this.Model.SequenceData.IsTransformOverride)
				{
					FTransformDouble value = UKismetMathLibrary.Conv_TransformToTransformDouble(this.Model.SequenceData.OverrideTransform);
					ftransformDouble2 = new FTransformDouble?(value);
				}
				else if (!StringUtils.IsEmpty(this.Model.SequenceData.绑定起始点标签))
				{
					string 绑定起始点标签 = this.Model.SequenceData.绑定起始点标签;
					if (!(绑定起始点标签 == "Player"))
					{
						if (!(绑定起始点标签 == "SequenceCamera"))
						{
							foreach (KeyValuePair<FName, EntityHandle> keyValuePair in this.Model.BindingEntityMap)
							{
								if (keyValuePair.Value.Valid && keyValuePair.Key.ToString() == this.Model.SequenceData.绑定起始点标签)
								{
									ftransformDouble2 = new FTransformDouble?(keyValuePair.Value.Entity.GetComponent<BaseActorComponent>().ActorTransform);
									break;
								}
							}
						}
						else
						{
							ftransformDouble2 = new FTransformDouble?(CameraController.Instance.MainModel.SequenceCamera.GetComponent<SequenceCameraDisplayComponent>().CineCamera.D_GetTransform());
						}
					}
					else
					{
						TsBaseCharacter baseCharacter = Global.BaseCharacter;
						ftransformDouble2 = ((baseCharacter != null) ? new FTransformDouble?(baseCharacter.D_GetTransform()) : null);
					}
				}
				if (ftransformDouble2 == null || ftransformDouble2.Value.GetLocation().IsZero())
				{
					FlowController instance = FlowController.Instance;
					string text = "需要绑定起始点的Sequence读不到坐标";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("UseTransform", this.Model.SequenceData.IsTransformOverride);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UseTag", this.Model.SequenceData.绑定起始点标签);
					instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					ftransformDouble = ftransformDouble2;
				}
			}
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			FVectorDouble fvectorDouble = new FVectorDouble(0.0);
			if (currentSequence.D_GetCenterOffset(ref fvectorDouble))
			{
				fvectorDouble = fvectorDouble;
			}
			else
			{
				if (ftransformDouble == null)
				{
					return;
				}
				fvectorDouble.Set(0.0, 0.0, 0.0);
			}
			this.Model.RelativeTransform = Transform.Create(Quat.IdentityProxy, global::Vector.ZeroVectorProxy, global::Vector.OneVectorProxy);
			if (ftransformDouble != null)
			{
				FTransformDouble valueOrDefault = ftransformDouble.GetValueOrDefault();
				valueOrDefault.AddToTranslation(fvectorDouble);
				this.Model.RelativeTransform.FromUeTransform(valueOrDefault);
			}
			else
			{
				this.Model.RelativeTransform.SetLocation(fvectorDouble);
			}
			this.Model.RelativeTransform.SetScale3D(global::Vector.OneVectorProxy);
		}

		// Token: 0x060348E1 RID: 215265 RVA: 0x00C66C90 File Offset: 0x00C64E90
		private void SetOriginTransform()
		{
			this.Model.CurLevelSeqActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.Model.CurLevelSeqActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			if (this.Model.RelativeTransform != null)
			{
				udefaultLevelSequenceInstanceData.TransformOrigin = this.Model.RelativeTransform.ToUeTransformOld();
			}
		}

		// Token: 0x060348E2 RID: 215266 RVA: 0x00C66CE8 File Offset: 0x00C64EE8
		private void ClearFrameInfo()
		{
			this.Model.CurSubtitleStartFrames.Clear();
			this.Model.CurSubtitleEndFrames.Clear();
			this.Model.CurShotStartFrames.Clear();
			this.Model.CurShotEndFrames.Clear();
			this.Model.CurStartFrame = null;
			this.Model.CurEndFrame = null;
		}

		// Token: 0x060348E3 RID: 215267 RVA: 0x00C66D58 File Offset: 0x00C64F58
		private void ReadBakedSeqFrameInfo()
		{
			SSequencesKeyFrames currentKeyFramesInfo = this.Model.GetCurrentKeyFramesInfo();
			TArray<int> subtitleStartFrames = currentKeyFramesInfo.SubtitleStartFrames;
			int num = subtitleStartFrames.Num();
			for (int i = 0; i < num; i++)
			{
				this.Model.CurSubtitleStartFrames.Add(subtitleStartFrames.Get(i));
			}
			TArray<int> subtitleEndFrames = currentKeyFramesInfo.SubtitleEndFrames;
			int num2 = subtitleEndFrames.Num();
			for (int j = 0; j < num2; j++)
			{
				this.Model.CurSubtitleEndFrames.Add(subtitleEndFrames.Get(j));
			}
			TArray<int> shotStartFrames = currentKeyFramesInfo.ShotStartFrames;
			int num3 = shotStartFrames.Num();
			for (int k = 0; k < num3; k++)
			{
				this.Model.CurShotStartFrames.Add(shotStartFrames.Get(k));
			}
			TArray<int> shotEndFrames = currentKeyFramesInfo.ShotEndFrames;
			int num4 = shotEndFrames.Num();
			for (int l = 0; l < num4; l++)
			{
				this.Model.CurShotEndFrames.Add(shotEndFrames.Get(l));
			}
		}

		// Token: 0x060348E4 RID: 215268 RVA: 0x00C66E54 File Offset: 0x00C65054
		private void ReadFadeEndRuntime()
		{
			this.Model.IsFadeEnd.Clear();
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			for (int i = 0; i < sequenceData.剧情资源.Num(); i++)
			{
				ULevelSequence sequence = sequenceData.剧情资源.Get(i);
				int num = UKuroSequenceRuntimeFunctionLibrary.GetPlaybackEnd(sequence) - 1;
				float num2 = this.GetFadeAmountAt(sequence, num);
				TArray<UMovieSceneTrack> tarray = UKuroSequenceRuntimeFunctionLibrary.FindMasterTracksByType(sequence, UMovieSceneCinematicShotTrack.StaticClass());
				UMovieSceneTrack umovieSceneTrack = (tarray.Num() > 0) ? tarray.Get(0) : null;
				if (ObjectUtils.IsValid(umovieSceneTrack))
				{
					TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(umovieSceneTrack as UMovieSceneSubTrack);
					if (sections.Num() > 0)
					{
						UMovieSceneSubSection umovieSceneSubSection = null;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						for (int j = sections.Num() - 1; j >= 0; j--)
						{
							UMovieSceneSection umovieSceneSection = sections.Get(j);
							int num6 = UKuroSequenceRuntimeFunctionLibrary.GetEndFrame(umovieSceneSection);
							if (num6 > num)
							{
								num6 = num;
							}
							if (num6 > num3)
							{
								umovieSceneSubSection = (umovieSceneSection as UMovieSceneSubSection);
								num5 = umovieSceneSubSection.Parameters.StartFrameOffset.Value;
								num4 = UKuroSequenceRuntimeFunctionLibrary.GetStartFrame(umovieSceneSubSection);
								num3 = num6;
							}
						}
						ULevelSequence ulevelSequence = ((umovieSceneSubSection != null) ? umovieSceneSubSection.GetSequence() : null) as ULevelSequence;
						if (ObjectUtils.IsValid(ulevelSequence))
						{
							int playbackStart = UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(ulevelSequence);
							int frameNumber = num - num4 + num5 + playbackStart;
							float fadeAmountAt = this.GetFadeAmountAt(ulevelSequence, frameNumber);
							if (fadeAmountAt >= 0f)
							{
								num2 = fadeAmountAt;
							}
						}
					}
				}
				this.Model.IsFadeEnd.Add((double)num2 > 0.9);
			}
		}

		// Token: 0x060348E5 RID: 215269 RVA: 0x00C66FE4 File Offset: 0x00C651E4
		public float GetFadeAmountAt(ULevelSequence sequence, int frameNumber)
		{
			TArray<UMovieSceneTrack> tarray = UKuroSequenceRuntimeFunctionLibrary.FindMasterTracksByType(sequence, UMovieSceneFadeTrack.StaticClass());
			if (tarray == null || tarray.Num() <= 0)
			{
				return -1f;
			}
			List<UMovieSceneSection> list = new List<UMovieSceneSection>();
			for (int i = 0; i < tarray.Num(); i++)
			{
				TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(tarray.Get(i));
				for (int j = 0; j < sections.Num(); j++)
				{
					list.Add(sections.Get(j));
				}
			}
			if (list.Count == 0)
			{
				return -1f;
			}
			float result = 0f;
			FFrameTime frame = new FFrameTime(new FFrameNumber(frameNumber), 0f);
			foreach (UMovieSceneSection umovieSceneSection in list)
			{
				UMovieSceneFadeSection umovieSceneFadeSection = umovieSceneSection as UMovieSceneFadeSection;
				if (UKuroSequenceRuntimeFunctionLibrary.SectionContains(umovieSceneFadeSection, frame))
				{
					result = ((umovieSceneFadeSection.FloatCurve.Times.Num() == 0 && !umovieSceneFadeSection.FloatCurve.bHasDefaultValue) ? -1f : UKuroSequenceRuntimeFunctionLibrary.GetFadeAmountAt(umovieSceneFadeSection, frame));
					break;
				}
			}
			return result;
		}

		// Token: 0x060348E6 RID: 215270 RVA: 0x00C67108 File Offset: 0x00C65308
		private void ReadFadeEnd()
		{
			if (this.Model.SequenceData.GeneratedData == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "使用了最终黑幕，却没有后处理", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			for (int i = 0; i < this.Model.SequenceData.GeneratedData.IsFadeEnd.Num(); i++)
			{
				this.Model.IsFadeEnd.Add(this.Model.SequenceData.GeneratedData.IsFadeEnd.Get(i));
			}
		}

		// Token: 0x060348E7 RID: 215271 RVA: 0x00C67194 File Offset: 0x00C65394
		private void ReadFinalPos()
		{
			if (this.Model.SequenceData.GeneratedData != null)
			{
				TArray<FTransform> finalPos = this.Model.SequenceData.GeneratedData.FinalPos;
				int num = finalPos.Num();
				int i = 0;
				while (i < num)
				{
					FTransform ftransform = finalPos.Get(i);
					Rotator rotator = Rotator.Create(ftransform.Rotator());
					global::Vector inT = global::Vector.Create(ftransform.GetLocation());
					EPlotSequenceType? type = this.Model.GetType();
					EPlotSequenceType eplotSequenceType = EPlotSequenceType.过场;
					if (type.GetValueOrDefault() == eplotSequenceType & type != null)
					{
						goto IL_B1;
					}
					type = this.Model.GetType();
					eplotSequenceType = EPlotSequenceType.其他;
					if (type.GetValueOrDefault() == eplotSequenceType & type != null)
					{
						goto IL_B1;
					}
					IL_C4:
					this.Model.AddFinalPos(Transform.Create(rotator.Quaternion(null), inT, global::Vector.OneVectorProxy));
					i++;
					continue;
					IL_B1:
					rotator.Yaw += 90f;
					goto IL_C4;
				}
				return;
			}
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.ZWY, "使用了最终位置，但是没有后处理位置。", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060348E8 RID: 215272 RVA: 0x00C672AD File Offset: 0x00C654AD
		public void JumpToNextSubtitleOrChildSeq()
		{
			this.GoToNextSubtitleOrChildSeq(false);
		}

		// Token: 0x060348E9 RID: 215273 RVA: 0x00C672B6 File Offset: 0x00C654B6
		public void AccelerateToNextSubtitleOrChildSeq(Action finishCallback)
		{
			this.AccelerateFinishCallback = finishCallback;
			this.GoToNextSubtitleOrChildSeq(true);
		}

		// Token: 0x060348EA RID: 215274 RVA: 0x00C672C6 File Offset: 0x00C654C6
		public void ClearAccelerateCallback()
		{
			this.AccelerateFinishCallback = null;
		}

		// Token: 0x060348EB RID: 215275 RVA: 0x00C672D0 File Offset: 0x00C654D0
		private void GoToNextSubtitleOrChildSeq(bool useAccelerate)
		{
			if (this.Model.IsPaused.GetValueOrDefault())
			{
				this.Model.NeedJumpWhenResume = true;
				return;
			}
			this.Model.NeedJumpWhenResume = false;
			ULevelSequencePlayer sequencePlayer = this.Model.CurLevelSeqActor.SequencePlayer;
			int value = sequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
			int? nextSubtitleOrChildSeqTargetFrame = this.GetNextSubtitleOrChildSeqTargetFrame(value);
			if (nextSubtitleOrChildSeqTargetFrame == null)
			{
				if (useAccelerate)
				{
					this.StopAcceleratingSkip();
				}
				return;
			}
			int value2 = nextSubtitleOrChildSeqTargetFrame.Value;
			int num = value2;
			int? curEndFrame = this.Model.CurEndFrame;
			if (num == curEndFrame.GetValueOrDefault() & curEndFrame != null)
			{
				this.StopAcceleratingSkip();
				this.JumpToSequenceEnd(value, sequencePlayer);
				return;
			}
			if (value2 > value)
			{
				int num2 = value2;
				curEndFrame = this.Model.CurEndFrame;
				if (num2 < curEndFrame.GetValueOrDefault() & curEndFrame != null)
				{
					if (useAccelerate)
					{
						this.AccelerateSequenceToFrame(value, value2, sequencePlayer);
						return;
					}
					this.StopAcceleratingSkip();
					this.SequenceJumpToFrame(value2, EUpdatePositionMethod.Play, true);
					return;
				}
			}
			if (useAccelerate)
			{
				this.StopAcceleratingSkip();
			}
		}

		// Token: 0x060348EC RID: 215276 RVA: 0x00C673D0 File Offset: 0x00C655D0
		private int? GetNextSubtitleOrChildSeqTargetFrame(int curFrame)
		{
			int num = 99999999;
			foreach (int num2 in this.Model.CurSubtitleStartFrames)
			{
				if (num2 == curFrame)
				{
					return null;
				}
				if (num2 > curFrame)
				{
					num = num2;
					break;
				}
			}
			int val = 99999999;
			foreach (int num3 in this.Model.CurShotStartFrames)
			{
				if (num3 > curFrame)
				{
					val = num3;
					break;
				}
			}
			int num4;
			if (!(this.Model.GetType() != EPlotSequenceType.站桩))
			{
				num4 = num;
			}
			else
			{
				num4 = Math.Min(num, val);
			}
			if (num4 != 0 && num4 != 99999999)
			{
				int num5 = num4;
				int? curEndFrame = this.Model.CurEndFrame;
				if (!(num5 >= curEndFrame.GetValueOrDefault() & curEndFrame != null))
				{
					return new int?(num4);
				}
			}
			return this.Model.CurEndFrame;
		}

		// Token: 0x060348ED RID: 215277 RVA: 0x00C6750C File Offset: 0x00C6570C
		private void JumpToSequenceEnd(int curFrame, UMovieSceneSequencePlayer sequencePlayer)
		{
			int value = this.Model.CurEndFrame.Value;
			if (!this.Model.WillFinish())
			{
				sequencePlayer.OnStop.Clear();
				sequencePlayer.GoToEndAndStop(EUpdatePositionMethod.Play);
				if (this.OnStopCallBack != null)
				{
					SequenceController.Instance.FlushDialogueState();
					this.Model.TwiceAnimFlag = true;
					this.OnStopCallBack();
					this.Model.TwiceAnimFlag = false;
				}
				return;
			}
			float num = (float)(this.Model.CurEndFrame.Value - curFrame) / this.Model.CurFrameRate.Value;
			float? endLeastTime = this.Model.EndLeastTime;
			if (num > endLeastTime.GetValueOrDefault() & endLeastTime != null)
			{
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "SequenceJumpToEnd", null, new object[]
				{
					this.Model.EndLeastTime
				});
				FlowController.Instance.EnableSkip(false);
				this.LastSubtitleDelay = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.LastSubtitleDelay = null;
					sequencePlayer.GoToEndAndStop(EUpdatePositionMethod.Play);
				}, this.Model.EndLeastTime.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			}
		}

		// Token: 0x060348EE RID: 215278 RVA: 0x00C67658 File Offset: 0x00C65858
		private void AccelerateSequenceToFrame(int curFrame, int targetFrame, UMovieSceneSequencePlayer sequencePlayer)
		{
			float value = this.AcceleratingSkipRecoverPlayRate.GetValueOrDefault();
			if (this.AcceleratingSkipRecoverPlayRate == null)
			{
				value = sequencePlayer.GetPlayRate();
				this.AcceleratingSkipRecoverPlayRate = new float?(value);
			}
			this.AcceleratingSkipTargetFrame = new int?(targetFrame);
			this.IsAcceleratingSkipPaused = false;
			this.AddAcceleratingSkipDelegates(sequencePlayer);
			float playRate = this.AcceleratingSkipRecoverPlayRate.Value * PlotModel.Instance.PlotGlobalConfig.EntitySequenceAccelerateRate;
			sequencePlayer.SetPlayRate(playRate);
			sequencePlayer.PlayTo(this.CreatePlaybackParams(targetFrame, EUpdatePositionMethod.Play));
		}

		// Token: 0x060348EF RID: 215279 RVA: 0x00C676DC File Offset: 0x00C658DC
		private void OnAcceleratingSkipPause()
		{
			int? acceleratingSkipTargetFrame = this.AcceleratingSkipTargetFrame;
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			ULevelSequencePlayer ulevelSequencePlayer = (curLevelSeqActor != null) ? curLevelSeqActor.SequencePlayer : null;
			if (acceleratingSkipTargetFrame == null || this.Model.State != ESequenceState.Playing || ulevelSequencePlayer == null)
			{
				return;
			}
			int value = ulevelSequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
			if (this.IsAcceleratingSkipPaused)
			{
				return;
			}
			if (value < acceleratingSkipTargetFrame.Value)
			{
				this.PauseAcceleratingSkip();
				return;
			}
			this.StopAcceleratingSkip();
			ulevelSequencePlayer.Play();
		}

		// Token: 0x060348F0 RID: 215280 RVA: 0x00C6775F File Offset: 0x00C6595F
		private void OnAcceleratingSkipPlay()
		{
			if (!this.IsAcceleratingSkipPaused || this.Model.IsPaused.GetValueOrDefault())
			{
				return;
			}
			this.ResumeAcceleratingSkip();
		}

		// Token: 0x060348F1 RID: 215281 RVA: 0x00C67782 File Offset: 0x00C65982
		private void AddAcceleratingSkipDelegates(UMovieSceneSequencePlayer sequencePlayer)
		{
			if (this.IsAcceleratingSkipDelegateBound)
			{
				return;
			}
			this.IsAcceleratingSkipDelegateBound = true;
			sequencePlayer.OnPause.Add(new Action(this.OnAcceleratingSkipPause));
			sequencePlayer.OnPlay.Add(new Action(this.OnAcceleratingSkipPlay));
		}

		// Token: 0x060348F2 RID: 215282 RVA: 0x00C677C4 File Offset: 0x00C659C4
		private void RemoveAcceleratingSkipDelegates()
		{
			if (!this.IsAcceleratingSkipDelegateBound)
			{
				return;
			}
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			ULevelSequencePlayer ulevelSequencePlayer = (curLevelSeqActor != null) ? curLevelSeqActor.SequencePlayer : null;
			if (ulevelSequencePlayer != null)
			{
				ulevelSequencePlayer.OnPause.Remove(new Action(this.OnAcceleratingSkipPause));
			}
			if (ulevelSequencePlayer != null)
			{
				ulevelSequencePlayer.OnPlay.Remove(new Action(this.OnAcceleratingSkipPlay));
			}
			this.IsAcceleratingSkipDelegateBound = false;
		}

		// Token: 0x060348F3 RID: 215283 RVA: 0x00C67834 File Offset: 0x00C65A34
		private void StopAcceleratingSkip()
		{
			float? acceleratingSkipRecoverPlayRate = this.AcceleratingSkipRecoverPlayRate;
			this.AcceleratingSkipTargetFrame = null;
			this.AcceleratingSkipRecoverPlayRate = null;
			this.IsAcceleratingSkipPaused = false;
			Action accelerateFinishCallback = this.AccelerateFinishCallback;
			if (accelerateFinishCallback != null)
			{
				accelerateFinishCallback();
			}
			this.AccelerateFinishCallback = null;
			this.RemoveAcceleratingSkipDelegates();
			if (acceleratingSkipRecoverPlayRate != null)
			{
				ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
				if (curLevelSeqActor == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.SetPlayRate(acceleratingSkipRecoverPlayRate.Value);
			}
		}

		// Token: 0x060348F4 RID: 215284 RVA: 0x00C678B4 File Offset: 0x00C65AB4
		private void PauseAcceleratingSkip()
		{
			float? acceleratingSkipRecoverPlayRate = this.AcceleratingSkipRecoverPlayRate;
			if (this.AcceleratingSkipTargetFrame == null || acceleratingSkipRecoverPlayRate == null)
			{
				return;
			}
			this.IsAcceleratingSkipPaused = true;
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			if (curLevelSeqActor == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(acceleratingSkipRecoverPlayRate.Value);
		}

		// Token: 0x060348F5 RID: 215285 RVA: 0x00C6790C File Offset: 0x00C65B0C
		private void ResumeAcceleratingSkip()
		{
			int? acceleratingSkipTargetFrame = this.AcceleratingSkipTargetFrame;
			float? acceleratingSkipRecoverPlayRate = this.AcceleratingSkipRecoverPlayRate;
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			ULevelSequencePlayer ulevelSequencePlayer = (curLevelSeqActor != null) ? curLevelSeqActor.SequencePlayer : null;
			if (acceleratingSkipTargetFrame == null || acceleratingSkipRecoverPlayRate == null || ulevelSequencePlayer == null)
			{
				return;
			}
			if (ulevelSequencePlayer.GetCurrentTime().Time.FrameNumber.Value >= acceleratingSkipTargetFrame.Value)
			{
				this.StopAcceleratingSkip();
				return;
			}
			this.IsAcceleratingSkipPaused = false;
			ulevelSequencePlayer.SetPlayRate(acceleratingSkipRecoverPlayRate.Value * PlotModel.Instance.PlotGlobalConfig.EntitySequenceAccelerateRate);
			ulevelSequencePlayer.PlayTo(this.CreatePlaybackParams(acceleratingSkipTargetFrame.Value, EUpdatePositionMethod.Play));
		}

		// Token: 0x060348F6 RID: 215286 RVA: 0x00C679B4 File Offset: 0x00C65BB4
		private void SequenceJumpToFrame(int targetFrame, EUpdatePositionMethod updatePositionMethod = EUpdatePositionMethod.Play, bool noEval = true)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				return;
			}
			if (noEval)
			{
				this.Model.CurLevelSeqActor.SequencePlayer.SetPlaybackPositionWithNoEval(this.CreatePlaybackParams(targetFrame, updatePositionMethod));
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
			this.Model.CurLevelSeqActor.SequencePlayer.SetPlaybackPosition(this.CreatePlaybackParams(targetFrame, updatePositionMethod));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
		}

		// Token: 0x060348F7 RID: 215287 RVA: 0x00C67A2E File Offset: 0x00C65C2E
		private FMovieSceneSequencePlaybackParams CreatePlaybackParams(int targetFrame, EUpdatePositionMethod updatePositionMethod = EUpdatePositionMethod.Play)
		{
			return new FMovieSceneSequencePlaybackParams(new FFrameTime(new FFrameNumber(targetFrame), 0f), 0f, "", EMovieScenePositionType.Frame, updatePositionMethod);
		}

		// Token: 0x060348F8 RID: 215288 RVA: 0x00C67A54 File Offset: 0x00C65C54
		[NullableContext(2)]
		public void PauseSequence(string reason = null)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "剧情Sequence未开始播放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Model.CurLevelSeqActor.SequencePlayer.IsPlaying())
			{
				this.PauseAcceleratingSkip();
				this.Model.CurLevelSeqActor.SequencePlayer.PauseOnNextFrame();
			}
			this.Model.PauseFrame = new int?(this.Model.CurLevelSeqActor.SequencePlayer.GetCurrentTime().Time.FrameNumber.Value);
			this.Model.IsPaused = new bool?(true);
			if (reason != null)
			{
				this.PauseReasonSet.Add(reason);
			}
		}

		// Token: 0x060348F9 RID: 215289 RVA: 0x00C67B14 File Offset: 0x00C65D14
		[NullableContext(2)]
		public void ResumeSequence(string reason = null, bool? goToNextFrame = null)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "剧情Sequence未开始播放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.NeedGoToNextFrameWhenResume = (this.NeedGoToNextFrameWhenResume || goToNextFrame.GetValueOrDefault());
			if (reason != null)
			{
				this.PauseReasonSet.Remove(reason);
			}
			if (this.PauseReasonSet.Count > 0)
			{
				return;
			}
			bool needGoToNextFrameWhenResume = this.NeedGoToNextFrameWhenResume;
			this.NeedGoToNextFrameWhenResume = false;
			if (this.Model.CurLevelSeqActor.SequencePlayer.IsPaused())
			{
				this.Model.CurLevelSeqActor.SequencePlayer.Play();
			}
			this.Model.IsPaused = new bool?(false);
			if (this.Model.NeedJumpWhenResume)
			{
				this.GoToNextSubtitleOrChildSeq(false);
			}
			else
			{
				if (needGoToNextFrameWhenResume && this.Model.PauseFrame != null)
				{
					this.SequenceJumpToFrame(this.Model.PauseFrame.Value + 1, EUpdatePositionMethod.Play, false);
				}
				this.ResumeAcceleratingSkip();
			}
			this.Model.PauseFrame = null;
		}

		// Token: 0x060348FA RID: 215290 RVA: 0x00C67C2C File Offset: 0x00C65E2C
		private void ReadDataRuntime()
		{
			ULevelSequence ulevelSequence = this.Model.SequenceData.剧情资源.Get(this.Model.SubSeqIndex);
			TArray<UMovieSceneTrack> masterTracks = ulevelSequence.MovieScene.MasterTracks;
			int num = (masterTracks != null) ? masterTracks.Num() : 0;
			FFrameRate tickResolution = ulevelSequence.MovieScene.TickResolution;
			FFrameRate displayRate = ulevelSequence.MovieScene.DisplayRate;
			float num2 = 1f * (float)(displayRate.Denominator * tickResolution.Numerator) / (float)(displayRate.Numerator * tickResolution.Denominator);
			for (int i = 0; i < num; i++)
			{
				UMovieSceneTrack umovieSceneTrack = masterTracks.Get(i);
				if (!umovieSceneTrack.bIsEvalDisabled)
				{
					if (umovieSceneTrack is UMovieSceneDialogueTrack)
					{
						TArray<UMovieSceneSection> sections = ((UMovieSceneDialogueTrack)umovieSceneTrack).Sections;
						int num3 = (sections != null) ? sections.Num() : 0;
						for (int j = 0; j < num3; j++)
						{
							UMovieSceneSection umovieSceneSection = sections.Get(j);
							if (umovieSceneSection is UMovieSceneDialogueSection)
							{
								UMovieSceneDialogueSection umovieSceneDialogueSection = umovieSceneSection as UMovieSceneDialogueSection;
								this.Model.CurSubtitleStartFrames.Add((int)((float)umovieSceneDialogueSection.GetStartFrame().Value.Value / num2));
								this.Model.CurSubtitleEndFrames.Add((int)((float)umovieSceneDialogueSection.GetEndFrame().Value.Value / num2));
							}
						}
					}
					else if (umovieSceneTrack is UMovieSceneDialogueStateTrack)
					{
						if (!umovieSceneTrack.bIsEvalDisabled)
						{
							TArray<UMovieSceneSection> sections2 = ((UMovieSceneDialogueStateTrack)umovieSceneTrack).Sections;
							int num4 = (sections2 != null) ? sections2.Num() : 0;
							for (int k = 0; k < num4; k++)
							{
								UMovieSceneSection umovieSceneSection2 = sections2.Get(k);
								if (umovieSceneSection2 is UMovieSceneDialogueStateSection)
								{
									UMovieSceneDialogueStateSection umovieSceneDialogueStateSection = umovieSceneSection2 as UMovieSceneDialogueStateSection;
									if (umovieSceneDialogueStateSection.SectionData.State == EDialogueStateEnum.SkipTarget)
									{
										this.Model.CurSubtitleStartFrames.Add((int)((float)umovieSceneDialogueStateSection.GetStartFrame().Value.Value / num2));
										this.Model.CurSubtitleEndFrames.Add((int)((float)umovieSceneDialogueStateSection.GetEndFrame().Value.Value / num2));
									}
								}
							}
						}
					}
					else if (umovieSceneTrack is UMovieSceneSubTrack)
					{
						TArray<UMovieSceneSection> sections3 = ((UMovieSceneSubTrack)umovieSceneTrack).Sections;
						int num5 = (sections3 != null) ? sections3.Num() : 0;
						for (int l = 0; l < num5; l++)
						{
							UMovieSceneSection umovieSceneSection3 = sections3.Get(l);
							if (umovieSceneSection3 is UMovieSceneSubSection)
							{
								UMovieSceneSubSection umovieSceneSubSection = umovieSceneSection3 as UMovieSceneSubSection;
								this.Model.CurShotStartFrames.Add((int)((float)umovieSceneSubSection.GetStartFrame().Value.Value / num2));
								this.Model.CurShotEndFrames.Add((int)((float)umovieSceneSubSection.GetEndFrame().Value.Value / num2));
							}
						}
					}
					else if (umovieSceneTrack is UMovieSceneQteTrack)
					{
						TArray<UMovieSceneSection> sections4 = ((UMovieSceneQteTrack)umovieSceneTrack).Sections;
						int num6 = sections4.Num();
						for (int m = 0; m < num6; m++)
						{
							UMovieSceneSection umovieSceneSection4 = sections4.Get(m);
							if (umovieSceneSection4 != null)
							{
								if (umovieSceneSection4 is UMovieSceneQteSection)
								{
									UMovieSceneQteSection umovieSceneQteSection = umovieSceneSection4 as UMovieSceneQteSection;
									this.Model.QteKeyFrames.Add((int)((float)umovieSceneQteSection.GetStartFrame().Value.Value / num2));
								}
								else if (umovieSceneSection4 is UMovieSceneQteTriggerSection)
								{
									TArray<FFrameNumber> keyTimes = ((UMovieSceneQteTriggerSection)umovieSceneSection4).DataChannel.KeyTimes;
									int num7 = keyTimes.Num();
									for (int n = 0; n < num7; n++)
									{
										FFrameNumber fframeNumber = keyTimes.Get(n);
										this.Model.QteKeyFrames.Add((int)((float)fframeNumber.Value / num2));
									}
								}
							}
						}
					}
				}
			}
			EPlotSequenceType? type = this.Model.GetType();
			EPlotSequenceType eplotSequenceType = EPlotSequenceType.站桩;
			if (type.GetValueOrDefault() == eplotSequenceType & type != null)
			{
				this.Model.CurShotStartFrames.Clear();
				this.Model.CurShotEndFrames.Clear();
				List<int> shotSectionFrames = this.GetShotSectionFrames(ulevelSequence);
				this.Model.CurShotStartFrames.Add(0);
				if (shotSectionFrames != null)
				{
					foreach (int item in shotSectionFrames)
					{
						this.Model.CurShotStartFrames.Add(item);
					}
				}
				this.Model.CurShotStartFrames.RemoveAt(this.Model.CurShotStartFrames.Count - 1);
				if (shotSectionFrames != null)
				{
					foreach (int item2 in shotSectionFrames)
					{
						this.Model.CurShotEndFrames.Add(item2);
					}
				}
			}
			this.Model.CurSubtitleStartFrames.Sort((int a, int b) => a - b);
			this.Model.CurSubtitleEndFrames.Sort((int a, int b) => a - b);
			this.Model.CurShotStartFrames.Sort((int a, int b) => a - b);
			this.Model.CurShotEndFrames.Sort((int a, int b) => a - b);
			this.Model.QteKeyFrames.Sort((int a, int b) => a - b);
		}

		// Token: 0x060348FB RID: 215291 RVA: 0x00C681EC File Offset: 0x00C663EC
		[return: Nullable(2)]
		private unsafe List<int> GetShotSectionFrames(ULevelSequence inSeq)
		{
			List<int> list = new List<int>();
			if (!ObjectUtils.IsValid(inSeq))
			{
				return null;
			}
			UMovieSceneSubTrack umovieSceneSubTrack = null;
			TArray<UMovieSceneTrack> masterTracks = UKuroSequenceRuntimeFunctionLibrary.GetMasterTracks(inSeq);
			for (int i = 0; i < masterTracks.Num(); i++)
			{
				UMovieSceneTrack umovieSceneTrack = masterTracks.Get(i);
				if (umovieSceneTrack is UMovieSceneSubTrack)
				{
					umovieSceneSubTrack = (umovieSceneTrack as UMovieSceneSubTrack);
					break;
				}
			}
			if (umovieSceneSubTrack == null)
			{
				return null;
			}
			TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(umovieSceneSubTrack);
			for (int j = 0; j < sections.Num(); j++)
			{
				UMovieSceneSubSection umovieSceneSubSection = sections.Get(j) as UMovieSceneSubSection;
				ULevelSequence ulevelSequence = umovieSceneSubSection.GetSequence() as ULevelSequence;
				int value = umovieSceneSubSection.GetStartFrame().Value.Value;
				int value2 = umovieSceneSubSection.GetEndFrame().Value.Value;
				int value3 = umovieSceneSubSection.Parameters.StartFrameOffset.Value;
				TArray<FSequencerBindingRuntimeProxy> spawnables = UKuroSequenceRuntimeFunctionLibrary.GetSpawnables(ulevelSequence);
				for (int k = 0; k < spawnables.Num(); k++)
				{
					FSequencerBindingRuntimeProxy fsequencerBindingRuntimeProxy = spawnables.Get(k);
					UObject objectTemplate = UKuroSequenceRuntimeFunctionLibrary.GetObjectTemplate(fsequencerBindingRuntimeProxy);
					if (objectTemplate == null)
					{
						string item = null;
						TArray<FMovieSceneSpawnable> spawnables2 = ulevelSequence.MovieScene.Spawnables;
						for (int l = 0; l < spawnables2.Num(); l++)
						{
							FMovieSceneSpawnable fmovieSceneSpawnable = spawnables2.Get(l);
							if (fmovieSceneSpawnable.Guid.ToString() == fsequencerBindingRuntimeProxy.BindingID.ToString())
							{
								item = fmovieSceneSpawnable.Name;
								break;
							}
						}
						FlowController instance = FlowController.Instance;
						string text = "Seq内存在IsEditorOnly";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", fsequencerBindingRuntimeProxy.BindingID);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", item);
						instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						if (!Info.Instance.IsBuildShipping)
						{
							ScrollingTipsController.Instance.ShowTipsByText("当前Seq内存在IsEditorOnly组件");
						}
					}
					else if (objectTemplate.GetClass() == ACineCameraActor.StaticClass())
					{
						TArray<UMovieSceneTrack> tracks = UKuroSequenceRuntimeFunctionLibrary.GetTracks(fsequencerBindingRuntimeProxy);
						for (int m = 0; m < tracks.Num(); m++)
						{
							UMovieSceneTrack umovieSceneTrack2 = tracks.Get(m);
							if (umovieSceneTrack2.GetClass() == UMovieScene3DTransformTrack.StaticClass())
							{
								TArray<UMovieSceneSection> sections2 = UKuroSequenceRuntimeFunctionLibrary.GetSections(umovieSceneTrack2);
								for (int n = 0; n < sections2.Num(); n++)
								{
									int num = sections2.Get(n).GetEndFrame().Value.Value - value3 + value - UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(ulevelSequence);
									if (num > value && num <= value2)
									{
										list.Add(num);
									}
									else if (num > value2)
									{
										list.Add(value2);
									}
								}
								break;
							}
						}
						break;
					}
				}
			}
			list.Sort((int a, int b) => a - b);
			return list;
		}

		// Token: 0x060348FC RID: 215292 RVA: 0x00C684D8 File Offset: 0x00C666D8
		private void ReadFinalPositionRuntime()
		{
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			for (int i = 0; i < sequenceData.剧情资源.Num(); i++)
			{
				ULevelSequence ulevelSequence = sequenceData.剧情资源.Get(i);
				FTransform? ftransform = null;
				BP_SequenceData_Generated_C generatedData = sequenceData.GeneratedData;
				if (generatedData != null && generatedData.IsCustomizedFinalPos)
				{
					ftransform = this.GetFinalPosition(ulevelSequence, SequenceDefine.FINAL_POS_TAG);
				}
				else
				{
					ULevelSequence sequence = ulevelSequence;
					BP_SequenceData_Generated_C generatedData2 = sequenceData.GeneratedData;
					ftransform = this.GetFinalPosition(sequence, FNameUtil.IsNothing((generatedData2 != null) ? new FName?(generatedData2.BlendOutTag) : null) ? SequenceDefine.HERO_TAG : sequenceData.GeneratedData.BlendOutTag);
				}
				if (ftransform == null)
				{
					this.Model.CurFinalPos.Add(null);
				}
				else
				{
					Rotator rotator = Rotator.Create(ftransform.Value.Rotator());
					global::Vector vector = global::Vector.Create(ftransform.Value.GetLocation());
					if (sequenceData.类型 == EPlotSequenceType.过场 || sequenceData.类型 == EPlotSequenceType.其他)
					{
						rotator.Yaw += 90f;
					}
					if (vector.IsNearlyZero(9.999999747378752E-05))
					{
						FlowController instance = FlowController.Instance;
						string text = "Seq最终位置提取到0点坐标";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", ulevelSequence);
						instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					Transform trans = Transform.Create(rotator.Quaternion(null), vector, global::Vector.OneVectorProxy);
					this.Model.AddFinalPos(trans);
				}
			}
		}

		// Token: 0x060348FD RID: 215293 RVA: 0x00C68670 File Offset: 0x00C66870
		public FTransform? GetFinalPosition(ULevelSequence sequence, FName targetTag)
		{
			FFrameTime fframeTime = new FFrameTime(new FFrameNumber(UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(sequence)), 0f);
			FFrameTime fframeTime2 = new FFrameTime(new FFrameNumber(UKuroSequenceRuntimeFunctionLibrary.GetPlaybackEnd(sequence) - 1), 0f);
			Transform transform = Transform.Create();
			if (this.GetSequenceLastTransform(sequence, targetTag, fframeTime, fframeTime2, transform))
			{
				return new FTransform?(transform.ToUeTransformOld());
			}
			TArray<UMovieSceneTrack> tarray = UKuroSequenceRuntimeFunctionLibrary.FindMasterTracksByType(sequence, UMovieSceneCinematicShotTrack.StaticClass());
			UMovieSceneTrack umovieSceneTrack = (tarray.Num() > 0) ? tarray.Get(0) : null;
			if (!ObjectUtils.IsValid(umovieSceneTrack))
			{
				return null;
			}
			TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(umovieSceneTrack);
			int num = sections.Num();
			List<UMovieSceneCinematicShotSection> list = new List<UMovieSceneCinematicShotSection>();
			for (int i = 0; i < num; i++)
			{
				UMovieSceneCinematicShotSection umovieSceneCinematicShotSection = sections.Get(i) as UMovieSceneCinematicShotSection;
				UMovieSceneSequence sequence2 = umovieSceneCinematicShotSection.GetSequence();
				if (ObjectUtils.IsValid(sequence2) && sequence2.FindBindingByTag(targetTag).Guid.IsValid())
				{
					int value = umovieSceneCinematicShotSection.GetStartFrame().Value.Value;
					int value2 = umovieSceneCinematicShotSection.GetEndFrame().Value.Value;
					if (value <= fframeTime2.FrameNumber.Value && value2 > fframeTime.FrameNumber.Value)
					{
						list.Add(umovieSceneCinematicShotSection);
					}
				}
			}
			list.Sort((UMovieSceneCinematicShotSection a, UMovieSceneCinematicShotSection b) => b.GetEndFrame().Value.Value - a.GetEndFrame().Value.Value);
			FFrameTime fframeTime3 = new FFrameTime();
			FFrameTime fframeTime4 = new FFrameTime();
			foreach (UMovieSceneCinematicShotSection umovieSceneCinematicShotSection2 in list)
			{
				ULevelSequence sequence3 = umovieSceneCinematicShotSection2.GetSequence() as ULevelSequence;
				int num2 = (UKuroSequenceRuntimeFunctionLibrary.GetStartFrame(umovieSceneCinematicShotSection2) < fframeTime.FrameNumber.Value) ? (fframeTime.FrameNumber.Value - UKuroSequenceRuntimeFunctionLibrary.GetStartFrame(umovieSceneCinematicShotSection2)) : 0;
				int value3 = umovieSceneCinematicShotSection2.Parameters.StartFrameOffset.Value + UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(sequence3) + num2;
				int num3 = (UKuroSequenceRuntimeFunctionLibrary.GetEndFrame(umovieSceneCinematicShotSection2) - 1 > fframeTime2.FrameNumber.Value) ? (fframeTime2.FrameNumber.Value - UKuroSequenceRuntimeFunctionLibrary.GetStartFrame(umovieSceneCinematicShotSection2)) : (UKuroSequenceRuntimeFunctionLibrary.GetEndFrame(umovieSceneCinematicShotSection2) - UKuroSequenceRuntimeFunctionLibrary.GetStartFrame(umovieSceneCinematicShotSection2) - 1);
				int value4 = umovieSceneCinematicShotSection2.Parameters.StartFrameOffset.Value + UKuroSequenceRuntimeFunctionLibrary.GetPlaybackStart(sequence3) + num3;
				fframeTime3.FrameNumber.Value = value3;
				fframeTime4.FrameNumber.Value = value4;
				if (this.GetSequenceLastTransform(sequence3, targetTag, fframeTime3, fframeTime4, transform))
				{
					return new FTransform?(transform.ToUeTransformOld());
				}
			}
			return null;
		}

		// Token: 0x060348FE RID: 215294 RVA: 0x00C68938 File Offset: 0x00C66B38
		public bool GetSequenceLastTransform(ULevelSequence sequence, FName tag, FFrameTime beginFrame, FFrameTime endFrame, Transform outTransform)
		{
			TArray<FMovieSceneObjectBindingID> tarray = sequence.FindBindingsByTag(tag);
			FSequencerBindingRuntimeProxy fsequencerBindingRuntimeProxy = null;
			for (int i = 0; i < tarray.Num(); i++)
			{
				FMovieSceneObjectBindingID fmovieSceneObjectBindingID = tarray.Get(i);
				fsequencerBindingRuntimeProxy = UKuroSequenceRuntimeFunctionLibrary.FindBindingById(sequence, fmovieSceneObjectBindingID.Guid);
				if (fsequencerBindingRuntimeProxy.BindingID.IsValid())
				{
					break;
				}
				fsequencerBindingRuntimeProxy = null;
			}
			if (fsequencerBindingRuntimeProxy == null)
			{
				return false;
			}
			TArray<UMovieSceneTrack> tarray2 = UKuroSequenceRuntimeFunctionLibrary.FindTracksByType(fsequencerBindingRuntimeProxy, UMovieScene3DTransformTrack.StaticClass());
			if (tarray2.Num() != 1)
			{
				return false;
			}
			FFrameTime fframeTime = null;
			UMovieSceneTrack track = tarray2.Get(0);
			TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(track);
			for (int j = 0; j < sections.Num(); j++)
			{
				UMovieScene3DTransformSection umovieScene3DTransformSection = sections.Get(j) as UMovieScene3DTransformSection;
				if (UKuroSequenceRuntimeFunctionLibrary.SectionContains(umovieScene3DTransformSection, endFrame))
				{
					fframeTime = endFrame;
					break;
				}
				FFrameNumberRangeBound endFrame2 = umovieScene3DTransformSection.GetEndFrame();
				FFrameNumberRangeBound startFrame = umovieScene3DTransformSection.GetStartFrame();
				if (!(endFrame2.Type == ERangeBoundTypes.Open) && endFrame2.Value.Value > beginFrame.FrameNumber.Value && startFrame.Value.Value <= endFrame.FrameNumber.Value)
				{
					if (fframeTime == null)
					{
						fframeTime = new FFrameTime(new FFrameNumber(endFrame2.Value.Value - 1), 0f);
					}
					else if (endFrame2.Value.Value - 1 > fframeTime.FrameNumber.Value)
					{
						fframeTime.FrameNumber.Value = endFrame2.Value.Value - 1;
					}
				}
			}
			if (fframeTime != null)
			{
				FTransform frameTransform = UKuroSequenceRuntimeFunctionLibrary.GetFrameTransform(track, fframeTime);
				outTransform.FromUeTransform(frameTransform);
				return true;
			}
			return false;
		}

		// Token: 0x060348FF RID: 215295 RVA: 0x00C68AE4 File Offset: 0x00C66CE4
		[NullableContext(2)]
		private bool CheckSequenceConstrainAspect(ULevelSequence levelSequence)
		{
			if (levelSequence == null)
			{
				return false;
			}
			TArray<UMovieSceneTrack> tarray = UKuroSequenceRuntimeFunctionLibrary.FindMasterTracksByType(levelSequence, UMovieSceneCinematicShotTrack.StaticClass());
			UMovieSceneTrack umovieSceneTrack = (tarray != null && tarray.Num() > 0) ? tarray.Get(0) : null;
			if (!ObjectUtils.IsValid(umovieSceneTrack))
			{
				return false;
			}
			TArray<UMovieSceneSection> sections = UKuroSequenceRuntimeFunctionLibrary.GetSections(umovieSceneTrack);
			int num = sections.Num();
			List<UMovieSceneCinematicShotSection> list = new List<UMovieSceneCinematicShotSection>();
			for (int i = 0; i < num; i++)
			{
				UMovieSceneCinematicShotSection item = sections.Get(i) as UMovieSceneCinematicShotSection;
				list.Add(item);
			}
			ULevelSequence ulevelSequence = null;
			foreach (UMovieSceneCinematicShotSection umovieSceneCinematicShotSection in list)
			{
				ulevelSequence = (umovieSceneCinematicShotSection.GetSequence() as ULevelSequence);
			}
			if (ulevelSequence == null)
			{
				return false;
			}
			FMovieSceneBinding fmovieSceneBinding = this.FindChildBindingByFatherTag(ulevelSequence, SequenceDefine.CAMERA_TAG);
			if (fmovieSceneBinding == null)
			{
				return false;
			}
			bool result = false;
			TArray<UMovieSceneTrack> tracks = fmovieSceneBinding.Tracks;
			for (int j = 0; j < tracks.Num(); j++)
			{
				UMovieSceneTrack umovieSceneTrack2 = tracks.Get(j);
				if (umovieSceneTrack2 is UMovieSceneBoolTrack)
				{
					UMovieSceneBoolTrack umovieSceneBoolTrack = umovieSceneTrack2 as UMovieSceneBoolTrack;
					if (umovieSceneBoolTrack != null)
					{
						result = false;
						for (int k = 0; k < umovieSceneBoolTrack.Sections.Num(); k++)
						{
							UMovieSceneSection umovieSceneSection = umovieSceneBoolTrack.Sections.Get(k);
							if (umovieSceneSection != null)
							{
								UMovieSceneBoolSection umovieSceneBoolSection = umovieSceneSection as UMovieSceneBoolSection;
								if (umovieSceneBoolSection != null)
								{
									FMovieSceneBoolChannel boolCurve = umovieSceneBoolSection.BoolCurve;
									if (boolCurve != null && boolCurve.bHasDefaultValue)
									{
										FMovieSceneBoolChannel boolCurve2 = umovieSceneBoolSection.BoolCurve;
										result = (boolCurve2 != null && boolCurve2.DefaultValue);
									}
									else
									{
										result = true;
										int num2 = 0;
										for (;;)
										{
											int num3 = num2;
											FMovieSceneBoolChannel boolCurve3 = umovieSceneBoolSection.BoolCurve;
											int? num4 = (boolCurve3 != null) ? new int?(boolCurve3.Values.Num()) : null;
											if (!(num3 < num4.GetValueOrDefault() & num4 != null))
											{
												goto IL_1D7;
											}
											FMovieSceneBoolChannel boolCurve4 = umovieSceneBoolSection.BoolCurve;
											if (boolCurve4 != null && !boolCurve4.Values.Get(num2))
											{
												break;
											}
											num2++;
										}
										result = false;
									}
								}
							}
							IL_1D7:;
						}
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06034900 RID: 215296 RVA: 0x00C68D0C File Offset: 0x00C66F0C
		[return: Nullable(2)]
		private FMovieSceneBinding FindChildBindingByFatherTag(ULevelSequence levelSequence, FName tag)
		{
			TArray<FMovieSceneSpawnable> spawnables = levelSequence.MovieScene.Spawnables;
			int num = spawnables.Num();
			List<FMovieSceneBinding> list = this.FindObjectBindingByTag(levelSequence, tag);
			if (list == null || list.Count <= 0)
			{
				return null;
			}
			FMovieSceneSpawnable fmovieSceneSpawnable = null;
			for (int i = 0; i < num; i++)
			{
				if (this.CompareGuid(spawnables.Get(i).Guid, list[0].ObjectGuid))
				{
					fmovieSceneSpawnable = spawnables.Get(i);
					break;
				}
			}
			if (fmovieSceneSpawnable == null)
			{
				return null;
			}
			TArray<FMovieScenePossessable> possessables = levelSequence.MovieScene.Possessables;
			FMovieScenePossessable fmovieScenePossessable = null;
			for (int j = 0; j < possessables.Num(); j++)
			{
				FMovieScenePossessable fmovieScenePossessable2 = possessables.Get(j);
				if (this.CompareGuid(fmovieScenePossessable2.ParentGuid, fmovieSceneSpawnable.Guid))
				{
					fmovieScenePossessable = fmovieScenePossessable2;
					break;
				}
			}
			if (fmovieScenePossessable == null)
			{
				return null;
			}
			return this.FindGuidInBinding(levelSequence, fmovieScenePossessable.Guid);
		}

		// Token: 0x06034901 RID: 215297 RVA: 0x00C68DF4 File Offset: 0x00C66FF4
		[return: Nullable(2)]
		private FMovieSceneBinding FindGuidInBinding(ULevelSequence levelSequence, FGuid a)
		{
			TArray<FMovieSceneBinding> objectBindings = levelSequence.MovieScene.ObjectBindings;
			FMovieSceneBinding result = null;
			for (int i = 0; i < objectBindings.Num(); i++)
			{
				FMovieSceneBinding fmovieSceneBinding = objectBindings.Get(i);
				if (this.CompareGuid(a, fmovieSceneBinding.ObjectGuid))
				{
					result = fmovieSceneBinding;
					break;
				}
			}
			return result;
		}

		// Token: 0x06034902 RID: 215298 RVA: 0x00C68E3C File Offset: 0x00C6703C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<FMovieSceneBinding> FindObjectBindingByTag(ULevelSequence levelSequence, FName tag)
		{
			FMovieSceneObjectBindingIDs fmovieSceneObjectBindingIDs;
			levelSequence.MovieScene.BindingGroups.TryGetValue(tag, out fmovieSceneObjectBindingIDs);
			List<FMovieSceneBinding> list = new List<FMovieSceneBinding>();
			if (fmovieSceneObjectBindingIDs != null)
			{
				TArray<FMovieSceneObjectBindingID> ids = fmovieSceneObjectBindingIDs.IDs;
				int num = (ids != null) ? ids.Num() : 0;
				for (int i = 0; i < num; i++)
				{
					FMovieSceneObjectBindingID fmovieSceneObjectBindingID = ids.Get(i);
					TArray<FMovieSceneBinding> objectBindings = levelSequence.MovieScene.ObjectBindings;
					int num2 = objectBindings.Num();
					for (int j = 0; j < num2; j++)
					{
						FMovieSceneBinding fmovieSceneBinding = objectBindings.Get(j);
						if (this.CompareGuid(fmovieSceneBinding.ObjectGuid, fmovieSceneObjectBindingID.Guid))
						{
							list.Add(fmovieSceneBinding);
						}
					}
				}
			}
			if (list.Count > 0)
			{
				return list;
			}
			return null;
		}

		// Token: 0x06034903 RID: 215299 RVA: 0x00C68EF6 File Offset: 0x00C670F6
		private bool CompareGuid(FGuid a, FGuid b)
		{
			return a.A == b.A && a.B == b.B && a.C == b.C && a.D == b.D;
		}

		// Token: 0x06034904 RID: 215300 RVA: 0x00C68F34 File Offset: 0x00C67134
		[NullableContext(2)]
		public override void LoadNecessaryData(Action callback = null)
		{
			this.SeqDataLoadingId = ResourceSystem.Instance.LoadAsync<BP_SequenceData_C>(this.Model.Config.Path, delegate([Nullable(2)] BP_SequenceData_C data, string _)
			{
				this.SeqDataLoadingId = -1;
				if (!ObjectUtils.IsValid(data))
				{
					Action callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2();
					return;
				}
				else
				{
					this.Model.SequenceData = data;
					this.SeqDataLoadingId = -1;
					this.Model.SubSeqLen = new int?(this.Model.SequenceData.剧情资源.Num());
					this.Model.LastIndex = 0;
					this.Model.SubSeqIndex = 0;
					this.Model.NextIndex = 0;
					this.ReadOriginTransform();
					if (this.Model.UseRuntimeData)
					{
						this.ReadFadeEndRuntime();
					}
					else
					{
						this.ReadFadeEnd();
					}
					if (this.Model.SequenceData.SaveFinalTransform)
					{
						if (this.Model.UseRuntimeData)
						{
							this.ReadFinalPositionRuntime();
						}
						else
						{
							this.ReadFinalPos();
						}
					}
					EPlotSequenceType? type = this.Model.Type;
					EPlotSequenceType eplotSequenceType = EPlotSequenceType.过场;
					if (type.GetValueOrDefault() == eplotSequenceType & type != null)
					{
						global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "过场生成SubSeuqenceMap", default(ReadOnlySpan<ValueTuple<string, object>>));
						this.MakeSubSequenceMap();
					}
					Action callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3();
					return;
				}
			}, 100, "js_undefined");
		}

		// Token: 0x06034905 RID: 215301 RVA: 0x00C68F88 File Offset: 0x00C67188
		public bool ReadNeedHidePlayer()
		{
			ULevelSequence currentSequence = SequenceModel.Instance.GetCurrentSequence();
			if (currentSequence == null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "读取现在的Seq失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			SubSeqInfo subSeqInfo;
			if (!this.SubSequenceMap.TryGetValue(currentSequence, out subSeqInfo))
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "不存在的subInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
			int? num;
			if (curLevelSeqActor == null)
			{
				num = null;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				num = ((sequencePlayer != null) ? new int?(sequencePlayer.GetCurrentTime().Time.FrameNumber.Value) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return false;
			}
			for (int i = 0; i < subSeqInfo.EndFrameArray.Count; i++)
			{
				int num3 = subSeqInfo.EndFrameArray[i];
				int? num4 = num2;
				int num5 = num3;
				if (num4.GetValueOrDefault() < num5 & num4 != null)
				{
					return !subSeqInfo.HavePlayerArray[i];
				}
			}
			return false;
		}

		// Token: 0x06034906 RID: 215302 RVA: 0x00C69098 File Offset: 0x00C67298
		private void MakeSubSequenceMap()
		{
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			this.SubSequenceMap.Clear();
			TArray<ULevelSequence> 剧情资源 = sequenceData.剧情资源;
			for (int i = 0; i < 剧情资源.Num(); i++)
			{
				ULevelSequence sequence = 剧情资源.Get(i);
				this.UpdateSubSequenceMap(sequence);
			}
		}

		// Token: 0x06034907 RID: 215303 RVA: 0x00C690E4 File Offset: 0x00C672E4
		private void UpdateSubSequenceMap(ULevelSequence sequence)
		{
			TArray<UMovieSceneTrack> masterTracks = sequence.MovieScene.MasterTracks;
			int num = masterTracks.Num();
			for (int i = 0; i < num; i++)
			{
				UMovieSceneSubTrack umovieSceneSubTrack = masterTracks.Get(i) as UMovieSceneSubTrack;
				if (umovieSceneSubTrack != null)
				{
					TArray<UMovieSceneSection> sections = umovieSceneSubTrack.Sections;
					int num2 = sections.Num();
					SubSeqInfo subSeqInfo = new SubSeqInfo();
					for (int j = 0; j < num2; j++)
					{
						UMovieSceneSubSection umovieSceneSubSection = sections.Get(j) as UMovieSceneSubSection;
						if (umovieSceneSubSection != null)
						{
							if (umovieSceneSubSection.SubSequence == null)
							{
								global::Log instance = global::Log.Instance;
								ELogModule module = ELogModule.Plot;
								ELogAuthor author = ELogAuthor.JYS;
								string message = "失效的SubSequence";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", umovieSceneSubSection);
								instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							}
							else
							{
								bool item = umovieSceneSubSection.SubSequence.FindBindingByTag(SequenceDefine.HERO_TAG).Guid.IsValid();
								subSeqInfo.HavePlayerArray.Add(item);
								subSeqInfo.EndFrameArray.Add(umovieSceneSubSection.GetEndFrame().Value.Value);
							}
						}
					}
					this.SubSequenceMap[sequence] = subSeqInfo;
				}
			}
		}

		// Token: 0x0401C00A RID: 114698
		private static readonly FName CONSTRAIN = new FName("bConstrainAspectRatio");

		// Token: 0x0401C00B RID: 114699
		private const int MAX_FRAME = 99999999;

		// Token: 0x0401C00C RID: 114700
		private int SeqDataLoadingId = -1;

		// Token: 0x0401C00D RID: 114701
		[Nullable(2)]
		private TimerHandle LastSubtitleDelay;

		// Token: 0x0401C00E RID: 114702
		private bool IsSequencePlay;

		// Token: 0x0401C00F RID: 114703
		[Nullable(2)]
		private Action OnStopCallBack;

		// Token: 0x0401C010 RID: 114704
		private int AspectLoadingTime;

		// Token: 0x0401C011 RID: 114705
		private readonly HashSet<string> PauseReasonSet = new HashSet<string>();

		// Token: 0x0401C012 RID: 114706
		private bool NeedGoToNextFrameWhenResume;

		// Token: 0x0401C013 RID: 114707
		private readonly Dictionary<ULevelSequence, SubSeqInfo> SubSequenceMap = new Dictionary<ULevelSequence, SubSeqInfo>();

		// Token: 0x0401C014 RID: 114708
		private int? AcceleratingSkipTargetFrame;

		// Token: 0x0401C015 RID: 114709
		private float? AcceleratingSkipRecoverPlayRate;

		// Token: 0x0401C016 RID: 114710
		private bool IsAcceleratingSkipPaused;

		// Token: 0x0401C017 RID: 114711
		private bool IsAcceleratingSkipDelegateBound;

		// Token: 0x0401C018 RID: 114712
		[Nullable(2)]
		private Action AccelerateFinishCallback;
	}
}
