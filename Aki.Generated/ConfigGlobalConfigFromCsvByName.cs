using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B6 RID: 950
	public class ConfigGlobalConfigFromCsvByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x000DB294 File Offset: 0x000D9494
		static ConfigGlobalConfigFromCsvByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGlobalConfigFromCsvByName.CreateStaticDefaultValue), new Action(ConfigGlobalConfigFromCsvByName.ResetStaticDefaultValue));
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000DB2B4 File Offset: 0x000D94B4
		public static void CreateStaticDefaultValue()
		{
			ConfigGlobalConfigFromCsvByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGlobalConfigFromCsvByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_global_config.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/q.全局配置/*.csv*"),
				new ValueTuple<string, object>("表名", "GlobalConfigFromCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `GlobalConfigFromCsv` where Name=?")
			});
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000DB333 File Offset: 0x000D9533
		public static void ResetStaticDefaultValue()
		{
			ConfigGlobalConfigFromCsvByName.LogPair = null;
			ConfigGlobalConfigFromCsvByName.HandleId = 0;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000DB341 File Offset: 0x000D9541
		public static void Init()
		{
			ConfigGlobalConfigFromCsvByName.HandleId = ConfigCommon.InitDataStatement(ConfigGlobalConfigFromCsvByName.HandleId, "db_global_config.db", "select BinData from `GlobalConfigFromCsv` where Name=?");
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000DB35C File Offset: 0x000D955C
		public static GlobalConfigFromCsv? GetConfig(string p0Name, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGlobalConfigFromCsvByName.HandleId, ConfigGlobalConfigFromCsvByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GlobalConfigFromCsvByName#" + p0Name);
				if (configBuffer != null)
				{
					return new GlobalConfigFromCsv?(GlobalConfigFromCsv.GetRootAsGlobalConfigFromCsv(configBuffer));
				}
			}
			ConfigGlobalConfigFromCsvByName.LogPair.Clear();
			ConfigGlobalConfigFromCsvByName.LogPair.Add(new ValueTuple<string, object>("Name", p0Name));
			if (!ConfigCommon.BindString(ConfigGlobalConfigFromCsvByName.HandleId, 1, p0Name, ConfigGlobalConfigFromCsvByName.LogPair) || ConfigCommon.Step(ConfigGlobalConfigFromCsvByName.HandleId, true, ConfigGlobalConfigFromCsvByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGlobalConfigFromCsvByName.HandleId, ConfigGlobalConfigFromCsvByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGlobalConfigFromCsvByName.HandleId, 0, ConfigGlobalConfigFromCsvByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGlobalConfigFromCsvByName.HandleId, ConfigGlobalConfigFromCsvByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GlobalConfigFromCsv rootAsGlobalConfigFromCsv = GlobalConfigFromCsv.GetRootAsGlobalConfigFromCsv(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GlobalConfigFromCsvByName#" + p0Name, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGlobalConfigFromCsvByName.HandleId, ConfigGlobalConfigFromCsvByName.LogPair);
			return new GlobalConfigFromCsv?(rootAsGlobalConfigFromCsv);
		}

		// Token: 0x040019DE RID: 6622
		private const string DB = "db_global_config.db";

		// Token: 0x040019DF RID: 6623
		private const string FILE = "k.可视化编辑/c.Csv/q.全局配置/*.csv*";

		// Token: 0x040019E0 RID: 6624
		private const string TABLE = "GlobalConfigFromCsv";

		// Token: 0x040019E1 RID: 6625
		private const string COMMAND = "select BinData from `GlobalConfigFromCsv` where Name=?";

		// Token: 0x040019E2 RID: 6626
		private const string KEY_PREFIX = "GlobalConfigFromCsvByName";

		// Token: 0x040019E3 RID: 6627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019E4 RID: 6628
		private static int HandleId;
	}
}
