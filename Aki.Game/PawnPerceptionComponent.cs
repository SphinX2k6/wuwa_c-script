using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02003289 RID: 12937
[NullableContext(2)]
[Nullable(0)]
public class PawnPerceptionComponent : EntityComponent
{
	// Token: 0x170026B0 RID: 9904
	// (get) Token: 0x0601C000 RID: 114688 RVA: 0x007C81EC File Offset: 0x007C63EC
	public bool IsInInteractRange
	{
		get
		{
			return this.IsInInteractRangeInternal;
		}
	}

	// Token: 0x170026B1 RID: 9905
	// (get) Token: 0x0601C001 RID: 114689 RVA: 0x007C81F4 File Offset: 0x007C63F4
	public bool InAnyOptionWithOffsetRange
	{
		get
		{
			return this.OptionWithOffsetInRange.Count > 0;
		}
	}

	// Token: 0x170026B2 RID: 9906
	// (get) Token: 0x0601C002 RID: 114690 RVA: 0x007C8204 File Offset: 0x007C6404
	public bool IsInAdsorbRange
	{
		get
		{
			return this.IsInAdsorbRangeInternal;
		}
	}

	// Token: 0x170026B3 RID: 9907
	// (get) Token: 0x0601C003 RID: 114691 RVA: 0x007C820C File Offset: 0x007C640C
	public bool IsInSightRange
	{
		get
		{
			return this.IsInSightRangeInternal;
		}
	}

	// Token: 0x0601C004 RID: 114692 RVA: 0x007C8214 File Offset: 0x007C6414
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

	// Token: 0x0601C005 RID: 114693 RVA: 0x007C82B4 File Offset: 0x007C64B4
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

	// Token: 0x0601C006 RID: 114694 RVA: 0x007C8380 File Offset: 0x007C6580
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

	// Token: 0x0601C007 RID: 114695 RVA: 0x007C8468 File Offset: 0x007C6668
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

	// Token: 0x0601C008 RID: 114696 RVA: 0x007C84E0 File Offset: 0x007C66E0
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

