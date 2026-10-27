using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000367 RID: 871
	public class ConfigFurnitureFilterConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x000CCF5C File Offset: 0x000CB15C
		static ConfigFurnitureFilterConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureFilterConfigAll.CreateStaticDefaultValue), new Action(ConfigFurnitureFilterConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000CCF7C File Offset: 0x000CB17C
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureFilterConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurnitureFilterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FurnitureFilterConfig`")
			});
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000CCFFB File Offset: 0x000CB1FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigAll.LogPair = null;
			ConfigFurnitureFilterConfigAll.HandleId = 0;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000CD009 File Offset: 0x000CB209
		public static void Init()
		{
			ConfigFurnitureFilterConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureFilterConfigAll.HandleId, "db_furniture.db", "select BinData from `FurnitureFilterConfig`");
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000CD024 File Offset: 0x000CB224
		[NullableContext(2)]
		public static IReadOnlyList<FurnitureFilterConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureFilterConfigAll.HandleId, ConfigFurnitureFilterConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FurnitureFilterConfig> readOnlyList = (IReadOnlyList<FurnitureFilterConfig>)ConfigCommon.GetConfig("FurnitureFilterConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FurnitureFilterConfig> list = new List<FurnitureFilterConfig>();
			while (ConfigCommon.Step(ConfigFurnitureFilterConfigAll.HandleId, false, ConfigFurnitureFilterConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureFilterConfigAll.HandleId, 0, ConfigFurnitureFilterConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureFilterConfigAll.HandleId, ConfigFurnitureFilterConfigAll.LogPair);
					return null;
				}
				FurnitureFilterConfig rootAsFurnitureFilterConfig = FurnitureFilterConfig.GetRootAsFurnitureFilterConfig(new ByteBuffer(item2));
				list.Add(rootAsFurnitureFilterConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FurnitureFilterConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureFilterConfigAll.HandleId, ConfigFurnitureFilterConfigAll.LogPair);
			return list;
		}

		// Token: 0x040017B5 RID: 6069
		private const string DB = "db_furniture.db";

		// Token: 0x040017B6 RID: 6070
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017B7 RID: 6071
		private const string TABLE = "FurnitureFilterConfig";

		// Token: 0x040017B8 RID: 6072
		private const string COMMAND = "select BinData from `FurnitureFilterConfig`";

		// Token: 0x040017B9 RID: 6073
		private const string KEY_PREFIX = "FurnitureFilterConfigAll";

		// Token: 0x040017BA RID: 6074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017BB RID: 6075
		private static int HandleId;
	}
}
