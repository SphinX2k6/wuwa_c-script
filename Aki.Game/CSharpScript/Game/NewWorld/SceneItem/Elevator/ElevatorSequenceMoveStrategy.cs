using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x02007201 RID: 29185
	[NullableContext(1)]
	[Nullable(0)]
	public class ElevatorSequenceMoveStrategy : ElevatorMoveStrategyBase
	{
		// Token: 0x17009E19 RID: 40473
		// (get) Token: 0x060476F8 RID: 292600 RVA: 0x0123070C File Offset: 0x0122E90C
		public bool IsInitializing
		{
			get
			{
				return this.IsInitializingFlag;
			}
		}

		// Token: 0x060476F9 RID: 292601 RVA: 0x01230714 File Offset: 0x0122E914
		private void SeekSequenceTo(float timeInSeconds)
		{
			ALevelSequenceActor elevatorSequenceActor = this.ElevatorSequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (elevatorSequenceActor != null) ? elevatorSequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return;
			}
			ulevelSequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
			{
				Time = timeInSeconds,
				PositionType = EMovieScenePositionType.Time,
				UpdateMethod = EUpdatePositionMethod.Jump
			});
		}

		// Token: 0x060476FA RID: 292602 RVA: 0x0123075C File Offset: 0x0122E95C
		private void PlaySequenceTo(float timeInSeconds)
		{
			ALevelSequenceActor elevatorSequenceActor = this.ElevatorSequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (elevatorSequenceActor != null) ? elevatorSequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return;
			}
			ulevelSequencePlayer.PlayToSeconds(timeInSeconds);
		}

		// Token: 0x060476FB RID: 292603 RVA: 0x01230788 File Offset: 0x0122E988
		[NullableContext(2)]
		private void DestroyAllSpawnedActors(ULevelSequencePlayer player)
		{
			if (player == null)
			{
				return;
			}
			TArray<UObject> allSpawnedObjects = player.GetAllSpawnedObjects();
			if (allSpawnedObjects == null)
			{
				return;
			}
			for (int i = 0; i < allSpawnedObjects.Num(); i++)
			{
				UObject uobject = allSpawnedObjects.Get(i);
				if (uobject != null && uobject.IsValid())
				{
					AActor aactor = uobject as AActor;
					if (aactor != null)
					{
						aactor.K2_DestroyActor();
					}
				}
			}
		}

		// Token: 0x060476FC RID: 292604 RVA: 0x012307D8 File Offset: 0x0122E9D8
		private void TickSequenceMove(float deltaSeconds)
		{
			if (this.ElevatorSequenceActor == null || this.ElevatorSequence == null)
			{
				this.SeqPlayedTime = this.SeqTargetTime;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "TickSequenceMove: ElevatorSequenceActor 或 ElevatorSequence 异常丢失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			float num = deltaSeconds * 0.001f;
			if (num <= 0f)
			{
				return;
			}
			float num2 = MathF.Abs(this.SeqTargetTime - this.SeqPlayedTime);
			if (num + 0.001f >= num2)
			{
				this.SeqPlayedTime = this.SeqTargetTime;
				this.SeqAccumulatedTime = 0f;
				this.PlaySequenceTo(this.SeqPlayedTime);
				return;
			}
			ClampStepResult clampStepResult = SequenceDriveHelper.ClampStep(num, this.SeqAccumulatedTime, num2);
			this.SeqAccumulatedTime = clampStepResult.NextAccumulated;
			if (clampStepResult.Step == null)
			{
				return;
			}
			if (clampStepResult.Step.Value + 0.001f >= num2)
			{
				this.SeqPlayedTime = this.SeqTargetTime;
			}
			else
			{
				int num3 = (this.SeqTargetTime > this.SeqPlayedTime) ? 1 : -1;
				this.SeqPlayedTime += clampStepResult.Step.Value * (float)num3;
			}
			this.PlaySequenceTo(this.SeqPlayedTime);
		}

		// Token: 0x060476FD RID: 292605 RVA: 0x01230920 File Offset: 0x0122EB20
		private void SequenceMoveFinish(Action onMoveArrived)
		{
			this.SeqPlayedTime = this.SeqTargetTime;
			this.PlaySequenceTo(this.SeqTargetTime);
			if (this.IsAnnularMoving)
			{
				this.IsAnnularMoving = false;
				float sequenceStartTime = this.GetSequenceStartTime();
				this.SeqPlayedTime = sequenceStartTime;
				this.SeqTargetTime = this.AnnularMoveTargetTime;
				this.SeqAccumulatedTime = 0f;
				this.SeekSequenceTo(sequenceStartTime);
				if (this.IsSequenceTimeReached(this.SeqPlayedTime, this.SeqTargetTime))
				{
					this.ExitAnimTickState();
					onMoveArrived();
				}
				return;
			}
			this.ExitAnimTickState();
			onMoveArrived();
		}

		// Token: 0x060476FE RID: 292606 RVA: 0x012309B0 File Offset: 0x0122EBB0
		private unsafe bool PlayElevatorSequence(string targetMark)
		{
			if (this.ElevatorSequenceActor == null || this.ElevatorSequence == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "PlayElevatorSequence ElevatorSequenceActor未就绪";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurFloor", this.Ctx.CurFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetFloor", this.Ctx.TargetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetMark", targetMark);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SeqPlayedTime", this.SeqPlayedTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("SeqTargetTime", this.SeqTargetTime);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				return false;
			}
			float? markTimeInSeconds = SequenceDriveHelper.GetMarkTimeInSeconds(this.ElevatorSequence, targetMark);
			if (markTimeInSeconds == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "PlayElevatorSequence Mark配置非法";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurFloor", this.Ctx.CurFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TargetFloor", this.Ctx.TargetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("TargetMark", targetMark);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("SeqPlayedTime", this.SeqPlayedTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("SeqTargetTime", this.SeqTargetTime);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
				return false;
			}
			if (this.Ctx.IsAnnular && this.ElevatorSequenceActor != null && markTimeInSeconds.Value < this.SeqPlayedTime - 0.001f)
			{
				this.IsAnnularMoving = true;
				this.AnnularMoveTargetTime = markTimeInSeconds.Value;
				this.SeqTargetTime = this.GetSequenceEndTime();
				this.SeqAccumulatedTime = 0f;
				return true;
			}
			this.IsAnnularMoving = false;
			this.SeqTargetTime = markTimeInSeconds.Value;
			this.SeqAccumulatedTime = 0f;
			return true;
		}

		// Token: 0x060476FF RID: 292607 RVA: 0x01230C4C File Offset: 0x0122EE4C
		private float GetSequenceStartTime()
		{
			ALevelSequenceActor elevatorSequenceActor = this.ElevatorSequenceActor;
			if (((elevatorSequenceActor != null) ? elevatorSequenceActor.SequencePlayer : null) == null)
			{
				return 0f;
			}
			FQualifiedFrameTime startTime = this.ElevatorSequenceActor.SequencePlayer.GetStartTime();
			return ((float)startTime.Time.FrameNumber.Value + startTime.Time.SubFrame) * (float)startTime.Rate.Denominator / (float)startTime.Rate.Numerator;
		}

		// Token: 0x06047700 RID: 292608 RVA: 0x01230CBC File Offset: 0x0122EEBC
		private float GetSequenceEndTime()
		{
			ALevelSequenceActor elevatorSequenceActor = this.ElevatorSequenceActor;
			if (((elevatorSequenceActor != null) ? elevatorSequenceActor.SequencePlayer : null) == null)
			{
				return 0f;
			}
			FQualifiedFrameTime endTime = this.ElevatorSequenceActor.SequencePlayer.GetEndTime();
			return ((float)endTime.Time.FrameNumber.Value + endTime.Time.SubFrame) * (float)endTime.Rate.Denominator / (float)endTime.Rate.Numerator;
		}

		// Token: 0x06047701 RID: 292609 RVA: 0x01230D2C File Offset: 0x0122EF2C
		private void ApplySequenceCenterOffset()
		{
			if (this.ElevatorSequenceActor == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = new FVectorDouble();
			ULevelSequence sequence = this.ElevatorSequenceActor.GetSequence();
			if (!((sequence != null) ? new bool?(sequence.D_GetCenterOffset(ref fvectorDouble)) : null).GetValueOrDefault())
			{
				fvectorDouble.Set(0.0, 0.0, 0.0);
			}
			this.ElevatorSequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.ElevatorSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			if (udefaultLevelSequenceInstanceData != null)
			{
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData2 = udefaultLevelSequenceInstanceData;
				FVector fvector = fvectorDouble.ToVector();
				udefaultLevelSequenceInstanceData2.TransformOrigin = new FTransform(ref fvector);
			}
		}

		// Token: 0x06047702 RID: 292610 RVA: 0x01230DD1 File Offset: 0x0122EFD1
		private bool IsSequenceTimeReached(float timeA, float timeB)
		{
			return MathF.Abs(timeA - timeB) <= 0.001f;
		}

		// Token: 0x06047703 RID: 292611 RVA: 0x01230DE8 File Offset: 0x0122EFE8
		private void InitSequenceSkeletalMeshes()
		{
			this.SequenceSkeletalMeshes.Clear();
			ALevelSequenceActor elevatorSequenceActor = this.ElevatorSequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (elevatorSequenceActor != null) ? elevatorSequenceActor.SequencePlayer : null;
			ULevelSequence elevatorSequence = this.ElevatorSequence;
			if (ulevelSequencePlayer == null || elevatorSequence == null)
			{
				return;
			}
			ElevatorSequenceMoveStrategy.<>c__DisplayClass27_0 CS$<>8__locals1;
			CS$<>8__locals1.collected = new HashSet<USkeletalMeshComponent>();
			TArray<UObject> allSpawnedObjects = ulevelSequencePlayer.GetAllSpawnedObjects();
			if (allSpawnedObjects != null)
			{
				for (int i = 0; i < allSpawnedObjects.Num(); i++)
				{
					ElevatorSequenceMoveStrategy.<InitSequenceSkeletalMeshes>g__collectFromActor|27_0(allSpawnedObjects.Get(i), ref CS$<>8__locals1);
				}
			}
			SceneItemReferenceComponent component = this.Ctx.Entity.GetComponent<SceneItemReferenceComponent>();
			List<AActor> list = (component != null) ? component.GetAllRefActors() : null;
			if (list != null)
			{
				foreach (AActor obj in list)
				{
					ElevatorSequenceMoveStrategy.<InitSequenceSkeletalMeshes>g__collectFromActor|27_0(obj, ref CS$<>8__locals1);
				}
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent in CS$<>8__locals1.collected)
			{
				uskeletalMeshComponent.SetTickGroup(ETickingGroup.TG_PostUpdateWork);
				this.SequenceSkeletalMeshes.Add(uskeletalMeshComponent);
			}
		}

		// Token: 0x06047704 RID: 292612 RVA: 0x01230F14 File Offset: 0x0122F114
		private void EnterAnimTickState()
		{
			if (this.IsAnimTickOptimizeActive)
			{
				return;
			}
			this.IsAnimTickOptimizeActive = true;
			this.AnimTickOriginalOptions.Clear();
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SequenceSkeletalMeshes)
			{
				if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
				{
					this.AnimTickOriginalOptions[uskeletalMeshComponent] = uskeletalMeshComponent.VisibilityBasedAnimTickOption;
					uskeletalMeshComponent.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
				}
			}
		}

		// Token: 0x06047705 RID: 292613 RVA: 0x01230FA0 File Offset: 0x0122F1A0
		private void ExitAnimTickState()
		{
			if (!this.IsAnimTickOptimizeActive)
			{
				return;
			}
			this.IsAnimTickOptimizeActive = false;
			foreach (KeyValuePair<USkeletalMeshComponent, EVisibilityBasedAnimTickOption> keyValuePair in this.AnimTickOriginalOptions)
			{
				USkeletalMeshComponent uskeletalMeshComponent;
				EVisibilityBasedAnimTickOption evisibilityBasedAnimTickOption;
				keyValuePair.Deconstruct(out uskeletalMeshComponent, out evisibilityBasedAnimTickOption);
				USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
				EVisibilityBasedAnimTickOption visibilityBasedAnimTickOption = evisibilityBasedAnimTickOption;
				if (uskeletalMeshComponent2 != null && uskeletalMeshComponent2.IsValid())
				{
					uskeletalMeshComponent2.VisibilityBasedAnimTickOption = visibilityBasedAnimTickOption;
				}
			}
			this.AnimTickOriginalOptions.Clear();
		}

		// Token: 0x06047706 RID: 292614 RVA: 0x0123102C File Offset: 0x0122F22C
		private void ReleaseElevatorSequenceActor()
		{
			this.ClearPendingRefActorReadyCallback();
			this.SequenceLoadRequestId++;
			if (this.ElevatorSequenceActor != null)
			{
				ULevelSequencePlayer sequencePlayer = this.ElevatorSequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.Stop();
				}
				this.DestroyAllSpawnedActors(sequencePlayer);
				ALevelSequenceActor sequenceActor = this.ElevatorSequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("GamePlayElevatorComponent.ReleaseElevatorSequenceActor", sequenceActor, null);
				}, null, null);
				this.ElevatorSequenceActor = null;
			}
			this.ElevatorSequence = null;
		}

		// Token: 0x06047707 RID: 292615 RVA: 0x012310AC File Offset: 0x0122F2AC
		private unsafe void LoadSequenceAsync(Action<ULevelSequence> callback)
		{
			ElevatorSequenceMoveStrategy.<>c__DisplayClass31_0 CS$<>8__locals1 = new ElevatorSequenceMoveStrategy.<>c__DisplayClass31_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			ElevatorSequenceMoveStrategy.<>c__DisplayClass31_0 CS$<>8__locals2 = CS$<>8__locals1;
			ILiftFloorSeqMarkConfig floorSeqMarkConfig = this.FloorSeqMarkConfig;
			CS$<>8__locals2.sequencePath = ((floorSeqMarkConfig != null) ? floorSeqMarkConfig.SequencePath : null);
			if (string.IsNullOrEmpty(CS$<>8__locals1.sequencePath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "LoadSequenceAsync 缺少SequencePath";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ElevatorSequenceMoveStrategy.<>c__DisplayClass31_0 CS$<>8__locals3 = CS$<>8__locals1;
			int num = this.SequenceLoadRequestId + 1;
			this.SequenceLoadRequestId = num;
			CS$<>8__locals3.requestId = num;
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(CS$<>8__locals1.sequencePath, delegate([Nullable(2)] ULevelSequence loadedSequence, string _)
			{
				if (CS$<>8__locals1.requestId != CS$<>8__locals1.<>4__this.SequenceLoadRequestId)
				{
					return;
				}
				if (loadedSequence == null || !loadedSequence.IsValid())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = "Sequence异步加载失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", CS$<>8__locals1.<>4__this.Ctx.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SequencePath", CS$<>8__locals1.sequencePath);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				CS$<>8__locals1.callback(loadedSequence);
			}, 100, "js_undefined");
		}

		// Token: 0x06047708 RID: 292616 RVA: 0x01231164 File Offset: 0x0122F364
		private bool InitElevatorSequenceActor(ULevelSequence sequence)
		{
			if (this.ElevatorSequenceActor != null)
			{
				return true;
			}
			this.ReleaseElevatorSequenceActor();
			this.ElevatorSequence = sequence;
			this.ElevatorSequenceActor = ActorSystem.Instance.Get<ALevelSequenceActor>(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null, false);
			if (this.ElevatorSequenceActor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "获取LevelSequenceActor失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.ElevatorSequenceActor.SetSequence(sequence);
			ULevelSequencePlayer sequencePlayer = this.ElevatorSequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Play();
				sequencePlayer.SetPlayRate(0f);
				sequencePlayer.Pause();
			}
			this.ApplySequenceCenterOffset();
			this.InitSequenceSkeletalMeshes();
			return true;
		}

		// Token: 0x06047709 RID: 292617 RVA: 0x01231224 File Offset: 0x0122F424
		private void WaitRefActorsReady(Action onReady)
		{
			ElevatorSequenceMoveStrategy.<>c__DisplayClass33_0 CS$<>8__locals1 = new ElevatorSequenceMoveStrategy.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.onReady = onReady;
			this.ClearPendingRefActorReadyCallback();
			CS$<>8__locals1.refComp = this.Ctx.Entity.GetComponent<SceneItemReferenceComponent>();
			if (CS$<>8__locals1.refComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "Sequence电梯不存在SceneItemReferenceComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (CS$<>8__locals1.refComp.AllActorReady)
			{
				CS$<>8__locals1.onReady();
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "Sequence电梯引用Actor未全部就绪, 等待加载完成";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.PendingRefActorReadyCallback = new Action<string, AActor>(CS$<>8__locals1.<WaitRefActorsReady>g__Callback|0);
			CS$<>8__locals1.refComp.AddOnRefActorReadyCallback(this.PendingRefActorReadyCallback);
		}

		// Token: 0x0604770A RID: 292618 RVA: 0x01231312 File Offset: 0x0122F512
		private void ClearPendingRefActorReadyCallback()
		{
			if (this.PendingRefActorReadyCallback == null)
			{
				return;
			}
			SceneItemReferenceComponent component = this.Ctx.Entity.GetComponent<SceneItemReferenceComponent>();
			if (component != null)
			{
				component.RemoveOnRefActorReadyCallback(this.PendingRefActorReadyCallback);
			}
			this.PendingRefActorReadyCallback = null;
		}

		// Token: 0x0604770B RID: 292619 RVA: 0x01231348 File Offset: 0x0122F548
		private unsafe void InitFloorSeqMarkConfig()
		{
			this.FloorSeqMarks = new List<string>();
			SceneItemReferenceComponent component = this.Ctx.Entity.GetComponent<SceneItemReferenceComponent>();
			this.FloorSeqMarkConfig = ((component != null) ? component.GetLiftFloorSeqMarkConfig() : null);
			ILiftFloorSeqMarkConfig floorSeqMarkConfig = this.FloorSeqMarkConfig;
			if (string.IsNullOrEmpty((floorSeqMarkConfig != null) ? floorSeqMarkConfig.SequencePath : null) || this.FloorSeqMarkConfig.FloorMarks == null || this.FloorSeqMarkConfig.FloorMarks.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "UseFloorSeqMarkMapping开启但SceneItemReferenceComponent映射配置缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<ILiftFloorSeqMark> list = new List<ILiftFloorSeqMark>();
			foreach (ILiftFloorSeqMark liftFloorSeqMark in this.FloorSeqMarkConfig.FloorMarks)
			{
				if (liftFloorSeqMark != null && liftFloorSeqMark.Floor != 0 && !string.IsNullOrEmpty(liftFloorSeqMark.Mark))
				{
					list.Add(liftFloorSeqMark);
				}
			}
			list.Sort((ILiftFloorSeqMark a, ILiftFloorSeqMark b) => a.Floor - b.Floor);
			if (list.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "FloorSeqMarkConfig中无有效楼层配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				int num = i + 1;
				if (list[i].Floor != num)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.CK;
					string message3 = "FloorSeqMarkConfig楼层配置非法, Floor必须从1开始且连续递增";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExpectedFloor", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActualFloor", list[i].Floor);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
			}
			this.FloorSeqMarks = new List<string>();
			foreach (ILiftFloorSeqMark liftFloorSeqMark2 in list)
			{
				this.FloorSeqMarks.Add(liftFloorSeqMark2.Mark);
			}
		}

		// Token: 0x0604770C RID: 292620 RVA: 0x012315E4 File Offset: 0x0122F7E4
		[NullableContext(2)]
		private unsafe void JumpElevatorSequenceToInitFloor(Action onComplete = null)
		{
			int initFloor = this.Ctx.CurFloor;
			string targetMark = this.GetFloorMark(initFloor);
			if (!string.IsNullOrEmpty(targetMark))
			{
				this.LoadSequenceAsync(delegate(ULevelSequence loadedSequence)
				{
					this.WaitRefActorsReady(delegate
					{
						if (!this.InitElevatorSequenceActor(loadedSequence))
						{
							Action onComplete3 = onComplete;
							if (onComplete3 == null)
							{
								return;
							}
							onComplete3();
							return;
						}
						else
						{
							float? markTimeInSeconds = SequenceDriveHelper.GetMarkTimeInSeconds(loadedSequence, targetMark);
							if (markTimeInSeconds == null)
							{
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.SceneItem;
								ELogAuthor author2 = ELogAuthor.CK;
								string message2 = "JumpElevatorSequenceToInitFloor Mark配置非法";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Mark", targetMark);
								instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
								Action onComplete4 = onComplete;
								if (onComplete4 == null)
								{
									return;
								}
								onComplete4();
								return;
							}
							else
							{
								this.SeqPlayedTime = markTimeInSeconds.Value;
								this.SeqTargetTime = markTimeInSeconds.Value;
								this.PlaySequenceTo(markTimeInSeconds.Value);
								Log instance3 = Log.Instance;
								ELogModule module3 = ELogModule.SceneItem;
								ELogAuthor author3 = ELogAuthor.CK;
								string message3 = "JumpElevatorSequenceToInitFloor 完成";
								<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("InitFloor", initFloor);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("TargetTime", markTimeInSeconds);
								instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
								Action onComplete5 = onComplete;
								if (onComplete5 == null)
								{
									return;
								}
								onComplete5();
								return;
							}
						}
					});
				});
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "JumpElevatorSequenceToInitFloor 找不到初始楼层对应Mark";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InitFloor", initFloor);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			Action onComplete2 = onComplete;
			if (onComplete2 == null)
			{
				return;
			}
			onComplete2();
		}

		// Token: 0x0604770D RID: 292621 RVA: 0x012316C4 File Offset: 0x0122F8C4
		private unsafe void PrepareSequenceMove(int targetFloor, Action onReady)
		{
			if (string.IsNullOrEmpty(this.GetFloorMark(targetFloor)))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "电梯楼层-SeqMark映射缺少目标楼层Mark";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurFloor", this.Ctx.CurFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("FloorSeqMarkCount", this.FloorSeqMarks.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			this.LoadSequenceAsync(delegate(ULevelSequence loadedSequence)
			{
				this.WaitRefActorsReady(delegate
				{
					if (!this.InitElevatorSequenceActor(loadedSequence))
					{
						return;
					}
					onReady();
				});
			});
		}

		// Token: 0x0604770E RID: 292622 RVA: 0x012317C0 File Offset: 0x0122F9C0
		public unsafe override bool OnBeforeEnterMoving()
		{
			int targetFloor = this.Ctx.TargetFloor;
			string floorMark = this.GetFloorMark(targetFloor);
			if (string.IsNullOrEmpty(floorMark))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "OnBeforeEnterMoving Failed, Missing Target Mark";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityConfigId", this.Ctx.EntityConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurFloor", this.Ctx.CurFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetFloor", targetFloor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("FloorSeqMarkCount", this.FloorSeqMarks.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			return this.PlayElevatorSequence(floorMark);
		}

		// Token: 0x0604770F RID: 292623 RVA: 0x012318AA File Offset: 0x0122FAAA
		public override void OnEnterMovePhase()
		{
			this.EnterAnimTickState();
		}

		// Token: 0x06047710 RID: 292624 RVA: 0x012318B2 File Offset: 0x0122FAB2
		[NullableContext(2)]
		private string GetFloorMark(int floor)
		{
			if (floor < 1 || floor > this.FloorSeqMarks.Count)
			{
				return null;
			}
			return this.FloorSeqMarks[floor - 1];
		}

		// Token: 0x06047711 RID: 292625 RVA: 0x012318D8 File Offset: 0x0122FAD8
		public override void InitFromConfig(LiftComponent config, ElevatorContext ctx, float _initLocationX, float _initLocationY, float _initLocationZ)
		{
			this.Ctx = ctx;
			if (config.StayPositions != null && config.StayPositions.Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "Sequence电梯不应配置StayPositions, 已跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityConfigId", ctx.EntityConfigId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06047712 RID: 292626 RVA: 0x01231933 File Offset: 0x0122FB33
		public override void OnInit()
		{
			this.InitFloorSeqMarkConfig();
		}

		// Token: 0x06047713 RID: 292627 RVA: 0x0123193C File Offset: 0x0122FB3C
		public override void OnStart(Action tryStartAutoRun)
		{
			this.IsInitializingFlag = true;
			this.JumpElevatorSequenceToInitFloor(delegate
			{
				this.IsInitializingFlag = false;
				tryStartAutoRun();
			});
		}

		// Token: 0x06047714 RID: 292628 RVA: 0x01231976 File Offset: 0x0122FB76
		public override void OnClear()
		{
			base.OnClear();
			this.IsInitializingFlag = false;
			this.ExitAnimTickState();
			this.SequenceSkeletalMeshes.Clear();
			this.ReleaseElevatorSequenceActor();
		}

		// Token: 0x06047715 RID: 292629 RVA: 0x0123199C File Offset: 0x0122FB9C
		public override void TickMove(float deltaSeconds)
		{
			this.TickSequenceMove(deltaSeconds);
		}

		// Token: 0x06047716 RID: 292630 RVA: 0x012319A5 File Offset: 0x0122FBA5
		public override void CheckAndFinishMove(Action onMoveArrived)
		{
			if (this.IsSequenceTimeReached(this.SeqPlayedTime, this.SeqTargetTime))
			{
				this.SequenceMoveFinish(onMoveArrived);
			}
		}

		// Token: 0x06047717 RID: 292631 RVA: 0x012319C2 File Offset: 0x0122FBC2
		public override void PrepareMoveToFloor(Action onReady)
		{
			this.PrepareSequenceMove(this.Ctx.TargetFloor, onReady);
		}

		// Token: 0x06047718 RID: 292632 RVA: 0x012319D6 File Offset: 0x0122FBD6
		public override int GetFloorCount()
		{
			return this.FloorSeqMarks.Count;
		}

		// Token: 0x06047719 RID: 292633 RVA: 0x012319E4 File Offset: 0x0122FBE4
		public override float GetMoveDuration()
		{
			float num = MathF.Abs(this.SeqTargetTime - this.SeqPlayedTime);
			if (num <= 1000f)
			{
				return num;
			}
			return 1000f;
		}

		// Token: 0x0604771A RID: 292634 RVA: 0x01231A13 File Offset: 0x0122FC13
		[NullableContext(2)]
		public ALevelSequenceActor GetPlayingSequenceActor()
		{
			return this.ElevatorSequenceActor;
		}

		// Token: 0x0604771C RID: 292636 RVA: 0x01231A44 File Offset: 0x0122FC44
		[NullableContext(2)]
		[CompilerGenerated]
		internal static void <InitSequenceSkeletalMeshes>g__collectFromActor|27_0(UObject obj, ref ElevatorSequenceMoveStrategy.<>c__DisplayClass27_0 A_1)
		{
			if (obj != null && obj.IsValid())
			{
				AActor aactor = obj as AActor;
				if (aactor != null)
				{
					TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
					for (int i = 0; i < tarray.Num(); i++)
					{
						USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
						if (uskeletalMeshComponent != null)
						{
							A_1.collected.Add(uskeletalMeshComponent);
						}
					}
					return;
				}
			}
		}

		// Token: 0x04025928 RID: 153896
		private readonly Dictionary<USkeletalMeshComponent, EVisibilityBasedAnimTickOption> AnimTickOriginalOptions = new Dictionary<USkeletalMeshComponent, EVisibilityBasedAnimTickOption>();

		// Token: 0x04025929 RID: 153897
		private readonly List<USkeletalMeshComponent> SequenceSkeletalMeshes = new List<USkeletalMeshComponent>();

		// Token: 0x0402592A RID: 153898
		private float AnnularMoveTargetTime;

		// Token: 0x0402592B RID: 153899
		[Nullable(2)]
		private ULevelSequence ElevatorSequence;

		// Token: 0x0402592C RID: 153900
		[Nullable(2)]
		private ALevelSequenceActor ElevatorSequenceActor;

		// Token: 0x0402592D RID: 153901
		[Nullable(2)]
		private ILiftFloorSeqMarkConfig FloorSeqMarkConfig;

		// Token: 0x0402592E RID: 153902
		private List<string> FloorSeqMarks = new List<string>();

		// Token: 0x0402592F RID: 153903
		private bool IsAnimTickOptimizeActive;

		// Token: 0x04025930 RID: 153904
		private bool IsAnnularMoving;

		// Token: 0x04025931 RID: 153905
		private bool IsInitializingFlag;

		// Token: 0x04025932 RID: 153906
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, AActor> PendingRefActorReadyCallback;

		// Token: 0x04025933 RID: 153907
		private float SeqAccumulatedTime;

		// Token: 0x04025934 RID: 153908
		private float SeqPlayedTime;

		// Token: 0x04025935 RID: 153909
		private float SeqTargetTime;

		// Token: 0x04025936 RID: 153910
		private int SequenceLoadRequestId;
	}
}
