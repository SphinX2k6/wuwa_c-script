using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DD9 RID: 24025
	public class LevelConditionCheckCharacterVehicleTagByEvent : LevelConditionBase
	{
		// Token: 0x0603A6A1 RID: 239265 RVA: 0x01081FE8 File Offset: 0x010801E8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs == null || eventArgs.Length < 4)
			{
				return false;
			}
			if ((int)eventArgs[2] >= (int)eventArgs[3])
			{
				return false;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return false;
			}
			int num = (int)eventArgs[0];
			if (num == getCurrentEntity.Id)
			{
				return true;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				return false;
			}
			CharacterDriveVehicleComponent characterDriveVehicleComponent = characterActorComponent.Entity.CheckGetComponent<CharacterDriveVehicleComponent>();
			if (characterDriveVehicleComponent == null)
			{
				return false;
			}
			Entity vehicleEntity = characterDriveVehicleComponent.VehicleEntity;
			int? num2 = (vehicleEntity != null) ? new int?(vehicleEntity.Id) : null;
			int num3 = num;
			int? num4 = num2;
			return num3 == num4.GetValueOrDefault() & num4 != null;
		}
	}
}
