using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x020062B6 RID: 25270
	[NullableContext(1)]
	[Nullable(0)]
	public class ElevatorSequenceMoveStrategy : ElevatorMoveStrategyBase
	{
		// Token: 0x17007376 RID: 29558
		// (get) Token: 0x0603D000 RID: 249856 RVA: 0x0118A2D0 File Offset: 0x011884D0
		public bool IsInitializing
		{
			get
			{
				return this.IsInitializingFlag;
			}
		}

		// Token: 0x0603D001 RID: 249857 RVA: 0x0118A2D8 File Offset: 0x011884D8
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

		// Token: 0x0603D002 RID: 249858 RVA: 0x0118A320 File Offset: 0x01188520
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

		// Token: 0x0603D003 RID: 249859 RVA: 0x0118A34C File Offset: 0x0118854C
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

		// Token: 0x0603D004 RID: 249860 RVA: 0x0118A39C File Offset: 0x0118859C
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

		// Token: 0x0603D005 RID: 249861 RVA: 0x0118A4E4 File Offset: 0x011886E4
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

		// Token: 0x0603D006 RID: 249862 RVA: 0x0118A574 File Offset: 0x01188774
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

		// Token: 0x0603D007 RID: 249863 RVA: 0x0118A810 File Offset: 0x01188A10
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

		// Token: 0x0603D008 RID: 249864 RVA: 0x0118A880 File Offset: 0x01188A80
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

		// Token: 0x0603D009 RID: 249865 RVA: 0x0118A8F0 File Offset: 0x01188AF0
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

		// Token: 0x0603D00A RID: 249866 RVA: 0x0118A995 File Offset: 0x01188B95
		private bool IsSequenceTimeReached(float timeA, float timeB)
		{
			return MathF.Abs(timeA - timeB) <= 0.001f;
		}

		// Token: 0x0603D00B RID: 249867 RVA: 0x0118A9AC File Offset: 0x01188BAC
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

		// Token: 0x0603D00C RID: 249868 RVA: 0x0118AAD8 File Offset: 0x01188CD8
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

		// Token: 0x0603D00D RID: 249869 RVA: 0x0118AB64 File Offset: 0x01188D64
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

		// Token: 0x0603D00E RID: 249870 RVA: 0x0118ABF0 File Offset: 0x01188DF0
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

		// Token: 0x0603D00F RID: 249871 RVA: 0x0118AC70 File Offset: 0x01188E70
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

		// Token: 0x0603D010 RID: 249872 RVA: 0x0118AD28 File Offset: 0x01188F28
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

		// Token: 0x0603D011 RID: 249873 RVA: 0x0118ADE8 File Offset: 0x01188FE8
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

		// Token: 0x0603D012 RID: 249874 RVA: 0x0118AED6 File Offset: 0x011890D6
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

		// Token: 0x0603D013 RID: 249875 RVA: 0x0118AF0C File Offset: 0x0118910C
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

		// Token: 0x0603D014 RID: 249876 RVA: 0x0118B1A8 File Offset: 0x011893A8
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

		// Token: 0x0603D015 RID: 249877 RVA: 0x0118B288 File Offset: 0x01189488
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

		// Token: 0x0603D016 RID: 249878 RVA: 0x0118B384 File Offset: 0x01189584
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

		// Token: 0x0603D017 RID: 249879 RVA: 0x0118B46E File Offset: 0x0118966E
		public override void OnEnterMovePhase()
		{
			this.EnterAnimTickState();
		}

		// Token: 0x0603D018 RID: 249880 RVA: 0x0118B476 File Offset: 0x01189676
		[NullableContext(2)]
		private string GetFloorMark(int floor)
		{
			if (floor < 1 || floor > this.FloorSeqMarks.Count)
			{
				return null;
			}
			return this.FloorSeqMarks[floor - 1];
		}

		// Token: 0x0603D019 RID: 249881 RVA: 0x0118B49C File Offset: 0x0118969C
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

		// Token: 0x0603D01A RID: 249882 RVA: 0x0118B4F7 File Offset: 0x011896F7
		public override void OnInit()
		{
			this.InitFloorSeqMarkConfig();
		}

		// Token: 0x0603D01B RID: 249883 RVA: 0x0118B500 File Offset: 0x01189700
		public override void OnStart(Action tryStartAutoRun)
		{
			this.IsInitializingFlag = true;
			this.JumpElevatorSequenceToInitFloor(delegate
			{
				this.IsInitializingFlag = false;
				tryStartAutoRun();
			});
		}

		// Token: 0x0603D01C RID: 249884 RVA: 0x0118B53A File Offset: 0x0118973A
		public override void OnClear()
		{
			base.OnClear();
			this.IsInitializingFlag = false;
			this.ExitAnimTickState();
			this.SequenceSkeletalMeshes.Clear();
			this.ReleaseElevatorSequenceActor();
		}

		// Token: 0x0603D01D RID: 249885 RVA: 0x0118B560 File Offset: 0x01189760
		public override void TickMove(float deltaSeconds)
		{
			this.TickSequenceMove(deltaSeconds);
		}

		// Token: 0x0603D01E RID: 249886 RVA: 0x0118B569 File Offset: 0x01189769
		public override void CheckAndFinishMove(Action onMoveArrived)
		{
			if (this.IsSequenceTimeReached(this.SeqPlayedTime, this.SeqTargetTime))
			{
				this.SequenceMoveFinish(onMoveArrived);
			}
		}

		// Token: 0x0603D01F RID: 249887 RVA: 0x0118B586 File Offset: 0x01189786
		public override void PrepareMoveToFloor(Action onReady)
		{
			this.PrepareSequenceMove(this.Ctx.TargetFloor, onReady);
		}

		// Token: 0x0603D020 RID: 249888 RVA: 0x0118B59A File Offset: 0x0118979A
		public override int GetFloorCount()
		{
			return this.FloorSeqMarks.Count;
		}

		// Token: 0x0603D021 RID: 249889 RVA: 0x0118B5A8 File Offset: 0x011897A8
		public override float GetMoveDuration()
		{
			float num = MathF.Abs(this.SeqTargetTime - this.SeqPlayedTime);
			if (num <= 1000f)
			{
				return num;
			}
			return 1000f;
		}

		// Token: 0x0603D022 RID: 249890 RVA: 0x0118B5D7 File Offset: 0x011897D7
		[NullableContext(2)]
		public ALevelSequenceActor GetPlayingSequenceActor()
		{
			return this.ElevatorSequenceActor;
		}

		// Token: 0x0603D024 RID: 249892 RVA: 0x0118B608 File Offset: 0x01189808
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

		// Token: 0x04020597 RID: 132503
		private readonly Dictionary<USkeletalMeshComponent, EVisibilityBasedAnimTickOption> AnimTickOriginalOptions = new Dictionary<USkeletalMeshComponent, EVisibilityBasedAnimTickOption>();

		// Token: 0x04020598 RID: 132504
		private readonly List<USkeletalMeshComponent> SequenceSkeletalMeshes = new List<USkeletalMeshComponent>();

		// Token: 0x04020599 RID: 132505
		private float AnnularMoveTargetTime;

		// Token: 0x0402059A RID: 132506
		[Nullable(2)]
		private ULevelSequence ElevatorSequence;

		// Token: 0x0402059B RID: 132507
		[Nullable(2)]
		private ALevelSequenceActor ElevatorSequenceActor;

		// Token: 0x0402059C RID: 132508
		[Nullable(2)]
		private ILiftFloorSeqMarkConfig FloorSeqMarkConfig;

		// Token: 0x0402059D RID: 132509
		private List<string> FloorSeqMarks = new List<string>();

		// Token: 0x0402059E RID: 132510
		private bool IsAnimTickOptimizeActive;

		// Token: 0x0402059F RID: 132511
		private bool IsAnnularMoving;

		// Token: 0x040205A0 RID: 132512
		private bool IsInitializingFlag;

		// Token: 0x040205A1 RID: 132513
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, AActor> PendingRefActorReadyCallback;

		// Token: 0x040205A2 RID: 132514
		private float SeqAccumulatedTime;

		// Token: 0x040205A3 RID: 132515
		private float SeqPlayedTime;

		// Token: 0x040205A4 RID: 132516
		private float SeqTargetTime;

		// Token: 0x040205A5 RID: 132517
		private int SequenceLoadRequestId;
	}
}
