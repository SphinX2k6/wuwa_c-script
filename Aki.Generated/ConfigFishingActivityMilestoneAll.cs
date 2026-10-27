using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D3 RID: 723
	public class ConfigFishingActivityMilestoneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x000B9568 File Offset: 0x000B7768
		static ConfigFishingActivityMilestoneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityMilestoneAll.CreateStaticDefaultValue), new Action(ConfigFishingActivityMilestoneAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000B9588 File Offset: 0x000B7788
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityMilestoneAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityMilestone"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityMilestone`")
			});
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000B9607 File Offset: 0x000B7807
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneAll.LogPair = null;
			ConfigFishingActivityMilestoneAll.HandleId = 0;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000B9615 File Offset: 0x000B7815
		public static void Init()
		{
			ConfigFishingActivityMilestoneAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityMilestoneAll.HandleId, "db_fishing.db", "select BinData from `FishingActivityMilestone`");
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000B9630 File Offset: 0x000B7830
		[NullableContext(2)]
		public static IReadOnlyList<FishingActivityMilestone> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityMilestoneAll.HandleId, ConfigFishingActivityMilestoneAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingActivityMilestone> readOnlyList = (IReadOnlyList<FishingActivityMilestone>)ConfigCommon.GetConfig("FishingActivityMilestoneAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingActivityMilestone> list = new List<FishingActivityMilestone>();
			while (ConfigCommon.Step(ConfigFishingActivityMilestoneAll.HandleId, false, ConfigFishingActivityMilestoneAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityMilestoneAll.HandleId, 0, ConfigFishingActivityMilestoneAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingActivityMilestoneAll.HandleId, ConfigFishingActivityMilestoneAll.LogPair);
					return null;
				}
				FishingActivityMilestone rootAsFishingActivityMilestone = FishingActivityMilestone.GetRootAsFishingActivityMilestone(new ByteBuffer(item2));
				list.Add(rootAsFishingActivityMilestone);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingActivityMilestoneAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingActivityMilestoneAll.HandleId, ConfigFishingActivityMilestoneAll.LogPair);
			return list;
		}

		// Token: 0x040013A9 RID: 5033
		private const string DB = "db_fishing.db";

		// Token: 0x040013AA RID: 5034
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x040013AB RID: 5035
		private const string TABLE = "FishingActivityMilestone";

		// Token: 0x040013AC RID: 5036
		private const string COMMAND = "select BinData from `FishingActivityMilestone`";

		// Token: 0x040013AD RID: 5037
		private const string KEY_PREFIX = "FishingActivityMilestoneAll";

		// Token: 0x040013AE RID: 5038
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013AF RID: 5039
		private static int HandleId;
	}
}
