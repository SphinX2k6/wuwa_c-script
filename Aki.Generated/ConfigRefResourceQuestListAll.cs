using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C5 RID: 1989
	public class ConfigRefResourceQuestListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EB0 RID: 11952 RVA: 0x001613A3 File Offset: 0x0015F5A3
		static ConfigRefResourceQuestListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefResourceQuestListAll.CreateStaticDefaultValue), new Action(ConfigRefResourceQuestListAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x001613C4 File Offset: 0x0015F5C4
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

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00161443 File Offset: 0x0015F643
		public static void ResetStaticDefaultValue()
		{
			ConfigRefResourceQuestListAll.LogPair = null;
			ConfigRefResourceQuestListAll.HandleId = 0;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00161451 File Offset: 0x0015F651
		public static void Init()
		{
			ConfigRefResourceQuestListAll.HandleId = ConfigCommon.InitDataStatement(ConfigRefResourceQuestListAll.HandleId, "db_refresourcequestlist.db", "select BinData from `RefResourceQuestList`");
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x0016146C File Offset: 0x0015F66C
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

		// Token: 0x04003649 RID: 13897
		private const string DB = "db_refresourcequestlist.db";

		// Token: 0x0400364A RID: 13898
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv";

		// Token: 0x0400364B RID: 13899
		private const string TABLE = "RefResourceQuestList";

		// Token: 0x0400364C RID: 13900
		private const string COMMAND = "select BinData from `RefResourceQuestList`";

		// Token: 0x0400364D RID: 13901
		private const string KEY_PREFIX = "RefResourceQuestListAll";

		// Token: 0x0400364E RID: 13902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400364F RID: 13903
		private static int HandleId;
	}
}
