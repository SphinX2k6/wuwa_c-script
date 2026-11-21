using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C6 RID: 966
	public class ConfigGuessJokerAiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016AB RID: 5803 RVA: 0x000DD41F File Offset: 0x000DB61F
		static ConfigGuessJokerAiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000DD440 File Offset: 0x000DB640
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAiConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAiConfig` where RoleId=?")
			});
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000DD4BF File Offset: 0x000DB6BF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigById.LogPair = null;
			ConfigGuessJokerAiConfigById.HandleId = 0;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000DD4CD File Offset: 0x000DB6CD
		public static void Init()
		{
			ConfigGuessJokerAiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig` where RoleId=?");
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000DD4E8 File Offset: 0x000DB6E8
		public static GuessJokerAiConfig? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAiConfigById.HandleId, ConfigGuessJokerAiConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerAiConfig?(GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(configBuffer));
				}
			}
			ConfigGuessJokerAiConfigById.LogPair.Clear();
			ConfigGuessJokerAiConfigById.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigGuessJokerAiConfigById.HandleId, 1, p0RoleId, ConfigGuessJokerAiConfigById.LogPair) || ConfigCommon.Step(ConfigGuessJokerAiConfigById.HandleId, true, ConfigGuessJokerAiConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigById.HandleId, ConfigGuessJokerAiConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAiConfigById.HandleId, 0, ConfigGuessJokerAiConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigById.HandleId, ConfigGuessJokerAiConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerAiConfig rootAsGuessJokerAiConfig = GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerAiConfigById.HandleId, ConfigGuessJokerAiConfigById.LogPair);
			return new GuessJokerAiConfig?(rootAsGuessJokerAiConfig);
		}

		// Token: 0x04001A4E RID: 6734
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A4F RID: 6735
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A50 RID: 6736
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x04001A51 RID: 6737
		private const string COMMAND = "select BinData from `GuessJokerAiConfig` where RoleId=?";

		// Token: 0x04001A52 RID: 6738
		private const string KEY_PREFIX = "GuessJokerAiConfigById";

		// Token: 0x04001A53 RID: 6739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A54 RID: 6740
		private static int HandleId;
	}
}
