using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084D RID: 2125
	public class ConfigRogueResBondAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031E0 RID: 12768 RVA: 0x00176E20 File Offset: 0x00175020
		static ConfigRogueResBondAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondAll.CreateStaticDefaultValue), new Action(ConfigRogueResBondAll.ResetStaticDefaultValue));
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00176E40 File Offset: 0x00175040
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBond"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBond`")
			});
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00176EBF File Offset: 0x001750BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondAll.LogPair = null;
			ConfigRogueResBondAll.HandleId = 0;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00176ECD File Offset: 0x001750CD
		public static void Init()
		{
			ConfigRogueResBondAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBond`");
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x00176EE8 File Offset: 0x001750E8
		[NullableContext(2)]
		public static IReadOnlyList<RogueResBond> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResBond> readOnlyList = (IReadOnlyList<RogueResBond>)ConfigCommon.GetConfig("RogueResBondAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResBond> list = new List<RogueResBond>();
			while (ConfigCommon.Step(ConfigRogueResBondAll.HandleId, false, ConfigRogueResBondAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondAll.HandleId, 0, ConfigRogueResBondAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair);
					return null;
				}
				RogueResBond rootAsRogueResBond = RogueResBond.GetRootAsRogueResBond(new ByteBuffer(item2));
				list.Add(rootAsRogueResBond);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResBondAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResBondAll.HandleId, ConfigRogueResBondAll.LogPair);
			return list;
		}

		// Token: 0x04003A01 RID: 14849
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A02 RID: 14850
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A03 RID: 14851
		private const string TABLE = "RogueResBond";

		// Token: 0x04003A04 RID: 14852
		private const string COMMAND = "select BinData from `RogueResBond`";

		// Token: 0x04003A05 RID: 14853
		private const string KEY_PREFIX = "RogueResBondAll";

		// Token: 0x04003A06 RID: 14854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A07 RID: 14855
		private static int HandleId;
	}
}
