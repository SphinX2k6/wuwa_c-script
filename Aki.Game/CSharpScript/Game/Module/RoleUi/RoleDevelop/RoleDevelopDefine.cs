using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CF0 RID: 15600
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopDefine : IStaticVariableResetter
	{
		// Token: 0x06027E7D RID: 163453 RVA: 0x00B27796 File Offset: 0x00B25996
		static RoleDevelopDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevelopDefine.CreateStaticDefaultValue), new Action(RoleDevelopDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06027E7E RID: 163454 RVA: 0x00B277B8 File Offset: 0x00B259B8
		public static void CreateStaticDefaultValue()
		{
			RoleDevelopDefine.roleDevelopCategoryConfig = new List<RoleDevelopCategoryData>
			{
				new RoleDevelopCategoryData
				{
					CategoryType = ERoleDevelopCategoryType.Overview,
					CategoryName = "RoleProject_Overview"
				},
				new RoleDevelopCategoryData
				{
					CategoryType = ERoleDevelopCategoryType.Role,
					CategoryName = "RoleProject_Role"
				},
				new RoleDevelopCategoryData
				{
					CategoryType = ERoleDevelopCategoryType.Weapon,
					CategoryName = "RoleProject_Weapon"
				},
				new RoleDevelopCategoryData
				{
					CategoryType = ERoleDevelopCategoryType.Phantom,
					CategoryName = "RoleProject_Phantom"
				},
				new RoleDevelopCategoryData
				{
					CategoryType = ERoleDevelopCategoryType.Skill,
					CategoryName = "RoleProject_Skill"
				}
			};
			RoleDevelopDefine.roleDevelopHotRoleTagColor = new Dictionary<ERoleDevelopHotRoleTag, string>
			{
				{
					ERoleDevelopHotRoleTag.Forecast,
					"#65d5af"
				},
				{
					ERoleDevelopHotRoleTag.Rerun,
					"#87c6f1"
				},
				{
					ERoleDevelopHotRoleTag.Summon,
					"#d7ba6c"
				},
				{
					ERoleDevelopHotRoleTag.None,
					"#d7ba6c"
				}
			};
		}

		// Token: 0x06027E7F RID: 163455 RVA: 0x00B2789A File Offset: 0x00B25A9A
		public static void ResetStaticDefaultValue()
		{
			RoleDevelopDefine.roleDevelopCategoryConfig = null;
			RoleDevelopDefine.roleDevelopHotRoleTagColor = null;
		}

		// Token: 0x04015C1F RID: 89119
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_PURPLE_QUALITY = 4;

		// Token: 0x04015C20 RID: 89120
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_GOLD_QUALITY = 5;

		// Token: 0x04015C21 RID: 89121
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_PURPLE_SOAR_LEVEL_THRESHOLD = 4;

		// Token: 0x04015C22 RID: 89122
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_GOLD_SOAR_LEVEL_THRESHOLD = 5;

		// Token: 0x04015C23 RID: 89123
		public const int PROSPECT_ROLE_SKILL_TARGET_LEVEL = 10;

		// Token: 0x04015C24 RID: 89124
		public const int PROSPECT_ROLE_SKILL_DEFAULT_LEVEL = 1;

		// Token: 0x04015C25 RID: 89125
		public const int SKILL_PLAN_BREAKTHROUGH_LEVEL_LIMIT = 6;

		// Token: 0x04015C26 RID: 89126
		public const int PHANTOM_FETTER_TRIGGER_THRESHOLD = 5;

		// Token: 0x04015C27 RID: 89127
		public const string ROLE_DEVELOP_ITEM_STATE_TAG_PREFAB = "UiItem_ItemBRoleDevelopTag";

		// Token: 0x04015C28 RID: 89128
		public const string ROLE_DEVELOP_RESULT_LINK_PREFAB = "UiItem_RoleDevelopResultLink";

		// Token: 0x04015C29 RID: 89129
		public static List<RoleDevelopCategoryData> roleDevelopCategoryConfig;

		// Token: 0x04015C2A RID: 89130
		public static Dictionary<ERoleDevelopHotRoleTag, string> roleDevelopHotRoleTagColor;
	}
}
