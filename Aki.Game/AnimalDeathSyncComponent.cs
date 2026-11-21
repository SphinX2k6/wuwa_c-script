using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200237D RID: 9085
[NullableContext(1)]
[Nullable(0)]
public class AnimalDeathSyncComponent : BaseDeathComponent
{
	// Token: 0x060166B0 RID: 91824 RVA: 0x0068DCCC File Offset: 0x0068BECC
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

	// Token: 0x060166B1 RID: 91825 RVA: 0x0068DD60 File Offset: 0x0068BF60
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

	// Token: 0x060166B2 RID: 91826 RVA: 0x0068DE19 File Offset: 0x0068C019
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<global::HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, new Action<global::HitInformation, HitContext>(this.OnBeHit));
		return true;
	}

	// Token: 0x060166B3 RID: 91827 RVA: 0x0068DE3C File Offset: 0x0068C03C
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

	// Token: 0x060166B4 RID: 91828 RVA: 0x0068DEC4 File Offset: 0x0068C0C4
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

	// Token: 0x060166B5 RID: 91829 RVA: 0x0068DFB4 File Offset: 0x0068C1B4
	public void OnDeathEnded(float delta)
	{
		this.OnDeathEndedInternal();
	}

	// Token: 0x060166B6 RID: 91830 RVA: 0x0068DFBC File Offset: 0x0068C1BC
	public void OnDeathEnded(bool bInterrupted)
	{
		this.OnDeathEndedInternal();
	}

	// Token: 0x060166B7 RID: 91831 RVA: 0x0068DFC4 File Offset: 0x0068C1C4
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

	// Token: 0x060166B8 RID: 91832 RVA: 0x0068E010 File Offset: 0x0068C210
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AnimalDeathSyncComponent animalDeathSyncComponent = (AnimalDeathSyncComponent)componentTemplate;
		if (animalDeathSyncComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (animalDeathSyncComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		this.HadPlayDeathAnim = animalDeathSyncComponent.HadPlayDeathAnim;
		return true;
	}

	// Token: 0x170022E7 RID: 8935
	// (get) Token: 0x060166B9 RID: 91833 RVA: 0x0068E092 File Offset: 0x0068C292
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170022E8 RID: 8936
	// (get) Token: 0x060166BA RID: 91834 RVA: 0x0068E095 File Offset: 0x0068C295
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BE16 RID: 48662
	private const int DISAPPEAR_REMOVE_DELAY = 1600;

	// Token: 0x0400BE17 RID: 48663
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400BE18 RID: 48664
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400BE19 RID: 48665
	private bool HadPlayDeathAnim;
}
