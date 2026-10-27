using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000075 RID: 117
	public class ConfigAdviceConjunctionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00069044 File Offset: 0x00067244
		static ConfigAdviceConjunctionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceConjunctionAll.CreateStaticDefaultValue), new Action(ConfigAdviceConjunctionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00069064 File Offset: 0x00067264
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

		// Token: 0x060002C0 RID: 704 RVA: 0x000690E3 File Offset: 0x000672E3
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceConjunctionAll.LogPair = null;
			ConfigAdviceConjunctionAll.HandleId = 0;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000690F1 File Offset: 0x000672F1
		public static void Init()
		{
			ConfigAdviceConjunctionAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceConjunctionAll.HandleId, "db_advice.db", "select BinData from `AdviceConjunction`");
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0006910C File Offset: 0x0006730C
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

		// Token: 0x04000317 RID: 791
		private const string DB = "db_advice.db";

		// Token: 0x04000318 RID: 792
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000319 RID: 793
		private const string TABLE = "AdviceConjunction";

		// Token: 0x0400031A RID: 794
		private const string COMMAND = "select BinData from `AdviceConjunction`";

		// Token: 0x0400031B RID: 795
		private const string KEY_PREFIX = "AdviceConjunctionAll";

		// Token: 0x0400031C RID: 796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400031D RID: 797
		private static int HandleId;
	}
}
