using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE2 RID: 24290
	public class LevelConditionOnSceneItemDurabilityEmpty : LevelConditionBase
	{
		// Token: 0x0603A8D0 RID: 239824 RVA: 0x0108CB70 File Offset: 0x0108AD70
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("EntityTemplateId");
			if (limitParams == null)
			{
				return true;
			}
			int num;
			if (int.TryParse(limitParams, out num))
			{
				Entity entity = (Entity)eventArgs[0];
				int? num2;
				if (entity == null)
				{
					num2 = null;
				}
				else
				{
					CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
					num2 = ((component != null) ? new int?(component.GetTemplateId()) : null);
				}
				int? num3 = num2;
				int num4 = num;
				return num3.GetValueOrDefault() == num4 & num3 != null;
			}
			return false;
		}
	}
}
