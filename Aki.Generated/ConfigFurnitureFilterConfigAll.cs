using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037C RID: 892
	public class ConfigFurnitureFilterConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014ED RID: 5357 RVA: 0x000D3468 File Offset: 0x000D1668
		static ConfigFurnitureFilterConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureFilterConfigAll.CreateStaticDefaultValue), new Action(ConfigFurnitureFilterConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000D3488 File Offset: 0x000D1688
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

		// Token: 0x060014EF RID: 5359 RVA: 0x000D3507 File Offset: 0x000D1707
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigAll.LogPair = null;
			ConfigFurnitureFilterConfigAll.HandleId = 0;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000D3515 File Offset: 0x000D1715
		public static void Init()
		{
			ConfigFurnitureFilterConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureFilterConfigAll.HandleId, "db_furniture.db", "select BinData from `FurnitureFilterConfig`");
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000D3530 File Offset: 0x000D1730
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

		// Token: 0x04001848 RID: 6216
		private const string DB = "db_furniture.db";

		// Token: 0x04001849 RID: 6217
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400184A RID: 6218
		private const string TABLE = "FurnitureFilterConfig";

		// Token: 0x0400184B RID: 6219
		private const string COMMAND = "select BinData from `FurnitureFilterConfig`";

		// Token: 0x0400184C RID: 6220
		private const string KEY_PREFIX = "FurnitureFilterConfigAll";

		// Token: 0x0400184D RID: 6221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400184E RID: 6222
		private static int HandleId;
	}
}
