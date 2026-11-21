using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007D RID: 125
	public class ConfigAdviceConjunctionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0006D8F8 File Offset: 0x0006BAF8
		static ConfigAdviceConjunctionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceConjunctionAll.CreateStaticDefaultValue), new Action(ConfigAdviceConjunctionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0006D918 File Offset: 0x0006BB18
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceConjunctionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceConjunctionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceConjunction"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceConjunction`")
			});
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0006D997 File Offset: 0x0006BB97
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceConjunctionAll.LogPair = null;
			ConfigAdviceConjunctionAll.HandleId = 0;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0006D9A5 File Offset: 0x0006BBA5
		public static void Init()
		{
			ConfigAdviceConjunctionAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceConjunctionAll.HandleId, "db_advice.db", "select BinData from `AdviceConjunction`");
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0006D9C0 File Offset: 0x0006BBC0
		[NullableContext(2)]
		public static IReadOnlyList<AdviceConjunction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceConjunctionAll.HandleId, ConfigAdviceConjunctionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceConjunction> readOnlyList = (IReadOnlyList<AdviceConjunction>)ConfigCommon.GetConfig("AdviceConjunctionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceConjunction> list = new List<AdviceConjunction>();
			while (ConfigCommon.Step(ConfigAdviceConjunctionAll.HandleId, false, ConfigAdviceConjunctionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceConjunctionAll.HandleId, 0, ConfigAdviceConjunctionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceConjunctionAll.HandleId, ConfigAdviceConjunctionAll.LogPair);
					return null;
				}
				AdviceConjunction rootAsAdviceConjunction = AdviceConjunction.GetRootAsAdviceConjunction(new ByteBuffer(item2));
				list.Add(rootAsAdviceConjunction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceConjunctionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceConjunctionAll.HandleId, ConfigAdviceConjunctionAll.LogPair);
			return list;
		}

		// Token: 0x0400034F RID: 847
		private const string DB = "db_advice.db";

		// Token: 0x04000350 RID: 848
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000351 RID: 849
		private const string TABLE = "AdviceConjunction";

		// Token: 0x04000352 RID: 850
		private const string COMMAND = "select BinData from `AdviceConjunction`";

		// Token: 0x04000353 RID: 851
		private const string KEY_PREFIX = "AdviceConjunctionAll";

		// Token: 0x04000354 RID: 852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000355 RID: 853
		private static int HandleId;
	}
}
