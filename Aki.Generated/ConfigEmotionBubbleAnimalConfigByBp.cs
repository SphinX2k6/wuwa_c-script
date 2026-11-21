using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027A RID: 634
	public class ConfigEmotionBubbleAnimalConfigByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x000B0FAB File Offset: 0x000AF1AB
		static ConfigEmotionBubbleAnimalConfigByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigByBp.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigByBp.ResetStaticDefaultValue));
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000B0FCC File Offset: 0x000AF1CC
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigByBp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleAnimalConfigByBp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubbleanimalconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleAnimalConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleAnimalConfig` where MonsterBp=?")
			});
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000B104B File Offset: 0x000AF24B
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigByBp.LogPair = null;
			ConfigEmotionBubbleAnimalConfigByBp.HandleId = 0;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000B1059 File Offset: 0x000AF259
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigByBp.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigByBp.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig` where MonsterBp=?");
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000B1074 File Offset: 0x000AF274
		[return: Nullable(2)]
		public static IReadOnlyList<EmotionBubbleAnimalConfig> GetConfigList(string p0MonsterBp, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleAnimalConfigByBp.HandleId, ConfigEmotionBubbleAnimalConfigByBp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EmotionBubbleAnimalConfig> readOnlyList = (IReadOnlyList<EmotionBubbleAnimalConfig>)ConfigCommon.GetConfig("EmotionBubbleAnimalConfigByBp#" + p0MonsterBp);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEmotionBubbleAnimalConfigByBp.LogPair.Clear();
			ConfigEmotionBubbleAnimalConfigByBp.LogPair.Add(new ValueTuple<string, object>("MonsterBp", p0MonsterBp));
			if (!ConfigCommon.BindString(ConfigEmotionBubbleAnimalConfigByBp.HandleId, 1, p0MonsterBp, ConfigEmotionBubbleAnimalConfigByBp.LogPair))
			{
				ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigByBp.HandleId, ConfigEmotionBubbleAnimalConfigByBp.LogPair);
				return null;
			}
			List<EmotionBubbleAnimalConfig> list = new List<EmotionBubbleAnimalConfig>();
			while (ConfigCommon.Step(ConfigEmotionBubbleAnimalConfigByBp.HandleId, false, ConfigEmotionBubbleAnimalConfigByBp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleAnimalConfigByBp.HandleId, 0, ConfigEmotionBubbleAnimalConfigByBp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigByBp.HandleId, ConfigEmotionBubbleAnimalConfigByBp.LogPair);
					return null;
				}
				EmotionBubbleAnimalConfig rootAsEmotionBubbleAnimalConfig = EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(new ByteBuffer(item2));
				list.Add(rootAsEmotionBubbleAnimalConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EmotionBubbleAnimalConfigByBp#" + p0MonsterBp, list, list.Count);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigByBp.HandleId, ConfigEmotionBubbleAnimalConfigByBp.LogPair);
			return list;
		}

		// Token: 0x0400113A RID: 4410
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x0400113B RID: 4411
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x0400113C RID: 4412
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x0400113D RID: 4413
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig` where MonsterBp=?";

		// Token: 0x0400113E RID: 4414
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigByBp";

		// Token: 0x0400113F RID: 4415
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001140 RID: 4416
		private static int HandleId;
	}
}
