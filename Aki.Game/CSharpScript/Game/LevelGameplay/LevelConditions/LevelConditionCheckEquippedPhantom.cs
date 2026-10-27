using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C87 RID: 27783
	public class LevelConditionCheckEquippedPhantom : LevelConditionBase
	{
		// Token: 0x060445A0 RID: 279968 RVA: 0x010DAA78 File Offset: 0x010D8C78
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("声骸位置"));
			int num2 = int.Parse(inConditionInfo.GetLimitParams("是否装备"));
			if (num != 0 && (num <= 0 || num > 5))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的声骸位置值的范围是[");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(5);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (num2 != 0 && num2 != 1)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelCondition;
				ELogAuthor author3 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的是否装备应该是0或1");
				instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
			if (currentFormationData == null)
			{
				return false;
			}
			int valueOrDefault = currentFormationData.CurrentRoleConfigId.GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				return false;
			}
			int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(valueOrDefault, num - 1);
			return num2 != 0 == (equipByIndex != 0);
		}
	}
}
