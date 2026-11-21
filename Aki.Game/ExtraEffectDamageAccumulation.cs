using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x0200247D RID: 9341
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectDamageAccumulation : BuffEffect, IStaticVariableResetter
{
	// Token: 0x060174A0 RID: 95392 RVA: 0x006D8EDE File Offset: 0x006D70DE
	static ExtraEffectDamageAccumulation()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExtraEffectDamageAccumulation.CreateStaticDefaultValue), new Action(ExtraEffectDamageAccumulation.ResetStaticDefaultValue));
	}

	// Token: 0x17002470 RID: 9328
	// (get) Token: 0x060174A1 RID: 95393 RVA: 0x006D8EFD File Offset: 0x006D70FD
	private static Dictionary<int, float> AccumulationMap
	{
		get
		{
			return ExtraEffectDamageAccumulation._accumulationMap;
		}
	}

	// Token: 0x060174A2 RID: 95394 RVA: 0x006D8F04 File Offset: 0x006D7104
	public ExtraEffectDamageAccumulation(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174A3 RID: 95395 RVA: 0x006D8F20 File Offset: 0x006D7120
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.AccumulationType = (EAccumulationType)int.Parse(extraEffectParameters_[0]);
		this.GoalType = (EPassiveEffectGoalType)int.Parse(extraEffectParameters_[1]);
		string[] array = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
		this.Ids = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.Ids[i] = long.Parse(array[i]);
		}
		string[] array2 = ((extraEffectParameters_.Length > 3) ? (extraEffectParameters_[3] ?? "") : "").Split('#', StringSplitOptions.None);
		for (int j = 0; j < array2.Length; j++)
		{
			if (!string.IsNullOrEmpty(array2[j]))
			{
				this.Triggers |= 1 << int.Parse(array2[j]);
			}
		}
		string[] array3 = ((extraEffectParameters_.Length > 4) ? (extraEffectParameters_[4] ?? "") : "").Split('#', StringSplitOptions.None);
		int num = array3.Length;
		if (num != 1)
		{
			if (num != 2)
			{
				return;
			}
			if (!string.IsNullOrEmpty(array3[0]))
			{
				this.AttributeId = new EAttributeType?((EAttributeType)int.Parse(array3[0]));
			}
			if (!string.IsNullOrEmpty(array3[1]))
			{
				this.Lower = float.Parse(array3[1]);
			}
		}
		else if (!string.IsNullOrEmpty(array3[0]))
		{
			this.Lower = float.Parse(array3[0]);
			return;
		}
	}

	// Token: 0x060174A4 RID: 95396 RVA: 0x006D9068 File Offset: 0x006D7268
	public override void OnCreated()
	{
		this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Accumulated);
	}

	// Token: 0x060174A5 RID: 95397 RVA: 0x006D9071 File Offset: 0x006D7271
	public override void OnRemoved(bool bPremature)
	{
		if (bPremature)
		{
			this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Premature);
			return;
		}
		this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Expired);
	}

	// Token: 0x060174A6 RID: 95398 RVA: 0x006D9085 File Offset: 0x006D7285
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		if (newCount < oldCount)
		{
			this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Reduced);
		}
	}

	// Token: 0x060174A7 RID: 95399 RVA: 0x006D9094 File Offset: 0x006D7294
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length >= 2)
		{
			object obj = parameters[0];
			if (obj is EAccumulationType)
			{
				EAccumulationType eaccumulationType = (EAccumulationType)obj;
				DamageResult damageResult = parameters[1] as DamageResult;
				if (damageResult != null)
				{
					if (eaccumulationType != this.AccumulationType)
					{
						return null;
					}
					if (damageResult.Damage >= 0f)
					{
						return null;
					}
					this.Accumulation += -damageResult.Damage;
					this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Accumulated);
					return null;
				}
			}
		}
		return null;
	}

	// Token: 0x060174A8 RID: 95400 RVA: 0x006D9100 File Offset: 0x006D7300
	public static void ApplyEffects(DamageResult damageResult, RequirementPayload requirements, BaseDamageComponent attacker, BaseDamageComponent victim)
	{
		BaseBuffComponent[] array = new BaseBuffComponent[]
		{
			victim.OwnerBuffComponent,
			attacker.OwnerBuffComponent
		};
		for (int i = 0; i < array.Length; i++)
		{
			BaseBuffComponent baseBuffComponent = array[i];
			if (baseBuffComponent != null)
			{
				if (baseBuffComponent.IsRoleBuffComponent())
				{
					RoleBuffComponent roleBuffComponent = baseBuffComponent as RoleBuffComponent;
					if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
					{
						PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
						BaseBuffComponent baseBuffComponent2 = array[1 - i];
						if (((formationBuffComp != null) ? formationBuffComp.BuffEffectManager : null) != null && baseBuffComponent2 != null)
						{
							foreach (ExtraEffectDamageAccumulation extraEffectDamageAccumulation in formationBuffComp.BuffEffectManager.FilterById<ExtraEffectDamageAccumulation>(EExtraEffectId.DamageAccumulation, null))
							{
								if (extraEffectDamageAccumulation.Check(requirements, baseBuffComponent2))
								{
									extraEffectDamageAccumulation.Execute(new object[]
									{
										(EAccumulationType)i,
										damageResult
									});
								}
							}
						}
					}
				}
				BaseBuffComponent baseBuffComponent3 = array[1 - i];
				if (baseBuffComponent.BuffEffectManager != null && baseBuffComponent3 != null)
				{
					foreach (ExtraEffectDamageAccumulation extraEffectDamageAccumulation2 in baseBuffComponent.BuffEffectManager.FilterById<ExtraEffectDamageAccumulation>(EExtraEffectId.DamageAccumulation, null))
					{
						if (extraEffectDamageAccumulation2.Check(requirements, baseBuffComponent3))
						{
							extraEffectDamageAccumulation2.Execute(new object[]
							{
								(EAccumulationType)i,
								damageResult
							});
						}
					}
				}
			}
		}
	}

	// Token: 0x060174A9 RID: 95401 RVA: 0x006D9278 File Offset: 0x006D7478
	public static float GetAccumulation(int bulletEntityId)
	{
		float valueOrDefault = ExtraEffectDamageAccumulation.AccumulationMap.GetValueOrDefault(bulletEntityId, 0f);
		ExtraEffectDamageAccumulation.AccumulationMap.Remove(bulletEntityId);
		return valueOrDefault;
	}

	// Token: 0x060174AA RID: 95402 RVA: 0x006D9296 File Offset: 0x006D7496
	private bool CheckTriggeredType(ExtraEffectDamageAccumulation.ETriggerType triggerType)
	{
		return (this.Triggers & 1 << (int)triggerType) != 0;
	}

	// Token: 0x060174AB RID: 95403 RVA: 0x006D92A8 File Offset: 0x006D74A8
	private void PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType triggerType)
	{
		if (!this.CheckTriggeredType(triggerType))
		{
			return;
		}
		if (triggerType == ExtraEffectDamageAccumulation.ETriggerType.Accumulated)
		{
			float num2;
			if (this.AttributeId != null)
			{
				float num = this.Lower * 0.0001f;
				BaseAttributeComponent component = base.OwnerEntity.GetComponent<BaseAttributeComponent>();
				num2 = ((component != null) ? component.GetBaseValue(this.AttributeId.Value) : 0f) * num;
			}
			else
			{
				num2 = this.Lower;
			}
			if (num2 < this.Accumulation)
			{
				this.TriggerEffect();
				return;
			}
		}
		else
		{
			this.TriggerEffect();
		}
	}

	// Token: 0x060174AC RID: 95404 RVA: 0x006D9324 File Offset: 0x006D7524
	private void TriggerEffect()
	{
		EPassiveEffectGoalType goalType = this.GoalType;
		if (goalType != EPassiveEffectGoalType.Buff)
		{
			if (goalType == EPassiveEffectGoalType.Bullet)
			{
				this.ExecuteAddBullets();
			}
		}
		else
		{
			this.ExecuteAddBuffs();
		}
		this.Accumulation = 0f;
	}

	// Token: 0x060174AD RID: 95405 RVA: 0x006D9358 File Offset: 0x006D7558
	private void ExecuteAddBuffs()
	{
		IActiveBuff buffByHandle = this.OwnerBuffComponent.GetBuffByHandle(this.ActiveHandleId);
		if (buffByHandle != null && buffByHandle.IsValid())
		{
			Entity entity = this.OwnerBuffComponent.GetEntity();
			BaseBuffComponent baseBuffComponent = (entity != null) ? entity.CheckGetComponent<BaseBuffComponent>() : null;
			for (int i = 0; i < this.Ids.Length; i++)
			{
				if (baseBuffComponent != null)
				{
					BaseBuffComponent baseBuffComponent2 = baseBuffComponent;
					long buffId = this.Ids[i];
					IActiveBuff preBuff = buffByHandle;
					int? stackCount = null;
					bool isIterable = true;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
					defaultInterpolatedStringHandler.AppendLiteral("因为其它buff额外效果而移除（前置buff Id=");
					defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
					defaultInterpolatedStringHandler.AppendLiteral(", handle=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
					defaultInterpolatedStringHandler.AppendLiteral("）");
					baseBuffComponent2.AddIterativeBuff(buffId, preBuff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
				}
			}
		}
	}

	// Token: 0x060174AE RID: 95406 RVA: 0x006D942C File Offset: 0x006D762C
	private void ExecuteAddBullets()
	{
		CharacterActorComponent component = base.OwnerEntity.GetComponent<CharacterActorComponent>();
		FTransformDouble? initialTransform = (component != null) ? new FTransformDouble?(component.ActorTransform) : null;
		EntityHandle instigatorEntity = base.InstigatorEntity;
		WorldEntity worldEntity = (instigatorEntity != null) ? instigatorEntity.Entity : null;
		if (initialTransform == null || worldEntity == null)
		{
			return;
		}
		long? messageId = base.Buff.MessageId;
		for (int i = 0; i < this.Ids.Length; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(worldEntity, this.Ids[i].ToString(), initialTransform, new BulletController.BulletCreateParams(), messageId, global::EBulletCreateSource.Others);
				if (bulletEntity != null)
				{
					ExtraEffectDamageAccumulation.AccumulationMap[bulletEntity.Id] = this.Accumulation;
				}
			}
		}
	}

	// Token: 0x060174AF RID: 95407 RVA: 0x006D94F3 File Offset: 0x006D76F3
	public static void CreateStaticDefaultValue()
	{
		ExtraEffectDamageAccumulation._accumulationMap = new Dictionary<int, float>();
	}

	// Token: 0x060174B0 RID: 95408 RVA: 0x006D94FF File Offset: 0x006D76FF
	public static void ResetStaticDefaultValue()
	{
		ExtraEffectDamageAccumulation._accumulationMap = null;
	}

	// Token: 0x0400C582 RID: 50562
	private float Accumulation;

	// Token: 0x0400C583 RID: 50563
	[Nullable(2)]
	private static Dictionary<int, float> _accumulationMap;

	// Token: 0x0400C584 RID: 50564
	private EAccumulationType AccumulationType;

	// Token: 0x0400C585 RID: 50565
	private EPassiveEffectGoalType GoalType;

	// Token: 0x0400C586 RID: 50566
	private long[] Ids = Array.Empty<long>();

	// Token: 0x0400C587 RID: 50567
	private int Triggers;

	// Token: 0x0400C588 RID: 50568
	private float Lower;

	// Token: 0x0400C589 RID: 50569
	private EAttributeType? AttributeId;

	// Token: 0x02008824 RID: 34852
	[NullableContext(0)]
	public enum ETriggerType
	{
		// Token: 0x0402B8DF RID: 178399
		Accumulated,
		// Token: 0x0402B8E0 RID: 178400
		Expired,
		// Token: 0x0402B8E1 RID: 178401
		Premature,
		// Token: 0x0402B8E2 RID: 178402
		Reduced
	}
}
