using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

// Token: 0x020000F6 RID: 246
[NullableContext(1)]
[Nullable(0)]
public class AiPerceptionEvents
{
	// Token: 0x06000DE3 RID: 3555 RVA: 0x0004ECBC File Offset: 0x0004CEBC
	public AiPerceptionEvents(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
	private void OnSceneItemDestroy(Entity entity)
	{
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		if (Vector.DistSquared(this.AiController.CharActorComp.ActorLocationProxy, component.ActorLocationProxy) < (double)this.DestroyEventListenSizeSquared && !this.BroadcastSet.Contains(component.Entity.Id))
		{
			this.BroadcastSet.Add(component.Entity.Id);
			this.DestroyEvent.Callback.Broadcast(component.Owner, true);
		}
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0004EE58 File Offset: 0x0004D058
	public void Clear(bool force = false)
	{
		this.AiHateAddEntities.Clear();
		this.AiHateRemoveEntities.Clear();
		this.AiHateRemoveEntityIds.Clear();
		this.AiPerceptionAddEntities.Clear();
		this.AiPerceptionRemoveEntities.Clear();
		this.AiPerceptionRemoveEntityIds.Clear();
		this.AiHateOutRangeEntities.Clear();
		this.AiHateAddActors.Empty(true);
		this.AiHateRemoveActors.Empty(true);
		this.AiHateRemoveActorIds.Empty(true);
		this.AiPerceptionAddActors.Empty(true);
		this.AiPerceptionRemoveActors.Empty(true);
		this.AiPerceptionRemoveActorIds.Empty(true);
		this.AiHateOutRangeAddActors.Empty(true);
		if (!force)
		{
			return;
		}
		this.HateEvents.Clear();
		this.PerceptionEvents.Clear();
		this.HateOutRangeEvents.Clear();
		if (this.DestroyEvent != null)
		{
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
			this.DestroyEvent = null;
			this.BroadcastSet.Clear();
		}
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x0004EF61 File Offset: 0x0004D161
	public void TickPerception()
	{
		if (this.PerceptionEvents.Count == 0)
		{
			return;
		}
		this.CallPerception();
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x0004EF77 File Offset: 0x0004D177
	public void TickHate()
	{
		if (this.HateOutRangeEvents.Count > 0)
		{
			this.CallHateOutRange();
		}
		if (this.HateEvents.Count > 0)
		{
			this.CallHate();
		}
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x0004EFA4 File Offset: 0x0004D1A4
	private void CallHateOutRange()
	{
		foreach (int item in this.AiHateAddEntities)
		{
			int num = this.AiHateOutRangeEntities.IndexOf(item);
			if (num != -1)
			{
				this.AiHateOutRangeEntities.RemoveAt(num);
			}
		}
		if (this.AiHateOutRangeEntities.Count > 0)
		{
			this.PrintBroadInfo("超出距离被伤害没添加仇恨事件广播", this.AiHateOutRangeEntities, null);
			this.MigrateActor(this.AiHateOutRangeEntities, this.AiHateOutRangeAddActors);
			foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder in this.HateOutRangeEvents)
			{
				ukuroPerceptionEventBinder.Callback.Broadcast(this.AiHateOutRangeAddActors, this.EmptyActors, this.EmptyActorIds, 0);
			}
			this.AiHateOutRangeEntities.Clear();
			this.AiHateOutRangeAddActors.Empty(true);
		}
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
	private void CallHate()
	{
		bool flag = this.AiHateAddEntities.Count > 0;
		bool flag2 = this.AiHateRemoveEntities.Count > 0;
		if (flag || flag2)
		{
			int count = this.AiController.AiHateList.GetHatredMap().Count;
			if (!flag)
			{
				this.PrintBroadInfo("仇恨广播", null, this.AiHateRemoveEntities);
				this.MigrateActor(this.AiHateRemoveEntities, this.AiHateRemoveActors);
				this.MigrateActorIds(this.AiHateRemoveEntityIds, this.AiHateRemoveActorIds);
				foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder in this.HateEvents)
				{
					ukuroPerceptionEventBinder.Callback.Broadcast(this.EmptyActors, this.AiHateRemoveActors, this.AiHateRemoveActorIds, count);
				}
				this.AiHateRemoveEntities.Clear();
				this.AiHateRemoveActors.Empty(true);
				this.AiHateRemoveEntityIds.Clear();
				this.AiHateRemoveActorIds.Empty(true);
				return;
			}
			if (!flag2)
			{
				this.PrintBroadInfo("仇恨广播", this.AiHateAddEntities, null);
				this.MigrateActor(this.AiHateAddEntities, this.AiHateAddActors);
				foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder2 in this.HateEvents)
				{
					ukuroPerceptionEventBinder2.Callback.Broadcast(this.AiHateAddActors, this.EmptyActors, this.EmptyActorIds, count);
				}
				this.AiHateAddEntities.Clear();
				this.AiHateAddActors.Empty(true);
				return;
			}
			this.PrintBroadInfo("仇恨广播", this.AiHateAddEntities, this.AiHateRemoveEntities);
			this.MigrateActor(this.AiHateAddEntities, this.AiHateAddActors);
			this.MigrateActor(this.AiHateRemoveEntities, this.AiHateRemoveActors);
			this.MigrateActorIds(this.AiHateRemoveEntityIds, this.AiHateRemoveActorIds);
			foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder3 in this.HateEvents)
			{
				ukuroPerceptionEventBinder3.Callback.Broadcast(this.AiHateAddActors, this.AiHateRemoveActors, this.AiHateRemoveActorIds, count);
			}
			this.AiHateAddEntities.Clear();
			this.AiHateRemoveEntities.Clear();
			this.AiHateAddActors.Empty(true);
			this.AiHateRemoveActors.Empty(true);
			this.AiHateRemoveEntityIds.Clear();
			this.AiHateRemoveActorIds.Empty(true);
		}
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x0004F344 File Offset: 0x0004D544
	private void CallPerception()
	{
		bool flag = this.AiPerceptionAddEntities.Count > 0;
		bool flag2 = this.AiPerceptionRemoveEntities.Count > 0;
		if (flag || flag2)
		{
			int count = this.AiController.AiPerception.AllEnemies.Count;
			if (!flag)
			{
				this.PrintBroadInfo("感知广播", null, this.AiPerceptionRemoveEntities);
				this.MigrateActor(this.AiPerceptionRemoveEntities, this.AiPerceptionRemoveActors);
				this.MigrateActorIds(this.AiPerceptionRemoveEntityIds, this.AiPerceptionRemoveActorIds);
				foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder in this.PerceptionEvents)
				{
					ukuroPerceptionEventBinder.Callback.Broadcast(this.EmptyActors, this.AiPerceptionRemoveActors, this.AiPerceptionRemoveActorIds, count);
				}
				this.AiPerceptionRemoveEntities.Clear();
				this.AiPerceptionRemoveActors.Empty(true);
				this.AiPerceptionRemoveEntityIds.Clear();
				this.AiPerceptionRemoveActorIds.Empty(true);
				return;
			}
			if (!flag2)
			{
				this.PrintBroadInfo("感知广播", this.AiPerceptionAddEntities, null);
				this.MigrateActor(this.AiPerceptionAddEntities, this.AiPerceptionAddActors);
				foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder2 in this.PerceptionEvents)
				{
					ukuroPerceptionEventBinder2.Callback.Broadcast(this.AiPerceptionAddActors, this.EmptyActors, this.EmptyActorIds, count);
				}
				this.AiPerceptionAddEntities.Clear();
				this.AiPerceptionAddActors.Empty(true);
				return;
			}
			this.PrintBroadInfo("感知广播", this.AiPerceptionAddEntities, this.AiPerceptionRemoveEntities);
			this.MigrateActor(this.AiPerceptionAddEntities, this.AiPerceptionAddActors);
			this.MigrateActor(this.AiPerceptionRemoveEntities, this.AiPerceptionRemoveActors);
			this.MigrateActorIds(this.AiPerceptionRemoveEntityIds, this.AiPerceptionRemoveActorIds);
			foreach (UKuroPerceptionEventBinder ukuroPerceptionEventBinder3 in this.PerceptionEvents)
			{
				ukuroPerceptionEventBinder3.Callback.Broadcast(this.AiPerceptionAddActors, this.AiPerceptionRemoveActors, this.AiPerceptionRemoveActorIds, count);
			}
			this.AiPerceptionAddEntities.Clear();
			this.AiPerceptionRemoveEntities.Clear();
			this.AiPerceptionAddActors.Empty(true);
			this.AiPerceptionRemoveActors.Empty(true);
			this.AiPerceptionRemoveEntityIds.Clear();
			this.AiPerceptionRemoveActorIds.Empty(true);
		}
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
	private void MigrateActor(List<int> entities, TArray<AActor> outActors)
	{
		foreach (int id in entities)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(id);
			if (entity != null && entity.Active && entity.Valid)
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				AActor aactor = (component != null) ? component.Owner : null;
				if (aactor != null)
				{
					outActors.Add(aactor);
				}
			}
		}
		entities.Clear();
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x0004F664 File Offset: 0x0004D864
	private void MigrateActorIds(List<int> entityIds, TArray<int> outIds)
	{
		foreach (int value in entityIds)
		{
			outIds.Add(value);
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x0004F6B4 File Offset: 0x0004D8B4
	public void AddAiHateEvent(UKuroPerceptionEventBinder handler)
	{
		if (this.HateEvents.Contains(handler))
		{
			return;
		}
		if (this.AiController.AiHateList != null)
		{
			foreach (KeyValuePair<int, HatredItem> keyValuePair in this.AiController.AiHateList.GetHatredMap())
			{
				this.AiController.AiPerceptionEvents.CollectAiHateEventById(true, keyValuePair.Key);
			}
		}
		this.HateEvents.Add(handler);
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x0004F74C File Offset: 0x0004D94C
	private void CollectEvent(bool addOrRemove, Entity entity, List<int> addEntities, List<int> removeEntities)
	{
		if (addOrRemove && addEntities != null)
		{
			int num = removeEntities.IndexOf(entity.Id);
			if (num != -1)
			{
				removeEntities.RemoveAt(num);
				addEntities.Add(entity.Id);
				return;
			}
			if (addEntities.Contains(entity.Id))
			{
				return;
			}
			addEntities.Add(entity.Id);
			return;
		}
		else
		{
			if (addEntities != null)
			{
				int num2 = addEntities.IndexOf(entity.Id);
				if (num2 != -1)
				{
					addEntities.RemoveAt(num2);
					removeEntities.Add(entity.Id);
					return;
				}
			}
			if (removeEntities.Contains(entity.Id))
			{
				return;
			}
			removeEntities.Add(entity.Id);
			return;
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
	private void CollectEventById(bool addOrRemove, int entity, [Nullable(2)] List<int> addEntities, List<int> removeEntities)
	{
		if (addOrRemove && addEntities != null)
		{
			int num = removeEntities.IndexOf(entity);
			if (num != -1)
			{
				removeEntities.RemoveAt(num);
				addEntities.Add(entity);
				return;
			}
			if (addEntities.Contains(entity))
			{
				return;
			}
			addEntities.Add(entity);
			return;
		}
		else
		{
			if (addEntities != null)
			{
				int num2 = addEntities.IndexOf(entity);
				if (num2 != -1)
				{
					addEntities.RemoveAt(num2);
					removeEntities.Add(entity);
					return;
				}
			}
			if (removeEntities.Contains(entity))
			{
				return;
			}
			removeEntities.Add(entity);
			return;
		}
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x0004F85C File Offset: 0x0004DA5C
	public void CollectAiHateEvent(bool addOrRemove, Entity entity)
	{
		this.CollectEvent(addOrRemove, entity, this.AiHateAddEntities, this.AiHateRemoveEntities);
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x0004F872 File Offset: 0x0004DA72
	public void CollectAiHateEventById(bool addOrRemove, int entityId)
	{
		this.CollectEventById(addOrRemove, entityId, this.AiHateAddEntities, this.AiHateRemoveEntityIds);
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x0004F888 File Offset: 0x0004DA88
	public void AddAiHateOutRangeEvent(UKuroPerceptionEventBinder handler)
	{
		if (this.HateOutRangeEvents.Contains(handler))
		{
			return;
		}
		this.HateOutRangeEvents.Add(handler);
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0004F8A5 File Offset: 0x0004DAA5
	public void CollectAiHateOutRangeEvent(Entity entity)
	{
		if (this.AiHateOutRangeEntities.Contains(entity.Id))
		{
			return;
		}
		this.AiHateOutRangeEntities.Add(entity.Id);
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x0004F8CC File Offset: 0x0004DACC
	public void AddAiPerceptionEvent(UKuroPerceptionEventBinder handler, bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		if (this.PerceptionEvents.Contains(handler))
		{
			return;
		}
		this.IncludeFriend = includeFriend;
		this.IncludeEnemy = includeEnemy;
		this.IncludeNeutral = includeNeutral;
		if (this.AiController.AiPerception != null)
		{
			foreach (int id in this.AiController.AiPerception.AllEnemies)
			{
				this.AiController.AiPerceptionEvents.CollectAiPerceptionEventById(true, id, ERelation.Enemy);
			}
		}
		this.PerceptionEvents.Add(handler);
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x0004F974 File Offset: 0x0004DB74
	public void SetPerceptionEventState(bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		this.IncludeFriend = includeFriend;
		this.IncludeEnemy = includeEnemy;
		this.IncludeNeutral = includeNeutral;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x0004F98B File Offset: 0x0004DB8B
	public void CollectAiPerceptionEventByActorComp(bool addOrRemove, BaseActorComponent actorComp, ERelation relation)
	{
		if (relation != ERelation.Friend)
		{
			if (relation != ERelation.Enemy)
			{
				if (!this.IncludeNeutral)
				{
					return;
				}
			}
			else if (!this.IncludeEnemy)
			{
				return;
			}
		}
		else if (!this.IncludeFriend)
		{
			return;
		}
		this.CollectEvent(addOrRemove, actorComp.Entity, this.AiPerceptionAddEntities, this.AiPerceptionRemoveEntities);
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x0004F9CB File Offset: 0x0004DBCB
	public void CollectAiPerceptionEventById(bool addOrRemove, int id, ERelation relation)
	{
		if (relation != ERelation.Friend)
		{
			if (relation != ERelation.Enemy)
			{
				if (!this.IncludeNeutral)
				{
					return;
				}
			}
			else if (!this.IncludeEnemy)
			{
				return;
			}
		}
		else if (!this.IncludeFriend)
		{
			return;
		}
		this.CollectEventById(addOrRemove, id, this.AiPerceptionAddEntities, this.AiPerceptionRemoveEntities);
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0004FA06 File Offset: 0x0004DC06
	public void CollectAiRemovePerceptionEventByEntityId(bool addOrRemove, int entityId, ERelation relation)
	{
		if (relation != ERelation.Friend)
		{
			if (relation != ERelation.Enemy)
			{
				if (!this.IncludeNeutral)
				{
					return;
				}
			}
			else if (!this.IncludeEnemy)
			{
				return;
			}
		}
		else if (!this.IncludeFriend)
		{
			return;
		}
		this.CollectEventById(addOrRemove, entityId, null, this.AiPerceptionRemoveEntityIds);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x0004FA3C File Offset: 0x0004DC3C
	public void AddSceneItemDestroyEvent(float distance, UKuroActorEventBinder eventBinder)
	{
		if (this.DestroyEvent == null)
		{
			EventSystem.Instance.Add(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
		this.DestroyEvent = eventBinder;
		this.DestroyEventListenSizeSquared = distance * distance;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x0004FA72 File Offset: 0x0004DC72
	public void RemoveSceneItemDestroyEvent(UKuroActorEventBinder eventBinder)
	{
		EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		this.DestroyEvent = null;
		this.BroadcastSet.Clear();
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x0004FAA2 File Offset: 0x0004DCA2
	public void ForceTriggerSceneItemDestroyEvent(AActor actor)
	{
		UKuroActorEventBinder destroyEvent = this.DestroyEvent;
		if (destroyEvent == null || !destroyEvent.IsValid())
		{
			return;
		}
		this.DestroyEvent.Callback.Broadcast(actor, true);
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
	public void OnSenseSceneItem(BaseActorComponent otherActorComp)
	{
		if (this.DestroyEvent == null || this.BroadcastSet.Contains(otherActorComp.Entity.Id))
		{
			return;
		}
		DurabilityComponent component = otherActorComp.Entity.GetComponent<DurabilityComponent>();
		if (component == null || !component.Valid || !component.IsDestroyed)
		{
			return;
		}
		this.BroadcastSet.Add(otherActorComp.Entity.Id);
		this.DestroyEvent.Callback.Broadcast(otherActorComp.Owner, true);
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x0004FB54 File Offset: 0x0004DD54
	[NullableContext(2)]
	private unsafe void PrintBroadInfo([Nullable(1)] string info, List<int> addIds, List<int> removeIds)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Ai;
		Entity entity = this.AiController.CharActorComp.Entity;
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("addIds", addIds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("removeIds:", removeIds);
		instance.Info(flag, entity, info, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x04000B4B RID: 2891
	private readonly List<int> AiHateAddEntities = new List<int>();

	// Token: 0x04000B4C RID: 2892
	private readonly List<int> AiHateRemoveEntities = new List<int>();

	// Token: 0x04000B4D RID: 2893
	private readonly List<int> AiHateRemoveEntityIds = new List<int>();

	// Token: 0x04000B4E RID: 2894
	private readonly List<int> AiPerceptionAddEntities = new List<int>();

	// Token: 0x04000B4F RID: 2895
	private readonly List<int> AiPerceptionRemoveEntities = new List<int>();

	// Token: 0x04000B50 RID: 2896
	private readonly List<int> AiPerceptionRemoveEntityIds = new List<int>();

	// Token: 0x04000B51 RID: 2897
	private readonly List<int> AiHateOutRangeEntities = new List<int>();

	// Token: 0x04000B52 RID: 2898
	private readonly TArray<AActor> AiHateAddActors = new TArray<AActor>();

	// Token: 0x04000B53 RID: 2899
	private readonly TArray<AActor> AiHateRemoveActors = new TArray<AActor>();

	// Token: 0x04000B54 RID: 2900
	private readonly TArray<int> AiHateRemoveActorIds = new TArray<int>();

	// Token: 0x04000B55 RID: 2901
	private readonly TArray<AActor> AiPerceptionAddActors = new TArray<AActor>();

	// Token: 0x04000B56 RID: 2902
	private readonly TArray<AActor> AiPerceptionRemoveActors = new TArray<AActor>();

	// Token: 0x04000B57 RID: 2903
	private readonly TArray<int> AiPerceptionRemoveActorIds = new TArray<int>();

	// Token: 0x04000B58 RID: 2904
	private readonly TArray<AActor> EmptyActors = new TArray<AActor>();

	// Token: 0x04000B59 RID: 2905
	private readonly TArray<int> EmptyActorIds = new TArray<int>();

	// Token: 0x04000B5A RID: 2906
	private readonly TArray<AActor> AiHateOutRangeAddActors = new TArray<AActor>();

	// Token: 0x04000B5B RID: 2907
	private readonly List<UKuroPerceptionEventBinder> HateEvents = new List<UKuroPerceptionEventBinder>();

	// Token: 0x04000B5C RID: 2908
	private readonly List<UKuroPerceptionEventBinder> PerceptionEvents = new List<UKuroPerceptionEventBinder>();

	// Token: 0x04000B5D RID: 2909
	private readonly List<UKuroPerceptionEventBinder> HateOutRangeEvents = new List<UKuroPerceptionEventBinder>();

	// Token: 0x04000B5E RID: 2910
	private readonly AiController AiController;

	// Token: 0x04000B5F RID: 2911
	private bool IncludeFriend = true;

	// Token: 0x04000B60 RID: 2912
	private bool IncludeEnemy = true;

	// Token: 0x04000B61 RID: 2913
	private bool IncludeNeutral = true;

	// Token: 0x04000B62 RID: 2914
	[Nullable(2)]
	private UKuroActorEventBinder DestroyEvent;

	// Token: 0x04000B63 RID: 2915
	private float DestroyEventListenSizeSquared;

	// Token: 0x04000B64 RID: 2916
	private readonly HashSet<int> BroadcastSet = new HashSet<int>();
}
