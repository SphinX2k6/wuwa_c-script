using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC1 RID: 24257
	public class AdventureDefine : IStaticVariableResetter
	{
		// Token: 0x0603DB19 RID: 252697 RVA: 0x00EE5D10 File Offset: 0x00EE3F10
		static AdventureDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdventureDefine.CreateStaticDefaultValue), new Action(AdventureDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603DB1A RID: 252698 RVA: 0x00EE5D84 File Offset: 0x00EE3F84
		public static void CreateStaticDefaultValue()
		{
			AdventureDefine.checkDungeonTypeCanShowHandlerMap = new Dictionary<EDungeonType, CheckDungeonTypeCanShowHandlerBase>
			{
				{
					EDungeonType.WheelTower,
					new CheckWheelTowerCanShowHandler()
				}
			};
		}

		// Token: 0x0603DB1B RID: 252699 RVA: 0x00EE5D9D File Offset: 0x00EE3F9D
		public static void ResetStaticDefaultValue()
		{
			AdventureDefine.checkDungeonTypeCanShowHandlerMap = null;
		}

		// Token: 0x0402032C RID: 131884
		public const int Monster062DetectConfID = 10010053;

		// Token: 0x0402032D RID: 131885
		public const int BigWorldID = 8;

		// Token: 0x0402032E RID: 131886
		public const int EDEFAULTCATEGORY = 16;

		// Token: 0x0402032F RID: 131887
		public const int WORLD_LEVEL_MIN = 1;

		// Token: 0x04020330 RID: 131888
		public const int WORLD_LEVEL_MAX = 8;

		// Token: 0x04020331 RID: 131889
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static IReadOnlyDictionary<EPeriodicityChallengeType, int> periodicityChallengeTypeToTarget = new Dictionary<EPeriodicityChallengeType, int>
		{
			{
				EPeriodicityChallengeType.None,
				0
			},
			{
				EPeriodicityChallengeType.TowerLow,
				1
			},
			{
				EPeriodicityChallengeType.TowerHigh,
				2
			},
			{
				EPeriodicityChallengeType.TowerVariation,
				3
			},
			{
				EPeriodicityChallengeType.TowerOverLoad,
				4
			},
			{
				EPeriodicityChallengeType.ShipTowerNormal,
				0
			},
			{
				EPeriodicityChallengeType.ShipTowerPeriodicity,
				0
			},
			{
				EPeriodicityChallengeType.WeeklyRogue,
				0
			}
		};

		// Token: 0x04020332 RID: 131890
		[Nullable(1)]
		public static Dictionary<EDungeonType, CheckDungeonTypeCanShowHandlerBase> checkDungeonTypeCanShowHandlerMap;
	}
}
