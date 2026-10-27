using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000078 RID: 120
	public class ConfigAdviceSentenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00069668 File Offset: 0x00067868
		static ConfigAdviceSentenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceSentenceAll.CreateStaticDefaultValue), new Action(ConfigAdviceSentenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00069688 File Offset: 0x00067888
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

		// Token: 0x060002D2 RID: 722 RVA: 0x00069707 File Offset: 0x00067907
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceSentenceAll.LogPair = null;
			ConfigAdviceSentenceAll.HandleId = 0;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00069715 File Offset: 0x00067915
		public static void Init()
		{
			ConfigAdviceSentenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceSentenceAll.HandleId, "db_advice.db", "select BinData from `AdviceSentence`");
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00069730 File Offset: 0x00067930
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

		// Token: 0x0400032C RID: 812
		private const string DB = "db_advice.db";

		// Token: 0x0400032D RID: 813
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x0400032E RID: 814
		private const string TABLE = "AdviceSentence";

		// Token: 0x0400032F RID: 815
		private const string COMMAND = "select BinData from `AdviceSentence`";

		// Token: 0x04000330 RID: 816
		private const string KEY_PREFIX = "AdviceSentenceAll";

		// Token: 0x04000331 RID: 817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000332 RID: 818
		private static int HandleId;
	}
}
