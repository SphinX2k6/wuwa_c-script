using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x020052FE RID: 21246
	public static class NewbieMainDefine
	{
		// Token: 0x0401BF51 RID: 114513
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<ENewbieMainTabType, IReadOnlyList<string>> NewbieMainBgTextureResourceMap = new Dictionary<ENewbieMainTabType, IReadOnlyList<string>>
		{
			{
				ENewbieMainTabType.Main,
				new string[]
				{
					"T_MissionMainNor",
					"T_MissionMainHold",
					"T_MissionMainPress",
					"T_MissionMainDisable"
				}
			},
			{
				ENewbieMainTabType.Role,
				new string[]
				{
					"T_MissionCompanionNor",
					"T_MissionCompanionHold",
					"T_MissionCompanionPress",
					"T_MissionCompanionDisable"
				}
			}
		};
	}
}
