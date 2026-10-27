using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F2E RID: 12078
[NullableContext(1)]
[Nullable(0)]
public class DamageModifier : ModifierCalculator, IStaticVariableResetter
{
	// Token: 0x06019BB3 RID: 105395 RVA: 0x006B36D8 File Offset: 0x006B18D8
	static DamageModifier()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageModifier.CreateStaticDefaultValue), new Action(DamageModifier.ResetStaticDefaultValue));
	}

	// Token: 0x06019BB4 RID: 105396 RVA: 0x006B36F7 File Offset: 0x006B18F7
	public DamageModifier(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BB5 RID: 105397 RVA: 0x006B3706 File Offset: 0x006B1906
	protected override bool CheckAuthority()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019BB6 RID: 105398 RVA: 0x006B371C File Offset: 0x006B191C
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.ModifyTough = (extraEffectParameters_.Length > 3 && !string.IsNullOrEmpty(extraEffectParameters_[3]));
		if (!this.ModifyTough)
		{
			return;
		}
		this.CalculationPolicy = (ESnapCalculateType)int.Parse(extraEffectParameters_[3]);
		this.StackParam = new long[1];
		this.RefParam1 = ((extraEffectParameters_.Length > 4) ? float.Parse(extraEffectParameters_[4]) : 0f);
		if (extraEffectParameters_.Length > 5 && !string.IsNullOrEmpty(extraEffectParameters_[5]))
		{
			string[] array = extraEffectParameters_[5].Split('#', StringSplitOptions.None);
			this.RefAttrId = (EAttributeType)int.Parse(array[0]);
			this.RefTargetType = (ESnapAttributeSourceType)int.Parse(array[1]);
			this.RefValueType = (EAttributeRefType)int.Parse(array[2]);
			this.RefParam2 = float.Parse(array[3]);
			this.ExecuteCountLimit = ((array.Length > 4) ? int.Parse(array[4]) : 0);
			this.ExecuteCount = 0;
		}
		if (extraEffectParameters_.Length > 6 && !string.IsNullOrEmpty(extraEffectParameters_[6]))
		{
			string[] array2 = extraEffectParameters_[6].Split('#', StringSplitOptions.None);
			this.UpperBound = (((array2.Length > 2) ? int.Parse(array2[2]) : 0) == 1);
		}
	}

	// Token: 0x06019BB7 RID: 105399 RVA: 0x006B3830 File Offset: 0x006B1A30
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length >= 2)
		{
			SnapshotPayload snapshotPayload = parameters[0] as SnapshotPayload;
			if (snapshotPayload != null)
			{
				object obj = parameters[1];
				if (obj is float)
				{
					float num = (float)obj;
					if (!this.ModifyTough || (this.ExecuteCount >= this.ExecuteCountLimit && this.ExecuteCountLimit > 0))
					{
						return -1f;
					}
					float num2 = base.CalculateValue(snapshotPayload);
					if (!this.UpperBound)
					{
						this.ExecuteCount++;
						return num2;
					}
					if (num2 < num)
					{
						this.ExecuteCount++;
						return num2;
					}
					return num;
				}
			}
		}
		return -1f;
	}

	// Token: 0x06019BB8 RID: 105400 RVA: 0x006B38E0 File Offset: 0x006B1AE0
	[return: Nullable(2)]
	private static DamageModifier GetLatestModifier([Nullable(2)] BaseBuffComponent victim, BaseBuffComponent attacker, RequirementPayload requirements)
	{
		if (victim == null || victim.BuffEffectManager == null)
		{
			return null;
		}
		DamageModifier result = null;
		foreach (DamageModifier damageModifier in victim.BuffEffectManager.FilterById<DamageModifier>(EExtraEffectId.DamageModify, null))
		{
			if (damageModifier.Check(requirements, attacker))
			{
				result = damageModifier;
			}
		}
		return result;
	}

	// Token: 0x06019BB9 RID: 105401 RVA: 0x006B394C File Offset: 0x006B1B4C
	[NullableContext(2)]
	private static DamageModifier CompareLatestModifier(DamageModifier modifier1, DamageModifier modifier2)
	{
		if (modifier1 == null || modifier1.Buff == null)
		{
			return modifier2;
		}
		if (modifier2 == null || modifier2.Buff == null)
		{
			return modifier1;
		}
		if (modifier1.Buff.CreateTimestamp <= modifier2.Buff.CreateTimestamp)
		{
			return modifier2;
		}
		return modifier1;
	}

	// Token: 0x06019BBA RID: 105402 RVA: 0x006B3984 File Offset: 0x006B1B84
	public static float ApplyEffects(RequirementPayload requirements, SnapshotPayload snapshots, float toughResult)
	{
		CharacterBuffComponent ownerBuffComponent = snapshots.Attacker.OwnerBuffComponent;
		DamageModifier latestModifier = DamageModifier.GetLatestModifier(snapshots.Target.OwnerBuffComponent, ownerBuffComponent, requirements);
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		DamageModifier latestModifier2 = DamageModifier.GetLatestModifier((playerEntity != null) ? playerEntity.GetComponent<PlayerBuffComponent>() : null, ownerBuffComponent, requirements);
		DamageModifier damageModifier = DamageModifier.CompareLatestModifier(latestModifier, latestModifier2);
		if (damageModifier == null)
		{
			return toughResult;
		}
		float num = (float)(damageModifier.Execute(new object[]
		{
			snapshots,
			toughResult
		}) ?? 0f);
		if (num < 0f)
		{
			return toughResult;
		}
		return num;
	}

	// Token: 0x06019BBB RID: 105403 RVA: 0x006B3A1B File Offset: 0x006B1C1B
	public static void CreateStaticDefaultValue()
	{
		DamageModifier.TempModifiedResult = 0f;
	}

	// Token: 0x06019BBC RID: 105404 RVA: 0x006B3A27 File Offset: 0x006B1C27
	public static void ResetStaticDefaultValue()
	{
		DamageModifier.TempModifiedResult = 0f;
	}

	// Token: 0x0400C1EF RID: 49647
	public float Value;

	// Token: 0x0400C1F0 RID: 49648
	public static float TempModifiedResult;

	// Token: 0x0400C1F1 RID: 49649
	public bool ModifyTough;

	// Token: 0x0400C1F2 RID: 49650
	public bool UpperBound;

	// Token: 0x0400C1F3 RID: 49651
	private int ExecuteCount;

	// Token: 0x0400C1F4 RID: 49652
	private int ExecuteCountLimit;
}
