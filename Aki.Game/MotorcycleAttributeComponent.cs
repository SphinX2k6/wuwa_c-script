using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020032F7 RID: 13047
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleAttributeComponent : CharacterAttributeComponent
{
	// Token: 0x17002748 RID: 10056
	// (get) Token: 0x0601C654 RID: 116308 RVA: 0x007F3D5B File Offset: 0x007F1F5B
	// (set) Token: 0x0601C655 RID: 116309 RVA: 0x007F3D63 File Offset: 0x007F1F63
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

	// Token: 0x17002749 RID: 10057
	// (get) Token: 0x0601C656 RID: 116310 RVA: 0x007F3D7C File Offset: 0x007F1F7C
	// (set) Token: 0x0601C657 RID: 116311 RVA: 0x007F3D84 File Offset: 0x007F1F84
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

	// Token: 0x1700274A RID: 10058
	// (get) Token: 0x0601C658 RID: 116312 RVA: 0x007F3DEF File Offset: 0x007F1FEF
	// (set) Token: 0x0601C659 RID: 116313 RVA: 0x007F3DF7 File Offset: 0x007F1FF7
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

	// Token: 0x1700274B RID: 10059
	// (get) Token: 0x0601C65A RID: 116314 RVA: 0x007F3E10 File Offset: 0x007F2010
	// (set) Token: 0x0601C65B RID: 116315 RVA: 0x007F3E18 File Offset: 0x007F2018
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

	// Token: 0x1700274C RID: 10060
	// (get) Token: 0x0601C65C RID: 116316 RVA: 0x007F3F18 File Offset: 0x007F2118
	// (set) Token: 0x0601C65D RID: 116317 RVA: 0x007F3F20 File Offset: 0x007F2120
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

	// Token: 0x0601C65E RID: 116318 RVA: 0x007F3F8C File Offset: 0x007F218C
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

	// Token: 0x0601C65F RID: 116319 RVA: 0x007F3FBD File Offset: 0x007F21BD
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

	// Token: 0x0601C660 RID: 116320 RVA: 0x007F3FE8 File Offset: 0x007F21E8
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

	// Token: 0x0601C661 RID: 116321 RVA: 0x007F4118 File Offset: 0x007F2318
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

	// Token: 0x0601C662 RID: 116322 RVA: 0x007F41AC File Offset: 0x007F23AC
	private void RefreshRecoverSpEnBuff()
	{
		this.BuffForRecoverSpEn = ((this.TagComp == null || !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁止蓄力能量恢复"])) && this.BeRidden && this.NeedRecoverSpEn && this.TwoWheelOnGround);
	}

	// Token: 0x0601C663 RID: 116323 RVA: 0x007F41FC File Offset: 0x007F23FC
	[NullableContext(2)]
	private void OnVehicleDriverChange(Entity oldDriver, Entity newDriver)
	{
		this.BeRidden = (newDriver != null);
	}

	// Token: 0x0601C664 RID: 116324 RVA: 0x007F4208 File Offset: 0x007F2408
	private void MotorSubStateModeChanged(EMotorSubState newState, EMotorSubState oldState)
	{
		this.TwoWheelOnGround = (newState == EMotorSubState.TwoWheelMoving || newState == EMotorSubState.Stop);
	}

	// Token: 0x0601C665 RID: 116325 RVA: 0x007F421B File Offset: 0x007F241B
	private void OnAttr62Changed(EAttributeType attrId, float newValue, float oldValue)
	{
		this.NeedRecoverSpEn = (newValue < base.GetCurrentValue(EAttributeType.SpecialEnergy1Max));
		this.SpEnEmpty = (newValue < 100f);
	}

	// Token: 0x0601C666 RID: 116326 RVA: 0x007F423C File Offset: 0x007F243C
	private void OnBanSpEnRecoverTagChanged(int tagId, bool tagExist)
	{
		this.RefreshRecoverSpEnBuff();
	}

	// Token: 0x0601C667 RID: 116327 RVA: 0x007F4244 File Offset: 0x007F2444
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleAttributeComponent motorcycleAttributeComponent = (MotorcycleAttributeComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (motorcycleAttributeComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BeRiddenInternal"))
		{
			this.BeRiddenInternal = motorcycleAttributeComponent.BeRiddenInternal;
		}
		if (base.CanResetComponentProperty("TwoWheelOnGroundTimer"))
		{
			if (motorcycleAttributeComponent.TwoWheelOnGroundTimer == null)
			{
				this.TwoWheelOnGroundTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TwoWheelOnGroundTimer), "TwoWheelOnGroundTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TwoWheelOnGroundInternal"))
		{
			this.TwoWheelOnGroundInternal = motorcycleAttributeComponent.TwoWheelOnGroundInternal;
		}
		if (base.CanResetComponentProperty("NeedRecoverSpEnInternal"))
		{
			this.NeedRecoverSpEnInternal = motorcycleAttributeComponent.NeedRecoverSpEnInternal;
		}
		if (base.CanResetComponentProperty("BuffForRecoverSpEnInternal"))
		{
			this.BuffForRecoverSpEnInternal = motorcycleAttributeComponent.BuffForRecoverSpEnInternal;
		}
		if (base.CanResetComponentProperty("SpEnEmptyInternal"))
		{
			this.SpEnEmptyInternal = motorcycleAttributeComponent.SpEnEmptyInternal;
		}
		return true;
	}

	// Token: 0x0400E149 RID: 57673
	[StaticVariableRuleIgnore]
	private static readonly long[] SpecialEnergyBuffIds = new long[]
	{
		7100000056L,
		7100000057L,
		7100000058L
	};

	// Token: 0x0400E14A RID: 57674
	[StaticVariableRuleIgnore]
	private static readonly long[] SpecialEnergyBuffIdsUpgraded = new long[]
	{
		7100000059L,
		7100000060L,
		7100000061L
	};

	// Token: 0x0400E14B RID: 57675
	[StaticVariableRuleIgnore]
	private static float CANNOT_RECOVER_SP_EN_TIMER = 500f;

	// Token: 0x0400E14C RID: 57676
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400E14D RID: 57677
	private bool BeRiddenInternal;

	// Token: 0x0400E14E RID: 57678
	[Nullable(2)]
	private TimerHandle TwoWheelOnGroundTimer;

	// Token: 0x0400E14F RID: 57679
	private bool TwoWheelOnGroundInternal;

	// Token: 0x0400E150 RID: 57680
	private bool NeedRecoverSpEnInternal;

	// Token: 0x0400E151 RID: 57681
	private bool BuffForRecoverSpEnInternal;

	// Token: 0x0400E152 RID: 57682
	private bool SpEnEmptyInternal;
}
