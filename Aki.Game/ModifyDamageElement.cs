using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x020024CC RID: 9420
[NullableContext(1)]
[Nullable(0)]
public class ModifyDamageElement : BuffEffect
{
	// Token: 0x06017643 RID: 95811 RVA: 0x006E3283 File Offset: 0x006E1483
	public ModifyDamageElement(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017644 RID: 95812 RVA: 0x006E32A0 File Offset: 0x006E14A0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.TargetType = (EElementType)int.Parse(parameters.ExtraEffectParameters_[0]);
		foreach (string s in parameters.ExtraEffectParameters_[1].Split(',', StringSplitOptions.None))
		{
			this.DamageIds.Add(long.Parse(s));
		}
	}

	// Token: 0x06017645 RID: 95813 RVA: 0x006E32F5 File Offset: 0x006E14F5
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return this.TargetType;
	}

	// Token: 0x06017646 RID: 95814 RVA: 0x006E3304 File Offset: 0x006E1504
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

	// Token: 0x06017647 RID: 95815 RVA: 0x006E3388 File Offset: 0x006E1588
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C69D RID: 50845
	public EElementType TargetType;

	// Token: 0x0400C69E RID: 50846
	public HashSet<long> DamageIds = new HashSet<long>();
}
