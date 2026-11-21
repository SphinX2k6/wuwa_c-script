using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DD5 RID: 24021
	public class LevelConditionCheckCharacterTagByEvent : LevelConditionBase
	{
		// Token: 0x0603A68B RID: 239243 RVA: 0x01081968 File Offset: 0x0107FB68
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
