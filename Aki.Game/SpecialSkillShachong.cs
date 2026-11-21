using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002709 RID: 9993
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillShachong : SpecialSkillBase
{
	// Token: 0x060190B6 RID: 102582 RVA: 0x007A0B7A File Offset: 0x0079ED7A
	[NullableContext(1)]
	public SpecialSkillShachong(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x060190B7 RID: 102583 RVA: 0x007A0B84 File Offset: 0x0079ED84
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

	// Token: 0x060190B8 RID: 102584 RVA: 0x007A0C80 File Offset: 0x0079EE80
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

	// Token: 0x060190B9 RID: 102585 RVA: 0x007A0CE8 File Offset: 0x0079EEE8
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

	// Token: 0x0400DA80 RID: 55936
	private const float LOADINGRANGE = 10000f;

	// Token: 0x0400DA81 RID: 55937
	private AActor ActorStreamingSource;

	// Token: 0x0400DA82 RID: 55938
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DA83 RID: 55939
	private CharacterAbilityComponent AbilityComp;

	// Token: 0x0400DA84 RID: 55940
	private int TagId;
}
