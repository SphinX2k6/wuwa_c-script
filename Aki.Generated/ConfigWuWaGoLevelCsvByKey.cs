using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA0 RID: 2720
	public class ConfigWuWaGoLevelCsvByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FD5 RID: 16341 RVA: 0x001C34C4 File Offset: 0x001C16C4
		static ConfigWuWaGoLevelCsvByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWaGoLevelCsvByKey.CreateStaticDefaultValue), new Action(ConfigWuWaGoLevelCsvByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x001C34E4 File Offset: 0x001C16E4
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

		// Token: 0x06003FD7 RID: 16343 RVA: 0x001C3563 File Offset: 0x001C1763
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWaGoLevelCsvByKey.LogPair = null;
			ConfigWuWaGoLevelCsvByKey.HandleId = 0;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x001C3571 File Offset: 0x001C1771
		public static void Init()
		{
			ConfigWuWaGoLevelCsvByKey.HandleId = ConfigCommon.InitDataStatement(ConfigWuWaGoLevelCsvByKey.HandleId, "db_wuwagolevelcsv.db", "select BinData from `WuWaGoLevelCsv` where Key=?");
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x001C358C File Offset: 0x001C178C
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

		// Token: 0x04004A46 RID: 19014
		private const string DB = "db_wuwagolevelcsv.db";

		// Token: 0x04004A47 RID: 19015
		private const string FILE = "k.可视化编辑/c.Csv/m.鸣潮GO关卡配置/*.csv*";

		// Token: 0x04004A48 RID: 19016
		private const string TABLE = "WuWaGoLevelCsv";

		// Token: 0x04004A49 RID: 19017
		private const string COMMAND = "select BinData from `WuWaGoLevelCsv` where Key=?";

		// Token: 0x04004A4A RID: 19018
		private const string KEY_PREFIX = "WuWaGoLevelCsvByKey";

		// Token: 0x04004A4B RID: 19019
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A4C RID: 19020
		private static int HandleId;
	}
}
