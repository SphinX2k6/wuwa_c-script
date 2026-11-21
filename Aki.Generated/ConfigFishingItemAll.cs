using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F1 RID: 753
	public class ConfigFishingItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x000C0D94 File Offset: 0x000BEF94
		static ConfigFishingItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingItemAll.CreateStaticDefaultValue), new Action(ConfigFishingItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000C0DB4 File Offset: 0x000BEFB4
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

		// Token: 0x060011AD RID: 4525 RVA: 0x000C0E33 File Offset: 0x000BF033
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingItemAll.LogPair = null;
			ConfigFishingItemAll.HandleId = 0;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000C0E41 File Offset: 0x000BF041
		public static void Init()
		{
			ConfigFishingItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingItemAll.HandleId, "db_fishing.db", "select BinData from `FishingItem`");
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000C0E5C File Offset: 0x000BF05C
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

		// Token: 0x0400147B RID: 5243
		private const string DB = "db_fishing.db";

		// Token: 0x0400147C RID: 5244
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x0400147D RID: 5245
		private const string TABLE = "FishingItem";

		// Token: 0x0400147E RID: 5246
		private const string COMMAND = "select BinData from `FishingItem`";

		// Token: 0x0400147F RID: 5247
		private const string KEY_PREFIX = "FishingItemAll";

		// Token: 0x04001480 RID: 5248
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001481 RID: 5249
		private static int HandleId;
	}
}
