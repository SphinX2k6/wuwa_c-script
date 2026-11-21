using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA6 RID: 16038
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleDefine : IStaticVariableResetter
	{
		// Token: 0x06028B68 RID: 166760 RVA: 0x00B6A6B8 File Offset: 0x00B688B8
		static RogueBattleDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleDefine.CreateStaticDefaultValue), new Action(RogueBattleDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06028B69 RID: 166761 RVA: 0x00B6A6D7 File Offset: 0x00B688D7
		public static void CreateStaticDefaultValue()
		{
			RogueBattleDefine.FetterTypeIconMap = new Dictionary<ERogueResBondEffectType, string>
			{
				{
					ERogueResBondEffectType.Battle,
					"T_RogueFetters_03"
				},
				{
					ERogueResBondEffectType.Explore,
					"T_RogueFetters_02"
				},
				{
					ERogueResBondEffectType.Link,
					"T_RogueFetters_01"
				}
			};
		}

		// Token: 0x06028B6A RID: 166762 RVA: 0x00B6A707 File Offset: 0x00B68907
		public static void ResetStaticDefaultValue()
		{
			RogueBattleDefine.FetterTypeIconMap = null;
		}

		// Token: 0x06028B6B RID: 166763 RVA: 0x00B6A710 File Offset: 0x00B68910
		public static int SortRogueBattleRoleBondInfo(RoleBondInfo aBondInfo, RoleBondInfo bBondInfo)
		{
			if (aBondInfo.Level != bBondInfo.Level)
			{
				return bBondInfo.Level - aBondInfo.Level;
			}
			if (aBondInfo.CurStar == bBondInfo.CurStar)
			{
				return aBondInfo.ConfigId - bBondInfo.ConfigId;
			}
			return bBondInfo.CurStar - aBondInfo.CurStar;
		}

		// Token: 0x06028B6C RID: 166764 RVA: 0x00B6A764 File Offset: 0x00B68964
		public static int SortRogueBattleRoleBondUpdateInfo(IRogueBattleRoleBondUpdateInfo a, IRogueBattleRoleBondUpdateInfo b)
		{
			RoleBondInfo newRoleBondInfo = a.NewRoleBondInfo;
			RoleBondInfo newRoleBondInfo2 = b.NewRoleBondInfo;
			if (newRoleBondInfo.Level != newRoleBondInfo2.Level)
			{
				return newRoleBondInfo2.Level - newRoleBondInfo.Level;
			}
			if (newRoleBondInfo.CurStar == newRoleBondInfo2.CurStar)
			{
				return newRoleBondInfo.ConfigId - newRoleBondInfo2.ConfigId;
			}
			return newRoleBondInfo2.CurStar - newRoleBondInfo.CurStar;
		}

		// Token: 0x04016228 RID: 90664
		public static Dictionary<ERogueResBondEffectType, string> FetterTypeIconMap;

		// Token: 0x04016229 RID: 90665
		public const int ROLELEVEL_EFFECTSHOW_TAG = 34;

		// Token: 0x0401622A RID: 90666
		public const int SKILLLEVEL_EFFECTSHOW_TAG = 33;

		// Token: 0x0401622B RID: 90667
		public const int WEAPONLEVEL_EFFECTSHOW_TAG = 32;
	}
}
