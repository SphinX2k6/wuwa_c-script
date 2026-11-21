using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E1 RID: 2017
	public class ConfigRefResourceQuestListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x0016868B File Offset: 0x0016688B
		static ConfigRefResourceQuestListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefResourceQuestListAll.CreateStaticDefaultValue), new Action(ConfigRefResourceQuestListAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x001686AC File Offset: 0x001668AC
		public static void CreateStaticDefaultValue()
		{
			ConfigRefResourceQuestListAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRefResourceQuestListAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_refresourcequestlist.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv"),
				new ValueTuple<string, object>("表名", "RefResourceQuestList"),
				new ValueTuple<string, object>("语句", "select BinData from `RefResourceQuestList`")
			});
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x0016872B File Offset: 0x0016692B
		public static void ResetStaticDefaultValue()
		{
			ConfigRefResourceQuestListAll.LogPair = null;
			ConfigRefResourceQuestListAll.HandleId = 0;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00168739 File Offset: 0x00166939
		public static void Init()
		{
			ConfigRefResourceQuestListAll.HandleId = ConfigCommon.InitDataStatement(ConfigRefResourceQuestListAll.HandleId, "db_refresourcequestlist.db", "select BinData from `RefResourceQuestList`");
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00168754 File Offset: 0x00166954
		[NullableContext(2)]
		public static IReadOnlyList<RefResourceQuestList> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRefResourceQuestListAll.HandleId, ConfigRefResourceQuestListAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RefResourceQuestList> readOnlyList = (IReadOnlyList<RefResourceQuestList>)ConfigCommon.GetConfig("RefResourceQuestListAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RefResourceQuestList> list = new List<RefResourceQuestList>();
			while (ConfigCommon.Step(ConfigRefResourceQuestListAll.HandleId, false, ConfigRefResourceQuestListAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRefResourceQuestListAll.HandleId, 0, ConfigRefResourceQuestListAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRefResourceQuestListAll.HandleId, ConfigRefResourceQuestListAll.LogPair);
					return null;
				}
				RefResourceQuestList rootAsRefResourceQuestList = RefResourceQuestList.GetRootAsRefResourceQuestList(new ByteBuffer(item2));
				list.Add(rootAsRefResourceQuestList);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RefResourceQuestListAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRefResourceQuestListAll.HandleId, ConfigRefResourceQuestListAll.LogPair);
			return list;
		}

		// Token: 0x0400370D RID: 14093
		private const string DB = "db_refresourcequestlist.db";

		// Token: 0x0400370E RID: 14094
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv";

		// Token: 0x0400370F RID: 14095
		private const string TABLE = "RefResourceQuestList";

		// Token: 0x04003710 RID: 14096
		private const string COMMAND = "select BinData from `RefResourceQuestList`";

		// Token: 0x04003711 RID: 14097
		private const string KEY_PREFIX = "RefResourceQuestListAll";

		// Token: 0x04003712 RID: 14098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003713 RID: 14099
		private static int HandleId;
	}
}
