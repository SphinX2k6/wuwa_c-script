using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B6 RID: 438
	public class ConfigDaemonHackConfigCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x00093BA1 File Offset: 0x00091DA1
		static ConfigDaemonHackConfigCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaemonHackConfigCsvById.CreateStaticDefaultValue), new Action(ConfigDaemonHackConfigCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00093BC0 File Offset: 0x00091DC0
		public static void CreateStaticDefaultValue()
		{
			ConfigDaemonHackConfigCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDaemonHackConfigCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daemonhackconfigcsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/m.魔偶骇入玩法配置/*.csv*"),
				new ValueTuple<string, object>("表名", "DaemonHackConfigCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `DaemonHackConfigCsv` where Id=?")
			});
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00093C3F File Offset: 0x00091E3F
		public static void ResetStaticDefaultValue()
		{
			ConfigDaemonHackConfigCsvById.LogPair = null;
			ConfigDaemonHackConfigCsvById.HandleId = 0;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00093C4D File Offset: 0x00091E4D
		public static void Init()
		{
			ConfigDaemonHackConfigCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDaemonHackConfigCsvById.HandleId, "db_daemonhackconfigcsv.db", "select BinData from `DaemonHackConfigCsv` where Id=?");
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00093C68 File Offset: 0x00091E68
		public static DaemonHackConfigCsv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDaemonHackConfigCsvById.HandleId, ConfigDaemonHackConfigCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DaemonHackConfigCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DaemonHackConfigCsv?(DaemonHackConfigCsv.GetRootAsDaemonHackConfigCsv(configBuffer));
				}
			}
			ConfigDaemonHackConfigCsvById.LogPair.Clear();
			ConfigDaemonHackConfigCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDaemonHackConfigCsvById.HandleId, 1, p0Id, ConfigDaemonHackConfigCsvById.LogPair) || ConfigCommon.Step(ConfigDaemonHackConfigCsvById.HandleId, true, ConfigDaemonHackConfigCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDaemonHackConfigCsvById.HandleId, ConfigDaemonHackConfigCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDaemonHackConfigCsvById.HandleId, 0, ConfigDaemonHackConfigCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDaemonHackConfigCsvById.HandleId, ConfigDaemonHackConfigCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DaemonHackConfigCsv rootAsDaemonHackConfigCsv = DaemonHackConfigCsv.GetRootAsDaemonHackConfigCsv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DaemonHackConfigCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDaemonHackConfigCsvById.HandleId, ConfigDaemonHackConfigCsvById.LogPair);
			return new DaemonHackConfigCsv?(rootAsDaemonHackConfigCsv);
		}

		// Token: 0x04000BDE RID: 3038
		private const string DB = "db_daemonhackconfigcsv.db";

		// Token: 0x04000BDF RID: 3039
		private const string FILE = "k.可视化编辑/c.Csv/m.魔偶骇入玩法配置/*.csv*";

		// Token: 0x04000BE0 RID: 3040
		private const string TABLE = "DaemonHackConfigCsv";

		// Token: 0x04000BE1 RID: 3041
		private const string COMMAND = "select BinData from `DaemonHackConfigCsv` where Id=?";

		// Token: 0x04000BE2 RID: 3042
		private const string KEY_PREFIX = "DaemonHackConfigCsvById";

		// Token: 0x04000BE3 RID: 3043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BE4 RID: 3044
		private static int HandleId;
	}
}
