using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CD RID: 973
	public class ConfigHandBookQuestTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016D5 RID: 5845 RVA: 0x000DA968 File Offset: 0x000D8B68
		static ConfigHandBookQuestTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookQuestTabAll.CreateStaticDefaultValue), new Action(ConfigHandBookQuestTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000DA988 File Offset: 0x000D8B88
		public static void CreateStaticDefaultValue()
		{
			ConfigHandBookQuestTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHandBookQuestTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "HandBookQuestTab"),
				new ValueTuple<string, object>("语句", "select BinData from `HandBookQuestTab`")
			});
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000DAA07 File Offset: 0x000D8C07
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookQuestTabAll.LogPair = null;
			ConfigHandBookQuestTabAll.HandleId = 0;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000DAA15 File Offset: 0x000D8C15
		public static void Init()
		{
			ConfigHandBookQuestTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookQuestTabAll.HandleId, "db_handbook.db", "select BinData from `HandBookQuestTab`");
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000DAA30 File Offset: 0x000D8C30
		[NullableContext(2)]
		public static IReadOnlyList<HandBookQuestTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHandBookQuestTabAll.HandleId, ConfigHandBookQuestTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HandBookQuestTab> readOnlyList = (IReadOnlyList<HandBookQuestTab>)ConfigCommon.GetConfig("HandBookQuestTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HandBookQuestTab> list = new List<HandBookQuestTab>();
			while (ConfigCommon.Step(ConfigHandBookQuestTabAll.HandleId, false, ConfigHandBookQuestTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHandBookQuestTabAll.HandleId, 0, ConfigHandBookQuestTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHandBookQuestTabAll.HandleId, ConfigHandBookQuestTabAll.LogPair);
					return null;
				}
				HandBookQuestTab rootAsHandBookQuestTab = HandBookQuestTab.GetRootAsHandBookQuestTab(new ByteBuffer(item2));
				list.Add(rootAsHandBookQuestTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HandBookQuestTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHandBookQuestTabAll.HandleId, ConfigHandBookQuestTabAll.LogPair);
			return list;
		}

		// Token: 0x04001A7F RID: 6783
		private const string DB = "db_handbook.db";

		// Token: 0x04001A80 RID: 6784
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001A81 RID: 6785
		private const string TABLE = "HandBookQuestTab";

		// Token: 0x04001A82 RID: 6786
		private const string COMMAND = "select BinData from `HandBookQuestTab`";

		// Token: 0x04001A83 RID: 6787
		private const string KEY_PREFIX = "HandBookQuestTabAll";

		// Token: 0x04001A84 RID: 6788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A85 RID: 6789
		private static int HandleId;
	}
}
