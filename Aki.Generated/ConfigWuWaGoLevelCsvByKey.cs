using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B75 RID: 2933
	public class ConfigWuWaGoLevelCsvByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044D3 RID: 17619 RVA: 0x001E2858 File Offset: 0x001E0A58
		static ConfigWuWaGoLevelCsvByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWaGoLevelCsvByKey.CreateStaticDefaultValue), new Action(ConfigWuWaGoLevelCsvByKey.ResetStaticDefaultValue));
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001E2878 File Offset: 0x001E0A78
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWaGoLevelCsvByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWaGoLevelCsvByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwagolevelcsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/m.鸣潮GO关卡配置/*.csv*"),
				new ValueTuple<string, object>("表名", "WuWaGoLevelCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWaGoLevelCsv` where Key=?")
			});
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001E28F7 File Offset: 0x001E0AF7
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWaGoLevelCsvByKey.LogPair = null;
			ConfigWuWaGoLevelCsvByKey.HandleId = 0;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001E2905 File Offset: 0x001E0B05
		public static void Init()
		{
			ConfigWuWaGoLevelCsvByKey.HandleId = ConfigCommon.InitDataStatement(ConfigWuWaGoLevelCsvByKey.HandleId, "db_wuwagolevelcsv.db", "select BinData from `WuWaGoLevelCsv` where Key=?");
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x001E2920 File Offset: 0x001E0B20
		public static WuWaGoLevelCsv? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWaGoLevelCsvByKey.HandleId, ConfigWuWaGoLevelCsvByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("WuWaGoLevelCsvByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new WuWaGoLevelCsv?(WuWaGoLevelCsv.GetRootAsWuWaGoLevelCsv(configBuffer));
				}
			}
			ConfigWuWaGoLevelCsvByKey.LogPair.Clear();
			ConfigWuWaGoLevelCsvByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigWuWaGoLevelCsvByKey.HandleId, 1, p0Key, ConfigWuWaGoLevelCsvByKey.LogPair) || ConfigCommon.Step(ConfigWuWaGoLevelCsvByKey.HandleId, true, ConfigWuWaGoLevelCsvByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWuWaGoLevelCsvByKey.HandleId, ConfigWuWaGoLevelCsvByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWaGoLevelCsvByKey.HandleId, 0, ConfigWuWaGoLevelCsvByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWuWaGoLevelCsvByKey.HandleId, ConfigWuWaGoLevelCsvByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WuWaGoLevelCsv rootAsWuWaGoLevelCsv = WuWaGoLevelCsv.GetRootAsWuWaGoLevelCsv(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("WuWaGoLevelCsvByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWuWaGoLevelCsvByKey.HandleId, ConfigWuWaGoLevelCsvByKey.LogPair);
			return new WuWaGoLevelCsv?(rootAsWuWaGoLevelCsv);
		}

		// Token: 0x04005019 RID: 20505
		private const string DB = "db_wuwagolevelcsv.db";

		// Token: 0x0400501A RID: 20506
		private const string FILE = "k.可视化编辑/c.Csv/m.鸣潮GO关卡配置/*.csv*";

		// Token: 0x0400501B RID: 20507
		private const string TABLE = "WuWaGoLevelCsv";

		// Token: 0x0400501C RID: 20508
		private const string COMMAND = "select BinData from `WuWaGoLevelCsv` where Key=?";

		// Token: 0x0400501D RID: 20509
		private const string KEY_PREFIX = "WuWaGoLevelCsvByKey";

		// Token: 0x0400501E RID: 20510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400501F RID: 20511
		private static int HandleId;
	}
}
