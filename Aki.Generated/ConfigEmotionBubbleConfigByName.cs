using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027D RID: 637
	public class ConfigEmotionBubbleConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x000B156B File Offset: 0x000AF76B
		static ConfigEmotionBubbleConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleConfigByName.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000B158C File Offset: 0x000AF78C
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleConfigByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubbleconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/b.表情气泡/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleConfig` where EmotionName=?")
			});
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000B160B File Offset: 0x000AF80B
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigByName.LogPair = null;
			ConfigEmotionBubbleConfigByName.HandleId = 0;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000B1619 File Offset: 0x000AF819
		public static void Init()
		{
			ConfigEmotionBubbleConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleConfigByName.HandleId, "db_emotionbubbleconfig.db", "select BinData from `EmotionBubbleConfig` where EmotionName=?");
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000B1634 File Offset: 0x000AF834
		public static EmotionBubbleConfig? GetConfig(string p0EmotionName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleConfigByName.HandleId, ConfigEmotionBubbleConfigByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EmotionBubbleConfigByName#" + p0EmotionName);
				if (configBuffer != null)
				{
					return new EmotionBubbleConfig?(EmotionBubbleConfig.GetRootAsEmotionBubbleConfig(configBuffer));
				}
			}
			ConfigEmotionBubbleConfigByName.LogPair.Clear();
			ConfigEmotionBubbleConfigByName.LogPair.Add(new ValueTuple<string, object>("EmotionName", p0EmotionName));
			if (!ConfigCommon.BindString(ConfigEmotionBubbleConfigByName.HandleId, 1, p0EmotionName, ConfigEmotionBubbleConfigByName.LogPair) || ConfigCommon.Step(ConfigEmotionBubbleConfigByName.HandleId, true, ConfigEmotionBubbleConfigByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleConfigByName.HandleId, ConfigEmotionBubbleConfigByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleConfigByName.HandleId, 0, ConfigEmotionBubbleConfigByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleConfigByName.HandleId, ConfigEmotionBubbleConfigByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EmotionBubbleConfig rootAsEmotionBubbleConfig = EmotionBubbleConfig.GetRootAsEmotionBubbleConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EmotionBubbleConfigByName#" + p0EmotionName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleConfigByName.HandleId, ConfigEmotionBubbleConfigByName.LogPair);
			return new EmotionBubbleConfig?(rootAsEmotionBubbleConfig);
		}

		// Token: 0x0400114F RID: 4431
		private const string DB = "db_emotionbubbleconfig.db";

		// Token: 0x04001150 RID: 4432
		private const string FILE = "k.可视化编辑/c.Csv/b.表情气泡/*.csv*";

		// Token: 0x04001151 RID: 4433
		private const string TABLE = "EmotionBubbleConfig";

		// Token: 0x04001152 RID: 4434
		private const string COMMAND = "select BinData from `EmotionBubbleConfig` where EmotionName=?";

		// Token: 0x04001153 RID: 4435
		private const string KEY_PREFIX = "EmotionBubbleConfigByName";

		// Token: 0x04001154 RID: 4436
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001155 RID: 4437
		private static int HandleId;
	}
}
