using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027E RID: 638
	public class ConfigEmotionBubbleMonsterConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x000B1765 File Offset: 0x000AF965
		static ConfigEmotionBubbleMonsterConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigAll.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000B1784 File Offset: 0x000AF984
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

		// Token: 0x06000EFA RID: 3834 RVA: 0x000B1803 File Offset: 0x000AFA03
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigAll.LogPair = null;
			ConfigEmotionBubbleMonsterConfigAll.HandleId = 0;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000B1811 File Offset: 0x000AFA11
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigAll.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig`");
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000B182C File Offset: 0x000AFA2C
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

		// Token: 0x04001156 RID: 4438
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x04001157 RID: 4439
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x04001158 RID: 4440
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x04001159 RID: 4441
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig`";

		// Token: 0x0400115A RID: 4442
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigAll";

		// Token: 0x0400115B RID: 4443
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400115C RID: 4444
		private static int HandleId;
	}
}
