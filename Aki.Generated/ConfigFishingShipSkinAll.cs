using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000300 RID: 768
	public class ConfigFishingShipSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001205 RID: 4613 RVA: 0x000C2E4C File Offset: 0x000C104C
		static ConfigFishingShipSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingShipSkinAll.CreateStaticDefaultValue), new Action(ConfigFishingShipSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000C2E6C File Offset: 0x000C106C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingShipSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingShipSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingShipSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingShipSkin`")
			});
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000C2EEB File Offset: 0x000C10EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingShipSkinAll.LogPair = null;
			ConfigFishingShipSkinAll.HandleId = 0;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000C2EF9 File Offset: 0x000C10F9
		public static void Init()
		{
			ConfigFishingShipSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingShipSkinAll.HandleId, "db_fishing.db", "select BinData from `FishingShipSkin`");
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000C2F14 File Offset: 0x000C1114
		[NullableContext(2)]
		public static IReadOnlyList<FishingShipSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingShipSkin> readOnlyList = (IReadOnlyList<FishingShipSkin>)ConfigCommon.GetConfig("FishingShipSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingShipSkin> list = new List<FishingShipSkin>();
			while (ConfigCommon.Step(ConfigFishingShipSkinAll.HandleId, false, ConfigFishingShipSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingShipSkinAll.HandleId, 0, ConfigFishingShipSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair);
					return null;
				}
				FishingShipSkin rootAsFishingShipSkin = FishingShipSkin.GetRootAsFishingShipSkin(new ByteBuffer(item2));
				list.Add(rootAsFishingShipSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingShipSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingShipSkinAll.HandleId, ConfigFishingShipSkinAll.LogPair);
			return list;
		}

		// Token: 0x040014E4 RID: 5348
		private const string DB = "db_fishing.db";

		// Token: 0x040014E5 RID: 5349
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014E6 RID: 5350
		private const string TABLE = "FishingShipSkin";

		// Token: 0x040014E7 RID: 5351
		private const string COMMAND = "select BinData from `FishingShipSkin`";

		// Token: 0x040014E8 RID: 5352
		private const string KEY_PREFIX = "FishingShipSkinAll";

		// Token: 0x040014E9 RID: 5353
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014EA RID: 5354
		private static int HandleId;
	}
}
