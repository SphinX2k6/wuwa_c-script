using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Input.InputDataTypeCreator
{
	// Token: 0x02006154 RID: 24916
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDataTypeCreatorFactory : IStaticVariableResetter
	{
		// Token: 0x0603BBBE RID: 244670 RVA: 0x010F47EF File Offset: 0x010F29EF
		static InputDataTypeCreatorFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDataTypeCreatorFactory.CreateStaticDefaultValue), new Action(InputDataTypeCreatorFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0603BBBF RID: 244671 RVA: 0x010F4810 File Offset: 0x010F2A10
		public static void Initialize()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.TowerDefenseEvent] = new TrapDefenseInputDataTypeCreator();
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.Survivors] = new SurvivorsRogueInputDataTypeCreator();
			InputDataTypeCreatorFactory.InputDataCreatorMap[EDungeonSubType.PinballBattle] = new PinballBattleInputDataTypeCreator();
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap[EWorldDungeonSubType.SpringManorWorld] = new SpringManorInputDataTypeCreator();
		}

		// Token: 0x0603BBC0 RID: 244672 RVA: 0x010F4860 File Offset: 0x010F2A60
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

		// Token: 0x0603BBC1 RID: 244673 RVA: 0x010F48A2 File Offset: 0x010F2AA2
		public static void CreateStaticDefaultValue()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap = new Dictionary<EDungeonSubType, InputDataTypeCreator>();
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap = new Dictionary<EWorldDungeonSubType, InputDataTypeCreator>();
			InputDataTypeCreatorFactory.DefaultInputDataCreator = new NormalWorldInputDataTypeCreator();
		}

		// Token: 0x0603BBC2 RID: 244674 RVA: 0x010F48C2 File Offset: 0x010F2AC2
		public static void ResetStaticDefaultValue()
		{
			InputDataTypeCreatorFactory.InputDataCreatorMap = null;
			InputDataTypeCreatorFactory.WorldInstanceInputDataCreatorMap = null;
			InputDataTypeCreatorFactory.DefaultInputDataCreator = null;
		}

		// Token: 0x0401F831 RID: 129073
		private static Dictionary<EDungeonSubType, InputDataTypeCreator> InputDataCreatorMap;

		// Token: 0x0401F832 RID: 129074
		private static Dictionary<EWorldDungeonSubType, InputDataTypeCreator> WorldInstanceInputDataCreatorMap;

		// Token: 0x0401F833 RID: 129075
		private static InputDataTypeCreator DefaultInputDataCreator;
	}
}
