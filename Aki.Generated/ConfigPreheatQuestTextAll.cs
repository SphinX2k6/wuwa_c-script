using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000758 RID: 1880
	public class ConfigPreheatQuestTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C21 RID: 11297 RVA: 0x00152CF8 File Offset: 0x00150EF8
		static ConfigPreheatQuestTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatQuestTextAll.CreateStaticDefaultValue), new Action(ConfigPreheatQuestTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00152D18 File Offset: 0x00150F18
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatQuestTextAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatQuestTextAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatQuestText"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatQuestText`")
			});
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00152D97 File Offset: 0x00150F97
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatQuestTextAll.LogPair = null;
			ConfigPreheatQuestTextAll.HandleId = 0;
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00152DA5 File Offset: 0x00150FA5
		public static void Init()
		{
			ConfigPreheatQuestTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatQuestTextAll.HandleId, "db_preheat.db", "select BinData from `PreheatQuestText`");
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00152DC0 File Offset: 0x00150FC0
		[NullableContext(2)]
		public static IReadOnlyList<PreheatQuestText> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatQuestTextAll.HandleId, ConfigPreheatQuestTextAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreheatQuestText> readOnlyList = (IReadOnlyList<PreheatQuestText>)ConfigCommon.GetConfig("PreheatQuestTextAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreheatQuestText> list = new List<PreheatQuestText>();
			while (ConfigCommon.Step(ConfigPreheatQuestTextAll.HandleId, false, ConfigPreheatQuestTextAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatQuestTextAll.HandleId, 0, ConfigPreheatQuestTextAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreheatQuestTextAll.HandleId, ConfigPreheatQuestTextAll.LogPair);
					return null;
				}
				PreheatQuestText rootAsPreheatQuestText = PreheatQuestText.GetRootAsPreheatQuestText(new ByteBuffer(item2));
				list.Add(rootAsPreheatQuestText);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreheatQuestTextAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreheatQuestTextAll.HandleId, ConfigPreheatQuestTextAll.LogPair);
			return list;
		}

		// Token: 0x0400334E RID: 13134
		private const string DB = "db_preheat.db";

		// Token: 0x0400334F RID: 13135
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003350 RID: 13136
		private const string TABLE = "PreheatQuestText";

		// Token: 0x04003351 RID: 13137
		private const string COMMAND = "select BinData from `PreheatQuestText`";

		// Token: 0x04003352 RID: 13138
		private const string KEY_PREFIX = "PreheatQuestTextAll";

		// Token: 0x04003353 RID: 13139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003354 RID: 13140
		private static int HandleId;
	}
}
