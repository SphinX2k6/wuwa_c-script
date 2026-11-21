using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FEF RID: 16367
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceQteManager
	{
		// Token: 0x060296D3 RID: 169683 RVA: 0x00BAA57C File Offset: 0x00BA877C
		public void Init()
		{
			this.AfterTickHandleId = PlotController.Instance.AddAfterTick(new Action<float>(this.OnTick));
			UMovieSceneDialogueSubsystem umovieSceneDialogueSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UMovieSceneDialogueSubsystem.StaticClass()) as UMovieSceneDialogueSubsystem;
			this.QteManager = ((umovieSceneDialogueSubsystem != null) ? umovieSceneDialogueSubsystem.GetQteManager() : null);
			if (!ObjectUtils.IsValid(this.QteManager))
			{
				FlowController.Instance.LogError("QteManager异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.QteManager = null;
			}
		}

		// Token: 0x060296D4 RID: 169684 RVA: 0x00BAA600 File Offset: 0x00BA8800
		public void Clear()
		{
			PlotController.Instance.RemoveAfterTick(this.AfterTickHandleId);
			if (this.CurrentSequenceQte.Count > 0)
			{
				foreach (KeyValuePair<int, ISequenceCommonQteHandle> keyValuePair in this.CurrentSequenceQte)
				{
					int key = keyValuePair.Key;
					keyValuePair.Value.ForceStopSequenceQte();
				}
			}
			this.CurrentSequenceQte.Clear();
			this.CollectPendingStartQteIds();
			this.ReleasePendingQtes();
			this.PendingOptionResult.Clear();
			this.PendingQteEventQueue.Clear();
			this.PendingFinishQteQueue.Clear();
			this.QteManager = null;
		}

		// Token: 0x060296D5 RID: 169685 RVA: 0x00BAA6C0 File Offset: 0x00BA88C0
		public void EnqueueQteStart(FMovieSceneQteEventParam param)
		{
			this.PendingQteEventQueue.Push(new SequenceQteManager.PendingQteStartEvent
			{
				Type = SequenceQteManager.EQtePendingEventType.Start,
				Data = this.CreateQteStartData(param)
			});
		}

		// Token: 0x060296D6 RID: 169686 RVA: 0x00BAA6E6 File Offset: 0x00BA88E6
		public void EnqueueQteAnimEnd(int qteId)
		{
			this.PendingQteEventQueue.Push(new SequenceQteManager.PendingQteAnimEndEvent
			{
				Type = SequenceQteManager.EQtePendingEventType.AnimEnd,
				QteId = qteId
			});
		}

		// Token: 0x060296D7 RID: 169687 RVA: 0x00BAA706 File Offset: 0x00BA8906
		public void EnqueueQteRelease(int qteId)
		{
			this.PendingReleaseQteIds.Add(qteId);
		}

		// Token: 0x060296D8 RID: 169688 RVA: 0x00BAA718 File Offset: 0x00BA8918
		private SequenceQteManager.ISequenceQteStartData CreateQteStartData(FMovieSceneQteEventParam param)
		{
			bool flag = !param.IsTriggerType;
			FFrameTime startFrame = null;
			FFrameTime fframeTime = null;
			if (flag)
			{
				startFrame = new FFrameTime
				{
					FrameNumber = param.StartFrame.FrameNumber,
					SubFrame = param.StartFrame.SubFrame
				};
				fframeTime = new FFrameTime
				{
					FrameNumber = param.EndFrame.FrameNumber,
					SubFrame = param.EndFrame.SubFrame
				};
				fframeTime.FrameNumber.Value--;
			}
			return new SequenceQteManager.SequenceQteStartData
			{
				QteId = param.QteId,
				SubtitleId = param.SubtitleId,
				IsProgress = flag,
				IsGroupQte = param.IsGroupQte,
				StartFrame = startFrame,
				EndFrame = fframeTime,
				AttachActor = param.AttachActor,
				SpineInfo = QteSpineInfoProxy.CreateQteSpineInfo(param.SpineInfo),
				IsUpdateWithProgress = param.IsUpdateWithProgress,
				SubQteParams = this.CreateSubQteParams(param.SubQteParams)
			};
		}

		// Token: 0x060296D9 RID: 169689 RVA: 0x00BAA814 File Offset: 0x00BA8A14
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MovieSceneSubQteParamsProxy> CreateSubQteParams([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FMovieSceneSubQteParams> @params)
		{
			if (@params == null || @params.Num() <= 0)
			{
				return null;
			}
			List<MovieSceneSubQteParamsProxy> list = new List<MovieSceneSubQteParamsProxy>();
			for (int i = 0; i < @params.Num(); i++)
			{
				FMovieSceneSubQteParams fmovieSceneSubQteParams = @params.Get(i);
				list.Add(new MovieSceneSubQteParamsProxy(fmovieSceneSubQteParams.SubQteId, QteSpineInfoProxy.CreateQteSpineInfo(fmovieSceneSubQteParams.SpineInfo)));
			}
			return list;
		}

		// Token: 0x060296DA RID: 169690 RVA: 0x00BAA86C File Offset: 0x00BA8A6C
		private void StartSequenceQte(SequenceQteManager.ISequenceQteStartData data)
		{
			if (this.CurrentSequenceQte.Count > 0)
			{
				foreach (KeyValuePair<int, ISequenceCommonQteHandle> keyValuePair in this.CurrentSequenceQte)
				{
					keyValuePair.Value.ForceStopSequenceQte();
				}
				this.CurrentSequenceQte.Clear();
			}
			ISequenceCommonQteHandle sequenceCommonQteHandle = this.CreateQte(data.QteId, data.SubtitleId, data.IsProgress, data.IsGroupQte, data.StartFrame, data.EndFrame, data.AttachActor, data.SpineInfo, data.SubQteParams, new bool?(data.IsUpdateWithProgress));
			if (sequenceCommonQteHandle == null)
			{
				UMovieSceneQteManager qteManager = this.QteManager;
				if (qteManager != null)
				{
					qteManager.FinishQte(data.QteId);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[FlowSequence][PlotQte] Sequence Qte 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", data.QteId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			sequenceCommonQteHandle.SetEventSpineComponents(this.GetEventSpineComponents());
			this.CurrentSequenceQte[data.QteId] = sequenceCommonQteHandle;
			sequenceCommonQteHandle.OnBegin();
			if (SequenceModel.Instance.IsPlaying)
			{
				if (sequenceCommonQteHandle.IsProgressQte)
				{
					ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
					if (curLevelSeqActor != null)
					{
						ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
						if (sequencePlayer != null)
						{
							sequencePlayer.PauseOnNextFrame();
						}
					}
				}
				else
				{
					SequenceController.Instance.PauseSequence("QTE");
				}
			}
			this.PlayDirection = SequenceQteManager.EDirection.Pause;
			FlowController.Instance.EnableSkip(false);
			PlotController.Instance.PlotViewManager.EnableInteractPlot(false, new bool?(true), "SequenceQte");
		}

		// Token: 0x060296DB RID: 169691 RVA: 0x00BAAA08 File Offset: 0x00BA8C08
		private List<USpineSkeletonAnimationComponent> GetEventSpineComponents()
		{
			List<USpineSkeletonAnimationComponent> list = new List<USpineSkeletonAnimationComponent>();
			HashSet<USpineSkeletonAnimationComponent> hashSet = new HashSet<USpineSkeletonAnimationComponent>();
			int num = 0;
			int num2 = 0;
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			TArray<UObject> tarray = (curLevelSeqActor != null) ? curLevelSeqActor.GetBindingByTag(SequenceQteManager.EventSpineAnimTag, true) : null;
			if (tarray == null || tarray.Num() == 0)
			{
				return list;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				AActor aactor = tarray.Get(i) as AActor;
				if (aactor == null || !ObjectUtils.IsValid(aactor))
				{
					num++;
				}
				else
				{
					TArray<UActorComponent> tarray2 = aactor.K2_GetComponentsByClass(USpineSkeletonAnimationComponent.StaticClass());
					if (tarray2.Num() == 0)
					{
						num2++;
					}
					for (int j = 0; j < tarray2.Num(); j++)
					{
						USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent = tarray2.Get(j) as USpineSkeletonAnimationComponent;
						if (uspineSkeletonAnimationComponent != null && ObjectUtils.IsValid(uspineSkeletonAnimationComponent) && hashSet.Add(uspineSkeletonAnimationComponent))
						{
							list.Add(uspineSkeletonAnimationComponent);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060296DC RID: 169692 RVA: 0x00BAAAF8 File Offset: 0x00BA8CF8
		private void OnSequenceAnimFinished(int qteId)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(qteId, out sequenceCommonQteHandle))
			{
				return;
			}
			sequenceCommonQteHandle.OnSequenceAnimFinished();
		}

		// Token: 0x060296DD RID: 169693 RVA: 0x00BAAB1C File Offset: 0x00BA8D1C
		public void OnSequenceQteFinished(int qteId)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(qteId, out sequenceCommonQteHandle))
			{
				return;
			}
			if (sequenceCommonQteHandle.SubtitleId != -1)
			{
				this.PendingOptionResult[sequenceCommonQteHandle.SubtitleId] = sequenceCommonQteHandle.OptionIndex;
			}
			this.PendingFinishQteQueue.Push(qteId);
		}

		// Token: 0x060296DE RID: 169694 RVA: 0x00BAAB68 File Offset: 0x00BA8D68
		private void HandleFinishSequenceQte(int qteId)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(qteId, out sequenceCommonQteHandle))
			{
				return;
			}
			if (SequenceModel.Instance.IsPlaying)
			{
				if (sequenceCommonQteHandle.IsProgressQte)
				{
					ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
					ULevelSequencePlayer ulevelSequencePlayer = (curLevelSeqActor != null) ? curLevelSeqActor.SequencePlayer : null;
					if (ulevelSequencePlayer != null)
					{
						ulevelSequencePlayer.CleanPauseOnFrame();
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
					if (ulevelSequencePlayer != null)
					{
						ulevelSequencePlayer.Play();
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
				else
				{
					this.FinishSequenceAnim(qteId);
					SequenceController.Instance.ResumeSequence("QTE", null);
				}
			}
			sequenceCommonQteHandle.OnFinish();
			FlowController.Instance.EnableSkip(true);
			PlotController.Instance.PlotViewManager.EnableInteractPlot(true, new bool?(true), "SequenceQte");
			this.CurrentSequenceQte.Remove(qteId);
		}

		// Token: 0x060296DF RID: 169695 RVA: 0x00BAAC44 File Offset: 0x00BA8E44
		private void OnTick(float delta)
		{
			this.ReleasePendingQtes();
			this.HandlePendingQteEvents();
			if (this.CurrentSequenceQte.Count <= 0)
			{
				goto IL_69;
			}
			using (Dictionary<int, ISequenceCommonQteHandle>.Enumerator enumerator = this.CurrentSequenceQte.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, ISequenceCommonQteHandle> keyValuePair = enumerator.Current;
					keyValuePair.Value.OnTick(delta);
				}
				goto IL_69;
			}
			IL_56:
			int qteId = this.PendingFinishQteQueue.Pop();
			this.HandleFinishSequenceQte(qteId);
			IL_69:
			if (this.PendingFinishQteQueue.Size <= 0)
			{
				return;
			}
			goto IL_56;
		}

		// Token: 0x060296E0 RID: 169696 RVA: 0x00BAACD8 File Offset: 0x00BA8ED8
		private void CollectPendingStartQteIds()
		{
			while (this.PendingQteEventQueue.Size > 0)
			{
				SequenceQteManager.TPendingQteEvent tpendingQteEvent = this.PendingQteEventQueue.Pop();
				if (tpendingQteEvent != null && tpendingQteEvent.Type == SequenceQteManager.EQtePendingEventType.Start)
				{
					this.PendingReleaseQteIds.Add(((SequenceQteManager.IPendingQteStartEvent)tpendingQteEvent).Data.QteId);
				}
			}
		}

		// Token: 0x060296E1 RID: 169697 RVA: 0x00BAAD28 File Offset: 0x00BA8F28
		private void ReleasePendingQtes()
		{
			UMovieSceneQteManager qteManager = this.QteManager;
			if (!ObjectUtils.IsValid(qteManager))
			{
				this.PendingReleaseQteIds.Clear();
				return;
			}
			foreach (int num in this.PendingReleaseQteIds)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[FlowSequence][PlotQte] 尝试释放未接管的原生Qte";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", num);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				qteManager.FinishQte(num);
			}
			this.PendingReleaseQteIds.Clear();
		}

		// Token: 0x060296E2 RID: 169698 RVA: 0x00BAADCC File Offset: 0x00BA8FCC
		private void HandlePendingQteEvents()
		{
			int i = this.PendingQteEventQueue.Size;
			while (i > 0)
			{
				i--;
				SequenceQteManager.TPendingQteEvent tpendingQteEvent = this.PendingQteEventQueue.Pop();
				if (tpendingQteEvent != null)
				{
					if (tpendingQteEvent.Type == SequenceQteManager.EQtePendingEventType.Start)
					{
						this.StartSequenceQte(((SequenceQteManager.IPendingQteStartEvent)tpendingQteEvent).Data);
					}
					else
					{
						this.OnSequenceAnimFinished(((SequenceQteManager.IPendingQteAnimEndEvent)tpendingQteEvent).QteId);
					}
				}
			}
		}

		// Token: 0x060296E3 RID: 169699 RVA: 0x00BAAE2C File Offset: 0x00BA902C
		[NullableContext(2)]
		public void ForwardSequenceAnim(int id, float progress, FFrameTime toFrame)
		{
			UMovieSceneQteManager qteManager = this.QteManager;
			if (qteManager != null)
			{
				qteManager.UpdateQte(id, true, progress);
			}
			if (this.PlayDirection != SequenceQteManager.EDirection.Forward)
			{
				this.PlayDirection = SequenceQteManager.EDirection.Forward;
				if (toFrame != null && SequenceModel.Instance.IsPlaying)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
					ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
					if (curLevelSeqActor != null)
					{
						curLevelSeqActor.SequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams
						{
							Frame = toFrame,
							PositionType = EMovieScenePositionType.Frame,
							UpdateMethod = EUpdatePositionMethod.Play
						});
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
			}
		}

		// Token: 0x060296E4 RID: 169700 RVA: 0x00BAAEC8 File Offset: 0x00BA90C8
		[NullableContext(2)]
		public void BackwardSequenceAnim(int id, float progress, FFrameTime toFrame)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(id, out sequenceCommonQteHandle))
			{
				return;
			}
			UMovieSceneQteManager qteManager = this.QteManager;
			if (qteManager != null)
			{
				qteManager.UpdateQte(id, false, progress);
			}
			if (this.PlayDirection != SequenceQteManager.EDirection.Backward)
			{
				this.PlayDirection = SequenceQteManager.EDirection.Backward;
				if (toFrame != null && SequenceModel.Instance.IsPlaying)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
					ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
					if (curLevelSeqActor != null)
					{
						ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
						if (sequencePlayer != null)
						{
							sequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams
							{
								Frame = toFrame,
								PositionType = EMovieScenePositionType.Frame,
								UpdateMethod = EUpdatePositionMethod.Play
							});
						}
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
			}
		}

		// Token: 0x060296E5 RID: 169701 RVA: 0x00BAAF7C File Offset: 0x00BA917C
		public void FinishSequenceAnim(int id)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(id, out sequenceCommonQteHandle))
			{
				return;
			}
			UMovieSceneQteManager qteManager = this.QteManager;
			if (qteManager == null)
			{
				return;
			}
			qteManager.FinishQte(id);
		}

		// Token: 0x060296E6 RID: 169702 RVA: 0x00BAAFAB File Offset: 0x00BA91AB
		public void SetPlayRate(float playRate)
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
				if (curLevelSeqActor == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.SetPlayRate(playRate);
			}
		}

		// Token: 0x060296E7 RID: 169703 RVA: 0x00BAAFD8 File Offset: 0x00BA91D8
		public void ResetPlayRate()
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
				if (curLevelSeqActor == null)
				{
					return;
				}
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.SetPlayRate(1f);
			}
		}

		// Token: 0x060296E8 RID: 169704 RVA: 0x00BAB00C File Offset: 0x00BA920C
		[NullableContext(2)]
		public ISequenceCommonQteHandle CreateQte(int qteId, int subtitleId, bool isProgress, bool isGroup, FFrameTime startFrame, FFrameTime endFrame, AActor attachActor, QteSpineInfoProxy spineInfo, [Nullable(new byte[]
		{
			2,
			1
		})] List<MovieSceneSubQteParamsProxy> subQteParams, bool? isUpdateWithProgress)
		{
			CommonQteContextBase commonQteContextBase;
			if (isGroup)
			{
				commonQteContextBase = CommonQteController.Instance.StartQteGroup(qteId, null, null, EQteSource.Plot, new QteExtraParams
				{
					AttachTarget = attachActor
				});
			}
			else
			{
				commonQteContextBase = CommonQteController.Instance.StartQte(qteId, null, null, EQteSource.Plot, new QteExtraParams
				{
					AttachTarget = attachActor
				});
			}
			if (commonQteContextBase == null)
			{
				return null;
			}
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (commonQteContextBase.Type.GetValueOrDefault() == ECommonQteContextType.SingleButtonLongPress)
			{
				sequenceCommonQteHandle = new SequenceQteLongPress(this, (CommonQteLongPressContext)commonQteContextBase);
			}
			else if (commonQteContextBase.Type.GetValueOrDefault() == ECommonQteContextType.SingleButtonContinuousClick)
			{
				sequenceCommonQteHandle = new SequenceQteContinuousClick(this, (CommonQteContinuousClickContext)commonQteContextBase);
			}
			else if (commonQteContextBase.Type.GetValueOrDefault() == ECommonQteContextType.SelectOption)
			{
				sequenceCommonQteHandle = new SequenceQteSelectOption(this, (CommonQteSelectOptionContext)commonQteContextBase);
			}
			else if (commonQteContextBase.Type.GetValueOrDefault() == ECommonQteContextType.QteGroup)
			{
				sequenceCommonQteHandle = new SequenceQteGroup(this, (CommonQteGroupContext)commonQteContextBase);
				((SequenceQteGroup)sequenceCommonQteHandle).SetSubQteParams(subQteParams);
			}
			else if (commonQteContextBase.Type.GetValueOrDefault() == ECommonQteContextType.SingleButtonDrag)
			{
				sequenceCommonQteHandle = new SequenceQteDrag(this, (CommonQteDragContext)commonQteContextBase);
			}
			else
			{
				sequenceCommonQteHandle = new SequenceQteHandleBase<CommonQteContextBase>(this, commonQteContextBase);
			}
			sequenceCommonQteHandle.SubtitleId = subtitleId;
			sequenceCommonQteHandle.IsProgressQte = isProgress;
			sequenceCommonQteHandle.SequenceQteStartRange = startFrame;
			sequenceCommonQteHandle.SequenceQteEndRange = endFrame;
			sequenceCommonQteHandle.SpineInfo = spineInfo;
			sequenceCommonQteHandle.IsUpdateWithProgress = isUpdateWithProgress.GetValueOrDefault();
			return sequenceCommonQteHandle;
		}

		// Token: 0x040169B8 RID: 92600
		private const string QTE_REASON = "QTE";

		// Token: 0x040169B9 RID: 92601
		private const string EnableInteractReason = "SequenceQte";

		// Token: 0x040169BA RID: 92602
		private static readonly FName EventSpineAnimTag = new FName("EventSpineAnim");

		// Token: 0x040169BB RID: 92603
		private readonly Dictionary<int, ISequenceCommonQteHandle> CurrentSequenceQte = new Dictionary<int, ISequenceCommonQteHandle>();

		// Token: 0x040169BC RID: 92604
		private SequenceQteManager.EDirection PlayDirection = SequenceQteManager.EDirection.Pause;

		// Token: 0x040169BD RID: 92605
		[Nullable(2)]
		public UMovieSceneQteManager QteManager;

		// Token: 0x040169BE RID: 92606
		public Dictionary<int, int> PendingOptionResult = new Dictionary<int, int>();

		// Token: 0x040169BF RID: 92607
		private int AfterTickHandleId;

		// Token: 0x040169C0 RID: 92608
		private readonly Queue<int> PendingFinishQteQueue = new Queue<int>(4);

		// Token: 0x040169C1 RID: 92609
		private readonly Queue<SequenceQteManager.TPendingQteEvent> PendingQteEventQueue = new Queue<SequenceQteManager.TPendingQteEvent>(4);

		// Token: 0x040169C2 RID: 92610
		private readonly HashSet<int> PendingReleaseQteIds = new HashSet<int>();

		// Token: 0x02009B91 RID: 39825
		[NullableContext(0)]
		private enum EDirection
		{
			// Token: 0x04030747 RID: 198471
			Forward,
			// Token: 0x04030748 RID: 198472
			Backward,
			// Token: 0x04030749 RID: 198473
			Pause
		}

		// Token: 0x02009B92 RID: 39826
		[NullableContext(0)]
		private enum EQtePendingEventType
		{
			// Token: 0x0403074B RID: 198475
			Start,
			// Token: 0x0403074C RID: 198476
			AnimEnd
		}

		// Token: 0x02009B93 RID: 39827
		[NullableContext(2)]
		private interface ISequenceQteStartData
		{
			// Token: 0x17007939 RID: 31033
			// (get) Token: 0x06044BFE RID: 281598
			// (set) Token: 0x06044BFF RID: 281599
			int QteId { get; set; }

			// Token: 0x1700793A RID: 31034
			// (get) Token: 0x06044C00 RID: 281600
			// (set) Token: 0x06044C01 RID: 281601
			int SubtitleId { get; set; }

			// Token: 0x1700793B RID: 31035
			// (get) Token: 0x06044C02 RID: 281602
			// (set) Token: 0x06044C03 RID: 281603
			bool IsProgress { get; set; }

			// Token: 0x1700793C RID: 31036
			// (get) Token: 0x06044C04 RID: 281604
			// (set) Token: 0x06044C05 RID: 281605
			bool IsGroupQte { get; set; }

			// Token: 0x1700793D RID: 31037
			// (get) Token: 0x06044C06 RID: 281606
			// (set) Token: 0x06044C07 RID: 281607
			FFrameTime StartFrame { get; set; }

			// Token: 0x1700793E RID: 31038
			// (get) Token: 0x06044C08 RID: 281608
			// (set) Token: 0x06044C09 RID: 281609
			FFrameTime EndFrame { get; set; }

			// Token: 0x1700793F RID: 31039
			// (get) Token: 0x06044C0A RID: 281610
			// (set) Token: 0x06044C0B RID: 281611
			AActor AttachActor { get; set; }

			// Token: 0x17007940 RID: 31040
			// (get) Token: 0x06044C0C RID: 281612
			// (set) Token: 0x06044C0D RID: 281613
			QteSpineInfoProxy SpineInfo { get; set; }

			// Token: 0x17007941 RID: 31041
			// (get) Token: 0x06044C0E RID: 281614
			// (set) Token: 0x06044C0F RID: 281615
			bool IsUpdateWithProgress { get; set; }

			// Token: 0x17007942 RID: 31042
			// (get) Token: 0x06044C10 RID: 281616
			// (set) Token: 0x06044C11 RID: 281617
			[Nullable(new byte[]
			{
				2,
				1
			})]
			List<MovieSceneSubQteParamsProxy> SubQteParams { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }
		}

		// Token: 0x02009B94 RID: 39828
		[NullableContext(2)]
		[Nullable(0)]
		[RequiredMember]
		private class SequenceQteStartData : SequenceQteManager.ISequenceQteStartData
		{
			// Token: 0x17007943 RID: 31043
			// (get) Token: 0x06044C12 RID: 281618 RVA: 0x0148736E File Offset: 0x0148556E
			// (set) Token: 0x06044C13 RID: 281619 RVA: 0x01487376 File Offset: 0x01485576
			[RequiredMember]
			public int QteId { get; set; }

			// Token: 0x17007944 RID: 31044
			// (get) Token: 0x06044C14 RID: 281620 RVA: 0x0148737F File Offset: 0x0148557F
			// (set) Token: 0x06044C15 RID: 281621 RVA: 0x01487387 File Offset: 0x01485587
			[RequiredMember]
			public int SubtitleId { get; set; }

			// Token: 0x17007945 RID: 31045
			// (get) Token: 0x06044C16 RID: 281622 RVA: 0x01487390 File Offset: 0x01485590
			// (set) Token: 0x06044C17 RID: 281623 RVA: 0x01487398 File Offset: 0x01485598
			[RequiredMember]
			public bool IsProgress { get; set; }

			// Token: 0x17007946 RID: 31046
			// (get) Token: 0x06044C18 RID: 281624 RVA: 0x014873A1 File Offset: 0x014855A1
			// (set) Token: 0x06044C19 RID: 281625 RVA: 0x014873A9 File Offset: 0x014855A9
			[RequiredMember]
			public bool IsGroupQte { get; set; }

			// Token: 0x17007947 RID: 31047
			// (get) Token: 0x06044C1A RID: 281626 RVA: 0x014873B2 File Offset: 0x014855B2
			// (set) Token: 0x06044C1B RID: 281627 RVA: 0x014873BA File Offset: 0x014855BA
			public FFrameTime StartFrame { get; set; }

			// Token: 0x17007948 RID: 31048
			// (get) Token: 0x06044C1C RID: 281628 RVA: 0x014873C3 File Offset: 0x014855C3
			// (set) Token: 0x06044C1D RID: 281629 RVA: 0x014873CB File Offset: 0x014855CB
			public FFrameTime EndFrame { get; set; }

			// Token: 0x17007949 RID: 31049
			// (get) Token: 0x06044C1E RID: 281630 RVA: 0x014873D4 File Offset: 0x014855D4
			// (set) Token: 0x06044C1F RID: 281631 RVA: 0x014873DC File Offset: 0x014855DC
			public AActor AttachActor { get; set; }

			// Token: 0x1700794A RID: 31050
			// (get) Token: 0x06044C20 RID: 281632 RVA: 0x014873E5 File Offset: 0x014855E5
			// (set) Token: 0x06044C21 RID: 281633 RVA: 0x014873ED File Offset: 0x014855ED
			public QteSpineInfoProxy SpineInfo { get; set; }

			// Token: 0x1700794B RID: 31051
			// (get) Token: 0x06044C22 RID: 281634 RVA: 0x014873F6 File Offset: 0x014855F6
			// (set) Token: 0x06044C23 RID: 281635 RVA: 0x014873FE File Offset: 0x014855FE
			[RequiredMember]
			public bool IsUpdateWithProgress { get; set; }

			// Token: 0x1700794C RID: 31052
			// (get) Token: 0x06044C24 RID: 281636 RVA: 0x01487407 File Offset: 0x01485607
			// (set) Token: 0x06044C25 RID: 281637 RVA: 0x0148740F File Offset: 0x0148560F
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public List<MovieSceneSubQteParamsProxy> SubQteParams { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }

			// Token: 0x06044C26 RID: 281638 RVA: 0x01487418 File Offset: 0x01485618
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public SequenceQteStartData()
			{
			}
		}

		// Token: 0x02009B95 RID: 39829
		private interface IPendingQteStartEvent : SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700794D RID: 31053
			// (get) Token: 0x06044C27 RID: 281639
			// (set) Token: 0x06044C28 RID: 281640
			SequenceQteManager.ISequenceQteStartData Data { get; set; }
		}

		// Token: 0x02009B96 RID: 39830
		[Nullable(0)]
		[RequiredMember]
		private class PendingQteStartEvent : SequenceQteManager.IPendingQteStartEvent, SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700794E RID: 31054
			// (get) Token: 0x06044C29 RID: 281641 RVA: 0x01487420 File Offset: 0x01485620
			// (set) Token: 0x06044C2A RID: 281642 RVA: 0x01487428 File Offset: 0x01485628
			[RequiredMember]
			public SequenceQteManager.EQtePendingEventType Type { get; set; }

			// Token: 0x1700794F RID: 31055
			// (get) Token: 0x06044C2B RID: 281643 RVA: 0x01487431 File Offset: 0x01485631
			// (set) Token: 0x06044C2C RID: 281644 RVA: 0x01487439 File Offset: 0x01485639
			[RequiredMember]
			public SequenceQteManager.ISequenceQteStartData Data { get; set; }

			// Token: 0x06044C2D RID: 281645 RVA: 0x01487442 File Offset: 0x01485642
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public PendingQteStartEvent()
			{
			}
		}

		// Token: 0x02009B97 RID: 39831
		[NullableContext(0)]
		private interface IPendingQteAnimEndEvent : SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x17007950 RID: 31056
			// (get) Token: 0x06044C2E RID: 281646
			// (set) Token: 0x06044C2F RID: 281647
			int QteId { get; set; }
		}

		// Token: 0x02009B98 RID: 39832
		[NullableContext(0)]
		[RequiredMember]
		private class PendingQteAnimEndEvent : SequenceQteManager.IPendingQteAnimEndEvent, SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x17007951 RID: 31057
			// (get) Token: 0x06044C30 RID: 281648 RVA: 0x0148744A File Offset: 0x0148564A
			// (set) Token: 0x06044C31 RID: 281649 RVA: 0x01487452 File Offset: 0x01485652
			[RequiredMember]
			public SequenceQteManager.EQtePendingEventType Type { get; set; }

			// Token: 0x17007952 RID: 31058
			// (get) Token: 0x06044C32 RID: 281650 RVA: 0x0148745B File Offset: 0x0148565B
			// (set) Token: 0x06044C33 RID: 281651 RVA: 0x01487463 File Offset: 0x01485663
			[RequiredMember]
			public int QteId { get; set; }

			// Token: 0x06044C34 RID: 281652 RVA: 0x0148746C File Offset: 0x0148566C
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public PendingQteAnimEndEvent()
			{
			}
		}

		// Token: 0x02009B99 RID: 39833
		private interface TPendingQteEvent
		{
			// Token: 0x17007953 RID: 31059
			// (get) Token: 0x06044C35 RID: 281653
			// (set) Token: 0x06044C36 RID: 281654
			SequenceQteManager.EQtePendingEventType Type { get; set; }
		}
	}
}
