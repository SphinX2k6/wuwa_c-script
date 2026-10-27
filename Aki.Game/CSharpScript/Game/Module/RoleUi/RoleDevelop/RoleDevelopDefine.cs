using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D31 RID: 19761
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopDefine : IStaticVariableResetter
	{
		// Token: 0x06033092 RID: 209042 RVA: 0x00BE1E25 File Offset: 0x00BE0025
		static RoleDevelopDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevelopDefine.CreateStaticDefaultValue), new Action(RoleDevelopDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06033093 RID: 209043 RVA: 0x00BE1E44 File Offset: 0x00BE0044
		public static void CreateStaticDefaultValue()
		{
			RoleDevelopDefine.roleDevelopCategoryConfig = new List<RoleDevelopCategoryData>
			{
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

		// Token: 0x06033094 RID: 209044 RVA: 0x00BE1F09 File Offset: 0x00BE0109
		public static void ResetStaticDefaultValue()
		{
			RoleDevelopDefine.roleDevelopCategoryConfig = null;
			RoleDevelopDefine.roleDevelopHotRoleTagColor = null;
		}

		// Token: 0x0401B266 RID: 111206
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_PURPLE_QUALITY = 4;

		// Token: 0x0401B267 RID: 111207
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_GOLD_QUALITY = 5;

		// Token: 0x0401B268 RID: 111208
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_PURPLE_SOAR_LEVEL_THRESHOLD = 4;

		// Token: 0x0401B269 RID: 111209
		public const int ROLE_DEVELOP_WORLD_DROP_PROMPT_GOLD_SOAR_LEVEL_THRESHOLD = 5;

		// Token: 0x0401B26A RID: 111210
		public const int PROSPECT_ROLE_SKILL_TARGET_LEVEL = 10;

		// Token: 0x0401B26B RID: 111211
		public const int PROSPECT_ROLE_SKILL_DEFAULT_LEVEL = 1;

		// Token: 0x0401B26C RID: 111212
		public const int SKILL_PLAN_BREAKTHROUGH_LEVEL_LIMIT = 6;

		// Token: 0x0401B26D RID: 111213
		public const string ROLE_DEVELOP_ITEM_STATE_TAG_PREFAB = "UiItem_ItemBRoleDevelopTag";

		// Token: 0x0401B26E RID: 111214
		public const string ROLE_DEVELOP_RESULT_LINK_PREFAB = "UiItem_RoleDevelopResultLink";

		// Token: 0x0401B26F RID: 111215
		public static List<RoleDevelopCategoryData> roleDevelopCategoryConfig;

		// Token: 0x0401B270 RID: 111216
		public static Dictionary<ERoleDevelopHotRoleTag, string> roleDevelopHotRoleTagColor;
	}
}
