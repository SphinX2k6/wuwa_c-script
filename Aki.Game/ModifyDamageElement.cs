using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002F78 RID: 12152
[NullableContext(1)]
[Nullable(0)]
public class ModifyDamageElement : BuffEffect
{
	// Token: 0x06019D31 RID: 105777 RVA: 0x006BC973 File Offset: 0x006BAB73
	public ModifyDamageElement(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D32 RID: 105778 RVA: 0x006BC990 File Offset: 0x006BAB90
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.TargetType = (EElementType)int.Parse(parameters.ExtraEffectParameters_[0]);
		foreach (string s in parameters.ExtraEffectParameters_[1].Split(',', StringSplitOptions.None))
		{
			this.DamageIds.Add(long.Parse(s));
		}
	}

	// Token: 0x06019D33 RID: 105779 RVA: 0x006BC9E5 File Offset: 0x006BABE5
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return this.TargetType;
	}

	// Token: 0x06019D34 RID: 105780 RVA: 0x006BC9F4 File Offset: 0x006BABF4
	[NullableContext(2)]
	public static EElementType? ApplyEffects(BaseBuffComponent attacker, long damageId)
	{
		if (attacker == null)
		{
			return null;
		}
		foreach (ModifyDamageElement modifyDamageElement in attacker.BuffEffectManager.FilterById<ModifyDamageElement>(EExtraEffectId.ModifyDamageElement, null))
		{
			if (modifyDamageElement.DamageIds.Contains(damageId))
			{
				return new EElementType?(modifyDamageElement.TargetType);
			}
		}
		return null;
	}

	// Token: 0x06019D35 RID: 105781 RVA: 0x006BCA78 File Offset: 0x006BAC78
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C2F4 RID: 49908
	public EElementType TargetType;

	// Token: 0x0400C2F5 RID: 49909
	public HashSet<long> DamageIds = new HashSet<long>();
}
