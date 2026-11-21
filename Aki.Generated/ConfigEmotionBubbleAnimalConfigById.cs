using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027B RID: 635
	public class ConfigEmotionBubbleAnimalConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EE6 RID: 3814 RVA: 0x000B1191 File Offset: 0x000AF391
		static ConfigEmotionBubbleAnimalConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigById.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000B11B0 File Offset: 0x000AF3B0
		public static void CreateStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEmotionBubbleAnimalConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_emotionbubbleanimalconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*"),
				new ValueTuple<string, object>("表名", "EmotionBubbleAnimalConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EmotionBubbleAnimalConfig` where Id=?")
			});
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000B122F File Offset: 0x000AF42F
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigById.LogPair = null;
			ConfigEmotionBubbleAnimalConfigById.HandleId = 0;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000B123D File Offset: 0x000AF43D
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigById.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig` where Id=?");
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000B1258 File Offset: 0x000AF458
		public static EmotionBubbleAnimalConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEmotionBubbleAnimalConfigById.HandleId, ConfigEmotionBubbleAnimalConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EmotionBubbleAnimalConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EmotionBubbleAnimalConfig?(EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(configBuffer));
				}
			}
			ConfigEmotionBubbleAnimalConfigById.LogPair.Clear();
			ConfigEmotionBubbleAnimalConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEmotionBubbleAnimalConfigById.HandleId, 1, p0Id, ConfigEmotionBubbleAnimalConfigById.LogPair) || ConfigCommon.Step(ConfigEmotionBubbleAnimalConfigById.HandleId, true, ConfigEmotionBubbleAnimalConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigById.HandleId, ConfigEmotionBubbleAnimalConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEmotionBubbleAnimalConfigById.HandleId, 0, ConfigEmotionBubbleAnimalConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigById.HandleId, ConfigEmotionBubbleAnimalConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EmotionBubbleAnimalConfig rootAsEmotionBubbleAnimalConfig = EmotionBubbleAnimalConfig.GetRootAsEmotionBubbleAnimalConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EmotionBubbleAnimalConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEmotionBubbleAnimalConfigById.HandleId, ConfigEmotionBubbleAnimalConfigById.LogPair);
			return new EmotionBubbleAnimalConfig?(rootAsEmotionBubbleAnimalConfig);
		}

		// Token: 0x04001141 RID: 4417
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x04001142 RID: 4418
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x04001143 RID: 4419
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x04001144 RID: 4420
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig` where Id=?";

		// Token: 0x04001145 RID: 4421
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigById";

		// Token: 0x04001146 RID: 4422
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001147 RID: 4423
		private static int HandleId;
	}
}
