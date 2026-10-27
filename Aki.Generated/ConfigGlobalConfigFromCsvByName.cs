using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A0 RID: 928
	public class ConfigGlobalConfigFromCsvByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015C7 RID: 5575 RVA: 0x000D4B40 File Offset: 0x000D2D40
		static ConfigGlobalConfigFromCsvByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGlobalConfigFromCsvByName.CreateStaticDefaultValue), new Action(ConfigGlobalConfigFromCsvByName.ResetStaticDefaultValue));
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000D4B60 File Offset: 0x000D2D60
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

		// Token: 0x060015C9 RID: 5577 RVA: 0x000D4BDF File Offset: 0x000D2DDF
		public static void ResetStaticDefaultValue()
		{
			ConfigGlobalConfigFromCsvByName.LogPair = null;
			ConfigGlobalConfigFromCsvByName.HandleId = 0;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000D4BED File Offset: 0x000D2DED
		public static void Init()
		{
			ConfigGlobalConfigFromCsvByName.HandleId = ConfigCommon.InitDataStatement(ConfigGlobalConfigFromCsvByName.HandleId, "db_global_config.db", "select BinData from `GlobalConfigFromCsv` where Name=?");
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x000D4C08 File Offset: 0x000D2E08
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

		// Token: 0x04001944 RID: 6468
		private const string DB = "db_global_config.db";

		// Token: 0x04001945 RID: 6469
		private const string FILE = "k.可视化编辑/c.Csv/q.全局配置/*.csv*";

		// Token: 0x04001946 RID: 6470
		private const string TABLE = "GlobalConfigFromCsv";

		// Token: 0x04001947 RID: 6471
		private const string COMMAND = "select BinData from `GlobalConfigFromCsv` where Name=?";

		// Token: 0x04001948 RID: 6472
		private const string KEY_PREFIX = "GlobalConfigFromCsvByName";

		// Token: 0x04001949 RID: 6473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400194A RID: 6474
		private static int HandleId;
	}
}
