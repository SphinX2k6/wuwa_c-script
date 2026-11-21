using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Framework;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004066 RID: 16486
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class FlowController : ControllerWithAssistantBase
	{
		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x06029CCA RID: 171210 RVA: 0x00BCF76F File Offset: 0x00BCD96F
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06029CCB RID: 171211 RVA: 0x00BCF772 File Offset: 0x00BCD972
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			FlowNetworks.Register();
			return result;
		}

		// Token: 0x06029CCC RID: 171212 RVA: 0x00BCF77F File Offset: 0x00BCD97F
		protected override bool OnClear()
		{
			FlowNetworks.UnRegister();
			return base.OnClear();
		}

		// Token: 0x06029CCD RID: 171213 RVA: 0x00BCF78C File Offset: 0x00BCD98C
		protected override void RegisterAssistant()
		{
			base.AddAssistant(0, new FlowServerNotifyCenter());
			base.AddAssistant(1, new FlowActionCenter());
			base.AddAssistant(2, new FlowActionRunner());
			base.AddAssistant(3, new FlowLaunchCenter());
		}

		// Token: 0x06029CCE RID: 171214 RVA: 0x00BCF7C0 File Offset: 0x00BCD9C0
		[return: Nullable(2)]
		private T GetAssistant<T>(FlowController.EAssistantType type) where T : class
		{
			if (this.Assistants == null)
			{
				return default(T);
			}
			ControllerAssistantBase controllerAssistantBase;
			if (this.Assistants.TryGetValue((int)type, out controllerAssistantBase))
			{
				return controllerAssistantBase as T;
			}
			return default(T);
		}

		// Token: 0x06029CCF RID: 171215 RVA: 0x00BCF804 File Offset: 0x00BCDA04
		public void StartNotify(FlowStartNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowStartNotify(notify);
		}

		// Token: 0x06029CD0 RID: 171216 RVA: 0x00BCF818 File Offset: 0x00BCDA18
		public void EndNotify(FlowEndNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowEndNotify(notify);
		}

		// Token: 0x06029CD1 RID: 171217 RVA: 0x00BCF82C File Offset: 0x00BCDA2C
		public void SkipBlackScreenNotify(FlowServerSkipNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowSkipBlackScreenNotify(notify);
		}

		// Token: 0x06029CD2 RID: 171218 RVA: 0x00BCF840 File Offset: 0x00BCDA40
		public void ClearOnLeaveOnlineWorld()
		{
		}

		// Token: 0x06029CD3 RID: 171219 RVA: 0x00BCF842 File Offset: 0x00BCDA42
		[NullableContext(2)]
		public FlowAction GetFlowAction(EAction type)
		{
			FlowActionCenter assistant = this.GetAssistant<FlowActionCenter>(FlowController.EAssistantType.ActionCenter);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetFlowAction(type);
		}

		// Token: 0x06029CD4 RID: 171220 RVA: 0x00BCF857 File Offset: 0x00BCDA57
		public void ExecuteActions(List<ActionInfo> actions, FlowContext context, Action callback)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ExecuteActions(actions, context, callback);
		}

		// Token: 0x06029CD5 RID: 171221 RVA: 0x00BCF86D File Offset: 0x00BCDA6D
		public void FinishFlow(string reason, long? incId = null, bool isServerEnd = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.FinishFlow(reason, incId, isServerEnd);
		}

		// Token: 0x06029CD6 RID: 171222 RVA: 0x00BCF883 File Offset: 0x00BCDA83
		public bool HasFlow(string flowListName, int flowId, int flowStateId)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.HasFlow(flowListName, flowId, flowStateId);
		}

		// Token: 0x06029CD7 RID: 171223 RVA: 0x00BCF89A File Offset: 0x00BCDA9A
		public void MarkClientError(string reason)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.MarkClientError(reason);
		}

		// Token: 0x06029CD8 RID: 171224 RVA: 0x00BCF8AE File Offset: 0x00BCDAAE
		[NullableContext(2)]
		public FlowContext GetCurrentContext()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetCurrentContext();
		}

		// Token: 0x06029CD9 RID: 171225 RVA: 0x00BCF8C2 File Offset: 0x00BCDAC2
		public void BackgroundFlow(string reason, bool useFade = true, bool isServerEnd = false, bool stopAtNoSkipSetPlotMode = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.BackgroundActions(reason, useFade, isServerEnd, stopAtNoSkipSetPlotMode);
		}

		// Token: 0x06029CDA RID: 171226 RVA: 0x00BCF8DA File Offset: 0x00BCDADA
		public void RunNextAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ExecuteNextAction();
		}

		// Token: 0x06029CDB RID: 171227 RVA: 0x00BCF8ED File Offset: 0x00BCDAED
		public void FinishFlowByGm()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ForceFinishActionsByGm();
		}

		// Token: 0x06029CDC RID: 171228 RVA: 0x00BCF900 File Offset: 0x00BCDB00
		public EAction? GetCurFlowAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetCurActionName();
		}

		// Token: 0x06029CDD RID: 171229 RVA: 0x00BCF927 File Offset: 0x00BCDB27
		public bool IsInShowTalk()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.IsInShowTalk();
		}

		// Token: 0x06029CDE RID: 171230 RVA: 0x00BCF93B File Offset: 0x00BCDB3B
		public void ExecuteSubActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions, Action<bool> callback, bool append = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ExecuteSubActions(actions, callback, append);
		}

		// Token: 0x06029CDF RID: 171231 RVA: 0x00BCF951 File Offset: 0x00BCDB51
		[NullableContext(2)]
		public global::Vector GetInteractPoint()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetInteractPoint();
		}

		// Token: 0x06029CE0 RID: 171232 RVA: 0x00BCF965 File Offset: 0x00BCDB65
		[NullableContext(2)]
		public IInteractCameraOffsetConfig GetCameraOffsetConfig()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetCameraOffsetConfig();
		}

		// Token: 0x06029CE1 RID: 171233 RVA: 0x00BCF979 File Offset: 0x00BCDB79
		public void AddActionNext(ActionInfo actionInfo)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.AddActionNext(actionInfo);
		}

		// Token: 0x06029CE2 RID: 171234 RVA: 0x00BCF98D File Offset: 0x00BCDB8D
		[NullableContext(2)]
		public int GetRecommendedOption(ITalkItem talkItem = null)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return 0;
			}
			return assistant.GetOptionToSelect(talkItem);
		}

		// Token: 0x06029CE3 RID: 171235 RVA: 0x00BCF9A2 File Offset: 0x00BCDBA2
		public void SelectOption(int talkId, int index)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RecordOption(talkId, index);
		}

		// Token: 0x06029CE4 RID: 171236 RVA: 0x00BCF9B7 File Offset: 0x00BCDBB7
		public void RecordTalkItem(ITalkItem talkItem)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RecordTalkItem(talkItem);
		}

		// Token: 0x06029CE5 RID: 171237 RVA: 0x00BCF9CC File Offset: 0x00BCDBCC
		public PlotReviewViewData CreatePlotReviewViewData()
		{
			List<PlotReviewItemData> list = new List<PlotReviewItemData>();
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			List<TalkRecord> list2 = (assistant != null) ? assistant.GetTalkHistory() : null;
			if (list2 != null && list2.Count > 0)
			{
				foreach (TalkRecord talkRecord in list2)
				{
					if (talkRecord.IsOption)
					{
						PlotReviewOptionItemData data = new PlotReviewOptionItemData
						{
							TalkItem = talkRecord.TalkItem,
							OptionIndex = talkRecord.OptionIndex.GetValueOrDefault()
						};
						PlotReviewItemData item = new PlotReviewItemData
						{
							Type = EPlotReviewItemType.Option,
							Data = data
						};
						list.Add(item);
					}
					else
					{
						PlotReviewTalkItemData data2 = new PlotReviewTalkItemData
						{
							TalkItem = talkRecord.TalkItem,
							IsPlaying = false
						};
						PlotReviewItemData item2 = new PlotReviewItemData
						{
							Type = EPlotReviewItemType.Talk,
							Data = data2
						};
						list.Add(item2);
					}
				}
			}
			return new PlotReviewViewData
			{
				PlotReviewItemDataList = list
			};
		}

		// Token: 0x06029CE6 RID: 171238 RVA: 0x00BCFADC File Offset: 0x00BCDCDC
		public bool OpenPlotReviewView()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			List<TalkRecord> list = (assistant != null) ? assistant.GetTalkHistory() : null;
			if (list == null || list.Count == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PlotView_001", Array.Empty<object>());
				return false;
			}
			PlotReviewViewData param = this.CreatePlotReviewViewData();
			UiManager.Instance.OpenView(EUiViewName.PlotReviewView, param, null);
			return true;
		}

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x06029CE7 RID: 171239 RVA: 0x00BCFB37 File Offset: 0x00BCDD37
		public FlowSequence FlowSequence
		{
			get
			{
				return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).FlowSequence;
			}
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x06029CE8 RID: 171240 RVA: 0x00BCFB45 File Offset: 0x00BCDD45
		public FlowShowTalk FlowShowTalk
		{
			get
			{
				return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).FlowShowTalk;
			}
		}

		// Token: 0x06029CE9 RID: 171241 RVA: 0x00BCFB53 File Offset: 0x00BCDD53
		public void EnableSkip(bool enable)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.EnableSkip(enable);
		}

		// Token: 0x06029CEA RID: 171242 RVA: 0x00BCFB67 File Offset: 0x00BCDD67
		public bool IsSkipEnabled()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.IsSkipEnabled();
		}

		// Token: 0x06029CEB RID: 171243 RVA: 0x00BCFB7B File Offset: 0x00BCDD7B
		public bool CheckCanSkipTmp()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CheckCanSkipTmp();
		}

		// Token: 0x06029CEC RID: 171244 RVA: 0x00BCFB8F File Offset: 0x00BCDD8F
		public void CountDownSkip(bool enable)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.TriggerCountDownSkip(enable);
		}

		// Token: 0x06029CED RID: 171245 RVA: 0x00BCFBA3 File Offset: 0x00BCDDA3
		public void CheckDisableInput(EPlotLevel? level = null, bool seamless = false, bool disableSequenceInertiaKeeper = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleInputBeforePlay(level, seamless, disableSequenceInertiaKeeper);
		}

		// Token: 0x06029CEE RID: 171246 RVA: 0x00BCFBB9 File Offset: 0x00BCDDB9
		[NullableContext(2)]
		public ActionInfo GetNextAction(bool bCheckSubAction = true)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetNextAction(bCheckSubAction);
		}

		// Token: 0x06029CEF RID: 171247 RVA: 0x00BCFBCE File Offset: 0x00BCDDCE
		public void LogError(string text, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.LogError(text, pairs);
		}

		// Token: 0x06029CF0 RID: 171248 RVA: 0x00BCFBE3 File Offset: 0x00BCDDE3
		public long GetFlowIncId()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return 0L;
			}
			return assistant.GetFlowIncId();
		}

		// Token: 0x06029CF1 RID: 171249 RVA: 0x00BCFBF8 File Offset: 0x00BCDDF8
		public void RequestPosition(IVector location, IRotator rotation)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestPosition(location, rotation);
		}

		// Token: 0x06029CF2 RID: 171250 RVA: 0x00BCFC0D File Offset: 0x00BCDE0D
		public bool CheckViewControlBeginForC()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CheckViewControlBeginForC();
		}

		// Token: 0x06029CF3 RID: 171251 RVA: 0x00BCFC21 File Offset: 0x00BCDE21
		public List<ActionParams> GetNameAction(EAction name)
		{
			return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).GetNameAction(name);
		}

		// Token: 0x06029CF4 RID: 171252 RVA: 0x00BCFC30 File Offset: 0x00BCDE30
		public string GetFlowName()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return ((assistant != null) ? assistant.GetFlowName() : null) ?? string.Empty;
		}

		// Token: 0x06029CF5 RID: 171253 RVA: 0x00BCFC4E File Offset: 0x00BCDE4E
		public bool HasPendingShowTalkOrSequenceDataAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.HasPendingShowTalkOrSequenceDataAction();
		}

		// Token: 0x06029CF6 RID: 171254 RVA: 0x00BCFC62 File Offset: 0x00BCDE62
		public bool CollectSeamlessFinalize(ESeamlessFinalizeFlag flag)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CollectSeamlessFinalize(flag);
		}

		// Token: 0x06029CF7 RID: 171255 RVA: 0x00BCFC77 File Offset: 0x00BCDE77
		public void RunDeferredSeamlessFinalizeOnPlotEnd()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RunDeferredSeamlessFinalizeOnPlotEnd();
		}

		// Token: 0x06029CF8 RID: 171256 RVA: 0x00BCFC8A File Offset: 0x00BCDE8A
		public void StartFlowByRes(string res)
		{
		}

		// Token: 0x06029CF9 RID: 171257 RVA: 0x00BCFC8C File Offset: 0x00BCDE8C
		[NullableContext(2)]
		public long StartFlow([Nullable(1)] string flowListName, int flowId, int stateId, GeneralContext context = null, long flowIncId = 0L, bool isServerNotify = false, bool isAsync = false, bool isSkip = false, global::Vector pos = null)
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return 0L;
			}
			return assistant.StartFlow(flowListName, flowId, stateId, context, flowIncId, isServerNotify, isAsync, null, false, isSkip, pos, null, false);
		}

		// Token: 0x06029CFA RID: 171258 RVA: 0x00BCFCC0 File Offset: 0x00BCDEC0
		public long StartFlowForView(string flowListName, int flowId, int stateId, UiParam uiParam, bool canBeAbandoned = true)
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return 0L;
			}
			return assistant.StartFlow(flowListName, flowId, stateId, null, 0L, false, false, uiParam, canBeAbandoned, false, null, null, false);
		}

		// Token: 0x06029CFB RID: 171259 RVA: 0x00BCFCF0 File Offset: 0x00BCDEF0
		[NullableContext(2)]
		public long StartFlowForCallback([Nullable(1)] string flowListName, int flowId, int stateId, Action callback, GeneralContext context = null, long flowIncId = 0L, bool isServerNotify = false, bool isAsync = false, bool isSkip = false, global::Vector pos = null)
		{
			return this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter).StartFlow(flowListName, flowId, stateId, context, flowIncId, isServerNotify, isAsync, null, false, isSkip, pos, callback, false);
		}

		// Token: 0x06029CFC RID: 171260 RVA: 0x00BCFD20 File Offset: 0x00BCDF20
		public void StartFlowForTeleportTransition(string flowListName, int flowId, int stateId, [Nullable(2)] Action callback = null)
		{
			this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter).StartFlow(flowListName, flowId, stateId, null, 0L, false, false, null, false, false, null, callback, true);
		}

		// Token: 0x06029CFD RID: 171261 RVA: 0x00BCFD49 File Offset: 0x00BCDF49
		public void StartPlotNetworkPending()
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.StartPlotNetworkPending();
		}

		// Token: 0x06029CFE RID: 171262 RVA: 0x00BCFD5C File Offset: 0x00BCDF5C
		protected override void OnTick(float delta)
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.Tick(delta);
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x06029CFF RID: 171263 RVA: 0x00BCFD70 File Offset: 0x00BCDF70
		public static FlowController Instance
		{
			get
			{
				return FlowController._Instance;
			}
		}

		// Token: 0x06029D00 RID: 171264 RVA: 0x00BCFD77 File Offset: 0x00BCDF77
		public static FlowController GetOrCreateInstance()
		{
			if (FlowController._Instance == null)
			{
				FlowController.CreateInstance();
			}
			return FlowController._Instance;
		}

		// Token: 0x06029D01 RID: 171265 RVA: 0x00BCFD8B File Offset: 0x00BCDF8B
		public static bool CreateInstance()
		{
			if (FlowController._Instance != null)
			{
				return true;
			}
			FlowController._Instance = new FlowController();
			return true;
		}

		// Token: 0x06029D02 RID: 171266 RVA: 0x00BCFDA1 File Offset: 0x00BCDFA1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029D03 RID: 171267 RVA: 0x00BCFDA3 File Offset: 0x00BCDFA3
		public static void ResetStaticDefaultValue()
		{
			FlowController._Instance = null;
		}

		// Token: 0x06029D04 RID: 171268 RVA: 0x00BCFDAB File Offset: 0x00BCDFAB
		static FlowController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowController.CreateStaticDefaultValue), new Action(FlowController.ResetStaticDefaultValue));
		}

		// Token: 0x04016CB7 RID: 93367
		public const int LOCAL_FLOWINCID = -1;

		// Token: 0x04016CB8 RID: 93368
		[Nullable(2)]
		private static FlowController _Instance;

		// Token: 0x02009C5D RID: 40029
		[NullableContext(0)]
		private enum EAssistantType
		{
			// Token: 0x04030AA8 RID: 199336
			ServerNotifyCenter,
			// Token: 0x04030AA9 RID: 199337
			ActionCenter,
			// Token: 0x04030AAA RID: 199338
			ActionRunner,
			// Token: 0x04030AAB RID: 199339
			LaunchCenter
		}
	}
}
