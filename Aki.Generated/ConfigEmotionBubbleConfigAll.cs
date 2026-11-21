using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027C RID: 636
	public class ConfigEmotionBubbleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EEC RID: 3820 RVA: 0x000B13D8 File Offset: 0x000AF5D8
		static ConfigEmotionBubbleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000B13F8 File Offset: 0x000AF5F8
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

		// Token: 0x06000EEE RID: 3822 RVA: 0x000B1477 File Offset: 0x000AF677
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigAll.LogPair = null;
			ConfigEmotionBubbleConfigAll.HandleId = 0;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000B1485 File Offset: 0x000AF685
		public static void Init()
		{
			ConfigEmotionBubbleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleConfigAll.HandleId, "db_emotionbubbleconfig.db", "select BinData from `EmotionBubbleConfig`");
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000B14A0 File Offset: 0x000AF6A0
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

		// Token: 0x04001148 RID: 4424
		private const string DB = "db_emotionbubbleconfig.db";

		// Token: 0x04001149 RID: 4425
		private const string FILE = "k.可视化编辑/c.Csv/b.表情气泡/*.csv*";

		// Token: 0x0400114A RID: 4426
		private const string TABLE = "EmotionBubbleConfig";

		// Token: 0x0400114B RID: 4427
		private const string COMMAND = "select BinData from `EmotionBubbleConfig`";

		// Token: 0x0400114C RID: 4428
		private const string KEY_PREFIX = "EmotionBubbleConfigAll";

		// Token: 0x0400114D RID: 4429
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400114E RID: 4430
		private static int HandleId;
	}
}
