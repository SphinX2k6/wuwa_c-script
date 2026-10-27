using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CDE RID: 27870
	public class LevelConditionCheckRangeByPbDataId : LevelConditionBase
	{
		// Token: 0x06044658 RID: 280152 RVA: 0x010DE944 File Offset: 0x010DCB44
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs != null && eventArgs.Length == 0)
			{
				return false;
			}
			if (inConditionInfo.LimitParamsLength != 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.JT;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("PbDataId");
			int id = (int)eventArgs[0];
			Entity entity = EntitySystem.Instance.Get(id);
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null;
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				num2 = num;
				num3 = int.Parse(limitParams);
				if (num2.GetValueOrDefault() == num3 & num2 != null)
				{
					return Global.BaseCharacter != null && Global.BaseCharacter.CharacterActorComponent != null;
				}
			}
			return false;
		}
	}
}
