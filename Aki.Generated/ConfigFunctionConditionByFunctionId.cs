using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035A RID: 858
	public class ConfigFunctionConditionByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x000CB45C File Offset: 0x000C965C
		static ConfigFunctionConditionByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionConditionByFunctionId.CreateStaticDefaultValue), new Action(ConfigFunctionConditionByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000CB47C File Offset: 0x000C967C
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

		// Token: 0x06001423 RID: 5155 RVA: 0x000CB4FB File Offset: 0x000C96FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionConditionByFunctionId.LogPair = null;
			ConfigFunctionConditionByFunctionId.HandleId = 0;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000CB509 File Offset: 0x000C9709
		public static void Init()
		{
			ConfigFunctionConditionByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionConditionByFunctionId.HandleId, "db_function.db", "select BinData from `FunctionCondition` where FunctionId=?");
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000CB524 File Offset: 0x000C9724
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

		// Token: 0x0400175A RID: 5978
		private const string DB = "db_function.db";

		// Token: 0x0400175B RID: 5979
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x0400175C RID: 5980
		private const string TABLE = "FunctionCondition";

		// Token: 0x0400175D RID: 5981
		private const string COMMAND = "select BinData from `FunctionCondition` where FunctionId=?";

		// Token: 0x0400175E RID: 5982
		private const string KEY_PREFIX = "FunctionConditionByFunctionId";

		// Token: 0x0400175F RID: 5983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001760 RID: 5984
		private static int HandleId;
	}
}
