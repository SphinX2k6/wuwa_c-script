using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E5 RID: 741
	public class ConfigFishingActivityGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x000BF450 File Offset: 0x000BD650
		static ConfigFishingActivityGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityGroupAll.CreateStaticDefaultValue), new Action(ConfigFishingActivityGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000BF470 File Offset: 0x000BD670
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

		// Token: 0x06001165 RID: 4453 RVA: 0x000BF4EF File Offset: 0x000BD6EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityGroupAll.LogPair = null;
			ConfigFishingActivityGroupAll.HandleId = 0;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000BF4FD File Offset: 0x000BD6FD
		public static void Init()
		{
			ConfigFishingActivityGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityGroupAll.HandleId, "db_fishing.db", "select BinData from `FishingActivityGroup`");
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000BF518 File Offset: 0x000BD718
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

		// Token: 0x04001427 RID: 5159
		private const string DB = "db_fishing.db";

		// Token: 0x04001428 RID: 5160
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001429 RID: 5161
		private const string TABLE = "FishingActivityGroup";

		// Token: 0x0400142A RID: 5162
		private const string COMMAND = "select BinData from `FishingActivityGroup`";

		// Token: 0x0400142B RID: 5163
		private const string KEY_PREFIX = "FishingActivityGroupAll";

		// Token: 0x0400142C RID: 5164
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400142D RID: 5165
		private static int HandleId;
	}
}
