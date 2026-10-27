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
	// Token: 0x02005096 RID: 20630
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class FlowController : ControllerWithAssistantBase
	{
		// Token: 0x17008084 RID: 32900
		// (get) Token: 0x06034DD1 RID: 216529 RVA: 0x00C8254F File Offset: 0x00C8074F
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06034DD2 RID: 216530 RVA: 0x00C82552 File Offset: 0x00C80752
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			FlowNetworks.Register();
			return result;
		}

		// Token: 0x06034DD3 RID: 216531 RVA: 0x00C8255F File Offset: 0x00C8075F
		protected override bool OnClear()
		{
			FlowNetworks.UnRegister();
			return base.OnClear();
		}

		// Token: 0x06034DD4 RID: 216532 RVA: 0x00C8256C File Offset: 0x00C8076C
		protected override void RegisterAssistant()
		{
			base.AddAssistant(0, new FlowServerNotifyCenter());
			base.AddAssistant(1, new FlowActionCenter());
			base.AddAssistant(2, new FlowActionRunner());
			base.AddAssistant(3, new FlowLaunchCenter());
		}

		// Token: 0x06034DD5 RID: 216533 RVA: 0x00C825A0 File Offset: 0x00C807A0
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

		// Token: 0x06034DD6 RID: 216534 RVA: 0x00C825E4 File Offset: 0x00C807E4
		public void StartNotify(FlowStartNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowStartNotify(notify);
		}

		// Token: 0x06034DD7 RID: 216535 RVA: 0x00C825F8 File Offset: 0x00C807F8
		public void EndNotify(FlowEndNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowEndNotify(notify);
		}

		// Token: 0x06034DD8 RID: 216536 RVA: 0x00C8260C File Offset: 0x00C8080C
		public void SkipBlackScreenNotify(FlowServerSkipNotify notify)
		{
			FlowServerNotifyCenter assistant = this.GetAssistant<FlowServerNotifyCenter>(FlowController.EAssistantType.ServerNotifyCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleFlowSkipBlackScreenNotify(notify);
		}

		// Token: 0x06034DD9 RID: 216537 RVA: 0x00C82620 File Offset: 0x00C80820
		public void ClearOnLeaveOnlineWorld()
		{
		}

		// Token: 0x06034DDA RID: 216538 RVA: 0x00C82622 File Offset: 0x00C80822
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

		// Token: 0x06034DDB RID: 216539 RVA: 0x00C82637 File Offset: 0x00C80837
		public void ExecuteActions(List<ActionInfo> actions, FlowContext context, Action callback)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ExecuteActions(actions, context, callback);
		}

		// Token: 0x06034DDC RID: 216540 RVA: 0x00C8264D File Offset: 0x00C8084D
		public void FinishFlow(string reason, long? incId = null, bool isServerEnd = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.FinishFlow(reason, incId, isServerEnd);
		}

		// Token: 0x06034DDD RID: 216541 RVA: 0x00C82663 File Offset: 0x00C80863
		public bool HasFlow(string flowListName, int flowId, int flowStateId)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.HasFlow(flowListName, flowId, flowStateId);
		}

		// Token: 0x06034DDE RID: 216542 RVA: 0x00C8267A File Offset: 0x00C8087A
		public void MarkClientError(string reason)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.MarkClientError(reason);
		}

		// Token: 0x06034DDF RID: 216543 RVA: 0x00C8268E File Offset: 0x00C8088E
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

		// Token: 0x06034DE0 RID: 216544 RVA: 0x00C826A2 File Offset: 0x00C808A2
		public void BackgroundFlow(string reason, bool useFade = true, bool isServerEnd = false, bool stopAtNoSkipSetPlotMode = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.BackgroundActions(reason, useFade, isServerEnd, stopAtNoSkipSetPlotMode);
		}

		// Token: 0x06034DE1 RID: 216545 RVA: 0x00C826BA File Offset: 0x00C808BA
		public void RunNextAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ExecuteNextAction();
		}

		// Token: 0x06034DE2 RID: 216546 RVA: 0x00C826CD File Offset: 0x00C808CD
		public void FinishFlowByGm()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.ForceFinishActionsByGm();
		}

		// Token: 0x06034DE3 RID: 216547 RVA: 0x00C826E0 File Offset: 0x00C808E0
		public EAction? GetCurFlowAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return null;
			}
			return assistant.GetCurActionName();
		}

		// Token: 0x06034DE4 RID: 216548 RVA: 0x00C82707 File Offset: 0x00C80907
		public bool IsInShowTalk()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.IsInShowTalk();
		}

		// Token: 0x06034DE5 RID: 216549 RVA: 0x00C8271B File Offset: 0x00C8091B
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

		// Token: 0x06034DE6 RID: 216550 RVA: 0x00C82731 File Offset: 0x00C80931
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

		// Token: 0x06034DE7 RID: 216551 RVA: 0x00C82745 File Offset: 0x00C80945
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

		// Token: 0x06034DE8 RID: 216552 RVA: 0x00C82759 File Offset: 0x00C80959
		public void AddActionNext(ActionInfo actionInfo)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.AddActionNext(actionInfo);
		}

		// Token: 0x06034DE9 RID: 216553 RVA: 0x00C8276D File Offset: 0x00C8096D
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

		// Token: 0x06034DEA RID: 216554 RVA: 0x00C82782 File Offset: 0x00C80982
		public void SelectOption(int talkId, int index)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RecordOption(talkId, index);
		}

		// Token: 0x06034DEB RID: 216555 RVA: 0x00C82797 File Offset: 0x00C80997
		public void RecordTalkItem(ITalkItem talkItem)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RecordTalkItem(talkItem);
		}

		// Token: 0x06034DEC RID: 216556 RVA: 0x00C827AC File Offset: 0x00C809AC
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

		// Token: 0x06034DED RID: 216557 RVA: 0x00C828BC File Offset: 0x00C80ABC
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

		// Token: 0x17008085 RID: 32901
		// (get) Token: 0x06034DEE RID: 216558 RVA: 0x00C82917 File Offset: 0x00C80B17
		public FlowSequence FlowSequence
		{
			get
			{
				return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).FlowSequence;
			}
		}

		// Token: 0x17008086 RID: 32902
		// (get) Token: 0x06034DEF RID: 216559 RVA: 0x00C82925 File Offset: 0x00C80B25
		public FlowShowTalk FlowShowTalk
		{
			get
			{
				return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).FlowShowTalk;
			}
		}

		// Token: 0x06034DF0 RID: 216560 RVA: 0x00C82933 File Offset: 0x00C80B33
		public void EnableSkip(bool enable)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.EnableSkip(enable);
		}

		// Token: 0x06034DF1 RID: 216561 RVA: 0x00C82947 File Offset: 0x00C80B47
		public bool IsSkipEnabled()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.IsSkipEnabled();
		}

		// Token: 0x06034DF2 RID: 216562 RVA: 0x00C8295B File Offset: 0x00C80B5B
		public bool CheckCanSkipTmp()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CheckCanSkipTmp();
		}

		// Token: 0x06034DF3 RID: 216563 RVA: 0x00C8296F File Offset: 0x00C80B6F
		public void CountDownSkip(bool enable)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.TriggerCountDownSkip(enable);
		}

		// Token: 0x06034DF4 RID: 216564 RVA: 0x00C82983 File Offset: 0x00C80B83
		public void CheckDisableInput(EPlotLevel? level = null, bool seamless = false, bool disableSequenceInertiaKeeper = false)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.HandleInputBeforePlay(level, seamless, disableSequenceInertiaKeeper);
		}

		// Token: 0x06034DF5 RID: 216565 RVA: 0x00C82999 File Offset: 0x00C80B99
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

		// Token: 0x06034DF6 RID: 216566 RVA: 0x00C829AE File Offset: 0x00C80BAE
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

		// Token: 0x06034DF7 RID: 216567 RVA: 0x00C829C3 File Offset: 0x00C80BC3
		public long GetFlowIncId()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return 0L;
			}
			return assistant.GetFlowIncId();
		}

		// Token: 0x06034DF8 RID: 216568 RVA: 0x00C829D8 File Offset: 0x00C80BD8
		public void RequestPosition(IVector location, IRotator rotation)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestPosition(location, rotation);
		}

		// Token: 0x06034DF9 RID: 216569 RVA: 0x00C829ED File Offset: 0x00C80BED
		public bool CheckViewControlBeginForC()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CheckViewControlBeginForC();
		}

		// Token: 0x06034DFA RID: 216570 RVA: 0x00C82A01 File Offset: 0x00C80C01
		public List<ActionParams> GetNameAction(EAction name)
		{
			return this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner).GetNameAction(name);
		}

		// Token: 0x06034DFB RID: 216571 RVA: 0x00C82A10 File Offset: 0x00C80C10
		public string GetFlowName()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return ((assistant != null) ? assistant.GetFlowName() : null) ?? string.Empty;
		}

		// Token: 0x06034DFC RID: 216572 RVA: 0x00C82A2E File Offset: 0x00C80C2E
		public bool HasPendingShowTalkOrSequenceDataAction()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.HasPendingShowTalkOrSequenceDataAction();
		}

		// Token: 0x06034DFD RID: 216573 RVA: 0x00C82A42 File Offset: 0x00C80C42
		public bool CollectSeamlessFinalize(ESeamlessFinalizeFlag flag)
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			return assistant != null && assistant.CollectSeamlessFinalize(flag);
		}

		// Token: 0x06034DFE RID: 216574 RVA: 0x00C82A57 File Offset: 0x00C80C57
		public void RunDeferredSeamlessFinalizeOnPlotEnd()
		{
			FlowActionRunner assistant = this.GetAssistant<FlowActionRunner>(FlowController.EAssistantType.ActionRunner);
			if (assistant == null)
			{
				return;
			}
			assistant.RunDeferredSeamlessFinalizeOnPlotEnd();
		}

		// Token: 0x06034DFF RID: 216575 RVA: 0x00C82A6A File Offset: 0x00C80C6A
		public void StartFlowByRes(string res)
		{
		}

		// Token: 0x06034E00 RID: 216576 RVA: 0x00C82A6C File Offset: 0x00C80C6C
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

		// Token: 0x06034E01 RID: 216577 RVA: 0x00C82AA0 File Offset: 0x00C80CA0
		public long StartFlowForView(string flowListName, int flowId, int stateId, UiParam uiParam, bool canBeAbandoned = true)
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return 0L;
			}
			return assistant.StartFlow(flowListName, flowId, stateId, null, 0L, false, false, uiParam, canBeAbandoned, false, null, null, false);
		}

		// Token: 0x06034E02 RID: 216578 RVA: 0x00C82AD0 File Offset: 0x00C80CD0
		[NullableContext(2)]
		public long StartFlowForCallback([Nullable(1)] string flowListName, int flowId, int stateId, Action callback, GeneralContext context = null, long flowIncId = 0L, bool isServerNotify = false, bool isAsync = false, bool isSkip = false, global::Vector pos = null)
		{
			return this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter).StartFlow(flowListName, flowId, stateId, context, flowIncId, isServerNotify, isAsync, null, false, isSkip, pos, callback, false);
		}

		// Token: 0x06034E03 RID: 216579 RVA: 0x00C82B00 File Offset: 0x00C80D00
		public void StartFlowForTeleportTransition(string flowListName, int flowId, int stateId, [Nullable(2)] Action callback = null)
		{
			this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter).StartFlow(flowListName, flowId, stateId, null, 0L, false, false, null, false, false, null, callback, true);
		}

		// Token: 0x06034E04 RID: 216580 RVA: 0x00C82B29 File Offset: 0x00C80D29
		public void StartPlotNetworkPending()
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.StartPlotNetworkPending();
		}

		// Token: 0x06034E05 RID: 216581 RVA: 0x00C82B3C File Offset: 0x00C80D3C
		protected override void OnTick(float delta)
		{
			FlowLaunchCenter assistant = this.GetAssistant<FlowLaunchCenter>(FlowController.EAssistantType.LaunchCenter);
			if (assistant == null)
			{
				return;
			}
			assistant.Tick(delta);
		}

		// Token: 0x17008087 RID: 32903
		// (get) Token: 0x06034E06 RID: 216582 RVA: 0x00C82B50 File Offset: 0x00C80D50
		public static FlowController Instance
		{
			get
			{
				return FlowController._Instance;
			}
		}

		// Token: 0x06034E07 RID: 216583 RVA: 0x00C82B57 File Offset: 0x00C80D57
		public static FlowController GetOrCreateInstance()
		{
			if (FlowController._Instance == null)
			{
				FlowController.CreateInstance();
			}
			return FlowController._Instance;
		}

		// Token: 0x06034E08 RID: 216584 RVA: 0x00C82B6B File Offset: 0x00C80D6B
		public static bool CreateInstance()
		{
			if (FlowController._Instance != null)
			{
				return true;
			}
			FlowController._Instance = new FlowController();
			return true;
		}

		// Token: 0x06034E09 RID: 216585 RVA: 0x00C82B81 File Offset: 0x00C80D81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034E0A RID: 216586 RVA: 0x00C82B83 File Offset: 0x00C80D83
		public static void ResetStaticDefaultValue()
		{
			FlowController._Instance = null;
		}

		// Token: 0x06034E0B RID: 216587 RVA: 0x00C82B8B File Offset: 0x00C80D8B
		static FlowController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowController.CreateStaticDefaultValue), new Action(FlowController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C288 RID: 115336
		public const int LOCAL_FLOWINCID = -1;

		// Token: 0x0401C289 RID: 115337
		[Nullable(2)]
		private static FlowController _Instance;

		// Token: 0x0200B224 RID: 45604
		[NullableContext(0)]
		private enum EAssistantType
		{
			// Token: 0x04036054 RID: 221268
			ServerNotifyCenter,
			// Token: 0x04036055 RID: 221269
			ActionCenter,
			// Token: 0x04036056 RID: 221270
			ActionRunner,
			// Token: 0x04036057 RID: 221271
			LaunchCenter
		}
	}
}
