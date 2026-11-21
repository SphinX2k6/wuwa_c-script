using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E3 RID: 995
	public class ConfigHandBookQuestTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x000E10BC File Offset: 0x000DF2BC
		static ConfigHandBookQuestTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookQuestTabAll.CreateStaticDefaultValue), new Action(ConfigHandBookQuestTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000E10DC File Offset: 0x000DF2DC
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

		// Token: 0x0600175B RID: 5979 RVA: 0x000E115B File Offset: 0x000DF35B
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookQuestTabAll.LogPair = null;
			ConfigHandBookQuestTabAll.HandleId = 0;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000E1169 File Offset: 0x000DF369
		public static void Init()
		{
			ConfigHandBookQuestTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookQuestTabAll.HandleId, "db_handbook.db", "select BinData from `HandBookQuestTab`");
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000E1184 File Offset: 0x000DF384
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

		// Token: 0x04001B19 RID: 6937
		private const string DB = "db_handbook.db";

		// Token: 0x04001B1A RID: 6938
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001B1B RID: 6939
		private const string TABLE = "HandBookQuestTab";

		// Token: 0x04001B1C RID: 6940
		private const string COMMAND = "select BinData from `HandBookQuestTab`";

		// Token: 0x04001B1D RID: 6941
		private const string KEY_PREFIX = "HandBookQuestTabAll";

		// Token: 0x04001B1E RID: 6942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B1F RID: 6943
		private static int HandleId;
	}
}
