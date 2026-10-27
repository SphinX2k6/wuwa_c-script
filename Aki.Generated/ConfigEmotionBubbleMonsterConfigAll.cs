using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026A RID: 618
	public class ConfigEmotionBubbleMonsterConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x000AB4A1 File Offset: 0x000A96A1
		static ConfigEmotionBubbleMonsterConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleMonsterConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubblemonsterconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleMonsterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleMonsterConfig`")
			});
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000AB53F File Offset: 0x000A973F
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigAll.LogPair = null;
			ConfigEmotionBubbleMonsterConfigAll.HandleId = 0;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000AB54D File Offset: 0x000A974D
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigAll.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig`");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000AB568 File Offset: 0x000A9768
		[NullableContext(2)]
		public static IReadOnlyList<EmotionBubbleMonsterConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleMonsterConfigAll.HandleId, ConfigEmotionBubbleMonsterConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EmotionBubbleMonsterConfig> readOnlyList = (IReadOnlyList<EmotionBubbleMonsterConfig>)ConfigCommon.GetConfig("EmotionBubbleMonsterConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EmotionBubbleMonsterConfig> list = new List<EmotionBubbleMonsterConfig>();
			while (ConfigCommon.Step(ConfigEmotionBubbleMonsterConfigAll.HandleId, false, ConfigEmotionBubbleMonsterConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleMonsterConfigAll.HandleId, 0, ConfigEmotionBubbleMonsterConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigAll.HandleId, ConfigEmotionBubbleMonsterConfigAll.LogPair);
					return null;
				}
				EmotionBubbleMonsterConfig rootAsEmotionBubbleMonsterConfig = EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(new ByteBuffer(item2));
				list.Add(rootAsEmotionBubbleMonsterConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EmotionBubbleMonsterConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigAll.HandleId, ConfigEmotionBubbleMonsterConfigAll.LogPair);
			return list;
		}

		// Token: 0x040010CA RID: 4298
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x040010CB RID: 4299
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x040010CC RID: 4300
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x040010CD RID: 4301
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig`";

		// Token: 0x040010CE RID: 4302
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigAll";

		// Token: 0x040010CF RID: 4303
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010D0 RID: 4304
		private static int HandleId;
	}
}
