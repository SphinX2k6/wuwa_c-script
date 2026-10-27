using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E59 RID: 11865
[NullableContext(1)]
[Nullable(0)]
public class AbilityUtils
{
	// Token: 0x060194D1 RID: 103633 RVA: 0x00682605 File Offset: 0x00680805
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

	// Token: 0x060194D2 RID: 103634 RVA: 0x0068263C File Offset: 0x0068083C
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

	// Token: 0x060194D3 RID: 103635 RVA: 0x0068265C File Offset: 0x0068085C
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

	// Token: 0x060194D4 RID: 103636 RVA: 0x0068269C File Offset: 0x0068089C
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

	// Token: 0x060194D5 RID: 103637 RVA: 0x006826D8 File Offset: 0x006808D8
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

	// Token: 0x060194D6 RID: 103638 RVA: 0x00682724 File Offset: 0x00680924
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
