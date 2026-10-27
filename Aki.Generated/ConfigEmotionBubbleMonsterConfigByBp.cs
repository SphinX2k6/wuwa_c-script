using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026B RID: 619
	public class ConfigEmotionBubbleMonsterConfigByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E86 RID: 3718 RVA: 0x000AB633 File Offset: 0x000A9833
		static ConfigEmotionBubbleMonsterConfigByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigByBp.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigByBp.ResetStaticDefaultValue));
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000AB654 File Offset: 0x000A9854
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

		// Token: 0x06000E88 RID: 3720 RVA: 0x000AB6D3 File Offset: 0x000A98D3
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigByBp.LogPair = null;
			ConfigEmotionBubbleMonsterConfigByBp.HandleId = 0;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000AB6E1 File Offset: 0x000A98E1
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigByBp.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigByBp.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig` where MonsterBp=?");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000AB6FC File Offset: 0x000A98FC
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

		// Token: 0x040010D1 RID: 4305
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x040010D2 RID: 4306
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x040010D3 RID: 4307
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x040010D4 RID: 4308
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig` where MonsterBp=?";

		// Token: 0x040010D5 RID: 4309
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigByBp";

		// Token: 0x040010D6 RID: 4310
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010D7 RID: 4311
		private static int HandleId;
	}
}
