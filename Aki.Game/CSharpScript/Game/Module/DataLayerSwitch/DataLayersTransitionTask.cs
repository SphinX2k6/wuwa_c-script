using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.StepSequence;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02004AB3 RID: 19123
	[NullableContext(2)]
	[Nullable(0)]
	public class DataLayersTransitionTask : IStaticVariableResetter
	{
		// Token: 0x0602FD8C RID: 195980 RVA: 0x00D5A8C8 File Offset: 0x00D58AC8
		static DataLayersTransitionTask()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DataLayersTransitionTask.CreateStaticDefaultValue), new Action(DataLayersTransitionTask.ResetStaticDefaultValue));
		}

		// Token: 0x0602FD8D RID: 195981 RVA: 0x00D5A8E7 File Offset: 0x00D58AE7
		public static void CreateStaticDefaultValue()
		{
			DataLayersTransitionTask.MaxTaskId = 0;
		}

		// Token: 0x0602FD8E RID: 195982 RVA: 0x00D5A8EF File Offset: 0x00D58AEF
		public static void ResetStaticDefaultValue()
		{
			DataLayersTransitionTask.MaxTaskId = 0;
		}

		// Token: 0x0602FD8F RID: 195983 RVA: 0x00D5A8F8 File Offset: 0x00D58AF8
		public DataLayersTransitionTask()
		{
			this.TaskId = ++DataLayersTransitionTask.MaxTaskId;
		}

		// Token: 0x0602FD90 RID: 195984 RVA: 0x00D5A988 File Offset: 0x00D58B88
		private UKuroSceneModifierSubsystem GetKuroSceneModifierSubsystem()
		{
			UKuroSceneModifierSubsystem kuroSceneModifierSubsystemCache = this.KuroSceneModifierSubsystemCache;
			if (kuroSceneModifierSubsystemCache == null || !kuroSceneModifierSubsystemCache.IsValid())
			{
				this.KuroSceneModifierSubsystemCache = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneModifierSubsystem.StaticClass()) as UKuroSceneModifierSubsystem);
				UKuroSceneModifierSubsystem kuroSceneModifierSubsystemCache2 = this.KuroSceneModifierSubsystemCache;
				if (kuroSceneModifierSubsystemCache2 == null || !kuroSceneModifierSubsystemCache2.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Level;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[DataLayersTransitionTask] 获取KuroSceneModifierSubsystem失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskId", this.TaskId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.KuroSceneModifierSubsystemCache = null;
				}
			}
			return this.KuroSceneModifierSubsystemCache;
		}

		// Token: 0x0602FD91 RID: 195985 RVA: 0x00D5AA20 File Offset: 0x00D58C20
		public unsafe void StartTask()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[DataLayersTransitionTask] DataLayer过渡开始";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ToActivateDataLayerNames", this.ToActivateDataLayerNames);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ToDeactivateDataLayerNames", this.ToDeactivateDataLayerNames);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.ToActivateDataLayerNames == null && this.ToDeactivateDataLayerNames == null)
			{
				this.StopTask(true);
				return;
			}
			this.Transition();
		}

		// Token: 0x0602FD92 RID: 195986 RVA: 0x00D5AACC File Offset: 0x00D58CCC
		[NullableContext(1)]
		private void InitUeContainerFromSet(HashSet<FName> inSet, TArray<FName> outUeSet)
		{
			outUeSet.Empty(true);
			foreach (FName value in inSet)
			{
				outUeSet.Add(value);
			}
		}

		// Token: 0x0602FD93 RID: 195987 RVA: 0x00D5AB24 File Offset: 0x00D58D24
		[NullableContext(1)]
		private void InitUeContainerFromSet(HashSet<FName> inSet, TSet<FName> outUeSet)
		{
			outUeSet.Empty(0);
			foreach (FName value in inSet)
			{
				outUeSet.Add(value);
			}
		}

		// Token: 0x0602FD94 RID: 195988 RVA: 0x00D5AB7C File Offset: 0x00D58D7C
		[NullableContext(1)]
		private void ChangeDataLayerState(HashSet<FName> dataLayerNames, bool targetState)
		{
			if (this.IsServerControlledDataLayer && dataLayerNames.Count > 0)
			{
				EventSystem.Instance.Emit<ELevelEnvChangeType, FVectorDouble?, float?>(EEventName.OnLevelEnvChange, ELevelEnvChangeType.DataLayer, null, null);
			}
			foreach (FName fname in dataLayerNames)
			{
				string text = fname.ToString();
				if (this.IsServerControlledDataLayer)
				{
					if (targetState)
					{
						GameModeModel.Instance.AddDataLayer(text);
					}
					else
					{
						GameModeModel.Instance.RemoveDataLayer(text);
					}
				}
				if (RenderModuleController.Instance.IsWorldPartitionDataLayerEnable(text) != targetState)
				{
					RenderModuleController.Instance.SetWorldPartitionDataLayerState(text, targetState, false);
				}
			}
		}

		// Token: 0x0602FD95 RID: 195989 RVA: 0x00D5AC4C File Offset: 0x00D58E4C
		private void Transition()
		{
			if (this.ToActivateDataLayerNames != null)
			{
				this.ToActivateDataLayerNamesUeSet = new TSet<FName>();
				this.InitUeContainerFromSet(this.ToActivateDataLayerNames, this.ToActivateDataLayerNamesUeSet);
			}
			if (this.ToDeactivateDataLayerNames != null)
			{
				this.ToDeactivateDataLayerNamesUeSet = new TSet<FName>();
				this.InitUeContainerFromSet(this.ToDeactivateDataLayerNames, this.ToDeactivateDataLayerNamesUeSet);
			}
			new StepSequence().AddStep((SequenceContext _) => this.TransitionPartLoadResources()).AddStep(delegate(SequenceContext ctx)
			{
				this.TransitionPartCheckBeforeTransition(ctx);
				return UniTask.CompletedTask;
			}).AddStep((SequenceContext _) => this.TransitionPartPlaySeqToBeforeModifyMatMark()).AddStep(delegate(SequenceContext _)
			{
				this.TransitionPartModifyMat();
				return UniTask.CompletedTask;
			}).AddStep((SequenceContext _) => this.TransitionPartLoadDataLayer()).AddStep((SequenceContext _) => this.TransitionPartPlaySeqToEnd()).AddStep((SequenceContext _) => this.TransitionPartUnloadDataLayer()).AddStep(delegate(SequenceContext _)
			{
				this.TransitionPartResetMat();
				return UniTask.CompletedTask;
			}).AddStep(delegate(SequenceContext _)
			{
				this.TransitionPartClearCustomCullFlag();
				return UniTask.CompletedTask;
			}).AddStep((SequenceContext _) => this.TransitionPartRenderAssetsCheck()).AddStep(delegate(SequenceContext _)
			{
				this.TransitionPartFixBornLocation();
				return UniTask.CompletedTask;
			}).SetOnAbort(delegate
			{
				this.OnTransitionAborted();
			}).SetFinally(delegate
			{
				this.StopTask(true);
			}).Run(this.AbortSignal);
		}

		// Token: 0x0602FD96 RID: 195990 RVA: 0x00D5AD94 File Offset: 0x00D58F94
		private UniTask TransitionPartLoadResources()
		{
			DataLayersTransitionTask.<TransitionPartLoadResources>d__51 <TransitionPartLoadResources>d__;
			<TransitionPartLoadResources>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartLoadResources>d__.<>4__this = this;
			<TransitionPartLoadResources>d__.<>1__state = -1;
			<TransitionPartLoadResources>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartLoadResources>d__51>(ref <TransitionPartLoadResources>d__);
			return <TransitionPartLoadResources>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD97 RID: 195991 RVA: 0x00D5ADD8 File Offset: 0x00D58FD8
		[NullableContext(1)]
		private void StartTrackedResourceLoad<[Nullable(0)] T>(string path, [Nullable(new byte[]
		{
			1,
			2
		})] Action<T> onLoaded) where T : UObject, IUnrealUObject
		{
			int id = -1;
			bool done = false;
			id = ResourceSystem.Instance.LoadAsync<T>(path, delegate([Nullable(2)] T asset, string _)
			{
				done = true;
				this.ActiveLoadIds.Remove(id);
				onLoaded(asset);
			}, 100, "js_undefined");
			if (id != -1 && !done)
			{
				this.ActiveLoadIds.Add(id);
			}
		}

		// Token: 0x0602FD98 RID: 195992 RVA: 0x00D5AE4E File Offset: 0x00D5904E
		[NullableContext(1)]
		private void TransitionPartCheckBeforeTransition(SequenceContext ctx)
		{
			HashSet<FName> toActivateDataLayerNames = this.ToActivateDataLayerNames;
			if (toActivateDataLayerNames == null || toActivateDataLayerNames.Count <= 0)
			{
				HashSet<FName> toDeactivateDataLayerNames = this.ToDeactivateDataLayerNames;
				if (toDeactivateDataLayerNames == null || toDeactivateDataLayerNames.Count <= 0)
				{
					ctx.Stop();
					return;
				}
			}
			this.CheckLogBeforeTransition();
		}

		// Token: 0x0602FD99 RID: 195993 RVA: 0x00D5AE8C File Offset: 0x00D5908C
		private void OnTransitionAborted()
		{
			SimpleLevelSequenceActor simpleLevelSequenceActor = this.SimpleLevelSequenceActor;
			if (simpleLevelSequenceActor != null && simpleLevelSequenceActor.IsPlaying())
			{
				UMovieSceneSequencePlayer player = simpleLevelSequenceActor.GetPlayer();
				if (player != null && player.IsValid())
				{
					FQualifiedFrameTime endTime = player.GetEndTime();
					player.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
					{
						Frame = endTime.Time,
						PositionType = EMovieScenePositionType.Frame,
						UpdateMethod = EUpdatePositionMethod.Jump
					});
				}
			}
			foreach (int id in this.ActiveLoadIds)
			{
				ResourceSystem.Instance.CancelAsyncLoad(id);
			}
			this.ActiveLoadIds.Clear();
			foreach (Action action in new List<Action>(this.ActivePollFinishers))
			{
				action();
			}
			HashSet<FName> toActivateDataLayerNames = this.ToActivateDataLayerNames;
			if (toActivateDataLayerNames != null && toActivateDataLayerNames.Count > 0)
			{
				this.ChangeDataLayerState(this.ToActivateDataLayerNames, true);
			}
			HashSet<FName> toDeactivateDataLayerNames = this.ToDeactivateDataLayerNames;
			if (toDeactivateDataLayerNames != null && toDeactivateDataLayerNames.Count > 0)
			{
				this.ChangeDataLayerState(this.ToDeactivateDataLayerNames, false);
			}
			UKuroSceneModifierSubsystem kuroSceneModifierSubsystem = this.GetKuroSceneModifierSubsystem();
			if (kuroSceneModifierSubsystem != null)
			{
				kuroSceneModifierSubsystem.ResetMaterialsByDataLayer(this.ToActivateDataLayerNamesUeSet);
			}
			UKuroSceneModifierSubsystem kuroSceneModifierSubsystem2 = this.GetKuroSceneModifierSubsystem();
			if (kuroSceneModifierSubsystem2 == null)
			{
				return;
			}
			kuroSceneModifierSubsystem2.ResetMaterialsByDataLayer(this.ToDeactivateDataLayerNamesUeSet);
		}

		// Token: 0x0602FD9A RID: 195994 RVA: 0x00D5AFFC File Offset: 0x00D591FC
		private unsafe void CheckLogBeforeTransition()
		{
			HashSet<FName> toActivateDataLayerNames = this.ToActivateDataLayerNames;
			if (toActivateDataLayerNames != null && toActivateDataLayerNames.Count > 0)
			{
				HashSet<FName> toDeactivateDataLayerNames = this.ToDeactivateDataLayerNames;
				if (toDeactivateDataLayerNames != null && toDeactivateDataLayerNames.Count > 0 && this.MatDataForActivating != null && this.MatDataForDeactivating != null && this.SeqData != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Level;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[DataLayersTransitionTask] 同时控制DataLayer显示的过渡和DataLayer隐藏的过渡，可能导致表现问题";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ToActivateDataLayerNames", this.ToActivateDataLayerNames);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ToDeactivateDataLayerNames", this.ToDeactivateDataLayerNames);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			HashSet<FName> toActivateDataLayerNames2 = this.ToActivateDataLayerNames;
			if (toActivateDataLayerNames2 == null || toActivateDataLayerNames2.Count <= 0 || this.MatDataForActivating == null)
			{
				HashSet<FName> toDeactivateDataLayerNames2 = this.ToDeactivateDataLayerNames;
				if (toDeactivateDataLayerNames2 == null || toDeactivateDataLayerNames2.Count <= 0 || this.MatDataForDeactivating == null)
				{
					return;
				}
			}
			if (this.SeqData == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[DataLayersTransitionTask] 要处理的DataLayer和过渡材质DA, 但是没有过渡Seq, 可能导致表现问题";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ToActivateDataLayerNames", this.ToActivateDataLayerNames);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ToDeactivateDataLayerNames", this.ToDeactivateDataLayerNames);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
		}

		// Token: 0x0602FD9B RID: 195995 RVA: 0x00D5B1A8 File Offset: 0x00D593A8
		private UniTask TransitionPartPlaySeqToBeforeModifyMatMark()
		{
			DataLayersTransitionTask.<TransitionPartPlaySeqToBeforeModifyMatMark>d__56 <TransitionPartPlaySeqToBeforeModifyMatMark>d__;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>4__this = this;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>1__state = -1;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartPlaySeqToBeforeModifyMatMark>d__56>(ref <TransitionPartPlaySeqToBeforeModifyMatMark>d__);
			return <TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD9C RID: 195996 RVA: 0x00D5B1EC File Offset: 0x00D593EC
		private void TransitionPartModifyMat()
		{
			UKuroSceneMatModifyDataAsset matDataForActivating = this.MatDataForActivating;
			if (matDataForActivating != null && matDataForActivating.IsValid())
			{
				UKuroSceneModifierSubsystem kuroSceneModifierSubsystem = this.GetKuroSceneModifierSubsystem();
				if (kuroSceneModifierSubsystem != null)
				{
					kuroSceneModifierSubsystem.ModifyMaterialsByDataLayer(this.ToActivateDataLayerNamesUeSet, this.MatDataForActivating, false);
				}
			}
			UKuroSceneMatModifyDataAsset matDataForDeactivating = this.MatDataForDeactivating;
			if (matDataForDeactivating != null && matDataForDeactivating.IsValid())
			{
				UKuroSceneModifierSubsystem kuroSceneModifierSubsystem2 = this.GetKuroSceneModifierSubsystem();
				if (kuroSceneModifierSubsystem2 == null)
				{
					return;
				}
				kuroSceneModifierSubsystem2.ModifyMaterialsByDataLayer(this.ToDeactivateDataLayerNamesUeSet, this.MatDataForDeactivating, true);
			}
		}

		// Token: 0x0602FD9D RID: 195997 RVA: 0x00D5B25C File Offset: 0x00D5945C
		[NullableContext(1)]
		private unsafe UniTask PollWithTimeout(string logTag, Func<bool> check, int intervalMs, float maxWaitTime)
		{
			UniTaskCompletionSource tcs = new UniTaskCompletionSource();
			TimerHandle pollTimer = null;
			TimerHandle maxTimer = null;
			bool finished = false;
			Action finish = null;
			finish = delegate()
			{
				if (finished)
				{
					return;
				}
				finished = true;
				this.ActivePollFinishers.Remove(finish);
				if (pollTimer != null && TimerSystem.Instance.Has(pollTimer))
				{
					TimerSystem.Instance.Remove(pollTimer);
				}
				if (maxTimer != null && TimerSystem.Instance.Has(maxTimer))
				{
					TimerSystem.Instance.Remove(maxTimer);
				}
				tcs.TrySetResult();
			};
			this.ActivePollFinishers.Add(finish);
			pollTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (check())
				{
					finish();
				}
			}, (float)intervalMs, 1f, null, null, true);
			if (pollTimer == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[DataLayersTransitionTask] " + logTag + ":设置轮询计时器时出错,强行结束";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskId", this.TaskId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				finish();
				return tcs.Task;
			}
			float num = maxWaitTime * 1000f;
			if (num <= 0f)
			{
				return tcs.Task;
			}
			if (num < 20f)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[DataLayersTransitionTask] " + logTag + ":超时时间不≤0但又过短,强行结束";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitMaxTime", maxWaitTime);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				finish();
				return tcs.Task;
			}
			maxTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Level;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[DataLayersTransitionTask] " + logTag + ":等待超时,强行结束";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("WaitMaxTime", maxWaitTime);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				finish();
			}, num, null, null, true, 1f);
			if (maxTimer == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Level;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[DataLayersTransitionTask] " + logTag + ":设置超时计时器时出错,强行结束";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TaskId", this.TaskId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				finish();
			}
			return tcs.Task;
		}

		// Token: 0x0602FD9E RID: 195998 RVA: 0x00D5B49C File Offset: 0x00D5969C
		[NullableContext(1)]
		private Func<bool> CreatePlayerDriftChecker()
		{
			DataLayersTransitionTask.<>c__DisplayClass60_0 CS$<>8__locals1 = new DataLayersTransitionTask.<>c__DisplayClass60_0();
			CS$<>8__locals1.<>4__this = this;
			DataLayersTransitionTask.<>c__DisplayClass60_0 CS$<>8__locals2 = CS$<>8__locals1;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CS$<>8__locals2.actorComponent = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			DataLayersTransitionTask.<>c__DisplayClass60_0 CS$<>8__locals3 = CS$<>8__locals1;
			CharacterActorComponent actorComponent = CS$<>8__locals1.actorComponent;
			CS$<>8__locals3.startLocation = ((actorComponent != null) ? actorComponent.ActorLocationProxy : null);
			if (!this.ShouldAbortOnPlayerDrift || CS$<>8__locals1.actorComponent == null || CS$<>8__locals1.startLocation == null)
			{
				return () => false;
			}
			CS$<>8__locals1.driftTmp = Vector.Create();
			return delegate()
			{
				CS$<>8__locals1.actorComponent.ActorLocationProxy.Subtraction(CS$<>8__locals1.startLocation, CS$<>8__locals1.driftTmp);
				return CS$<>8__locals1.driftTmp.SizeSquared() > (double)CS$<>8__locals1.<>4__this.DriftAbortDistanceSquare;
			};
		}

		// Token: 0x0602FD9F RID: 195999 RVA: 0x00D5B534 File Offset: 0x00D59734
		private UniTask TransitionPartLoadDataLayer()
		{
			DataLayersTransitionTask.<TransitionPartLoadDataLayer>d__61 <TransitionPartLoadDataLayer>d__;
			<TransitionPartLoadDataLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartLoadDataLayer>d__.<>4__this = this;
			<TransitionPartLoadDataLayer>d__.<>1__state = -1;
			<TransitionPartLoadDataLayer>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartLoadDataLayer>d__61>(ref <TransitionPartLoadDataLayer>d__);
			return <TransitionPartLoadDataLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA0 RID: 196000 RVA: 0x00D5B578 File Offset: 0x00D59778
		private UniTask TryWaitDataLayerStreaming(HashSet<FName> dataLayerNames, bool considerVoxel, bool modifyBudget, ELoadMode loadMode, float maxWaitTime)
		{
			DataLayersTransitionTask.<TryWaitDataLayerStreaming>d__62 <TryWaitDataLayerStreaming>d__;
			<TryWaitDataLayerStreaming>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryWaitDataLayerStreaming>d__.<>4__this = this;
			<TryWaitDataLayerStreaming>d__.dataLayerNames = dataLayerNames;
			<TryWaitDataLayerStreaming>d__.considerVoxel = considerVoxel;
			<TryWaitDataLayerStreaming>d__.modifyBudget = modifyBudget;
			<TryWaitDataLayerStreaming>d__.loadMode = loadMode;
			<TryWaitDataLayerStreaming>d__.maxWaitTime = maxWaitTime;
			<TryWaitDataLayerStreaming>d__.<>1__state = -1;
			<TryWaitDataLayerStreaming>d__.<>t__builder.Start<DataLayersTransitionTask.<TryWaitDataLayerStreaming>d__62>(ref <TryWaitDataLayerStreaming>d__);
			return <TryWaitDataLayerStreaming>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA1 RID: 196001 RVA: 0x00D5B5E8 File Offset: 0x00D597E8
		private UniTask TransitionPartUnloadDataLayer()
		{
			DataLayersTransitionTask.<TransitionPartUnloadDataLayer>d__63 <TransitionPartUnloadDataLayer>d__;
			<TransitionPartUnloadDataLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartUnloadDataLayer>d__.<>4__this = this;
			<TransitionPartUnloadDataLayer>d__.<>1__state = -1;
			<TransitionPartUnloadDataLayer>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartUnloadDataLayer>d__63>(ref <TransitionPartUnloadDataLayer>d__);
			return <TransitionPartUnloadDataLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA2 RID: 196002 RVA: 0x00D5B62B File Offset: 0x00D5982B
		private void TransitionPartResetMat()
		{
			UKuroSceneModifierSubsystem kuroSceneModifierSubsystem = this.GetKuroSceneModifierSubsystem();
			if (kuroSceneModifierSubsystem != null)
			{
				kuroSceneModifierSubsystem.ResetMaterialsByDataLayer(this.ToActivateDataLayerNamesUeSet);
			}
			UKuroSceneModifierSubsystem kuroSceneModifierSubsystem2 = this.GetKuroSceneModifierSubsystem();
			if (kuroSceneModifierSubsystem2 == null)
			{
				return;
			}
			kuroSceneModifierSubsystem2.ResetMaterialsByDataLayer(this.ToDeactivateDataLayerNamesUeSet);
		}

		// Token: 0x0602FDA3 RID: 196003 RVA: 0x00D5B65C File Offset: 0x00D5985C
		private void TransitionPartClearCustomCullFlag()
		{
			if (this.ShouldClearCustomCullFlag)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.CustomCullFlag 0", null);
				}, 1000f, null, null, true, 1f);
			}
		}

		// Token: 0x0602FDA4 RID: 196004 RVA: 0x00D5B6A8 File Offset: 0x00D598A8
		private UniTask TransitionPartRenderAssetsCheck()
		{
			DataLayersTransitionTask.<TransitionPartRenderAssetsCheck>d__66 <TransitionPartRenderAssetsCheck>d__;
			<TransitionPartRenderAssetsCheck>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartRenderAssetsCheck>d__.<>4__this = this;
			<TransitionPartRenderAssetsCheck>d__.<>1__state = -1;
			<TransitionPartRenderAssetsCheck>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartRenderAssetsCheck>d__66>(ref <TransitionPartRenderAssetsCheck>d__);
			return <TransitionPartRenderAssetsCheck>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA5 RID: 196005 RVA: 0x00D5B6EB File Offset: 0x00D598EB
		private void TransitionPartFixBornLocation()
		{
			if (this.ShouldEmitFixBornLocation)
			{
				EventSystem.Instance.Emit(EEventName.FixBornLocation);
			}
		}

		// Token: 0x0602FDA6 RID: 196006 RVA: 0x00D5B708 File Offset: 0x00D59908
		private UniTask TransitionPartPlaySeqToEnd()
		{
			DataLayersTransitionTask.<TransitionPartPlaySeqToEnd>d__68 <TransitionPartPlaySeqToEnd>d__;
			<TransitionPartPlaySeqToEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartPlaySeqToEnd>d__.<>4__this = this;
			<TransitionPartPlaySeqToEnd>d__.<>1__state = -1;
			<TransitionPartPlaySeqToEnd>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartPlaySeqToEnd>d__68>(ref <TransitionPartPlaySeqToEnd>d__);
			return <TransitionPartPlaySeqToEnd>d__.<>t__builder.Task;
		}

		// Token: 0x0602FDA7 RID: 196007 RVA: 0x00D5B74C File Offset: 0x00D5994C
		public unsafe void StopTask(bool success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[DataLayersTransitionTask] DataLayer过渡结束";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ToActivateDataLayerNames", this.ToActivateDataLayerNames);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ToDeactivateDataLayerNames", this.ToDeactivateDataLayerNames);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			SimpleLevelSequenceActor simpleLevelSequenceActor = this.SimpleLevelSequenceActor;
			if (simpleLevelSequenceActor != null)
			{
				simpleLevelSequenceActor.Clear();
			}
			this.SimpleLevelSequenceActor = null;
			Action<DataLayersTransitionTask, bool> taskFinishCallback = this.TaskFinishCallback;
			if (taskFinishCallback == null)
			{
				return;
			}
			taskFinishCallback(this, success);
		}

		// Token: 0x0602FDA8 RID: 196008 RVA: 0x00D5B804 File Offset: 0x00D59A04
		public unsafe void AbortTask()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[DataLayersTransitionTask] DataLayer过渡被中止，强制收到终态";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", this.TaskId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ToActivateDataLayerNames", this.ToActivateDataLayerNames);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ToDeactivateDataLayerNames", this.ToDeactivateDataLayerNames);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.AbortSignal.Abort();
		}

		// Token: 0x0401965F RID: 104031
		private const float DEFAULT_WAIT_DATALAYER_STREAMING_RADIUS = 3500f;

		// Token: 0x04019660 RID: 104032
		private static int MaxTaskId;

		// Token: 0x04019661 RID: 104033
		private readonly int TaskId;

		// Token: 0x04019662 RID: 104034
		public UKuroSceneMatModifyDataAsset MatDataForActivating;

		// Token: 0x04019663 RID: 104035
		public string MatPathForActivating;

		// Token: 0x04019664 RID: 104036
		public bool MatDataForActivatingLoaded;

		// Token: 0x04019665 RID: 104037
		public UKuroSceneMatModifyDataAsset MatDataForDeactivating;

		// Token: 0x04019666 RID: 104038
		public string MatPathForDeactivating;

		// Token: 0x04019667 RID: 104039
		public bool MatDataForDeactivatingLoaded;

		// Token: 0x04019668 RID: 104040
		public ULevelSequence SeqData;

		// Token: 0x04019669 RID: 104041
		public string SeqPath;

		// Token: 0x0401966A RID: 104042
		public bool SeqDataLoaded;

		// Token: 0x0401966B RID: 104043
		public string SeqMarkBeforeModifyMat;

		// Token: 0x0401966C RID: 104044
		public HashSet<FName> ToActivateDataLayerNames;

		// Token: 0x0401966D RID: 104045
		public HashSet<FName> ToDeactivateDataLayerNames;

		// Token: 0x0401966E RID: 104046
		public bool ShouldWaitDataLayersActivateFinish;

		// Token: 0x0401966F RID: 104047
		public bool ShouldConsiderVoxelDuringWaitDataLayersActivateFinish;

		// Token: 0x04019670 RID: 104048
		public float MaxTimeForWaitDataLayerActivateFinish;

		// Token: 0x04019671 RID: 104049
		public bool ShouldModifyBudgetDuringWaitDataLayerActivateFinish = true;

		// Token: 0x04019672 RID: 104050
		public ELoadMode TargetLoadModeDuringWaitDataLayerActivateFinish = ELoadMode.InGameLoading;

		// Token: 0x04019673 RID: 104051
		public bool ShouldWaitDataLayersDeactivateFinish;

		// Token: 0x04019674 RID: 104052
		public bool ShouldConsiderVoxelDuringWaitDataLayersDeactivateFinish;

		// Token: 0x04019675 RID: 104053
		public float MaxTimeForWaitDataLayerDeactivateFinish;

		// Token: 0x04019676 RID: 104054
		public bool ShouldModifyBudgetDuringWaitDataLayerDeactivateFinish = true;

		// Token: 0x04019677 RID: 104055
		public ELoadMode TargetLoadModeDuringWaitDataLayerDeactivateFinish = ELoadMode.InGameLoading;

		// Token: 0x04019678 RID: 104056
		public float WaitDataLayerStreamingRadius = 3500f;

		// Token: 0x04019679 RID: 104057
		public bool IsServerControlledDataLayer;

		// Token: 0x0401967A RID: 104058
		public bool ShouldClearCustomCullFlag;

		// Token: 0x0401967B RID: 104059
		public bool ShouldCheckRenderAssets;

		// Token: 0x0401967C RID: 104060
		public float RenderAssetsCheckRadius = 7000f;

		// Token: 0x0401967D RID: 104061
		public float WaitRenderAssetsTimeout = 40f;

		// Token: 0x0401967E RID: 104062
		public bool ShouldEmitFixBornLocation;

		// Token: 0x0401967F RID: 104063
		public bool ShouldAbortOnPlayerDrift;

		// Token: 0x04019680 RID: 104064
		public float DriftAbortDistanceSquare = 10000f;

		// Token: 0x04019681 RID: 104065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DataLayersTransitionTask, bool> TaskFinishCallback;

		// Token: 0x04019682 RID: 104066
		[Nullable(1)]
		public ISequenceAbortSignal AbortSignal = new DataLayerTransitionAbortSignal();

		// Token: 0x04019683 RID: 104067
		private SimpleLevelSequenceActor SimpleLevelSequenceActor;

		// Token: 0x04019684 RID: 104068
		private TSet<FName> ToActivateDataLayerNamesUeSet;

		// Token: 0x04019685 RID: 104069
		private TSet<FName> ToDeactivateDataLayerNamesUeSet;

		// Token: 0x04019686 RID: 104070
		private UKuroSceneModifierSubsystem KuroSceneModifierSubsystemCache;

		// Token: 0x04019687 RID: 104071
		[Nullable(1)]
		private readonly HashSet<int> ActiveLoadIds = new HashSet<int>();

		// Token: 0x04019688 RID: 104072
		[Nullable(1)]
		private readonly HashSet<Action> ActivePollFinishers = new HashSet<Action>();
	}
}
