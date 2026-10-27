using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000381 RID: 897
	public class ConfigGatherActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600150C RID: 5388 RVA: 0x000D0AA0 File Offset: 0x000CECA0
		static ConfigGatherActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGatherActivityAll.CreateStaticDefaultValue), new Action(ConfigGatherActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000D0AC0 File Offset: 0x000CECC0
		public static void CreateStaticDefaultValue()
		{
			ConfigGatherActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGatherActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_collectionactivity.db"),
				new ValueTuple<string, object>("文件", "s.收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "GatherActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `GatherActivity`")
			});
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000D0B3F File Offset: 0x000CED3F
		public static void ResetStaticDefaultValue()
		{
			ConfigGatherActivityAll.LogPair = null;
			ConfigGatherActivityAll.HandleId = 0;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000D0B4D File Offset: 0x000CED4D
		public static void Init()
		{
			ConfigGatherActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigGatherActivityAll.HandleId, "db_collectionactivity.db", "select BinData from `GatherActivity`");
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000D0B68 File Offset: 0x000CED68
		[NullableContext(2)]
		public static IReadOnlyList<GatherActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GatherActivity> readOnlyList = (IReadOnlyList<GatherActivity>)ConfigCommon.GetConfig("GatherActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GatherActivity> list = new List<GatherActivity>();
			while (ConfigCommon.Step(ConfigGatherActivityAll.HandleId, false, ConfigGatherActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGatherActivityAll.HandleId, 0, ConfigGatherActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair);
					return null;
				}
				GatherActivity rootAsGatherActivity = GatherActivity.GetRootAsGatherActivity(new ByteBuffer(item2));
				list.Add(rootAsGatherActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GatherActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair);
			return list;
		}

		// Token: 0x0400186B RID: 6251
		private const string DB = "db_collectionactivity.db";

		// Token: 0x0400186C RID: 6252
		private const string FILE = "s.收集活动.xlsx";

		// Token: 0x0400186D RID: 6253
		private const string TABLE = "GatherActivity";

		// Token: 0x0400186E RID: 6254
		private const string COMMAND = "select BinData from `GatherActivity`";

		// Token: 0x0400186F RID: 6255
		private const string KEY_PREFIX = "GatherActivityAll";

		// Token: 0x04001870 RID: 6256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001871 RID: 6257
		private static int HandleId;
	}
}