	// Token: 0x0601C009 RID: 114697 RVA: 0x007C854C File Offset: 0x007C674C
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.MonitorConditionIds = new TMap<int, int>();
		this.ConfigId = base.Entity.GetComponent<CreatureDataComponent>().GetPbDataId();
		return true;
	}

	// Token: 0x0601C00A RID: 114698 RVA: 0x007C8570 File Offset: 0x007C6770
	protected override bool OnInit()
	{
		this.PawnSensoryInfo = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		return true;
	}

	// Token: 0x0601C00B RID: 114699 RVA: 0x007C8584 File Offset: 0x007C6784
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

	// Token: 0x0601C00C RID: 114700 RVA: 0x007C8644 File Offset: 0x007C6844
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

	// Token: 0x0601C00D RID: 114701 RVA: 0x007C86FC File Offset: 0x007C68FC
	protected override bool OnEnd()
	{
		if (this.IsEnterNearby)
		{
			EventSystem.Instance.Emit<Entity>(EEventName.RemoveNearbyTrack, base.Entity);
		}
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.LeaveLogicRange, new Action(this.OnLeaveLogicRange));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnUpdateNearbyEnable, new Action<bool>(this.OnUpdateNearbyEnable));
		this.InteractEvent = null;
		this.SightEvent = null;
		this.GuideEvent = null;
		this.InteractEventWithTagsInternal.Clear();
		this.MonitorConditionIds.Empty(0);
		return true;
	}

	// Token: 0x0601C00E RID: 114702 RVA: 0x007C8798 File Offset: 0x007C6998
	private void OnLeaveLogicRange()
	{
		if (this.IsEnterNearby)
		{
			this.IsEnterNearby = false;
			EventSystem.Instance.Emit<Entity>(EEventName.OnLeaveNearbyTrackRange, base.Entity);
		}
	}

	// Token: 0x0601C00F RID: 114703 RVA: 0x007C87BF File Offset: 0x007C69BF
	private void OnUpdateNearbyEnable(bool enable)
	{
		this.NearbyEnable = enable;
		this.IsEnterNearby = false;
	}

	// Token: 0x0601C010 RID: 114704 RVA: 0x007C87D0 File Offset: 0x007C69D0
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

	// Token: 0x0601C011 RID: 114705 RVA: 0x007C88F0 File Offset: 0x007C6AF0
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnPerceptionComponent pawnPerceptionComponent = (PawnPerceptionComponent)componentTemplate;
		if (base.CanResetComponentProperty("OwnActor"))
		{
			if (pawnPerceptionComponent.OwnActor == null)
			{
				this.OwnActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.OwnActor), "OwnActor"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInInteractRangeInternal"))
		{
			this.IsInInteractRangeInternal = pawnPerceptionComponent.IsInInteractRangeInternal;
		}
		if (base.CanResetComponentProperty("IsInSightRangeInternal"))
		{
			this.IsInSightRangeInternal = pawnPerceptionComponent.IsInSightRangeInternal;
		}
		if (base.CanResetComponentProperty("NearbyEnable"))
		{
			this.NearbyEnable = pawnPerceptionComponent.NearbyEnable;
		}
		if (base.CanResetComponentProperty("IsEnterNearby"))
		{
			this.IsEnterNearby = pawnPerceptionComponent.IsEnterNearby;
		}
		if (base.CanResetComponentProperty("MonitorConditionIds"))
		{
			if (pawnPerceptionComponent.MonitorConditionIds == null)
			{
				this.MonitorConditionIds = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int, int>(this.MonitorConditionIds), "MonitorConditionIds"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PawnSensoryInfo"))
		{
			if (pawnPerceptionComponent.PawnSensoryInfo == null)
			{
				this.PawnSensoryInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnSensoryInfoComponent>(this.PawnSensoryInfo), "PawnSensoryInfo"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ConfigId"))
		{
			this.ConfigId = pawnPerceptionComponent.ConfigId;
		}
		if (base.CanResetComponentProperty("InteractEvent"))
		{
			if (pawnPerceptionComponent.InteractEvent == null)
			{
				this.InteractEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.InteractEvent), "InteractEvent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InteractEventWithTagsInternal") && pawnPerceptionComponent.InteractEventWithTagsInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, PlayerPerceptionEvent>>(this.InteractEventWithTagsInternal), "InteractEventWithTagsInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OffsetOptionInteractEvent") && pawnPerceptionComponent.OffsetOptionInteractEvent != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, PlayerPerceptionEvent>>(this.OffsetOptionInteractEvent), "OffsetOptionInteractEvent"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OptionWithOffsetInRange") && pawnPerceptionComponent.OptionWithOffsetInRange != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.OptionWithOffsetInRange), "OptionWithOffsetInRange"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SightEvent"))
		{
			if (pawnPerceptionComponent.SightEvent == null)
			{
				this.SightEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.SightEvent), "SightEvent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GuideEvent"))
		{
			if (pawnPerceptionComponent.GuideEvent == null)
			{
				this.GuideEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.GuideEvent), "GuideEvent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DD5A RID: 56666
	private const int DISTANCE_OFFSET = 100;

	// Token: 0x0400DD5B RID: 56667
	private const int INTERACT_LOGIC_OFFSET = 100;

	// Token: 0x0400DD5C RID: 56668
	private BaseActorComponent OwnActor;

	// Token: 0x0400DD5D RID: 56669
	private bool IsInInteractRangeInternal;

	// Token: 0x0400DD5E RID: 56670
	private readonly bool IsInAdsorbRangeInternal;

	// Token: 0x0400DD5F RID: 56671
	private bool IsInSightRangeInternal;

	// Token: 0x0400DD60 RID: 56672
	public bool NearbyEnable;

	// Token: 0x0400DD61 RID: 56673
	private bool IsEnterNearby;

	// Token: 0x0400DD62 RID: 56674
	private TMap<int, int> MonitorConditionIds;

	// Token: 0x0400DD63 RID: 56675
	private PawnSensoryInfoComponent PawnSensoryInfo;

	// Token: 0x0400DD64 RID: 56676
	protected int ConfigId;

	// Token: 0x0400DD65 RID: 56677
	private PlayerPerceptionEvent InteractEvent;

	// Token: 0x0400DD66 RID: 56678
	[Nullable(1)]
	private readonly Dictionary<int, PlayerPerceptionEvent> InteractEventWithTagsInternal = new Dictionary<int, PlayerPerceptionEvent>();

	// Token: 0x0400DD67 RID: 56679
	[Nullable(1)]
	private readonly Dictionary<int, PlayerPerceptionEvent> OffsetOptionInteractEvent = new Dictionary<int, PlayerPerceptionEvent>();

	// Token: 0x0400DD68 RID: 56680
	[Nullable(1)]
	private readonly HashSet<int> OptionWithOffsetInRange = new HashSet<int>();

	// Token: 0x0400DD69 RID: 56681
	private PlayerPerceptionEvent SightEvent;

	// Token: 0x0400DD6A RID: 56682
	private PlayerPerceptionEvent GuideEvent;
}
