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
	// Token: 0x02005092 RID: 20626
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionRunner : ControllerAssistantBase
	{
		// Token: 0x06034D73 RID: 216435 RVA: 0x00C7FBE0 File Offset: 0x00C7DDE0
		protected override void OnDestroy()
		{
			this.Context = null;
			this.CurAction = null;
			this.CurActionInstance = null;
			this.CurSubAction = null;
			this.CurSubActionInstance = null;
		}

		// Token: 0x06034D74 RID: 216436 RVA: 0x00C7FC05 File Offset: 0x00C7DE05
		public void EnableSkip(bool enable)
		{
			if (this.Context == null)
			{
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.EnableSkipPlot, enable);
			this.Context.CanSkip = enable;
		}

		// Token: 0x06034D75 RID: 216437 RVA: 0x00C7FC2D File Offset: 0x00C7DE2D
		public bool IsSkipEnabled()
		{
			FlowContext context = this.Context;
			return context != null && context.CanSkip;
		}

		// Token: 0x06034D76 RID: 216438 RVA: 0x00C7FC40 File Offset: 0x00C7DE40
		[NullableContext(2)]
		public FlowContext GetCurrentContext()
		{
			return this.Context;
		}

		// Token: 0x06034D77 RID: 216439 RVA: 0x00C7FC48 File Offset: 0x00C7DE48
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

		// Token: 0x06034D78 RID: 216440 RVA: 0x00C7FCCC File Offset: 0x00C7DECC
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

		// Token: 0x06034D79 RID: 216441 RVA: 0x00C7FD4E File Offset: 0x00C7DF4E
		public bool IsInShowTalk()
		{
			return this.Context != null && this.Context.CurShowTalk != null;
		}

		// Token: 0x06034D7A RID: 216442 RVA: 0x00C7FD68 File Offset: 0x00C7DF68
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

		// Token: 0x06034D7B RID: 216443 RVA: 0x00C7FDA8 File Offset: 0x00C7DFA8
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

		// Token: 0x06034D7C RID: 216444 RVA: 0x00C7FE80 File Offset: 0x00C7E080
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

		// Token: 0x06034D7D RID: 216445 RVA: 0x00C7FF24 File Offset: 0x00C7E124
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

		// Token: 0x06034D7E RID: 216446 RVA: 0x00C7FFA8 File Offset: 0x00C7E1A8
		private bool ShouldResumeAtSetPlotMode(ActionInfo actionInfo)
		{
			if (this.Context == null || !this.Context.IsSegmentSkipping || actionInfo.Name != EAction.SetPlotMode)
			{
				return false;
			}
			SetPlotMode setPlotMode = actionInfo.Params as SetPlotMode;
			return setPlotMode != null && setPlotMode.NoSkip.GetValueOrDefault();
		}

		// Token: 0x06034D7F RID: 216447 RVA: 0x00C7FFF8 File Offset: 0x00C7E1F8
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

		// Token: 0x06034D80 RID: 216448 RVA: 0x00C80110 File Offset: 0x00C7E310
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

		// Token: 0x06034D81 RID: 216449 RVA: 0x00C80148 File Offset: 0x00C7E348
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

		// Token: 0x06034D82 RID: 216450 RVA: 0x00C80228 File Offset: 0x00C7E428
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

		// Token: 0x06034D83 RID: 216451 RVA: 0x00C80276 File Offset: 0x00C7E476
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

		// Token: 0x06034D84 RID: 216452 RVA: 0x00C802B0 File Offset: 0x00C7E4B0
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

		// Token: 0x06034D85 RID: 216453 RVA: 0x00C80370 File Offset: 0x00C7E570
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

		// Token: 0x06034D86 RID: 216454 RVA: 0x00C803EC File Offset: 0x00C7E5EC
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

		// Token: 0x06034D87 RID: 216455 RVA: 0x00C804DC File Offset: 0x00C7E6DC
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

		// Token: 0x06034D88 RID: 216456 RVA: 0x00C80579 File Offset: 0x00C7E779
		public void AddActionNext(ActionInfo actionInfo)
		{
			if (this.Context == null)
			{
				return;
			}
			this.ActionInfoList.Add(actionInfo);
		}

		// Token: 0x06034D89 RID: 216457 RVA: 0x00C80590 File Offset: 0x00C7E790
		public void ExecuteNextAction()
		{
			if (this.Context == null)
			{
				return;
			}
			this.NextAction();
		}

		// Token: 0x06034D8A RID: 216458 RVA: 0x00C805A1 File Offset: 0x00C7E7A1
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

		// Token: 0x06034D8B RID: 216459 RVA: 0x00C805BC File Offset: 0x00C7E7BC
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

		// Token: 0x06034D8C RID: 216460 RVA: 0x00C8063C File Offset: 0x00C7E83C
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

		// Token: 0x06034D8D RID: 216461 RVA: 0x00C806E8 File Offset: 0x00C7E8E8
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

		// Token: 0x06034D8E RID: 216462 RVA: 0x00C8073C File Offset: 0x00C7E93C
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

		// Token: 0x06034D8F RID: 216463 RVA: 0x00C807AC File Offset: 0x00C7E9AC
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

		// Token: 0x06034D90 RID: 216464 RVA: 0x00C80848 File Offset: 0x00C7EA48
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

		// Token: 0x06034D91 RID: 216465 RVA: 0x00C80930 File Offset: 0x00C7EB30
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

		// Token: 0x06034D92 RID: 216466 RVA: 0x00C80B04 File Offset: 0x00C7ED04
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

		// Token: 0x06034D93 RID: 216467 RVA: 0x00C80BF0 File Offset: 0x00C7EDF0
		private void SkipSequenceTalk()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "跳过剧情: 演出对话", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.FlowSequence.Skip();
		}

		// Token: 0x06034D94 RID: 216468 RVA: 0x00C80C24 File Offset: 0x00C7EE24
		private void SkipNormalTalk()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "跳过剧情: 普通对话", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.FlowShowTalk.Skip();
		}

		// Token: 0x06034D95 RID: 216469 RVA: 0x00C80C58 File Offset: 0x00C7EE58
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

		// Token: 0x06034D96 RID: 216470 RVA: 0x00C80D10 File Offset: 0x00C7EF10
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

		// Token: 0x06034D97 RID: 216471 RVA: 0x00C80D80 File Offset: 0x00C7EF80
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

		// Token: 0x06034D98 RID: 216472 RVA: 0x00C80E54 File Offset: 0x00C7F054
		public int GetHistoryOptionSelect(int talkId)
		{
			FlowContext context = this.Context;
			if (((context != null) ? context.CurShowTalk : null) == null)
			{
				return -1;
			}
			return this.Context.OptionsHistory[this.Context.CurShowTalkActionId].GetValueOrDefault(talkId, -1);
		}

		// Token: 0x06034D99 RID: 216473 RVA: 0x00C80E90 File Offset: 0x00C7F090
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

		// Token: 0x06034D9A RID: 216474 RVA: 0x00C80F90 File Offset: 0x00C7F190
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

		// Token: 0x06034D9B RID: 216475 RVA: 0x00C8102A File Offset: 0x00C7F22A
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

		// Token: 0x06034D9C RID: 216476 RVA: 0x00C81040 File Offset: 0x00C7F240
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

		// Token: 0x06034D9D RID: 216477 RVA: 0x00C810A8 File Offset: 0x00C7F2A8
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

		// Token: 0x06034D9E RID: 216478 RVA: 0x00C810DE File Offset: 0x00C7F2DE
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

		// Token: 0x06034D9F RID: 216479 RVA: 0x00C81114 File Offset: 0x00C7F314
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

		// Token: 0x06034DA0 RID: 216480 RVA: 0x00C8117C File Offset: 0x00C7F37C
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

		// Token: 0x06034DA1 RID: 216481 RVA: 0x00C81244 File Offset: 0x00C7F444
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

		// Token: 0x06034DA2 RID: 216482 RVA: 0x00C8129B File Offset: 0x00C7F49B
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

		// Token: 0x06034DA3 RID: 216483 RVA: 0x00C812C8 File Offset: 0x00C7F4C8
		public long GetFlowIncId()
		{
			return this.Context.FlowIncId;
		}

		// Token: 0x06034DA4 RID: 216484 RVA: 0x00C812D5 File Offset: 0x00C7F4D5
		public void RequestPosition(IVector location, IRotator rotation)
		{
			FlowNetworks.RequestSeqEndPosition(this.Context, location, rotation);
		}

		// Token: 0x06034DA5 RID: 216485 RVA: 0x00C812E4 File Offset: 0x00C7F4E4
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

		// Token: 0x06034DA6 RID: 216486 RVA: 0x00C8134C File Offset: 0x00C7F54C
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

		// Token: 0x06034DA7 RID: 216487 RVA: 0x00C813DC File Offset: 0x00C7F5DC
		public string GetFlowName()
		{
			FlowContext context = this.Context;
			return ((context != null) ? context.FormatId : null) ?? "";
		}

		// Token: 0x06034DA8 RID: 216488 RVA: 0x00C813FC File Offset: 0x00C7F5FC
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

		// Token: 0x06034DA9 RID: 216489 RVA: 0x00C8144F File Offset: 0x00C7F64F
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

		// Token: 0x06034DAA RID: 216490 RVA: 0x00C81490 File Offset: 0x00C7F690
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

		// Token: 0x0401C26E RID: 115310
		public const int OPTION_SKIPPING_SELECTED = 0;

		// Token: 0x0401C26F RID: 115311
		public const float SKIP_FADE_TIME = 0.25f;

		// Token: 0x0401C270 RID: 115312
		public const int HANG_COUNT_DOWN = 20000;

		// Token: 0x0401C271 RID: 115313
		[Nullable(2)]
		private FlowContext Context;

		// Token: 0x0401C272 RID: 115314
		private readonly Dictionary<long, List<ActionRecord>> CacheFlowIncId = new Dictionary<long, List<ActionRecord>>();

		// Token: 0x0401C273 RID: 115315
		private readonly List<ActionInfo> ActionInfoList = new List<ActionInfo>();

		// Token: 0x0401C274 RID: 115316
		private readonly Queue<ActionInfo> SubActionInfoList = new Queue<ActionInfo>(4);

		// Token: 0x0401C275 RID: 115317
		[Nullable(2)]
		private ActionInfo CurAction;

		// Token: 0x0401C276 RID: 115318
		[Nullable(2)]
		private FlowActionBase CurActionInstance;

		// Token: 0x0401C277 RID: 115319
		[Nullable(2)]
		private ActionInfo CurSubAction;

		// Token: 0x0401C278 RID: 115320
		[Nullable(2)]
		private FlowActionBase CurSubActionInstance;

		// Token: 0x0401C279 RID: 115321
		public readonly FlowSequence FlowSequence = new FlowSequence();

		// Token: 0x0401C27A RID: 115322
		public readonly FlowShowTalk FlowShowTalk = new FlowShowTalk();

		// Token: 0x0401C27B RID: 115323
		[Nullable(2)]
		private Action ActionsCallBack;

		// Token: 0x0401C27C RID: 115324
		private readonly List<Action<bool>> SubActionsCallBack = new List<Action<bool>>();

		// Token: 0x0401C27D RID: 115325
		[Nullable(2)]
		private TimerHandle SkipTimer;

		// Token: 0x0401C27E RID: 115326
		[Nullable(2)]
		private TimerHandle CountDowner;

		// Token: 0x0401C27F RID: 115327
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
