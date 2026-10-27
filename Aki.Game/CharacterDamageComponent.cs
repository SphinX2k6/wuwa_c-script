using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;

// Token: 0x02002EC0 RID: 11968
[NullableContext(2)]
[Nullable(0)]
public class CharacterDamageComponent : BaseDamageComponent
{
	// Token: 0x17002343 RID: 9027
	// (get) Token: 0x060198CA RID: 104650 RVA: 0x0069BC37 File Offset: 0x00699E37
	private new CharacterActorComponent ActorComponent
	{
		get
		{
			return this.ActorComponent as CharacterActorComponent;
		}
	}

	// Token: 0x060198CB RID: 104651 RVA: 0x0069BC44 File Offset: 0x00699E44
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.ActorComponent = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.HitComponent = base.Entity.CheckGetComponent<CharacterHitComponent>();
		this.UnifiedStateComponent = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.MoveComponent = base.Entity.GetComponent<CharacterMoveComponent>();
		this.FallingSpeedThreshold = this.GetFallingSpeedThreshold();
		return true;
	}

	// Token: 0x060198CC RID: 104652 RVA: 0x0069BCAC File Offset: 0x00699EAC
	protected override void OnTick(float delta)
	{
		CharacterMoveComponent moveComponent = this.MoveComponent;
		if ((((moveComponent != null) ? moveComponent.GravityDirect : null) ?? global::Vector.DownVectorProxy).DotProduct(this.ActorComponent.ActorVelocityProxy) >= this.FallingSpeedThreshold)
		{
			if (this.FallingStartTime == 0.0)
			{
				this.FallingStartTime = Time.Instance.WorldTimeSeconds;
				return;
			}
		}
		else
		{
			this.FallingStartTime = 0.0;
		}
	}

	// Token: 0x060198CD RID: 104653 RVA: 0x0069BD20 File Offset: 0x00699F20
	public void FallInjure()
	{
		if (!this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌"]))
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (((unifiedStateComponent != null) ? unifiedStateComponent.IsInGame : null).GetValueOrDefault() && !DeadReviveModel.Instance.SkipFallInjure)
			{
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.跌落无伤"]))
				{
					return;
				}
				CharacterMoveComponent moveComponent = this.MoveComponent;
				double num = (((moveComponent != null) ? moveComponent.GravityUp : null) ?? global::Vector.UpVectorProxy).DotProduct(this.ActorComponent.ActorVelocityProxy);
				double fallingHeight = this.GetFallingHeight();
				if (-num < this.FallingSpeedThreshold)
				{
					this.FallingStartTime = 0.0;
				}
				double num2 = (this.FallingStartTime != 0.0) ? (Time.Instance.WorldTimeSeconds - this.FallingStartTime) : 0.0;
				double num3 = Math.Ceiling(this.CalculateFallInjure(-num, fallingHeight, num2));
				UeMovementTickManageComponent component = base.Entity.GetComponent<UeMovementTickManageComponent>();
				if (component != null)
				{
					component.DumpVelocityCacheInfo("跌落伤害处理", false);
				}
				if (num3 <= 0.0)
				{
					return;
				}
				long creatureDataId = this.CreatureDataComponent.GetCreatureDataId();
				base.Entity.GetComponent<CharacterMovementSyncComponent>().CollectSampleAndSend(false);
				CreatureController.Instance.LandingDamageRequest(creatureDataId, num, (int)(num2 * 1000.0));
				EventSystem.Instance.EmitWithTarget<float, bool>(base.Entity, EEventName.CharOnFallInjure, (float)num3, false);
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (buffComponent != null)
				{
					buffComponent.RemoveBuffByEffectType(EExtraEffectId.Frozen, "跌落伤害移除冰冻buff");
				}
				this.HitComponent.NeedCalculateFallInjure = false;
				return;
			}
		}
	}

	// Token: 0x060198CE RID: 104654 RVA: 0x0069BEC0 File Offset: 0x0069A0C0
	private double CalculateFallInjure(double lastSpeedZ, double height, double time)
	{
		float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
		double num;
		if (this.CreatureDataComponent.IsRealMonster())
		{
			num = Calculation.LandingDamageCalculationMonster(height, (double)currentValue);
		}
		else
		{
			num = Calculation.LandingDamageCalculationRole(lastSpeedZ, time, (double)currentValue);
		}
		if (num <= 0.0)
		{
			return 0.0;
		}
		return num;
	}

	// Token: 0x060198CF RID: 104655 RVA: 0x0069BF20 File Offset: 0x0069A120
	private double GetFallingHeight()
	{
		if (!this.HitComponent.NeedCalculateFallInjure)
		{
			return 0.0;
		}
		double z = this.HitComponent.BeHitLocation.Z;
		double z2 = this.ActorComponent.ActorLocationProxy.Z;
		if (z <= z2)
		{
			return 0.0;
		}
		return z - z2;
	}

	// Token: 0x060198D0 RID: 104656 RVA: 0x0069BF77 File Offset: 0x0069A177
	private double GetFallingSpeedThreshold()
	{
		return (double)ConfigCommonParamById.GetIntArrayConfig("landing_damage_args_role")[1];
	}

	// Token: 0x060198D1 RID: 104657 RVA: 0x0069BF8C File Offset: 0x0069A18C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterDamageComponent characterDamageComponent = (CharacterDamageComponent)componentTemplate;
		if (base.CanResetComponentProperty("HitComponent"))
		{
			if (characterDamageComponent.HitComponent == null)
			{
				this.HitComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterHitComponent>(this.HitComponent), "HitComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (characterDamageComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComponent"))
		{
			if (characterDamageComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FallingSpeedThreshold"))
		{
			this.FallingSpeedThreshold = characterDamageComponent.FallingSpeedThreshold;
		}
		if (base.CanResetComponentProperty("FallingStartTime"))
		{
			this.FallingStartTime = characterDamageComponent.FallingStartTime;
		}
		return true;
	}

	// Token: 0x0400BEF3 RID: 48883
	private CharacterHitComponent HitComponent;

	// Token: 0x0400BEF4 RID: 48884
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400BEF5 RID: 48885
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400BEF6 RID: 48886
	private double FallingSpeedThreshold;

	// Token: 0x0400BEF7 RID: 48887
	private double FallingStartTime;
}
