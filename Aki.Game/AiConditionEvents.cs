using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Monster.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020000DD RID: 221
[NullableContext(1)]
[Nullable(0)]
public class AiConditionEvents
{
	// Token: 0x06000CF9 RID: 3321 RVA: 0x00046320 File Offset: 0x00044520
	public AiConditionEvents(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00046348 File Offset: 0x00044548
	private void OnSceneItemDestroy(Entity entity)
	{
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		double num = Vector.DistSquared(this.AiController.CharActorComp.ActorLocationProxy, component.ActorLocationProxy);
		foreach (KeyValuePair<UKuroActorEventBinder, double> keyValuePair in this.DestroyEvents)
		{
			UKuroActorEventBinder key = keyValuePair.Key;
			double value = keyValuePair.Value;
			if (num < value)
			{
				key.Callback.Broadcast(component.Owner, true);
			}
		}
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x000463F4 File Offset: 0x000445F4
	public void AddConditionEvent(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
	{
		ConditionEventPair conditionEventPair = new ConditionEventPair();
		conditionEventPair.InitConditions(conditions, eventBinder, this.AiController.CharActorComp);
		this.ConditionEventPairs.Add(conditionEventPair);
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00046428 File Offset: 0x00044628
	public bool RemoveConditionEvent(UKuroBooleanEventBinder eventBinder)
	{
		int num = 0;
		foreach (ConditionEventPair conditionEventPair in this.ConditionEventPairs)
		{
			if (conditionEventPair.EventBinder == eventBinder)
			{
				conditionEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.ConditionEventPairs.Count)
		{
			this.ConditionEventPairs.RemoveRange(num, this.ConditionEventPairs.Count - num);
			return true;
		}
		return false;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x000464B8 File Offset: 0x000446B8
	public void AddSceneItemDestroyEvent(double distance, UKuroActorEventBinder eventBinder)
	{
		if (this.DestroyEvents.Count == 0)
		{
			EventSystem.Instance.Add<Entity>(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
		this.DestroyEvents[eventBinder] = distance * distance;
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x000464F2 File Offset: 0x000446F2
	public void RemoveSceneItemDestroyEvent(UKuroActorEventBinder eventBinder)
	{
		if (this.DestroyEvents.Remove(eventBinder) && this.DestroyEvents.Count == 0)
		{
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x0004652C File Offset: 0x0004472C
	public void Clear()
	{
		foreach (ConditionEventPair conditionEventPair in this.ConditionEventPairs)
		{
			conditionEventPair.Clear();
		}
		this.ConditionEventPairs.Clear();
		if (this.DestroyEvents.Count > 0)
		{
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
		this.DestroyEvents.Clear();
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x000465BC File Offset: 0x000447BC
	public void ResetAllConditionEvent()
	{
		foreach (ConditionEventPair conditionEventPair in this.ConditionEventPairs)
		{
			conditionEventPair.ResetConditions(false);
		}
	}

	// Token: 0x04000A5D RID: 2653
	private readonly List<ConditionEventPair> ConditionEventPairs = new List<ConditionEventPair>();

	// Token: 0x04000A5E RID: 2654
	private readonly Dictionary<UKuroActorEventBinder, double> DestroyEvents = new Dictionary<UKuroActorEventBinder, double>();

	// Token: 0x04000A5F RID: 2655
	private readonly AiController AiController;
}
