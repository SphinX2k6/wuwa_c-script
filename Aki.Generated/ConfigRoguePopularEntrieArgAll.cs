using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000848 RID: 2120
	public class ConfigRoguePopularEntrieArgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031C2 RID: 12738 RVA: 0x00176318 File Offset: 0x00174518
		static ConfigRoguePopularEntrieArgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgAll.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgAll.ResetStaticDefaultValue));
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00176338 File Offset: 0x00174538
		public static void CreateStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoguePopularEntrieArgAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RoguePopularEntrieArg"),
				new ValueTuple<string, object>("语句", "select BinData from `RoguePopularEntrieArg`")
			});
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x001763B7 File Offset: 0x001745B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgAll.LogPair = null;
			ConfigRoguePopularEntrieArgAll.HandleId = 0;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x001763C5 File Offset: 0x001745C5
		public static void Init()
		{
			ConfigRoguePopularEntrieArgAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgAll.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg`");
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x001763E0 File Offset: 0x001745E0
		[NullableContext(2)]
		public static IReadOnlyList<RoguePopularEntrieArg> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoguePopularEntrieArg> readOnlyList = (IReadOnlyList<RoguePopularEntrieArg>)ConfigCommon.GetConfig("RoguePopularEntrieArgAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoguePopularEntrieArg> list = new List<RoguePopularEntrieArg>();
			while (ConfigCommon.Step(ConfigRoguePopularEntrieArgAll.HandleId, false, ConfigRoguePopularEntrieArgAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoguePopularEntrieArgAll.HandleId, 0, ConfigRoguePopularEntrieArgAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair);
					return null;
				}
				RoguePopularEntrieArg rootAsRoguePopularEntrieArg = RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(new ByteBuffer(item2));
				list.Add(rootAsRoguePopularEntrieArg);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoguePopularEntrieArgAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoguePopularEntrieArgAll.HandleId, ConfigRoguePopularEntrieArgAll.LogPair);
			return list;
		}

		// Token: 0x040039DE RID: 14814
		private const string DB = "db_rogue.db";

		// Token: 0x040039DF RID: 14815
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039E0 RID: 14816
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x040039E1 RID: 14817
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg`";

		// Token: 0x040039E2 RID: 14818
		private const string KEY_PREFIX = "RoguePopularEntrieArgAll";

		// Token: 0x040039E3 RID: 14819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039E4 RID: 14820
		private static int HandleId;
	}
}
