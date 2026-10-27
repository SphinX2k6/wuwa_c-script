using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000871 RID: 2161
	public class ConfigRogueWeeklyBuffPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032B8 RID: 12984 RVA: 0x001782EF File Offset: 0x001764EF
		static ConfigRogueWeeklyBuffPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x00178310 File Offset: 0x00176510
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBuffPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBuffPool` where Id=?")
			});
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0017838F File Offset: 0x0017658F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolById.LogPair = null;
			ConfigRogueWeeklyBuffPoolById.HandleId = 0;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x0017839D File Offset: 0x0017659D
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool` where Id=?");
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x001783B8 File Offset: 0x001765B8
		public static RogueWeeklyBuffPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyBuffPool?(RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(configBuffer));
				}
			}
			ConfigRogueWeeklyBuffPoolById.LogPair.Clear();
			ConfigRogueWeeklyBuffPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBuffPoolById.HandleId, 1, p0Id, ConfigRogueWeeklyBuffPoolById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyBuffPoolById.HandleId, true, ConfigRogueWeeklyBuffPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBuffPoolById.HandleId, 0, ConfigRogueWeeklyBuffPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyBuffPool rootAsRogueWeeklyBuffPool = RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolById.HandleId, ConfigRogueWeeklyBuffPoolById.LogPair);
			return new RogueWeeklyBuffPool?(rootAsRogueWeeklyBuffPool);
		}

		// Token: 0x04003AFD RID: 15101
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003AFE RID: 15102
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003AFF RID: 15103
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003B00 RID: 15104
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool` where Id=?";

		// Token: 0x04003B01 RID: 15105
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolById";

		// Token: 0x04003B02 RID: 15106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B03 RID: 15107
		private static int HandleId;
	}
}
