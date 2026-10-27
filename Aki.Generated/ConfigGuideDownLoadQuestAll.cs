using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B9 RID: 953
	public class ConfigGuideDownLoadQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x000D7F9C File Offset: 0x000D619C
		static ConfigGuideDownLoadQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDownLoadQuestAll.CreateStaticDefaultValue), new Action(ConfigGuideDownLoadQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000D7FBC File Offset: 0x000D61BC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDownLoadQuestAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "GuideDownLoadQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideDownLoadQuest`")
			});
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000D803B File Offset: 0x000D623B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestAll.LogPair = null;
			ConfigGuideDownLoadQuestAll.HandleId = 0;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000D8049 File Offset: 0x000D6249
		public static void Init()
		{
			ConfigGuideDownLoadQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDownLoadQuestAll.HandleId, "db_download.db", "select BinData from `GuideDownLoadQuest`");
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000D8064 File Offset: 0x000D6264
		[NullableContext(2)]
		public static IReadOnlyList<GuideDownLoadQuest> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDownLoadQuestAll.HandleId, ConfigGuideDownLoadQuestAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuideDownLoadQuest> readOnlyList = (IReadOnlyList<GuideDownLoadQuest>)ConfigCommon.GetConfig("GuideDownLoadQuestAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuideDownLoadQuest> list = new List<GuideDownLoadQuest>();
			while (ConfigCommon.Step(ConfigGuideDownLoadQuestAll.HandleId, false, ConfigGuideDownLoadQuestAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDownLoadQuestAll.HandleId, 0, ConfigGuideDownLoadQuestAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuideDownLoadQuestAll.HandleId, ConfigGuideDownLoadQuestAll.LogPair);
					return null;
				}
				GuideDownLoadQuest rootAsGuideDownLoadQuest = GuideDownLoadQuest.GetRootAsGuideDownLoadQuest(new ByteBuffer(item2));
				list.Add(rootAsGuideDownLoadQuest);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuideDownLoadQuestAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuideDownLoadQuestAll.HandleId, ConfigGuideDownLoadQuestAll.LogPair);
			return list;
		}

		// Token: 0x040019F3 RID: 6643
		private const string DB = "db_download.db";

		// Token: 0x040019F4 RID: 6644
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040019F5 RID: 6645
		private const string TABLE = "GuideDownLoadQuest";

		// Token: 0x040019F6 RID: 6646
		private const string COMMAND = "select BinData from `GuideDownLoadQuest`";

		// Token: 0x040019F7 RID: 6647
		private const string KEY_PREFIX = "GuideDownLoadQuestAll";

		// Token: 0x040019F8 RID: 6648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019F9 RID: 6649
		private static int HandleId;
	}
}
