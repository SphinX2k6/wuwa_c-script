using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F2B RID: 12075
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectDamageAugment : BuffEffect
{
	// Token: 0x06019BA6 RID: 105382 RVA: 0x006B31EF File Offset: 0x006B13EF
	public ExtraEffectDamageAugment(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BA7 RID: 105383 RVA: 0x006B3200 File Offset: 0x006B1400
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		float[] extraEffectGrowParameters2 = parameters.ExtraEffectGrowParameters2;
		int level = this.Level;
		this.AttrId = (EAttributeType)int.Parse(extraEffectParameters_[0]);
		this.RefValueType = (EAttributeRefType)int.Parse(extraEffectParameters_[1]);
		this.RefParam1 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, level, 0f);
		this.RefParam2 = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, level, 0f);
	}

	// Token: 0x06019BA8 RID: 105384 RVA: 0x006B326C File Offset: 0x006B146C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		EAttributeType attrId = this.AttrId;
		EntityHandle instigatorEntity = base.InstigatorEntity;
		BaseAttributeComponent baseAttributeComponent;
		if (instigatorEntity == null)
		{
			baseAttributeComponent = null;
		}
		else
		{
			WorldEntity entity = instigatorEntity.Entity;
			baseAttributeComponent = ((entity != null) ? entity.CheckGetComponent<BaseAttributeComponent>() : null);
		}
		BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
		float refParam = this.RefParam1;
		float refParam2 = this.RefParam2;
		float num = refParam * 0.0001f;
		float num2 = 0f;
		EAttributeRefType refValueType = this.RefValueType;
		if (refValueType != EAttributeRefType.BaseValue)
		{
			if (refValueType == EAttributeRefType.CurrentValue)
			{
				num2 = baseAttributeComponent2.GetCurrentValue(attrId);
			}
		}
		else
		{
			num2 = baseAttributeComponent2.GetBaseValue(attrId);
		}
		return Math.Max(num2 * num + refParam2, 0f);
	}

	// Token: 0x06019BA9 RID: 105385 RVA: 0x006B32F8 File Offset: 0x006B14F8
	public static float ApplyEffects(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		BaseBuffComponent ownerBuffComponent = snapshots.Attacker.OwnerBuffComponent;
		CharacterBuffComponent ownerBuffComponent2 = snapshots.Target.OwnerBuffComponent;
		float num = 0f;
		foreach (ExtraEffectDamageAugment extraEffectDamageAugment in ownerBuffComponent.BuffEffectManager.FilterById<ExtraEffectDamageAugment>(EExtraEffectId.DamageAugment, null))
		{
			if (extraEffectDamageAugment.Check(requirements, ownerBuffComponent2))
			{
				num += (float)(extraEffectDamageAugment.Execute(Array.Empty<object>()) ?? 0f);
			}
		}
		return num;
	}

	// Token: 0x0400C1E8 RID: 49640
	private EAttributeType AttrId;

	// Token: 0x0400C1E9 RID: 49641
	private float RefParam1;

	// Token: 0x0400C1EA RID: 49642
	private float RefParam2;

	// Token: 0x0400C1EB RID: 49643
	private EAttributeRefType RefValueType;
}
