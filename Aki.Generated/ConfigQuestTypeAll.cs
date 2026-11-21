using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AD RID: 1965
	public class ConfigQuestTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E20 RID: 11808 RVA: 0x00161638 File Offset: 0x0015F838
		static ConfigQuestTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTypeAll.CreateStaticDefaultValue), new Action(ConfigQuestTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00161658 File Offset: 0x0015F858
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

		// Token: 0x06002E22 RID: 11810 RVA: 0x001616D7 File Offset: 0x0015F8D7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTypeAll.LogPair = null;
			ConfigQuestTypeAll.HandleId = 0;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x001616E5 File Offset: 0x0015F8E5
		public static void Init()
		{
			ConfigQuestTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTypeAll.HandleId, "db_questtype.db", "select BinData from `QuestType`");
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00161700 File Offset: 0x0015F900
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

		// Token: 0x040035A1 RID: 13729
		private const string DB = "db_questtype.db";

		// Token: 0x040035A2 RID: 13730
		private const string FILE = "r.任务类型.xlsx";

		// Token: 0x040035A3 RID: 13731
		private const string TABLE = "QuestType";

		// Token: 0x040035A4 RID: 13732
		private const string COMMAND = "select BinData from `QuestType`";

		// Token: 0x040035A5 RID: 13733
		private const string KEY_PREFIX = "QuestTypeAll";

		// Token: 0x040035A6 RID: 13734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035A7 RID: 13735
		private static int HandleId;
	}
}
