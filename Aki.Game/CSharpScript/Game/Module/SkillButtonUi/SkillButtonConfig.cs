using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004BFE RID: 19454
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonConfig : ConfigBase
	{
		// Token: 0x060324DB RID: 206043 RVA: 0x00BB05CB File Offset: 0x00BAE7CB
		public IReadOnlyList<SkillButton> GetAllSkillButtonConfig(int roleId)
		{
			return ConfigSkillButtonByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x060324DC RID: 206044 RVA: 0x00BB05D4 File Offset: 0x00BAE7D4
		public IReadOnlyList<SkillCommonButton> GetAllSkillCommonButtonConfig()
		{
			return ConfigSkillCommonButtonAll.GetConfigList(true);
		}

		// Token: 0x060324DD RID: 206045 RVA: 0x00BB05DC File Offset: 0x00BAE7DC
		public IReadOnlyList<SkillFollowerButton> GetAllSkillFollowerButtonConfig(int pbDataId)
		{
			return ConfigSkillFollowerButtonByPbDataId.GetConfigList(pbDataId, true);
		}

		// Token: 0x060324DE RID: 206046 RVA: 0x00BB05E5 File Offset: 0x00BAE7E5
		public IReadOnlyList<SkillVehicleButton> GetAllSkillVehicleButtonConfig(int templateId)
		{
			return ConfigSkillVehicleButtonByTemplateId.GetConfigList(templateId, true);
		}

		// Token: 0x060324DF RID: 206047 RVA: 0x00BB05EE File Offset: 0x00BAE7EE
		public IReadOnlyList<SkillPriorityButton> GetAllSkillPriorityButtonConfig()
		{
			return ConfigSkillPriorityButtonAll.GetConfigList(true);
		}

		// Token: 0x060324E0 RID: 206048 RVA: 0x00BB05F6 File Offset: 0x00BAE7F6
		public SkillButtonIndex? GetSkillIndexConfig(int id)
		{
			return ConfigSkillButtonIndexById.GetConfig(id, true);
		}

		// Token: 0x060324E1 RID: 206049 RVA: 0x00BB05FF File Offset: 0x00BAE7FF
		public IReadOnlyList<SkillButtonIndex> GetSkillIndexConfigListByRoleType(int roleType)
		{
			return ConfigSkillButtonIndexByRoleType.GetConfigList(roleType, true);
		}

		// Token: 0x060324E2 RID: 206050 RVA: 0x00BB0608 File Offset: 0x00BAE808
		public SkillIcon? GetSkillIconConfigByTag(int tagId)
		{
			return ConfigSkillIconByTag.GetConfig(tagId, true);
		}

		// Token: 0x060324E3 RID: 206051 RVA: 0x00BB0611 File Offset: 0x00BAE811
		public SkillButtonEffect? GetSkillButtonEffectConfig(int configId)
		{
			return ConfigSkillButtonEffectById.GetConfig(configId, true);
		}

		// Token: 0x060324E4 RID: 206052 RVA: 0x00BB061A File Offset: 0x00BAE81A
		public IReadOnlyList<BehaviorCommonButton> GetAllBehaviorCommonButtonConfig()
		{
			return ConfigBehaviorCommonButtonAll.GetConfigList(true);
		}

		// Token: 0x060324E5 RID: 206053 RVA: 0x00BB0622 File Offset: 0x00BAE822
		public BehaviorCommonButton? GetBehaviorCommonButtonConfig(int configId)
		{
			return ConfigBehaviorCommonButtonById.GetConfig(configId, true);
		}

		// Token: 0x17007C76 RID: 31862
		// (get) Token: 0x060324E6 RID: 206054 RVA: 0x00BB062B File Offset: 0x00BAE82B
		[Nullable(1)]
		public static SkillButtonConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return SkillButtonConfig._Instance;
			}
		}

		// Token: 0x060324E7 RID: 206055 RVA: 0x00BB0632 File Offset: 0x00BAE832
		[NullableContext(1)]
		public static SkillButtonConfig GetOrCreateInstance()
		{
			if (SkillButtonConfig._Instance == null)
			{
				SkillButtonConfig.CreateInstance();
			}
			return SkillButtonConfig._Instance;
		}

		// Token: 0x060324E8 RID: 206056 RVA: 0x00BB0646 File Offset: 0x00BAE846
		public static bool CreateInstance()
		{
			if (SkillButtonConfig._Instance != null)
			{
				return true;
			}
			SkillButtonConfig._Instance = new SkillButtonConfig();
			return true;
		}

		// Token: 0x060324E9 RID: 206057 RVA: 0x00BB065C File Offset: 0x00BAE85C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060324EA RID: 206058 RVA: 0x00BB065E File Offset: 0x00BAE85E
		public static void ResetStaticDefaultValue()
		{
			SkillButtonConfig._Instance = null;
		}

		// Token: 0x060324EB RID: 206059 RVA: 0x00BB0666 File Offset: 0x00BAE866
		static SkillButtonConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillButtonConfig.CreateStaticDefaultValue), new Action(SkillButtonConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AC23 RID: 109603
		private static SkillButtonConfig _Instance;
	}
}
