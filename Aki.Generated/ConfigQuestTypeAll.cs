using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000793 RID: 1939
	public class ConfigQuestTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D84 RID: 11652 RVA: 0x0015A72C File Offset: 0x0015892C
		static ConfigQuestTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeAll.CreateStaticDefaultValue), new Action(ConfigQuestTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x0015A74C File Offset: 0x0015894C
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtype.db"),
				new ValueTuple<string, object>("文件", "r.任务类型.xlsx"),
				new ValueTuple<string, object>("表名", "QuestType"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestType`")
			});
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0015A7CB File Offset: 0x001589CB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeAll.LogPair = null;
			ConfigQuestTypeAll.HandleId = 0;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0015A7D9 File Offset: 0x001589D9
		public static void Init()
		{
			ConfigQuestTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeAll.HandleId, "db_questtype.db", "select BinData from `QuestType`");
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x0015A7F4 File Offset: 0x001589F4
		[NullableContext(2)]
		public static IReadOnlyList<QuestType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTypeAll.HandleId, ConfigQuestTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestType> readOnlyList = (IReadOnlyList<QuestType>)ConfigCommon.GetConfig("QuestTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestType> list = new List<QuestType>();
			while (ConfigCommon.Step(ConfigQuestTypeAll.HandleId, false, ConfigQuestTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTypeAll.HandleId, 0, ConfigQuestTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestTypeAll.HandleId, ConfigQuestTypeAll.LogPair);
					return null;
				}
				QuestType rootAsQuestType = QuestType.GetRootAsQuestType(new ByteBuffer(item2));
				list.Add(rootAsQuestType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestTypeAll.HandleId, ConfigQuestTypeAll.LogPair);
			return list;
		}

		// Token: 0x040034EB RID: 13547
		private const string DB = "db_questtype.db";

		// Token: 0x040034EC RID: 13548
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040034ED RID: 13549
		private const string TABLE = "QuestType";

		// Token: 0x040034EE RID: 13550
		private const string COMMAND = "select BinData from `QuestType`";

		// Token: 0x040034EF RID: 13551
		private const string KEY_PREFIX = "QuestTypeAll";

		// Token: 0x040034F0 RID: 13552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034F1 RID: 13553
		private static int HandleId;
	}
}
