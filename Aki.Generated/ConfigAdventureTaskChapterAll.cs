using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000065 RID: 101
	public class ConfigAdventureTaskChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0006A940 File Offset: 0x00068B40
		static ConfigAdventureTaskChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterAll.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0006A960 File Offset: 0x00068B60
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskChapterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskChapterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventuretask.db"),
				new ValueTuple<string, object>("文件", "k.开拓任务.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTaskChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTaskChapter`")
			});
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0006A9DF File Offset: 0x00068BDF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterAll.LogPair = null;
			ConfigAdventureTaskChapterAll.HandleId = 0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0006A9ED File Offset: 0x00068BED
		public static void Init()
		{
			ConfigAdventureTaskChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterAll.HandleId, "db_adventuretask.db", "select BinData from `AdventureTaskChapter`");
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0006AA08 File Offset: 0x00068C08
		[NullableContext(2)]
		public static IReadOnlyList<AdventureTaskChapter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskChapterAll.HandleId, ConfigAdventureTaskChapterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdventureTaskChapter> readOnlyList = (IReadOnlyList<AdventureTaskChapter>)ConfigCommon.GetConfig("AdventureTaskChapterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdventureTaskChapter> list = new List<AdventureTaskChapter>();
			while (ConfigCommon.Step(ConfigAdventureTaskChapterAll.HandleId, false, ConfigAdventureTaskChapterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskChapterAll.HandleId, 0, ConfigAdventureTaskChapterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdventureTaskChapterAll.HandleId, ConfigAdventureTaskChapterAll.LogPair);
					return null;
				}
				AdventureTaskChapter rootAsAdventureTaskChapter = AdventureTaskChapter.GetRootAsAdventureTaskChapter(new ByteBuffer(item2));
				list.Add(rootAsAdventureTaskChapter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdventureTaskChapterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdventureTaskChapterAll.HandleId, ConfigAdventureTaskChapterAll.LogPair);
			return list;
		}

		// Token: 0x040002A7 RID: 679
		private const string DB = "db_adventuretask.db";

		// Token: 0x040002A8 RID: 680
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x040002A9 RID: 681
		private const string TABLE = "AdventureTaskChapter";

		// Token: 0x040002AA RID: 682
		private const string COMMAND = "select BinData from `AdventureTaskChapter`";

		// Token: 0x040002AB RID: 683
		private const string KEY_PREFIX = "AdventureTaskChapterAll";

		// Token: 0x040002AC RID: 684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002AD RID: 685
		private static int HandleId;
	}
}
