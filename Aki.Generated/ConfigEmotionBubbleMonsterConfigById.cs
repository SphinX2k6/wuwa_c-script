using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000280 RID: 640
	public class ConfigEmotionBubbleMonsterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F04 RID: 3844 RVA: 0x000B1ADD File Offset: 0x000AFCDD
		static ConfigEmotionBubbleMonsterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEmotionBubbleMonsterConfigById.CreateStaticDefaultValue), new Action(ConfigEmotionBubbleMonsterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000B1AFC File Offset: 0x000AFCFC
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

		// Token: 0x06000F06 RID: 3846 RVA: 0x000B1B7B File Offset: 0x000AFD7B
		public static void ResetStaticDefaultValue()
		{
			ConfigEmotionBubbleMonsterConfigById.LogPair = null;
			ConfigEmotionBubbleMonsterConfigById.HandleId = 0;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000B1B89 File Offset: 0x000AFD89
		public static void Init()
		{
			ConfigEmotionBubbleMonsterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEmotionBubbleMonsterConfigById.HandleId, "db_emotionbubblemonsterconfig.db", "select BinData from `EmotionBubbleMonsterConfig` where Id=?");
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000B1BA4 File Offset: 0x000AFDA4
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

		// Token: 0x04001164 RID: 4452
		private const string DB = "db_emotionbubblemonsterconfig.db";

		// Token: 0x04001165 RID: 4453
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物表情气泡映射/*.csv*";

		// Token: 0x04001166 RID: 4454
		private const string TABLE = "EmotionBubbleMonsterConfig";

		// Token: 0x04001167 RID: 4455
		private const string COMMAND = "select BinData from `EmotionBubbleMonsterConfig` where Id=?";

		// Token: 0x04001168 RID: 4456
		private const string KEY_PREFIX = "EmotionBubbleMonsterConfigById";

		// Token: 0x04001169 RID: 4457
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400116A RID: 4458
		private static int HandleId;
	}
}
