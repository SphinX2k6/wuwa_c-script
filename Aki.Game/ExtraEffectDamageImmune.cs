using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002480 RID: 9344
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectDamageImmune : BuffEffect
{
	// Token: 0x060174BA RID: 95418 RVA: 0x006D98D2 File Offset: 0x006D7AD2
	public ExtraEffectDamageImmune(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174BB RID: 95419 RVA: 0x006D98F0 File Offset: 0x006D7AF0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			EElementType eelementType = (EElementType)int.Parse(extraEffectParameters_[i]);
			this.ImmuneElements[(int)eelementType] = true;
		}
	}

	// Token: 0x060174BC RID: 95420 RVA: 0x006D9924 File Offset: 0x006D7B24
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

	// Token: 0x060174BD RID: 95421 RVA: 0x006D995C File Offset: 0x006D7B5C
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

	// Token: 0x0400C590 RID: 50576
	private bool[] ImmuneElements = new bool[7];
}
