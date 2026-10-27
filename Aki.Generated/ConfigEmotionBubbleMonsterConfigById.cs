using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026C RID: 620
	public class ConfigEmotionBubbleMonsterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x000AB819 File Offset: 0x000A9A19
		static ConfigEmotionBubbleMonsterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigById.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000AB838 File Offset: 0x000A9A38
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleMonsterConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubblemonsterconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleMonsterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleMonsterConfig` where Id=?")
			});
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000AB8B7 File Offset: 0x000A9AB7
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigById.LogPair = null;
			ConfigEmotionBubbleMonsterConfigById.HandleId = 0;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000AB8C5 File Offset: 0x000A9AC5
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigById.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig` where Id=?");
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000AB8E0 File Offset: 0x000A9AE0
		public static EmotionBubbleMonsterConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleMonsterConfigById.HandleId, ConfigEmotionBubbleMonsterConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EmotionBubbleMonsterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EmotionBubbleMonsterConfig?(EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(configBuffer));
				}
			}
			ConfigEmotionBubbleMonsterConfigById.LogPair.Clear();
			ConfigEmotionBubbleMonsterConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEmotionBubbleMonsterConfigById.HandleId, 1, p0Id, ConfigEmotionBubbleMonsterConfigById.LogPair) || ConfigCommon.Step(ConfigEmotionBubbleMonsterConfigById.HandleId, true, ConfigEmotionBubbleMonsterConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigById.HandleId, ConfigEmotionBubbleMonsterConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleMonsterConfigById.HandleId, 0, ConfigEmotionBubbleMonsterConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigById.HandleId, ConfigEmotionBubbleMonsterConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EmotionBubbleMonsterConfig rootAsEmotionBubbleMonsterConfig = EmotionBubbleMonsterConfig.GetRootAsEmotionBubbleMonsterConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EmotionBubbleMonsterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleMonsterConfigById.HandleId, ConfigEmotionBubbleMonsterConfigById.LogPair);
			return new EmotionBubbleMonsterConfig?(rootAsEmotionBubbleMonsterConfig);
		}

		// Token: 0x040010D8 RID: 4312
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x040010D9 RID: 4313
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x040010DA RID: 4314
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x040010DB RID: 4315
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig` where Id=?";

		// Token: 0x040010DC RID: 4316
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigById";

		// Token: 0x040010DD RID: 4317
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010DE RID: 4318
		private static int HandleId;
	}
}
