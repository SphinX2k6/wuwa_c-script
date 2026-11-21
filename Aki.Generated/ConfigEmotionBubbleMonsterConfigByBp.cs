using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027F RID: 639
	public class ConfigEmotionBubbleMonsterConfigByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EFE RID: 3838 RVA: 0x000B18F7 File Offset: 0x000AFAF7
		static ConfigEmotionBubbleMonsterConfigByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigByBp.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigByBp.ResetStaticDefaultValue));
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000B1918 File Offset: 0x000AFB18
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigByBp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleMonsterConfigByBp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubblemonsterconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleMonsterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleMonsterConfig` where MonsterBp=?")
			});
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000B1997 File Offset: 0x000AFB97
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigByBp.LogPair = null;
			ConfigEmotionBubbleMonsterConfigByBp.HandleId = 0;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000B19A5 File Offset: 0x000AFBA5
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigByBp.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigByBp.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig` where MonsterBp=?");
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000B19C0 File Offset: 0x000AFBC0
		[return: Nullable(2)]
		public static IReadOnlyList<EmotionBubbleMonsterConfig> GetConfigList(string p0MonsterBp, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleMonsterConfigByBp.HandleId, ConfigEmotionBubbleMonsterConfigByBp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EmotionBubbleMonsterConfig> readOnlyList = (IReadOnlyList<EmotionBubbleMonsterConfig>)ConfigCommon.GetConfig("EmotionBubbleMonsterConfigByBp#" + p0MonsterBp);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEmotionBubbleMonsterConfigByBp.LogPair.Clear();
			ConfigEmotionBubbleMonsterConfigByBp.LogPair.Add(new ValueTuple<string, object>("MonsterBp", p0MonsterBp));
			if (!ConfigCommon.BindString(ConfigEmotionBubbleMonsterConfigByBp.HandleId, 1, p0MonsterBp, ConfigEmotionBubbleMonsterConfigByBp.LogPair))
			{
				ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigByBp.HandleId, ConfigEmotionBubbleMonsterConfigByBp.LogPair);
				return null;
			}
			List<EmotionBubbleMonsterConfig> list = new List<EmotionBubbleMonsterConfig>();
			while (ConfigCommon.Step(ConfigEmotionBubbleMonsterConfigByBp.HandleId, false, ConfigEmotionBubbleMonsterConfigByBp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleMonsterConfigByBp.HandleId, 0, ConfigEmotionBubbleMonsterConfigByBp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigByBp.HandleId, ConfigEmotionBubbleMonsterConfigByBp.LogPair);
					return null;
				}
				EmotionBubbleMonsterConfig rootAsEmotionBubbleMonsterConfig = EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(new ByteBuffer(item2));
				list.Add(rootAsEmotionBubbleMonsterConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EmotionBubbleMonsterConfigByBp#" + p0MonsterBp, list, list.Count);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigByBp.HandleId, ConfigEmotionBubbleMonsterConfigByBp.LogPair);
			return list;
		}

		// Token: 0x0400115D RID: 4445
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x0400115E RID: 4446
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x0400115F RID: 4447
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x04001160 RID: 4448
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig` where MonsterBp=?";

		// Token: 0x04001161 RID: 4449
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigByBp";

		// Token: 0x04001162 RID: 4450
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001163 RID: 4451
		private static int HandleId;
	}
}
