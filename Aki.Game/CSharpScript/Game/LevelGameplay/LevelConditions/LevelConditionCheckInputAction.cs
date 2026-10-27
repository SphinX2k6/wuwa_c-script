using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CAA RID: 27818
	public class LevelConditionCheckInputAction : LevelConditionBase
	{
		// Token: 0x060445E4 RID: 280036 RVA: 0x010DBF88 File Offset: 0x010DA188
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
			string limitParams = inConditionInfo.GetLimitParams("Action");
			string limitParams2 = inConditionInfo.GetLimitParams("Kind");
			EActionKind eactionKind = (EActionKind)((limitParams2 != null) ? int.Parse(limitParams2) : 0);
			if (limitParams == null || eactionKind == (EActionKind)0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的参数不符合条件类型");
				defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.CheckInputAction);
				defaultInterpolatedStringHandler.AppendLiteral("的定义");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (eactionKind != EActionKind.ActionInput)
			{
				if (eactionKind != EActionKind.AxisInput)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.LevelCondition;
					ELogAuthor author3 = ELogAuthor.TL;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
					defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
					defaultInterpolatedStringHandler.AppendLiteral("的Kind参数不符合条件类型");
					defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.CheckInputAction);
					defaultInterpolatedStringHandler.AppendLiteral("的定义");
					instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				if (!axisMappings.HasField(limitParams))
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.LevelCondition;
					ELogAuthor author4 = ELogAuthor.TL;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
					defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
					defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
					defaultInterpolatedStringHandler.AppendLiteral("的Kind配了");
					defaultInterpolatedStringHandler.AppendFormatted<int>((int)eactionKind);
					defaultInterpolatedStringHandler.AppendLiteral("(轴映射)，但");
					defaultInterpolatedStringHandler.AppendFormatted(limitParams);
					defaultInterpolatedStringHandler.AppendLiteral("用不是轴映射");
					instance4.Error(module4, author4, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				return limitParams == InputDistributeController.Instance.GetCurrentAxisName();
			}
			else
			{
				if (!actionMappings.HasField(limitParams))
				{
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.LevelCondition;
					ELogAuthor author5 = ELogAuthor.TL;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
					defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
					defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
					defaultInterpolatedStringHandler.AppendLiteral("的Kind配了");
					defaultInterpolatedStringHandler.AppendFormatted<int>((int)eactionKind);
					defaultInterpolatedStringHandler.AppendLiteral("(操作映射)，但");
					defaultInterpolatedStringHandler.AppendFormatted(limitParams);
					defaultInterpolatedStringHandler.AppendLiteral("不是操作映射");
					instance5.Error(module5, author5, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				return limitParams == InputDistributeController.Instance.GetCurrentActionName();
			}
		}
	}
}
