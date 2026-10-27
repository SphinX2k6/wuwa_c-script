using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002E21 RID: 11809
[NullableContext(1)]
[Nullable(0)]
public class AnimalDeathSyncComponent : BaseDeathComponent
{
	// Token: 0x06018DEE RID: 101870 RVA: 0x00667D04 File Offset: 0x00665F04
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.UnifiedStateComponent = base.Entity.CheckGetComponent<BaseUnifiedStateComponent>();
		EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		if (base.Entity.CheckGetComponent<CreatureDataComponent>().GetLivingStatus().GetValueOrDefault() == LivingStatus.Dead)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.ExecuteDeath(null);
			}, null, null);
		}
		this.HadPlayDeathAnim = false;
		return true;
	}

	// Token: 0x06018DEF RID: 101871 RVA: 0x00667D98 File Offset: 0x00665F98
	private void OnBeHit(global::HitInformation hitData, HitContext hitContext)
	{
		if (hitData.DamageId == 0L)
		{
			return;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.通用无敌"]) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
		{
			return;
		}
		CharacterAiComponent component = base.Entity.GetComponent<CharacterAiComponent>();
		if (component != null)
		{
			component.DisableAi("动物死亡");
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		CreatureController.Instance.AnimalDieRequest(base.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId(), base.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy);
	}

	// Token: 0x06018DF0 RID: 101872 RVA: 0x00667E51 File Offset: 0x00666051
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<global::HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		return true;
	}

	// Token: 0x06018DF1 RID: 101873 RVA: 0x00667E74 File Offset: 0x00666074
	public override bool ExecuteDeath(long? preMessageId)
	{
		if (!base.ExecuteDeath(preMessageId))
		{
			return false;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null)
		{
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]));
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null)
		{
			unifiedStateComponent.ResetCharState();
		}
		this.PlayDieAnimation();
		EventSystem.Instance.Emit<int>(EEventName.CharOnRoleDead, base.Entity.Id);
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharOnRoleDeadTargetSelf);
		return true;
	}

	// Token: 0x06018DF2 RID: 101874 RVA: 0x00667EFC File Offset: 0x006660FC
	public void PlayDieAnimation()
	{
		if (this.HadPlayDeathAnim)
		{
			return;
		}
		this.HadPlayDeathAnim = true;
		if (!this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不播放死亡动画"]))
		{
			BaseMontageComponent montageComponent = this.MontageComponent;
			if (montageComponent != null && montageComponent.Valid)
			{
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.消失"]))
				{
					TimerSystem.Instance.Delay(new TTimerAction(this.OnDeathEnded), 1600f, null, null, true, 1f);
					return;
				}
				if (this.UnifiedStateComponent.PositionState == global::ECharPositionState.Water)
				{
					base.PlayDeathMontageWithType(ECharacterDeathMontageType.DieInWater, new Action<bool>(this.OnDeathEnded), null, new bool?(true));
					return;
				}
				base.PlayDeathMontageWithType(ECharacterDeathMontageType.Die, new Action<bool>(this.OnDeathEnded), null, new bool?(true));
				return;
			}
		}
		this.OnDeathEnded(0f);
	}

	// Token: 0x06018DF3 RID: 101875 RVA: 0x00667FEC File Offset: 0x006661EC
	public void OnDeathEnded(float delta)
	{
		this.OnDeathEndedInternal();
	}

	// Token: 0x06018DF4 RID: 101876 RVA: 0x00667FF4 File Offset: 0x006661F4
	public void OnDeathEnded(bool bInterrupted)
	{
		this.OnDeathEndedInternal();
	}

	// Token: 0x06018DF5 RID: 101877 RVA: 0x00667FFC File Offset: 0x006661FC
	private void OnDeathEndedInternal()
	{
		base.Entity.Disable("[BaseAttributeComponent.DieAnimationFinished] 死亡动画播放完后隐藏");
		BaseAnimationComponent component = base.Entity.GetComponent<BaseAnimationComponent>();
		if (component != null)
		{
			component.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.Death);
		}
		CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
		this.HadPlayDeathAnim = false;
	}

	// Token: 0x06018DF6 RID: 101878 RVA: 0x00668048 File Offset: 0x00666248
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AnimalDeathSyncComponent animalDeathSyncComponent = (AnimalDeathSyncComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (animalDeathSyncComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (animalDeathSyncComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HadPlayDeathAnim"))
		{
			this.HadPlayDeathAnim = animalDeathSyncComponent.HadPlayDeathAnim;
		}
		return true;
	}

	// Token: 0x0400BA88 RID: 47752
	private const int DISAPPEAR_REMOVE_DELAY = 1600;

	// Token: 0x0400BA89 RID: 47753
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400BA8A RID: 47754
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400BA8B RID: 47755
	private bool HadPlayDeathAnim;
}
