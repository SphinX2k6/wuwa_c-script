using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F77 RID: 12151
[NullableContext(1)]
[Nullable(0)]
public class DamageAmplifyOnBeHit : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06019D29 RID: 105769 RVA: 0x006BC84B File Offset: 0x006BAA4B
	static DamageAmplifyOnBeHit()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageAmplifyOnBeHit.CreateStaticDefaultValue), new Action(DamageAmplifyOnBeHit.ResetStaticDefaultValue));
	}

	// Token: 0x06019D2A RID: 105770 RVA: 0x006BC86A File Offset: 0x006BAA6A
	public DamageAmplifyOnBeHit(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D2B RID: 105771 RVA: 0x006BC879 File Offset: 0x006BAA79
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.Value = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x06019D2C RID: 105772 RVA: 0x006BC897 File Offset: 0x006BAA97
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		float value = this.Value;
		IActiveBuff buff = base.Buff;
		return value * (float)((buff != null) ? buff.StackCount : 1);
	}

	// Token: 0x06019D2D RID: 105773 RVA: 0x006BC8B8 File Offset: 0x006BAAB8
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

	// Token: 0x06019D2E RID: 105774 RVA: 0x006BC954 File Offset: 0x006BAB54
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x06019D2F RID: 105775 RVA: 0x006BC95B File Offset: 0x006BAB5B
	public static void CreateStaticDefaultValue()
	{
		DamageAmplifyOnBeHit.TempModifiedResult = 0f;
	}

	// Token: 0x06019D30 RID: 105776 RVA: 0x006BC967 File Offset: 0x006BAB67
	public static void ResetStaticDefaultValue()
	{
		DamageAmplifyOnBeHit.TempModifiedResult = 0f;
	}

	// Token: 0x0400C2F2 RID: 49906
	public float Value;

	// Token: 0x0400C2F3 RID: 49907
	public static float TempModifiedResult;
}
