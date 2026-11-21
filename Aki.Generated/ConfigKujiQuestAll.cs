using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000496 RID: 1174
	public class ConfigKujiQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B8E RID: 7054 RVA: 0x000F8ACF File Offset: 0x000F6CCF
		static ConfigKujiQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestAll.CreateStaticDefaultValue), new Action(ConfigKujiQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000F8AF0 File Offset: 0x000F6CF0
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

		// Token: 0x06001B90 RID: 7056 RVA: 0x000F8B6F File Offset: 0x000F6D6F
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestAll.LogPair = null;
			ConfigKujiQuestAll.HandleId = 0;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000F8B7D File Offset: 0x000F6D7D
		public static void Init()
		{
			ConfigKujiQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestAll.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest`");
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000F8B98 File Offset: 0x000F6D98
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

		// Token: 0x04001FFE RID: 8190
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001FFF RID: 8191
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04002000 RID: 8192
		private const string TABLE = "KujiQuest";

		// Token: 0x04002001 RID: 8193
		private const string COMMAND = "select BinData from `KujiQuest`";

		// Token: 0x04002002 RID: 8194
		private const string KEY_PREFIX = "KujiQuestAll";

		// Token: 0x04002003 RID: 8195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002004 RID: 8196
		private static int HandleId;
	}
}
