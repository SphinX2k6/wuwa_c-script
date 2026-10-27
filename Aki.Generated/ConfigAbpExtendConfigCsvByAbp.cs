using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000A RID: 10
	public class ConfigAbpExtendConfigCsvByAbp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0005B660 File Offset: 0x00059860
		static ConfigAbpExtendConfigCsvByAbp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbpExtendConfigCsvByAbp.CreateStaticDefaultValue), new Action(ConfigAbpExtendConfigCsvByAbp.ResetStaticDefaultValue));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0005B680 File Offset: 0x00059880
		public static void CreateStaticDefaultValue()
		{
			ConfigAbpExtendConfigCsvByAbp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbpExtendConfigCsvByAbp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_abpextendconfigcsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.ABP配置扩展表/*.csv*"),
				new ValueTuple<string, object>("表名", "AbpExtendConfigCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `AbpExtendConfigCsv` where Abp=?")
			});
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0005B6FF File Offset: 0x000598FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbpExtendConfigCsvByAbp.LogPair = null;
			ConfigAbpExtendConfigCsvByAbp.HandleId = 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0005B70D File Offset: 0x0005990D
		public static void Init()
		{
			ConfigAbpExtendConfigCsvByAbp.HandleId = ConfigCommon.InitDataStatement(ConfigAbpExtendConfigCsvByAbp.HandleId, "db_abpextendconfigcsv.db", "select BinData from `AbpExtendConfigCsv` where Abp=?");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0005B728 File Offset: 0x00059928
		[return: Nullable(2)]
		public static IReadOnlyList<AbpExtendConfigCsv> GetConfigList(string p0Abp, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbpExtendConfigCsvByAbp.HandleId, ConfigAbpExtendConfigCsvByAbp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbpExtendConfigCsv> readOnlyList = (IReadOnlyList<AbpExtendConfigCsv>)ConfigCommon.GetConfig("AbpExtendConfigCsvByAbp#" + p0Abp);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAbpExtendConfigCsvByAbp.LogPair.Clear();
			ConfigAbpExtendConfigCsvByAbp.LogPair.Add(new ValueTuple<string, object>("Abp", p0Abp));
			if (!ConfigCommon.BindString(ConfigAbpExtendConfigCsvByAbp.HandleId, 1, p0Abp, ConfigAbpExtendConfigCsvByAbp.LogPair))
			{
				ConfigCommon.Reset(ConfigAbpExtendConfigCsvByAbp.HandleId, ConfigAbpExtendConfigCsvByAbp.LogPair);
				return null;
			}
			List<AbpExtendConfigCsv> list = new List<AbpExtendConfigCsv>();
			while (ConfigCommon.Step(ConfigAbpExtendConfigCsvByAbp.HandleId, false, ConfigAbpExtendConfigCsvByAbp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbpExtendConfigCsvByAbp.HandleId, 0, ConfigAbpExtendConfigCsvByAbp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbpExtendConfigCsvByAbp.HandleId, ConfigAbpExtendConfigCsvByAbp.LogPair);
					return null;
				}
				AbpExtendConfigCsv rootAsAbpExtendConfigCsv = AbpExtendConfigCsv.GetRootAsAbpExtendConfigCsv(new ByteBuffer(item2));
				list.Add(rootAsAbpExtendConfigCsv);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbpExtendConfigCsvByAbp#" + p0Abp, list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbpExtendConfigCsvByAbp.HandleId, ConfigAbpExtendConfigCsvByAbp.LogPair);
			return list;
		}

		// Token: 0x0400002A RID: 42
		private const string DB = "db_abpextendconfigcsv.db";

		// Token: 0x0400002B RID: 43
		private const string FILE = "k.可视化编辑/c.Csv/a.ABP配置扩展表/*.csv*";

		// Token: 0x0400002C RID: 44
		private const string TABLE = "AbpExtendConfigCsv";

		// Token: 0x0400002D RID: 45
		private const string COMMAND = "select BinData from `AbpExtendConfigCsv` where Abp=?";

		// Token: 0x0400002E RID: 46
		private const string KEY_PREFIX = "AbpExtendConfigCsvByAbp";

		// Token: 0x0400002F RID: 47
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000030 RID: 48
		private static int HandleId;
	}
}
