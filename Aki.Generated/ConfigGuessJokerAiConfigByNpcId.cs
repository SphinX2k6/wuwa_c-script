using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C7 RID: 967
	public class ConfigGuessJokerAiConfigByNpcId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016B1 RID: 5809 RVA: 0x000DD668 File Offset: 0x000DB868
		static ConfigGuessJokerAiConfigByNpcId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigByNpcId.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigByNpcId.ResetStaticDefaultValue));
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000DD688 File Offset: 0x000DB888
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigByNpcId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAiConfigByNpcId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAiConfig` where NpcId=?")
			});
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000DD707 File Offset: 0x000DB907
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigByNpcId.LogPair = null;
			ConfigGuessJokerAiConfigByNpcId.HandleId = 0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000DD715 File Offset: 0x000DB915
		public static void Init()
		{
			ConfigGuessJokerAiConfigByNpcId.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigByNpcId.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig` where NpcId=?");
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000DD730 File Offset: 0x000DB930
		public static GuessJokerAiConfig? GetConfig(int p0NpcId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigByNpcId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NpcId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerAiConfig?(GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(configBuffer));
				}
			}
			ConfigGuessJokerAiConfigByNpcId.LogPair.Clear();
			ConfigGuessJokerAiConfigByNpcId.LogPair.Add(new ValueTuple<string, object>("NpcId", p0NpcId));
			if (!ConfigCommon.BindInt(ConfigGuessJokerAiConfigByNpcId.HandleId, 1, p0NpcId, ConfigGuessJokerAiConfigByNpcId.LogPair) || ConfigCommon.Step(ConfigGuessJokerAiConfigByNpcId.HandleId, true, ConfigGuessJokerAiConfigByNpcId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAiConfigByNpcId.HandleId, 0, ConfigGuessJokerAiConfigByNpcId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerAiConfig rootAsGuessJokerAiConfig = GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigByNpcId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NpcId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
			return new GuessJokerAiConfig?(rootAsGuessJokerAiConfig);
		}

		// Token: 0x04001A55 RID: 6741
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A56 RID: 6742
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A57 RID: 6743
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x04001A58 RID: 6744
		private const string COMMAND = "select BinData from `GuessJokerAiConfig` where NpcId=?";

		// Token: 0x04001A59 RID: 6745
		private const string KEY_PREFIX = "GuessJokerAiConfigByNpcId";

		// Token: 0x04001A5A RID: 6746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A5B RID: 6747
		private static int HandleId;
	}
}
