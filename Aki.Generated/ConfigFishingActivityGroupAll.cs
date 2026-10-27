using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D0 RID: 720
	public class ConfigFishingActivityGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x000B8F44 File Offset: 0x000B7144
		static ConfigFishingActivityGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityGroupAll.CreateStaticDefaultValue), new Action(ConfigFishingActivityGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x000B8F64 File Offset: 0x000B7164
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityGroup`")
			});
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000B8FE3 File Offset: 0x000B71E3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityGroupAll.LogPair = null;
			ConfigFishingActivityGroupAll.HandleId = 0;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x000B8FF1 File Offset: 0x000B71F1
		public static void Init()
		{
			ConfigFishingActivityGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityGroupAll.HandleId, "db_fishing.db", "select BinData from `FishingActivityGroup`");
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000B900C File Offset: 0x000B720C
		[NullableContext(2)]
		public static IReadOnlyList<FishingActivityGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityGroupAll.HandleId, ConfigFishingActivityGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingActivityGroup> readOnlyList = (IReadOnlyList<FishingActivityGroup>)ConfigCommon.GetConfig("FishingActivityGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingActivityGroup> list = new List<FishingActivityGroup>();
			while (ConfigCommon.Step(ConfigFishingActivityGroupAll.HandleId, false, ConfigFishingActivityGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityGroupAll.HandleId, 0, ConfigFishingActivityGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingActivityGroupAll.HandleId, ConfigFishingActivityGroupAll.LogPair);
					return null;
				}
				FishingActivityGroup rootAsFishingActivityGroup = FishingActivityGroup.GetRootAsFishingActivityGroup(new ByteBuffer(item2));
				list.Add(rootAsFishingActivityGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingActivityGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingActivityGroupAll.HandleId, ConfigFishingActivityGroupAll.LogPair);
			return list;
		}

		// Token: 0x04001394 RID: 5012
		private const string DB = "db_fishing.db";

		// Token: 0x04001395 RID: 5013
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001396 RID: 5014
		private const string TABLE = "FishingActivityGroup";

		// Token: 0x04001397 RID: 5015
		private const string COMMAND = "select BinData from `FishingActivityGroup`";

		// Token: 0x04001398 RID: 5016
		private const string KEY_PREFIX = "FishingActivityGroupAll";

		// Token: 0x04001399 RID: 5017
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400139A RID: 5018
		private static int HandleId;
	}
}
