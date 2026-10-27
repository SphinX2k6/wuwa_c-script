using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000268 RID: 616
	public class ConfigEmotionBubbleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x000AB114 File Offset: 0x000A9314
		static ConfigEmotionBubbleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000AB134 File Offset: 0x000A9334
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubbleconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/b.表情气泡/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleConfig`")
			});
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000AB1B3 File Offset: 0x000A93B3
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigAll.LogPair = null;
			ConfigEmotionBubbleConfigAll.HandleId = 0;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000AB1C1 File Offset: 0x000A93C1
		public static void Init()
		{
			ConfigEmotionBubbleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleConfigAll.HandleId, "db_emotionbubbleconfig.db", "select BinData from `EmotionBubbleConfig`");
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000AB1DC File Offset: 0x000A93DC
		[NullableContext(2)]
		public static IReadOnlyList<EmotionBubbleConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleConfigAll.HandleId, ConfigEmotionBubbleConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EmotionBubbleConfig> readOnlyList = (IReadOnlyList<EmotionBubbleConfig>)ConfigCommon.GetConfig("EmotionBubbleConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EmotionBubbleConfig> list = new List<EmotionBubbleConfig>();
			while (ConfigCommon.Step(ConfigEmotionBubbleConfigAll.HandleId, false, ConfigEmotionBubbleConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleConfigAll.HandleId, 0, ConfigEmotionBubbleConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEmotionBubbleConfigAll.HandleId, ConfigEmotionBubbleConfigAll.LogPair);
					return null;
				}
				EmotionBubbleConfig rootAsEmotionBubbleConfig = EmotionBubbleConfig.GetRootAsEmotionBubbleConfig(new ByteBuffer(item2));
				list.Add(rootAsEmotionBubbleConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EmotionBubbleConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleConfigAll.HandleId, ConfigEmotionBubbleConfigAll.LogPair);
			return list;
		}

		// Token: 0x040010BC RID: 4284
		private const string DB = "db_emotionbubbleconfig.db";

		// Token: 0x040010BD RID: 4285
		private const string FILE = "k.可视化编辑/c.Csv/b.表情气泡/*.csv*";

		// Token: 0x040010BE RID: 4286
		private const string TABLE = "EmotionBubbleConfig";

		// Token: 0x040010BF RID: 4287
		private const string COMMAND = "select BinData from `EmotionBubbleConfig`";

		// Token: 0x040010C0 RID: 4288
		private const string KEY_PREFIX = "EmotionBubbleConfigAll";

		// Token: 0x040010C1 RID: 4289
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010C2 RID: 4290
		private static int HandleId;
	}
}
