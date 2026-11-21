using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000142 RID: 322
	public class ConfigCalabashDevelopRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00087FA8 File Offset: 0x000861A8
		static ConfigCalabashDevelopRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopRewardAll.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00087FC8 File Offset: 0x000861C8
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

		// Token: 0x0600078F RID: 1935 RVA: 0x00088047 File Offset: 0x00086247
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopRewardAll.LogPair = null;
			ConfigCalabashDevelopRewardAll.HandleId = 0;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00088055 File Offset: 0x00086255
		public static void Init()
		{
			ConfigCalabashDevelopRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopRewardAll.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopReward`");
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00088070 File Offset: 0x00086270
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

		// Token: 0x040008B2 RID: 2226
		private const string DB = "db_calabash.db";

		// Token: 0x040008B3 RID: 2227
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008B4 RID: 2228
		private const string TABLE = "CalabashDevelopReward";

		// Token: 0x040008B5 RID: 2229
		private const string COMMAND = "select BinData from `CalabashDevelopReward`";

		// Token: 0x040008B6 RID: 2230
		private const string KEY_PREFIX = "CalabashDevelopRewardAll";

		// Token: 0x040008B7 RID: 2231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008B8 RID: 2232
		private static int HandleId;
	}
}
