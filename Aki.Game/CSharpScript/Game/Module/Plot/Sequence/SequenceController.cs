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
	// Token: 0x02005011 RID: 20497
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SequenceController : ControllerWithAssistantBase
	{
		// Token: 0x17007FF2 RID: 32754
		// (get) Token: 0x06034736 RID: 214838 RVA: 0x00C5A9B6 File Offset: 0x00C58BB6
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06034737 RID: 214839 RVA: 0x00C5A9B9 File Offset: 0x00C58BB9
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			this.Model = SequenceModel.Instance;
			SequenceRenderSettings.SetupSequenceSetting();
			return result;
		}

		// Token: 0x06034738 RID: 214840 RVA: 0x00C5A9D4 File Offset: 0x00C58BD4
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

		// Token: 0x06034739 RID: 214841 RVA: 0x00C5AA20 File Offset: 0x00C58C20
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
			this.FlushDialogueState();
			if (this.CheckRenderDataPromise != null)
			{
				this.CheckSeqStreamingData();
			}
		}

		// Token: 0x0603473A RID: 214842 RVA: 0x00C5AB38 File Offset: 0x00C58D38
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

		// Token: 0x17007FF3 RID: 32755
		// (get) Token: 0x0603473B RID: 214843 RVA: 0x00C5AB99 File Offset: 0x00C58D99
		private SequenceAssistant SequenceAssistant
		{
			get
			{
				return this.Assistants[0] as SequenceAssistant;
			}
		}

		// Token: 0x17007FF4 RID: 32756
		// (get) Token: 0x0603473C RID: 214844 RVA: 0x00C5ABAC File Offset: 0x00C58DAC
		private ActorAssistant ActorAssistant
		{
			get
			{
				return this.Assistants[1] as ActorAssistant;
			}
		}

		// Token: 0x17007FF5 RID: 32757
		// (get) Token: 0x0603473D RID: 214845 RVA: 0x00C5ABBF File Offset: 0x00C58DBF
		private FunctionAssistant FunctionAssistant
		{
			get
			{
				return this.Assistants[2] as FunctionAssistant;
			}
		}

		// Token: 0x17007FF6 RID: 32758
		// (get) Token: 0x0603473E RID: 214846 RVA: 0x00C5ABD2 File Offset: 0x00C58DD2
		private CameraAssistant CameraAssistant
		{
			get
			{
				return this.Assistants[3] as CameraAssistant;
			}
		}

		// Token: 0x17007FF7 RID: 32759
		// (get) Token: 0x0603473F RID: 214847 RVA: 0x00C5ABE5 File Offset: 0x00C58DE5
		private RenderAssistant RenderAssistant
		{
			get
			{
				return this.Assistants[4] as RenderAssistant;
			}
		}

		// Token: 0x17007FF8 RID: 32760
		// (get) Token: 0x06034740 RID: 214848 RVA: 0x00C5ABF8 File Offset: 0x00C58DF8
		private FlowAssistant FlowAssistant
		{
			get
			{
				return this.Assistants[5] as FlowAssistant;
			}
		}

		// Token: 0x17007FF9 RID: 32761
		// (get) Token: 0x06034741 RID: 214849 RVA: 0x00C5AC0B File Offset: 0x00C58E0B
		private UiAssistant UiAssistant
		{
			get
			{
				return this.Assistants[6] as UiAssistant;
			}
		}

		// Token: 0x06034742 RID: 214850 RVA: 0x00C5AC20 File Offset: 0x00C58E20
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

		// Token: 0x06034743 RID: 214851 RVA: 0x00C5AD4D File Offset: 0x00C58F4D
		public void LoadData(PlaySequenceData config, Action callback)
		{
			this.Model.State = ESequenceState.Loading;
			this.Model.Config = config;
			this.SequenceAssistant.LoadNecessaryData(callback);
		}

		// Token: 0x06034744 RID: 214852 RVA: 0x00C5AD74 File Offset: 0x00C58F74
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

		// Token: 0x06034745 RID: 214853 RVA: 0x00C5ADF0 File Offset: 0x00C58FF0
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

		// Token: 0x06034746 RID: 214854 RVA: 0x00C5AEEC File Offset: 0x00C590EC
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

		// Token: 0x06034747 RID: 214855 RVA: 0x00C5B054 File Offset: 0x00C59254
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

		// Token: 0x06034748 RID: 214856 RVA: 0x00C5B0DC File Offset: 0x00C592DC
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

		// Token: 0x06034749 RID: 214857 RVA: 0x00C5B154 File Offset: 0x00C59354
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

		// Token: 0x0603474A RID: 214858 RVA: 0x00C5B1C4 File Offset: 0x00C593C4
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

		// Token: 0x0603474B RID: 214859 RVA: 0x00C5B210 File Offset: 0x00C59410
		private UniTask CheckSwitchSubLevelWithTimeout()
		{
			SequenceController.<CheckSwitchSubLevelWithTimeout>d__38 <CheckSwitchSubLevelWithTimeout>d__;
			<CheckSwitchSubLevelWithTimeout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckSwitchSubLevelWithTimeout>d__.<>1__state = -1;
			<CheckSwitchSubLevelWithTimeout>d__.<>t__builder.Start<SequenceController.<CheckSwitchSubLevelWithTimeout>d__38>(ref <CheckSwitchSubLevelWithTimeout>d__);
			return <CheckSwitchSubLevelWithTimeout>d__.<>t__builder.Task;
		}

		// Token: 0x0603474C RID: 214860 RVA: 0x00C5B24C File Offset: 0x00C5944C
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

		// Token: 0x0603474D RID: 214861 RVA: 0x00C5B2E4 File Offset: 0x00C594E4
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

		// Token: 0x0603474E RID: 214862 RVA: 0x00C5B41B File Offset: 0x00C5961B
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

		// Token: 0x17007FFA RID: 32762
		// (get) Token: 0x0603474F RID: 214863 RVA: 0x00C5B448 File Offset: 0x00C59648
		public Event<ESequenceEventName, Delegate> Event
		{
			get
			{
				return this.UiAssistant.Event;
			}
		}

		// Token: 0x06034750 RID: 214864 RVA: 0x00C5B455 File Offset: 0x00C59655
		public void SelectOption(int index, int talkItemId)
		{
			this.UiAssistant.HandleSelectedOption(index, talkItemId).Forget();
		}

		// Token: 0x06034751 RID: 214865 RVA: 0x00C5B469 File Offset: 0x00C59669
		public void FinishSubtitle(int id)
		{
			this.UiAssistant.HandlePlotSubtitleEnd(id, true).Forget();
		}

		// Token: 0x06034752 RID: 214866 RVA: 0x00C5B47D File Offset: 0x00C5967D
		public void JumpToNextSubtitleOrChildSeq()
		{
			this.SequenceAssistant.JumpToNextSubtitleOrChildSeq();
		}

		// Token: 0x06034753 RID: 214867 RVA: 0x00C5B48A File Offset: 0x00C5968A
		public void AccelerateToNextSubtitleOrChildSeq(Action finishCallback)
		{
			this.SequenceAssistant.AccelerateToNextSubtitleOrChildSeq(finishCallback);
		}

		// Token: 0x06034754 RID: 214868 RVA: 0x00C5B498 File Offset: 0x00C59698
		public void ClearAccelerateCallback()
		{
			this.SequenceAssistant.ClearAccelerateCallback();
		}

		// Token: 0x06034755 RID: 214869 RVA: 0x00C5B4A5 File Offset: 0x00C596A5
		[NullableContext(2)]
		public void PauseSequence(string reason = null)
		{
			this.SequenceAssistant.PauseSequence(reason);
		}

		// Token: 0x06034756 RID: 214870 RVA: 0x00C5B4B3 File Offset: 0x00C596B3
		[NullableContext(2)]
		public void ResumeSequence(string reason = null, bool? goToNextFrame = null)
		{
			this.SequenceAssistant.ResumeSequence(reason, goToNextFrame);
		}

		// Token: 0x06034757 RID: 214871 RVA: 0x00C5B4C2 File Offset: 0x00C596C2
		public void SetNextSequenceIndex(int index)
		{
			this.FlowAssistant.SetNextSequenceIndex(index);
		}

		// Token: 0x06034758 RID: 214872 RVA: 0x00C5B4D0 File Offset: 0x00C596D0
		public void CheckSeqStreamingData()
		{
			if (this.RenderAssistant.CheckSeqStreamingData())
			{
				this.FinishCheckRenderDataWait(new bool?(true));
			}
		}

		// Token: 0x06034759 RID: 214873 RVA: 0x00C5B4EC File Offset: 0x00C596EC
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

		// Token: 0x0603475A RID: 214874 RVA: 0x00C5B5D3 File Offset: 0x00C597D3
		private void ClearCheckRenderDataTimeout()
		{
			if (this.CheckRenderDataTimeoutHandle != null && TimerSystem.Instance.Has(this.CheckRenderDataTimeoutHandle))
			{
				TimerSystem.Instance.Remove(this.CheckRenderDataTimeoutHandle);
			}
			this.CheckRenderDataTimeoutHandle = null;
		}

		// Token: 0x0603475B RID: 214875 RVA: 0x00C5B607 File Offset: 0x00C59807
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

		// Token: 0x0603475C RID: 214876 RVA: 0x00C5B627 File Offset: 0x00C59827
		public void FlushDialogueState()
		{
			this.UiAssistant.TriggerAllSubtitle();
		}

		// Token: 0x0603475D RID: 214877 RVA: 0x00C5B634 File Offset: 0x00C59834
		public void TryApplyMouthAnim(string textKey, List<int> characterIdList)
		{
			this.ActorAssistant.TryApplyMouthAnim(textKey, characterIdList);
		}

		// Token: 0x0603475E RID: 214878 RVA: 0x00C5B644 File Offset: 0x00C59844
		public void StopMouthAnim()
		{
			if (this.ActorAssistant == null)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "StopMouthAnim失败,this.ActorAssistant为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ActorAssistant.StopMouthAnim();
		}

		// Token: 0x0603475F RID: 214879 RVA: 0x00C5B681 File Offset: 0x00C59881
		public void RunSequenceFrameEvents(string key)
		{
			this.FunctionAssistant.RunSequenceFrameEvents(key);
		}

		// Token: 0x06034760 RID: 214880 RVA: 0x00C5B690 File Offset: 0x00C59890
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

		// Token: 0x06034761 RID: 214881 RVA: 0x00C5B739 File Offset: 0x00C59939
		public void ShowLogo(float time)
		{
			this.FunctionAssistant.ShowLogo(time);
		}

		// Token: 0x06034762 RID: 214882 RVA: 0x00C5B747 File Offset: 0x00C59947
		public void OpenUiView(string assetPath, string spineName, bool needLoop = true, bool useFullscreenAdaptAnchor = false)
		{
			this.FunctionAssistant.OpenBackgroundImage(assetPath, spineName, needLoop, useFullscreenAdaptAnchor).Forget();
		}

		// Token: 0x06034763 RID: 214883 RVA: 0x00C5B75E File Offset: 0x00C5995E
		public void OpenUiViewForArray(string assetPath, TArray<SpineThingsInfo> spineArray, bool useFullscreenAdaptAnchor = false)
		{
			this.FunctionAssistant.OpenBackgroundImageInArray(assetPath, spineArray, useFullscreenAdaptAnchor).Forget();
		}

		// Token: 0x06034764 RID: 214884 RVA: 0x00C5B773 File Offset: 0x00C59973
		public void PlayUiLevelSequence(string seqName)
		{
			this.FunctionAssistant.PlayUiLevelSequence(seqName).Forget();
		}

		// Token: 0x06034765 RID: 214885 RVA: 0x00C5B786 File Offset: 0x00C59986
		public void CloseUiView()
		{
			this.FunctionAssistant.CloseBackgroundImage().Forget();
		}

		// Token: 0x06034766 RID: 214886 RVA: 0x00C5B798 File Offset: 0x00C59998
		public void PlaySpineAnim(string spineName, bool needLoop = true)
		{
			this.FunctionAssistant.PlaySpineAnim(spineName, needLoop);
		}

		// Token: 0x06034767 RID: 214887 RVA: 0x00C5B7A7 File Offset: 0x00C599A7
		public void PlaySpineAnimInArray(TArray<SpineThingsInfo> spineArray)
		{
			this.FunctionAssistant.PlaySpineAnimInArray(spineArray);
		}

		// Token: 0x06034768 RID: 214888 RVA: 0x00C5B7B5 File Offset: 0x00C599B5
		public void CloseSpineAnim(string spineName)
		{
			this.FunctionAssistant.CloseSpineAnimation(spineName);
		}

		// Token: 0x06034769 RID: 214889 RVA: 0x00C5B7C3 File Offset: 0x00C599C3
		public void CloseSpineAnimInArray(TArray<string> spineArray)
		{
			this.FunctionAssistant.CloseSpineAnimationInArray(spineArray);
		}

		// Token: 0x0603476A RID: 214890 RVA: 0x00C5B7D1 File Offset: 0x00C599D1
		public void DisableMotionBlurAwhile()
		{
			this.Model.DisableMotionBlurFrame = 2f;
			this.RenderAssistant.SetMotionBlurState(false);
		}

		// Token: 0x0603476B RID: 214891 RVA: 0x00C5B7EF File Offset: 0x00C599EF
		public void AdditionSeqPlay(ULevelSequence levelSequence, FName componentName, FName boneName, int frame)
		{
			this.FunctionAssistant.AdditionSeqPlay(levelSequence, componentName, boneName, frame);
		}

		// Token: 0x0603476C RID: 214892 RVA: 0x00C5B801 File Offset: 0x00C59A01
		public void AdditionSeqEnd()
		{
			this.FunctionAssistant.AdditionSeqEnd();
		}

		// Token: 0x0603476D RID: 214893 RVA: 0x00C5B80E File Offset: 0x00C59A0E
		public void EnableCameraShake(bool bEnable, TSoftClassPtr<UMatineeCameraShake> cameraShakePtr)
		{
			if (bEnable)
			{
				this.CameraAssistant.StartCameraShake(cameraShakePtr);
				return;
			}
			this.CameraAssistant.StopCameraShake(cameraShakePtr);
		}

		// Token: 0x0603476E RID: 214894 RVA: 0x00C5B82C File Offset: 0x00C59A2C
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

		// Token: 0x17007FFB RID: 32763
		// (get) Token: 0x0603476F RID: 214895 RVA: 0x00C5B8D0 File Offset: 0x00C59AD0
		public static SequenceController Instance
		{
			get
			{
				return SequenceController._Instance;
			}
		}

		// Token: 0x06034770 RID: 214896 RVA: 0x00C5B8D7 File Offset: 0x00C59AD7
		public static SequenceController GetOrCreateInstance()
		{
			if (SequenceController._Instance == null)
			{
				SequenceController.CreateInstance();
			}
			return SequenceController._Instance;
		}

		// Token: 0x06034771 RID: 214897 RVA: 0x00C5B8EB File Offset: 0x00C59AEB
		public static bool CreateInstance()
		{
			if (SequenceController._Instance != null)
			{
				return true;
			}
			SequenceController._Instance = new SequenceController();
			return true;
		}

		// Token: 0x06034772 RID: 214898 RVA: 0x00C5B901 File Offset: 0x00C59B01
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034773 RID: 214899 RVA: 0x00C5B903 File Offset: 0x00C59B03
		public static void ResetStaticDefaultValue()
		{
			SequenceController._Instance = null;
		}

		// Token: 0x06034774 RID: 214900 RVA: 0x00C5B90B File Offset: 0x00C59B0B
		static SequenceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceController.CreateStaticDefaultValue), new Action(SequenceController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF02 RID: 114434
		[Nullable(2)]
		private CustomPromise<bool?> CheckRenderDataPromise;

		// Token: 0x0401BF03 RID: 114435
		[Nullable(2)]
		private CustomPromise<bool> ForceStreamPromise;

		// Token: 0x0401BF04 RID: 114436
		[Nullable(2)]
		private SequenceModel Model;

		// Token: 0x0401BF05 RID: 114437
		private const int DEFAULT_WAIT_SUB_LEVEL_TIMEOUT_S = 10;

		// Token: 0x0401BF06 RID: 114438
		private const int WAIT_RENDER_DATA_TIMEOUT_S = 40;

		// Token: 0x0401BF07 RID: 114439
		private readonly int ForceStreamTimeoutMs = 10000;

		// Token: 0x0401BF08 RID: 114440
		private readonly int WaitRenderDataTimeoutMs = 40000;

		// Token: 0x0401BF09 RID: 114441
		[Nullable(2)]
		private TimerHandle CheckRenderDataTimeoutHandle;

		// Token: 0x0401BF0A RID: 114442
		public bool GmForceCollectExtraTexture;

		// Token: 0x0401BF0B RID: 114443
		[Nullable(2)]
		private static SequenceController _Instance;

		// Token: 0x0200B14D RID: 45389
		[NullableContext(0)]
		private enum EAssistantType
		{
			// Token: 0x04035CCB RID: 220363
			SequenceAssistant,
			// Token: 0x04035CCC RID: 220364
			ActorAssistant,
			// Token: 0x04035CCD RID: 220365
			FunctionAssistant,
			// Token: 0x04035CCE RID: 220366
			CameraAssistant,
			// Token: 0x04035CCF RID: 220367
			RenderAssistant,
			// Token: 0x04035CD0 RID: 220368
			FlowAssistant,
			// Token: 0x04035CD1 RID: 220369
			UiAssistant
		}
	}
}
