using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000192 RID: 402
	public class ConfigConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x0008ED8B File Offset: 0x0008CF8B
		static ConfigConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConditionById.CreateStaticDefaultValue), new Action(ConfigConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0008EDAC File Offset: 0x0008CFAC
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

		// Token: 0x06000971 RID: 2417 RVA: 0x0008EE2B File Offset: 0x0008D02B
		public static void ResetStaticDefaultValue()
		{
			ConfigConditionById.LogPair = null;
			ConfigConditionById.HandleId = 0;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0008EE39 File Offset: 0x0008D039
		public static void Init()
		{
			ConfigConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigConditionById.HandleId, "db_condition.db", "select BinData from `Condition` where Id=?");
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0008EE54 File Offset: 0x0008D054
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

		// Token: 0x04000AE2 RID: 2786
		private const string DB = "db_condition.db";

		// Token: 0x04000AE3 RID: 2787
		private const string FILE = "t.条件.xlsx";

		// Token: 0x04000AE4 RID: 2788
		private const string TABLE = "Condition";

		// Token: 0x04000AE5 RID: 2789
		private const string COMMAND = "select BinData from `Condition` where Id=?";

		// Token: 0x04000AE6 RID: 2790
		private const string KEY_PREFIX = "ConditionById";

		// Token: 0x04000AE7 RID: 2791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AE8 RID: 2792
		private static int HandleId;
	}
}
