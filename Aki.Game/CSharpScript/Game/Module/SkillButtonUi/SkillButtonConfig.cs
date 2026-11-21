using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BAF RID: 15279
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonConfig : ConfigBase
	{
		// Token: 0x06027281 RID: 160385 RVA: 0x00AF4BDF File Offset: 0x00AF2DDF
		public IReadOnlyList<SkillButton> GetAllSkillButtonConfig(int roleId)
		{
			return ConfigSkillButtonByRoleId.GetConfigList(roleId, true);
		}

		// Token: 0x06027282 RID: 160386 RVA: 0x00AF4BE8 File Offset: 0x00AF2DE8
		public IReadOnlyList<SkillCommonButton> GetAllSkillCommonButtonConfig()
		{
			return ConfigSkillCommonButtonAll.GetConfigList(true);
		}

		// Token: 0x06027283 RID: 160387 RVA: 0x00AF4BF0 File Offset: 0x00AF2DF0
		public IReadOnlyList<SkillFollowerButton> GetAllSkillFollowerButtonConfig(int pbDataId)
		{
			return ConfigSkillFollowerButtonByPbDataId.GetConfigList(pbDataId, true);
		}

		// Token: 0x06027284 RID: 160388 RVA: 0x00AF4BF9 File Offset: 0x00AF2DF9
		public IReadOnlyList<SkillVehicleButton> GetAllSkillVehicleButtonConfig(int templateId)
		{
			return ConfigSkillVehicleButtonByTemplateId.GetConfigList(templateId, true);
		}

		// Token: 0x06027285 RID: 160389 RVA: 0x00AF4C02 File Offset: 0x00AF2E02
		public IReadOnlyList<SkillPriorityButton> GetAllSkillPriorityButtonConfig()
		{
			return ConfigSkillPriorityButtonAll.GetConfigList(true);
		}

		// Token: 0x06027286 RID: 160390 RVA: 0x00AF4C0A File Offset: 0x00AF2E0A
		public SkillButtonIndex? GetSkillIndexConfig(int id)
		{
			return ConfigSkillButtonIndexById.GetConfig(id, true);
		}

		// Token: 0x06027287 RID: 160391 RVA: 0x00AF4C13 File Offset: 0x00AF2E13
		public IReadOnlyList<SkillButtonIndex> GetSkillIndexConfigListByRoleType(int roleType)
		{
			return ConfigSkillButtonIndexByRoleType.GetConfigList(roleType, true);
		}

		// Token: 0x06027288 RID: 160392 RVA: 0x00AF4C1C File Offset: 0x00AF2E1C
		public SkillIcon? GetSkillIconConfigByTag(int tagId)
		{
			return ConfigSkillIconByTag.GetConfig(tagId, true);
		}

		// Token: 0x06027289 RID: 160393 RVA: 0x00AF4C25 File Offset: 0x00AF2E25
		public SkillButtonEffect? GetSkillButtonEffectConfig(int configId)
		{
			return ConfigSkillButtonEffectById.GetConfig(configId, true);
		}

		// Token: 0x0602728A RID: 160394 RVA: 0x00AF4C2E File Offset: 0x00AF2E2E
		public IReadOnlyList<BehaviorCommonButton> GetAllBehaviorCommonButtonConfig()
		{
			return ConfigBehaviorCommonButtonAll.GetConfigList(true);
		}

		// Token: 0x0602728B RID: 160395 RVA: 0x00AF4C36 File Offset: 0x00AF2E36
		public BehaviorCommonButton? GetBehaviorCommonButtonConfig(int configId)
		{
			return ConfigBehaviorCommonButtonById.GetConfig(configId, true);
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x0602728C RID: 160396 RVA: 0x00AF4C3F File Offset: 0x00AF2E3F
		[Nullable(1)]
		public static SkillButtonConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return SkillButtonConfig._Instance;
			}
		}

		// Token: 0x0602728D RID: 160397 RVA: 0x00AF4C46 File Offset: 0x00AF2E46
		[NullableContext(1)]
		public static SkillButtonConfig GetOrCreateInstance()
		{
			if (SkillButtonConfig._Instance == null)
			{
				SkillButtonConfig.CreateInstance();
			}
			return SkillButtonConfig._Instance;
		}

		// Token: 0x0602728E RID: 160398 RVA: 0x00AF4C5A File Offset: 0x00AF2E5A
		public static bool CreateInstance()
		{
			if (SkillButtonConfig._Instance != null)
			{
				return true;
			}
			SkillButtonConfig._Instance = new SkillButtonConfig();
			return true;
		}

		// Token: 0x0602728F RID: 160399 RVA: 0x00AF4C70 File Offset: 0x00AF2E70
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027290 RID: 160400 RVA: 0x00AF4C72 File Offset: 0x00AF2E72
		public static void ResetStaticDefaultValue()
		{
			SkillButtonConfig._Instance = null;
		}

		// Token: 0x06027291 RID: 160401 RVA: 0x00AF4C7A File Offset: 0x00AF2E7A
		static SkillButtonConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillButtonConfig.CreateStaticDefaultValue), new Action(SkillButtonConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401557D RID: 87421
		private static SkillButtonConfig _Instance;
	}
}
