using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000750 RID: 1872
	public class ConfigPopularityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BF1 RID: 11249 RVA: 0x00151D34 File Offset: 0x0014FF34
		static ConfigPopularityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPopularityAll.CreateStaticDefaultValue), new Action(ConfigPopularityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00151D54 File Offset: 0x0014FF54
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

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00151DD3 File Offset: 0x0014FFD3
		public static void ResetStaticDefaultValue()
		{
			ConfigPopularityAll.LogPair = null;
			ConfigPopularityAll.HandleId = 0;
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00151DE1 File Offset: 0x0014FFE1
		public static void Init()
		{
			ConfigPopularityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPopularityAll.HandleId, "db_moonchasing.db", "select BinData from `Popularity`");
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00151DFC File Offset: 0x0014FFFC
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

		// Token: 0x04003316 RID: 13078
		private const string DB = "db_moonchasing.db";

		// Token: 0x04003317 RID: 13079
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04003318 RID: 13080
		private const string TABLE = "Popularity";

		// Token: 0x04003319 RID: 13081
		private const string COMMAND = "select BinData from `Popularity`";

		// Token: 0x0400331A RID: 13082
		private const string KEY_PREFIX = "PopularityAll";

		// Token: 0x0400331B RID: 13083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400331C RID: 13084
		private static int HandleId;
	}
}
