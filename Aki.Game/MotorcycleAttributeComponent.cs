using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002869 RID: 10345
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleAttributeComponent : CharacterAttributeComponent
{
	// Token: 0x17002AC2 RID: 10946
	// (get) Token: 0x0601A322 RID: 107298 RVA: 0x0081A287 File Offset: 0x00818487
	// (set) Token: 0x0601A323 RID: 107299 RVA: 0x0081A28F File Offset: 0x0081848F
	protected bool BeRidden
	{
		get
		{
			return this.BeRiddenInternal;
		}
		set
		{
			if (this.BeRiddenInternal == value)
			{
				return;
			}
			this.BeRiddenInternal = value;
			this.RefreshRecoverSpEnBuff();
		}
	}

	// Token: 0x17002AC3 RID: 10947
	// (get) Token: 0x0601A324 RID: 107300 RVA: 0x0081A2A8 File Offset: 0x008184A8
	// (set) Token: 0x0601A325 RID: 107301 RVA: 0x0081A2B0 File Offset: 0x008184B0
	protected bool TwoWheelOnGround
	{
		get
		{
			return this.TwoWheelOnGroundInternal;
		}
		set
		{
			if (value)
			{
				if (this.TwoWheelOnGroundTimer != null)
				{
					this.TwoWheelOnGroundTimer.Remove();
					this.TwoWheelOnGroundTimer = null;
				}
				this.TwoWheelOnGroundInternal = true;
				this.RefreshRecoverSpEnBuff();
				return;
			}
			if (this.TwoWheelOnGroundTimer != null)
			{
				return;
			}
			this.TwoWheelOnGroundTimer = TimerSystem.Instance.Delay(delegate(float id)
			{
				this.TwoWheelOnGroundTimer = null;
				this.TwoWheelOnGroundInternal = false;
				this.RefreshRecoverSpEnBuff();
			}, MotorcycleAttributeComponent.CANNOT_RECOVER_SP_EN_TIMER, null, null, true, 1f);
		}
	}

	// Token: 0x17002AC4 RID: 10948
	// (get) Token: 0x0601A326 RID: 107302 RVA: 0x0081A31B File Offset: 0x0081851B
	// (set) Token: 0x0601A327 RID: 107303 RVA: 0x0081A323 File Offset: 0x00818523
	protected bool NeedRecoverSpEn
	{
		get
		{
			return this.NeedRecoverSpEnInternal;
		}
		set
		{
			if (this.NeedRecoverSpEnInternal == value)
			{
				return;
			}
			this.NeedRecoverSpEnInternal = value;
			this.RefreshRecoverSpEnBuff();
		}
	}

	// Token: 0x17002AC5 RID: 10949
	// (get) Token: 0x0601A328 RID: 107304 RVA: 0x0081A33C File Offset: 0x0081853C
	// (set) Token: 0x0601A329 RID: 107305 RVA: 0x0081A344 File Offset: 0x00818544
	protected bool BuffForRecoverSpEn
	{
		get
		{
			return this.BuffForRecoverSpEnInternal;
		}
		set
		{
			if (this.BuffForRecoverSpEnInternal == value)
			{
				return;
			}
			this.BuffForRecoverSpEnInternal = value;
			if (!value)
			{
				foreach (long buffId in (this.TagComp != null && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点8"])) ? MotorcycleAttributeComponent.SpecialEnergyBuffIdsUpgraded : MotorcycleAttributeComponent.SpecialEnergyBuffIds)
				{
					CharacterBuffComponent buffComponent = base.BuffComponent;
					if (buffComponent != null)
					{
						buffComponent.RemoveBuff(buffId, -1, "蓄能飞跃体力", null, null, null);
					}
				}
				return;
			}
			long[] array2 = (this.TagComp != null && this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.科技树.战斗相关.科技树3节点8"])) ? MotorcycleAttributeComponent.SpecialEnergyBuffIdsUpgraded : MotorcycleAttributeComponent.SpecialEnergyBuffIds;
			CharacterBuffComponent buffComponent2 = base.BuffComponent;
			if (buffComponent2 == null)
			{
				return;
			}
			buffComponent2.AddBuff(array2[0], new AddBuffParam
			{
				InstigatorId = base.BuffComponent.CreatureDataId,
				Reason = "蓄能飞跃体力"
			});
		}
	}

	// Token: 0x17002AC6 RID: 10950
	// (get) Token: 0x0601A32A RID: 107306 RVA: 0x0081A444 File Offset: 0x00818644
	// (set) Token: 0x0601A32B RID: 107307 RVA: 0x0081A44C File Offset: 0x0081864C
	protected bool SpEnEmpty
	{
		get
		{
			return this.SpEnEmptyInternal;
		}
		set
		{
			if (this.SpEnEmptyInternal == value)
			{
				return;
			}
			this.SpEnEmptyInternal = value;
			if (value)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用蓄力跳.能量耗尽"]));
				return;
			}
			else
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 == null)
				{
					return;
				}
				tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用蓄力跳.能量耗尽"]));
				return;
			}
		}
	}

	// Token: 0x0601A32C RID: 107308 RVA: 0x0081A4B8 File Offset: 0x008186B8
	protected override bool OnStart()
	{
		bool flag = base.OnStart();
		if (!flag)
		{
			return flag;
		}
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.AddMotorListen();
		return true;
	}

	// Token: 0x0601A32D RID: 107309 RVA: 0x0081A4E9 File Offset: 0x008186E9
	protected override bool OnEnd()
	{
		this.RemoveMotorListen();
		if (this.TwoWheelOnGroundTimer != null)
		{
			this.TwoWheelOnGroundTimer.Remove();
			this.TwoWheelOnGroundTimer = null;
		}
		return base.OnEnd();
	}

	// Token: 0x0601A32E RID: 107310 RVA: 0x0081A514 File Offset: 0x00818714
	private void AddMotorListen()
	{
		VehiclePerformComponent component = base.Entity.GetComponent<VehiclePerformComponent>();
		this.BeRidden = (((component != null) ? component.Driver : null) != null);
		EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		MotorcycleMoveComponent component2 = base.Entity.GetComponent<MotorcycleMoveComponent>();
		EMotorSubState? emotorSubState = (component2 != null) ? new EMotorSubState?(component2.MotorSubState) : null;
		EMotorSubState? emotorSubState2 = emotorSubState;
		EMotorSubState emotorSubState3 = EMotorSubState.TwoWheelMoving;
		bool twoWheelOnGround;
		if (!(emotorSubState2.GetValueOrDefault() == emotorSubState3 & emotorSubState2 != null))
		{
			emotorSubState2 = emotorSubState;
			emotorSubState3 = EMotorSubState.Stop;
			twoWheelOnGround = (emotorSubState2.GetValueOrDefault() == emotorSubState3 & emotorSubState2 != null);
		}
		else
		{
			twoWheelOnGround = true;
		}
		this.TwoWheelOnGround = twoWheelOnGround;
		EventSystem.Instance.AddWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateModeChanged));
		this.NeedRecoverSpEn = (base.GetCurrentValue(EAttributeType.SpecialEnergy1) < base.GetCurrentValue(EAttributeType.SpecialEnergy1Max));
		base.AddListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttr62Changed), null);
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁止蓄力能量恢复"], new BaseTagComponent.TTagSwitchedCallback(this.OnBanSpEnRecoverTagChanged), null);
		}
		this.RefreshRecoverSpEnBuff();
	}

	// Token: 0x0601A32F RID: 107311 RVA: 0x0081A644 File Offset: 0x00818844
	private void RemoveMotorListen()
	{
		EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		EventSystem.Instance.RemoveWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, new Action<EMotorSubState, EMotorSubState>(this.MotorSubStateModeChanged));
		base.RemoveListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttr62Changed));
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null)
		{
			return;
		}
		tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁止蓄力能量恢复"], new BaseTagComponent.TTagSwitchedCallback(this.OnBanSpEnRecoverTagChanged));
	}

	// Token: 0x0601A330 RID: 107312 RVA: 0x0081A6D8 File Offset: 0x008188D8
	private void RefreshRecoverSpEnBuff()
	{
		this.BuffForRecoverSpEn = ((this.TagComp == null || !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁止蓄力能量恢复"])) && this.BeRidden && this.NeedRecoverSpEn && this.TwoWheelOnGround);
	}

	// Token: 0x0601A331 RID: 107313 RVA: 0x0081A728 File Offset: 0x00818928
	[NullableContext(2)]
	private void OnVehicleDriverChange(Entity oldDriver, Entity newDriver)
	{
		this.BeRidden = (newDriver != null);
	}

	// Token: 0x0601A332 RID: 107314 RVA: 0x0081A734 File Offset: 0x00818934
	private void MotorSubStateModeChanged(EMotorSubState newState, EMotorSubState oldState)
	{
		this.TwoWheelOnGround = (newState == EMotorSubState.TwoWheelMoving || newState == EMotorSubState.Stop);
	}

	// Token: 0x0601A333 RID: 107315 RVA: 0x0081A747 File Offset: 0x00818947
	private void OnAttr62Changed(EAttributeType attrId, float newValue, float oldValue)
	{
		this.NeedRecoverSpEn = (newValue < base.GetCurrentValue(EAttributeType.SpecialEnergy1Max));
		this.SpEnEmpty = (newValue < 100f);
	}

	// Token: 0x0601A334 RID: 107316 RVA: 0x0081A768 File Offset: 0x00818968
	private void OnBanSpEnRecoverTagChanged(int tagId, bool tagExist)
	{
		this.RefreshRecoverSpEnBuff();
	}

	// Token: 0x0601A335 RID: 107317 RVA: 0x0081A770 File Offset: 0x00818970
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleAttributeComponent motorcycleAttributeComponent = (MotorcycleAttributeComponent)componentTemplate;
		if (motorcycleAttributeComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.BeRiddenInternal = motorcycleAttributeComponent.BeRiddenInternal;
		if (motorcycleAttributeComponent.TwoWheelOnGroundTimer == null)
		{
			this.TwoWheelOnGroundTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TwoWheelOnGroundTimer), "TwoWheelOnGroundTimer"))
		{
			return false;
		}
		this.TwoWheelOnGroundInternal = motorcycleAttributeComponent.TwoWheelOnGroundInternal;
		this.NeedRecoverSpEnInternal = motorcycleAttributeComponent.NeedRecoverSpEnInternal;
		this.BuffForRecoverSpEnInternal = motorcycleAttributeComponent.BuffForRecoverSpEnInternal;
		this.SpEnEmptyInternal = motorcycleAttributeComponent.SpEnEmptyInternal;
		return true;
	}

	// Token: 0x17002AC7 RID: 10951
	// (get) Token: 0x0601A336 RID: 107318 RVA: 0x0081A822 File Offset: 0x00818A22
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AC8 RID: 10952
	// (get) Token: 0x0601A337 RID: 107319 RVA: 0x0081A825 File Offset: 0x00818A25
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AC9 RID: 10953
	// (get) Token: 0x0601A338 RID: 107320 RVA: 0x0081A828 File Offset: 0x00818A28
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ACA RID: 10954
	// (get) Token: 0x0601A339 RID: 107321 RVA: 0x0081A82B File Offset: 0x00818A2B
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ACB RID: 10955
	// (get) Token: 0x0601A33A RID: 107322 RVA: 0x0081A82E File Offset: 0x00818A2E
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ACC RID: 10956
	// (get) Token: 0x0601A33B RID: 107323 RVA: 0x0081A831 File Offset: 0x00818A31
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002ACD RID: 10957
	// (get) Token: 0x0601A33C RID: 107324 RVA: 0x0081A834 File Offset: 0x00818A34
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E5F4 RID: 58868
	[StaticVariableRuleIgnore]
	private static readonly long[] SpecialEnergyBuffIds = new long[]
	{
		7100000056L,
		7100000057L,
		7100000058L
	};

	// Token: 0x0400E5F5 RID: 58869
	[StaticVariableRuleIgnore]
	private static readonly long[] SpecialEnergyBuffIdsUpgraded = new long[]
	{
		7100000059L,
		7100000060L,
		7100000061L
	};

	// Token: 0x0400E5F6 RID: 58870
	[StaticVariableRuleIgnore]
	private static float CANNOT_RECOVER_SP_EN_TIMER = 500f;

	// Token: 0x0400E5F7 RID: 58871
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400E5F8 RID: 58872
	private bool BeRiddenInternal;

	// Token: 0x0400E5F9 RID: 58873
	[Nullable(2)]
	private TimerHandle TwoWheelOnGroundTimer;

	// Token: 0x0400E5FA RID: 58874
	private bool TwoWheelOnGroundInternal;

	// Token: 0x0400E5FB RID: 58875
	private bool NeedRecoverSpEnInternal;

	// Token: 0x0400E5FC RID: 58876
	private bool BuffForRecoverSpEnInternal;

	// Token: 0x0400E5FD RID: 58877
	private bool SpEnEmptyInternal;
}
