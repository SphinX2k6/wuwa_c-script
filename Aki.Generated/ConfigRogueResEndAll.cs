using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085E RID: 2142
	public class ConfigRogueResEndAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003246 RID: 12870 RVA: 0x001792CC File Offset: 0x001774CC
		static ConfigRogueResEndAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndAll.CreateStaticDefaultValue), new Action(ConfigRogueResEndAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x001792EC File Offset: 0x001774EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEndAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEndAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEnd"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEnd`")
			});
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0017936B File Offset: 0x0017756B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndAll.LogPair = null;
			ConfigRogueResEndAll.HandleId = 0;
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00179379 File Offset: 0x00177579
		public static void Init()
		{
			ConfigRogueResEndAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEnd`");
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x00179394 File Offset: 0x00177594
		[NullableContext(2)]
		public static IReadOnlyList<RogueResEnd> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEndAll.HandleId, ConfigRogueResEndAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResEnd> readOnlyList = (IReadOnlyList<RogueResEnd>)ConfigCommon.GetConfig("RogueResEndAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResEnd> list = new List<RogueResEnd>();
			while (ConfigCommon.Step(ConfigRogueResEndAll.HandleId, false, ConfigRogueResEndAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEndAll.HandleId, 0, ConfigRogueResEndAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResEndAll.HandleId, ConfigRogueResEndAll.LogPair);
					return null;
				}
				RogueResEnd rootAsRogueResEnd = RogueResEnd.GetRootAsRogueResEnd(new ByteBuffer(item2));
				list.Add(rootAsRogueResEnd);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResEndAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResEndAll.HandleId, ConfigRogueResEndAll.LogPair);
			return list;
		}

		// Token: 0x04003A78 RID: 14968
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A79 RID: 14969
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A7A RID: 14970
		private const string TABLE = "RogueResEnd";

		// Token: 0x04003A7B RID: 14971
		private const string COMMAND = "select BinData from `RogueResEnd`";

		// Token: 0x04003A7C RID: 14972
		private const string KEY_PREFIX = "RogueResEndAll";

		// Token: 0x04003A7D RID: 14973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A7E RID: 14974
		private static int HandleId;
	}
}
