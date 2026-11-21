using System;
using System.Runtime.CompilerServices;

// Token: 0x020024CA RID: 9418
[NullableContext(1)]
[Nullable(0)]
public class DamageAmplifyOnHit : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06017633 RID: 95795 RVA: 0x006E3030 File Offset: 0x006E1230
	static DamageAmplifyOnHit()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageAmplifyOnHit.CreateStaticDefaultValue), new Action(DamageAmplifyOnHit.ResetStaticDefaultValue));
	}

	// Token: 0x06017634 RID: 95796 RVA: 0x006E304F File Offset: 0x006E124F
	public DamageAmplifyOnHit(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017635 RID: 95797 RVA: 0x006E305E File Offset: 0x006E125E
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x06017636 RID: 95798 RVA: 0x006E307C File Offset: 0x006E127C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		float value = this.Value;
		IActiveBuff buff = base.Buff;
		return value * (float)((buff != null) ? buff.StackCount : 1);
	}

	// Token: 0x06017637 RID: 95799 RVA: 0x006E30A0 File Offset: 0x006E12A0
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

	// Token: 0x06017638 RID: 95800 RVA: 0x006E313C File Offset: 0x006E133C
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x06017639 RID: 95801 RVA: 0x006E3143 File Offset: 0x006E1343
	public static void CreateStaticDefaultValue()
	{
		DamageAmplifyOnHit.TempModifiedResult = 0f;
	}

	// Token: 0x0601763A RID: 95802 RVA: 0x006E314F File Offset: 0x006E134F
	public static void ResetStaticDefaultValue()
	{
		DamageAmplifyOnHit.TempModifiedResult = 0f;
	}

	// Token: 0x0400C699 RID: 50841
	public float Value;

	// Token: 0x0400C69A RID: 50842
	public static float TempModifiedResult;
}
