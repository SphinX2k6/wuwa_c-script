using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02001D6B RID: 7531
[NullableContext(1)]
[Nullable(0)]
public class QuestFailedBehaviorNode : BehaviorNodeBase, IStaticVariableResetter
{
	// Token: 0x0600E50F RID: 58639 RVA: 0x0035F6EB File Offset: 0x0035D8EB
	public QuestFailedBehaviorNode(int NodeId) : base(NodeId)
	{
	}

	// Token: 0x0600E510 RID: 58640 RVA: 0x0035F6FF File Offset: 0x0035D8FF
	static QuestFailedBehaviorNode()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestFailedBehaviorNode.CreateStaticDefaultValue), new Action(QuestFailedBehaviorNode.ResetStaticDefaultValue));
	}

	// Token: 0x1700124F RID: 4687
	// (get) Token: 0x0600E511 RID: 58641 RVA: 0x0035F71E File Offset: 0x0035D91E
	public override EBtNode NodeType
	{
		get
		{
			return EBtNode.QuestFailed;
		}
	}

	// Token: 0x17001250 RID: 4688
	// (get) Token: 0x0600E512 RID: 58642 RVA: 0x0035F721 File Offset: 0x0035D921
	public bool? NeedSecondaryConfirm
	{
		get
		{
			return this.NeedConfirm;
		}
	}

	// Token: 0x17001251 RID: 4689
	// (get) Token: 0x0600E513 RID: 58643 RVA: 0x0035F729 File Offset: 0x0035D929
	public ETeleportTransitionType? NowTransitionType
	{
		get
		{
			return this.TransitionType;
		}
	}

	// Token: 0x17001252 RID: 4690
	// (get) Token: 0x0600E514 RID: 58644 RVA: 0x0035F734 File Offset: 0x0035D934
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

	// Token: 0x0600E515 RID: 58645 RVA: 0x0035F768 File Offset: 0x0035D968
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

	// Token: 0x0600E516 RID: 58646 RVA: 0x0035F969 File Offset: 0x0035DB69
	protected override void OnNodeActive()
	{
		if (this.RangeFailedParameterContext != null)
		{
			this.RangeFailedEffectChain.Handle(this.RangeFailedParameterContext);
		}
	}

	// Token: 0x0600E517 RID: 58647 RVA: 0x0035F988 File Offset: 0x0035DB88
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

	// Token: 0x0600E518 RID: 58648 RVA: 0x0035F9F4 File Offset: 0x0035DBF4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(sneakTimeResponse.ErrorId, 18825, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600E519 RID: 58649 RVA: 0x0035FAD0 File Offset: 0x0035DCD0
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

	// Token: 0x0600E51A RID: 58650 RVA: 0x0035FB48 File Offset: 0x0035DD48
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(sneakResponse.ErrorId, 20692, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600E51B RID: 58651 RVA: 0x0035FC32 File Offset: 0x0035DE32
	private void AddStalkEvent()
	{
		EventSystem.Instance.Add(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
	}

	// Token: 0x0600E51C RID: 58652 RVA: 0x0035FC50 File Offset: 0x0035DE50
	private void RemoveStalkEvent()
	{
		if (EventSystem.Instance.Has(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound)))
		{
			EventSystem.Instance.Remove(EEventName.OnStalkFound, new Action<int>(this.OnStalkFound));
		}
	}

	// Token: 0x0600E51D RID: 58653 RVA: 0x0035FC8C File Offset: 0x0035DE8C
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

	// Token: 0x0600E51E RID: 58654 RVA: 0x0035FCF0 File Offset: 0x0035DEF0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(npcTraceFailedResponse.ErrorId, 26082, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600E51F RID: 58655 RVA: 0x0035FD78 File Offset: 0x0035DF78
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

	// Token: 0x0600E520 RID: 58656 RVA: 0x0035FDFA File Offset: 0x0035DFFA
	public bool IsFadeInScreen()
	{
		return this.TransitionType.GetValueOrDefault() == ETeleportTransitionType.FadeInScreen;
	}

	// Token: 0x0600E521 RID: 58657 RVA: 0x0035FE0A File Offset: 0x0035E00A
	private void StopFailRangeEffect()
	{
		if (this.RangeFailedParameterContext != null)
		{
			this.RangeFailedEffectChain.Stop(this.RangeFailedParameterContext);
		}
	}

	// Token: 0x0600E522 RID: 58658 RVA: 0x0035FE28 File Offset: 0x0035E028
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

	// Token: 0x0600E523 RID: 58659 RVA: 0x0035FEA3 File Offset: 0x0035E0A3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E524 RID: 58660 RVA: 0x0035FEA5 File Offset: 0x0035E0A5
	public static void ResetStaticDefaultValue()
	{
		QuestFailedBehaviorNode.RangeFailedEffectChainInternal = null;
	}

	// Token: 0x0400699B RID: 27035
	public const int STALK_FAILED_DELAY_TIME = 1000;

	// Token: 0x0400699C RID: 27036
	[Nullable(2)]
	public ITimerUiConfig TimerUiConfig;

	// Token: 0x0400699D RID: 27037
	public bool? CanGiveUp;

	// Token: 0x0400699E RID: 27038
	private bool? SneakState;

	// Token: 0x0400699F RID: 27039
	private bool RegisterSneakyNotify;

	// Token: 0x040069A0 RID: 27040
	private bool? NeedConfirm;

	// Token: 0x040069A1 RID: 27041
	private ETeleportTransitionType? TransitionType;

	// Token: 0x040069A2 RID: 27042
	[Nullable(2)]
	public string GiveUpText;

	// Token: 0x040069A3 RID: 27043
	private List<int> EntitiesMonitorStalkAlert = new List<int>();

	// Token: 0x040069A4 RID: 27044
	private bool IsRequesting;

	// Token: 0x040069A5 RID: 27045
	public bool NeedRequiresSecondConfirmation;

	// Token: 0x040069A6 RID: 27046
	[Nullable(2)]
	private RangeFailedParameterContext RangeFailedParameterContext;

	// Token: 0x040069A7 RID: 27047
	[Nullable(2)]
	private static RangeFailedEffectHandler RangeFailedEffectChainInternal;
}
