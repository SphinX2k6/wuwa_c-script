using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F76 RID: 12150
[NullableContext(1)]
[Nullable(0)]
public class DamageAmplifyOnHit : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06019D21 RID: 105761 RVA: 0x006BC720 File Offset: 0x006BA920
	static DamageAmplifyOnHit()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageAmplifyOnHit.CreateStaticDefaultValue), new Action(DamageAmplifyOnHit.ResetStaticDefaultValue));
	}

	// Token: 0x06019D22 RID: 105762 RVA: 0x006BC73F File Offset: 0x006BA93F
	public DamageAmplifyOnHit(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D23 RID: 105763 RVA: 0x006BC74E File Offset: 0x006BA94E
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x06019D24 RID: 105764 RVA: 0x006BC76C File Offset: 0x006BA96C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		float value = this.Value;
		IActiveBuff buff = base.Buff;
		return value * (float)((buff != null) ? buff.StackCount : 1);
	}

	// Token: 0x06019D25 RID: 105765 RVA: 0x006BC790 File Offset: 0x006BA990
	public static float ApplyEffects(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		BaseBuffComponent ownerBuffComponent = snapshots.Attacker.OwnerBuffComponent;
		CharacterBuffComponent ownerBuffComponent2 = snapshots.Target.OwnerBuffComponent;
		float num = 0f;
		foreach (DamageAmplifyOnHit damageAmplifyOnHit in ownerBuffComponent.BuffEffectManager.FilterById<DamageAmplifyOnHit>(EExtraEffectId.DamageAmplifyOnHit, null))
		{
			if (damageAmplifyOnHit.Check(requirements, ownerBuffComponent2))
			{
				object obj = damageAmplifyOnHit.Execute(Array.Empty<object>());
				if (obj is float)
				{
					float num2 = (float)obj;
					num += num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06019D26 RID: 105766 RVA: 0x006BC82C File Offset: 0x006BAA2C
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x06019D27 RID: 105767 RVA: 0x006BC833 File Offset: 0x006BAA33
	public static void CreateStaticDefaultValue()
	{
		DamageAmplifyOnHit.TempModifiedResult = 0f;
	}

	// Token: 0x06019D28 RID: 105768 RVA: 0x006BC83F File Offset: 0x006BAA3F
	public static void ResetStaticDefaultValue()
	{
		DamageAmplifyOnHit.TempModifiedResult = 0f;
	}

	// Token: 0x0400C2F0 RID: 49904
	public float Value;

	// Token: 0x0400C2F1 RID: 49905
	public static float TempModifiedResult;
}
