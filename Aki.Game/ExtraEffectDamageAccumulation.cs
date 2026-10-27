using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002F2A RID: 12074
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectDamageAccumulation : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06019B95 RID: 105365 RVA: 0x006B2BC6 File Offset: 0x006B0DC6
	static ExtraEffectDamageAccumulation()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExtraEffectDamageAccumulation.CreateStaticDefaultValue), new Action(ExtraEffectDamageAccumulation.ResetStaticDefaultValue));
	}

	// Token: 0x170023AE RID: 9134
	// (get) Token: 0x06019B96 RID: 105366 RVA: 0x006B2BE5 File Offset: 0x006B0DE5
	private static Dictionary<int, float> AccumulationMap
	{
		get
		{
			return ExtraEffectDamageAccumulation._accumulationMap;
		}
	}

	// Token: 0x06019B97 RID: 105367 RVA: 0x006B2BEC File Offset: 0x006B0DEC
	public ExtraEffectDamageAccumulation(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019B98 RID: 105368 RVA: 0x006B2C08 File Offset: 0x006B0E08
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

	// Token: 0x06019B99 RID: 105369 RVA: 0x006B2D50 File Offset: 0x006B0F50
	public override void OnCreated()
	{
		this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Accumulated);
	}

	// Token: 0x06019B9A RID: 105370 RVA: 0x006B2D59 File Offset: 0x006B0F59
	public override void OnRemoved(bool bPremature)
	{
		if (bPremature)
		{
			this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Premature);
			return;
		}
		this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Expired);
	}

	// Token: 0x06019B9B RID: 105371 RVA: 0x006B2D6D File Offset: 0x006B0F6D
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		if (newCount < oldCount)
		{
			this.PreTriggerEffect(ExtraEffectDamageAccumulation.ETriggerType.Reduced);
		}
	}

	// Token: 0x06019B9C RID: 105372 RVA: 0x006B2D7C File Offset: 0x006B0F7C
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

	// Token: 0x06019B9D RID: 105373 RVA: 0x006B2DE8 File Offset: 0x006B0FE8
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

	// Token: 0x06019B9E RID: 105374 RVA: 0x006B2F60 File Offset: 0x006B1160
	public static float GetAccumulation(int bulletEntityId)
	{
		float valueOrDefault = ExtraEffectDamageAccumulation.AccumulationMap.GetValueOrDefault(bulletEntityId, 0f);
		ExtraEffectDamageAccumulation.AccumulationMap.Remove(bulletEntityId);
		return valueOrDefault;
	}

	// Token: 0x06019B9F RID: 105375 RVA: 0x006B2F7E File Offset: 0x006B117E
	private bool CheckTriggeredType(ExtraEffectDamageAccumulation.ETriggerType triggerType)
	{
		return (this.Triggers & 1 << (int)triggerType) != 0;
	}

	// Token: 0x06019BA0 RID: 105376 RVA: 0x006B2F90 File Offset: 0x006B1190
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

	// Token: 0x06019BA1 RID: 105377 RVA: 0x006B300C File Offset: 0x006B120C
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

	// Token: 0x06019BA2 RID: 105378 RVA: 0x006B3040 File Offset: 0x006B1240
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

	// Token: 0x06019BA3 RID: 105379 RVA: 0x006B3114 File Offset: 0x006B1314
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

	// Token: 0x06019BA4 RID: 105380 RVA: 0x006B31DB File Offset: 0x006B13DB
	public static void CreateStaticDefaultValue()
	{
		ExtraEffectDamageAccumulation._accumulationMap = new Dictionary<int, float>();
	}

	// Token: 0x06019BA5 RID: 105381 RVA: 0x006B31E7 File Offset: 0x006B13E7
	public static void ResetStaticDefaultValue()
	{
		ExtraEffectDamageAccumulation._accumulationMap = null;
	}

	// Token: 0x0400C1E0 RID: 49632
	private float Accumulation;

	// Token: 0x0400C1E1 RID: 49633
	[Nullable(2)]
	private static Dictionary<int, float> _accumulationMap;

	// Token: 0x0400C1E2 RID: 49634
	private EAccumulationType AccumulationType;

	// Token: 0x0400C1E3 RID: 49635
	private EPassiveEffectGoalType GoalType;

	// Token: 0x0400C1E4 RID: 49636
	private long[] Ids = Array.Empty<long>();

	// Token: 0x0400C1E5 RID: 49637
	private int Triggers;

	// Token: 0x0400C1E6 RID: 49638
	private float Lower;

	// Token: 0x0400C1E7 RID: 49639
	private EAttributeType? AttributeId;

	// Token: 0x020095FF RID: 38399
	[NullableContext(0)]
	public enum ETriggerType
	{
		// Token: 0x0403024A RID: 197194
		Accumulated,
		// Token: 0x0403024B RID: 197195
		Expired,
		// Token: 0x0403024C RID: 197196
		Premature,
		// Token: 0x0403024D RID: 197197
		Reduced
	}
}
