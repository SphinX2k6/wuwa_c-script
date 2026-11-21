using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Sequence;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004070 RID: 16496
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowSequence
	{
		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x06029D3F RID: 171327 RVA: 0x00BD2804 File Offset: 0x00BD0A04
		public bool IsInit
		{
			get
			{
				return this.IsInitInner;
			}
		}

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x06029D40 RID: 171328 RVA: 0x00BD280C File Offset: 0x00BD0A0C
		public bool IsPlaying
		{
			get
			{
				return this.IsPlayingInner;
			}
		}

		// Token: 0x06029D41 RID: 171329 RVA: 0x00BD2814 File Offset: 0x00BD0A14
		public void Clear()
		{
			this.IsInitInner = false;
			this.IsPlayingInner = false;
			this.CurShowTalk = null;
			this.IdIndexMap.Clear();
			this.NextSequenceIndex = -2;
			this.CurTalkItem = null;
			this.Context = null;
			this.IsSubtitleShowed = false;
			this.IsOptionSelected = false;
			this.IsSkipping = false;
			this.NextTalkIndex = null;
			this.FinalPos = null;
			this.IsFadeEnd.Clear();
			this.FrameEventsMap.Clear();
			this.FrameEvents.Clear();
			this.LastId = -1;
			this.LastHasOption = false;
			this.CurrentQte.Clear();
			this.QteLatentAction.Clear();
			if (this.DelayEnableSkipTimer != null)
			{
				TimerSystem.Instance.Remove(this.DelayEnableSkipTimer);
			}
			this.DelayEnableSkipTimer = null;
			this.NpcPerformArray.Clear();
			this.NpcPerformRelationMap.Clear();
		}

		// Token: 0x06029D42 RID: 171330 RVA: 0x00BD28FC File Offset: 0x00BD0AFC
		public void Init(ShowTalk inParams, FlowContext context)
		{
			this.Clear();
			this.CurShowTalk = inParams;
			if (this.CurShowTalk == null || StringUtils.IsEmpty(this.CurShowTalk.SequenceDataAsset))
			{
				FlowController.Instance.LogError("[FlowSequence] 配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.CurShowTalk.TalkSequence != null)
			{
				for (int i = 0; i < this.CurShowTalk.TalkSequence.Count; i++)
				{
					foreach (int key in this.CurShowTalk.TalkSequence[i])
					{
						if (!this.IdIndexMap.TryAdd(key, i))
						{
							FlowController.Instance.LogError("[FlowSequence] 初始化分段时Id重复", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
					}
				}
			}
			this.Context = context;
			this.Context.CurTalkId = -1;
			this.Context.CurOptionId = -1;
			this.Context.CurSubActionId = 0;
			this.NextSequenceIndex = 0;
			this.NextTalkIndex = new int?(0);
			this.IsInitInner = true;
			EventSystem.Instance.Add<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
		}

		// Token: 0x06029D43 RID: 171331 RVA: 0x00BD2A44 File Offset: 0x00BD0C44
		private void OnSequenceStart(float viewBlendDuration)
		{
			float num = viewBlendDuration * 1000f;
			if (num > 20f && num < 180000f)
			{
				this.DelayEnableSkipTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					FlowController.Instance.EnableSkip(true);
					this.DelayEnableSkipTimer = null;
				}, num, null, null, true, 1f);
				return;
			}
			FlowController.Instance.EnableSkip(true);
		}

		// Token: 0x06029D44 RID: 171332 RVA: 0x00BD2A9C File Offset: 0x00BD0C9C
		public void Start(bool bSeamless)
		{
			if (!this.IsInit || this.IsPlaying)
			{
				return;
			}
			this.IsPlayingInner = true;
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			EPlotLevel eplotLevel = EPlotLevel.LevelA;
			if (plotLevel.GetValueOrDefault() == eplotLevel & plotLevel != null)
			{
				SequenceModel.Instance.Type = new EPlotSequenceType?(EPlotSequenceType.过场);
			}
			else if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelB)
			{
				SequenceModel.Instance.Type = new EPlotSequenceType?(EPlotSequenceType.站桩);
			}
			PlotController.Instance.PlotViewManager.EmitPlotStartShowTalk(this.CurShowTalk);
			PlotModel.Instance.CurShowTalk = this.CurShowTalk;
			PlotModel.Instance.ResetOptionReadState(this.CurShowTalk);
			List<ISequenceFrameEvent> list = new List<ISequenceFrameEvent>();
			if (this.CurShowTalk.TalkFrameEvents != null)
			{
				foreach (IShowTalkFrameEvent showTalkFrameEvent in this.CurShowTalk.TalkFrameEvents)
				{
					list.Add(showTalkFrameEvent.FrameEvent);
					Dictionary<int, HashSet<string>> frameEventsMap = SequenceModel.Instance.FrameEventsMap;
					IShowTalkFrameEventPosition position = showTalkFrameEvent.Position;
					HashSet<string> hashSet2;
					if (!frameEventsMap.ContainsKey((position != null) ? position.TalkItemId : 0))
					{
						HashSet<string> hashSet = new HashSet<string>();
						hashSet.Add(showTalkFrameEvent.FrameEvent.EventKey);
						SequenceModel.Instance.FrameEventsMap.Add(showTalkFrameEvent.Position.TalkItemId, hashSet);
					}
					else if (SequenceModel.Instance.FrameEventsMap.TryGetValue(showTalkFrameEvent.Position.TalkItemId, out hashSet2))
					{
						hashSet2.Add(showTalkFrameEvent.FrameEvent.EventKey);
						SequenceModel.Instance.FrameEventsMap[showTalkFrameEvent.Position.TalkItemId] = hashSet2;
					}
				}
			}
			List<string> list2 = new List<string>();
			EPlotLevel? plotLevel2 = PlotModel.Instance.PlotConfig.PlotLevel;
			if ((plotLevel2.GetValueOrDefault() == EPlotLevel.LevelB || plotLevel2.GetValueOrDefault() == EPlotLevel.ControlEntity) && this.CurShowTalk.TalkItems != null)
			{
				foreach (ITalkItem talkItem in this.CurShowTalk.TalkItems)
				{
					string sequenceMouthAnimKey = SequenceMouthAnimUtil.GetSequenceMouthAnimKey(talkItem);
					if (sequenceMouthAnimKey != null && !list2.Contains(sequenceMouthAnimKey))
					{
						list2.Add(sequenceMouthAnimKey);
					}
				}
			}
			if (!this.Context.IsBackground)
			{
				SequenceController.Instance.Play(new PlaySequenceData
				{
					Path = this.CurShowTalk.SequenceDataAsset,
					ResetCamera = this.CurShowTalk.ResetCamera,
					FrameEvents = list,
					SeqBlendAnim = this.CurShowTalk.SeqBlendAnim
				}, list2, new Action<bool>(this.OnSequenceStop), bSeamless);
				return;
			}
			SequenceController.Instance.ManualFinish();
			SequenceController.Instance.LoadData(new PlaySequenceData
			{
				Path = this.CurShowTalk.SequenceDataAsset,
				ResetCamera = this.CurShowTalk.ResetCamera,
				FrameEvents = list
			}, new Action(this.Skip));
		}

		// Token: 0x06029D45 RID: 171333 RVA: 0x00BD2DBC File Offset: 0x00BD0FBC
		public void Stop(bool isForced = false)
		{
			if (!this.IsInit)
			{
				return;
			}
			if (this.IsPlaying)
			{
				this.IsPlayingInner = false;
				SequenceController.Instance.ManualFinish();
			}
			this.StopPromise().ContinueWith(new Action(this.FinalHandle)).Forget();
		}

		// Token: 0x06029D46 RID: 171334 RVA: 0x00BD2DFC File Offset: 0x00BD0FFC
		private UniTask StopPromise()
		{
			FlowSequence.<StopPromise>d__35 <StopPromise>d__;
			<StopPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StopPromise>d__.<>4__this = this;
			<StopPromise>d__.<>1__state = -1;
			<StopPromise>d__.<>t__builder.Start<FlowSequence.<StopPromise>d__35>(ref <StopPromise>d__);
			return <StopPromise>d__.<>t__builder.Task;
		}

		// Token: 0x06029D47 RID: 171335 RVA: 0x00BD2E40 File Offset: 0x00BD1040
		private void FinalHandle()
		{
			this.Context.CurTalkId = -1;
			this.Context.CurOptionId = -1;
			this.Context.CurSubActionId = 0;
			this.Context.CurShowTalk = null;
			this.Context.CurShowTalkActionId = 0;
			PlotModel.Instance.ClearOptionReadState();
			PlotModel.Instance.CurShowTalk = null;
			PlotModel.Instance.OptionEnable = true;
			FlowController.Instance.EnableSkip(false);
			EventSystem.Instance.Remove<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
			this.Clear();
			EventSystem.Instance.Emit(EEventName.PlotEndShowTalk);
			FlowController.Instance.RunNextAction();
		}

		// Token: 0x06029D48 RID: 171336 RVA: 0x00BD2EF0 File Offset: 0x00BD10F0
		public void Skip()
		{
			if (!this.IsInit || !this.IsPlaying || this.IsSkipping)
			{
				return;
			}
			this.IsSkipping = true;
			if (SequenceModel.Instance.CurFinalPos.Count != 0)
			{
				this.FinalPos = new List<Transform>(SequenceModel.Instance.CurFinalPos);
			}
			foreach (bool item in SequenceModel.Instance.IsFadeEnd)
			{
				this.IsFadeEnd.Add(item);
			}
			foreach (KeyValuePair<string, List<ActionInfo>> keyValuePair in SequenceModel.Instance.FrameEvents)
			{
				this.FrameEvents[keyValuePair.Key] = keyValuePair.Value;
			}
			foreach (KeyValuePair<int, HashSet<string>> keyValuePair2 in SequenceModel.Instance.FrameEventsMap)
			{
				this.FrameEventsMap[keyValuePair2.Key] = keyValuePair2.Value;
			}
			foreach (KeyValuePair<int, HashSet<string>> keyValuePair3 in SequenceModel.Instance.FrameEventsMap)
			{
				this.FrameEventsMap[keyValuePair3.Key] = keyValuePair3.Value;
			}
			foreach (Entity entity in SequenceModel.Instance.NeedHideNpcSet)
			{
				CreatureController.Instance.SetEntityEnable(entity, true, "显示NPC", false);
			}
			SequenceModel.Instance.NeedHideNpcSet.Clear();
			EntityHandle plotBindingVehicle = SequenceModel.Instance.PlotBindingVehicle;
			if (((plotBindingVehicle != null) ? plotBindingVehicle.Entity : null) != null)
			{
				CreatureController instance = CreatureController.Instance;
				EntityHandle plotBindingVehicle2 = SequenceModel.Instance.PlotBindingVehicle;
				instance.SetEntityEnable((plotBindingVehicle2 != null) ? plotBindingVehicle2.Entity : null, true, "Plot enable vehicle", false);
				SequenceModel.Instance.PlotBindingVehicle = null;
			}
			foreach (FName fname in SequenceModel.Instance.NpcGroupPerform)
			{
				this.NpcPerformArray.Add(fname);
				NpcRelation value;
				if (SequenceModel.Instance.NpcRelationMap.TryGetValue(fname, out value))
				{
					this.NpcPerformRelationMap[fname] = value;
				}
			}
			SequenceController.Instance.ManualFinish();
			this.IsPlayingInner = false;
			if (this.CurrentQte.Count > 0)
			{
				foreach (int talkId in new List<int>(this.CurrentQte.Keys))
				{
					this.OnQteEnd(talkId);
				}
			}
			if (this.IsSubtitleShowed)
			{
				this.OnSubtitleEnd(new int?(this.CurTalkItem.Id));
				return;
			}
			if (this.HasOption() && !this.IsOptionSelected)
			{
				ITalkItem curTalkItem = this.CurTalkItem;
				this.RunSequenceFrameEventsWhenSkip((curTalkItem != null) ? new int?(curTalkItem.Id) : null);
				this.OnSelectOption(FlowController.Instance.GetRecommendedOption(this.CurTalkItem));
				return;
			}
			int? nextTalkIndex = this.NextTalkIndex;
			int count = this.CurShowTalk.TalkItems.Count;
			if (nextTalkIndex.GetValueOrDefault() >= count & nextTalkIndex != null)
			{
				ITalkItem curTalkItem2 = this.CurTalkItem;
				this.RunSequenceFrameEventsWhenSkip((curTalkItem2 != null) ? new int?(curTalkItem2.Id) : null);
				this.OnSequenceStop(false);
				return;
			}
			ITalkItem curTalkItem3 = this.CurTalkItem;
			this.RunSequenceFrameEventsWhenSkip((curTalkItem3 != null) ? new int?(curTalkItem3.Id) : null);
			int id = this.CurShowTalk.TalkItems[this.NextTalkIndex.Value].Id;
			this.OnSubtitleStart(id);
			this.OnSubtitleEnd(new int?(id));
		}

		// Token: 0x06029D49 RID: 171337 RVA: 0x00BD3358 File Offset: 0x00BD1558
		private void SubtitleActionCallback(bool result)
		{
			if (this.SubtitleActionPromise != null)
			{
				CustomPromise subtitleActionPromise = this.SubtitleActionPromise;
				this.SubtitleActionPromise = null;
				subtitleActionPromise.SetResult();
			}
			if (!this.IsSkipping)
			{
				return;
			}
			if (!result)
			{
				return;
			}
			if (this.HasOption())
			{
				this.OnSelectOption(FlowController.Instance.GetRecommendedOption(this.CurTalkItem));
				return;
			}
			int? nextTalkIndex = this.NextTalkIndex;
			int count = this.CurShowTalk.TalkItems.Count;
			if (nextTalkIndex.GetValueOrDefault() >= count & nextTalkIndex != null)
			{
				this.OnSequenceStop(false);
				return;
			}
			int id = this.CurShowTalk.TalkItems[this.NextTalkIndex.Value].Id;
			this.OnSubtitleStart(id);
			this.OnSubtitleEnd(new int?(id));
		}

		// Token: 0x06029D4A RID: 171338 RVA: 0x00BD3418 File Offset: 0x00BD1618
		private void OptionActionCallback(bool result)
		{
			if (this.OptionActionPromise != null)
			{
				CustomPromise optionActionPromise = this.OptionActionPromise;
				this.OptionActionPromise = null;
				optionActionPromise.SetResult();
			}
			if (!result)
			{
				return;
			}
			if (!this.IsSkipping)
			{
				return;
			}
			int? nextTalkIndex = this.NextTalkIndex;
			int count = this.CurShowTalk.TalkItems.Count;
			if (nextTalkIndex.GetValueOrDefault() >= count & nextTalkIndex != null)
			{
				this.OnSequenceStop(false);
				return;
			}
			int id = this.CurShowTalk.TalkItems[this.NextTalkIndex.Value].Id;
			this.OnSubtitleStart(id);
			this.OnSubtitleEnd(new int?(id));
		}

		// Token: 0x06029D4B RID: 171339 RVA: 0x00BD34B8 File Offset: 0x00BD16B8
		private bool HasOption()
		{
			ITalkItem curTalkItem = this.CurTalkItem;
			if (((curTalkItem != null) ? curTalkItem.Options : null) == null)
			{
				return false;
			}
			ITalkItem curTalkItem2 = this.CurTalkItem;
			if (curTalkItem2 == null)
			{
				return false;
			}
			List<ITalkOption> options = curTalkItem2.Options;
			int? num = (options != null) ? new int?(options.Count) : null;
			int num2 = 0;
			return num.GetValueOrDefault() > num2 & num != null;
		}

		// Token: 0x06029D4C RID: 171340 RVA: 0x00BD351C File Offset: 0x00BD171C
		private void CheckLastAndSetNew()
		{
			if (this.LastHasOption && !this.IsOptionSelected)
			{
				FlowController instance = FlowController.Instance;
				string text = "遗漏选项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Miss TalkItem Id", this.LastId);
				instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			ITalkItem curTalkItem = this.CurTalkItem;
			this.LastId = ((curTalkItem != null) ? curTalkItem.Id : -1);
			this.LastHasOption = this.HasOption();
		}

		// Token: 0x06029D4D RID: 171341 RVA: 0x00BD358C File Offset: 0x00BD178C
		public void OnJumpTalk(int talkId)
		{
			if (!this.IsInit)
			{
				return;
			}
			this.NextSequenceIndex = this.IdIndexMap.GetValueOrDefault(talkId, -1);
			SequenceController.Instance.SetNextSequenceIndex(this.NextSequenceIndex);
			this.NextTalkIndex = new int?(-1);
			for (int i = 0; i < this.CurShowTalk.TalkItems.Count; i++)
			{
				if (this.CurShowTalk.TalkItems[i].Id == talkId)
				{
					this.NextTalkIndex = new int?(i);
					break;
				}
			}
			if (this.IsSkipping)
			{
				this.OnSubtitleStart(talkId);
				this.OnSubtitleEnd(new int?(talkId));
			}
		}

		// Token: 0x06029D4E RID: 171342 RVA: 0x00BD362F File Offset: 0x00BD182F
		public void OnFinishTalk()
		{
			if (!this.IsInit)
			{
				return;
			}
			this.NextSequenceIndex = -1;
			SequenceController.Instance.SetNextSequenceIndex(this.NextSequenceIndex);
			if (this.IsSkipping)
			{
				this.OnSequenceStop(false);
			}
		}

		// Token: 0x06029D4F RID: 171343 RVA: 0x00BD3660 File Offset: 0x00BD1860
		public bool IsCurrentSubtitle(int talkId)
		{
			if (this.IsSubtitleShowed)
			{
				ITalkItem curTalkItem = this.CurTalkItem;
				return curTalkItem != null && curTalkItem.Id == talkId;
			}
			return false;
		}

		// Token: 0x06029D50 RID: 171344 RVA: 0x00BD3680 File Offset: 0x00BD1880
		public unsafe void OnSubtitleStart(int talkId)
		{
			if (!this.IsInit)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowSequence][Subtitle] 字幕显示";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("talkId", talkId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ITalkItem talkItem = null;
			foreach (ITalkItem talkItem2 in this.CurShowTalk.TalkItems)
			{
				if (talkItem2.Id == talkId)
				{
					talkItem = talkItem2;
					break;
				}
			}
			if (this.GetNextTalkItem().Id != talkId)
			{
				FlowController instance2 = FlowController.Instance;
				string text = "[FlowSequence][Subtitle] Seq字幕顺序与编辑器对不上";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("talkId", talkId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SeqIndex", SequenceModel.Instance.SubSeqIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("index in seq", this.NextTalkIndex);
				instance2.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.NextTalkIndex = new int?(this.CurShowTalk.TalkItems.IndexOf(talkItem));
			}
			this.NextTalkIndex++;
			if (talkItem == null)
			{
				FlowController instance3 = FlowController.Instance;
				string text2 = "[FlowSequence][Subtitle] 依赖编辑器的Seq找不到字幕";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("talkItem.ID", talkId);
				instance3.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			this.IsSubtitleShowed = true;
			this.Context.CurTalkId = talkId;
			this.Context.CurOptionId = -1;
			this.CurTalkItem = talkItem;
			this.CheckLastAndSetNew();
			this.IsOptionSelected = false;
		}

		// Token: 0x06029D51 RID: 171345 RVA: 0x00BD385C File Offset: 0x00BD1A5C
		public unsafe bool OnSubtitleEnd(int? id = null)
		{
			if (this.IsSkipping)
			{
				this.RunSequenceFrameEventsWhenSkip(new int?(id.Value));
			}
			if (!this.IsInit || !this.IsSubtitleShowed)
			{
				return false;
			}
			if (id != null)
			{
				int id2 = this.CurTalkItem.Id;
				int? num = id;
				if (!(id2 == num.GetValueOrDefault() & num != null))
				{
					FlowController instance = FlowController.Instance;
					string text = "[FlowSequence] 结束对话Id错误";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cur", this.CurTalkItem.Id);
					instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
			}
			this.IsSubtitleShowed = false;
			this.SubtitleActionPromise = new CustomPromise();
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[FlowSequence][Subtitle] 字幕关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RunSubActions(this.CurTalkItem.Actions, new Action<bool>(this.SubtitleActionCallback), false);
			return true;
		}

		// Token: 0x06029D52 RID: 171346 RVA: 0x00BD3974 File Offset: 0x00BD1B74
		public unsafe int OnQteStart(int id)
		{
			ITalkItem talkItem = null;
			foreach (ITalkItem talkItem2 in this.CurShowTalk.TalkItems)
			{
				if (talkItem2.Id == id)
				{
					talkItem = talkItem2;
					break;
				}
			}
			if (this.GetNextTalkItem().Id != id)
			{
				FlowController instance = FlowController.Instance;
				string text = "[FlowSequence][Subtitle] Qte在Seq中顺序与编辑器不符合";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SeqIndex", SequenceModel.Instance.SubSeqIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("index in seq", this.NextTalkIndex);
				instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.NextTalkIndex = new int?(this.CurShowTalk.TalkItems.IndexOf(talkItem));
			}
			this.NextTalkIndex++;
			ITalkItemQte talkItemQte = talkItem as ITalkItemQte;
			this.CurrentQte[id] = talkItemQte;
			global::Log instance2 = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowSequence][Subtitle] Qte开启";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return talkItemQte.QteId;
		}

		// Token: 0x06029D53 RID: 171347 RVA: 0x00BD3B00 File Offset: 0x00BD1D00
		public unsafe void OnQteExecute(int talkId, bool result)
		{
			ITalkItemQte talkItemQte;
			if (!this.CurrentQte.TryGetValue(talkId, out talkItemQte))
			{
				return;
			}
			this.QteLatentAction[talkId] = -1;
			if (talkItemQte.Options == null || talkItemQte.Options.Count == 0)
			{
				return;
			}
			for (int i = 0; i < talkItemQte.Options.Count; i++)
			{
				ITalkOption talkOption = talkItemQte.Options[i];
				if (talkOption.TypeParams != null)
				{
					switch (talkOption.TypeParams.Type)
					{
					case ETalkOptionParamType.QteSucceed:
						if (result)
						{
							this.OnQteOption(talkItemQte, i);
							global::Log instance = global::Log.Instance;
							ELogModule module = ELogModule.Plot;
							ELogAuthor author = ELogAuthor.FZX;
							string message = "[FlowSequence][Subtitle] Qte成功执行";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", talkId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionIndex", i);
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						break;
					case ETalkOptionParamType.QteFailed:
						if (!result)
						{
							this.OnQteOption(talkItemQte, i);
							global::Log instance2 = global::Log.Instance;
							ELogModule module2 = ELogModule.Plot;
							ELogAuthor author2 = ELogAuthor.FZX;
							string message2 = "[FlowSequence][Subtitle] Qte失败执行";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("id", talkId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("optionIndex", i);
							instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						}
						break;
					case ETalkOptionParamType.QteSucceedDelayExec:
						if (result)
						{
							this.QteLatentAction[talkId] = i;
						}
						break;
					case ETalkOptionParamType.QteFailedDelayExec:
						if (!result)
						{
							this.QteLatentAction[talkId] = i;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06029D54 RID: 171348 RVA: 0x00BD3CA0 File Offset: 0x00BD1EA0
		public unsafe void OnQteEnd(int talkId)
		{
			if (!this.CurrentQte.ContainsKey(talkId))
			{
				return;
			}
			if (!this.QteLatentAction.ContainsKey(talkId))
			{
				if (!this.IsSkipping)
				{
					return;
				}
				this.OnQteExecute(talkId, false);
			}
			ITalkItemQte talkItem = this.CurrentQte[talkId];
			int num = this.QteLatentAction[talkId];
			this.QteLatentAction.Remove(talkId);
			this.CurrentQte.Remove(talkId);
			if (num == -1)
			{
				return;
			}
			this.OnQteOption(talkItem, num);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowSequence][Subtitle] Qte关闭";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", talkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("delay option index", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("delay no more", this.IsSkipping);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06029D55 RID: 171349 RVA: 0x00BD3D9D File Offset: 0x00BD1F9D
		public void OnSequenceStop(bool _)
		{
			this.CheckLastAndSetNew();
			this.IsPlayingInner = false;
			this.Stop(false);
		}

		// Token: 0x06029D56 RID: 171350 RVA: 0x00BD3DB4 File Offset: 0x00BD1FB4
		public bool OnSelectOption(int index)
		{
			if (!this.IsInit)
			{
				return false;
			}
			if (this.Context.CurOptionId != -1 || this.IsOptionSelected)
			{
				return false;
			}
			this.IsOptionSelected = true;
			ITalkItem curTalkItem = this.CurTalkItem;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[FlowSequence] 选择选项";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			List<ITalkOption> options = curTalkItem.Options;
			int num = (options != null) ? options.Count : 0;
			List<ActionInfo> actions = (index < num) ? curTalkItem.Options[index].Actions : null;
			if (index >= num)
			{
				FlowController.Instance.LogError("[FlowSequence] 选项超出下标", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			FlowController.Instance.SelectOption(curTalkItem.Id, index);
			this.OptionActionPromise = new CustomPromise();
			this.RunSubActions(actions, new Action<bool>(this.OptionActionCallback), false);
			return true;
		}

		// Token: 0x06029D57 RID: 171351 RVA: 0x00BD3E9C File Offset: 0x00BD209C
		private void OnQteOption(ITalkItem talkItem, int index)
		{
			if (talkItem.Options == null || talkItem.Options.Count == 0)
			{
				return;
			}
			FlowController.Instance.SelectOption(talkItem.Id, index);
			this.RunSubActions(talkItem.Options[index].Actions, null, true);
		}

		// Token: 0x06029D58 RID: 171352 RVA: 0x00BD3EEC File Offset: 0x00BD20EC
		[NullableContext(2)]
		private void RunSubActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions, Action<bool> callback = null, bool append = false)
		{
			FlowController.Instance.ExecuteSubActions(actions, delegate(bool result)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(result);
			}, append);
		}

		// Token: 0x06029D59 RID: 171353 RVA: 0x00BD3F20 File Offset: 0x00BD2120
		[NullableContext(2)]
		public ITalkItem CreateSubtitleFromTalkItem(int talkId)
		{
			if (!this.IsInit)
			{
				return null;
			}
			ITalkItem talkItem = null;
			foreach (ITalkItem talkItem2 in this.CurShowTalk.TalkItems)
			{
				if (talkItem2.Id == talkId)
				{
					talkItem = talkItem2;
					break;
				}
			}
			if (talkItem == null)
			{
				FlowController instance = FlowController.Instance;
				string text = "[FlowSequence] 剧情Seq找不到字幕";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("talkId", talkId);
				instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return talkItem;
		}

		// Token: 0x06029D5A RID: 171354 RVA: 0x00BD3FB8 File Offset: 0x00BD21B8
		[NullableContext(2)]
		public ITalkItem GetNextTalkItem()
		{
			if (this.NextTalkIndex != null && this.CurShowTalk != null && this.CurShowTalk.TalkItems.Count > 0)
			{
				int count = this.CurShowTalk.TalkItems.Count;
				int? nextTalkIndex = this.NextTalkIndex;
				if (count > nextTalkIndex.GetValueOrDefault() & nextTalkIndex != null)
				{
					return this.CurShowTalk.TalkItems[this.NextTalkIndex.Value];
				}
			}
			return null;
		}

		// Token: 0x06029D5B RID: 171355 RVA: 0x00BD4034 File Offset: 0x00BD2234
		public unsafe void RunSequenceFrameEventsWhenSkip(int? id)
		{
			if (id == null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "RunSequenceFrameEventsWhenSkip 但id为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			HashSet<string> hashSet = null;
			HashSet<string> hashSet2;
			if (this.FrameEventsMap.TryGetValue(id.Value, out hashSet2))
			{
				hashSet = hashSet2;
			}
			if (hashSet != null)
			{
				foreach (string text in hashSet)
				{
					List<ActionInfo> list;
					if (this.FrameEvents.TryGetValue(text, out list) && list.Count != 0)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Plot;
						ELogAuthor author = ELogAuthor.JYS;
						string message = "RunSequenceFrameEventsWhenSkip";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", text);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						FlowController.Instance.ExecuteSubActions(list, delegate(bool result)
						{
						}, false);
					}
				}
			}
		}

		// Token: 0x06029D5C RID: 171356 RVA: 0x00BD4170 File Offset: 0x00BD2370
		public List<int> GetAllQte()
		{
			List<int> list = new List<int>();
			ShowTalk curShowTalk = this.CurShowTalk;
			if (((curShowTalk != null) ? curShowTalk.TalkItems : null) != null)
			{
				foreach (ITalkItem talkItem in this.CurShowTalk.TalkItems)
				{
					if (talkItem.Type.GetValueOrDefault() == ETalkItemType.QTE)
					{
						list.Add((talkItem as ITalkItemQte).QteId);
					}
				}
			}
			return list;
		}

		// Token: 0x04016D06 RID: 93446
		public const int FINISH_INDEX = -1;

		// Token: 0x04016D07 RID: 93447
		public const int INVALID_INDEX = -2;

		// Token: 0x04016D08 RID: 93448
		private bool IsInitInner;

		// Token: 0x04016D09 RID: 93449
		private bool IsPlayingInner;

		// Token: 0x04016D0A RID: 93450
		[Nullable(2)]
		private ShowTalk CurShowTalk;

		// Token: 0x04016D0B RID: 93451
		private readonly Dictionary<int, int> IdIndexMap = new Dictionary<int, int>();

		// Token: 0x04016D0C RID: 93452
		private int NextSequenceIndex = -2;

		// Token: 0x04016D0D RID: 93453
		[Nullable(2)]
		private ITalkItem CurTalkItem;

		// Token: 0x04016D0E RID: 93454
		[Nullable(2)]
		private FlowContext Context;

		// Token: 0x04016D0F RID: 93455
		private bool IsSubtitleShowed;

		// Token: 0x04016D10 RID: 93456
		private bool IsOptionSelected;

		// Token: 0x04016D11 RID: 93457
		private bool IsSkipping;

		// Token: 0x04016D12 RID: 93458
		private int? NextTalkIndex = new int?(0);

		// Token: 0x04016D13 RID: 93459
		[Nullable(2)]
		private List<Transform> FinalPos;

		// Token: 0x04016D14 RID: 93460
		private readonly List<bool> IsFadeEnd = new List<bool>();

		// Token: 0x04016D15 RID: 93461
		private readonly Dictionary<int, HashSet<string>> FrameEventsMap = new Dictionary<int, HashSet<string>>();

		// Token: 0x04016D16 RID: 93462
		private readonly Dictionary<string, List<ActionInfo>> FrameEvents = new Dictionary<string, List<ActionInfo>>();

		// Token: 0x04016D17 RID: 93463
		[Nullable(2)]
		public CustomPromise SubtitleActionPromise;

		// Token: 0x04016D18 RID: 93464
		[Nullable(2)]
		public CustomPromise OptionActionPromise;

		// Token: 0x04016D19 RID: 93465
		private readonly Dictionary<int, ITalkItemQte> CurrentQte = new Dictionary<int, ITalkItemQte>();

		// Token: 0x04016D1A RID: 93466
		private readonly Dictionary<int, int> QteLatentAction = new Dictionary<int, int>();

		// Token: 0x04016D1B RID: 93467
		[Nullable(2)]
		private TimerHandle DelayEnableSkipTimer;

		// Token: 0x04016D1C RID: 93468
		private readonly List<FName> NpcPerformArray = new List<FName>();

		// Token: 0x04016D1D RID: 93469
		private readonly Dictionary<FName, NpcRelation> NpcPerformRelationMap = new Dictionary<FName, NpcRelation>();

		// Token: 0x04016D1E RID: 93470
		private int LastId = -1;

		// Token: 0x04016D1F RID: 93471
		private bool LastHasOption;
	}
}
