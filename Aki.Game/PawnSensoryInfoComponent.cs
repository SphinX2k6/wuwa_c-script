using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020027FB RID: 10235
[NullableContext(1)]
[Nullable(0)]
public class PawnSensoryInfoComponent : EntityComponent
{
	// Token: 0x06019C29 RID: 105513 RVA: 0x007EFF7B File Offset: 0x007EE17B
	protected override void OnEnable()
	{
		base.OnEnable();
		if (this.PerceptionsEvents.Count > 0 && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroPerceptionInterface.MarkElementDisable(base.Entity.GameBudgetManagedToken, false);
		}
	}

	// Token: 0x06019C2A RID: 105514 RVA: 0x007EFFAF File Offset: 0x007EE1AF
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		if (this.PerceptionsEvents.Count > 0 && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroPerceptionInterface.MarkElementDisable(base.Entity.GameBudgetManagedToken, true);
		}
	}

	// Token: 0x06019C2B RID: 105515 RVA: 0x007EFFE4 File Offset: 0x007EE1E4
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

	// Token: 0x06019C2C RID: 105516 RVA: 0x007F0034 File Offset: 0x007EE234
	public void DeletePerceptionEvent(PlayerPerceptionEvent @event)
	{
		this.PerceptionsEvents.Remove(@event);
		EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(@event);
	}

	// Token: 0x06019C2D RID: 105517 RVA: 0x007F0050 File Offset: 0x007EE250
	private void ClearPerceptionEvent()
	{
		foreach (PlayerPerceptionEvent @event in this.PerceptionsEvents)
		{
			EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(@event);
		}
		this.PerceptionsEvents.Clear();
	}

	// Token: 0x06019C2E RID: 105518 RVA: 0x007F00B4 File Offset: 0x007EE2B4
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

	// Token: 0x06019C2F RID: 105519 RVA: 0x007F0134 File Offset: 0x007EE334
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

	// Token: 0x06019C30 RID: 105520 RVA: 0x007F01F8 File Offset: 0x007EE3F8
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

	// Token: 0x06019C31 RID: 105521 RVA: 0x007F026C File Offset: 0x007EE46C
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

	// Token: 0x06019C32 RID: 105522 RVA: 0x007F02BF File Offset: 0x007EE4BF
	private void OnRangeLeave()
	{
		this.IsInRangeInternal = false;
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.LeaveLogicRange);
		EventSystem.Instance.Emit<int>(EEventName.PlayerSenseTargetLeave, base.Entity.Id);
	}

	// Token: 0x06019C33 RID: 105523 RVA: 0x007F02FC File Offset: 0x007EE4FC
	protected override bool OnEnd()
	{
		this.LogicRangeEvent = null;
		this.DefaultRangeEvent = null;
		this.ClearPerceptionEvent();
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.LeaveLogicRange);
		EventSystem.Instance.Emit<int>(EEventName.PlayerSenseTargetLeave, base.Entity.Id);
		return true;
	}

	// Token: 0x06019C34 RID: 105524 RVA: 0x007F034F File Offset: 0x007EE54F
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

	// Token: 0x17002970 RID: 10608
	// (get) Token: 0x06019C35 RID: 105525 RVA: 0x007F037B File Offset: 0x007EE57B
	public double PlayerDistSquared
	{
		get
		{
			return this.PlayerDistSquaredInternal;
		}
	}

	// Token: 0x17002971 RID: 10609
	// (get) Token: 0x06019C36 RID: 105526 RVA: 0x007F0383 File Offset: 0x007EE583
	public double PlayerDist
	{
		get
		{
			return Math.Sqrt(this.PlayerDistSquaredInternal);
		}
	}

	// Token: 0x17002972 RID: 10610
	// (get) Token: 0x06019C37 RID: 105527 RVA: 0x007F0390 File Offset: 0x007EE590
	public float LogicRange
	{
		get
		{
			return this.LogicRangeInternal;
		}
	}

	// Token: 0x17002973 RID: 10611
	// (get) Token: 0x06019C38 RID: 105528 RVA: 0x007F0398 File Offset: 0x007EE598
	public bool IsInLogicRange
	{
		get
		{
			return this.IsInRangeInternal;
		}
	}

	// Token: 0x06019C39 RID: 105529 RVA: 0x007F03A0 File Offset: 0x007EE5A0
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

	// Token: 0x06019C3A RID: 105530 RVA: 0x007F0494 File Offset: 0x007EE694
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnSensoryInfoComponent pawnSensoryInfoComponent = (PawnSensoryInfoComponent)componentTemplate;
		this.LogicRangeInternal = pawnSensoryInfoComponent.LogicRangeInternal;
		this.IsInRangeInternal = pawnSensoryInfoComponent.IsInRangeInternal;
		this.IsAlreadyInitDefaultInternal = pawnSensoryInfoComponent.IsAlreadyInitDefaultInternal;
		if (pawnSensoryInfoComponent.DefaultRangeEvent == null)
		{
			this.DefaultRangeEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultRangeEvent), "DefaultRangeEvent"))
		{
			return false;
		}
		if (pawnSensoryInfoComponent.PerceptionsEvents != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.PerceptionsEvents), "PerceptionsEvents"))
		{
			return false;
		}
		if (pawnSensoryInfoComponent.LogicRangeEvent == null)
		{
			this.LogicRangeEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LogicRangeEvent), "LogicRangeEvent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002974 RID: 10612
	// (get) Token: 0x06019C3B RID: 105531 RVA: 0x007F0550 File Offset: 0x007EE750
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002975 RID: 10613
	// (get) Token: 0x06019C3C RID: 105532 RVA: 0x007F0553 File Offset: 0x007EE753
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002976 RID: 10614
	// (get) Token: 0x06019C3D RID: 105533 RVA: 0x007F0556 File Offset: 0x007EE756
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002977 RID: 10615
	// (get) Token: 0x06019C3E RID: 105534 RVA: 0x007F0559 File Offset: 0x007EE759
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E213 RID: 57875
	public const int PERCEPTION_SEARCH_RANGE = 2000;

	// Token: 0x0400E214 RID: 57876
	private float LogicRangeInternal;

	// Token: 0x0400E215 RID: 57877
	private bool IsInRangeInternal;

	// Token: 0x0400E216 RID: 57878
	private bool IsAlreadyInitDefaultInternal;

	// Token: 0x0400E217 RID: 57879
	private readonly double PlayerDistSquaredInternal = double.MaxValue;

	// Token: 0x0400E218 RID: 57880
	[Nullable(2)]
	private PlayerPerceptionEvent DefaultRangeEvent;

	// Token: 0x0400E219 RID: 57881
	private readonly HashSet<PlayerPerceptionEvent> PerceptionsEvents = new HashSet<PlayerPerceptionEvent>();

	// Token: 0x0400E21A RID: 57882
	[Nullable(2)]
	private PlayerPerceptionEvent LogicRangeEvent;
}
