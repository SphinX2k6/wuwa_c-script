using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F0 RID: 2032
	public class ConfigRegressQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FB2 RID: 12210 RVA: 0x0016A505 File Offset: 0x00168705
		static ConfigRegressQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressQuestAll.CreateStaticDefaultValue), new Action(ConfigRegressQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x0016A524 File Offset: 0x00168724
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

		// Token: 0x06002FB4 RID: 12212 RVA: 0x0016A5A3 File Offset: 0x001687A3
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressQuestAll.LogPair = null;
			ConfigRegressQuestAll.HandleId = 0;
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x0016A5B1 File Offset: 0x001687B1
		public static void Init()
		{
			ConfigRegressQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressQuestAll.HandleId, "db_regressactivity.db", "select BinData from `RegressQuest`");
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x0016A5CC File Offset: 0x001687CC
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

		// Token: 0x04003776 RID: 14198
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003777 RID: 14199
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003778 RID: 14200
		private const string TABLE = "RegressQuest";

		// Token: 0x04003779 RID: 14201
		private const string COMMAND = "select BinData from `RegressQuest`";

		// Token: 0x0400377A RID: 14202
		private const string KEY_PREFIX = "RegressQuestAll";

		// Token: 0x0400377B RID: 14203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400377C RID: 14204
		private static int HandleId;
	}
}
