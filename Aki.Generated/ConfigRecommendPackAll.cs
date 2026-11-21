using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DC RID: 2012
	public class ConfigRecommendPackAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F3A RID: 12090 RVA: 0x00167D50 File Offset: 0x00165F50
		static ConfigRecommendPackAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecommendPackAll.CreateStaticDefaultValue), new Action(ConfigRecommendPackAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00167D70 File Offset: 0x00165F70
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

		// Token: 0x06002F3C RID: 12092 RVA: 0x00167DEF File Offset: 0x00165FEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRecommendPackAll.LogPair = null;
			ConfigRecommendPackAll.HandleId = 0;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00167DFD File Offset: 0x00165FFD
		public static void Init()
		{
			ConfigRecommendPackAll.HandleId = ConfigCommon.InitDataStatement(ConfigRecommendPackAll.HandleId, "db_download.db", "select BinData from `RecommendPack`");
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00167E18 File Offset: 0x00166018
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

		// Token: 0x040036EA RID: 14058
		private const string DB = "db_download.db";

		// Token: 0x040036EB RID: 14059
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040036EC RID: 14060
		private const string TABLE = "RecommendPack";

		// Token: 0x040036ED RID: 14061
		private const string COMMAND = "select BinData from `RecommendPack`";

		// Token: 0x040036EE RID: 14062
		private const string KEY_PREFIX = "RecommendPackAll";

		// Token: 0x040036EF RID: 14063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036F0 RID: 14064
		private static int HandleId;
	}
}
