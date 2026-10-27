using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000133 RID: 307
	public class ConfigCalabashDevelopRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00082644 File Offset: 0x00080844
		static ConfigCalabashDevelopRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardAll.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00082664 File Offset: 0x00080864
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashDevelopRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashDevelopReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashDevelopReward`")
			});
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000826E3 File Offset: 0x000808E3
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardAll.LogPair = null;
			ConfigCalabashDevelopRewardAll.HandleId = 0;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000826F1 File Offset: 0x000808F1
		public static void Init()
		{
			ConfigCalabashDevelopRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardAll.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward`");
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0008270C File Offset: 0x0008090C
		[NullableContext(2)]
		public static IReadOnlyList<CalabashDevelopReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashDevelopRewardAll.HandleId, ConfigCalabashDevelopRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CalabashDevelopReward> readOnlyList = (IReadOnlyList<CalabashDevelopReward>)ConfigCommon.GetConfig("CalabashDevelopRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CalabashDevelopReward> list = new List<CalabashDevelopReward>();
			while (ConfigCommon.Step(ConfigCalabashDevelopRewardAll.HandleId, false, ConfigCalabashDevelopRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashDevelopRewardAll.HandleId, 0, ConfigCalabashDevelopRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCalabashDevelopRewardAll.HandleId, ConfigCalabashDevelopRewardAll.LogPair);
					return null;
				}
				CalabashDevelopReward rootAsCalabashDevelopReward = CalabashDevelopReward.GetRootAsCalabashDevelopReward(new ByteBuffer(item2));
				list.Add(rootAsCalabashDevelopReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CalabashDevelopRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCalabashDevelopRewardAll.HandleId, ConfigCalabashDevelopRewardAll.LogPair);
			return list;
		}

		// Token: 0x04000849 RID: 2121
		private const string DB = "db_calabash.db";

		// Token: 0x0400084A RID: 2122
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x0400084B RID: 2123
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x0400084C RID: 2124
		private const string COMMAND = "select BinData from `CalabashDevelopReward`";

		// Token: 0x0400084D RID: 2125
		private const string KEY_PREFIX = "CalabashDevelopRewardAll";

		// Token: 0x0400084E RID: 2126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400084F RID: 2127
		private static int HandleId;
	}
}
