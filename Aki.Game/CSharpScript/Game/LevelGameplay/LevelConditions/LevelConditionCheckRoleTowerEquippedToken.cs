using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E64 RID: 24164
	public class LevelConditionCheckRoleTowerEquippedToken : LevelConditionBase
	{
		// Token: 0x0603A7CA RID: 239562 RVA: 0x01088F3C File Offset: 0x0108713C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			RoleTowerModel instance = RoleTowerModel.Instance;
			return instance.IsInRoleTowerDungeon() && instance.GetEquipTokenId() > 0;
		}
	}
}
