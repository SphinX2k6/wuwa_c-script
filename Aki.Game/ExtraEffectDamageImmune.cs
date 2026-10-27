using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002F2D RID: 12077
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectDamageImmune : BuffEffect
{
	// Token: 0x06019BAF RID: 105391 RVA: 0x006B35BA File Offset: 0x006B17BA
	public ExtraEffectDamageImmune(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BB0 RID: 105392 RVA: 0x006B35D8 File Offset: 0x006B17D8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			EElementType eelementType = (EElementType)int.Parse(extraEffectParameters_[i]);
			this.ImmuneElements[(int)eelementType] = true;
		}
	}

	// Token: 0x06019BB1 RID: 105393 RVA: 0x006B360C File Offset: 0x006B180C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length != 0)
		{
			TDamageParam tdamageParam = parameters[0] as TDamageParam;
			if (tdamageParam != null)
			{
				return this.ImmuneElements[(int)tdamageParam.Element];
			}
		}
		return false;
	}

	// Token: 0x06019BB2 RID: 105394 RVA: 0x006B3644 File Offset: 0x006B1844
	public static bool ApplyEffects(RequirementPayload requirements, TDamageParam inputParam, SnapshotPayload snapshots)
	{
		CharacterBuffComponent ownerBuffComponent = snapshots.Attacker.OwnerBuffComponent;
		foreach (ExtraEffectDamageImmune extraEffectDamageImmune in snapshots.Target.OwnerBuffComponent.BuffEffectManager.FilterById<ExtraEffectDamageImmune>(EExtraEffectId.DamageImmune, null))
		{
			if (extraEffectDamageImmune.Check(requirements, ownerBuffComponent) == ((bool?)extraEffectDamageImmune.Execute(new object[]
			{
				inputParam
			})).GetValueOrDefault())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0400C1EE RID: 49646
	private bool[] ImmuneElements = new bool[7];
}
