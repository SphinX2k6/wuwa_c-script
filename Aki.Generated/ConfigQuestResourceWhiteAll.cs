using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000798 RID: 1944
	public class ConfigQuestResourceWhiteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DA1 RID: 11681 RVA: 0x0015E8EF File Offset: 0x0015CAEF
		static ConfigQuestResourceWhiteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestResourceWhiteAll.CreateStaticDefaultValue), new Action(ConfigQuestResourceWhiteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0015E910 File Offset: 0x0015CB10
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

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0015E98F File Offset: 0x0015CB8F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestResourceWhiteAll.LogPair = null;
			ConfigQuestResourceWhiteAll.HandleId = 0;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0015E99D File Offset: 0x0015CB9D
		public static void Init()
		{
			ConfigQuestResourceWhiteAll.HandleId = ConfigCommon.InitDataStatement(ConfigQuestResourceWhiteAll.HandleId, "db_download.db", "select BinData from `QuestResourceWhite`");
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0015E9B8 File Offset: 0x0015CBB8
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

		// Token: 0x0400350E RID: 13582
		private const string DB = "db_download.db";

		// Token: 0x0400350F RID: 13583
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04003510 RID: 13584
		private const string TABLE = "QuestResourceWhite";

		// Token: 0x04003511 RID: 13585
		private const string COMMAND = "select BinData from `QuestResourceWhite`";

		// Token: 0x04003512 RID: 13586
		private const string KEY_PREFIX = "QuestResourceWhiteAll";

		// Token: 0x04003513 RID: 13587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003514 RID: 13588
		private static int HandleId;
	}
}
