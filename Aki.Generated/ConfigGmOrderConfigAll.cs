using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A3 RID: 931
	public class ConfigGmOrderConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015D9 RID: 5593 RVA: 0x000D5114 File Offset: 0x000D3314
		static ConfigGmOrderConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderConfigAll.CreateStaticDefaultValue), new Action(ConfigGmOrderConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000D5134 File Offset: 0x000D3334
		public static void CreateStaticDefaultValue()
		{
			ConfigGmOrderConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmOrderConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmOrderConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GmOrderConfig`")
			});
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000D51B3 File Offset: 0x000D33B3
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderConfigAll.LogPair = null;
			ConfigGmOrderConfigAll.HandleId = 0;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000D51C1 File Offset: 0x000D33C1
		public static void Init()
		{
			ConfigGmOrderConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderConfigAll.HandleId, "db_gm.db", "select BinData from `GmOrderConfig`");
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000D51DC File Offset: 0x000D33DC
		[NullableContext(2)]
		public static IReadOnlyList<GmOrderConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmOrderConfigAll.HandleId, ConfigGmOrderConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GmOrderConfig> readOnlyList = (IReadOnlyList<GmOrderConfig>)ConfigCommon.GetConfig("GmOrderConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GmOrderConfig> list = new List<GmOrderConfig>();
			while (ConfigCommon.Step(ConfigGmOrderConfigAll.HandleId, false, ConfigGmOrderConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmOrderConfigAll.HandleId, 0, ConfigGmOrderConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGmOrderConfigAll.HandleId, ConfigGmOrderConfigAll.LogPair);
					return null;
				}
				GmOrderConfig rootAsGmOrderConfig = GmOrderConfig.GetRootAsGmOrderConfig(new ByteBuffer(item2));
				list.Add(rootAsGmOrderConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GmOrderConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGmOrderConfigAll.HandleId, ConfigGmOrderConfigAll.LogPair);
			return list;
		}

		// Token: 0x04001959 RID: 6489
		private const string DB = "db_gm.db";

		// Token: 0x0400195A RID: 6490
		private const string FILE = "g.GM.xlsx";

		// Token: 0x0400195B RID: 6491
		private const string TABLE = "GmOrderConfig";

		// Token: 0x0400195C RID: 6492
		private const string COMMAND = "select BinData from `GmOrderConfig`";

		// Token: 0x0400195D RID: 6493
		private const string KEY_PREFIX = "GmOrderConfigAll";

		// Token: 0x0400195E RID: 6494
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400195F RID: 6495
		private static int HandleId;
	}
}
