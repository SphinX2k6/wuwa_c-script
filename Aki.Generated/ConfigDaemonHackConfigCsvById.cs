using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C8 RID: 456
	public class ConfigDaemonHackConfigCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x00099AD9 File Offset: 0x00097CD9
		static ConfigDaemonHackConfigCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDaemonHackConfigCsvById.CreateStaticDefaultValue), new Action(ConfigDaemonHackConfigCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00099AF8 File Offset: 0x00097CF8
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

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00099B77 File Offset: 0x00097D77
		public static void ResetStaticDefaultValue()
		{
			ConfigDaemonHackConfigCsvById.LogPair = null;
			ConfigDaemonHackConfigCsvById.HandleId = 0;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00099B85 File Offset: 0x00097D85
		public static void Init()
		{
			ConfigDaemonHackConfigCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDaemonHackConfigCsvById.HandleId, "db_daemonhackconfigcsv.db", "select BinData from `DaemonHackConfigCsv` where Id=?");
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00099BA0 File Offset: 0x00097DA0
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

		// Token: 0x04000C5C RID: 3164
		private const string DB = "db_daemonhackconfigcsv.db";

		// Token: 0x04000C5D RID: 3165
		private const string FILE = "k.可视化编辑/c.Csv/m.魔偶骇入玩法配置/*.csv*";

		// Token: 0x04000C5E RID: 3166
		private const string TABLE = "DaemonHackConfigCsv";

		// Token: 0x04000C5F RID: 3167
		private const string COMMAND = "select BinData from `DaemonHackConfigCsv` where Id=?";

		// Token: 0x04000C60 RID: 3168
		private const string KEY_PREFIX = "DaemonHackConfigCsvById";

		// Token: 0x04000C61 RID: 3169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C62 RID: 3170
		private static int HandleId;
	}
}
