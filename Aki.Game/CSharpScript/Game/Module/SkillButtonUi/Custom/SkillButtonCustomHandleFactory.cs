using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BDA RID: 15322
	[NullableContext(2)]
	[Nullable(0)]
	public static class SkillButtonCustomHandleFactory
	{
		// Token: 0x060274E5 RID: 160997 RVA: 0x00B06650 File Offset: 0x00B04850
		public static SkillButtonCustomHandleBase GetSkillButtonCustomHandleById(int customHandleId)
		{
			if (customHandleId == 0)
			{
				return null;
			}
			SkillButtonCustom? config = ConfigSkillButtonCustomById.GetConfig(customHandleId, true);
			if (config == null)
			{
				return null;
			}
			SkillButtonCustomHandleBase skillButtonCustomHandleByType = SkillButtonCustomHandleFactory.GetSkillButtonCustomHandleByType((ESkillButtonCustomHandle)config.Value.Type);
			if (skillButtonCustomHandleByType != null)
			{
				SkillButtonCustom value = config.Value;
				skillButtonCustomHandleByType.TagIds.AddRange(value.GetTagIdsArray() ?? Array.Empty<int>());
				skillButtonCustomHandleByType.BuffIds.AddRange(value.GetBuffIdsArray() ?? Array.Empty<long>());
				for (int i = 0; i < value.ParamsLength; i++)
				{
					skillButtonCustomHandleByType.Params.Add(value.Params(i));
				}
			}
			return skillButtonCustomHandleByType;
		}

		// Token: 0x060274E6 RID: 160998 RVA: 0x00B066F8 File Offset: 0x00B048F8
		public static SkillButtonCustomHandleBase GetSkillButtonCustomHandleByType(ESkillButtonCustomHandle customHandleType)
		{
			Type type;
			if (SkillButtonCustomHandleFactory.Map.TryGetValue(customHandleType, out type) && type != null)
			{
				SkillButtonCustomHandleBase skillButtonCustomHandleBase = Activator.CreateInstance(type) as SkillButtonCustomHandleBase;
				skillButtonCustomHandleBase.HandleType = customHandleType;
				return skillButtonCustomHandleBase;
			}
			return null;
		}

		// Token: 0x060274E7 RID: 160999 RVA: 0x00B06734 File Offset: 0x00B04934
		// Note: this type is marked as 'beforefieldinit'.
		static SkillButtonCustomHandleFactory()
		{
			Dictionary<ESkillButtonCustomHandle, Type> dictionary = new Dictionary<ESkillButtonCustomHandle, Type>();
			dictionary[ESkillButtonCustomHandle.KeLaiTaUltimate] = typeof(SkillButtonCustomHandleKeLaiTaUltimate);
			dictionary[ESkillButtonCustomHandle.HackFollowAttack] = typeof(SkillButtonCustomHandleHackFollowAttach);
			dictionary[ESkillButtonCustomHandle.ZanNiUltimate] = typeof(SkillButtonCustomHandleZanNiUltimate);
			dictionary[ESkillButtonCustomHandle.AimisiMobileUpDown] = typeof(SkillButtonCustomHandleAimisiMobileUpDown);
			dictionary[ESkillButtonCustomHandle.DotIndicator] = typeof(SkillButtonCustomHandleDotIndicator);
			dictionary[ESkillButtonCustomHandle.SharedHoldRingFx] = typeof(SkillButtonCustomHandleSharedHoldRingFx);
			dictionary[ESkillButtonCustomHandle.HoldRingFxSimulateRestore] = typeof(SkillButtonCustomHandleHoldRingFxSimulateRestore);
			dictionary[ESkillButtonCustomHandle.OverrideAttributeColorByTag] = typeof(SkillButtonCustomHandleOverrideAttributeColorByTag);
			dictionary[ESkillButtonCustomHandle.ExploreAsFight] = typeof(SkillButtonCustomHandleExploreAsFight);
			dictionary[ESkillButtonCustomHandle.ButtonDisappear] = typeof(SkillButtonCustomHandleButtonDisappear);
			SkillButtonCustomHandleFactory.Map = dictionary;
		}

		// Token: 0x04015716 RID: 87830
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static Dictionary<ESkillButtonCustomHandle, Type> Map;
	}
}
