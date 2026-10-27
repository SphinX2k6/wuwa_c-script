using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000269 RID: 617
	public class ConfigEmotionBubbleConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x000AB2A7 File Offset: 0x000A94A7
		static ConfigEmotionBubbleConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleConfigByName.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000AB2C8 File Offset: 0x000A94C8
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

		// Token: 0x06000E7C RID: 3708 RVA: 0x000AB347 File Offset: 0x000A9547
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleConfigByName.LogPair = null;
			ConfigEmotionBubbleConfigByName.HandleId = 0;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000AB355 File Offset: 0x000A9555
		public static void Init()
		{
			ConfigEmotionBubbleConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleConfigByName.HandleId, "db_emotionbubbleconfig.db", "select BinData from `EmotionBubbleConfig` where EmotionName=?");
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000AB370 File Offset: 0x000A9570
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

		// Token: 0x040010C3 RID: 4291
		private const string DB = "db_emotionbubbleconfig.db";

		// Token: 0x040010C4 RID: 4292
		private const string FILE = "k.可视化编辑/c.Csv/b.表情气泡/*.csv*";

		// Token: 0x040010C5 RID: 4293
		private const string TABLE = "EmotionBubbleConfig";

		// Token: 0x040010C6 RID: 4294
		private const string COMMAND = "select BinData from `EmotionBubbleConfig` where EmotionName=?";

		// Token: 0x040010C7 RID: 4295
		private const string KEY_PREFIX = "EmotionBubbleConfigByName";

		// Token: 0x040010C8 RID: 4296
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010C9 RID: 4297
		private static int HandleId;
	}
}
