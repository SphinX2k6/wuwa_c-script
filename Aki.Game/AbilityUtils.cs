using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023AB RID: 9131
[NullableContext(1)]
[Nullable(0)]
public class AbilityUtils
{
	// Token: 0x06016D8B RID: 93579 RVA: 0x006A8997 File Offset: 0x006A6B97
	public static T GetLevelValue<[Nullable(2)] T>([Nullable(new byte[]
	{
		2,
		1
	})] T[] array, int level, T defaultValueIfNotFound)
	{
		if (array == null || array.Length == 0)
		{
			return defaultValueIfNotFound;
		}
		if (level >= 1 && level - 1 < array.Length)
		{
			return array[level - 1];
		}
		if (level == 0)
		{
			return array[0];
		}
		return array[array.Length - 1];
	}

	// Token: 0x06016D8C RID: 93580 RVA: 0x006A89CE File Offset: 0x006A6BCE
	[NullableContext(2)]
	public static double GetArrayValue(double[] array, int index, double defaultValueIfNotFound)
	{
		if (array == null || array.Length == 0 || index < 0)
		{
			return defaultValueIfNotFound;
		}
		if (index < array.Length)
		{
			return array[index];
		}
		return array[array.Length - 1];
	}

	// Token: 0x06016D8D RID: 93581 RVA: 0x006A89EE File Offset: 0x006A6BEE
	[NullableContext(2)]
	public static float GetAttrValue(IAttributeSet attrSet, EAttributeType attrId, EAttributeBasedFloatCalculationType attrCalcPolicy)
	{
		if (attrSet == null)
		{
			return 0f;
		}
		switch (attrCalcPolicy)
		{
		case EAttributeBasedFloatCalculationType.CurrentValue:
			return attrSet.GetCurrentValue(attrId);
		case EAttributeBasedFloatCalculationType.BonusValue:
			return attrSet.GetCurrentValue(attrId) - attrSet.GetBaseValue(attrId);
		}
		return attrSet.GetBaseValue(attrId);
	}

	// Token: 0x06016D8E RID: 93582 RVA: 0x006A8A2C File Offset: 0x006A6C2C
	public static void SetSpecialEnergyAttrValue(int entityId, int attrId, float value)
	{
		if (!CharacterAttributeTypes.specialEnergyIds.Contains((EAttributeType)attrId))
		{
			return;
		}
		BaseAttributeComponent component = EntitySystem.Instance.GetComponent<BaseAttributeComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetBaseValue((EAttributeType)attrId, value);
		}
	}

	// Token: 0x06016D8F RID: 93583 RVA: 0x006A8A68 File Offset: 0x006A6C68
	public static bool ModifyFuLuoLuoSpecialEnergy(Entity target, int energyType)
	{
		SpecialSkillBase specialSkillBase;
		if (target == null)
		{
			specialSkillBase = null;
		}
		else
		{
			CharacterSpecialSkillComponent component = target.GetComponent<CharacterSpecialSkillComponent>();
			specialSkillBase = ((component != null) ? component.SpecialSkill : null);
		}
		SpecialSkillBase specialSkillBase2 = specialSkillBase;
		if (specialSkillBase2 == null)
		{
			return false;
		}
		SpecialSkillFuLuoLuo specialSkillFuLuoLuo = specialSkillBase2 as SpecialSkillFuLuoLuo;
		if (specialSkillFuLuoLuo != null)
		{
			if (energyType == 0)
			{
				specialSkillFuLuoLuo.RemoveSpecialEnergy();
			}
			else
			{
				specialSkillFuLuoLuo.AddSpecialEnergy(energyType);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06016D90 RID: 93584 RVA: 0x006A8AB4 File Offset: 0x006A6CB4
	public static int GetFuLuoLuoSpecialEnergyType(Entity target, int index)
	{
		SpecialSkillBase specialSkillBase;
		if (target == null)
		{
			specialSkillBase = null;
		}
		else
		{
			CharacterSpecialSkillComponent component = target.GetComponent<CharacterSpecialSkillComponent>();
			specialSkillBase = ((component != null) ? component.SpecialSkill : null);
		}
		SpecialSkillBase specialSkillBase2 = specialSkillBase;
		if (specialSkillBase2 == null)
		{
			return 0;
		}
		SpecialSkillFuLuoLuo specialSkillFuLuoLuo = specialSkillBase2 as SpecialSkillFuLuoLuo;
		if (specialSkillFuLuoLuo != null)
		{
			return specialSkillFuLuoLuo.GetSpecialEnergyType(index);
		}
		return 0;
	}
}
