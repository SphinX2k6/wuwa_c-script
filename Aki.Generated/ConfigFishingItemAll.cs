using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DC RID: 732
	public class ConfigFishingItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x000BA888 File Offset: 0x000B8A88
		static ConfigFishingItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingItemAll.CreateStaticDefaultValue), new Action(ConfigFishingItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x000BA8A8 File Offset: 0x000B8AA8
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingItem"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingItem`")
			});
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000BA927 File Offset: 0x000B8B27
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingItemAll.LogPair = null;
			ConfigFishingItemAll.HandleId = 0;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x000BA935 File Offset: 0x000B8B35
		public static void Init()
		{
			ConfigFishingItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingItemAll.HandleId, "db_fishing.db", "select BinData from `FishingItem`");
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000BA950 File Offset: 0x000B8B50
		[NullableContext(2)]
		public static IReadOnlyList<FishingItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingItemAll.HandleId, ConfigFishingItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingItem> readOnlyList = (IReadOnlyList<FishingItem>)ConfigCommon.GetConfig("FishingItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingItem> list = new List<FishingItem>();
			while (ConfigCommon.Step(ConfigFishingItemAll.HandleId, false, ConfigFishingItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingItemAll.HandleId, 0, ConfigFishingItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingItemAll.HandleId, ConfigFishingItemAll.LogPair);
					return null;
				}
				FishingItem rootAsFishingItem = FishingItem.GetRootAsFishingItem(new ByteBuffer(item2));
				list.Add(rootAsFishingItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingItemAll.HandleId, ConfigFishingItemAll.LogPair);
			return list;
		}

		// Token: 0x040013E8 RID: 5096
		private const string DB = "db_fishing.db";

		// Token: 0x040013E9 RID: 5097
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040013EA RID: 5098
		private const string TABLE = "FishingItem";

		// Token: 0x040013EB RID: 5099
		private const string COMMAND = "select BinData from `FishingItem`";

		// Token: 0x040013EC RID: 5100
		private const string KEY_PREFIX = "FishingItemAll";

		// Token: 0x040013ED RID: 5101
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013EE RID: 5102
		private static int HandleId;
	}
}
