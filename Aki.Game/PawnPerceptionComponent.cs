using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x020027FA RID: 10234
[NullableContext(2)]
[Nullable(0)]
public class PawnPerceptionComponent : EntityComponent
{
	// Token: 0x17002967 RID: 10599
	// (get) Token: 0x06019C06 RID: 105478 RVA: 0x007EF500 File Offset: 0x007ED700
	public bool IsInInteractRange
	{
		get
		{
			return this.IsInInteractRangeInternal;
		}
	}

	// Token: 0x17002968 RID: 10600
	// (get) Token: 0x06019C07 RID: 105479 RVA: 0x007EF508 File Offset: 0x007ED708
	public bool IsInInteractForbiddenRange
	{
		get
		{
			return this.IsInInteractForbiddenRangeInternal;
		}
	}

	// Token: 0x17002969 RID: 10601
	// (get) Token: 0x06019C08 RID: 105480 RVA: 0x007EF510 File Offset: 0x007ED710
	public bool InAnyOptionWithOffsetRange
	{
		get
		{
			return this.OptionWithOffsetInRange.Count > 0;
		}
	}

	// Token: 0x1700296A RID: 10602
	// (get) Token: 0x06019C09 RID: 105481 RVA: 0x007EF520 File Offset: 0x007ED720
	public bool IsInAdsorbRange
	{
		get
		{
			return this.IsInAdsorbRangeInternal;
		}
	}

	// Token: 0x1700296B RID: 10603
	// (get) Token: 0x06019C0A RID: 105482 RVA: 0x007EF528 File Offset: 0x007ED728
	public bool IsInSightRange
	{
		get
		{
			return this.IsInSightRangeInternal;
		}
	}

