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
	// Token: 0x02005039 RID: 20537
	[NullableContext(1)]
	[Nullable(0)]
	public class UiAssistant : SeqBaseAssistant
	{
		// Token: 0x1700802A RID: 32810
		// (get) Token: 0x06034912 RID: 215314 RVA: 0x00C695A6 File Offset: 0x00C677A6
		private Dictionary<int, int> PendingOptionResult
		{
			get
			{
				return this.SequenceQteManger.PendingOptionResult;
			}
		}

		// Token: 0x06034913 RID: 215315 RVA: 0x00C695B4 File Offset: 0x00C677B4
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

		// Token: 0x06034914 RID: 215316 RVA: 0x00C695F7 File Offset: 0x00C677F7
		private void OnViewDone(bool result)
		{
			CustomPromise<bool> promise = this.Promise;
			if (promise != null)
			{
				promise.SetResult(result);
			}
			this.Promise = null;
		}

		// Token: 0x06034915 RID: 215317 RVA: 0x00C69614 File Offset: 0x00C67814
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

		// Token: 0x06034916 RID: 215318 RVA: 0x00C696E3 File Offset: 0x00C678E3
		public override void EachStop()
		{
			PlotController.Instance.PlotViewManager.HandleSubSequenceStop();
		}

		// Token: 0x06034917 RID: 215319 RVA: 0x00C696F4 File Offset: 0x00C678F4
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

		// Token: 0x06034918 RID: 215320 RVA: 0x00C69754 File Offset: 0x00C67954
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

		// Token: 0x06034919 RID: 215321 RVA: 0x00C697DC File Offset: 0x00C679DC
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

		// Token: 0x0603491A RID: 215322 RVA: 0x00C69860 File Offset: 0x00C67A60
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

		// Token: 0x0603491B RID: 215323 RVA: 0x00C698E1 File Offset: 0x00C67AE1
		public void OnQteStart(FMovieSceneQteEventParam param)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				this.SequenceQteManger.EnqueueQteRelease(param.QteId);
				return;
			}
			this.SequenceQteManger.EnqueueQteStart(param);
		}

		// Token: 0x0603491C RID: 215324 RVA: 0x00C6990F File Offset: 0x00C67B0F
		public void OnQteAnimEnd(int qteId)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				return;
			}
			this.SequenceQteManger.EnqueueQteAnimEnd(qteId);
		}

		// Token: 0x0603491D RID: 215325 RVA: 0x00C6992C File Offset: 0x00C67B2C
		public void OnShowDialogue(bool bShow, in FText dialogueId, int guardTime, int audioDelay, int audioTransitionDuration, ELanguageAudio languageAudio, int autoPlayDelay, in TArray<int> unisonIdList)
		{
			if (this.Model.State != ESequenceState.Playing)
			{
				return;
			}
			float guardTime2 = (float)guardTime / 0.03f;
			this.CacheDialogueQueue.Push(new CacheDialogueData(bShow, dialogueId.ToString(), guardTime2, (float)audioDelay, (float)audioTransitionDuration, languageAudio, (float)autoPlayDelay, unisonIdList));
		}

		// Token: 0x0603491E RID: 215326 RVA: 0x00C69978 File Offset: 0x00C67B78
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

		// Token: 0x0603491F RID: 215327 RVA: 0x00C699EB File Offset: 0x00C67BEB
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

		// Token: 0x06034920 RID: 215328 RVA: 0x00C69A1C File Offset: 0x00C67C1C
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

		// Token: 0x06034921 RID: 215329 RVA: 0x00C69AC4 File Offset: 0x00C67CC4
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

		// Token: 0x06034922 RID: 215330 RVA: 0x00C69B94 File Offset: 0x00C67D94
		private void InitSubtitle()
		{
			this.Model.DefaultGuardTime = PlotModel.Instance.PlotGlobalConfig.GuardTime;
			this.Model.DefaultAudioDelay = PlotModel.Instance.PlotGlobalConfig.AudioDelay;
			this.Model.DefaultAudioTransitionDuration = PlotModel.Instance.PlotGlobalConfig.AudioTransitionDuration;
			this.Model.IsSubtitleConfigInit = true;
		}

		// Token: 0x06034923 RID: 215331 RVA: 0x00C69BFC File Offset: 0x00C67DFC
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

		// Token: 0x06034924 RID: 215332 RVA: 0x00C69E24 File Offset: 0x00C68024
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

		// Token: 0x06034925 RID: 215333 RVA: 0x00C69E78 File Offset: 0x00C68078
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

		// Token: 0x06034926 RID: 215334 RVA: 0x00C69ECB File Offset: 0x00C680CB
		private void HandlePlotNoText(ITalkItem subtitle)
		{
			FlowController.Instance.FlowSequence.OnSubtitleStart(subtitle.Id);
		}

		// Token: 0x06034927 RID: 215335 RVA: 0x00C69EE2 File Offset: 0x00C680E2
		private void HandlePlotNoTextEnd(int id)
		{
			FlowController.Instance.FlowSequence.OnSubtitleEnd(new int?(id));
		}

		// Token: 0x06034928 RID: 215336 RVA: 0x00C69EFC File Offset: 0x00C680FC
		private UniTask PreloadQte()
		{
			UiAssistant.<PreloadQte>d__30 <PreloadQte>d__;
			<PreloadQte>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadQte>d__.<>4__this = this;
			<PreloadQte>d__.<>1__state = -1;
			<PreloadQte>d__.<>t__builder.Start<UiAssistant.<PreloadQte>d__30>(ref <PreloadQte>d__);
			return <PreloadQte>d__.<>t__builder.Task;
		}

		// Token: 0x06034929 RID: 215337 RVA: 0x00C69F40 File Offset: 0x00C68140
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

		// Token: 0x0401C02B RID: 114731
		private const string SUBTITLE_ACTION_PAUSE = "Action";

		// Token: 0x0401C02C RID: 114732
		private const string OPTION_ACTION_PAUSE = "Option";

		// Token: 0x0401C02D RID: 114733
		public Event<ESequenceEventName, Delegate> Event = new Event<ESequenceEventName, Delegate>();

		// Token: 0x0401C02E RID: 114734
		private readonly Queue<CacheDialogueData> CacheDialogueQueue = new Queue<CacheDialogueData>(4);

		// Token: 0x0401C02F RID: 114735
		private bool SubtitleEventRegistered;

		// Token: 0x0401C030 RID: 114736
		private readonly QteManger QteManger = new QteManger();

		// Token: 0x0401C031 RID: 114737
		private readonly SequenceQteManager SequenceQteManger = new SequenceQteManager();
	}
}
