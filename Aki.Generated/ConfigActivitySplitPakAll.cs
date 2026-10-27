using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000052 RID: 82
	public class ConfigActivitySplitPakAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001EC RID: 492 RVA: 0x000649A0 File Offset: 0x00062BA0
		static ConfigActivitySplitPakAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySplitPakAll.CreateStaticDefaultValue), new Action(ConfigActivitySplitPakAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000649C0 File Offset: 0x00062BC0
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

		// Token: 0x060001EE RID: 494 RVA: 0x00064A3F File Offset: 0x00062C3F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySplitPakAll.LogPair = null;
			ConfigActivitySplitPakAll.HandleId = 0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00064A4D File Offset: 0x00062C4D
		public static void Init()
		{
			ConfigActivitySplitPakAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySplitPakAll.HandleId, "db_activity.db", "select BinData from `ActivitySplitPak`");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00064A68 File Offset: 0x00062C68
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

		// Token: 0x04000222 RID: 546
		private const string DB = "db_activity.db";

		// Token: 0x04000223 RID: 547
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000224 RID: 548
		private const string TABLE = "ActivitySplitPak";

		// Token: 0x04000225 RID: 549
		private const string COMMAND = "select BinData from `ActivitySplitPak`";

		// Token: 0x04000226 RID: 550
		private const string KEY_PREFIX = "ActivitySplitPakAll";

		// Token: 0x04000227 RID: 551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000228 RID: 552
		private static int HandleId;
	}
}
