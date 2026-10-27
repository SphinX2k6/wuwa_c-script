using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200328A RID: 12938
[NullableContext(1)]
[Nullable(0)]
public class PawnSensoryInfoComponent : EntityComponent
{
	// Token: 0x0601C01B RID: 114715 RVA: 0x007C8C48 File Offset: 0x007C6E48
	protected override void OnEnable()
	{
		base.OnEnable();
		if (this.PerceptionsEvents.Count > 0 && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroPerceptionInterface.MarkElementDisable(base.Entity.GameBudgetManagedToken, false);
		}
	}

	// Token: 0x0601C01C RID: 114716 RVA: 0x007C8C7C File Offset: 0x007C6E7C
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		if (this.PerceptionsEvents.Count > 0 && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroPerceptionInterface.MarkElementDisable(base.Entity.GameBudgetManagedToken, true);
		}
	}

	// Token: 0x0601C01D RID: 114717 RVA: 0x007C8CB4 File Offset: 0x007C6EB4
	[NullableContext(2)]
	[return: Nullable(1)]
	public PlayerPerceptionEvent CreatePerceptionEvent(float enterDistance, uint entityToken = 0U, Action onEnter = null, Action onLeave = null, Action onDestroy = null, Func<bool> enterCondition = null, float leaveDistance = -1f, global::Vector locationOffset = null)
	{
		PlayerPerceptionEvent playerPerceptionEvent = EnvironmentalPerceptionController.Instance.CreatePlayerPerceptionEvent();
		this.PerceptionsEvents.Add(playerPerceptionEvent);
		playerPerceptionEvent.Init(enterDistance, entityToken, onEnter, onLeave, onDestroy, enterCondition, leaveDistance, locationOffset);
		if (entityToken != 0U)
		{
			UKuroPerceptionInterface.MarkElementDisable(entityToken, !base.Entity.Active);
		}
		return playerPerceptionEvent;
	}

	// Token: 0x0601C01E RID: 114718 RVA: 0x007C8D04 File Offset: 0x007C6F04
	public void DeletePerceptionEvent(PlayerPerceptionEvent @event)
	{
		this.PerceptionsEvents.Remove(@event);
		EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(@event);
	}

	// Token: 0x0601C01F RID: 114719 RVA: 0x007C8D20 File Offset: 0x007C6F20
	private void ClearPerceptionEvent()
	{
		foreach (PlayerPerceptionEvent @event in this.PerceptionsEvents)
		{
			EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(@event);
		}
		this.PerceptionsEvents.Clear();
	}

	// Token: 0x0601C020 RID: 114720 RVA: 0x007C8D84 File Offset: 0x007C6F84
	public void RegisterPerceptionEvent()
	{
		uint gameBudgetManagedToken = base.Entity.GameBudgetManagedToken;
		if (gameBudgetManagedToken == 0U)
		{
			return;
		}
		foreach (PlayerPerceptionEvent playerPerceptionEvent in this.PerceptionsEvents)
		{
			if (!playerPerceptionEvent.IsValid())
			{
				playerPerceptionEvent.Register(gameBudgetManagedToken);
			}
		}
		UKuroPerceptionInterface.MarkElementDisable(gameBudgetManagedToken, !base.Entity.Active);
	}

	// Token: 0x0601C021 RID: 114721 RVA: 0x007C8E04 File Offset: 0x007C7004
	protected override void OnActivate()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		Entity entity = base.Entity;
		uint entityToken = (entity != null) ? entity.GameBudgetManagedToken : 0U;
		if (component.GetEntityType() == EEntityType.Player)
		{
			this.ExecuteInDefaultRange();
		}
		else
		{
			if (this.DefaultRangeEvent != null)
			{
				this.DeletePerceptionEvent(this.DefaultRangeEvent);
				this.DefaultRangeEvent = null;
			}
			this.DefaultRangeEvent = this.CreatePerceptionEvent(2000f, entityToken, new Action(this.ExecuteInDefaultRange), null, null, null, -1f, null);
		}
		if (this.LogicRangeEvent == null && this.LogicRangeInternal > 0f)
		{
			this.LogicRangeEvent = this.CreatePerceptionEvent(this.LogicRangeInternal, entityToken, new Action(this.OnRangeEnter), new Action(this.OnRangeLeave), null, null, -1f, null);
		}
	}

	// Token: 0x0601C022 RID: 114722 RVA: 0x007C8EC8 File Offset: 0x007C70C8
	public void SetLogicRange(float range)
	{
		if (range > this.LogicRangeInternal)
		{
			this.LogicRangeInternal = range;
			if (this.LogicRangeEvent != null)
			{
				this.LogicRangeEvent.UpdateDistance(range, -1f);
				return;
			}
			uint gameBudgetManagedToken = base.Entity.GameBudgetManagedToken;
			if (gameBudgetManagedToken != 0U)
			{
				this.LogicRangeEvent = this.CreatePerceptionEvent(range, gameBudgetManagedToken, new Action(this.OnRangeEnter), new Action(this.OnRangeLeave), null, null, -1f, null);
			}
		}
	}

	// Token: 0x0601C023 RID: 114723 RVA: 0x007C8F3C File Offset: 0x007C713C
	private void OnRangeEnter()
	{
		this.IsInRangeInternal = true;
		if (!this.IsAlreadyInitDefaultInternal)
		{
			this.ExecuteInDefaultRange();
		}
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.EnterLogicRange);
		EventSystem.Instance.Emit<int>(EEventName.PlayerSenseTargetEnter, base.Entity.Id);
	}

	// Token: 0x0601C024 RID: 114724 RVA: 0x007C8F8F File Offset: 0x007C718F
	private void OnRangeLeave()
	{
		this.IsInRangeInternal = false;
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.LeaveLogicRange);
		EventSystem.Instance.Emit<int>(EEventName.PlayerSenseTargetLeave, base.Entity.Id);
	}

	// Token: 0x0601C025 RID: 114725 RVA: 0x007C8FCC File Offset: 0x007C71CC
	protected override bool OnEnd()
	{
		this.LogicRangeEvent = null;
		this.DefaultRangeEvent = null;
		this.ClearPerceptionEvent();
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.LeaveLogicRange);
		EventSystem.Instance.Emit<int>(EEventName.PlayerSenseTargetLeave, base.Entity.Id);
		return true;
	}

	// Token: 0x0601C026 RID: 114726 RVA: 0x007C901F File Offset: 0x007C721F
	private void ExecuteInDefaultRange()
	{
		if (!this.IsAlreadyInitDefaultInternal)
		{
			this.IsAlreadyInitDefaultInternal = true;
			if (this.DefaultRangeEvent != null)
			{
				this.DeletePerceptionEvent(this.DefaultRangeEvent);
				this.DefaultRangeEvent = null;
			}
		}
	}

	// Token: 0x170026B4 RID: 9908
	// (get) Token: 0x0601C027 RID: 114727 RVA: 0x007C904B File Offset: 0x007C724B
	public double PlayerDistSquared
	{
		get
		{
			return this.PlayerDistSquaredInternal;
		}
	}

	// Token: 0x170026B5 RID: 9909
	// (get) Token: 0x0601C028 RID: 114728 RVA: 0x007C9053 File Offset: 0x007C7253
	public double PlayerDist
	{
		get
		{
			return Math.Sqrt(this.PlayerDistSquaredInternal);
		}
	}

	// Token: 0x170026B6 RID: 9910
	// (get) Token: 0x0601C029 RID: 114729 RVA: 0x007C9060 File Offset: 0x007C7260
	public float LogicRange
	{
		get
		{
			return this.LogicRangeInternal;
		}
	}

	// Token: 0x170026B7 RID: 9911
	// (get) Token: 0x0601C02A RID: 114730 RVA: 0x007C9068 File Offset: 0x007C7268
	public bool IsInLogicRange
	{
		get
		{
			return this.IsInRangeInternal;
		}
	}

	// Token: 0x0601C02B RID: 114731 RVA: 0x007C9070 File Offset: 0x007C7270
	public string GetDebugString()
	{
		string text = "";
		string str = text;
		string str2 = "DefaultRangeToken: ";
		PlayerPerceptionEvent defaultRangeEvent = this.DefaultRangeEvent;
		text = str + str2 + (((defaultRangeEvent != null) ? defaultRangeEvent.EventToken.ToString() : null) ?? "undefined") + "\n";
		string str3 = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(69, 3);
		defaultInterpolatedStringHandler.AppendLiteral("LogicRangeToken: ");
		PlayerPerceptionEvent logicRangeEvent = this.LogicRangeEvent;
		defaultInterpolatedStringHandler.AppendFormatted(((logicRangeEvent != null) ? logicRangeEvent.EventToken.ToString() : null) ?? "undefined");
		defaultInterpolatedStringHandler.AppendLiteral("; LogicRange: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.LogicRangeInternal);
		defaultInterpolatedStringHandler.AppendLiteral("; IsInRangeInternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsInLogicRange);
		defaultInterpolatedStringHandler.AppendLiteral("\nLogicRangeInfo:\n");
		text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
		if (this.LogicRangeEvent != null)
		{
			text += UKuroPerceptionInterface.GetPlayerPerceptionDebugString(this.LogicRangeEvent.EventToken);
		}
		return text;
	}

	// Token: 0x0601C02C RID: 114732 RVA: 0x007C9164 File Offset: 0x007C7364
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnSensoryInfoComponent pawnSensoryInfoComponent = (PawnSensoryInfoComponent)componentTemplate;
		if (base.CanResetComponentProperty("LogicRangeInternal"))
		{
			this.LogicRangeInternal = pawnSensoryInfoComponent.LogicRangeInternal;
		}
		if (base.CanResetComponentProperty("IsInRangeInternal"))
		{
			this.IsInRangeInternal = pawnSensoryInfoComponent.IsInRangeInternal;
		}
		if (base.CanResetComponentProperty("IsAlreadyInitDefaultInternal"))
		{
			this.IsAlreadyInitDefaultInternal = pawnSensoryInfoComponent.IsAlreadyInitDefaultInternal;
		}
		if (base.CanResetComponentProperty("DefaultRangeEvent"))
		{
			if (pawnSensoryInfoComponent.DefaultRangeEvent == null)
			{
				this.DefaultRangeEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.DefaultRangeEvent), "DefaultRangeEvent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PerceptionsEvents") && pawnSensoryInfoComponent.PerceptionsEvents != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.PerceptionsEvents), "PerceptionsEvents"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LogicRangeEvent"))
		{
			if (pawnSensoryInfoComponent.LogicRangeEvent == null)
			{
				this.LogicRangeEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.LogicRangeEvent), "LogicRangeEvent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DD6B RID: 56683
	public const int PERCEPTION_SEARCH_RANGE = 2000;

	// Token: 0x0400DD6C RID: 56684
	private float LogicRangeInternal;

	// Token: 0x0400DD6D RID: 56685
	private bool IsInRangeInternal;

	// Token: 0x0400DD6E RID: 56686
	private bool IsAlreadyInitDefaultInternal;

	// Token: 0x0400DD6F RID: 56687
	private readonly double PlayerDistSquaredInternal = double.MaxValue;

	// Token: 0x0400DD70 RID: 56688
	[Nullable(2)]
	private PlayerPerceptionEvent DefaultRangeEvent;

	// Token: 0x0400DD71 RID: 56689
	private readonly HashSet<PlayerPerceptionEvent> PerceptionsEvents = new HashSet<PlayerPerceptionEvent>();

	// Token: 0x0400DD72 RID: 56690
	[Nullable(2)]
	private PlayerPerceptionEvent LogicRangeEvent;
}
