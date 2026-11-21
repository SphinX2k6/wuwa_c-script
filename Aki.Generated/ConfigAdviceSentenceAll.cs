using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000080 RID: 128
	public class ConfigAdviceSentenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0006DF1C File Offset: 0x0006C11C
		static ConfigAdviceSentenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceSentenceAll.CreateStaticDefaultValue), new Action(ConfigAdviceSentenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0006DF3C File Offset: 0x0006C13C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceSentenceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceSentenceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceSentence"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceSentence`")
			});
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0006DFBB File Offset: 0x0006C1BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceSentenceAll.LogPair = null;
			ConfigAdviceSentenceAll.HandleId = 0;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0006DFC9 File Offset: 0x0006C1C9
		public static void Init()
		{
			ConfigAdviceSentenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceSentenceAll.HandleId, "db_advice.db", "select BinData from `AdviceSentence`");
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0006DFE4 File Offset: 0x0006C1E4
		[NullableContext(2)]
		public static IReadOnlyList<AdviceSentence> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceSentenceAll.HandleId, ConfigAdviceSentenceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceSentence> readOnlyList = (IReadOnlyList<AdviceSentence>)ConfigCommon.GetConfig("AdviceSentenceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceSentence> list = new List<AdviceSentence>();
			while (ConfigCommon.Step(ConfigAdviceSentenceAll.HandleId, false, ConfigAdviceSentenceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceSentenceAll.HandleId, 0, ConfigAdviceSentenceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceSentenceAll.HandleId, ConfigAdviceSentenceAll.LogPair);
					return null;
				}
				AdviceSentence rootAsAdviceSentence = AdviceSentence.GetRootAsAdviceSentence(new ByteBuffer(item2));
				list.Add(rootAsAdviceSentence);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceSentenceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceSentenceAll.HandleId, ConfigAdviceSentenceAll.LogPair);
			return list;
		}

		// Token: 0x04000364 RID: 868
		private const string DB = "db_advice.db";

		// Token: 0x04000365 RID: 869
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000366 RID: 870
		private const string TABLE = "AdviceSentence";

		// Token: 0x04000367 RID: 871
		private const string COMMAND = "select BinData from `AdviceSentence`";

		// Token: 0x04000368 RID: 872
		private const string KEY_PREFIX = "AdviceSentenceAll";

		// Token: 0x04000369 RID: 873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400036A RID: 874
		private static int HandleId;
	}
}
