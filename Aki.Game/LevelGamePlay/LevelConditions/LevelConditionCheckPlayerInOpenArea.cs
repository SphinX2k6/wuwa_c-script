using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Map;
using UnrealEngine;

namespace Aki.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x0200302A RID: 12330
	public class LevelConditionCheckPlayerInOpenArea : LevelConditionBase
	{
		// Token: 0x0601D3FE RID: 119806 RVA: 0x008EE594 File Offset: 0x008EC794
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent != null)
			{
				return MapModel.Instance.IsInMapPolygon(characterActorComponent.ActorLocationProxy);
			}
			Log.Instance.Warn(ELogModule.LevelCondition, ELogAuthor.CK, "[CheckPlayerInOpenArea]无法获取玩家角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
	}
}
