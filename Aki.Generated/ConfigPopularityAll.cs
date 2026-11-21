using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000768 RID: 1896
	public class ConfigPopularityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C81 RID: 11393 RVA: 0x001587B0 File Offset: 0x001569B0
		static ConfigPopularityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPopularityAll.CreateStaticDefaultValue), new Action(ConfigPopularityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x001587D0 File Offset: 0x001569D0
		public static void CreateStaticDefaultValue()
		{
			ConfigPopularityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPopularityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Popularity"),
				new ValueTuple<string, object>("语句", "select BinData from `Popularity`")
			});
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0015884F File Offset: 0x00156A4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPopularityAll.LogPair = null;
			ConfigPopularityAll.HandleId = 0;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0015885D File Offset: 0x00156A5D
		public static void Init()
		{
			ConfigPopularityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPopularityAll.HandleId, "db_moonchasing.db", "select BinData from `Popularity`");
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00158878 File Offset: 0x00156A78
		[NullableContext(2)]
		public static IReadOnlyList<Popularity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPopularityAll.HandleId, ConfigPopularityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Popularity> readOnlyList = (IReadOnlyList<Popularity>)ConfigCommon.GetConfig("PopularityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Popularity> list = new List<Popularity>();
			while (ConfigCommon.Step(ConfigPopularityAll.HandleId, false, ConfigPopularityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPopularityAll.HandleId, 0, ConfigPopularityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPopularityAll.HandleId, ConfigPopularityAll.LogPair);
					return null;
				}
				Popularity rootAsPopularity = Popularity.GetRootAsPopularity(new ByteBuffer(item2));
				list.Add(rootAsPopularity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PopularityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPopularityAll.HandleId, ConfigPopularityAll.LogPair);
			return list;
		}

		// Token: 0x040033BE RID: 13246
		private const string DB = "db_moonchasing.db";

		// Token: 0x040033BF RID: 13247
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x040033C0 RID: 13248
		private const string TABLE = "Popularity";

		// Token: 0x040033C1 RID: 13249
		private const string COMMAND = "select BinData from `Popularity`";

		// Token: 0x040033C2 RID: 13250
		private const string KEY_PREFIX = "PopularityAll";

		// Token: 0x040033C3 RID: 13251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033C4 RID: 13252
		private static int HandleId;
	}
}
