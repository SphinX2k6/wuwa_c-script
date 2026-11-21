using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A4 RID: 420
	public class ConfigConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00094CC3 File Offset: 0x00092EC3
		static ConfigConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConditionById.CreateStaticDefaultValue), new Action(ConfigConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00094CE4 File Offset: 0x00092EE4
		public static void CreateStaticDefaultValue()
		{
			ConfigConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_condition.db"),
				new ValueTuple<string, object>("文件", "t.条件.xlsx"),
				new ValueTuple<string, object>("表名", "Condition"),
				new ValueTuple<string, object>("语句", "select BinData from `Condition` where Id=?")
			});
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00094D63 File Offset: 0x00092F63
		public static void ResetStaticDefaultValue()
		{
			ConfigConditionById.LogPair = null;
			ConfigConditionById.HandleId = 0;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00094D71 File Offset: 0x00092F71
		public static void Init()
		{
			ConfigConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigConditionById.HandleId, "db_condition.db", "select BinData from `Condition` where Id=?");
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00094D8C File Offset: 0x00092F8C
		public static Condition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConditionById.HandleId, ConfigConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Condition?(Condition.GetRootAsCondition(configBuffer));
				}
			}
			ConfigConditionById.LogPair.Clear();
			ConfigConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConditionById.HandleId, 1, p0Id, ConfigConditionById.LogPair) || ConfigCommon.Step(ConfigConditionById.HandleId, true, ConfigConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConditionById.HandleId, ConfigConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConditionById.HandleId, 0, ConfigConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConditionById.HandleId, ConfigConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Condition rootAsCondition = Condition.GetRootAsCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConditionById.HandleId, ConfigConditionById.LogPair);
			return new Condition?(rootAsCondition);
		}

		// Token: 0x04000B60 RID: 2912
		private const string DB = "db_condition.db";

		// Token: 0x04000B61 RID: 2913
		private const string FILE = "t.条件.xlsx";

		// Token: 0x04000B62 RID: 2914
		private const string TABLE = "Condition";

		// Token: 0x04000B63 RID: 2915
		private const string COMMAND = "select BinData from `Condition` where Id=?";

		// Token: 0x04000B64 RID: 2916
		private const string KEY_PREFIX = "ConditionById";

		// Token: 0x04000B65 RID: 2917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B66 RID: 2918
		private static int HandleId;
	}
}
