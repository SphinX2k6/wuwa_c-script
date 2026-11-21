using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047B RID: 1147
	public class ConfigJokerDeckById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x000F51CF File Offset: 0x000F33CF
		static ConfigJokerDeckById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerDeckById.CreateStaticDefaultValue), new Action(ConfigJokerDeckById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x000F51F0 File Offset: 0x000F33F0
		public static void CreateStaticDefaultValue()
		{
			ConfigJokerDeckById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigJokerDeckById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "JokerDeck"),
				new ValueTuple<string, object>("语句", "select BinData from `JokerDeck` where Id=?")
			});
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000F526F File Offset: 0x000F346F
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerDeckById.LogPair = null;
			ConfigJokerDeckById.HandleId = 0;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000F527D File Offset: 0x000F347D
		public static void Init()
		{
			ConfigJokerDeckById.HandleId = ConfigCommon.InitDataStatement(ConfigJokerDeckById.HandleId, "db_guessjokercard.db", "select BinData from `JokerDeck` where Id=?");
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000F5298 File Offset: 0x000F3498
		public static JokerDeck? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigJokerDeckById.HandleId, ConfigJokerDeckById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("JokerDeckById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new JokerDeck?(JokerDeck.GetRootAsJokerDeck(configBuffer));
				}
			}
			ConfigJokerDeckById.LogPair.Clear();
			ConfigJokerDeckById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigJokerDeckById.HandleId, 1, p0Id, ConfigJokerDeckById.LogPair) || ConfigCommon.Step(ConfigJokerDeckById.HandleId, true, ConfigJokerDeckById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigJokerDeckById.HandleId, ConfigJokerDeckById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigJokerDeckById.HandleId, 0, ConfigJokerDeckById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigJokerDeckById.HandleId, ConfigJokerDeckById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			JokerDeck rootAsJokerDeck = JokerDeck.GetRootAsJokerDeck(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("JokerDeckById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigJokerDeckById.HandleId, ConfigJokerDeckById.LogPair);
			return new JokerDeck?(rootAsJokerDeck);
		}

		// Token: 0x04001F41 RID: 8001
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001F42 RID: 8002
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001F43 RID: 8003
		private const string TABLE = "JokerDeck";

		// Token: 0x04001F44 RID: 8004
		private const string COMMAND = "select BinData from `JokerDeck` where Id=?";

		// Token: 0x04001F45 RID: 8005
		private const string KEY_PREFIX = "JokerDeckById";

		// Token: 0x04001F46 RID: 8006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F47 RID: 8007
		private static int HandleId;
	}
}
