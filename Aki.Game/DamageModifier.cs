using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002481 RID: 9345
[NullableContext(1)]
[Nullable(0)]
public class DamageModifier : ModifierCalculator, IStaticVariableResetter
{
	// Token: 0x060174BE RID: 95422 RVA: 0x006D99F0 File Offset: 0x006D7BF0
	static DamageModifier()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageModifier.CreateStaticDefaultValue), new Action(DamageModifier.ResetStaticDefaultValue));
	}

	// Token: 0x060174BF RID: 95423 RVA: 0x006D9A0F File Offset: 0x006D7C0F
	public DamageModifier(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174C0 RID: 95424 RVA: 0x006D9A1E File Offset: 0x006D7C1E
	protected override bool CheckAuthority()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060174C1 RID: 95425 RVA: 0x006D9A34 File Offset: 0x006D7C34
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

	// Token: 0x060174C2 RID: 95426 RVA: 0x006D9B48 File Offset: 0x006D7D48
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

	// Token: 0x060174C3 RID: 95427 RVA: 0x006D9BF8 File Offset: 0x006D7DF8
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

	// Token: 0x060174C4 RID: 95428 RVA: 0x006D9C64 File Offset: 0x006D7E64
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

	// Token: 0x060174C5 RID: 95429 RVA: 0x006D9C9C File Offset: 0x006D7E9C
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

	// Token: 0x060174C6 RID: 95430 RVA: 0x006D9D33 File Offset: 0x006D7F33
	public static void CreateStaticDefaultValue()
	{
		DamageModifier.TempModifiedResult = 0f;
	}

	// Token: 0x060174C7 RID: 95431 RVA: 0x006D9D3F File Offset: 0x006D7F3F
	public static void ResetStaticDefaultValue()
	{
		DamageModifier.TempModifiedResult = 0f;
	}

	// Token: 0x0400C591 RID: 50577
	public float Value;

	// Token: 0x0400C592 RID: 50578
	public static float TempModifiedResult;

	// Token: 0x0400C593 RID: 50579
	public bool ModifyTough;

	// Token: 0x0400C594 RID: 50580
	public bool UpperBound;

	// Token: 0x0400C595 RID: 50581
	private int ExecuteCount;

	// Token: 0x0400C596 RID: 50582
	private int ExecuteCountLimit;
}
