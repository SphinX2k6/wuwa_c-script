using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000267 RID: 615
	public class ConfigEmotionBubbleAnimalConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E6E RID: 3694 RVA: 0x000AAECD File Offset: 0x000A90CD
		static ConfigEmotionBubbleAnimalConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleAnimalConfigById.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleAnimalConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000AAEEC File Offset: 0x000A90EC
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

		// Token: 0x06000E70 RID: 3696 RVA: 0x000AAF6B File Offset: 0x000A916B
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleAnimalConfigById.LogPair = null;
			ConfigEmotionBubbleAnimalConfigById.HandleId = 0;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000AAF79 File Offset: 0x000A9179
		public static void Init()
		{
			ConfigEmotionBubbleAnimalConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleAnimalConfigById.HandleId, "db_emotionbubbleanimalconfig.db", "select BinData from `EmotionBubbleAnimalConfig` where Id=?");
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000AAF94 File Offset: 0x000A9194
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

		// Token: 0x040010B5 RID: 4277
		private const string DB = "db_emotionbubbleanimalconfig.db";

		// Token: 0x040010B6 RID: 4278
		private const string FILE = "k.可视化编辑/c.Csv/d.动物表情气泡映射/*.csv*";

		// Token: 0x040010B7 RID: 4279
		private const string TABLE = "EmotionBubbleAnimalConfig";

		// Token: 0x040010B8 RID: 4280
		private const string COMMAND = "select BinData from `EmotionBubbleAnimalConfig` where Id=?";

		// Token: 0x040010B9 RID: 4281
		private const string KEY_PREFIX = "EmotionBubbleAnimalConfigById";

		// Token: 0x040010BA RID: 4282
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010BB RID: 4283
		private static int HandleId;
	}
}
