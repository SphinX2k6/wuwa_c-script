using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B0 RID: 944
	public class ConfigGuessJokerAiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x000D6CCB File Offset: 0x000D4ECB
		static ConfigGuessJokerAiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000D6CEC File Offset: 0x000D4EEC
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

		// Token: 0x06001629 RID: 5673 RVA: 0x000D6D6B File Offset: 0x000D4F6B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigById.LogPair = null;
			ConfigGuessJokerAiConfigById.HandleId = 0;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000D6D79 File Offset: 0x000D4F79
		public static void Init()
		{
			ConfigGuessJokerAiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig` where RoleId=?");
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000D6D94 File Offset: 0x000D4F94
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

		// Token: 0x040019B4 RID: 6580
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019B5 RID: 6581
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019B6 RID: 6582
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x040019B7 RID: 6583
		private const string COMMAND = "select BinData from `GuessJokerAiConfig` where RoleId=?";

		// Token: 0x040019B8 RID: 6584
		private const string KEY_PREFIX = "GuessJokerAiConfigById";

		// Token: 0x040019B9 RID: 6585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019BA RID: 6586
		private static int HandleId;
	}
}
