using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005025 RID: 20517
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceQteManager
	{
		// Token: 0x06034830 RID: 215088 RVA: 0x00C5F02C File Offset: 0x00C5D22C
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

		// Token: 0x06034831 RID: 215089 RVA: 0x00C5F0B0 File Offset: 0x00C5D2B0
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

		// Token: 0x06034832 RID: 215090 RVA: 0x00C5F170 File Offset: 0x00C5D370
		public void EnqueueQteStart(FMovieSceneQteEventParam param)
		{
			this.PendingQteEventQueue.Push(new SequenceQteManager.PendingQteStartEvent
			{
				Type = SequenceQteManager.EQtePendingEventType.Start,
				Data = this.CreateQteStartData(param)
			});
		}

		// Token: 0x06034833 RID: 215091 RVA: 0x00C5F196 File Offset: 0x00C5D396
		public void EnqueueQteAnimEnd(int qteId)
		{
			this.PendingQteEventQueue.Push(new SequenceQteManager.PendingQteAnimEndEvent
			{
				Type = SequenceQteManager.EQtePendingEventType.AnimEnd,
				QteId = qteId
			});
		}

		// Token: 0x06034834 RID: 215092 RVA: 0x00C5F1B6 File Offset: 0x00C5D3B6
		public void EnqueueQteRelease(int qteId)
		{
			this.PendingReleaseQteIds.Add(qteId);
		}

		// Token: 0x06034835 RID: 215093 RVA: 0x00C5F1C8 File Offset: 0x00C5D3C8
		private SequenceQteManager.ISequenceQteStartData CreateQteStartData(FMovieSceneQteEventParam param)
		{
			bool flag = !param.IsTriggerType;
			FFrameTime startFrame = null;
			FFrameTime fframeTime = null;
			if (flag)
			{
				startFrame = new FFrameTime(param.StartFrame.FrameNumber, param.StartFrame.SubFrame);
				fframeTime = new FFrameTime(param.EndFrame.FrameNumber, param.EndFrame.SubFrame);
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

		// Token: 0x06034836 RID: 215094 RVA: 0x00C5F2AC File Offset: 0x00C5D4AC
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

		// Token: 0x06034837 RID: 215095 RVA: 0x00C5F304 File Offset: 0x00C5D504
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

		// Token: 0x06034838 RID: 215096 RVA: 0x00C5F4A0 File Offset: 0x00C5D6A0
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

		// Token: 0x06034839 RID: 215097 RVA: 0x00C5F590 File Offset: 0x00C5D790
		private void OnSequenceAnimFinished(int qteId)
		{
			ISequenceCommonQteHandle sequenceCommonQteHandle;
			if (!this.CurrentSequenceQte.TryGetValue(qteId, out sequenceCommonQteHandle))
			{
				return;
			}
			sequenceCommonQteHandle.OnSequenceAnimFinished();
		}

		// Token: 0x0603483A RID: 215098 RVA: 0x00C5F5B4 File Offset: 0x00C5D7B4
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

		// Token: 0x0603483B RID: 215099 RVA: 0x00C5F600 File Offset: 0x00C5D800
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

		// Token: 0x0603483C RID: 215100 RVA: 0x00C5F6DC File Offset: 0x00C5D8DC
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

		// Token: 0x0603483D RID: 215101 RVA: 0x00C5F770 File Offset: 0x00C5D970
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

		// Token: 0x0603483E RID: 215102 RVA: 0x00C5F7C0 File Offset: 0x00C5D9C0
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

		// Token: 0x0603483F RID: 215103 RVA: 0x00C5F864 File Offset: 0x00C5DA64
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

		// Token: 0x06034840 RID: 215104 RVA: 0x00C5F8C4 File Offset: 0x00C5DAC4
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
						curLevelSeqActor.SequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(toFrame, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play));
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
			}
		}

		// Token: 0x06034841 RID: 215105 RVA: 0x00C5F958 File Offset: 0x00C5DB58
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
							sequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(toFrame, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play));
						}
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
			}
		}

		// Token: 0x06034842 RID: 215106 RVA: 0x00C5FA04 File Offset: 0x00C5DC04
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

		// Token: 0x06034843 RID: 215107 RVA: 0x00C5FA33 File Offset: 0x00C5DC33
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

		// Token: 0x06034844 RID: 215108 RVA: 0x00C5FA60 File Offset: 0x00C5DC60
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

		// Token: 0x06034845 RID: 215109 RVA: 0x00C5FA94 File Offset: 0x00C5DC94
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

		// Token: 0x0401BFCD RID: 114637
		private const string QTE_REASON = "QTE";

		// Token: 0x0401BFCE RID: 114638
		private const string EnableInteractReason = "SequenceQte";

		// Token: 0x0401BFCF RID: 114639
		private static readonly FName EventSpineAnimTag = new FName("EventSpineAnim");

		// Token: 0x0401BFD0 RID: 114640
		private readonly Dictionary<int, ISequenceCommonQteHandle> CurrentSequenceQte = new Dictionary<int, ISequenceCommonQteHandle>();

		// Token: 0x0401BFD1 RID: 114641
		private SequenceQteManager.EDirection PlayDirection = SequenceQteManager.EDirection.Pause;

		// Token: 0x0401BFD2 RID: 114642
		[Nullable(2)]
		public UMovieSceneQteManager QteManager;

		// Token: 0x0401BFD3 RID: 114643
		public Dictionary<int, int> PendingOptionResult = new Dictionary<int, int>();

		// Token: 0x0401BFD4 RID: 114644
		private int AfterTickHandleId;

		// Token: 0x0401BFD5 RID: 114645
		private readonly Queue<int> PendingFinishQteQueue = new Queue<int>(4);

		// Token: 0x0401BFD6 RID: 114646
		private readonly Queue<SequenceQteManager.TPendingQteEvent> PendingQteEventQueue = new Queue<SequenceQteManager.TPendingQteEvent>(4);

		// Token: 0x0401BFD7 RID: 114647
		private readonly HashSet<int> PendingReleaseQteIds = new HashSet<int>();

		// Token: 0x0200B15A RID: 45402
		[NullableContext(0)]
		private enum EDirection
		{
			// Token: 0x04035D00 RID: 220416
			Forward,
			// Token: 0x04035D01 RID: 220417
			Backward,
			// Token: 0x04035D02 RID: 220418
			Pause
		}

		// Token: 0x0200B15B RID: 45403
		[NullableContext(0)]
		private enum EQtePendingEventType
		{
			// Token: 0x04035D04 RID: 220420
			Start,
			// Token: 0x04035D05 RID: 220421
			AnimEnd
		}

		// Token: 0x0200B15C RID: 45404
		[NullableContext(2)]
		private interface ISequenceQteStartData
		{
			// Token: 0x1700A195 RID: 41365
			// (get) Token: 0x0604E5F5 RID: 321013
			// (set) Token: 0x0604E5F6 RID: 321014
			int QteId { get; set; }

			// Token: 0x1700A196 RID: 41366
			// (get) Token: 0x0604E5F7 RID: 321015
			// (set) Token: 0x0604E5F8 RID: 321016
			int SubtitleId { get; set; }

			// Token: 0x1700A197 RID: 41367
			// (get) Token: 0x0604E5F9 RID: 321017
			// (set) Token: 0x0604E5FA RID: 321018
			bool IsProgress { get; set; }

			// Token: 0x1700A198 RID: 41368
			// (get) Token: 0x0604E5FB RID: 321019
			// (set) Token: 0x0604E5FC RID: 321020
			bool IsGroupQte { get; set; }

			// Token: 0x1700A199 RID: 41369
			// (get) Token: 0x0604E5FD RID: 321021
			// (set) Token: 0x0604E5FE RID: 321022
			FFrameTime StartFrame { get; set; }

			// Token: 0x1700A19A RID: 41370
			// (get) Token: 0x0604E5FF RID: 321023
			// (set) Token: 0x0604E600 RID: 321024
			FFrameTime EndFrame { get; set; }

			// Token: 0x1700A19B RID: 41371
			// (get) Token: 0x0604E601 RID: 321025
			// (set) Token: 0x0604E602 RID: 321026
			AActor AttachActor { get; set; }

			// Token: 0x1700A19C RID: 41372
			// (get) Token: 0x0604E603 RID: 321027
			// (set) Token: 0x0604E604 RID: 321028
			QteSpineInfoProxy SpineInfo { get; set; }

			// Token: 0x1700A19D RID: 41373
			// (get) Token: 0x0604E605 RID: 321029
			// (set) Token: 0x0604E606 RID: 321030
			bool IsUpdateWithProgress { get; set; }

			// Token: 0x1700A19E RID: 41374
			// (get) Token: 0x0604E607 RID: 321031
			// (set) Token: 0x0604E608 RID: 321032
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

		// Token: 0x0200B15D RID: 45405
		[NullableContext(2)]
		[Nullable(0)]
		[RequiredMember]
		private class SequenceQteStartData : SequenceQteManager.ISequenceQteStartData
		{
			// Token: 0x1700A19F RID: 41375
			// (get) Token: 0x0604E609 RID: 321033 RVA: 0x014CDBF6 File Offset: 0x014CBDF6
			// (set) Token: 0x0604E60A RID: 321034 RVA: 0x014CDBFE File Offset: 0x014CBDFE
			[RequiredMember]
			public int QteId { get; set; }

			// Token: 0x1700A1A0 RID: 41376
			// (get) Token: 0x0604E60B RID: 321035 RVA: 0x014CDC07 File Offset: 0x014CBE07
			// (set) Token: 0x0604E60C RID: 321036 RVA: 0x014CDC0F File Offset: 0x014CBE0F
			[RequiredMember]
			public int SubtitleId { get; set; }

			// Token: 0x1700A1A1 RID: 41377
			// (get) Token: 0x0604E60D RID: 321037 RVA: 0x014CDC18 File Offset: 0x014CBE18
			// (set) Token: 0x0604E60E RID: 321038 RVA: 0x014CDC20 File Offset: 0x014CBE20
			[RequiredMember]
			public bool IsProgress { get; set; }

			// Token: 0x1700A1A2 RID: 41378
			// (get) Token: 0x0604E60F RID: 321039 RVA: 0x014CDC29 File Offset: 0x014CBE29
			// (set) Token: 0x0604E610 RID: 321040 RVA: 0x014CDC31 File Offset: 0x014CBE31
			[RequiredMember]
			public bool IsGroupQte { get; set; }

			// Token: 0x1700A1A3 RID: 41379
			// (get) Token: 0x0604E611 RID: 321041 RVA: 0x014CDC3A File Offset: 0x014CBE3A
			// (set) Token: 0x0604E612 RID: 321042 RVA: 0x014CDC42 File Offset: 0x014CBE42
			public FFrameTime StartFrame { get; set; }

			// Token: 0x1700A1A4 RID: 41380
			// (get) Token: 0x0604E613 RID: 321043 RVA: 0x014CDC4B File Offset: 0x014CBE4B
			// (set) Token: 0x0604E614 RID: 321044 RVA: 0x014CDC53 File Offset: 0x014CBE53
			public FFrameTime EndFrame { get; set; }

			// Token: 0x1700A1A5 RID: 41381
			// (get) Token: 0x0604E615 RID: 321045 RVA: 0x014CDC5C File Offset: 0x014CBE5C
			// (set) Token: 0x0604E616 RID: 321046 RVA: 0x014CDC64 File Offset: 0x014CBE64
			public AActor AttachActor { get; set; }

			// Token: 0x1700A1A6 RID: 41382
			// (get) Token: 0x0604E617 RID: 321047 RVA: 0x014CDC6D File Offset: 0x014CBE6D
			// (set) Token: 0x0604E618 RID: 321048 RVA: 0x014CDC75 File Offset: 0x014CBE75
			public QteSpineInfoProxy SpineInfo { get; set; }

			// Token: 0x1700A1A7 RID: 41383
			// (get) Token: 0x0604E619 RID: 321049 RVA: 0x014CDC7E File Offset: 0x014CBE7E
			// (set) Token: 0x0604E61A RID: 321050 RVA: 0x014CDC86 File Offset: 0x014CBE86
			[RequiredMember]
			public bool IsUpdateWithProgress { get; set; }

			// Token: 0x1700A1A8 RID: 41384
			// (get) Token: 0x0604E61B RID: 321051 RVA: 0x014CDC8F File Offset: 0x014CBE8F
			// (set) Token: 0x0604E61C RID: 321052 RVA: 0x014CDC97 File Offset: 0x014CBE97
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

			// Token: 0x0604E61D RID: 321053 RVA: 0x014CDCA0 File Offset: 0x014CBEA0
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public SequenceQteStartData()
			{
			}
		}

		// Token: 0x0200B15E RID: 45406
		private interface IPendingQteStartEvent : SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700A1A9 RID: 41385
			// (get) Token: 0x0604E61E RID: 321054
			// (set) Token: 0x0604E61F RID: 321055
			SequenceQteManager.ISequenceQteStartData Data { get; set; }
		}

		// Token: 0x0200B15F RID: 45407
		[Nullable(0)]
		[RequiredMember]
		private class PendingQteStartEvent : SequenceQteManager.IPendingQteStartEvent, SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700A1AA RID: 41386
			// (get) Token: 0x0604E620 RID: 321056 RVA: 0x014CDCA8 File Offset: 0x014CBEA8
			// (set) Token: 0x0604E621 RID: 321057 RVA: 0x014CDCB0 File Offset: 0x014CBEB0
			[RequiredMember]
			public SequenceQteManager.EQtePendingEventType Type { get; set; }

			// Token: 0x1700A1AB RID: 41387
			// (get) Token: 0x0604E622 RID: 321058 RVA: 0x014CDCB9 File Offset: 0x014CBEB9
			// (set) Token: 0x0604E623 RID: 321059 RVA: 0x014CDCC1 File Offset: 0x014CBEC1
			[RequiredMember]
			public SequenceQteManager.ISequenceQteStartData Data { get; set; }

			// Token: 0x0604E624 RID: 321060 RVA: 0x014CDCCA File Offset: 0x014CBECA
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public PendingQteStartEvent()
			{
			}
		}

		// Token: 0x0200B160 RID: 45408
		[NullableContext(0)]
		private interface IPendingQteAnimEndEvent : SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700A1AC RID: 41388
			// (get) Token: 0x0604E625 RID: 321061
			// (set) Token: 0x0604E626 RID: 321062
			int QteId { get; set; }
		}

		// Token: 0x0200B161 RID: 45409
		[NullableContext(0)]
		[RequiredMember]
		private class PendingQteAnimEndEvent : SequenceQteManager.IPendingQteAnimEndEvent, SequenceQteManager.TPendingQteEvent
		{
			// Token: 0x1700A1AD RID: 41389
			// (get) Token: 0x0604E627 RID: 321063 RVA: 0x014CDCD2 File Offset: 0x014CBED2
			// (set) Token: 0x0604E628 RID: 321064 RVA: 0x014CDCDA File Offset: 0x014CBEDA
			[RequiredMember]
			public SequenceQteManager.EQtePendingEventType Type { get; set; }

			// Token: 0x1700A1AE RID: 41390
			// (get) Token: 0x0604E629 RID: 321065 RVA: 0x014CDCE3 File Offset: 0x014CBEE3
			// (set) Token: 0x0604E62A RID: 321066 RVA: 0x014CDCEB File Offset: 0x014CBEEB
			[RequiredMember]
			public int QteId { get; set; }

			// Token: 0x0604E62B RID: 321067 RVA: 0x014CDCF4 File Offset: 0x014CBEF4
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public PendingQteAnimEndEvent()
			{
			}
		}

		// Token: 0x0200B162 RID: 45410
		private interface TPendingQteEvent
		{
			// Token: 0x1700A1AF RID: 41391
			// (get) Token: 0x0604E62C RID: 321068
			// (set) Token: 0x0604E62D RID: 321069
			SequenceQteManager.EQtePendingEventType Type { get; set; }
		}
	}
}
