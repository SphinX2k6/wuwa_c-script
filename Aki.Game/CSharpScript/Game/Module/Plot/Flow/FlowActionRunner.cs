using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot.FlowActions;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004062 RID: 16482
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionRunner : ControllerAssistantBase
	{
		// Token: 0x06029C6C RID: 171116 RVA: 0x00BCD190 File Offset: 0x00BCB390
		protected override void OnDestroy()
		{
			this.Context = null;
			this.CurAction = null;
			this.CurActionInstance = null;
			this.CurSubAction = null;
			this.CurSubActionInstance = null;
		}

		// Token: 0x06029C6D RID: 171117 RVA: 0x00BCD1B5 File Offset: 0x00BCB3B5
		public void EnableSkip(bool enable)
		{
			if (this.Context == null)
			{
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.EnableSkipPlot, enable);
			this.Context.CanSkip = enable;
		}

		// Token: 0x06029C6E RID: 171118 RVA: 0x00BCD1DD File Offset: 0x00BCB3DD
		public bool IsSkipEnabled()
		{
			FlowContext context = this.Context;
			return context != null && context.CanSkip;
		}

		// Token: 0x06029C6F RID: 171119 RVA: 0x00BCD1F0 File Offset: 0x00BCB3F0
		[NullableContext(2)]
		public FlowContext GetCurrentContext()
		{
			return this.Context;
		}

		// Token: 0x06029C70 RID: 171120 RVA: 0x00BCD1F8 File Offset: 0x00BCB3F8
		[NullableContext(2)]
		public global::Vector GetInteractPoint()
		{
			Entity entity = null;
			FlowContext context = this.Context;
			if (((context != null) ? context.Context : null) != null && this.Context.Context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				entity = EntitySystem.Instance.Get(((EntityContext)this.Context.Context).EntityId.Value);
			}
			if (entity == null)
			{
				return null;
			}
			PawnInteractNewComponent component = entity.GetComponent<PawnInteractNewComponent>();
			if (component == null)
			{
				return null;
			}
			PawnInteractController interactController = component.GetInteractController();
			if (interactController == null)
			{
				return null;
			}
			return interactController.GetInteractPoint();
		}

		// Token: 0x06029C71 RID: 171121 RVA: 0x00BCD27C File Offset: 0x00BCB47C
		[NullableContext(2)]
		public IInteractCameraOffsetConfig GetCameraOffsetConfig()
		{
			Entity entity = null;
			FlowContext context = this.Context;
			if (((context != null) ? context.Context : null) != null && this.Context.Context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				entity = EntitySystem.Instance.Get(((EntityContext)this.Context.Context).EntityId.Value);
			}
			if (entity == null)
			{
				return null;
			}
			PawnInteractNewComponent component = entity.GetComponent<PawnInteractNewComponent>();
			if (component == null)
			{
				return null;
			}
			PawnInteractController interactController = component.GetInteractController();
			if (interactController == null)
			{
				return null;
			}
			return interactController.GetCameraOffsetConfig();
		}

		// Token: 0x06029C72 RID: 171122 RVA: 0x00BCD2FE File Offset: 0x00BCB4FE
		public bool IsInShowTalk()
		{
			return this.Context != null && this.Context.CurShowTalk != null;
		}

		// Token: 0x06029C73 RID: 171123 RVA: 0x00BCD318 File Offset: 0x00BCB518
		public EAction? GetCurActionName()
		{
			ActionInfo curAction = this.CurAction;
			if (curAction != null)
			{
				return new EAction?(curAction.Name);
			}
			ActionInfo curSubAction = this.CurSubAction;
			if (curSubAction == null)
			{
				return null;
			}
			return new EAction?(curSubAction.Name);
		}

		// Token: 0x06029C74 RID: 171124 RVA: 0x00BCD358 File Offset: 0x00BCB558
		public void ExecuteActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions, FlowContext context, Action callback)
		{
			if (actions == null || actions.Count <= 0)
			{
				this.FinishActions();
				return;
			}
			this.Context = context;
			this.ActionInfoList.Clear();
			this.ActionInfoList.AddRange(actions);
			this.ActionInfoList.Reverse();
			List<ActionInfo> actionInfoList = this.ActionInfoList;
			if (actionInfoList[actionInfoList.Count - 1].Name != EAction.SetPlotMode)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.ZWY, "第一个行为不是SetPlotMode，自动添加。", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ActionInfoList.Add(this.DefaultSetPlotModeAction);
			}
			this.Context.HasAdjustCamera = this.CheckAdjustCameraAction();
			this.ActionsCallBack = callback;
			bool disableFlow = PlotModel.Instance.PlotGlobalConfig.DisableFlow;
			this.Context.IsBackground = disableFlow;
			this.NextAction();
		}

		// Token: 0x06029C75 RID: 171125 RVA: 0x00BCD430 File Offset: 0x00BCB630
		private void NextAction()
		{
			if (this.Context == null || this.Context.IsBreakdown || this.ActionInfoList.Count <= 0)
			{
				this.FinishActions();
				return;
			}
			List<ActionInfo> actionInfoList = this.ActionInfoList;
			ActionInfo actionInfo = actionInfoList[actionInfoList.Count - 1];
			this.ActionInfoList.RemoveAt(this.ActionInfoList.Count - 1);
			if (actionInfo.Disabled.GetValueOrDefault() || actionInfo.EdLocalDisabled.GetValueOrDefault())
			{
				this.NextAction();
				return;
			}
			if (this.ShouldResumeAtSetPlotMode(actionInfo))
			{
				this.ResumeFromSegmentSkip(actionInfo);
			}
			this.ExecuteAction(actionInfo);
		}

		// Token: 0x06029C76 RID: 171126 RVA: 0x00BCD4D4 File Offset: 0x00BCB6D4
		private void ExecuteAction(ActionInfo actionInfo)
		{
			FlowAction flowAction = FlowController.Instance.GetFlowAction(actionInfo.Name);
			if (flowAction == null)
			{
				this.NextAction();
				return;
			}
			this.CurAction = actionInfo;
			this.Context.CurActionId = actionInfo.ActionId.GetValueOrDefault();
			FlowActionBase action = flowAction.GetAction();
			this.CurActionInstance = action;
			action.Runner = this;
			action.Callback = new Action<bool, bool>(this.OnActionFinished);
			action.Execute(actionInfo, this.Context, flowAction.IsAutoFinish);
		}

		// Token: 0x06029C77 RID: 171127 RVA: 0x00BCD558 File Offset: 0x00BCB758
		private bool ShouldResumeAtSetPlotMode(ActionInfo actionInfo)
		{
			if (this.Context == null || !this.Context.IsSegmentSkipping || actionInfo.Name != EAction.SetPlotMode)
			{
				return false;
			}
			SetPlotMode setPlotMode = actionInfo.Params as SetPlotMode;
			return setPlotMode != null && setPlotMode.NoSkip.GetValueOrDefault();
		}

		// Token: 0x06029C78 RID: 171128 RVA: 0x00BCD5A8 File Offset: 0x00BCB7A8
		private unsafe void ResumeFromSegmentSkip(ActionInfo actionInfo)
		{
			if (this.Context == null)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "跳过剧情: 遇到不可跳过SetPlotMode，恢复正常播放";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Context.FormatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionId", actionInfo.ActionId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			bool isFadeSkip = this.Context.IsFadeSkip;
			TimerHandle skipTimer = this.SkipTimer;
			if (skipTimer != null)
			{
				skipTimer.Remove();
			}
			this.SkipTimer = null;
			this.Context.IsBackground = false;
			this.Context.IsSegmentSkipping = false;
			this.Context.IsFadeSkip = false;
			PlotController.Instance.HideUi(false, new long?(this.Context.FlowIncId));
			if (isFadeSkip)
			{
				PlotModel.Instance.IsFadeIn = false;
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "SkipPlot_" + this.Context.FormatId, null, new float?(0.25f));
			}
		}

		// Token: 0x06029C79 RID: 171129 RVA: 0x00BCD6C0 File Offset: 0x00BCB8C0
		private void OnActionFinished(bool isSuccess, bool isContinue)
		{
			if (this.CurActionInstance != null)
			{
				this.CurActionInstance.Recycle();
			}
			this.CurAction = null;
			this.Context.CurActionId = 0;
			this.CurActionInstance = null;
			if (isContinue)
			{
				this.NextAction();
			}
		}

		// Token: 0x06029C7A RID: 171130 RVA: 0x00BCD6F8 File Offset: 0x00BCB8F8
		public unsafe void FinishFlow(string reason, long? flowIncId = null, bool isServerEnd = false)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "FinishFlow";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("incId", flowIncId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (flowIncId != null && PlotModel.Instance.SetPendingPlotState(flowIncId.Value, true, true, isServerEnd))
			{
				return;
			}
			if (this.Context != null)
			{
				if (flowIncId != null)
				{
					long flowIncId2 = this.Context.FlowIncId;
					long? num = flowIncId;
					if (!(flowIncId2 == num.GetValueOrDefault() & num != null))
					{
						return;
					}
				}
				this.Context.IsBreakdown = true;
				this.Rollback(this.Context.RollbackRecord);
				this.BackgroundActions(reason, false, isServerEnd, false);
			}
		}

		// Token: 0x06029C7B RID: 171131 RVA: 0x00BCD7D8 File Offset: 0x00BCB9D8
		public void MarkClientError(string reason)
		{
			if (this.Context == null || this.Context.HasClientError)
			{
				return;
			}
			this.Context.HasClientError = true;
			string text = "剧情客户端资源异常，结束时上报ClientError";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			this.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06029C7C RID: 171132 RVA: 0x00BCD826 File Offset: 0x00BCBA26
		public void ForceFinishActionsByGm()
		{
			if (this.Context == null)
			{
				return;
			}
			if (this.Context.IsServerNotify)
			{
				FlowNetworks.RequestGmFinish();
			}
			this.Context.IsBreakdown = true;
			this.BackgroundActions("GM强制中断剧情", false, true, false);
		}

		// Token: 0x06029C7D RID: 171133 RVA: 0x00BCD860 File Offset: 0x00BCBA60
		private void FinishActions()
		{
			FlowActionBase curActionInstance = this.CurActionInstance;
			if (curActionInstance != null)
			{
				curActionInstance.Recycle();
			}
			this.CurActionInstance = null;
			FlowActionBase curSubActionInstance = this.CurSubActionInstance;
			if (curSubActionInstance != null)
			{
				curSubActionInstance.Recycle();
			}
			this.CurSubActionInstance = null;
			TimerHandle skipTimer = this.SkipTimer;
			if (skipTimer != null)
			{
				skipTimer.Remove();
			}
			this.SkipTimer = null;
			this.FlowSequence.Stop(true);
			this.ActionInfoList.Clear();
			this.CurAction = null;
			this.CurSubAction = null;
			PlotController instance = PlotController.Instance;
			FlowContext context = this.Context;
			instance.CloseAllUi((context != null) ? new long?(context.FlowIncId) : null);
			PlotController.Instance.EnsureFormationMemoryMaskBeforePlotEnd();
			this.CloseLoading(delegate
			{
				this.SubmitFlow();
				this.RunDeferredSeamlessFinalizeOnPlotEnd();
				this.Context = null;
				Action actionsCallBack = this.ActionsCallBack;
				this.ActionsCallBack = null;
				if (actionsCallBack == null)
				{
					return;
				}
				actionsCallBack();
			});
		}

		// Token: 0x06029C7E RID: 171134 RVA: 0x00BCD920 File Offset: 0x00BCBB20
		private void CloseLoading(Action callback)
		{
			if ((this.Context.IsFadeSkip && !PlotModel.Instance.IsFadeIn) || !PlotModel.Instance.PlotConfig.SkipHiddenBlackScreenAtEnd)
			{
				PlotModel.Instance.IsFadeIn = false;
				LevelLoadingController instance = LevelLoadingController.Instance;
				ELoadingReason reason = ELoadingReason.Common;
				string str = "SkipPlot_";
				FlowContext context = this.Context;
				instance.CloseLoading(reason, str + ((context != null) ? context.FormatId : null), callback, new float?(0.25f));
				return;
			}
			callback();
		}

		// Token: 0x06029C7F RID: 171135 RVA: 0x00BCD99C File Offset: 0x00BCBB9C
		private void SubmitFlow()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "剧情选项";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("选项", this.Context.OptionsCollection);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			KuroSdkReport.Instance.OnPlotFinish(this.Context);
			if (!this.Context.IsServerEnd && this.Context.IsServerNotify && !this.Context.IsAsync)
			{
				this.CacheFlowIncId[this.Context.FlowIncId] = new List<ActionRecord>(this.Context.RollbackRecord);
				FlowNetworks.RequestFlowEnd(this.Context.FlowIncId, this.Context.IsBackground || this.Context.HasSkipped, this.Context.OptionsCollection, new Action<long, ErrorCode?>(this.OnEndResponse), this.Context.HasClientError);
			}
		}

		// Token: 0x06029C80 RID: 171136 RVA: 0x00BCDA8C File Offset: 0x00BCBC8C
		private void OnEndResponse(long flowIncId, ErrorCode? errorCode)
		{
			if (!this.CacheFlowIncId.Remove(flowIncId))
			{
				this.LogError("ContextCache undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			ErrorCode? errorCode2 = errorCode;
			ErrorCode errorCode3 = ErrorCode.Success;
			if ((errorCode2.GetValueOrDefault() == errorCode3 & errorCode2 != null) || errorCode == null)
			{
				return;
			}
			if (errorCode.GetValueOrDefault() == ErrorCode.ErrFlowNotExist)
			{
				string text = "ErrFlowNotExist";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response flowIncId", flowIncId);
				this.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Rollback(this.CacheFlowIncId.GetValueOrDefault(flowIncId));
			FlowNetworks.RequestFlowRestart(flowIncId);
		}

		// Token: 0x06029C81 RID: 171137 RVA: 0x00BCDB29 File Offset: 0x00BCBD29
		public void AddActionNext(ActionInfo actionInfo)
		{
			if (this.Context == null)
			{
				return;
			}
			this.ActionInfoList.Add(actionInfo);
		}

		// Token: 0x06029C82 RID: 171138 RVA: 0x00BCDB40 File Offset: 0x00BCBD40
		public void ExecuteNextAction()
		{
			if (this.Context == null)
			{
				return;
			}
			this.NextAction();
		}

		// Token: 0x06029C83 RID: 171139 RVA: 0x00BCDB51 File Offset: 0x00BCBD51
		[NullableContext(2)]
		public void ExecuteSubActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions, Action<bool> callback = null, bool append = false)
		{
			this.SetupSubActions(actions, callback, append);
			if (this.CurSubActionInstance == null)
			{
				this.NextSubAction();
			}
		}

		// Token: 0x06029C84 RID: 171140 RVA: 0x00BCDB6C File Offset: 0x00BCBD6C
		[NullableContext(2)]
		private void SetupSubActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions, Action<bool> callback = null, bool append = false)
		{
			if (!append)
			{
				this.SubActionInfoList.Clear();
				this.SubActionsCallBack.Clear();
			}
			if (callback != null)
			{
				this.SubActionsCallBack.Add(callback);
			}
			if (actions != null)
			{
				foreach (ActionInfo element in actions)
				{
					this.SubActionInfoList.Push(element);
				}
			}
		}

		// Token: 0x06029C85 RID: 171141 RVA: 0x00BCDBEC File Offset: 0x00BCBDEC
		private void NextSubAction()
		{
			if (this.SubActionInfoList.Size <= 0)
			{
				this.FinishSubActions(true);
				return;
			}
			ActionInfo actionInfo = this.SubActionInfoList.Pop();
			FlowAction flowAction = FlowController.Instance.GetFlowAction(actionInfo.Name);
			if (flowAction == null)
			{
				this.NextSubAction();
				return;
			}
			this.CurSubAction = actionInfo;
			if (this.Context != null)
			{
				this.Context.CurSubActionId = actionInfo.ActionId.GetValueOrDefault();
			}
			FlowActionBase action = flowAction.GetAction();
			this.CurSubActionInstance = action;
			action.Runner = this;
			action.Callback = new Action<bool, bool>(this.OnSubActionFinished);
			action.Execute(actionInfo, this.Context, flowAction.IsAutoFinish);
		}

		// Token: 0x06029C86 RID: 171142 RVA: 0x00BCDC98 File Offset: 0x00BCBE98
		private void OnSubActionFinished(bool isSuccess, bool isContinue)
		{
			if (this.CurSubActionInstance != null)
			{
				this.CurSubActionInstance.Recycle();
			}
			this.CurSubAction = null;
			if (this.Context != null)
			{
				this.Context.CurSubActionId = 0;
			}
			this.CurSubActionInstance = null;
			if (isContinue)
			{
				this.NextSubAction();
				return;
			}
			this.FinishSubActions(false);
		}

		// Token: 0x06029C87 RID: 171143 RVA: 0x00BCDCEC File Offset: 0x00BCBEEC
		private void FinishSubActions(bool result = true)
		{
			if (this.SubActionsCallBack.Count == 0)
			{
				return;
			}
			List<Action<bool>> list = new List<Action<bool>>(this.SubActionsCallBack);
			this.SubActionsCallBack.Clear();
			foreach (Action<bool> action in list)
			{
				action(result);
			}
		}

		// Token: 0x06029C88 RID: 171144 RVA: 0x00BCDD5C File Offset: 0x00BCBF5C
		private void Rollback(List<ActionRecord> actionRecords)
		{
			FlowContext context = this.Context;
			if (((context != null) ? context.RollbackRecord : null) == null || this.Context.RollbackRecord.Count == 0)
			{
				return;
			}
			foreach (ActionRecord actionRecord in actionRecords)
			{
				FlowAction flowAction = FlowController.Instance.GetFlowAction(actionRecord.ActionInfo.Name);
				if (flowAction != null)
				{
					flowAction.GetAction().Rollback(actionRecord, this.Context);
				}
			}
		}

		// Token: 0x06029C89 RID: 171145 RVA: 0x00BCDDF8 File Offset: 0x00BCBFF8
		public void FinishShowCenterTextAction(Action callback)
		{
			bool flag = true;
			if (this.CurAction != null)
			{
				if (this.ActionInfoList.Count > 0)
				{
					List<ActionInfo> actionInfoList = this.ActionInfoList;
					ActionInfo actionInfo = actionInfoList[actionInfoList.Count - 1];
					if (actionInfo == null)
					{
						this.LogError("FinishShowCenterTextAction:nextAction丢失", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					if (actionInfo.Name == EAction.ShowCenterText)
					{
						flag = false;
					}
				}
			}
			else if (this.CurSubAction != null && this.SubActionInfoList.Size > 0)
			{
				ActionInfo front = this.SubActionInfoList.Front;
				if (front == null)
				{
					this.LogError("FinishShowCenterTextAction:nextAction丢失", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				if (front.Name == EAction.ShowCenterText)
				{
					flag = false;
				}
			}
			if (flag && UiManager.Instance.IsViewOpen(EUiViewName.PlotTransitionView))
			{
				UiManager.Instance.CloseView(EUiViewName.PlotTransitionView, delegate(bool _)
				{
					callback();
				});
				return;
			}
			callback();
		}

		// Token: 0x06029C8A RID: 171146 RVA: 0x00BCDEE0 File Offset: 0x00BCC0E0
		public unsafe void BackgroundActions(string reason, bool useFade = true, bool isServerEnd = false, bool stopAtNoSkipSetPlotMode = false)
		{
			if (this.Context == null)
			{
				return;
			}
			this.Context.IsServerEnd = isServerEnd;
			if (this.Context.IsBackground)
			{
				return;
			}
			if (!this.Context.CanSkip && SequenceModel.Instance.IsPlaying)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "当前状态不可跳过", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "跳过剧情";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原因", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", this.Context.FormatId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ServerNotify", this.Context.IsServerNotify);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ServerEnd", this.Context.IsServerEnd);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			TimerHandle skipTimer = this.SkipTimer;
			if (skipTimer != null)
			{
				skipTimer.Remove();
			}
			this.SkipTimer = null;
			this.Context.IsBackground = true;
			this.Context.IsSegmentSkipping = stopAtNoSkipSetPlotMode;
			this.Context.HasSkipped = true;
			this.Context.IsServerEnd = isServerEnd;
			this.Context.IsFadeSkip = useFade;
			if (useFade)
			{
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "SkipPlot_" + this.Context.FormatId, null, new object[]
				{
					0.25f
				});
				this.SkipTimer = TimerSystem.Instance.Delay(new TTimerAction(this.SkipPlot), 250f, null, null, true, 1f);
				return;
			}
			this.SkipPlot(0f);
		}

		// Token: 0x06029C8B RID: 171147 RVA: 0x00BCE0B4 File Offset: 0x00BCC2B4
		private void SkipPlot(float _)
		{
			TimerHandle skipTimer = this.SkipTimer;
			if (skipTimer != null)
			{
				skipTimer.Remove();
			}
			this.SkipTimer = null;
			if (this.Context == null)
			{
				return;
			}
			PlotController.Instance.PlotViewManager.StopPlotVoiceOnInterrupt(this.Context.FlowIncId);
			PlotController.Instance.ClearUi(new long?(this.Context.FlowIncId));
			PlotController.Instance.HideUi(true, new long?(this.Context.FlowIncId));
			if (this.Context.CurShowTalk == null)
			{
				if (this.CurAction != null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "跳过剧情: 行为";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionId", this.CurAction.ActionId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					FlowActionBase curActionInstance = this.CurActionInstance;
					if (curActionInstance == null)
					{
						return;
					}
					curActionInstance.InterruptExecute();
				}
				return;
			}
			if (this.FlowSequence.IsInit)
			{
				this.SkipSequenceTalk();
			}
			else
			{
				this.SkipNormalTalk();
			}
			FlowActionBase curSubActionInstance = this.CurSubActionInstance;
			if (curSubActionInstance == null)
			{
				return;
			}
			curSubActionInstance.InterruptExecute();
		}

		// Token: 0x06029C8C RID: 171148 RVA: 0x00BCE1BC File Offset: 0x00BCC3BC
		private void SkipSequenceTalk()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "跳过剧情: 演出对话", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.FlowSequence.Skip();
		}

		// Token: 0x06029C8D RID: 171149 RVA: 0x00BCE1F0 File Offset: 0x00BCC3F0
		private void SkipNormalTalk()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "跳过剧情: 普通对话", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.FlowShowTalk.Skip();
		}

		// Token: 0x06029C8E RID: 171150 RVA: 0x00BCE224 File Offset: 0x00BCC424
		public void HandleInputBeforePlay(EPlotLevel? level, bool seamless = false, bool disableSequenceInertiaKeeper = false)
		{
			EPlotLevel value = level.GetValueOrDefault();
			if (level == null)
			{
				value = EPlotLevel.LevelC;
				level = new EPlotLevel?(value);
			}
			if (level.GetValueOrDefault() != EPlotLevel.LevelD && level.GetValueOrDefault() != EPlotLevel.LevelE && level.GetValueOrDefault() != EPlotLevel.ControlEntity)
			{
				PlotModel.Instance.PlotConfig.DisableInput = true;
				EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, "Start Plot");
				InputDistributeController.Instance.RefreshInputTag();
				if (!disableSequenceInertiaKeeper)
				{
					FlowContext context = this.Context;
					if (((context != null && context.SeamlessPlot) || seamless) && level.GetValueOrDefault() != EPlotLevel.LevelC)
					{
						PlotSequenceInertiaKeeper.Instance.Start("FlowActionRunner.HandleInputBeforePlay");
						return;
					}
				}
			}
			else
			{
				PlotModel.Instance.PlotConfig.DisableInput = false;
			}
		}

		// Token: 0x06029C8F RID: 171151 RVA: 0x00BCE2DC File Offset: 0x00BCC4DC
		private bool CheckAdjustCameraAction()
		{
			if (this.ActionInfoList.Count == 0)
			{
				return false;
			}
			using (List<ActionInfo>.Enumerator enumerator = this.ActionInfoList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Name == EAction.AdjustPlayerCamera)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06029C90 RID: 171152 RVA: 0x00BCE34C File Offset: 0x00BCC54C
		[NullableContext(2)]
		public int GetOptionToSelect(ITalkItem inTalkItem = null)
		{
			int curShowTalkActionId = this.Context.CurShowTalkActionId;
			ITalkItem talkItem = inTalkItem;
			if (talkItem == null)
			{
				foreach (ITalkItem talkItem2 in this.Context.CurShowTalk.TalkItems)
				{
					if (talkItem2.Id == this.Context.CurTalkId)
					{
						talkItem = talkItem2;
						break;
					}
				}
			}
			if (((talkItem != null) ? talkItem.Options : null) == null)
			{
				return 0;
			}
			Dictionary<int, int> dictionary;
			int num;
			if (!this.Context.OptionsHistory.TryGetValue(curShowTalkActionId, out dictionary) || !dictionary.TryGetValue(talkItem.Id, out num))
			{
				return 0;
			}
			int num2 = num + 1;
			if (num2 >= talkItem.Options.Count)
			{
				return 0;
			}
			return num2;
		}

		// Token: 0x06029C91 RID: 171153 RVA: 0x00BCE420 File Offset: 0x00BCC620
		public int GetHistoryOptionSelect(int talkId)
		{
			FlowContext context = this.Context;
			if (((context != null) ? context.CurShowTalk : null) == null)
			{
				return -1;
			}
			return this.Context.OptionsHistory[this.Context.CurShowTalkActionId].GetValueOrDefault(talkId, -1);
		}

		// Token: 0x06029C92 RID: 171154 RVA: 0x00BCE45C File Offset: 0x00BCC65C
		public void RecordOption(int talkId, int optionIndex)
		{
			FlowContext context = this.Context;
			if (((context != null) ? context.CurShowTalk : null) == null)
			{
				return;
			}
			this.Context.OptionsHistory[this.Context.CurShowTalkActionId][talkId] = optionIndex;
			List<ValueTuple<int, List<ValueTuple<int, int>>>> optionsCollection = this.Context.OptionsCollection;
			optionsCollection[optionsCollection.Count - 1].Item2.Add(new ValueTuple<int, int>(talkId, optionIndex));
			ITalkItem talkItem = null;
			foreach (ITalkItem talkItem2 in this.Context.CurShowTalk.TalkItems)
			{
				if (talkItem2.Id == talkId)
				{
					talkItem = talkItem2;
					break;
				}
			}
			if (talkItem != null)
			{
				TalkRecord item = new TalkRecord
				{
					TalkItem = talkItem,
					IsOption = true,
					OptionIndex = new int?(optionIndex)
				};
				FlowContext context2 = this.Context;
				if (context2 == null)
				{
					return;
				}
				context2.TalkHistory.Add(item);
			}
		}

		// Token: 0x06029C93 RID: 171155 RVA: 0x00BCE55C File Offset: 0x00BCC75C
		public void RecordTalkItem(ITalkItem talkItem)
		{
			ETalkItemType? type = talkItem.Type;
			if (type != null)
			{
				ETalkItemType? etalkItemType = type;
				ETalkItemType etalkItemType2 = ETalkItemType.Talk;
				if (!(etalkItemType.GetValueOrDefault() == etalkItemType2 & etalkItemType != null))
				{
					return;
				}
			}
			if (this.FlowSequence.IsCurrentSubtitle(talkItem.Id))
			{
				return;
			}
			string tidTalk = talkItem.TidTalk;
			if (tidTalk == null)
			{
				return;
			}
			string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(tidTalk);
			if (flowConfigLocalText == null || StringUtils.IsBlank(flowConfigLocalText))
			{
				return;
			}
			TalkRecord item = new TalkRecord
			{
				TalkItem = talkItem,
				IsOption = false
			};
			FlowContext context = this.Context;
			if (context == null)
			{
				return;
			}
			context.TalkHistory.Add(item);
		}

		// Token: 0x06029C94 RID: 171156 RVA: 0x00BCE5F6 File Offset: 0x00BCC7F6
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<TalkRecord> GetTalkHistory()
		{
			FlowContext context = this.Context;
			if (context == null)
			{
				return null;
			}
			return context.TalkHistory;
		}

		// Token: 0x06029C95 RID: 171157 RVA: 0x00BCE60C File Offset: 0x00BCC80C
		public bool CheckCanSkipTmp()
		{
			if (this.ActionInfoList == null)
			{
				return false;
			}
			using (List<ActionInfo>.Enumerator enumerator = this.ActionInfoList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Name == EAction.PlaySequenceData)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06029C96 RID: 171158 RVA: 0x00BCE674 File Offset: 0x00BCC874
		public void JumpTalk(int talkId)
		{
			if (this.Context.CurShowTalk == null)
			{
				return;
			}
			if (this.FlowSequence.IsInit)
			{
				this.FlowSequence.OnJumpTalk(talkId);
				return;
			}
			this.FlowShowTalk.SwitchTalkItem(talkId);
		}

		// Token: 0x06029C97 RID: 171159 RVA: 0x00BCE6AA File Offset: 0x00BCC8AA
		public void FinishTalk()
		{
			if (this.Context.CurShowTalk == null)
			{
				return;
			}
			if (this.FlowSequence.IsInit)
			{
				this.FlowSequence.OnFinishTalk();
				return;
			}
			this.FlowShowTalk.FinishShowTalk();
		}

		// Token: 0x06029C98 RID: 171160 RVA: 0x00BCE6E0 File Offset: 0x00BCC8E0
		public void TriggerCountDownSkip(bool enable)
		{
			if (enable)
			{
				TimerHandle countDowner = this.CountDowner;
				if (countDowner != null)
				{
					countDowner.Remove();
				}
				this.CountDowner = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.BackgroundActions("D级剧情被别的界面打断", false, false, false);
					this.CountDowner = null;
				}, 20000f, null, null, true, 1f);
				return;
			}
			TimerHandle countDowner2 = this.CountDowner;
			if (countDowner2 != null)
			{
				countDowner2.Remove();
			}
			this.CountDowner = null;
		}

		// Token: 0x06029C99 RID: 171161 RVA: 0x00BCE748 File Offset: 0x00BCC948
		public bool HasFlow(string flowListName, int flowId, int flowStateId)
		{
			if (this.Context != null && this.Context.FlowListName == flowListName && this.Context.FlowId == flowId && this.Context.FlowStateId == flowStateId)
			{
				return true;
			}
			foreach (PlotInfo plotInfo in PlotModel.Instance.PlotPendingList)
			{
				if (plotInfo.FlowListName == flowListName && plotInfo.FlowId == flowId)
				{
					int? stateId = plotInfo.StateId;
					if (stateId.GetValueOrDefault() == flowStateId & stateId != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06029C9A RID: 171162 RVA: 0x00BCE810 File Offset: 0x00BCCA10
		[NullableContext(2)]
		public ActionInfo GetNextAction(bool checkSubAction)
		{
			if (this.Context == null)
			{
				return null;
			}
			if (checkSubAction && this.SubActionInfoList.Size > 0)
			{
				return this.SubActionInfoList.Front;
			}
			if (this.ActionInfoList.Count <= 0)
			{
				return null;
			}
			List<ActionInfo> actionInfoList = this.ActionInfoList;
			return actionInfoList[actionInfoList.Count - 1];
		}

		// Token: 0x06029C9B RID: 171163 RVA: 0x00BCE867 File Offset: 0x00BCCA67
		public void LogError(string text, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (this.Context == null)
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.FZX, text, pairs);
				return;
			}
			FlowContext context = this.Context;
			if (context == null)
			{
				return;
			}
			context.LogError(text, pairs);
		}

		// Token: 0x06029C9C RID: 171164 RVA: 0x00BCE894 File Offset: 0x00BCCA94
		public long GetFlowIncId()
		{
			return this.Context.FlowIncId;
		}

		// Token: 0x06029C9D RID: 171165 RVA: 0x00BCE8A1 File Offset: 0x00BCCAA1
		public void RequestPosition(IVector location, IRotator rotation)
		{
			FlowNetworks.RequestSeqEndPosition(this.Context, location, rotation);
		}

		// Token: 0x06029C9E RID: 171166 RVA: 0x00BCE8B0 File Offset: 0x00BCCAB0
		public bool CheckViewControlBeginForC()
		{
			for (int i = this.ActionInfoList.Count - 1; i > 0; i--)
			{
				ActionInfo actionInfo = this.ActionInfoList[i];
				if (actionInfo.Name == EAction.ShowTalk)
				{
					return true;
				}
				if (actionInfo.Name == EAction.BeginFlowTemplate)
				{
					return ((BeginFlowTemplate)actionInfo.Params).UseFreeCamera.GetValueOrDefault();
				}
			}
			return true;
		}

		// Token: 0x06029C9F RID: 171167 RVA: 0x00BCE918 File Offset: 0x00BCCB18
		public List<ActionParams> GetNameAction(EAction actionName)
		{
			List<ActionParams> list = new List<ActionParams>();
			foreach (ActionInfo actionInfo in this.ActionInfoList)
			{
				if (actionInfo.Name == actionName)
				{
					list.Add(actionInfo.Params);
				}
			}
			FlowContext context = this.Context;
			if (((context != null) ? context.CurShowTalk : null) != null)
			{
				list.Add(this.Context.CurShowTalk);
			}
			return list;
		}

		// Token: 0x06029CA0 RID: 171168 RVA: 0x00BCE9A8 File Offset: 0x00BCCBA8
		public string GetFlowName()
		{
			FlowContext context = this.Context;
			return ((context != null) ? context.FormatId : null) ?? "";
		}

		// Token: 0x06029CA1 RID: 171169 RVA: 0x00BCE9C8 File Offset: 0x00BCCBC8
		public bool HasPendingShowTalkOrSequenceDataAction()
		{
			for (int i = this.ActionInfoList.Count - 1; i >= 0; i--)
			{
				ActionInfo actionInfo = this.ActionInfoList[i];
				if (actionInfo.Name == EAction.ShowTalk || actionInfo.Name == EAction.PlaySequenceData || actionInfo.Name == EAction.PlayMovie)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06029CA2 RID: 171170 RVA: 0x00BCEA1B File Offset: 0x00BCCC1B
		public bool CollectSeamlessFinalize(ESeamlessFinalizeFlag flag)
		{
			if (this.Context == null || !this.Context.SeamlessPlot)
			{
				return false;
			}
			if (this.Context.IsBackground)
			{
				return false;
			}
			if (!this.HasPendingShowTalkOrSequenceDataAction())
			{
				return false;
			}
			this.Context.AddDeferredFinalizeFlag(flag);
			return true;
		}

		// Token: 0x06029CA3 RID: 171171 RVA: 0x00BCEA5C File Offset: 0x00BCCC5C
		public void RunDeferredSeamlessFinalizeOnPlotEnd()
		{
			if (this.Context == null)
			{
				return;
			}
			ESeamlessFinalizeFlag eseamlessFinalizeFlag = this.Context.ConsumeDeferredFinalizeFlags();
			if (eseamlessFinalizeFlag == ESeamlessFinalizeFlag.None)
			{
				return;
			}
			if (eseamlessFinalizeFlag.HasFlag(ESeamlessFinalizeFlag.ExitSequenceCamera))
			{
				CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
			}
			if (eseamlessFinalizeFlag.HasFlag(ESeamlessFinalizeFlag.ExitMovieMode))
			{
				MovieModeController.Instance.ExitMovieMode(new ExitMovieModeParams
				{
					BlendTime = 0f
				}, null);
				SequenceModel.Instance.EnablingUiBlend = false;
			}
			if (eseamlessFinalizeFlag.HasFlag(ESeamlessFinalizeFlag.UiRemoveAspectView))
			{
				PlotController.Instance.RemoveAspectTransformView();
			}
			if (eseamlessFinalizeFlag.HasFlag(ESeamlessFinalizeFlag.TemplateResetCamera))
			{
				PlotModel.Instance.SwitchCameraMode(EPlotCameraMode.Main);
				CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetArmLengthAndRotation(PlotModel.Instance.PlotGlobalConfig.PlotTemplateCameraExitRotation.ToUeRotator());
			}
		}

		// Token: 0x04016C9D RID: 93341
		public const int OPTION_SKIPPING_SELECTED = 0;

		// Token: 0x04016C9E RID: 93342
		public const float SKIP_FADE_TIME = 0.25f;

		// Token: 0x04016C9F RID: 93343
		public const int HANG_COUNT_DOWN = 20000;

		// Token: 0x04016CA0 RID: 93344
		[Nullable(2)]
		private FlowContext Context;

		// Token: 0x04016CA1 RID: 93345
		private readonly Dictionary<long, List<ActionRecord>> CacheFlowIncId = new Dictionary<long, List<ActionRecord>>();

		// Token: 0x04016CA2 RID: 93346
		private readonly List<ActionInfo> ActionInfoList = new List<ActionInfo>();

		// Token: 0x04016CA3 RID: 93347
		private readonly Queue<ActionInfo> SubActionInfoList = new Queue<ActionInfo>(4);

		// Token: 0x04016CA4 RID: 93348
		[Nullable(2)]
		private ActionInfo CurAction;

		// Token: 0x04016CA5 RID: 93349
		[Nullable(2)]
		private FlowActionBase CurActionInstance;

		// Token: 0x04016CA6 RID: 93350
		[Nullable(2)]
		private ActionInfo CurSubAction;

		// Token: 0x04016CA7 RID: 93351
		[Nullable(2)]
		private FlowActionBase CurSubActionInstance;

		// Token: 0x04016CA8 RID: 93352
		public readonly FlowSequence FlowSequence = new FlowSequence();

		// Token: 0x04016CA9 RID: 93353
		public readonly FlowShowTalk FlowShowTalk = new FlowShowTalk();

		// Token: 0x04016CAA RID: 93354
		[Nullable(2)]
		private Action ActionsCallBack;

		// Token: 0x04016CAB RID: 93355
		private readonly List<Action<bool>> SubActionsCallBack = new List<Action<bool>>();

		// Token: 0x04016CAC RID: 93356
		[Nullable(2)]
		private TimerHandle SkipTimer;

		// Token: 0x04016CAD RID: 93357
		[Nullable(2)]
		private TimerHandle CountDowner;

		// Token: 0x04016CAE RID: 93358
		private readonly ActionInfo DefaultSetPlotModeAction = new ActionInfo
		{
			Name = EAction.SetPlotMode,
			Params = new SetPlotMode
			{
				Mode = EPlotLevel.LevelC.ToEnumString(),
				IsSwitchMainRole = new bool?(false),
				UseFlowCamera = new bool?(true)
			},
			ActionGuid = ""
		};
	}
}
