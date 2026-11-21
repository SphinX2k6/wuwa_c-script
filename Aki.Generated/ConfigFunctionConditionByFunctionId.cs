using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036F RID: 879
	public class ConfigFunctionConditionByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600149F RID: 5279 RVA: 0x000D1968 File Offset: 0x000CFB68
		static ConfigFunctionConditionByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionConditionByFunctionId.CreateStaticDefaultValue), new Action(ConfigFunctionConditionByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x000D1988 File Offset: 0x000CFB88
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionConditionByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionConditionByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionCondition` where FunctionId=?")
			});
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000D1A07 File Offset: 0x000CFC07
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionConditionByFunctionId.LogPair = null;
			ConfigFunctionConditionByFunctionId.HandleId = 0;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000D1A15 File Offset: 0x000CFC15
		public static void Init()
		{
			ConfigFunctionConditionByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionConditionByFunctionId.HandleId, "db_function.db", "select BinData from `FunctionCondition` where FunctionId=?");
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000D1A30 File Offset: 0x000CFC30
		public static FunctionCondition? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionConditionByFunctionId.HandleId, ConfigFunctionConditionByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionConditionByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FunctionCondition?(FunctionCondition.GetRootAsFunctionCondition(configBuffer));
				}
			}
			ConfigFunctionConditionByFunctionId.LogPair.Clear();
			ConfigFunctionConditionByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigFunctionConditionByFunctionId.HandleId, 1, p0FunctionId, ConfigFunctionConditionByFunctionId.LogPair) || ConfigCommon.Step(ConfigFunctionConditionByFunctionId.HandleId, true, ConfigFunctionConditionByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFunctionConditionByFunctionId.HandleId, ConfigFunctionConditionByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionConditionByFunctionId.HandleId, 0, ConfigFunctionConditionByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFunctionConditionByFunctionId.HandleId, ConfigFunctionConditionByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FunctionCondition rootAsFunctionCondition = FunctionCondition.GetRootAsFunctionCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionConditionByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFunctionConditionByFunctionId.HandleId, ConfigFunctionConditionByFunctionId.LogPair);
			return new FunctionCondition?(rootAsFunctionCondition);
		}

		// Token: 0x040017ED RID: 6125
		private const string DB = "db_function.db";

		// Token: 0x040017EE RID: 6126
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x040017EF RID: 6127
		private const string TABLE = "FunctionCondition";

		// Token: 0x040017F0 RID: 6128
		private const string COMMAND = "select BinData from `FunctionCondition` where FunctionId=?";

		// Token: 0x040017F1 RID: 6129
		private const string KEY_PREFIX = "FunctionConditionByFunctionId";

		// Token: 0x040017F2 RID: 6130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017F3 RID: 6131
		private static int HandleId;
	}
}
