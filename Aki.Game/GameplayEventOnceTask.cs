using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E5C RID: 11868
public class GameplayEventOnceTask : IGameplayEventTask
{
	// Token: 0x060194DD RID: 103645 RVA: 0x0068276C File Offset: 0x0068096C
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

	// Token: 0x060194DE RID: 103646 RVA: 0x006827BC File Offset: 0x006809BC
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

	// Token: 0x0400BC1F RID: 48159
	private int TagId;

	// Token: 0x0400BC20 RID: 48160
	[Nullable(2)]
	private TGameplayEventCallback Callback;

	// Token: 0x0400BC21 RID: 48161
	[Nullable(2)]
	private BaseAbilityComponent AbilityComponent;

	// Token: 0x0400BC22 RID: 48162
	private bool Ended;
}
