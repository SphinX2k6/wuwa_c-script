using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C77 RID: 27767
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckDungeonTypes : LevelConditionBase, IStaticVariableResetter
	{
		// Token: 0x06044578 RID: 279928 RVA: 0x010D92C0 File Offset: 0x010D74C0
		static LevelConditionCheckDungeonTypes()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelConditionCheckDungeonTypes.CreateStaticDefaultValue), new Action(LevelConditionCheckDungeonTypes.ResetStaticDefaultValue));
		}

		// Token: 0x06044579 RID: 279929 RVA: 0x010D93C0 File Offset: 0x010D75C0
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			LevelConditionCheckDungeonTypes.typeSet.Clear();
			LevelConditionCheckDungeonTypes.subTypeSet.Clear();
			foreach (string[] array2 in LevelConditionCheckDungeonTypes.paramList)
			{
				string limitParams = inConditionInfo.GetLimitParams(array2[0]);
				if (limitParams != null)
				{
					break;
				}
				string limitParams2 = inConditionInfo.GetLimitParams(array2[1]);
				if (limitParams2 != null)
				{
					break;
				}
				int item = 0;
				int item2 = 0;
				bool flag = int.TryParse(limitParams, out item);
				bool flag2 = int.TryParse(limitParams2, out item2);
				if (flag && flag2)
				{
					LevelConditionCheckDungeonTypes.typeSet.Add(item);
					LevelConditionCheckDungeonTypes.subTypeSet.Add(item2);
				}
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
			return instanceDungeon != null && LevelConditionCheckDungeonTypes.typeSet.Contains(instanceDungeon.Value.InstType) && LevelConditionCheckDungeonTypes.subTypeSet.Contains(instanceDungeon.Value.InstSubType);
		}

		// Token: 0x0604457A RID: 279930 RVA: 0x010D94C4 File Offset: 0x010D76C4
		public static void CreateStaticDefaultValue()
		{
			LevelConditionCheckDungeonTypes.typeSet = new HashSet<int>();
			LevelConditionCheckDungeonTypes.subTypeSet = new HashSet<int>();
		}

		// Token: 0x0604457B RID: 279931 RVA: 0x010D94DA File Offset: 0x010D76DA
		public static void ResetStaticDefaultValue()
		{
			LevelConditionCheckDungeonTypes.typeSet = null;
			LevelConditionCheckDungeonTypes.subTypeSet = null;
		}

		// Token: 0x040239B9 RID: 145849
		[StaticVariableRuleIgnore]
		private static readonly string[][] paramList = new string[][]
		{
			new string[]
			{
				"Type1",
				"SubType1"
			},
			new string[]
			{
				"Type2",
				"SubType2"
			},
			new string[]
			{
				"Type3",
				"SubType3"
			},
			new string[]
			{
				"Type4",
				"SubType4"
			},
			new string[]
			{
				"Type5",
				"SubType5"
			},
			new string[]
			{
				"Type6",
				"SubType6"
			},
			new string[]
			{
				"Type7",
				"SubType7"
			},
			new string[]
			{
				"Type8",
				"SubType8"
			}
		};

		// Token: 0x040239BA RID: 145850
		private static HashSet<int> typeSet;

		// Token: 0x040239BB RID: 145851
		private static HashSet<int> subTypeSet;
	}
}
