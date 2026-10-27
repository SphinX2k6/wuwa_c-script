using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Input.InputDataTypeCreator
{
	// Token: 0x02006FD3 RID: 28627
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDataTypeCreatorFactory : IStaticVariableResetter
	{
		// Token: 0x06045A0D RID: 285197 RVA: 0x0114A9FB File Offset: 0x01148BFB
		static InputDataTypeCreatorFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDataTypeCreatorFactory.CreateStaticDefaultValue), new Action(InputDataTypeCreatorFactory.ResetStaticDefaultValue));
		}

		// Token: 0x06045A0E RID: 285198 RVA: 0x0114AA1C File Offset: 0x01148C1C
		public static void Initialize()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.TowerDefenseEvent] = new TrapDefenseInputDataTypeCreator();
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.Survivors] = new SurvivorsRogueInputDataTypeCreator();
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.PinballBattle] = new PinballBattleInputDataTypeCreator();
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap[EWorldDungeonSubType.SpringManorWorld] = new SpringManorInputDataTypeCreator();
		}

		// Token: 0x06045A0F RID: 285199 RVA: 0x0114AA6C File Offset: 0x01148C6C
		public static InputDataTypeCreator GetInputDataCreator(EDungeonSubType dungeonSubType, EWorldDungeonSubType worldDungeonSubType)
		{
			InputDataTypeCreator inputDataTypeCreator = null;
			InputDataTypeCreator inputDataTypeCreator3;
			if (dungeonSubType == EDungeonSubType.WorldInstance)
			{
				InputDataTypeCreator inputDataTypeCreator2;
				if (InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap.TryGetValue(worldDungeonSubType, out inputDataTypeCreator2))
				{
					inputDataTypeCreator = inputDataTypeCreator2;
				}
			}
			else if (InputDataTypeCreatorFactory.InputDataCreatorMap.TryGetValue(dungeonSubType, out inputDataTypeCreator3))
			{
				inputDataTypeCreator = inputDataTypeCreator3;
			}
			if (inputDataTypeCreator != null)
			{
				return inputDataTypeCreator;
			}
			return InputDataTypeCreatorFactory.DefaultInputDataCreator;
		}

		// Token: 0x06045A10 RID: 285200 RVA: 0x0114AAAE File Offset: 0x01148CAE
		public static void CreateStaticDefaultValue()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap = new Dictionary<EDungeonSubType, InputDataTypeCreator>();
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap = new Dictionary<EWorldDungeonSubType, InputDataTypeCreator>();
			InputDataTypeCreatorFactory.DefaultInputDataCreator = new NormalWorldInputDataTypeCreator();
		}

		// Token: 0x06045A11 RID: 285201 RVA: 0x0114AACE File Offset: 0x01148CCE
		public static void ResetStaticDefaultValue()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap = null;
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap = null;
			InputDataTypeCreatorFactory.DefaultInputDataCreator = null;
		}

		// Token: 0x0402457C RID: 148860
		private static Dictionary<EDungeonSubType, InputDataTypeCreator> InputDataCreatorMap;

		// Token: 0x0402457D RID: 148861
		private static Dictionary<EWorldDungeonSubType, InputDataTypeCreator> WorldInstanceInputDataCreatorMap;

		// Token: 0x0402457E RID: 148862
		private static InputDataTypeCreator DefaultInputDataCreator;
	}
}
