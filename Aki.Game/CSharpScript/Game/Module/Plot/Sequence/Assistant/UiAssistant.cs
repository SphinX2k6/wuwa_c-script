using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.Sequence.Qte;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02004006 RID: 16390
	[NullableContext(1)]
	[Nullable(0)]
	public class UiAssistant : SeqBaseAssistant
	{
		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x060297D0 RID: 169936 RVA: 0x00BB5A36 File Offset: 0x00BB3C36
		private Dictionary<int, int> PendingOptionResult
		{
			get
			{
				return this.SequenceQteManger.PendingOptionResult;
			}
		}

		// Token: 0x060297D1 RID: 169937 RVA: 0x00BB5A44 File Offset: 0x00BB3C44
		[NullableContext(0)]
		public override UniTask<bool> LoadPromise()
		{
			UiAssistant.<LoadPromise>d__9 <LoadPromise>d__;
			<LoadPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadPromise>d__.<>4__this = this;
			<LoadPromise>d__.<>1__state = -1;
			<LoadPromise>d__.<>t__builder.Start<UiAssistant.<LoadPromise>d__9>(ref <LoadPromise>d__);
			return <LoadPromise>d__.<>t__builder.Task;
		}

		// Token: 0x060297D2 RID: 169938 RVA: 0x00BB5A87 File Offset: 0x00BB3C87
		private void OnViewDone(bool result)
		{
			CustomPromise<bool> promise = this.Promise;
			if (promise != null)
			{
				promise.SetResult(result);
			}
			this.Promise = null;
		}

		// Token: 0x060297D3 RID: 169939 RVA: 0x00BB5AA4 File Offset: 0x00BB3CA4
		[NullableContext(2)]
		public override void PreAllPlay(Action<bool> callback = null)
		{
			if (this.Model.IsSubtitleUiUse)
			{
				this.AddDialogueEvent();
			}
			PlotController.Instance.PlotViewManager.PlotDoingTextShow(this.Model.SequenceData.标识为演出制作中);
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			if (!(packageAudio == "zh"))
			{
				if (!(packageAudio == "ja"))
				{
					if (!(packageAudio == "ko"))
					{
						if (!(packageAudio == "en"))
						{
							this.Model.CurLanguageAudio = ELanguageAudio.All;
						}
						else
						{
							this.Model.CurLanguageAudio = ELanguageAudio.en;
						}
					}
					else
					{
						this.Model.CurLanguageAudio = ELanguageAudio.ko;
					}
				}
				else
				{
					this.Model.CurLanguageAudio = ELanguageAudio.ja;
				}
			}
			else
			{
				this.Model.CurLanguageAudio = ELanguageAudio.zh;
			}
			this.SequenceQteManger.Init();
		}

		// Token: 0x060297D4 RID: 169940 RVA: 0x00BB5B73 File Offset: 0x00BB3D73
		public override void EachStop()
		{
			PlotController.Instance.PlotViewManager.HandleSubSequenceStop();
		}

		// Token: 0x060297D5 RID: 169941 RVA: 0x00BB5B84 File Offset: 0x00BB3D84
		[NullableContext(2)]
		public override void AllStop(Action<bool> callback = null)
		{
			if (this.Model.GetLastFadeEnd())
			{
				PlotModel.Instance.IsFadeIn = true;
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "Plot_LastFadeEnd", null, new object[]
				{
					0,
					LevelLoadingController.Instance.CameraFade.ColorSearch()
				});
			}
		}

		// Token: 0x060297D6 RID: 169942 RVA: 0x00BB5BE4 File Offset: 0x00BB3DE4
		public override void End()
		{
			if (this.Model.IsSubtitleUiUse)
			{
				this.RemoveDialogueEvent();
			}
			PlotController.Instance.RemoveViewCallback(new TCallback(this.OnViewDone));
			this.QteManger.StopQte();
			this.SequenceQteManger.Clear();
			if (this.Promise != null)
			{
				this.Promise.SetResult(false);
				this.Promise = null;
			}
			CommonQteController.Instance.ClearPreloadQteRes();
			if (!FlowController.Instance.CollectSeamlessFinalize(ESeamlessFinalizeFlag.UiRemoveAspectView))
			{
				PlotController.Instance.RemoveAspectTransformView();
			}
		}

		// Token: 0x060297D7 RID: 169943 RVA: 0x00BB5C6C File Offset: 0x00BB3E6C
		private void AddDialogueEvent()
		{
			if (this.SubtitleEventRegistered)
			{
				return;
			}
			this.SubtitleEventRegistered = true;
			UMovieSceneDialogueSubsystem umovieSceneDialogueSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UMovieSceneDialogueSubsystem.StaticClass()) as UMovieSceneDialogueSubsystem;
			UMovieSceneQteManager qteManager = umovieSceneDialogueSubsystem.GetQteManager();
			umovieSceneDialogueSubsystem.OnShowDialogueWithUnison.Add(new FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate(this.OnShowDialogue));
			qteManager.OnQteStart.Add(new Action<FMovieSceneQteEventParam>(this.OnQteStart));
			qteManager.OnQteAnimEnd.Add(new Action<int>(this.OnQteAnimEnd));
		}

		// Token: 0x060297D8 RID: 169944 RVA: 0x00BB5CF0 File Offset: 0x00BB3EF0
		private void RemoveDialogueEvent()
		{
			if (!this.SubtitleEventRegistered)
			{
				return;
			}
			this.SubtitleEventRegistered = false;
			UMovieSceneDialogueSubsystem umovieSceneDialogueSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UMovieSceneDialogueSubsystem.StaticClass()) as UMovieSceneDialogueSubsystem;
			UMovieSceneQteManager qteManager = umovieSceneDialogueSubsystem.GetQteManager();
			umovieSceneDialogueSubsystem.OnShowDialogueWithUnison.Remove(new FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate(this.OnShowDialogue));
			qteManager.OnQteStart.Remove(new Action<FMovieSceneQteEventParam>(this.OnQteStart));
			qteManager.OnQteAnimEnd.Remove(new Action<int>(this.OnQteAnimEnd));
		}

		// Token: 0x060297D9 RID: 169945 RVA: 0x00BB5D71 File Offset: 0x00BB3F71
		public void OnQteStart(FMovieSceneQteEventParam param)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				this.SequenceQteManger.EnqueueQteRelease(param.QteId);
				return;
			}
			this.SequenceQteManger.EnqueueQteStart(param);
		}

		// Token: 0x060297DA RID: 169946 RVA: 0x00BB5D9F File Offset: 0x00BB3F9F
		public void OnQteAnimEnd(int qteId)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				return;
			}
			this.SequenceQteManger.EnqueueQteAnimEnd(qteId);
		}

		// Token: 0x060297DB RID: 169947 RVA: 0x00BB5DBC File Offset: 0x00BB3FBC
		public void OnShowDialogue(bool bShow, in FText dialogueId, int guardTime, int audioDelay, int audioTransitionDuration, ELanguageAudio languageAudio, int autoPlayDelay, in TArray<int> unisonIdList)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				return;
			}
			float guardTime2 = (float)guardTime / 0.03f;
			this.CacheDialogueQueue.Push(new CacheDialogueData(bShow, dialogueId.ToString(), guardTime2, (float)audioDelay, (float)audioTransitionDuration, languageAudio, (float)autoPlayDelay, unisonIdList));
		}

		// Token: 0x060297DC RID: 169948 RVA: 0x00BB5E08 File Offset: 0x00BB4008
		public void TriggerAllSubtitle()
		{
			if (this.Model.IsPaused.GetValueOrDefault())
			{
				return;
			}
			while (this.CacheDialogueQueue.Size > 0)
			{
				CacheDialogueData cacheDialogueData = this.CacheDialogueQueue.Pop();
				if (cacheDialogueData != null)
				{
					this.HandleSequenceDialog(cacheDialogueData.Show, cacheDialogueData.DialogueId, cacheDialogueData.GuardTime, cacheDialogueData.AudioDelay, cacheDialogueData.AudioTransitionDuration, cacheDialogueData.LanguageAudio, cacheDialogueData.AutoPlayDelay, cacheDialogueData.UnisonIdList);
				}
			}
		}

		// Token: 0x060297DD RID: 169949 RVA: 0x00BB5E7B File Offset: 0x00BB407B
		private void HandleSequenceDialog(bool isShow, string id, float guardTime, float audioDelay, float audioTransitionDuration, ELanguageAudio languageAudio, float autoPlayDelay, [Nullable(2)] TArray<int> unisonIdList)
		{
			if (languageAudio != ELanguageAudio.All && languageAudio != this.Model.CurLanguageAudio)
			{
				return;
			}
			if (isShow)
			{
				this.TriggerSubtitle(id, guardTime, audioDelay, audioTransitionDuration, autoPlayDelay, unisonIdList);
				return;
			}
			this.TriggerSubtitleEnd(id);
		}

		// Token: 0x060297DE RID: 169950 RVA: 0x00BB5EAC File Offset: 0x00BB40AC
		private void TriggerSubtitle(string id, float guardTime, float audioDelay, float audioTransitionDuration, float autoPlayDelay, [Nullable(2)] TArray<int> unisonIdList)
		{
			if (id == "None")
			{
				return;
			}
			int talkId = int.Parse(id);
			ITalkItem talkItem = FlowController.Instance.FlowSequence.CreateSubtitleFromTalkItem(talkId);
			if (talkItem == null)
			{
				return;
			}
			if (this.PendingOptionResult.ContainsKey(talkItem.Id))
			{
				FlowController.Instance.FlowSequence.OnSubtitleStart(talkItem.Id);
				return;
			}
			ETalkItemType? type = talkItem.Type;
			if (type != null)
			{
				ETalkItemType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault == ETalkItemType.QTE)
				{
					this.QteManger.HandlePlotQte(talkItem);
					return;
				}
				if (valueOrDefault == ETalkItemType.NoTextItem)
				{
					this.HandlePlotNoText(talkItem);
					return;
				}
			}
			this.HandlePlotSubtitle(talkItem, guardTime, audioDelay, audioTransitionDuration, autoPlayDelay, unisonIdList);
		}

		// Token: 0x060297DF RID: 169951 RVA: 0x00BB5F54 File Offset: 0x00BB4154
		private void TriggerSubtitleEnd(string id)
		{
			if (id == "None")
			{
				return;
			}
			int num = int.Parse(id);
			ITalkItem talkItem = FlowController.Instance.FlowSequence.CreateSubtitleFromTalkItem(num);
			if (talkItem == null)
			{
				return;
			}
			if (this.PendingOptionResult.ContainsKey(talkItem.Id))
			{
				int index = this.PendingOptionResult[talkItem.Id];
				FlowController.Instance.FlowSequence.OnSubtitleEnd(new int?(talkItem.Id));
				FlowController.Instance.FlowSequence.OnSelectOption(index);
				return;
			}
			ETalkItemType? type = talkItem.Type;
			if (type != null)
			{
				ETalkItemType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault == ETalkItemType.QTE)
				{
					this.QteManger.HandlePlotQteEnd(num);
					return;
				}
				if (valueOrDefault == ETalkItemType.NoTextItem)
				{
					this.HandlePlotNoTextEnd(num);
					return;
				}
			}
			this.HandlePlotSubtitleEnd(num, false).Forget();
		}

		// Token: 0x060297E0 RID: 169952 RVA: 0x00BB6024 File Offset: 0x00BB4224
		private void InitSubtitle()
		{
			this.Model.DefaultGuardTime = PlotModel.Instance.PlotGlobalConfig.GuardTime;
			this.Model.DefaultAudioDelay = PlotModel.Instance.PlotGlobalConfig.AudioDelay;
			this.Model.DefaultAudioTransitionDuration = PlotModel.Instance.PlotGlobalConfig.AudioTransitionDuration;
			this.Model.IsSubtitleConfigInit = true;
		}

		// Token: 0x060297E1 RID: 169953 RVA: 0x00BB608C File Offset: 0x00BB428C
		public void HandlePlotSubtitle(ITalkItem inSubtitles, float guardTime, float audioDelay, float audioTransitionDuration, float autoPlayDelay, [Nullable(2)] TArray<int> unisonIdList)
		{
			if (!this.Model.IsSubtitleConfigInit)
			{
				this.InitSubtitle();
			}
			this.Model.CurSubtitle.Subtitles = inSubtitles;
			if (guardTime < 0f)
			{
				this.Model.CurSubtitle.GuardTime = 0f;
			}
			else if (guardTime == 0f)
			{
				this.Model.CurSubtitle.GuardTime = this.Model.DefaultGuardTime * (float)TimeUtil.Instance.InverseMillisecond;
			}
			else
			{
				this.Model.CurSubtitle.GuardTime = MathUtils.Instance.Clamp(guardTime, 20f, 180000f);
			}
			if (audioDelay < 0f)
			{
				this.Model.CurSubtitle.AudioDelay = 0f;
			}
			else if (audioDelay == 0f)
			{
				this.Model.CurSubtitle.AudioDelay = this.Model.DefaultAudioDelay * (float)TimeUtil.Instance.InverseMillisecond;
			}
			else
			{
				this.Model.CurSubtitle.AudioDelay = audioDelay;
			}
			if (audioTransitionDuration < 0f)
			{
				this.Model.CurSubtitle.AudioTransitionDuration = 0f;
			}
			else if (audioTransitionDuration == 0f)
			{
				this.Model.CurSubtitle.AudioTransitionDuration = this.Model.DefaultAudioTransitionDuration * (float)TimeUtil.Instance.InverseMillisecond;
			}
			else
			{
				this.Model.CurSubtitle.AudioTransitionDuration = audioTransitionDuration;
			}
			if (autoPlayDelay <= 0f)
			{
				this.Model.CurSubtitle.AutoPlayDelay = 0f;
			}
			else
			{
				this.Model.CurSubtitle.AutoPlayDelay = autoPlayDelay * (float)TimeUtil.Instance.InverseMillisecond;
			}
			PlotSubtitleConfig curSubtitle = this.Model.CurSubtitle;
			PlotController.Instance.PlotViewManager.OnUpdateSubtitle(curSubtitle.Subtitles);
			FlowController.Instance.FlowSequence.OnSubtitleStart(curSubtitle.Subtitles.Id);
			PlotController.Instance.PlotViewManager.UpdateSeqSubtitle(curSubtitle);
			string sequenceMouthAnimKey = SequenceMouthAnimUtil.GetSequenceMouthAnimKey(curSubtitle.Subtitles);
			if (sequenceMouthAnimKey != null)
			{
				List<int> sequenceMouthAnimSpeakerIds = SequenceMouthAnimUtil.GetSequenceMouthAnimSpeakerIds(curSubtitle.Subtitles, unisonIdList);
				if (sequenceMouthAnimSpeakerIds.Count > 0)
				{
					SequenceController.Instance.TryApplyMouthAnim(sequenceMouthAnimKey, sequenceMouthAnimSpeakerIds);
				}
			}
		}

		// Token: 0x060297E2 RID: 169954 RVA: 0x00BB62B4 File Offset: 0x00BB44B4
		public UniTask HandlePlotSubtitleEnd(int id, bool isSkip = false)
		{
			UiAssistant.<HandlePlotSubtitleEnd>d__26 <HandlePlotSubtitleEnd>d__;
			<HandlePlotSubtitleEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandlePlotSubtitleEnd>d__.<>4__this = this;
			<HandlePlotSubtitleEnd>d__.id = id;
			<HandlePlotSubtitleEnd>d__.isSkip = isSkip;
			<HandlePlotSubtitleEnd>d__.<>1__state = -1;
			<HandlePlotSubtitleEnd>d__.<>t__builder.Start<UiAssistant.<HandlePlotSubtitleEnd>d__26>(ref <HandlePlotSubtitleEnd>d__);
			return <HandlePlotSubtitleEnd>d__.<>t__builder.Task;
		}

		// Token: 0x060297E3 RID: 169955 RVA: 0x00BB6308 File Offset: 0x00BB4508
		public UniTask HandleSelectedOption(int inOption, int talkItemId)
		{
			UiAssistant.<HandleSelectedOption>d__27 <HandleSelectedOption>d__;
			<HandleSelectedOption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleSelectedOption>d__.<>4__this = this;
			<HandleSelectedOption>d__.inOption = inOption;
			<HandleSelectedOption>d__.talkItemId = talkItemId;
			<HandleSelectedOption>d__.<>1__state = -1;
			<HandleSelectedOption>d__.<>t__builder.Start<UiAssistant.<HandleSelectedOption>d__27>(ref <HandleSelectedOption>d__);
			return <HandleSelectedOption>d__.<>t__builder.Task;
		}

		// Token: 0x060297E4 RID: 169956 RVA: 0x00BB635B File Offset: 0x00BB455B
		private void HandlePlotNoText(ITalkItem subtitle)
		{
			FlowController.Instance.FlowSequence.OnSubtitleStart(subtitle.Id);
		}

		// Token: 0x060297E5 RID: 169957 RVA: 0x00BB6372 File Offset: 0x00BB4572
		private void HandlePlotNoTextEnd(int id)
		{
			FlowController.Instance.FlowSequence.OnSubtitleEnd(new int?(id));
		}

		// Token: 0x060297E6 RID: 169958 RVA: 0x00BB638C File Offset: 0x00BB458C
		private UniTask PreloadQte()
		{
			UiAssistant.<PreloadQte>d__30 <PreloadQte>d__;
			<PreloadQte>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadQte>d__.<>4__this = this;
			<PreloadQte>d__.<>1__state = -1;
			<PreloadQte>d__.<>t__builder.Start<UiAssistant.<PreloadQte>d__30>(ref <PreloadQte>d__);
			return <PreloadQte>d__.<>t__builder.Task;
		}

		// Token: 0x060297E7 RID: 169959 RVA: 0x00BB63D0 File Offset: 0x00BB45D0
		public void PreloadUi(CustomPromise<bool> promise)
		{
			UiAssistant.<>c__DisplayClass31_0 CS$<>8__locals1 = new UiAssistant.<>c__DisplayClass31_0();
			CS$<>8__locals1.promise = promise;
			CS$<>8__locals1.<>4__this = this;
			string formatId = PlotModel.Instance.PlotResult.FormatId;
			if (PlotController.Instance.GetCurrentViewName() == null)
			{
				CS$<>8__locals1.<PreloadUi>g__SetResult|0();
				return;
			}
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			bool flag;
			if (sequenceData == null)
			{
				flag = (null != null);
			}
			else
			{
				BP_SequenceData_Generated_C generatedData = sequenceData.GeneratedData;
				flag = (((generatedData != null) ? generatedData.PreloadUiArray : null) != null);
			}
			if (flag)
			{
				BP_SequenceData_C sequenceData2 = this.Model.SequenceData;
				bool flag2;
				if (sequenceData2 == null)
				{
					flag2 = false;
				}
				else
				{
					BP_SequenceData_Generated_C generatedData2 = sequenceData2.GeneratedData;
					int? num = (generatedData2 != null) ? new int?(generatedData2.PreloadUiArray.Num()) : null;
					int num2 = 0;
					flag2 = (num.GetValueOrDefault() <= num2 & num != null);
				}
				if (!flag2)
				{
					List<UniTask> list = new List<UniTask>();
					if (PreloadModelNew.Instance.PlotUiAssetManager.IsLoading(formatId))
					{
						list.Add(PreloadModelNew.Instance.PlotUiAssetManager.WaitForPlotUiAsset(formatId));
					}
					else
					{
						list.Add(this.PreloadQte());
						list.Add(UniTask.Create(delegate()
						{
							UiAssistant.<>c__DisplayClass31_0.<<PreloadUi>b__1>d <<PreloadUi>b__1>d;
							<<PreloadUi>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
							<<PreloadUi>b__1>d.<>4__this = CS$<>8__locals1;
							<<PreloadUi>b__1>d.<>1__state = -1;
							<<PreloadUi>b__1>d.<>t__builder.Start<UiAssistant.<>c__DisplayClass31_0.<<PreloadUi>b__1>d>(ref <<PreloadUi>b__1>d);
							return <<PreloadUi>b__1>d.<>t__builder.Task;
						}));
					}
					if (SequenceModel.Instance.SkipUiWaiting)
					{
						UniTask.WhenAll(list);
						CS$<>8__locals1.<PreloadUi>g__SetResult|0();
						return;
					}
					UniTask.WhenAll(list).ContinueWith(new Action(CS$<>8__locals1.<PreloadUi>g__SetResult|0));
					return;
				}
			}
			CS$<>8__locals1.<PreloadUi>g__SetResult|0();
		}

		// Token: 0x04016A36 RID: 92726
		private const string SUBTITLE_ACTION_PAUSE = "Action";

		// Token: 0x04016A37 RID: 92727
		private const string OPTION_ACTION_PAUSE = "Option";

		// Token: 0x04016A38 RID: 92728
		public Event<ESequenceEventName, Delegate> Event = new Event<ESequenceEventName, Delegate>();

		// Token: 0x04016A39 RID: 92729
		private readonly Queue<CacheDialogueData> CacheDialogueQueue = new Queue<CacheDialogueData>(4);

		// Token: 0x04016A3A RID: 92730
		private bool SubtitleEventRegistered;

		// Token: 0x04016A3B RID: 92731
		private readonly QteManger QteManger = new QteManger();

		// Token: 0x04016A3C RID: 92732
		private readonly SequenceQteManager SequenceQteManger = new SequenceQteManager();
	}
}
