using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CB RID: 971
	public class ConfigGuessJokerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016C9 RID: 5833 RVA: 0x000DDE1F File Offset: 0x000DC01F
		static ConfigGuessJokerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerLevelById.CreateStaticDefaultValue), new Action(ConfigGuessJokerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000DDE40 File Offset: 0x000DC040
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerLevel` where Id=?")
			});
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000DDEBF File Offset: 0x000DC0BF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerLevelById.LogPair = null;
			ConfigGuessJokerLevelById.HandleId = 0;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000DDECD File Offset: 0x000DC0CD
		public static void Init()
		{
			ConfigGuessJokerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerLevelById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerLevel` where Id=?");
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000DDEE8 File Offset: 0x000DC0E8
		public static GuessJokerLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerLevelById.HandleId, ConfigGuessJokerLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerLevel?(GuessJokerLevel.GetRootAsGuessJokerLevel(configBuffer));
				}
			}
			ConfigGuessJokerLevelById.LogPair.Clear();
			ConfigGuessJokerLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuessJokerLevelById.HandleId, 1, p0Id, ConfigGuessJokerLevelById.LogPair) || ConfigCommon.Step(ConfigGuessJokerLevelById.HandleId, true, ConfigGuessJokerLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerLevelById.HandleId, ConfigGuessJokerLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerLevelById.HandleId, 0, ConfigGuessJokerLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerLevelById.HandleId, ConfigGuessJokerLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerLevel rootAsGuessJokerLevel = GuessJokerLevel.GetRootAsGuessJokerLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerLevelById.HandleId, ConfigGuessJokerLevelById.LogPair);
			return new GuessJokerLevel?(rootAsGuessJokerLevel);
		}

		// Token: 0x04001A71 RID: 6769
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A72 RID: 6770
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A73 RID: 6771
		private const string TABLE = "GuessJokerLevel";

		// Token: 0x04001A74 RID: 6772
		private const string COMMAND = "select BinData from `GuessJokerLevel` where Id=?";

		// Token: 0x04001A75 RID: 6773
		private const string KEY_PREFIX = "GuessJokerLevelById";

		// Token: 0x04001A76 RID: 6774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A77 RID: 6775
		private static int HandleId;
	}
}
