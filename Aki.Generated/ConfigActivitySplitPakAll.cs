using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005A RID: 90
	public class ConfigActivitySplitPakAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00069254 File Offset: 0x00067454
		static ConfigActivitySplitPakAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySplitPakAll.CreateStaticDefaultValue), new Action(ConfigActivitySplitPakAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00069274 File Offset: 0x00067474
		public static void CreateStaticDefaultValue()
		{
			ConfigActivitySplitPakAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivitySplitPakAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivitySplitPak"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivitySplitPak`")
			});
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000692F3 File Offset: 0x000674F3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySplitPakAll.LogPair = null;
			ConfigActivitySplitPakAll.HandleId = 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00069301 File Offset: 0x00067501
		public static void Init()
		{
			ConfigActivitySplitPakAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySplitPakAll.HandleId, "db_activity.db", "select BinData from `ActivitySplitPak`");
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0006931C File Offset: 0x0006751C
		[NullableContext(2)]
		public static IReadOnlyList<ActivitySplitPak> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivitySplitPakAll.HandleId, ConfigActivitySplitPakAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivitySplitPak> readOnlyList = (IReadOnlyList<ActivitySplitPak>)ConfigCommon.GetConfig("ActivitySplitPakAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivitySplitPak> list = new List<ActivitySplitPak>();
			while (ConfigCommon.Step(ConfigActivitySplitPakAll.HandleId, false, ConfigActivitySplitPakAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivitySplitPakAll.HandleId, 0, ConfigActivitySplitPakAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivitySplitPakAll.HandleId, ConfigActivitySplitPakAll.LogPair);
					return null;
				}
				ActivitySplitPak rootAsActivitySplitPak = ActivitySplitPak.GetRootAsActivitySplitPak(new ByteBuffer(item2));
				list.Add(rootAsActivitySplitPak);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivitySplitPakAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivitySplitPakAll.HandleId, ConfigActivitySplitPakAll.LogPair);
			return list;
		}

		// Token: 0x0400025A RID: 602
		private const string DB = "db_activity.db";

		// Token: 0x0400025B RID: 603
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400025C RID: 604
		private const string TABLE = "ActivitySplitPak";

		// Token: 0x0400025D RID: 605
		private const string COMMAND = "select BinData from `ActivitySplitPak`";

		// Token: 0x0400025E RID: 606
		private const string KEY_PREFIX = "ActivitySplitPakAll";

		// Token: 0x0400025F RID: 607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000260 RID: 608
		private static int HandleId;
	}
}
