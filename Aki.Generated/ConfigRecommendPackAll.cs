using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C0 RID: 1984
	public class ConfigRecommendPackAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x00160A68 File Offset: 0x0015EC68
		static ConfigRecommendPackAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecommendPackAll.CreateStaticDefaultValue), new Action(ConfigRecommendPackAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00160A88 File Offset: 0x0015EC88
		public static void CreateStaticDefaultValue()
		{
			ConfigRecommendPackAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecommendPackAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "RecommendPack"),
				new ValueTuple<string, object>("语句", "select BinData from `RecommendPack`")
			});
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00160B07 File Offset: 0x0015ED07
		public static void ResetStaticDefaultValue()
		{
			ConfigRecommendPackAll.LogPair = null;
			ConfigRecommendPackAll.HandleId = 0;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00160B15 File Offset: 0x0015ED15
		public static void Init()
		{
			ConfigRecommendPackAll.HandleId = ConfigCommon.InitDataStatement(ConfigRecommendPackAll.HandleId, "db_download.db", "select BinData from `RecommendPack`");
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00160B30 File Offset: 0x0015ED30
		[NullableContext(2)]
		public static IReadOnlyList<RecommendPack> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecommendPackAll.HandleId, ConfigRecommendPackAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RecommendPack> readOnlyList = (IReadOnlyList<RecommendPack>)ConfigCommon.GetConfig("RecommendPackAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RecommendPack> list = new List<RecommendPack>();
			while (ConfigCommon.Step(ConfigRecommendPackAll.HandleId, false, ConfigRecommendPackAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecommendPackAll.HandleId, 0, ConfigRecommendPackAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRecommendPackAll.HandleId, ConfigRecommendPackAll.LogPair);
					return null;
				}
				RecommendPack rootAsRecommendPack = RecommendPack.GetRootAsRecommendPack(new ByteBuffer(item2));
				list.Add(rootAsRecommendPack);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RecommendPackAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRecommendPackAll.HandleId, ConfigRecommendPackAll.LogPair);
			return list;
		}

		// Token: 0x04003626 RID: 13862
		private const string DB = "db_download.db";

		// Token: 0x04003627 RID: 13863
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04003628 RID: 13864
		private const string TABLE = "RecommendPack";

		// Token: 0x04003629 RID: 13865
		private const string COMMAND = "select BinData from `RecommendPack`";

		// Token: 0x0400362A RID: 13866
		private const string KEY_PREFIX = "RecommendPackAll";

		// Token: 0x0400362B RID: 13867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400362C RID: 13868
		private static int HandleId;
	}
}
