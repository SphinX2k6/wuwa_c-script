using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005031 RID: 20529
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionAssistant : SeqBaseAssistant
	{
		// Token: 0x060348A6 RID: 215206 RVA: 0x00C647F8 File Offset: 0x00C629F8
		[NullableContext(2)]
		public override void Load(Action<bool> callback)
		{
			List<int> pbDataIds = this.ParseFrameEvent(this.Model.Config.FrameEvents);
			this.SetFrameEvents(this.Model.Config.FrameEvents);
			this.WaitFunctionEntityTask = WaitEntityTask.CreateWithPbDataId("FunctionAssistant.Load", pbDataIds, delegate(bool? result)
			{
				this.WaitFunctionEntityTask = null;
				callback(result.GetValueOrDefault());
			}, 60000, true, false);
		}

		// Token: 0x060348A7 RID: 215207 RVA: 0x00C6486A File Offset: 0x00C62A6A
		[NullableContext(2)]
		public override void PreAllPlay(Action<bool> callback = null)
		{
			this.ShowLogoTimer = null;
			PlotModel.Instance.PlotTimeOfDay.OnSeqStart();
		}

		// Token: 0x060348A8 RID: 215208 RVA: 0x00C64882 File Offset: 0x00C62A82
		[NullableContext(2)]
		public override void AllStop(Action<bool> callback = null)
		{
			this.Model.FrameEvents.Clear();
		}

		// Token: 0x060348A9 RID: 215209 RVA: 0x00C64894 File Offset: 0x00C62A94
		public override void End()
		{
			if (this.WaitFunctionEntityTask != null)
			{
				this.WaitFunctionEntityTask.Cancel();
			}
			if (this.ShowLogoTimer != null)
			{
				this.ShowLogoTimer.Remove();
				UiManager.Instance.CloseView(EUiViewName.PlotLogoView, null);
			}
			PlotModel.Instance.PlotWeather.StopAllWeather();
			PlotModel.Instance.PlotTimeOfDay.OnSeqEnd();
			this.Model.FrameEvents.Clear();
			this.RemoveDirector();
		}

		// Token: 0x060348AA RID: 215210 RVA: 0x00C6490C File Offset: 0x00C62B0C
		private List<int> ParseFrameEvent([Nullable(new byte[]
		{
			2,
			1
		})] List<ISequenceFrameEvent> inEvents)
		{
			List<int> list = new List<int>();
			if (inEvents == null || inEvents.Count == 0)
			{
				return list;
			}
			foreach (ISequenceFrameEvent sequenceFrameEvent in inEvents)
			{
				if (sequenceFrameEvent.EventActions != null && sequenceFrameEvent.EventActions.Count != 0)
				{
					foreach (ActionInfo actionInfo in sequenceFrameEvent.EventActions)
					{
						List<int> list2 = null;
						EAction name = actionInfo.Name;
						if (name != EAction.AwakeEntity)
						{
							if (name == EAction.ChangeEntityState)
							{
								ChangeEntityState changeEntityState = actionInfo.Params as ChangeEntityState;
								switch (changeEntityState.Type)
								{
								case EChangeEntityState.Directly:
									list2 = new List<int>
									{
										changeEntityState.EntityId
									};
									break;
								case EChangeEntityState.BatchDirectly:
									list2 = ((IChangeEntityStateBatchDirectly)changeEntityState).EntityIds;
									break;
								case EChangeEntityState.Loop:
									list2 = new List<int>
									{
										changeEntityState.EntityId
									};
									break;
								}
							}
						}
						else
						{
							list2 = (actionInfo.Params as AwakeEntity).EntityIds;
						}
						if (list2 != null && list2.Count > 0)
						{
							foreach (int item in list2)
							{
								list.Add(item);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060348AB RID: 215211 RVA: 0x00C64AD4 File Offset: 0x00C62CD4
		public void SetFrameEvents([Nullable(new byte[]
		{
			2,
			1
		})] List<ISequenceFrameEvent> events)
		{
			if (events == null || events.Count == 0)
			{
				return;
			}
			foreach (ISequenceFrameEvent sequenceFrameEvent in events)
			{
				this.Model.FrameEvents[sequenceFrameEvent.EventKey] = sequenceFrameEvent.EventActions;
				this.Model.ActionQueue.Push(sequenceFrameEvent.EventKey);
			}
		}

		// Token: 0x060348AC RID: 215212 RVA: 0x00C64B5C File Offset: 0x00C62D5C
		public void RunSequenceFrameEvents(string key)
		{
			if (this.Model.State == ESequenceState.Ending)
			{
				return;
			}
			List<ActionInfo> frameEvents = this.Model.GetFrameEvents(key);
			if (this.Model.ActionQueue == null || this.Model.ActionQueue.Size <= 0)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "ActionQueue为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Model.ActionQueue.Pop() != key)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "编辑器与Seq帧事件顺序不一致，可能会导致跳过的表现错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (frameEvents == null || frameEvents.Count == 0)
			{
				FlowController instance = FlowController.Instance;
				string text = "没有找到对应的帧事件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FlowController.Instance.ExecuteSubActions(frameEvents, delegate(bool _)
			{
			}, true);
			int num = 0;
			foreach (KeyValuePair<int, HashSet<string>> keyValuePair in this.Model.FrameEventsMap)
			{
				int key2 = keyValuePair.Key;
				if (keyValuePair.Value.Contains(key))
				{
					num = key2;
				}
			}
			if (num != 0)
			{
				this.Model.FrameEventsMap.Remove(num);
			}
		}

		// Token: 0x060348AD RID: 215213 RVA: 0x00C64CC8 File Offset: 0x00C62EC8
		public void ShowLogo(float time)
		{
			int num = (int)(time * 1000f);
			if (num < 20)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "展示logo时间过短，不展示", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PlotLogoView, null, null);
			this.ShowLogoTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				UiManager.Instance.CloseView(EUiViewName.PlotLogoView, null);
				this.ShowLogoTimer = null;
			}, (float)num, null, null, true, 1f);
		}

		// Token: 0x060348AE RID: 215214 RVA: 0x00C64D38 File Offset: 0x00C62F38
		public UniTask OpenBackgroundImage(string uiName, string spineName, bool needLoop = true, bool useFullscreenAdaptAnchor = false)
		{
			FunctionAssistant.<OpenBackgroundImage>d__10 <OpenBackgroundImage>d__;
			<OpenBackgroundImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenBackgroundImage>d__.<>4__this = this;
			<OpenBackgroundImage>d__.uiName = uiName;
			<OpenBackgroundImage>d__.spineName = spineName;
			<OpenBackgroundImage>d__.needLoop = needLoop;
			<OpenBackgroundImage>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
			<OpenBackgroundImage>d__.<>1__state = -1;
			<OpenBackgroundImage>d__.<>t__builder.Start<FunctionAssistant.<OpenBackgroundImage>d__10>(ref <OpenBackgroundImage>d__);
			return <OpenBackgroundImage>d__.<>t__builder.Task;
		}

		// Token: 0x060348AF RID: 215215 RVA: 0x00C64D9C File Offset: 0x00C62F9C
		public UniTask OpenBackgroundImageInArray(string uiName, TArray<SpineThingsInfo> spineArray, bool useFullscreenAdaptAnchor = false)
		{
			FunctionAssistant.<OpenBackgroundImageInArray>d__11 <OpenBackgroundImageInArray>d__;
			<OpenBackgroundImageInArray>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenBackgroundImageInArray>d__.<>4__this = this;
			<OpenBackgroundImageInArray>d__.uiName = uiName;
			<OpenBackgroundImageInArray>d__.spineArray = spineArray;
			<OpenBackgroundImageInArray>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
			<OpenBackgroundImageInArray>d__.<>1__state = -1;
			<OpenBackgroundImageInArray>d__.<>t__builder.Start<FunctionAssistant.<OpenBackgroundImageInArray>d__11>(ref <OpenBackgroundImageInArray>d__);
			return <OpenBackgroundImageInArray>d__.<>t__builder.Task;
		}

		// Token: 0x060348B0 RID: 215216 RVA: 0x00C64DF8 File Offset: 0x00C62FF8
		public UniTask PlayUiLevelSequence(string seqName)
		{
			FunctionAssistant.<PlayUiLevelSequence>d__12 <PlayUiLevelSequence>d__;
			<PlayUiLevelSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUiLevelSequence>d__.seqName = seqName;
			<PlayUiLevelSequence>d__.<>1__state = -1;
			<PlayUiLevelSequence>d__.<>t__builder.Start<FunctionAssistant.<PlayUiLevelSequence>d__12>(ref <PlayUiLevelSequence>d__);
			return <PlayUiLevelSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060348B1 RID: 215217 RVA: 0x00C64E3C File Offset: 0x00C6303C
		public UniTask CloseBackgroundImage()
		{
			FunctionAssistant.<CloseBackgroundImage>d__13 <CloseBackgroundImage>d__;
			<CloseBackgroundImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseBackgroundImage>d__.<>1__state = -1;
			<CloseBackgroundImage>d__.<>t__builder.Start<FunctionAssistant.<CloseBackgroundImage>d__13>(ref <CloseBackgroundImage>d__);
			return <CloseBackgroundImage>d__.<>t__builder.Task;
		}

		// Token: 0x060348B2 RID: 215218 RVA: 0x00C64E78 File Offset: 0x00C63078
		public void PlaySpineAnim(string spineName, bool needLoop = true)
		{
			if (string.IsNullOrEmpty(spineName))
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:SpineName为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("PlaySpineAnim", delegate(PlotSubtitleView view)
			{
				view.PlaySonUiSpine(spineName, needLoop, false, 0f);
				return UniTask.CompletedTask;
			}, null);
		}

		// Token: 0x060348B3 RID: 215219 RVA: 0x00C64EE8 File Offset: 0x00C630E8
		public void PlaySpineAnimInArray(TArray<SpineThingsInfo> spineArray)
		{
			if (spineArray.Num() <= 0)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:spineArray为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("PlaySpineAnimInArray", delegate(PlotSubtitleView view)
			{
				view.PlaySonUiSpineInArray(spineArray);
				return UniTask.CompletedTask;
			}, null);
		}

		// Token: 0x060348B4 RID: 215220 RVA: 0x00C64F50 File Offset: 0x00C63150
		public void CloseSpineAnimation(string str)
		{
			PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("CloseSpineAnimation", delegate(PlotSubtitleView view)
			{
				view.CloseSpineAnimation(str, 0f);
				return UniTask.CompletedTask;
			}, null);
		}

		// Token: 0x060348B5 RID: 215221 RVA: 0x00C64F8C File Offset: 0x00C6318C
		public void CloseSpineAnimationInArray(TArray<string> stringArray)
		{
			if (stringArray.Num() <= 0)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:未填入数组，关闭失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PlotController.Instance.PlotViewManager.RunWithPlotSubtitleView("CloseSpineAnimationInArray", delegate(PlotSubtitleView view)
			{
				for (int i = 0; i < stringArray.Num(); i++)
				{
					view.CloseSpineAnimation(stringArray.Get(i), 0f);
				}
				return UniTask.CompletedTask;
			}, null);
		}

		// Token: 0x060348B6 RID: 215222 RVA: 0x00C64FF4 File Offset: 0x00C631F4
		public unsafe void AdditionSeqPlay(ULevelSequence levelSequence, FName componentName, FName boneName, int frame)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[额外Seq播放]AdditionSeqPlay:";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelSequence", levelSequence);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("boneName", boneName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("frame", frame);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.AdditionGenerateDirector(levelSequence, componentName, boneName, frame);
		}

		// Token: 0x060348B7 RID: 215223 RVA: 0x00C65084 File Offset: 0x00C63284
		public void AdditionSeqEnd()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[额外Seq播放]AdditionSeqEnd:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelSequence", this.Model.AdditionSeqDirector);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.Model.AdditionSeqDirector != null && this.Model.AdditionSeqDirector.SequencePlayer != null)
			{
				ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
				TArray<UObject> tarray = (curLevelSeqActor != null) ? curLevelSeqActor.GetBindingByTag(new FName("Dart"), true) : null;
				if (tarray != null)
				{
					for (int i = 0; i < tarray.Num(); i++)
					{
						AActor aactor = tarray.Get(i) as AActor;
						if (aactor != null && aactor.GetWorld() != null)
						{
							aactor.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
						}
					}
				}
				this.RemoveDirector();
			}
		}

		// Token: 0x060348B8 RID: 215224 RVA: 0x00C65140 File Offset: 0x00C63340
		private void RemoveDirector()
		{
			ALevelSequenceActor additionSeqDirector = this.Model.AdditionSeqDirector;
			if (additionSeqDirector == null || !additionSeqDirector.IsValid())
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "[额外Seq播放]AdditionGenerateDirector 销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			ActorSystem.Instance.Put("AdditionSeqEnd", additionSeqDirector, null);
			this.Model.AdditionSeqDirector = null;
		}

		// Token: 0x060348B9 RID: 215225 RVA: 0x00C651A0 File Offset: 0x00C633A0
		private void AdditionGenerateDirector(ULevelSequence levelSequence, FName componentName, FName boneName, int frame = 0)
		{
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bDisableMovementInput = false;
			fmovieSceneSequencePlaybackSettings.bDisableLookAtInput = false;
			if (this.Model.AdditionSeqDirector != null)
			{
				if (this.Model.AdditionSeqDirector.GetSequence() != levelSequence)
				{
					this.AdditionSeqEnd();
					this.Model.AdditionSeqDirector = ActorSystem.Instance.Spawn<ALevelSequenceActor>(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null);
				}
			}
			else
			{
				this.Model.AdditionSeqDirector = ActorSystem.Instance.Spawn<ALevelSequenceActor>(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null);
			}
			ULevelSequencePlayer sequencePlayer = this.Model.AdditionSeqDirector.SequencePlayer;
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "[额外Seq播放]AdditionGenerateDirector 没找到Player", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Model.AdditionSeqDirector.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.Model.AdditionSeqDirector.SetSequence(levelSequence);
			sequencePlayer.Play();
			sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(new FFrameTime(new FFrameNumber(frame), 0f), 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play));
			TArray<UObject> bindingByTag = this.Model.AdditionSeqDirector.GetBindingByTag(new FName("Target"), true);
			if (bindingByTag.Num() <= 0)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "[额外Seq播放]AdditionGenerateDirector 获取绑定目标 Target", default(ReadOnlySpan<ValueTuple<string, object>>));
				ULevelSequencePlayer sequencePlayer2 = this.Model.AdditionSeqDirector.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.Stop();
				return;
			}
			else
			{
				AActor aactor = bindingByTag.Get(0) as AActor;
				ALevelSequenceActor curLevelSeqActor = this.Model.CurLevelSeqActor;
				TArray<UObject> tarray = (curLevelSeqActor != null) ? curLevelSeqActor.GetBindingByTag(new FName("Dart"), true) : null;
				if (tarray != null && tarray.Num() > 0)
				{
					for (int i = 0; i < tarray.Num(); i++)
					{
						UObject uobject = tarray.Get(i);
						if (uobject != null)
						{
							AActor aactor2 = uobject as AActor;
							if (aactor2 != null)
							{
								if (aactor2.GetWorld() != null)
								{
									TArray<UActorComponent> tarray2 = aactor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
									USkeletalMeshComponent uskeletalMeshComponent = null;
									for (int j = 0; j < tarray2.Num(); j++)
									{
										USkeletalMeshComponent uskeletalMeshComponent2 = tarray2.Get(j) as USkeletalMeshComponent;
										if (uskeletalMeshComponent2 != null && uskeletalMeshComponent2.GetFName() == componentName)
										{
											global::Log instance = global::Log.Instance;
											ELogModule module = ELogModule.Plot;
											ELogAuthor author = ELogAuthor.JYS;
											string message = "[额外Seq播放]找到了skeletalComp";
											ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skeletalCompName", uskeletalMeshComponent2);
											instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
											uskeletalMeshComponent = uskeletalMeshComponent2;
											break;
										}
									}
									if (uskeletalMeshComponent != null)
									{
										aactor2.K2_AttachToComponent(uskeletalMeshComponent, boneName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepWorld, false, true);
									}
									else
									{
										aactor2.K2_AttachToActor(aactor, boneName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepWorld, false, true);
									}
								}
								else
								{
									global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "[额外Seq播放]AdditionGenerateDirector actor NotValid", default(ReadOnlySpan<ValueTuple<string, object>>));
								}
							}
						}
					}
					return;
				}
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "[额外Seq播放]AdditionGenerateDirector 获取不到要绑定的物品 Dart", default(ReadOnlySpan<ValueTuple<string, object>>));
				ULevelSequencePlayer sequencePlayer3 = this.Model.AdditionSeqDirector.SequencePlayer;
				if (sequencePlayer3 == null)
				{
					return;
				}
				sequencePlayer3.Stop();
				return;
			}
		}

		// Token: 0x0401BFFD RID: 114685
		[Nullable(2)]
		private WaitEntityTask WaitFunctionEntityTask;

		// Token: 0x0401BFFE RID: 114686
		[Nullable(2)]
		private TimerHandle ShowLogoTimer;
	}
}
