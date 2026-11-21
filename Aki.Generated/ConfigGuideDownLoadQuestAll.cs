using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CF RID: 975
	public class ConfigGuideDownLoadQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
		static ConfigGuideDownLoadQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDownLoadQuestAll.CreateStaticDefaultValue), new Action(ConfigGuideDownLoadQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x000DE710 File Offset: 0x000DC910
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

		// Token: 0x060016E3 RID: 5859 RVA: 0x000DE78F File Offset: 0x000DC98F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestAll.LogPair = null;
			ConfigGuideDownLoadQuestAll.HandleId = 0;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x000DE79D File Offset: 0x000DC99D
		public static void Init()
		{
			ConfigGuideDownLoadQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDownLoadQuestAll.HandleId, "db_download.db", "select BinData from `GuideDownLoadQuest`");
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000DE7B8 File Offset: 0x000DC9B8
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

		// Token: 0x04001A8D RID: 6797
		private const string DB = "db_download.db";

		// Token: 0x04001A8E RID: 6798
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04001A8F RID: 6799
		private const string TABLE = "GuideDownLoadQuest";

		// Token: 0x04001A90 RID: 6800
		private const string COMMAND = "select BinData from `GuideDownLoadQuest`";

		// Token: 0x04001A91 RID: 6801
		private const string KEY_PREFIX = "GuideDownLoadQuestAll";

		// Token: 0x04001A92 RID: 6802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A93 RID: 6803
		private static int HandleId;
	}
}
