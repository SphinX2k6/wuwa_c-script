using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA6 RID: 20134
	public class AdventureDefine : IStaticVariableResetter
	{
		// Token: 0x06032AA9 RID: 207529 RVA: 0x00E3725C File Offset: 0x00E3545C
		static AdventureDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdventureDefine.CreateStaticDefaultValue), new Action(AdventureDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06032AAA RID: 207530 RVA: 0x00E372D0 File Offset: 0x00E354D0
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

		// Token: 0x06032AAB RID: 207531 RVA: 0x00E372E9 File Offset: 0x00E354E9
		public static void ResetStaticDefaultValue()
		{
			AdventureDefine.checkDungeonTypeCanShowHandlerMap = null;
		}

		// Token: 0x0401ADF3 RID: 110067
		public const int Monster062DetectConfID = 10010053;

		// Token: 0x0401ADF4 RID: 110068
		public const int BigWorldID = 8;

		// Token: 0x0401ADF5 RID: 110069
		public const int EDEFAULTCATEGORY = 16;

		// Token: 0x0401ADF6 RID: 110070
		public const int WORLD_LEVEL_MIN = 1;

		// Token: 0x0401ADF7 RID: 110071
		public const int WORLD_LEVEL_MAX = 8;

		// Token: 0x0401ADF8 RID: 110072
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

		// Token: 0x0401ADF9 RID: 110073
		[Nullable(1)]
		public static Dictionary<EDungeonType, CheckDungeonTypeCanShowHandlerBase> checkDungeonTypeCanShowHandlerMap;
	}
}