	// Token: 0x06019C0B RID: 105483 RVA: 0x007EF530 File Offset: 0x007ED730
	public void SetInteractRange(float inRange, float exitRange = 0f, Vector offset = null)
	{
		this.PawnSensoryInfo.SetLogicRange((float)((double)Math.Max(inRange + 100f, exitRange) + ((offset != null) ? offset.Size() : 0.0)));
		if (this.InteractEvent != null)
		{
			this.InteractEvent.UpdateDistance(inRange, (exitRange == 0f) ? inRange : exitRange);
			return;
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		this.InteractEvent = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			this.IsInInteractRangeInternal = true;
			EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.OnInEntityInteractRangeChange, true);
		}, delegate
		{
			this.IsInInteractRangeInternal = false;
			EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.OnInEntityInteractRangeChange, false);
		}, null, null, exitRange, offset);
	}

	// Token: 0x06019C0C RID: 105484 RVA: 0x007EF5D0 File Offset: 0x007ED7D0
	public void SetInteractForbiddenRange(float inRange, float exitRange = 0f, Vector offset = null)
	{
		if (this.ForbiddenRangeEvent != null)
		{
			this.ForbiddenRangeEvent.UpdateDistance(inRange, (exitRange == 0f) ? inRange : exitRange);
			return;
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		this.ForbiddenRangeEvent = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			this.IsInInteractForbiddenRangeInternal = true;
		}, delegate
		{
			this.IsInInteractForbiddenRangeInternal = false;
		}, null, null, exitRange, offset);
	}

	// Token: 0x06019C0D RID: 105485 RVA: 0x007EF640 File Offset: 0x007ED840
	public void SetInteractRangeWithTags(int tagId, float inRange, float exitRange = 0f, Vector offset = null, Action enterEvent = null, Action leaveEvent = null)
	{
		this.PawnSensoryInfo.SetLogicRange((float)((double)Math.Max(inRange + 100f, exitRange) + ((offset != null) ? offset.Size() : 0.0)));
		if (this.InteractEventWithTagsInternal.ContainsKey(tagId))
		{
			this.InteractEventWithTagsInternal[tagId].UpdateDistance(inRange, (exitRange == 0f) ? inRange : exitRange);
			return;
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		PlayerPerceptionEvent value = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			if (enterEvent != null)
			{
				enterEvent();
			}
		}, delegate
		{
			if (leaveEvent != null)
			{
				leaveEvent();
			}
		}, null, null, exitRange, offset);
		this.InteractEventWithTagsInternal[tagId] = value;
	}

	// Token: 0x06019C0E RID: 105486 RVA: 0x007EF70C File Offset: 0x007ED90C
	public void SetOffsetOptionInteractRange(int optionId, float inRange, float exitRange = 0f, Vector offset = null, Action enterEvent = null, Action leaveEvent = null)
	{
		this.PawnSensoryInfo.SetLogicRange((float)((double)Math.Max(inRange + 100f, exitRange) + ((offset != null) ? offset.Size() : 0.0)));
		if (this.OffsetOptionInteractEvent.ContainsKey(optionId))
		{
			this.OffsetOptionInteractEvent[optionId].UpdateDistance(inRange, (exitRange == 0f) ? inRange : exitRange);
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		PlayerPerceptionEvent value = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			if (enterEvent != null)
			{
				enterEvent();
			}
			this.OptionWithOffsetInRange.Add(optionId);
			EventSystem.Instance.EmitWithTarget<bool>(this.Entity, EEventName.OnInEntityInteractRangeChange, true);
		}, delegate
		{
			if (leaveEvent != null)
			{
				leaveEvent();
			}
			this.OptionWithOffsetInRange.Remove(optionId);
			EventSystem.Instance.EmitWithTarget<bool>(this.Entity, EEventName.OnInEntityInteractRangeChange, false);
		}, null, null, exitRange, offset);
		this.OffsetOptionInteractEvent[optionId] = value;
	}

	// Token: 0x06019C0F RID: 105487 RVA: 0x007EF7F4 File Offset: 0x007ED9F4
	public void SetSightRange(float inRange)
	{
		this.PawnSensoryInfo.SetLogicRange(inRange);
		if (this.SightEvent != null)
		{
			this.SightEvent.UpdateDistance(inRange, -1f);
			return;
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		this.SightEvent = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			this.IsInSightRangeInternal = true;
		}, delegate
		{
			this.IsInSightRangeInternal = false;
		}, null, null, -1f, null);
	}

	// Token: 0x06019C10 RID: 105488 RVA: 0x007EF86C File Offset: 0x007EDA6C
	public void SetGuideRange(float inRange)
	{
		this.PawnSensoryInfo.SetLogicRange(inRange);
		if (this.GuideEvent != null)
		{
			this.GuideEvent.UpdateDistance(inRange, -1f);
			return;
		}
		PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
		Entity entity = base.Entity;
		this.GuideEvent = pawnSensoryInfo.CreatePerceptionEvent(inRange, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
		{
			EventSystem.Instance.Emit<int>(EEventName.OnGuideRangeEnter, base.Entity.Id);
		}, null, null, null, -1f, null);
	}

	// Token: 0x06019C11 RID: 105489 RVA: 0x007EF8D8 File Offset: 0x007EDAD8
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.MonitorConditionIds = new TMap<int, int>();
		this.ConfigId = base.Entity.GetComponent<CreatureDataComponent>().GetPbDataId();
		return true;
	}

	// Token: 0x06019C12 RID: 105490 RVA: 0x007EF8FC File Offset: 0x007EDAFC
	protected override bool OnInit()
	{
		this.PawnSensoryInfo = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		return true;
	}

	// Token: 0x06019C13 RID: 105491 RVA: 0x007EF910 File Offset: 0x007EDB10
	protected override bool OnStart()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.OwnActor = base.Entity.GetComponent<BaseActorComponent>();
		AActor owner = this.OwnActor.Owner;
		if (owner == null || !owner.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Pawn;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[PawnPerceptionComponent.OnStart] 非法Actor";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.LeaveLogicRange, new Action(this.OnLeaveLogicRange));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnUpdateNearbyEnable, new Action<bool>(this.OnUpdateNearbyEnable));
		return true;
	}

	// Token: 0x06019C14 RID: 105492 RVA: 0x007EF9D0 File Offset: 0x007EDBD0
	protected override void OnActivate()
	{
		SceneItemNearbyTrackingComponent component = base.Entity.GetComponent<SceneItemNearbyTrackingComponent>();
		if (component != null)
		{
			int value = component.ShowRange.Value;
			int value2 = component.HideRange.Value;
			this.NearbyEnable = component.EnableTracking;
			this.IsEnterNearby = false;
			PawnSensoryInfoComponent pawnSensoryInfo = this.PawnSensoryInfo;
			float enterDistance = (float)value;
			Entity entity = base.Entity;
			pawnSensoryInfo.CreatePerceptionEvent(enterDistance, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
			{
				this.IsEnterNearby = true;
				EventSystem.Instance.Emit<Entity>(EEventName.OnEnterNearbyTrackRange, base.Entity);
			}, delegate
			{
				this.IsEnterNearby = false;
				EventSystem.Instance.Emit<Entity>(EEventName.OnLeaveNearbyTrackRange, base.Entity);
			}, null, () => this.NearbyEnable, (float)value2, null);
			this.PawnSensoryInfo.SetLogicRange((float)value);
			this.PawnSensoryInfo.SetLogicRange((float)(value2 + 100));
		}
	}

	// Token: 0x06019C15 RID: 105493 RVA: 0x007EFA88 File Offset: 0x007EDC88
	protected override bool OnEnd()
	{
		if (this.IsEnterNearby)
		{
			EventSystem.Instance.Emit<Entity>(EEventName.RemoveNearbyTrack, base.Entity);
		}
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.LeaveLogicRange, new Action(this.OnLeaveLogicRange));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnUpdateNearbyEnable, new Action<bool>(this.OnUpdateNearbyEnable));
		this.InteractEvent = null;
		this.ForbiddenRangeEvent = null;
		this.SightEvent = null;
		this.GuideEvent = null;
		this.InteractEventWithTagsInternal.Clear();
		this.MonitorConditionIds.Empty(0);
		return true;
	}

	// Token: 0x06019C16 RID: 105494 RVA: 0x007EFB2B File Offset: 0x007EDD2B
	private void OnLeaveLogicRange()
	{
		if (this.IsEnterNearby)
		{
			this.IsEnterNearby = false;
			EventSystem.Instance.Emit<Entity>(EEventName.OnLeaveNearbyTrackRange, base.Entity);
		}
	}

	// Token: 0x06019C17 RID: 105495 RVA: 0x007EFB52 File Offset: 0x007EDD52
	private void OnUpdateNearbyEnable(bool enable)
	{
		this.NearbyEnable = enable;
		this.IsEnterNearby = false;
	}

	// Token: 0x06019C18 RID: 105496 RVA: 0x007EFB64 File Offset: 0x007EDD64
	[NullableContext(1)]
	public string GetDebugString()
	{
		string text = "";
		string str = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(61, 2);
		defaultInterpolatedStringHandler.AppendLiteral("InteractRangeToken: ");
		PlayerPerceptionEvent interactEvent = this.InteractEvent;
		defaultInterpolatedStringHandler.AppendFormatted(((interactEvent != null) ? interactEvent.EventToken.ToString() : null) ?? "undefined");
		defaultInterpolatedStringHandler.AppendLiteral("; IsInRangeInternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsInInteractRangeInternal);
		defaultInterpolatedStringHandler.AppendLiteral("\nInteractRangeInfo:\n");
		text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		if (this.InteractEvent != null)
		{
			text += UKuroPerceptionInterface.GetPlayerPerceptionDebugString(this.InteractEvent.EventToken);
		}
		if (this.OffsetOptionInteractEvent.Count > 0)
		{
			text += "\nOptionInteractRangeInfo:\n";
			foreach (PlayerPerceptionEvent playerPerceptionEvent in this.OffsetOptionInteractEvent.Values)
			{
				text = text + UKuroPerceptionInterface.GetPlayerPerceptionDebugString(playerPerceptionEvent.EventToken) + "\n";
			}
		}
		return text;
	}

	// Token: 0x06019C19 RID: 105497 RVA: 0x007EFC84 File Offset: 0x007EDE84
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnPerceptionComponent pawnPerceptionComponent = (PawnPerceptionComponent)componentTemplate;
		if (pawnPerceptionComponent.OwnActor == null)
		{
			this.OwnActor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OwnActor), "OwnActor"))
		{
			return false;
		}
		this.IsInInteractRangeInternal = pawnPerceptionComponent.IsInInteractRangeInternal;
		this.IsInInteractForbiddenRangeInternal = pawnPerceptionComponent.IsInInteractForbiddenRangeInternal;
		this.IsInSightRangeInternal = pawnPerceptionComponent.IsInSightRangeInternal;
		this.NearbyEnable = pawnPerceptionComponent.NearbyEnable;
		this.IsEnterNearby = pawnPerceptionComponent.IsEnterNearby;
		if (pawnPerceptionComponent.MonitorConditionIds == null)
		{
			this.MonitorConditionIds = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int, int>(this.MonitorConditionIds), "MonitorConditionIds"))
		{
			return false;
		}
		if (pawnPerceptionComponent.PawnSensoryInfo == null)
		{
			this.PawnSensoryInfo = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnSensoryInfo), "PawnSensoryInfo"))
		{
			return false;
		}
		this.ConfigId = pawnPerceptionComponent.ConfigId;
		if (pawnPerceptionComponent.InteractEvent == null)
		{
			this.InteractEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractEvent), "InteractEvent"))
		{
			return false;
		}
		if (pawnPerceptionComponent.ForbiddenRangeEvent == null)
		{
			this.ForbiddenRangeEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForbiddenRangeEvent), "ForbiddenRangeEvent"))
		{
			return false;
		}
		if (pawnPerceptionComponent.InteractEventWithTagsInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractEventWithTagsInternal), "InteractEventWithTagsInternal"))
		{
			return false;
		}
		if (pawnPerceptionComponent.OffsetOptionInteractEvent != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.OffsetOptionInteractEvent), "OffsetOptionInteractEvent"))
		{
			return false;
		}
		if (pawnPerceptionComponent.OptionWithOffsetInRange != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.OptionWithOffsetInRange), "OptionWithOffsetInRange"))
		{
			return false;
		}
		if (pawnPerceptionComponent.SightEvent == null)
		{
			this.SightEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightEvent), "SightEvent"))
		{
			return false;
		}
		if (pawnPerceptionComponent.GuideEvent == null)
		{
			this.GuideEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GuideEvent), "GuideEvent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x1700296C RID: 10604
	// (get) Token: 0x06019C1A RID: 105498 RVA: 0x007EFE7F File Offset: 0x007EE07F
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700296D RID: 10605
	// (get) Token: 0x06019C1B RID: 105499 RVA: 0x007EFE82 File Offset: 0x007EE082
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700296E RID: 10606
	// (get) Token: 0x06019C1C RID: 105500 RVA: 0x007EFE85 File Offset: 0x007EE085
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700296F RID: 10607
	// (get) Token: 0x06019C1D RID: 105501 RVA: 0x007EFE88 File Offset: 0x007EE088
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E200 RID: 57856
	private const int DISTANCE_OFFSET = 100;

	// Token: 0x0400E201 RID: 57857
	private const int INTERACT_LOGIC_OFFSET = 100;

	// Token: 0x0400E202 RID: 57858
	private BaseActorComponent OwnActor;

	// Token: 0x0400E203 RID: 57859
	private bool IsInInteractRangeInternal;

	// Token: 0x0400E204 RID: 57860
	private bool IsInInteractForbiddenRangeInternal;

	// Token: 0x0400E205 RID: 57861
	private readonly bool IsInAdsorbRangeInternal;

	// Token: 0x0400E206 RID: 57862
	private bool IsInSightRangeInternal;

	// Token: 0x0400E207 RID: 57863
	public bool NearbyEnable;

	// Token: 0x0400E208 RID: 57864
	private bool IsEnterNearby;

	// Token: 0x0400E209 RID: 57865
	private TMap<int, int> MonitorConditionIds;

	// Token: 0x0400E20A RID: 57866
	private PawnSensoryInfoComponent PawnSensoryInfo;

	// Token: 0x0400E20B RID: 57867
	protected int ConfigId;

	// Token: 0x0400E20C RID: 57868
	private PlayerPerceptionEvent InteractEvent;

	// Token: 0x0400E20D RID: 57869
	private PlayerPerceptionEvent ForbiddenRangeEvent;

	// Token: 0x0400E20E RID: 57870
	[Nullable(1)]
	private readonly Dictionary<int, PlayerPerceptionEvent> InteractEventWithTagsInternal = new Dictionary<int, PlayerPerceptionEvent>();

	// Token: 0x0400E20F RID: 57871
	[Nullable(1)]
	private readonly Dictionary<int, PlayerPerceptionEvent> OffsetOptionInteractEvent = new Dictionary<int, PlayerPerceptionEvent>();

	// Token: 0x0400E210 RID: 57872
	[Nullable(1)]
	private readonly HashSet<int> OptionWithOffsetInRange = new HashSet<int>();

	// Token: 0x0400E211 RID: 57873
	private PlayerPerceptionEvent SightEvent;

	// Token: 0x0400E212 RID: 57874
	private PlayerPerceptionEvent GuideEvent;
}
