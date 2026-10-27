using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D6 RID: 28886
	[NullableContext(1)]
	[Nullable(0)]
	public static class ManipulateSkillConfig
	{
		// Token: 0x060467C1 RID: 288705 RVA: 0x011B37D0 File Offset: 0x011B19D0
		public static bool IsMechascoutRole(int roleId)
		{
			return RoleConfig.Instance.GetBaseRoleId(roleId) == 5045;
		}

		// Token: 0x060467C2 RID: 288706 RVA: 0x011B37E4 File Offset: 0x011B19E4
		public static ManipulateSkillConfigData GetSkillConfig(int roleId)
		{
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
			return ManipulateSkillConfig.RoleSkillConfigMap.GetValueOrDefault(baseRoleId, ManipulateSkillConfig.DefaultConfig);
		}

		// Token: 0x060467C3 RID: 288707 RVA: 0x011B380D File Offset: 0x011B1A0D
		public static ManipulateSkillConfigData GetDefaultConfig()
		{
			return ManipulateSkillConfig.DefaultConfig;
		}

		// Token: 0x04024F23 RID: 151331
		public const int MechascoutBaseRoleId = 5045;

		// Token: 0x04024F24 RID: 151332
		[StaticVariableRuleIgnore]
		private static readonly ManipulateSkillConfigData DefaultConfig = new ManipulateSkillConfigData
		{
			SkillId = 210003,
			CastSkillId = 210005,
			CancelSkillId = 210006,
			HoldingSkillId = 210007
		};

		// Token: 0x04024F25 RID: 151333
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
