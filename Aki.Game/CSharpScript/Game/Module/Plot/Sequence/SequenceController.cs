using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence.Assistant;
using CSharpScript.Game.Module.Plot.Sequence.NpcPerformState;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FDB RID: 16347
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SequenceController : ControllerWithAssistantBase
	{
		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x060295D9 RID: 169433 RVA: 0x00BA5EB6 File Offset: 0x00BA40B6
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060295DA RID: 169434 RVA: 0x00BA5EB9 File Offset: 0x00BA40B9
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			this.Model = SequenceModel.Instance;
			SequenceRenderSettings.SetupSequenceSetting();
			return result;
		}

		// Token: 0x060295DB RID: 169435 RVA: 0x00BA5ED4 File Offset: 0x00BA40D4
		protected override bool OnClear()
		{
			if (this.Model != null)
			{
				this.Model.State = ESequenceState.Ending;
				this.FinishCheckRenderDataWait(null);
				this.Model.State = ESequenceState.Null;
			}
			this.Model = null;
			return base.OnClear();
		}

		// Token: 0x060295DC RID: 169436 RVA: 0x00BA5F20 File Offset: 0x00BA4120
		protected override void OnTick(float delta)
		{
			if (this.Model.PlayOptions != null)
			{
				this.CameraAssistant.UpdateFollowSequencePlayerCameraAnchor();
			}
			if (this.Model.DisableMotionBlurFrame > 0f)
			{
				this.Model.DisableMotionBlurFrame -= 1f;
				if (this.Model.DisableMotionBlurFrame == 0f)
				{
					this.RenderAssistant.SetMotionBlurState(true);
				}
			}
			if (this.Model.BeginSwitchFrame > 0f)
			{
				this.Model.BeginSwitchFrame -= 1f;
				if (this.Model.BeginSwitchFrame == 0f)
				{
					ActorAssistant actorAssistant = this.ActorAssistant;
					if (actorAssistant != null && actorAssistant.ShouldDelayEndSwitchPose())
					{
						this.Model.BeginSwitchFrame = 1f;
						goto IL_12C;
					}
				}
				if (this.Model.BeginSwitchFrame == 0f)
				{
					if (this.ActorAssistant != null)
					{
						this.ActorAssistant.EndSwitchPose();
						PlotBlendController instance = PlotBlendController.Instance;
						PlaySequenceData config = this.Model.Config;
						instance.TryExecuteBlend((config != null) ? config.Path : null).Forget<bool>();
					}
					else
					{
						global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.ZWY, "SwitchPose 失败!", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			}
			IL_12C:
			this.FlushDialogueState();
			this.RenderAssistant.TickPreStream();
			if (this.CheckRenderDataPromise != null)
			{
				this.CheckSeqStreamingData();
			}
		}

		// Token: 0x060295DD RID: 169437 RVA: 0x00BA6078 File Offset: 0x00BA4278
		protected override void RegisterAssistant()
		{
			base.AddAssistant(0, new SequenceAssistant());
			base.AddAssistant(1, new ActorAssistant());
			base.AddAssistant(2, new FunctionAssistant());
			base.AddAssistant(3, new CameraAssistant());
			base.AddAssistant(4, new RenderAssistant());
			base.AddAssistant(5, new FlowAssistant());
			base.AddAssistant(6, new UiAssistant());
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x060295DE RID: 169438 RVA: 0x00BA60D9 File Offset: 0x00BA42D9
		private SequenceAssistant SequenceAssistant
		{
			get
			{
				return this.Assistants[0] as SequenceAssistant;
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x060295DF RID: 169439 RVA: 0x00BA60EC File Offset: 0x00BA42EC
		private ActorAssistant ActorAssistant
		{
			get
			{
				return this.Assistants[1] as ActorAssistant;
			}
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x060295E0 RID: 169440 RVA: 0x00BA60FF File Offset: 0x00BA42FF
		private FunctionAssistant FunctionAssistant
		{
			get
			{
				return this.Assistants[2] as FunctionAssistant;
			}
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x060295E1 RID: 169441 RVA: 0x00BA6112 File Offset: 0x00BA4312
		private CameraAssistant CameraAssistant
		{
			get
			{
				return this.Assistants[3] as CameraAssistant;
			}
		}

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x060295E2 RID: 169442 RVA: 0x00BA6125 File Offset: 0x00BA4325
		private RenderAssistant RenderAssistant
		{
			get
			{
				return this.Assistants[4] as RenderAssistant;
			}
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x060295E3 RID: 169443 RVA: 0x00BA6138 File Offset: 0x00BA4338
		private FlowAssistant FlowAssistant
		{
			get
			{
				return this.Assistants[5] as FlowAssistant;
			}
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x060295E4 RID: 169444 RVA: 0x00BA614B File Offset: 0x00BA434B
		private UiAssistant UiAssistant
		{
			get
			{
				return this.Assistants[6] as UiAssistant;
			}
		}

		// Token: 0x060295E5 RID: 169445 RVA: 0x00BA6160 File Offset: 0x00BA4360
		public void Play(PlaySequenceData config, List<string> preLoadMouthKeys, [Nullable(2)] Action<bool> callback = null, bool seamless = false)
		{
			if (this.Model != null && this.Model.IsPlaying)
			{
				FlowController.Instance.LogError("重复播放剧情Sequence，当前一次只能播放一段", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (config == null)
			{
				FlowController.Instance.LogError("播放剧情Sequence配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (preLoadMouthKeys != null && preLoadMouthKeys.Count > 0)
			{
				this.ActorAssistant.PreLoadMouthAssetName = preLoadMouthKeys;
			}
			else
			{
				this.ActorAssistant.PreLoadMouthAssetName.Clear();
			}
			this.Model.Config = config;
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			SequenceModel model = this.Model;
			EPlotCameraMode? cameraMode = plotConfig.CameraMode;
			EntityControlRuntimeOptions entityControlOptions = plotConfig.EntityControlOptions;
			bool isSubtitleUiUse = true;
			FlowContext currentContext = FlowController.Instance.GetCurrentContext();
			model.PlayOptions = new SequencePlayOptions(cameraMode, entityControlOptions, isSubtitleUiUse, currentContext != null && currentContext.IsWaitRenderData, 1f);
			this.Model.IsSeamless = seamless;
			this.Model.FinishCallback = callback;
			if (config.SeqBlendAnim != null)
			{
				PlotBlendController.Instance.SetupInfo(config.SeqBlendAnim, config.Path);
			}
			this.Load(delegate(bool result)
			{
				if (this.Model.IsEnding)
				{
					return;
				}
				if (!result)
				{
					FlowController.Instance.LogError("资源加载失败，不播放Sequence", default(ReadOnlySpan<ValueTuple<string, object>>));
					FlowController.Instance.MarkClientError("SequenceLoadFailed");
					this.EndPlay();
					this.DoCallback(false);
					return;
				}
				this.Setup(delegate(bool result)
				{
					if (this.Model.IsEnding)
					{
						return;
					}
					if (!result)
					{
						FlowController.Instance.MarkClientError("SequenceSetupFailed");
						this.EndPlay();
						this.DoCallback(false);
						return;
					}
					this.StartPlay(delegate(bool result)
					{
						if (this.Model.IsEnding)
						{
							return;
						}
						if (!result)
						{
							this.EndPlay();
							this.DoCallback(false);
							return;
						}
						this.StopPlay(delegate(bool result)
						{
							if (this.Model.IsEnding)
							{
								return;
							}
							if (!result)
							{
								this.EndPlay();
							}
							this.Model.Reset();
							this.DoCallback(result);
						});
					});
				});
			});
		}

		// Token: 0x060295E6 RID: 169446 RVA: 0x00BA628D File Offset: 0x00BA448D
		public void LoadData(PlaySequenceData config, Action callback)
		{
			this.Model.State = ESequenceState.Loading;
			this.Model.Config = config;
			this.SequenceAssistant.LoadNecessaryData(callback);
		}

		// Token: 0x060295E7 RID: 169447 RVA: 0x00BA62B4 File Offset: 0x00BA44B4
		public void ManualFinish()
		{
			if (this.Model.State == ESequenceState.Null || this.Model.State == ESequenceState.Stopping || this.Model.State == ESequenceState.Ending)
			{
				this.Model.FinishCallback = null;
				return;
			}
			SequenceModel.Instance.IsSeamless = false;
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "剧情Sequence强制停止", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.EndPlay();
			this.Model.Reset();
		}

		// Token: 0x060295E8 RID: 169448 RVA: 0x00BA6330 File Offset: 0x00BA4530
		private void Load(Action<bool> callback)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[剧情加载等待] Sequence加载-开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (StringUtils.IsEmpty(this.Model.Config.Path))
			{
				return;
			}
			this.Model.State = ESequenceState.Loading;
			UniTask<bool> task = this.UiAssistant.LoadPromise();
			UniTask<bool> task2 = this.ActorAssistant.BeginLoadMouthAssetPromise();
			CustomPromise<bool?> promise = new CustomPromise<bool?>();
			CustomPromise<bool> preloadUiPromise = new CustomPromise<bool>();
			CustomPromise<bool> forceStreamPromise = new CustomPromise<bool>();
			this.ForceStreamPromise = forceStreamPromise;
			Action<bool> <>9__3;
			Action<bool> <>9__2;
			this.SequenceAssistant.Load(delegate(bool result)
			{
				if (!result)
				{
					FlowController.Instance.LogError("Sequence加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					promise.SetResult(new bool?(false));
					preloadUiPromise.SetResult(false);
					forceStreamPromise.SetResult(false);
					return;
				}
				this.UiAssistant.PreloadUi(preloadUiPromise);
				this.RequestForceStreamSceneActors(forceStreamPromise);
				SeqBaseAssistant actorAssistant = this.ActorAssistant;
				Action<bool> callback2;
				if ((callback2 = <>9__2) == null)
				{
					callback2 = (<>9__2 = delegate(bool result)
					{
						if (!result)
						{
							promise.SetResult(new bool?(false));
							return;
						}
						SeqBaseAssistant functionAssistant = this.FunctionAssistant;
						Action<bool> callback3;
						if ((callback3 = <>9__3) == null)
						{
							callback3 = (<>9__3 = delegate(bool result)
							{
								if (!result)
								{
									promise.SetResult(new bool?(false));
									return;
								}
								if (this.Model.IsWaitRenderData)
								{
									this.CheckRenderDataPromise = promise;
									this.CheckSeqStreamingData();
									this.StartCheckRenderDataTimeout(promise);
									return;
								}
								this.CheckSeqStreamingData();
								promise.SetResult(new bool?(true));
							});
						}
						functionAssistant.Load(callback3);
					});
				}
				actorAssistant.Load(callback2);
			});
			UniTask.WhenAll<bool, bool, bool?, bool, bool>(task, task2, promise.Promise, preloadUiPromise.Promise, forceStreamPromise.Promise).ContinueWith(delegate(ValueTuple<bool, bool, bool?, bool, bool> promiseResult)
			{
				bool? item = promiseResult.Item3;
				if (item == null)
				{
					return;
				}
				bool flag = promiseResult.Item1 && promiseResult.Item2 && item.Value && promiseResult.Item4 && promiseResult.Item5;
				if (this.ForceStreamPromise == forceStreamPromise)
				{
					this.ForceStreamPromise = null;
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[剧情加载等待] Sequence加载-完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", flag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				callback(flag);
			}).Forget();
		}

		// Token: 0x060295E9 RID: 169449 RVA: 0x00BA642C File Offset: 0x00BA462C
		private unsafe void RequestForceStreamSceneActors(CustomPromise<bool> forceStreamPromise)
		{
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			if (sequenceData == null || !sequenceData.IsForceStreamSceneActor)
			{
				forceStreamPromise.SetResult(true);
				return;
			}
			BP_SequenceData_Generated_C generatedData = sequenceData.GeneratedData;
			TArray<FSoftObjectPath> tarray = (generatedData != null) ? generatedData.ActorRefs : null;
			if (tarray == null || tarray.Num() == 0)
			{
				forceStreamPromise.SetResult(true);
				return;
			}
			UKuroActorStreamingHandle handle = UKuroSequenceRuntimeFunctionLibrary.RequestActorExternalStreaming(GlobalData.World, tarray);
			if (handle == null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[剧情加载等待] 强制流送Actor跳过：非PartitionedWorld或子系统不可用", default(ReadOnlySpan<ValueTuple<string, object>>));
				forceStreamPromise.SetResult(true);
				return;
			}
			this.Model.ForceStreamHandle = handle;
			int num = tarray.Num();
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[剧情加载等待] 强制流送Actor-开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TimerHandle timeoutHandle = null;
			Action onCompleted = null;
			onCompleted = delegate()
			{
				handle.OnCompleted.Remove(onCompleted);
				if (timeoutHandle != null && TimerSystem.Instance.Has(timeoutHandle))
				{
					TimerSystem.Instance.Remove(timeoutHandle);
				}
				if (forceStreamPromise.IsPending)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Plot;
					ELogAuthor author2 = ELogAuthor.YZH;
					string message2 = "[剧情加载等待] 强制流送Actor-完成";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("loaded", handle.GetLoadedCount());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("requested", handle.GetRequestedCount());
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					forceStreamPromise.SetResult(true);
				}
			};
			handle.OnCompleted.Add(onCompleted);
			if (this.ForceStreamTimeoutMs > 0)
			{
				timeoutHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					timeoutHandle = null;
					if (forceStreamPromise.IsPending)
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Plot;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "[剧情加载等待] 强制流送Actor-超时";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timeoutMs", this.ForceStreamTimeoutMs);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("loaded", handle.GetLoadedCount());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("requested", handle.GetRequestedCount());
						instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						forceStreamPromise.SetResult(true);
					}
				}, (float)this.ForceStreamTimeoutMs, null, null, true, 1f);
			}
		}

		// Token: 0x060295EA RID: 169450 RVA: 0x00BA6594 File Offset: 0x00BA4794
		private void Setup(Action<bool> callback)
		{
			SequenceController.<>c__DisplayClass34_0 CS$<>8__locals1 = new SequenceController.<>c__DisplayClass34_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			this.Model.State = ESequenceState.PrePlay;
			this.FlowAssistant.PreAllPlay(null);
			this.SequenceAssistant.PreAllPlay(null);
			this.UiAssistant.PreAllPlay(null);
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			if (sequenceData != null && sequenceData.EnableStartTransformBlend)
			{
				this.ActorAssistant.StartTransformBlend(delegate
				{
					base.<Setup>g__DoPlay|0();
				});
				return;
			}
			CS$<>8__locals1.<Setup>g__DoPlay|0();
		}

		// Token: 0x060295EB RID: 169451 RVA: 0x00BA661C File Offset: 0x00BA481C
		private void StartPlay(Action<bool> callback)
		{
			EventSystem.Instance.Emit<float>(EEventName.PlotSequencePlay, this.Model.SequenceData.相机过渡时间);
			this.ActorAssistant.CheckHideBattleCharacter();
			SeqNpcPerformStateManager.Instance.OnBattleCharacterHidden("演出隐藏实机角色后");
			this.Model.State = ESequenceState.Playing;
			this.ForEachPlaySequence(callback);
			EventSystem.Instance.Emit(EEventName.PlotSequenceStarted);
			PlotModel.Instance.SeamlessLockState = false;
		}

		// Token: 0x060295EC RID: 169452 RVA: 0x00BA6694 File Offset: 0x00BA4894
		private void ForEachPlaySequence(Action<bool> callback)
		{
			this.FlowAssistant.PreEachPlay();
			this.SequenceAssistant.PreEachPlay();
			this.ActorAssistant.PreEachPlay();
			this.RenderAssistant.PreEachPlay();
			this.CameraAssistant.PreEachPlay();
			this.SequenceAssistant.Play(delegate
			{
				this.RenderAssistant.EachStop();
				this.SequenceAssistant.EachStop();
				this.UiAssistant.EachStop();
				this.FlowAssistant.EachStop();
				this.CameraAssistant.EachStop();
				if (this.Model.IsFinish())
				{
					EventSystem.Instance.Emit(EEventName.PlotSequenceEnd);
					callback(true);
					return;
				}
				this.WaitSubLevelThenContinue(callback).Forget();
			});
		}

		// Token: 0x060295ED RID: 169453 RVA: 0x00BA6704 File Offset: 0x00BA4904
		private UniTask WaitSubLevelThenContinue(Action<bool> callback)
		{
			SequenceController.<WaitSubLevelThenContinue>d__37 <WaitSubLevelThenContinue>d__;
			<WaitSubLevelThenContinue>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitSubLevelThenContinue>d__.<>4__this = this;
			<WaitSubLevelThenContinue>d__.callback = callback;
			<WaitSubLevelThenContinue>d__.<>1__state = -1;
			<WaitSubLevelThenContinue>d__.<>t__builder.Start<SequenceController.<WaitSubLevelThenContinue>d__37>(ref <WaitSubLevelThenContinue>d__);
			return <WaitSubLevelThenContinue>d__.<>t__builder.Task;
		}

		// Token: 0x060295EE RID: 169454 RVA: 0x00BA6750 File Offset: 0x00BA4950
		private UniTask CheckSwitchSubLevelWithTimeout()
		{
			SequenceController.<CheckSwitchSubLevelWithTimeout>d__38 <CheckSwitchSubLevelWithTimeout>d__;
			<CheckSwitchSubLevelWithTimeout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckSwitchSubLevelWithTimeout>d__.<>1__state = -1;
			<CheckSwitchSubLevelWithTimeout>d__.<>t__builder.Start<SequenceController.<CheckSwitchSubLevelWithTimeout>d__38>(ref <CheckSwitchSubLevelWithTimeout>d__);
			return <CheckSwitchSubLevelWithTimeout>d__.<>t__builder.Task;
		}

		// Token: 0x060295EF RID: 169455 RVA: 0x00BA678C File Offset: 0x00BA498C
		private void StopPlay(Action<bool> callback)
		{
			this.Model.State = ESequenceState.Stopping;
			this.FunctionAssistant.AllStop(null);
			this.RenderAssistant.AllStop(null);
			this.FlowAssistant.AllStop(null);
			this.UiAssistant.AllStop(null);
			UniTask<bool> task = this.ActorAssistant.AllStopPromise();
			UniTask<bool> task2 = this.CameraAssistant.AllStopPromise();
			this.CameraAssistant.AllStop(null);
			UniTask.WhenAll<bool, bool>(task, task2).ContinueWith(delegate(ValueTuple<bool, bool> result)
			{
				if (!result.Item1)
				{
					callback(false);
					return;
				}
				this.SequenceAssistant.AllStop(null);
				this.EndPlay();
				callback(true);
			});
		}

		// Token: 0x060295F0 RID: 169456 RVA: 0x00BA6824 File Offset: 0x00BA4A24
		private void EndPlay()
		{
			if (this.Model.IsEnding)
			{
				return;
			}
			this.Model.State = ESequenceState.Ending;
			this.FinishCheckRenderDataWait(null);
			if (this.ForceStreamPromise != null)
			{
				this.ForceStreamPromise.SetResult(false);
				this.ForceStreamPromise = null;
			}
			if (this.Model.ForceStreamHandle != null)
			{
				this.Model.ForceStreamHandle.Cancel();
				this.Model.ForceStreamHandle = null;
			}
			this.RenderAssistant.End();
			this.SequenceAssistant.End();
			this.ActorAssistant.End();
			this.UiAssistant.End();
			this.FunctionAssistant.End();
			this.FlowAssistant.End();
			this.CameraAssistant.End();
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClass(GlobalData.World, AKuroPostProcessVolume.StaticClass(), ref tarray);
			int num = tarray.Num();
			FName tag = new FName("SequencePostProcess");
			for (int i = 0; i < num; i++)
			{
				AKuroPostProcessVolume akuroPostProcessVolume = tarray.Get(i) as AKuroPostProcessVolume;
				if (akuroPostProcessVolume.ActorHasTag(tag))
				{
					akuroPostProcessVolume.Settings = new FPostProcessSettings();
				}
			}
			this.Model.State = ESequenceState.Null;
		}

		// Token: 0x060295F1 RID: 169457 RVA: 0x00BA695B File Offset: 0x00BA4B5B
		private void DoCallback(bool result)
		{
			if (this.Model.FinishCallback == null)
			{
				return;
			}
			Action<bool> finishCallback = this.Model.FinishCallback;
			this.Model.FinishCallback = null;
			finishCallback(result);
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x060295F2 RID: 169458 RVA: 0x00BA6988 File Offset: 0x00BA4B88
		public Event<ESequenceEventName, Delegate> Event
		{
			get
			{
				return this.UiAssistant.Event;
			}
		}

		// Token: 0x060295F3 RID: 169459 RVA: 0x00BA6995 File Offset: 0x00BA4B95
		public void SelectOption(int index, int talkItemId)
		{
			this.UiAssistant.HandleSelectedOption(index, talkItemId).Forget();
		}

		// Token: 0x060295F4 RID: 169460 RVA: 0x00BA69A9 File Offset: 0x00BA4BA9
		public void FinishSubtitle(int id)
		{
			this.UiAssistant.HandlePlotSubtitleEnd(id, true).Forget();
		}

		// Token: 0x060295F5 RID: 169461 RVA: 0x00BA69BD File Offset: 0x00BA4BBD
		public void JumpToNextSubtitleOrChildSeq()
		{
			this.SequenceAssistant.JumpToNextSubtitleOrChildSeq();
		}

		// Token: 0x060295F6 RID: 169462 RVA: 0x00BA69CA File Offset: 0x00BA4BCA
		public void AccelerateToNextSubtitleOrChildSeq(Action finishCallback)
		{
			this.SequenceAssistant.AccelerateToNextSubtitleOrChildSeq(finishCallback);
		}

		// Token: 0x060295F7 RID: 169463 RVA: 0x00BA69D8 File Offset: 0x00BA4BD8
		public void ClearAccelerateCallback()
		{
			this.SequenceAssistant.ClearAccelerateCallback();
		}

		// Token: 0x060295F8 RID: 169464 RVA: 0x00BA69E5 File Offset: 0x00BA4BE5
		[NullableContext(2)]
		public void PauseSequence(string reason = null)
		{
			this.SequenceAssistant.PauseSequence(reason);
		}

		// Token: 0x060295F9 RID: 169465 RVA: 0x00BA69F3 File Offset: 0x00BA4BF3
		[NullableContext(2)]
		public void ResumeSequence(string reason = null, bool? goToNextFrame = null)
		{
			this.SequenceAssistant.ResumeSequence(reason, goToNextFrame);
		}

		// Token: 0x060295FA RID: 169466 RVA: 0x00BA6A02 File Offset: 0x00BA4C02
		public void SetNextSequenceIndex(int index)
		{
			this.FlowAssistant.SetNextSequenceIndex(index);
		}

		// Token: 0x060295FB RID: 169467 RVA: 0x00BA6A10 File Offset: 0x00BA4C10
		public void CheckSeqStreamingData()
		{
			if (this.RenderAssistant.CheckSeqStreamingData())
			{
				this.FinishCheckRenderDataWait(new bool?(true));
			}
		}

		// Token: 0x060295FC RID: 169468 RVA: 0x00BA6A2C File Offset: 0x00BA4C2C
		private unsafe void StartCheckRenderDataTimeout(CustomPromise<bool?> promise)
		{
			SequenceController.<>c__DisplayClass53_0 CS$<>8__locals1 = new SequenceController.<>c__DisplayClass53_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.promise = promise;
			if (CS$<>8__locals1.promise != this.CheckRenderDataPromise || !CS$<>8__locals1.promise.IsPending)
			{
				return;
			}
			if (this.WaitRenderDataTimeoutMs <= 0)
			{
				return;
			}
			SequenceController.<>c__DisplayClass53_0 CS$<>8__locals2 = CS$<>8__locals1;
			SequenceModel model = this.Model;
			string daPath;
			if (model == null)
			{
				daPath = null;
			}
			else
			{
				PlaySequenceData config = model.Config;
				daPath = ((config != null) ? config.Path : null);
			}
			CS$<>8__locals2.daPath = daPath;
			FlowContext currentContext = FlowController.Instance.GetCurrentContext();
			CS$<>8__locals1.flowId = ((currentContext != null) ? currentContext.FormatId : null);
			CS$<>8__locals1.flowIncId = ((currentContext != null) ? new long?(currentContext.FlowIncId) : null);
			CS$<>8__locals1.plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			this.CheckRenderDataTimeoutHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (CS$<>8__locals1.<>4__this.CheckRenderDataPromise != CS$<>8__locals1.promise || !CS$<>8__locals1.promise.IsPending)
				{
					return;
				}
				CS$<>8__locals1.<>4__this.CheckRenderDataTimeoutHandle = null;
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[剧情加载等待] 手动流送等待超时，放行Sequence加载";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("daPath", CS$<>8__locals1.daPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowId", CS$<>8__locals1.flowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("flowIncId", CS$<>8__locals1.flowIncId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("plotLevel", CS$<>8__locals1.plotLevel);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("timeoutMs", CS$<>8__locals1.<>4__this.WaitRenderDataTimeoutMs);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				CS$<>8__locals1.<>4__this.FinishCheckRenderDataWait(new bool?(true));
			}, (float)this.WaitRenderDataTimeoutMs, null, null, true, 1f);
		}

		// Token: 0x060295FD RID: 169469 RVA: 0x00BA6B13 File Offset: 0x00BA4D13
		private void ClearCheckRenderDataTimeout()
		{
			if (this.CheckRenderDataTimeoutHandle != null && TimerSystem.Instance.Has(this.CheckRenderDataTimeoutHandle))
			{
				TimerSystem.Instance.Remove(this.CheckRenderDataTimeoutHandle);
			}
			this.CheckRenderDataTimeoutHandle = null;
		}

		// Token: 0x060295FE RID: 169470 RVA: 0x00BA6B47 File Offset: 0x00BA4D47
		private void FinishCheckRenderDataWait(bool? result)
		{
			CustomPromise<bool?> checkRenderDataPromise = this.CheckRenderDataPromise;
			this.CheckRenderDataPromise = null;
			this.ClearCheckRenderDataTimeout();
			if (checkRenderDataPromise == null)
			{
				return;
			}
			checkRenderDataPromise.SetResult(result);
		}

		// Token: 0x060295FF RID: 169471 RVA: 0x00BA6B67 File Offset: 0x00BA4D67
		public void FlushDialogueState()
		{
			this.UiAssistant.TriggerAllSubtitle();
		}

		// Token: 0x06029600 RID: 169472 RVA: 0x00BA6B74 File Offset: 0x00BA4D74
		public void TryApplyMouthAnim(string textKey, List<int> characterIdList)
		{
			this.ActorAssistant.TryApplyMouthAnim(textKey, characterIdList);
		}

		// Token: 0x06029601 RID: 169473 RVA: 0x00BA6B84 File Offset: 0x00BA4D84
		public void StopMouthAnim()
		{
			if (this.ActorAssistant == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "StopMouthAnim失败,this.ActorAssistant为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ActorAssistant.StopMouthAnim();
		}

		// Token: 0x06029602 RID: 169474 RVA: 0x00BA6BC1 File Offset: 0x00BA4DC1
		public void RunSequenceFrameEvents(string key)
		{
			this.FunctionAssistant.RunSequenceFrameEvents(key);
		}

		// Token: 0x06029603 RID: 169475 RVA: 0x00BA6BD0 File Offset: 0x00BA4DD0
		public void TriggerCutChange()
		{
			this.Model.DisableMotionBlurFrame = 2f;
			this.RenderAssistant.SetMotionBlurState(false);
			EPlotSequenceType? type = this.Model.Type;
			EPlotSequenceType eplotSequenceType = EPlotSequenceType.过场;
			if ((type.GetValueOrDefault() == eplotSequenceType & type != null) && this.SequenceAssistant.ReadNeedHidePlayer())
			{
				this.ActorAssistant.PlayerHide();
			}
			this.CameraAssistant.CalcPreloadLocation();
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.InvalidSeveralFrameOcculusion 5", null);
			if (GlobalData.IsSm5 && UKuroSequencePerformanceManager.GetPerformanceMode() == EKuroPerformanceMode.EPM_InPerformanceMode && UKuroSequencePerformanceManager.GetShadowUpdateCVar())
			{
				this.RenderAssistant.CmdShadowUpdate();
			}
		}

		// Token: 0x06029604 RID: 169476 RVA: 0x00BA6C79 File Offset: 0x00BA4E79
		public void ShowLogo(float time)
		{
			this.FunctionAssistant.ShowLogo(time);
		}

		// Token: 0x06029605 RID: 169477 RVA: 0x00BA6C87 File Offset: 0x00BA4E87
		public void OpenUiView(string assetPath, string spineName, bool needLoop = true, bool useFullscreenAdaptAnchor = false)
		{
			this.FunctionAssistant.OpenBackgroundImage(assetPath, spineName, needLoop, useFullscreenAdaptAnchor).Forget();
		}

		// Token: 0x06029606 RID: 169478 RVA: 0x00BA6C9E File Offset: 0x00BA4E9E
		public void OpenUiViewForArray(string assetPath, TArray<SpineThingsInfo> spineArray, bool useFullscreenAdaptAnchor = false)
		{
			this.FunctionAssistant.OpenBackgroundImageInArray(assetPath, spineArray, useFullscreenAdaptAnchor).Forget();
		}

		// Token: 0x06029607 RID: 169479 RVA: 0x00BA6CB3 File Offset: 0x00BA4EB3
		public void PlayUiLevelSequence(string seqName)
		{
			this.FunctionAssistant.PlayUiLevelSequence(seqName).Forget();
		}

		// Token: 0x06029608 RID: 169480 RVA: 0x00BA6CC6 File Offset: 0x00BA4EC6
		public void CloseUiView()
		{
			this.FunctionAssistant.CloseBackgroundImage().Forget();
		}

		// Token: 0x06029609 RID: 169481 RVA: 0x00BA6CD8 File Offset: 0x00BA4ED8
		public void PlaySpineAnim(string spineName, bool needLoop = true)
		{
			this.FunctionAssistant.PlaySpineAnim(spineName, needLoop);
		}

		// Token: 0x0602960A RID: 169482 RVA: 0x00BA6CE7 File Offset: 0x00BA4EE7
		public void PlaySpineAnimInArray(TArray<SpineThingsInfo> spineArray)
		{
			this.FunctionAssistant.PlaySpineAnimInArray(spineArray);
		}

		// Token: 0x0602960B RID: 169483 RVA: 0x00BA6CF5 File Offset: 0x00BA4EF5
		public void CloseSpineAnim(string spineName)
		{
			this.FunctionAssistant.CloseSpineAnimation(spineName);
		}

		// Token: 0x0602960C RID: 169484 RVA: 0x00BA6D03 File Offset: 0x00BA4F03
		public void CloseSpineAnimInArray(TArray<string> spineArray)
		{
			this.FunctionAssistant.CloseSpineAnimationInArray(spineArray);
		}

		// Token: 0x0602960D RID: 169485 RVA: 0x00BA6D11 File Offset: 0x00BA4F11
		public void DisableMotionBlurAwhile()
		{
			this.Model.DisableMotionBlurFrame = 2f;
			this.RenderAssistant.SetMotionBlurState(false);
		}

		// Token: 0x0602960E RID: 169486 RVA: 0x00BA6D2F File Offset: 0x00BA4F2F
		public void AdditionSeqPlay(ULevelSequence levelSequence, FName componentName, FName boneName, int frame)
		{
			this.FunctionAssistant.AdditionSeqPlay(levelSequence, componentName, boneName, frame);
		}

		// Token: 0x0602960F RID: 169487 RVA: 0x00BA6D41 File Offset: 0x00BA4F41
		public void AdditionSeqEnd()
		{
			this.FunctionAssistant.AdditionSeqEnd();
		}

		// Token: 0x06029610 RID: 169488 RVA: 0x00BA6D4E File Offset: 0x00BA4F4E
		public void EnableCameraShake(bool bEnable, TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
		{
			if (bEnable)
			{
				this.CameraAssistant.StartCameraShake(cameraShakePtr);
				return;
			}
			this.CameraAssistant.StopCameraShake(cameraShakePtr);
		}

		// Token: 0x06029611 RID: 169489 RVA: 0x00BA6D6C File Offset: 0x00BA4F6C
		public string GetCurrentSequenceDebugInfo()
		{
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			if (currentSequence == null)
			{
				return "";
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
			int valueOrDefault = num2.GetValueOrDefault();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler.AppendFormatted(currentSequence.GetName());
			defaultInterpolatedStringHandler.AppendLiteral("  Frame: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x06029612 RID: 169490 RVA: 0x00BA6E10 File Offset: 0x00BA5010
		public static SequenceController Instance
		{
			get
			{
				return SequenceController._Instance;
			}
		}

		// Token: 0x06029613 RID: 169491 RVA: 0x00BA6E17 File Offset: 0x00BA5017
		public static SequenceController GetOrCreateInstance()
		{
			if (SequenceController._Instance == null)
			{
				SequenceController.CreateInstance();
			}
			return SequenceController._Instance;
		}

		// Token: 0x06029614 RID: 169492 RVA: 0x00BA6E2B File Offset: 0x00BA502B
		public static bool CreateInstance()
		{
			if (SequenceController._Instance != null)
			{
				return true;
			}
			SequenceController._Instance = new SequenceController();
			return true;
		}

		// Token: 0x06029615 RID: 169493 RVA: 0x00BA6E41 File Offset: 0x00BA5041
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029616 RID: 169494 RVA: 0x00BA6E43 File Offset: 0x00BA5043
		public static void ResetStaticDefaultValue()
		{
			SequenceController._Instance = null;
		}

		// Token: 0x06029617 RID: 169495 RVA: 0x00BA6E4B File Offset: 0x00BA504B
		static SequenceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceController.CreateStaticDefaultValue), new Action(SequenceController.ResetStaticDefaultValue));
		}

		// Token: 0x040168EB RID: 92395
		[Nullable(2)]
		private CustomPromise<bool?> CheckRenderDataPromise;

		// Token: 0x040168EC RID: 92396
		[Nullable(2)]
		private CustomPromise<bool> ForceStreamPromise;

		// Token: 0x040168ED RID: 92397
		[Nullable(2)]
		private SequenceModel Model;

		// Token: 0x040168EE RID: 92398
		private const int DEFAULT_WAIT_SUB_LEVEL_TIMEOUT_S = 10;

		// Token: 0x040168EF RID: 92399
		private const int WAIT_RENDER_DATA_TIMEOUT_S = 40;

		// Token: 0x040168F0 RID: 92400
		private readonly int ForceStreamTimeoutMs = 10000;

		// Token: 0x040168F1 RID: 92401
		private readonly int WaitRenderDataTimeoutMs = 40000;

		// Token: 0x040168F2 RID: 92402
		[Nullable(2)]
		private TimerHandle CheckRenderDataTimeoutHandle;

		// Token: 0x040168F3 RID: 92403
		public bool GmForceCollectExtraTexture;

		// Token: 0x040168F4 RID: 92404
		[Nullable(2)]
		private static SequenceController _Instance;

		// Token: 0x02009B85 RID: 39813
		[NullableContext(0)]
		private enum EAssistantType
		{
			// Token: 0x04030713 RID: 198419
			SequenceAssistant,
			// Token: 0x04030714 RID: 198420
			ActorAssistant,
			// Token: 0x04030715 RID: 198421
			FunctionAssistant,
			// Token: 0x04030716 RID: 198422
			CameraAssistant,
			// Token: 0x04030717 RID: 198423
			RenderAssistant,
			// Token: 0x04030718 RID: 198424
			FlowAssistant,
			// Token: 0x04030719 RID: 198425
			UiAssistant
		}
	}
}
