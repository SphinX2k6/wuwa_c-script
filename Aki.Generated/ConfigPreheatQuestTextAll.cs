using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000770 RID: 1904
	public class ConfigPreheatQuestTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CB1 RID: 11441 RVA: 0x00159774 File Offset: 0x00157974
		static ConfigPreheatQuestTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatQuestTextAll.CreateStaticDefaultValue), new Action(ConfigPreheatQuestTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00159794 File Offset: 0x00157994
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

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00159813 File Offset: 0x00157A13
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatQuestTextAll.LogPair = null;
			ConfigPreheatQuestTextAll.HandleId = 0;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00159821 File Offset: 0x00157A21
		public static void Init()
		{
			ConfigPreheatQuestTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatQuestTextAll.HandleId, "db_preheat.db", "select BinData from `PreheatQuestText`");
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0015983C File Offset: 0x00157A3C
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

		// Token: 0x040033F6 RID: 13302
		private const string DB = "db_preheat.db";

		// Token: 0x040033F7 RID: 13303
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x040033F8 RID: 13304
		private const string TABLE = "PreheatQuestText";

		// Token: 0x040033F9 RID: 13305
		private const string COMMAND = "select BinData from `PreheatQuestText`";

		// Token: 0x040033FA RID: 13306
		private const string KEY_PREFIX = "PreheatQuestTextAll";

		// Token: 0x040033FB RID: 13307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033FC RID: 13308
		private static int HandleId;
	}
}
