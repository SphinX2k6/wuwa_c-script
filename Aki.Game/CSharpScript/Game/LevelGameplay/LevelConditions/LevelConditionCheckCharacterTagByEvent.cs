using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C5B RID: 27739
	public class LevelConditionCheckCharacterTagByEvent : LevelConditionBase
	{
		// Token: 0x06044531 RID: 279857 RVA: 0x010D79D0 File Offset: 0x010D5BD0
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
			return getCurrentEntity != null && (int)eventArgs[0] == getCurrentEntity.Id;
		}
	}
}
