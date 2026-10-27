using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EDD RID: 20189
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleDefine : IStaticVariableResetter
	{
		// Token: 0x06033CFD RID: 212221 RVA: 0x00C211A0 File Offset: 0x00C1F3A0
		static RogueBattleDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleDefine.CreateStaticDefaultValue), new Action(RogueBattleDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06033CFE RID: 212222 RVA: 0x00C211BF File Offset: 0x00C1F3BF
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

		// Token: 0x06033CFF RID: 212223 RVA: 0x00C211EF File Offset: 0x00C1F3EF
		public static void ResetStaticDefaultValue()
		{
			RogueBattleDefine.FetterTypeIconMap = null;
		}

		// Token: 0x06033D00 RID: 212224 RVA: 0x00C211F8 File Offset: 0x00C1F3F8
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

		// Token: 0x06033D01 RID: 212225 RVA: 0x00C2124C File Offset: 0x00C1F44C
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

		// Token: 0x0401B855 RID: 112725
		public static Dictionary<ERogueResBondEffectType, string> FetterTypeIconMap;

		// Token: 0x0401B856 RID: 112726
		public const int ROLELEVEL_EFFECTSHOW_TAG = 34;

		// Token: 0x0401B857 RID: 112727
		public const int SKILLLEVEL_EFFECTSHOW_TAG = 33;

		// Token: 0x0401B858 RID: 112728
		public const int WEAPONLEVEL_EFFECTSHOW_TAG = 32;
	}
}
