using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077E RID: 1918
	public class ConfigQuestResourceWhiteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D05 RID: 11525 RVA: 0x001579E3 File Offset: 0x00155BE3
		static ConfigQuestResourceWhiteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestResourceWhiteAll.CreateStaticDefaultValue), new Action(ConfigQuestResourceWhiteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00157A04 File Offset: 0x00155C04
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestResourceWhiteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestResourceWhiteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "QuestResourceWhite"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestResourceWhite`")
			});
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00157A83 File Offset: 0x00155C83
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestResourceWhiteAll.LogPair = null;
			ConfigQuestResourceWhiteAll.HandleId = 0;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00157A91 File Offset: 0x00155C91
		public static void Init()
		{
			ConfigQuestResourceWhiteAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestResourceWhiteAll.HandleId, "db_download.db", "select BinData from `QuestResourceWhite`");
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00157AAC File Offset: 0x00155CAC
		[NullableContext(2)]
		public static IReadOnlyList<QuestResourceWhite> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestResourceWhiteAll.HandleId, ConfigQuestResourceWhiteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QuestResourceWhite> readOnlyList = (IReadOnlyList<QuestResourceWhite>)ConfigCommon.GetConfig("QuestResourceWhiteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QuestResourceWhite> list = new List<QuestResourceWhite>();
			while (ConfigCommon.Step(ConfigQuestResourceWhiteAll.HandleId, false, ConfigQuestResourceWhiteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestResourceWhiteAll.HandleId, 0, ConfigQuestResourceWhiteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQuestResourceWhiteAll.HandleId, ConfigQuestResourceWhiteAll.LogPair);
					return null;
				}
				QuestResourceWhite rootAsQuestResourceWhite = QuestResourceWhite.GetRootAsQuestResourceWhite(new ByteBuffer(item2));
				list.Add(rootAsQuestResourceWhite);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QuestResourceWhiteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQuestResourceWhiteAll.HandleId, ConfigQuestResourceWhiteAll.LogPair);
			return list;
		}

		// Token: 0x04003458 RID: 13400
		private const string DB = "db_download.db";

		// Token: 0x04003459 RID: 13401
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x0400345A RID: 13402
		private const string TABLE = "QuestResourceWhite";

		// Token: 0x0400345B RID: 13403
		private const string COMMAND = "select BinData from `QuestResourceWhite`";

		// Token: 0x0400345C RID: 13404
		private const string KEY_PREFIX = "QuestResourceWhiteAll";

		// Token: 0x0400345D RID: 13405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400345E RID: 13406
		private static int HandleId;
	}
}
