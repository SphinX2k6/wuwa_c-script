using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000279 RID: 633
	public class ConfigEmotionBubbleAnimalConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x000B0E17 File Offset: 0x000AF017
		static ConfigEmotionBubbleAnimalConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000B0E38 File Offset: 0x000AF038
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

		// Token: 0x06000EDC RID: 3804 RVA: 0x000B0EB7 File Offset: 0x000AF0B7
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigAll.LogPair = null;
			ConfigEmotionBubbleAnimalConfigAll.HandleId = 0;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000B0EC5 File Offset: 0x000AF0C5
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigAll.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig`");
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000B0EE0 File Offset: 0x000AF0E0
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

		// Token: 0x04001133 RID: 4403
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x04001134 RID: 4404
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x04001135 RID: 4405
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x04001136 RID: 4406
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig`";

		// Token: 0x04001137 RID: 4407
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigAll";

		// Token: 0x04001138 RID: 4408
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001139 RID: 4409
		private static int HandleId;
	}
}
