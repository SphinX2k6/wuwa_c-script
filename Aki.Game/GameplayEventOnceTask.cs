using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023AE RID: 9134
public class GameplayEventOnceTask : IGameplayEventTask
{
	// Token: 0x06016D97 RID: 93591 RVA: 0x006A8AFC File Offset: 0x006A6CFC
	[NullableContext(1)]
	public void StartTask(int tagId, TGameplayEventCallback callback, BaseAbilityComponent abilityComponent)
	{
		this.TagId = tagId;
		this.AbilityComponent = abilityComponent;
		this.Callback = delegate(int eventTagId, FGameplayEventData payload)
		{
			this.EndTask();
			callback(eventTagId, payload);
		};
		abilityComponent.AddGameplayEventListener(tagId, this.Callback);
	}

	// Token: 0x06016D98 RID: 93592 RVA: 0x006A8B4C File Offset: 0x006A6D4C
	public void EndTask()
	{
		if (this.Ended)
		{
			return;
		}
		this.Ended = true;
		if (this.Callback != null)
		{
			BaseAbilityComponent abilityComponent = this.AbilityComponent;
			if (abilityComponent != null)
			{
				abilityComponent.RemoveGameplayEventListener(this.TagId, this.Callback);
			}
		}
		this.AbilityComponent = null;
		this.Callback = null;
	}

	// Token: 0x0400BFB3 RID: 49075
	private int TagId;

	// Token: 0x0400BFB4 RID: 49076
	[Nullable(2)]
	private TGameplayEventCallback Callback;

	// Token: 0x0400BFB5 RID: 49077
	[Nullable(2)]
	private BaseAbilityComponent AbilityComponent;

	// Token: 0x0400BFB6 RID: 49078
	private bool Ended;
}
