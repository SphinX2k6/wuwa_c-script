using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E8 RID: 744
	public class ConfigFishingActivityMilestoneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001175 RID: 4469 RVA: 0x000BFA74 File Offset: 0x000BDC74
		static ConfigFishingActivityMilestoneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityMilestoneAll.CreateStaticDefaultValue), new Action(ConfigFishingActivityMilestoneAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000BFA94 File Offset: 0x000BDC94
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

		// Token: 0x06001177 RID: 4471 RVA: 0x000BFB13 File Offset: 0x000BDD13
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneAll.LogPair = null;
			ConfigFishingActivityMilestoneAll.HandleId = 0;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000BFB21 File Offset: 0x000BDD21
		public static void Init()
		{
			ConfigFishingActivityMilestoneAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityMilestoneAll.HandleId, "db_fishing.db", "select BinData from `FishingActivityMilestone`");
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000BFB3C File Offset: 0x000BDD3C
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

		// Token: 0x0400143C RID: 5180
		private const string DB = "db_fishing.db";

		// Token: 0x0400143D RID: 5181
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x0400143E RID: 5182
		private const string TABLE = "FishingActivityMilestone";

		// Token: 0x0400143F RID: 5183
		private const string COMMAND = "select BinData from `FishingActivityMilestone`";

		// Token: 0x04001440 RID: 5184
		private const string KEY_PREFIX = "FishingActivityMilestoneAll";

		// Token: 0x04001441 RID: 5185
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001442 RID: 5186
		private static int HandleId;
	}
}
