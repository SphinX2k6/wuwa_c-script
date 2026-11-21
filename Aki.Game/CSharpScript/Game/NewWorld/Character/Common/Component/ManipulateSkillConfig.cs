using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200633A RID: 25402
	[NullableContext(1)]
	[Nullable(0)]
	public static class ManipulateSkillConfig
	{
		// Token: 0x0603D8C8 RID: 252104 RVA: 0x011D286D File Offset: 0x011D0A6D
		public static bool IsMechascoutRole(int roleId)
		{
			return RoleConfig.Instance.GetBaseRoleId(roleId) == 5045;
		}

		// Token: 0x0603D8C9 RID: 252105 RVA: 0x011D2884 File Offset: 0x011D0A84
		public static ManipulateSkillConfigData GetSkillConfig(int roleId)
		{
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
			return ManipulateSkillConfig.RoleSkillConfigMap.GetValueOrDefault(baseRoleId, ManipulateSkillConfig.DefaultConfig);
		}

		// Token: 0x0603D8CA RID: 252106 RVA: 0x011D28AD File Offset: 0x011D0AAD
		public static ManipulateSkillConfigData GetDefaultConfig()
		{
			return ManipulateSkillConfig.DefaultConfig;
		}

		// Token: 0x04020A62 RID: 133730
		public const int MechascoutBaseRoleId = 5045;

		// Token: 0x04020A63 RID: 133731
		[StaticVariableRuleIgnore]
		private static readonly ManipulateSkillConfigData DefaultConfig = new ManipulateSkillConfigData
		{
			SkillId = 210003,
			CastSkillId = 210005,
			CancelSkillId = 210006,
			HoldingSkillId = 210007
		};

		// Token: 0x04020A64 RID: 133732
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, ManipulateSkillConfigData> RoleSkillConfigMap = new Dictionary<int, ManipulateSkillConfigData>
		{
			{
				5045,
				new ManipulateSkillConfigData
				{
					SkillId = 5045006,
					CastSkillId = 5045007,
					CancelSkillId = 5045016,
					HoldingSkillId = 5045017
				}
			}
		};
	}
}
