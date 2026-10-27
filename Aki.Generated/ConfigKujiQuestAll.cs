using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000480 RID: 1152
	public class ConfigKujiQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x000F237B File Offset: 0x000F057B
		static ConfigKujiQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestAll.CreateStaticDefaultValue), new Action(ConfigKujiQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000F239C File Offset: 0x000F059C
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiQuestAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiQuestAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiQuest`")
			});
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000F241B File Offset: 0x000F061B
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestAll.LogPair = null;
			ConfigKujiQuestAll.HandleId = 0;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000F2429 File Offset: 0x000F0629
		public static void Init()
		{
			ConfigKujiQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestAll.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest`");
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000F2444 File Offset: 0x000F0644
		[NullableContext(2)]
		public static IReadOnlyList<KujiQuest> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiQuestAll.HandleId, ConfigKujiQuestAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KujiQuest> readOnlyList = (IReadOnlyList<KujiQuest>)ConfigCommon.GetConfig("KujiQuestAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KujiQuest> list = new List<KujiQuest>();
			while (ConfigCommon.Step(ConfigKujiQuestAll.HandleId, false, ConfigKujiQuestAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiQuestAll.HandleId, 0, ConfigKujiQuestAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKujiQuestAll.HandleId, ConfigKujiQuestAll.LogPair);
					return null;
				}
				KujiQuest rootAsKujiQuest = KujiQuest.GetRootAsKujiQuest(new ByteBuffer(item2));
				list.Add(rootAsKujiQuest);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KujiQuestAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKujiQuestAll.HandleId, ConfigKujiQuestAll.LogPair);
			return list;
		}

		// Token: 0x04001F64 RID: 8036
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F65 RID: 8037
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F66 RID: 8038
		private const string TABLE = "KujiQuest";

		// Token: 0x04001F67 RID: 8039
		private const string COMMAND = "select BinData from `KujiQuest`";

		// Token: 0x04001F68 RID: 8040
		private const string KEY_PREFIX = "KujiQuestAll";

		// Token: 0x04001F69 RID: 8041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F6A RID: 8042
		private static int HandleId;
	}
}
