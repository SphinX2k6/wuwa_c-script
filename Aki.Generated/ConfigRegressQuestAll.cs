using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D4 RID: 2004
	public class ConfigRegressQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F0A RID: 12042 RVA: 0x0016321D File Offset: 0x0016141D
		static ConfigRegressQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressQuestAll.CreateStaticDefaultValue), new Action(ConfigRegressQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0016323C File Offset: 0x0016143C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressQuestAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressQuestAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressQuest`")
			});
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x001632BB File Offset: 0x001614BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressQuestAll.LogPair = null;
			ConfigRegressQuestAll.HandleId = 0;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x001632C9 File Offset: 0x001614C9
		public static void Init()
		{
			ConfigRegressQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressQuestAll.HandleId, "db_regressactivity.db", "select BinData from `RegressQuest`");
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x001632E4 File Offset: 0x001614E4
		[NullableContext(2)]
		public static IReadOnlyList<RegressQuest> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressQuestAll.HandleId, ConfigRegressQuestAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressQuest> readOnlyList = (IReadOnlyList<RegressQuest>)ConfigCommon.GetConfig("RegressQuestAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressQuest> list = new List<RegressQuest>();
			while (ConfigCommon.Step(ConfigRegressQuestAll.HandleId, false, ConfigRegressQuestAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressQuestAll.HandleId, 0, ConfigRegressQuestAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressQuestAll.HandleId, ConfigRegressQuestAll.LogPair);
					return null;
				}
				RegressQuest rootAsRegressQuest = RegressQuest.GetRootAsRegressQuest(new ByteBuffer(item2));
				list.Add(rootAsRegressQuest);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressQuestAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressQuestAll.HandleId, ConfigRegressQuestAll.LogPair);
			return list;
		}

		// Token: 0x040036B2 RID: 14002
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036B3 RID: 14003
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036B4 RID: 14004
		private const string TABLE = "RegressQuest";

		// Token: 0x040036B5 RID: 14005
		private const string COMMAND = "select BinData from `RegressQuest`";

		// Token: 0x040036B6 RID: 14006
		private const string KEY_PREFIX = "RegressQuestAll";

		// Token: 0x040036B7 RID: 14007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036B8 RID: 14008
		private static int HandleId;
	}
}
