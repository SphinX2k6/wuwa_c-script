using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005D RID: 93
	public class ConfigAdventureTaskChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600022E RID: 558 RVA: 0x0006608C File Offset: 0x0006428C
		static ConfigAdventureTaskChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterAll.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000660AC File Offset: 0x000642AC
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

		// Token: 0x06000230 RID: 560 RVA: 0x0006612B File Offset: 0x0006432B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterAll.LogPair = null;
			ConfigAdventureTaskChapterAll.HandleId = 0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00066139 File Offset: 0x00064339
		public static void Init()
		{
			ConfigAdventureTaskChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterAll.HandleId, "db_adventuretask.db", "select BinData from `AdventureTaskChapter`");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00066154 File Offset: 0x00064354
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

		// Token: 0x0400026F RID: 623
		private const string DB = "db_adventuretask.db";

		// Token: 0x04000270 RID: 624
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x04000271 RID: 625
		private const string TABLE = "AdventureTaskChapter";

		// Token: 0x04000272 RID: 626
		private const string COMMAND = "select BinData from `AdventureTaskChapter`";

		// Token: 0x04000273 RID: 627
		private const string KEY_PREFIX = "AdventureTaskChapterAll";

		// Token: 0x04000274 RID: 628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000275 RID: 629
		private static int HandleId;
	}
}
