using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;

// Token: 0x02002413 RID: 9235
[NullableContext(2)]
[Nullable(0)]
public class CharacterDamageComponent : BaseDamageComponent
{
	// Token: 0x170023E2 RID: 9186
	// (get) Token: 0x060171B3 RID: 94643 RVA: 0x006C1E8B File Offset: 0x006C008B
	private new CharacterActorComponent ActorComponent
	{
		get
		{
			return this.ActorComponent as CharacterActorComponent;
		}
	}

	// Token: 0x060171B4 RID: 94644 RVA: 0x006C1E98 File Offset: 0x006C0098
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

	// Token: 0x060171B5 RID: 94645 RVA: 0x006C1F00 File Offset: 0x006C0100
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

	// Token: 0x060171B6 RID: 94646 RVA: 0x006C1F74 File Offset: 0x006C0174
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

	// Token: 0x060171B7 RID: 94647 RVA: 0x006C2114 File Offset: 0x006C0314
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

	// Token: 0x060171B8 RID: 94648 RVA: 0x006C2174 File Offset: 0x006C0374
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

	// Token: 0x060171B9 RID: 94649 RVA: 0x006C21CB File Offset: 0x006C03CB
	private double GetFallingSpeedThreshold()
	{
		return (double)ConfigCommonParamById.GetIntArrayConfig("landing_damage_args_role")[1];
	}

	// Token: 0x060171BA RID: 94650 RVA: 0x006C21E0 File Offset: 0x006C03E0
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterDamageComponent characterDamageComponent = (CharacterDamageComponent)componentTemplate;
		if (characterDamageComponent.HitComponent == null)
		{
			this.HitComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComponent), "HitComponent"))
		{
			return false;
		}
		if (characterDamageComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		if (characterDamageComponent.MoveComponent == null)
		{
			this.MoveComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
		{
			return false;
		}
		this.FallingSpeedThreshold = characterDamageComponent.FallingSpeedThreshold;
		this.FallingStartTime = characterDamageComponent.FallingStartTime;
		return true;
	}

	// Token: 0x170023E3 RID: 9187
	// (get) Token: 0x060171BB RID: 94651 RVA: 0x006C2299 File Offset: 0x006C0499
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E4 RID: 9188
	// (get) Token: 0x060171BC RID: 94652 RVA: 0x006C229C File Offset: 0x006C049C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E5 RID: 9189
	// (get) Token: 0x060171BD RID: 94653 RVA: 0x006C229F File Offset: 0x006C049F
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C28E RID: 49806
	private CharacterHitComponent HitComponent;

	// Token: 0x0400C28F RID: 49807
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400C290 RID: 49808
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400C291 RID: 49809
	private double FallingSpeedThreshold;

	// Token: 0x0400C292 RID: 49810
	private double FallingStartTime;
}
