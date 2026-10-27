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
	// Token: 0x02005AD2 RID: 23250
	[NullableContext(2)]
	[Nullable(0)]
	public class DataLayersTransitionTask : IStaticVariableResetter
	{
		// Token: 0x0603AE1A RID: 241178 RVA: 0x00E09BE8 File Offset: 0x00E07DE8
		static DataLayersTransitionTask()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DataLayersTransitionTask.CreateStaticDefaultValue), new Action(DataLayersTransitionTask.ResetStaticDefaultValue));
		}

		// Token: 0x0603AE1B RID: 241179 RVA: 0x00E09C07 File Offset: 0x00E07E07
		public static void CreateStaticDefaultValue()
		{
			DataLayersTransitionTask.MaxTaskId = 0;
		}

		// Token: 0x0603AE1C RID: 241180 RVA: 0x00E09C0F File Offset: 0x00E07E0F
		public static void ResetStaticDefaultValue()
		{
			DataLayersTransitionTask.MaxTaskId = 0;
		}

		// Token: 0x0603AE1D RID: 241181 RVA: 0x00E09C18 File Offset: 0x00E07E18
		public DataLayersTransitionTask()
		{
			this.TaskId = ++DataLayersTransitionTask.MaxTaskId;
		}

		// Token: 0x0603AE1E RID: 241182 RVA: 0x00E09CA8 File Offset: 0x00E07EA8
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

		// Token: 0x0603AE1F RID: 241183 RVA: 0x00E09D40 File Offset: 0x00E07F40
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

		// Token: 0x0603AE20 RID: 241184 RVA: 0x00E09DEC File Offset: 0x00E07FEC
		[NullableContext(1)]
		private void InitUeContainerFromSet(HashSet<FName> inSet, TArray<FName> outUeSet)
		{
			outUeSet.Empty(true);
			foreach (FName value in inSet)
			{
				outUeSet.Add(value);
			}
		}

		// Token: 0x0603AE21 RID: 241185 RVA: 0x00E09E44 File Offset: 0x00E08044
		[NullableContext(1)]
		private void InitUeContainerFromSet(HashSet<FName> inSet, TSet<FName> outUeSet)
		{
			outUeSet.Empty(0);
			foreach (FName value in inSet)
			{
				outUeSet.Add(value);
			}
		}

		// Token: 0x0603AE22 RID: 241186 RVA: 0x00E09E9C File Offset: 0x00E0809C
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

		// Token: 0x0603AE23 RID: 241187 RVA: 0x00E09F6C File Offset: 0x00E0816C
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

		// Token: 0x0603AE24 RID: 241188 RVA: 0x00E0A0B4 File Offset: 0x00E082B4
		private UniTask TransitionPartLoadResources()
		{
			DataLayersTransitionTask.<TransitionPartLoadResources>d__51 <TransitionPartLoadResources>d__;
			<TransitionPartLoadResources>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartLoadResources>d__.<>4__this = this;
			<TransitionPartLoadResources>d__.<>1__state = -1;
			<TransitionPartLoadResources>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartLoadResources>d__51>(ref <TransitionPartLoadResources>d__);
			return <TransitionPartLoadResources>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE25 RID: 241189 RVA: 0x00E0A0F8 File Offset: 0x00E082F8
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

		// Token: 0x0603AE26 RID: 241190 RVA: 0x00E0A16E File Offset: 0x00E0836E
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

		// Token: 0x0603AE27 RID: 241191 RVA: 0x00E0A1AC File Offset: 0x00E083AC
		private void OnTransitionAborted()
		{
			SimpleLevelSequenceActor simpleLevelSequenceActor = this.SimpleLevelSequenceActor;
			if (simpleLevelSequenceActor != null && simpleLevelSequenceActor.IsPlaying())
			{
				UMovieSceneSequencePlayer player = simpleLevelSequenceActor.GetPlayer();
				if (player != null && player.IsValid())
				{
					FQualifiedFrameTime endTime = player.GetEndTime();
					player.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(endTime.Time, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Jump));
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

		// Token: 0x0603AE28 RID: 241192 RVA: 0x00E0A314 File Offset: 0x00E08514
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

		// Token: 0x0603AE29 RID: 241193 RVA: 0x00E0A4C0 File Offset: 0x00E086C0
		private UniTask TransitionPartPlaySeqToBeforeModifyMatMark()
		{
			DataLayersTransitionTask.<TransitionPartPlaySeqToBeforeModifyMatMark>d__56 <TransitionPartPlaySeqToBeforeModifyMatMark>d__;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>4__this = this;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>1__state = -1;
			<TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartPlaySeqToBeforeModifyMatMark>d__56>(ref <TransitionPartPlaySeqToBeforeModifyMatMark>d__);
			return <TransitionPartPlaySeqToBeforeModifyMatMark>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE2A RID: 241194 RVA: 0x00E0A504 File Offset: 0x00E08704
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

		// Token: 0x0603AE2B RID: 241195 RVA: 0x00E0A574 File Offset: 0x00E08774
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

		// Token: 0x0603AE2C RID: 241196 RVA: 0x00E0A7B4 File Offset: 0x00E089B4
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

		// Token: 0x0603AE2D RID: 241197 RVA: 0x00E0A84C File Offset: 0x00E08A4C
		private UniTask TransitionPartLoadDataLayer()
		{
			DataLayersTransitionTask.<TransitionPartLoadDataLayer>d__61 <TransitionPartLoadDataLayer>d__;
			<TransitionPartLoadDataLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartLoadDataLayer>d__.<>4__this = this;
			<TransitionPartLoadDataLayer>d__.<>1__state = -1;
			<TransitionPartLoadDataLayer>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartLoadDataLayer>d__61>(ref <TransitionPartLoadDataLayer>d__);
			return <TransitionPartLoadDataLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE2E RID: 241198 RVA: 0x00E0A890 File Offset: 0x00E08A90
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

		// Token: 0x0603AE2F RID: 241199 RVA: 0x00E0A900 File Offset: 0x00E08B00
		private UniTask TransitionPartUnloadDataLayer()
		{
			DataLayersTransitionTask.<TransitionPartUnloadDataLayer>d__63 <TransitionPartUnloadDataLayer>d__;
			<TransitionPartUnloadDataLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartUnloadDataLayer>d__.<>4__this = this;
			<TransitionPartUnloadDataLayer>d__.<>1__state = -1;
			<TransitionPartUnloadDataLayer>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartUnloadDataLayer>d__63>(ref <TransitionPartUnloadDataLayer>d__);
			return <TransitionPartUnloadDataLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE30 RID: 241200 RVA: 0x00E0A943 File Offset: 0x00E08B43
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

		// Token: 0x0603AE31 RID: 241201 RVA: 0x00E0A974 File Offset: 0x00E08B74
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

		// Token: 0x0603AE32 RID: 241202 RVA: 0x00E0A9C0 File Offset: 0x00E08BC0
		private UniTask TransitionPartRenderAssetsCheck()
		{
			DataLayersTransitionTask.<TransitionPartRenderAssetsCheck>d__66 <TransitionPartRenderAssetsCheck>d__;
			<TransitionPartRenderAssetsCheck>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartRenderAssetsCheck>d__.<>4__this = this;
			<TransitionPartRenderAssetsCheck>d__.<>1__state = -1;
			<TransitionPartRenderAssetsCheck>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartRenderAssetsCheck>d__66>(ref <TransitionPartRenderAssetsCheck>d__);
			return <TransitionPartRenderAssetsCheck>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE33 RID: 241203 RVA: 0x00E0AA03 File Offset: 0x00E08C03
		private void TransitionPartFixBornLocation()
		{
			if (this.ShouldEmitFixBornLocation)
			{
				EventSystem.Instance.Emit(EEventName.FixBornLocation);
			}
		}

		// Token: 0x0603AE34 RID: 241204 RVA: 0x00E0AA20 File Offset: 0x00E08C20
		private UniTask TransitionPartPlaySeqToEnd()
		{
			DataLayersTransitionTask.<TransitionPartPlaySeqToEnd>d__68 <TransitionPartPlaySeqToEnd>d__;
			<TransitionPartPlaySeqToEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TransitionPartPlaySeqToEnd>d__.<>4__this = this;
			<TransitionPartPlaySeqToEnd>d__.<>1__state = -1;
			<TransitionPartPlaySeqToEnd>d__.<>t__builder.Start<DataLayersTransitionTask.<TransitionPartPlaySeqToEnd>d__68>(ref <TransitionPartPlaySeqToEnd>d__);
			return <TransitionPartPlaySeqToEnd>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE35 RID: 241205 RVA: 0x00E0AA64 File Offset: 0x00E08C64
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

		// Token: 0x0603AE36 RID: 241206 RVA: 0x00E0AB1C File Offset: 0x00E08D1C
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

		// Token: 0x0401EBA3 RID: 125859
		private const float DEFAULT_WAIT_DATALAYER_STREAMING_RADIUS = 3500f;

		// Token: 0x0401EBA4 RID: 125860
		private static int MaxTaskId;

		// Token: 0x0401EBA5 RID: 125861
		private readonly int TaskId;

		// Token: 0x0401EBA6 RID: 125862
		public UKuroSceneMatModifyDataAsset MatDataForActivating;

		// Token: 0x0401EBA7 RID: 125863
		public string MatPathForActivating;

		// Token: 0x0401EBA8 RID: 125864
		public bool MatDataForActivatingLoaded;

		// Token: 0x0401EBA9 RID: 125865
		public UKuroSceneMatModifyDataAsset MatDataForDeactivating;

		// Token: 0x0401EBAA RID: 125866
		public string MatPathForDeactivating;

		// Token: 0x0401EBAB RID: 125867
		public bool MatDataForDeactivatingLoaded;

		// Token: 0x0401EBAC RID: 125868
		public ULevelSequence SeqData;

		// Token: 0x0401EBAD RID: 125869
		public string SeqPath;

		// Token: 0x0401EBAE RID: 125870
		public bool SeqDataLoaded;

		// Token: 0x0401EBAF RID: 125871
		public string SeqMarkBeforeModifyMat;

		// Token: 0x0401EBB0 RID: 125872
		public HashSet<FName> ToActivateDataLayerNames;

		// Token: 0x0401EBB1 RID: 125873
		public HashSet<FName> ToDeactivateDataLayerNames;

		// Token: 0x0401EBB2 RID: 125874
		public bool ShouldWaitDataLayersActivateFinish;

		// Token: 0x0401EBB3 RID: 125875
		public bool ShouldConsiderVoxelDuringWaitDataLayersActivateFinish;

		// Token: 0x0401EBB4 RID: 125876
		public float MaxTimeForWaitDataLayerActivateFinish;

		// Token: 0x0401EBB5 RID: 125877
		public bool ShouldModifyBudgetDuringWaitDataLayerActivateFinish = true;

		// Token: 0x0401EBB6 RID: 125878
		public ELoadMode TargetLoadModeDuringWaitDataLayerActivateFinish = ELoadMode.InGameLoading;

		// Token: 0x0401EBB7 RID: 125879
		public bool ShouldWaitDataLayersDeactivateFinish;

		// Token: 0x0401EBB8 RID: 125880
		public bool ShouldConsiderVoxelDuringWaitDataLayersDeactivateFinish;

		// Token: 0x0401EBB9 RID: 125881
		public float MaxTimeForWaitDataLayerDeactivateFinish;

		// Token: 0x0401EBBA RID: 125882
		public bool ShouldModifyBudgetDuringWaitDataLayerDeactivateFinish = true;

		// Token: 0x0401EBBB RID: 125883
		public ELoadMode TargetLoadModeDuringWaitDataLayerDeactivateFinish = ELoadMode.InGameLoading;

		// Token: 0x0401EBBC RID: 125884
		public float WaitDataLayerStreamingRadius = 3500f;

		// Token: 0x0401EBBD RID: 125885
		public bool IsServerControlledDataLayer;

		// Token: 0x0401EBBE RID: 125886
		public bool ShouldClearCustomCullFlag;

		// Token: 0x0401EBBF RID: 125887
		public bool ShouldCheckRenderAssets;

		// Token: 0x0401EBC0 RID: 125888
		public float RenderAssetsCheckRadius = 7000f;

		// Token: 0x0401EBC1 RID: 125889
		public float WaitRenderAssetsTimeout = 40f;

		// Token: 0x0401EBC2 RID: 125890
		public bool ShouldEmitFixBornLocation;

		// Token: 0x0401EBC3 RID: 125891
		public bool ShouldAbortOnPlayerDrift;

		// Token: 0x0401EBC4 RID: 125892
		public float DriftAbortDistanceSquare = 10000f;

		// Token: 0x0401EBC5 RID: 125893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DataLayersTransitionTask, bool> TaskFinishCallback;

		// Token: 0x0401EBC6 RID: 125894
		[Nullable(1)]
		public ISequenceAbortSignal AbortSignal = new DataLayerTransitionAbortSignal();

		// Token: 0x0401EBC7 RID: 125895
		private SimpleLevelSequenceActor SimpleLevelSequenceActor;

		// Token: 0x0401EBC8 RID: 125896
		private TSet<FName> ToActivateDataLayerNamesUeSet;

		// Token: 0x0401EBC9 RID: 125897
		private TSet<FName> ToDeactivateDataLayerNamesUeSet;

		// Token: 0x0401EBCA RID: 125898
		private UKuroSceneModifierSubsystem KuroSceneModifierSubsystemCache;

		// Token: 0x0401EBCB RID: 125899
		[Nullable(1)]
		private readonly HashSet<int> ActiveLoadIds = new HashSet<int>();

		// Token: 0x0401EBCC RID: 125900
		[Nullable(1)]
		private readonly HashSet<Action> ActivePollFinishers = new HashSet<Action>();
	}
}
