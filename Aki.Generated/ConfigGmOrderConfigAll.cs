using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B9 RID: 953
	public class ConfigGmOrderConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x000DB868 File Offset: 0x000D9A68
		static ConfigGmOrderConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderConfigAll.CreateStaticDefaultValue), new Action(ConfigGmOrderConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000DB888 File Offset: 0x000D9A88
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

		// Token: 0x0600165F RID: 5727 RVA: 0x000DB907 File Offset: 0x000D9B07
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderConfigAll.LogPair = null;
			ConfigGmOrderConfigAll.HandleId = 0;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000DB915 File Offset: 0x000D9B15
		public static void Init()
		{
			ConfigGmOrderConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderConfigAll.HandleId, "db_gm.db", "select BinData from `GmOrderConfig`");
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000DB930 File Offset: 0x000D9B30
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

		// Token: 0x040019F3 RID: 6643
		private const string DB = "db_gm.db";

		// Token: 0x040019F4 RID: 6644
		private const string FILE = "g.GM.xlsx";

		// Token: 0x040019F5 RID: 6645
		private const string TABLE = "GmOrderConfig";

		// Token: 0x040019F6 RID: 6646
		private const string COMMAND = "select BinData from `GmOrderConfig`";

		// Token: 0x040019F7 RID: 6647
		private const string KEY_PREFIX = "GmOrderConfigAll";

		// Token: 0x040019F8 RID: 6648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019F9 RID: 6649
		private static int HandleId;
	}
}
