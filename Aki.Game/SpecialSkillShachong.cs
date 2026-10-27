using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200319B RID: 12699
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillShachong : SpecialSkillBase
{
	// Token: 0x0601B596 RID: 112022 RVA: 0x007788EE File Offset: 0x00776AEE
	[NullableContext(1)]
	public SpecialSkillShachong(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B597 RID: 112023 RVA: 0x007788F8 File Offset: 0x00776AF8
	public override void OnStart()
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName("Grid_Navigation");
		if (dynamicFName != null)
		{
			this.ActorStreamingSource = GameModeModel.CreateIndependentStreamingSource(new FName[]
			{
				dynamicFName.Value
			}, 10000f, EStreamingSourcePriority.Highest);
		}
		this.ActorComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterActorComponent>();
		FName? dynamicFName2 = FNameUtil.GetDynamicFName("Root");
		AActor actorStreamingSource = this.ActorStreamingSource;
		if (actorStreamingSource != null && actorStreamingSource.IsValid() && this.ActorComp != null && dynamicFName2 != null)
		{
			this.ActorStreamingSource.D_K2_SetActorLocation(this.ActorComp.GetSocketLocation(dynamicFName2.Value), false, ref WorldGlobal.SweepHitResult, true);
		}
		this.AbilityComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterAbilityComponent>();
		this.TagId = GameplayTagUtils.GetTagIdByName("怪物.ML1WeiZuoShenWangMd00601.功能标签.变招点");
		CharacterAbilityComponent abilityComp = this.AbilityComp;
		if (abilityComp == null)
		{
			return;
		}
		abilityComp.AddGameplayEventListener(this.TagId, new TGameplayEventCallback(this.OnEvent));
	}

	// Token: 0x0601B598 RID: 112024 RVA: 0x007789F4 File Offset: 0x00776BF4
	[NullableContext(1)]
	private void OnEvent(int tagId, FGameplayEventData payload)
	{
		if (this.ActorComp != null)
		{
			AActor actorStreamingSource = this.ActorStreamingSource;
			if (actorStreamingSource != null && actorStreamingSource.IsValid())
			{
				FName? dynamicFName = FNameUtil.GetDynamicFName("Root");
				if (dynamicFName == null)
				{
					return;
				}
				this.ActorStreamingSource.D_K2_SetActorLocation(this.ActorComp.GetSocketLocation(dynamicFName.Value), false, ref WorldGlobal.SweepHitResult, true);
				return;
			}
		}
	}

	// Token: 0x0601B599 RID: 112025 RVA: 0x00778A5C File Offset: 0x00776C5C
	public override void OnEnd()
	{
		AActor actorStreamingSource = this.ActorStreamingSource;
		if (actorStreamingSource != null && actorStreamingSource.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = this.ActorStreamingSource.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent != null && uworldPartitionStreamingSourceComponent.IsValid())
			{
				uworldPartitionStreamingSourceComponent.DisableStreamingSource();
			}
			ActorSystem.Instance.Put("SpecialSkillShachong.OnEnd", this.ActorStreamingSource, null);
			this.ActorStreamingSource = null;
		}
		this.ActorComp = null;
		CharacterAbilityComponent abilityComp = this.AbilityComp;
		if (abilityComp != null)
		{
			abilityComp.RemoveGameplayEventListener(this.TagId, new TGameplayEventCallback(this.OnEvent));
		}
		this.AbilityComp = null;
	}

	// Token: 0x0400D5FD RID: 54781
	private const float LOADINGRANGE = 10000f;

	// Token: 0x0400D5FE RID: 54782
	private AActor ActorStreamingSource;

	// Token: 0x0400D5FF RID: 54783
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D600 RID: 54784
	private CharacterAbilityComponent AbilityComp;

	// Token: 0x0400D601 RID: 54785
	private int TagId;
}
