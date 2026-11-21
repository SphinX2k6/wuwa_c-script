using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x0200122D RID: 4653
[NullableContext(1)]
[Nullable(0)]
public class QuestFailedBehaviorNode : BehaviorNodeBase, IStaticVariableResetter
{
	// Token: 0x0600B92D RID: 47405 RVA: 0x0036B33F File Offset: 0x0036953F
	public QuestFailedBehaviorNode(int NodeId) : base(NodeId)
	{
	}

	// Token: 0x0600B92E RID: 47406 RVA: 0x0036B353 File Offset: 0x00369553
	static QuestFailedBehaviorNode()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestFailedBehaviorNode.CreateStaticDefaultValue), new Action(QuestFailedBehaviorNode.ResetStaticDefaultValue));
	}

	// Token: 0x17001279 RID: 4729
	// (get) Token: 0x0600B92F RID: 47407 RVA: 0x0036B372 File Offset: 0x00369572
	public override EBtNode NodeType
	{
		get
		{
			return EBtNode.QuestFailed;
		}
	}

	// Token: 0x1700127A RID: 4730
	// (get) Token: 0x0600B930 RID: 47408 RVA: 0x0036B375 File Offset: 0x00369575
	public bool? NeedSecondaryConfirm
	{
		get
		{
			return this.NeedConfirm;
		}
	}

	// Token: 0x1700127B RID: 4731
	// (get) Token: 0x0600B931 RID: 47409 RVA: 0x0036B37D File Offset: 0x0036957D
	public ETeleportTransitionType? NowTransitionType
	{
		get
		{
			return this.TransitionType;
		}
	}

	// Token: 0x1700127C RID: 4732
	// (get) Token: 0x0600B932 RID: 47410 RVA: 0x0036B388 File Offset: 0x00369588
	public RangeFailedEffectHandler RangeFailedEffectChain
	{
		get
		{
			if (QuestFailedBehaviorNode.RangeFailedEffectChainInternal == null)
			{
				RangeFailedEffectRangeEntitiesHandler rangeFailedEffectRangeEntitiesHandler = new RangeFailedEffectRangeEntitiesHandler();
				RangeFailedEffectFixedPointHandler next = new RangeFailedEffectFixedPointHandler();
				rangeFailedEffectRangeEntitiesHandler.SetNext(next);
				QuestFailedBehaviorNode.RangeFailedEffectChainInternal = rangeFailedEffectRangeEntitiesHandler;
			}
			return QuestFailedBehaviorNode.RangeFailedEffectChainInternal;
		}
	}

	// Token: 0x0600B933 RID: 47411 RVA: 0x0036B3BC File Offset: 0x003695BC
	protected override bool OnCreate(IBtNode config)
	{
		if (config == null || config.Type != EBtNode.QuestFailed)
		{
			return false;
		}
		IQuestFailedCondition failedCondition = (config as IQuestFailedBtNode).FailedCondition;
		bool? needConfirm;
		if (failedCondition == null)
		{
			needConfirm = null;
		}
		else
		{
			IFailedTeleport failedTeleport = failedCondition.FailedTeleport;
			needConfirm = ((failedTeleport != null) ? new bool?(failedTeleport.IsConfirm) : null);
		}
		this.NeedConfirm = needConfirm;
		IQuestFailedCondition failedCondition2 = (config as IQuestFailedBtNode).FailedCondition;
		ETeleportTransitionType? transitionType;
		if (failedCondition2 == null)
		{
			transitionType = null;
		}
		else
		{
			IFailedTeleport failedTeleport2 = failedCondition2.FailedTeleport;
			if (failedTeleport2 == null)
			{
				transitionType = null;
			}
			else
			{
				ITeleportTransitionType transitionOption = failedTeleport2.TransitionOption;
				transitionType = ((transitionOption != null) ? new ETeleportTransitionType?(transitionOption.Type) : null);
			}
		}
		this.TransitionType = transitionType;
		IQuestFailedCondition failedCondition3 = (config as IQuestFailedBtNode).FailedCondition;
		ITimerUiConfig timerUiConfig;
		if (failedCondition3 == null)
		{
			timerUiConfig = null;
		}
		else
		{
			ITimerConfig timer = failedCondition3.Timer;
			timerUiConfig = ((timer != null) ? timer.UiConfig : null);
		}
		this.TimerUiConfig = timerUiConfig;
		IQuestFailedCondition failedCondition4 = (config as IQuestFailedBtNode).FailedCondition;
		IRangeLimitingCondition rangeLimitingCondition = (failedCondition4 != null) ? failedCondition4.RangeLimiting : null;
		if (rangeLimitingCondition != null)
		{
			this.RangeFailedParameterContext = new RangeFailedParameterContext(rangeLimitingCondition);
		}
		IQuestFailedCondition failedCondition5 = (config as IQuestFailedBtNode).FailedCondition;
		bool? flag;
		if (failedCondition5 == null)
		{
			flag = null;
		}
		else
		{
			IRangeLimitingCondition rangeLimiting = failedCondition5.RangeLimiting;
			flag = ((rangeLimiting != null) ? rangeLimiting.RequiresSecondConfirmation : null);
		}
		bool? flag2 = flag;
		this.NeedRequiresSecondConfirmation = flag2.GetValueOrDefault();
		IQuestFailedCondition failedCondition6 = (config as IQuestFailedBtNode).FailedCondition;
		if (((failedCondition6 != null) ? failedCondition6.SneakPlayCondition : null) != null)
		{
			this.AddSneakEvent();
		}
		IQuestFailedCondition failedCondition7 = (config as IQuestFailedBtNode).FailedCondition;
		bool flag3;
		if (failedCondition7 == null)
		{
			flag3 = (null != null);
		}
		else
		{
			IQuestFailedConditionEntityAlert entityAlert = failedCondition7.EntityAlert;
			flag3 = (((entityAlert != null) ? entityAlert.EntityIds : null) != null);
		}
		if (flag3 && (config as IQuestFailedBtNode).FailedCondition.EntityAlert.EntityIds.Count > 0)
		{
			this.EntitiesMonitorStalkAlert = (config as IQuestFailedBtNode).FailedCondition.EntityAlert.EntityIds;
			this.AddStalkEvent();
		}
		IQuestFailedCondition failedCondition8 = (config as IQuestFailedBtNode).FailedCondition;
		this.CanGiveUp = ((failedCondition8 != null) ? failedCondition8.CanGiveUp : null);
		IQuestFailedCondition failedCondition9 = (config as IQuestFailedBtNode).FailedCondition;
		this.GiveUpText = ((failedCondition9 != null) ? failedCondition9.TidGiveUpText : null);
		return true;
	}

	// Token: 0x0600B934 RID: 47412 RVA: 0x0036B5BD File Offset: 0x003697BD
	protected override void OnNodeActive()
	{
		if (this.RangeFailedParameterContext != null)
		{
			this.RangeFailedEffectChain.Handle(this.RangeFailedParameterContext);
		}
	}

	// Token: 0x0600B935 RID: 47413 RVA: 0x0036B5DC File Offset: 0x003697DC
	protected override void OnNodeDeActive(bool success)
	{
		this.StopFailRangeEffect();
		if (this.RegisterSneakyNotify)
		{
			this.AddOrRemoveSneakBuff(false);
		}
		this.RemoveSneakEvent();
		this.RemoveStalkEvent();
		if (this.RangeFailedParameterContext != null)
		{
			this.RangeFailedParameterContext.Clear();
			this.RangeFailedParameterContext = null;
		}
		base.OnNodeDeActive(success);
		if (QuestNewController.Instance.QuestRangeFailWarningTreeId == base.TreeIncId)
		{
			QuestNewController.Instance.HideCancelRangeFailWaringEffect();
		}
	}

	// Token: 0x0600B936 RID: 47414 RVA: 0x0036B648 File Offset: 0x00369848
	private void AddSneakEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		this.AddOrRemoveSneakBuff(true);
		this.RegisterSneakyNotify = true;
		Net.Instance.Register(ENotifyMessageId.SneakNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SneakNotify sneakNotify = (SneakNotify)msg;
			long num = MathUtils.Instance.LongToBigInt(sneakNotify.EndTime);
			this.SneakState = new bool?(num != 0L);
			EventSystem.Instance.Emit<bool, long>(EEventName.OnSneakFoundChange, this.SneakState.Value, num);
		});
		if (this.BtType == BtType.Invalid)
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.SneakStart);
		int? behaviorTreeOwnerId = GeneralLogicTreeModel.Instance.GetBehaviorTreeOwnerId(new long?(base.TreeIncId));
		SneakTimeRequest sneakTimeRequest = SneakTimeRequest.Create();
		sneakTimeRequest.TreeOwnerId = behaviorTreeOwnerId.Value;
		sneakTimeRequest.TreeIncId = MathUtils.Instance.BigIntToLong(base.TreeIncId);
		Net.Instance.Call(ERequestMessageId.SneakTimeRequest, sneakTimeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SneakTimeResponse sneakTimeResponse = (SneakTimeResponse)msg;
			if (sneakTimeResponse.ErrorId != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(sneakTimeResponse.ErrorId, 16525, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600B937 RID: 47415 RVA: 0x0036B724 File Offset: 0x00369924
	private void RemoveSneakEvent()
	{
		EventSystem.Instance.Emit(EEventName.SneakEnd);
		if (EventSystem.Instance.Has(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged)))
		{
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		}
		if (this.RegisterSneakyNotify)
		{
			Net.Instance.UnRegister(ENotifyMessageId.SneakNotify);
			this.RegisterSneakyNotify = false;
		}
	}

	// Token: 0x0600B938 RID: 47416 RVA: 0x0036B79C File Offset: 0x0036999C
	private void OnBattleStateChanged(bool isInBattleState)
	{
		this.AddOrRemoveSneakBuff(!isInBattleState);
		bool? sneakState = this.SneakState;
		if (isInBattleState == sneakState.GetValueOrDefault() & sneakState != null)
		{
			return;
		}
		if (this.BtType == BtType.Invalid)
		{
			return;
		}
		this.SneakState = new bool?(isInBattleState);
		if (!isInBattleState)
		{
			EventSystem.Instance.Emit<bool, long>(EEventName.OnSneakFoundChange, this.SneakState.Value, 0L);
		}
		int? behaviorTreeOwnerId = GeneralLogicTreeModel.Instance.GetBehaviorTreeOwnerId(new long?(base.TreeIncId));
		SneakRequest sneakRequest = SneakRequest.Create();
		sneakRequest.TreeOwnerId = behaviorTreeOwnerId.Value;
		sneakRequest.TreeIncId = MathUtils.Instance.BigIntToLong(base.TreeIncId);
		sneakRequest.NodeId = base.NodeId;
		sneakRequest.IsStart = isInBattleState;
		Net.Instance.Call(ERequestMessageId.SneakRequest, sneakRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SneakResponse sneakResponse = (SneakResponse)msg;
			int errorId = (int)sneakResponse.ErrorId;
			if (errorId != 0 && errorId != 600067 && errorId != 1000054)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(sneakResponse.ErrorId, 27480, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600B939 RID: 47417 RVA: 0x0036B886 File Offset: 0x00369A86
	private void AddStalkEvent()
	{
		EventSystem.Instance.Add(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
	}

	// Token: 0x0600B93A RID: 47418 RVA: 0x0036B8A4 File Offset: 0x00369AA4
	private void RemoveStalkEvent()
	{
		if (EventSystem.Instance.Has(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound)))
		{
			EventSystem.Instance.Remove(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
		}
	}

	// Token: 0x0600B93B RID: 47419 RVA: 0x0036B8E0 File Offset: 0x00369AE0
	private void OnStalkFound(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return;
		}
		int pbDataId = entity.GetComponent<CreatureDataComponent>().GetPbDataId();
		if (!this.EntitiesMonitorStalkAlert.Contains(pbDataId))
		{
			return;
		}
		TimerSystem.Instance.Delay(delegate(float _)
		{
			if (this.IsRequesting)
			{
				return;
			}
			this.IsRequesting = true;
			EventSystem.Instance.Emit(EEventName.OnStalkFailed);
			this.RequestStalkFailed();
		}, 1000f, null, null, true, 1f);
	}

	// Token: 0x0600B93C RID: 47420 RVA: 0x0036B944 File Offset: 0x00369B44
	private void RequestStalkFailed()
	{
		int? behaviorTreeOwnerId = GeneralLogicTreeModel.Instance.GetBehaviorTreeOwnerId(new long?(base.TreeIncId));
		NpcTraceFailedRequest npcTraceFailedRequest = NpcTraceFailedRequest.Create();
		npcTraceFailedRequest.TreeOwnerId = behaviorTreeOwnerId.Value;
		npcTraceFailedRequest.TreeIncId = MathUtils.Instance.BigIntToLong(base.TreeIncId);
		npcTraceFailedRequest.NodeId = base.NodeId;
		Net.Instance.Call(ERequestMessageId.NpcTraceFailedRequest, npcTraceFailedRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NpcTraceFailedResponse npcTraceFailedResponse = (NpcTraceFailedResponse)msg;
			if (npcTraceFailedResponse.ErrorId != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(npcTraceFailedResponse.ErrorId, 19981, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600B93D RID: 47421 RVA: 0x0036B9CC File Offset: 0x00369BCC
	private void AddOrRemoveSneakBuff(bool isAdd)
	{
		CharacterBuffComponent component = Global.BaseCharacter.GetEntityNoBlueprint().GetComponent<CharacterBuffComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		if (isAdd)
		{
			component.AddBuff(70000049L, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				Reason = "QuestFailedBehaviorNode"
			});
			return;
		}
		component.RemoveBuff(70000049L, -1, "QuestFailedBehaviorNode", null, null, null);
	}

	// Token: 0x0600B93E RID: 47422 RVA: 0x0036BA4E File Offset: 0x00369C4E
	public bool IsFadeInScreen()
	{
		return this.TransitionType.GetValueOrDefault() == ETeleportTransitionType.FadeInScreen;
	}

	// Token: 0x0600B93F RID: 47423 RVA: 0x0036BA5E File Offset: 0x00369C5E
	private void StopFailRangeEffect()
	{
		if (this.RangeFailedParameterContext != null)
		{
			this.RangeFailedEffectChain.Stop(this.RangeFailedParameterContext);
		}
	}

	// Token: 0x0600B940 RID: 47424 RVA: 0x0036BA7C File Offset: 0x00369C7C
	public bool IsOutFailRange(global::Vector itemPosition)
	{
		if (this.RangeFailedParameterContext != null)
		{
			if (this.RangeFailedParameterContext.FailRangeCheck != null)
			{
				return this.RangeFailedParameterContext.FailRangeCheck.MapCheckReachedPosition(itemPosition) == null;
			}
			if (this.RangeFailedParameterContext.RangeFailedEffectCenterPos != null)
			{
				float rangeFailedEffectRadius = this.RangeFailedParameterContext.RangeFailedEffectRadius;
				return global::Vector.DistXY(this.RangeFailedParameterContext.RangeFailedEffectCenterPos, itemPosition) > (double)this.RangeFailedParameterContext.RangeFailedEffectRadius;
			}
		}
		return true;
	}

	// Token: 0x0600B941 RID: 47425 RVA: 0x0036BAF7 File Offset: 0x00369CF7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B942 RID: 47426 RVA: 0x0036BAF9 File Offset: 0x00369CF9
	public static void ResetStaticDefaultValue()
	{
		QuestFailedBehaviorNode.RangeFailedEffectChainInternal = null;
	}

	// Token: 0x04006A7B RID: 27259
	public const int STALK_FAILED_DELAY_TIME = 1000;

	// Token: 0x04006A7C RID: 27260
	[Nullable(2)]
	public ITimerUiConfig TimerUiConfig;

	// Token: 0x04006A7D RID: 27261
	public bool? CanGiveUp;

	// Token: 0x04006A7E RID: 27262
	private bool? SneakState;

	// Token: 0x04006A7F RID: 27263
	private bool RegisterSneakyNotify;

	// Token: 0x04006A80 RID: 27264
	private bool? NeedConfirm;

	// Token: 0x04006A81 RID: 27265
	private ETeleportTransitionType? TransitionType;

	// Token: 0x04006A82 RID: 27266
	[Nullable(2)]
	public string GiveUpText;

	// Token: 0x04006A83 RID: 27267
	private List<int> EntitiesMonitorStalkAlert = new List<int>();

	// Token: 0x04006A84 RID: 27268
	private bool IsRequesting;

	// Token: 0x04006A85 RID: 27269
	public bool NeedRequiresSecondConfirmation;

	// Token: 0x04006A86 RID: 27270
	[Nullable(2)]
	private RangeFailedParameterContext RangeFailedParameterContext;

	// Token: 0x04006A87 RID: 27271
	[Nullable(2)]
	private static RangeFailedEffectHandler RangeFailedEffectChainInternal;
}
