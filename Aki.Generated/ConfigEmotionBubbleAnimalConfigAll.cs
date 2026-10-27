using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000265 RID: 613
	public class ConfigEmotionBubbleAnimalConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x000AAB53 File Offset: 0x000A8D53
		static ConfigEmotionBubbleAnimalConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000AAB74 File Offset: 0x000A8D74
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleAnimalConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubbleanimalconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleAnimalConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleAnimalConfig`")
			});
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000AABF3 File Offset: 0x000A8DF3
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigAll.LogPair = null;
			ConfigEmotionBubbleAnimalConfigAll.HandleId = 0;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000AAC01 File Offset: 0x000A8E01
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigAll.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig`");
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000AAC1C File Offset: 0x000A8E1C
		[NullableContext(2)]
		public static IReadOnlyList<EmotionBubbleAnimalConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleAnimalConfigAll.HandleId, ConfigEmotionBubbleAnimalConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EmotionBubbleAnimalConfig> readOnlyList = (IReadOnlyList<EmotionBubbleAnimalConfig>)ConfigCommon.GetConfig("EmotionBubbleAnimalConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EmotionBubbleAnimalConfig> list = new List<EmotionBubbleAnimalConfig>();
			while (ConfigCommon.Step(ConfigEmotionBubbleAnimalConfigAll.HandleId, false, ConfigEmotionBubbleAnimalConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleAnimalConfigAll.HandleId, 0, ConfigEmotionBubbleAnimalConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigAll.HandleId, ConfigEmotionBubbleAnimalConfigAll.LogPair);
					return null;
				}
				EmotionBubbleAnimalConfig rootAsEmotionBubbleAnimalConfig = EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(new ByteBuffer(item2));
				list.Add(rootAsEmotionBubbleAnimalConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EmotionBubbleAnimalConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigAll.HandleId, ConfigEmotionBubbleAnimalConfigAll.LogPair);
			return list;
		}

		// Token: 0x040010A7 RID: 4263
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x040010A8 RID: 4264
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x040010A9 RID: 4265
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x040010AA RID: 4266
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig`";

		// Token: 0x040010AB RID: 4267
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigAll";

		// Token: 0x040010AC RID: 4268
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010AD RID: 4269
		private static int HandleId;
	}
}
