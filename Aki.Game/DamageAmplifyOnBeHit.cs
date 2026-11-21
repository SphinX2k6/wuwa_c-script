using System;
using System.Runtime.CompilerServices;

// Token: 0x020024CB RID: 9419
[NullableContext(1)]
[Nullable(0)]
public class DamageAmplifyOnBeHit : BuffEffect, IStaticVariableResetter
{
	// Token: 0x0601763B RID: 95803 RVA: 0x006E315B File Offset: 0x006E135B
	static DamageAmplifyOnBeHit()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageAmplifyOnBeHit.CreateStaticDefaultValue), new Action(DamageAmplifyOnBeHit.ResetStaticDefaultValue));
	}

	// Token: 0x0601763C RID: 95804 RVA: 0x006E317A File Offset: 0x006E137A
	public DamageAmplifyOnBeHit(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601763D RID: 95805 RVA: 0x006E3189 File Offset: 0x006E1389
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x0601763E RID: 95806 RVA: 0x006E31A7 File Offset: 0x006E13A7
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		float value = this.Value;
		IActiveBuff buff = base.Buff;
		return value * (float)((buff != null) ? buff.StackCount : 1);
	}

	// Token: 0x0601763F RID: 95807 RVA: 0x006E31C8 File Offset: 0x006E13C8
	public static float ApplyEffects(RequirementPayload requirements, SnapshotPayload snapshots)
	{
		CharacterBuffComponent ownerBuffComponent = snapshots.Attacker.OwnerBuffComponent;
		BaseBuffComponent ownerBuffComponent2 = snapshots.Target.OwnerBuffComponent;
		float num = 0f;
		foreach (DamageAmplifyOnBeHit damageAmplifyOnBeHit in ownerBuffComponent2.BuffEffectManager.FilterById<DamageAmplifyOnBeHit>(EExtraEffectId.DamageAmplifyOnBeHit, null))
		{
			if (damageAmplifyOnBeHit.Check(requirements, ownerBuffComponent))
			{
				object obj = damageAmplifyOnBeHit.Execute(Array.Empty<object>());
				if (obj is float)
				{
					float num2 = (float)obj;
					num += num2;
				}
			}
		}
		return num;
	}

	// Token: 0x06017640 RID: 95808 RVA: 0x006E3264 File Offset: 0x006E1464
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x06017641 RID: 95809 RVA: 0x006E326B File Offset: 0x006E146B
	public static void CreateStaticDefaultValue()
	{
		DamageAmplifyOnBeHit.TempModifiedResult = 0f;
	}

	// Token: 0x06017642 RID: 95810 RVA: 0x006E3277 File Offset: 0x006E1477
	public static void ResetStaticDefaultValue()
	{
		DamageAmplifyOnBeHit.TempModifiedResult = 0f;
	}

	// Token: 0x0400C69B RID: 50843
	public float Value;

	// Token: 0x0400C69C RID: 50844
	public static float TempModifiedResult;
}
