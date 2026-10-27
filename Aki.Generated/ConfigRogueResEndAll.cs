using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000842 RID: 2114
	public class ConfigRogueResEndAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600319E RID: 12702 RVA: 0x00171FE4 File Offset: 0x001701E4
		static ConfigRogueResEndAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndAll.CreateStaticDefaultValue), new Action(ConfigRogueResEndAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00172004 File Offset: 0x00170204
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

		// Token: 0x060031A0 RID: 12704 RVA: 0x00172083 File Offset: 0x00170283
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndAll.LogPair = null;
			ConfigRogueResEndAll.HandleId = 0;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00172091 File Offset: 0x00170291
		public static void Init()
		{
			ConfigRogueResEndAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEnd`");
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x001720AC File Offset: 0x001702AC
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

		// Token: 0x040039B4 RID: 14772
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039B5 RID: 14773
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039B6 RID: 14774
		private const string TABLE = "RogueResEnd";

		// Token: 0x040039B7 RID: 14775
		private const string COMMAND = "select BinData from `RogueResEnd`";

		// Token: 0x040039B8 RID: 14776
		private const string KEY_PREFIX = "RogueResEndAll";

		// Token: 0x040039B9 RID: 14777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039BA RID: 14778
		private static int HandleId;
	}
}
