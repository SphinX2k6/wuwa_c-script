using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000082 RID: 130
	public class ConfigAdviceWordAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600030C RID: 780 RVA: 0x0006E2F8 File Offset: 0x0006C4F8
		static ConfigAdviceWordAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordAll.CreateStaticDefaultValue), new Action(ConfigAdviceWordAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0006E318 File Offset: 0x0006C518
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWord"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWord`")
			});
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0006E397 File Offset: 0x0006C597
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordAll.LogPair = null;
			ConfigAdviceWordAll.HandleId = 0;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0006E3A5 File Offset: 0x0006C5A5
		public static void Init()
		{
			ConfigAdviceWordAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordAll.HandleId, "db_advice.db", "select BinData from `AdviceWord`");
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
		[NullableContext(2)]
		public static IReadOnlyList<AdviceWord> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceWord> readOnlyList = (IReadOnlyList<AdviceWord>)ConfigCommon.GetConfig("AdviceWordAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceWord> list = new List<AdviceWord>();
			while (ConfigCommon.Step(ConfigAdviceWordAll.HandleId, false, ConfigAdviceWordAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordAll.HandleId, 0, ConfigAdviceWordAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair);
					return null;
				}
				AdviceWord rootAsAdviceWord = AdviceWord.GetRootAsAdviceWord(new ByteBuffer(item2));
				list.Add(rootAsAdviceWord);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceWordAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair);
			return list;
		}

		// Token: 0x04000372 RID: 882
		private const string DB = "db_advice.db";

		// Token: 0x04000373 RID: 883
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000374 RID: 884
		private const string TABLE = "AdviceWord";

		// Token: 0x04000375 RID: 885
		private const string COMMAND = "select BinData from `AdviceWord`";

		// Token: 0x04000376 RID: 886
		private const string KEY_PREFIX = "AdviceWordAll";

		// Token: 0x04000377 RID: 887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000378 RID: 888
		private static int HandleId;
	}
}
