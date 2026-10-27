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
	// Token: 0x06000CF3 RID: 3315 RVA: 0x00045784 File Offset: 0x00043984
	public AiConditionEvents(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x000457AC File Offset: 0x000439AC
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

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00045858 File Offset: 0x00043A58
	public void AddConditionEvent(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
	{
		ConditionEventPair conditionEventPair = new ConditionEventPair();
		conditionEventPair.InitConditions(conditions, eventBinder, this.AiController.CharActorComp);
		this.ConditionEventPairs.Add(conditionEventPair);
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0004588C File Offset: 0x00043A8C
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

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0004591C File Offset: 0x00043B1C
	public void AddSceneItemDestroyEvent(double distance, UKuroActorEventBinder eventBinder)
	{
		if (this.DestroyEvents.Count == 0)
		{
			EventSystem.Instance.Add<Entity>(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
		this.DestroyEvents[eventBinder] = distance * distance;
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00045956 File Offset: 0x00043B56
	public void RemoveSceneItemDestroyEvent(UKuroActorEventBinder eventBinder)
	{
		if (this.DestroyEvents.Remove(eventBinder) && this.DestroyEvents.Count == 0)
		{
			EventSystem.Instance.Remove(EEventName.OnSceneItemDurabilityEmpty, new Action<Entity>(this.OnSceneItemDestroy));
		}
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00045990 File Offset: 0x00043B90
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

	// Token: 0x06000CFA RID: 3322 RVA: 0x00045A20 File Offset: 0x00043C20
	public void ResetAllConditionEvent()
	{
		foreach (ConditionEventPair conditionEventPair in this.ConditionEventPairs)
		{
			conditionEventPair.ResetConditions(false);
		}
	}

	// Token: 0x04000A55 RID: 2645
	private readonly List<ConditionEventPair> ConditionEventPairs = new List<ConditionEventPair>();

	// Token: 0x04000A56 RID: 2646
	private readonly Dictionary<UKuroActorEventBinder, double> DestroyEvents = new Dictionary<UKuroActorEventBinder, double>();

	// Token: 0x04000A57 RID: 2647
	private readonly AiController AiController;
}
