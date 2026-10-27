using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000266 RID: 614
	public class ConfigEmotionBubbleAnimalConfigByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E68 RID: 3688 RVA: 0x000AACE7 File Offset: 0x000A8EE7
		static ConfigEmotionBubbleAnimalConfigByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigByBp.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigByBp.ResetStaticDefaultValue));
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000AAD08 File Offset: 0x000A8F08
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

		// Token: 0x06000E6A RID: 3690 RVA: 0x000AAD87 File Offset: 0x000A8F87
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigByBp.LogPair = null;
			ConfigEmotionBubbleAnimalConfigByBp.HandleId = 0;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000AAD95 File Offset: 0x000A8F95
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigByBp.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigByBp.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig` where MonsterBp=?");
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000AADB0 File Offset: 0x000A8FB0
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

		// Token: 0x040010AE RID: 4270
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x040010AF RID: 4271
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x040010B0 RID: 4272
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x040010B1 RID: 4273
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig` where MonsterBp=?";

		// Token: 0x040010B2 RID: 4274
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigByBp";

		// Token: 0x040010B3 RID: 4275
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010B4 RID: 4276
		private static int HandleId;
	}
}
