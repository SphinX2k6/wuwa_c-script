using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EFF RID: 24319
	public class LevelConditionSelfGameplayTagCheck : LevelConditionBase
	{
		// Token: 0x0603A920 RID: 239904 RVA: 0x0108E0A4 File Offset: 0x0108C2A4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0 || inTrigger == null)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("GamePlayTag");
			if (limitParams == null)
			{
				return false;
			}
			if (inTrigger is TsBaseCharacter)
			{
				CharacterActorComponent characterActorComponent = ((TsBaseCharacter)inTrigger).CharacterActorComponent;
				bool? flag;
				if (characterActorComponent == null)
				{
					flag = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					if (entity == null)
					{
						flag = null;
					}
					else
					{
						BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
						flag = ((component != null) ? new bool?(component.HasTag(GameplayTagUtils.GetTagIdByName(limitParams))) : null);
					}
				}
				bool? flag2 = flag;
				return flag2.GetValueOrDefault();
			}
			return false;
		}
	}
}
