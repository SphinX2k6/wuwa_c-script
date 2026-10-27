using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B5 RID: 949
	public class ConfigGuessJokerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001645 RID: 5701 RVA: 0x000D76CB File Offset: 0x000D58CB
		static ConfigGuessJokerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerLevelById.CreateStaticDefaultValue), new Action(ConfigGuessJokerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000D76EC File Offset: 0x000D58EC
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

		// Token: 0x06001647 RID: 5703 RVA: 0x000D776B File Offset: 0x000D596B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerLevelById.LogPair = null;
			ConfigGuessJokerLevelById.HandleId = 0;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000D7779 File Offset: 0x000D5979
		public static void Init()
		{
			ConfigGuessJokerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerLevelById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerLevel` where Id=?");
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000D7794 File Offset: 0x000D5994
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

		// Token: 0x040019D7 RID: 6615
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019D8 RID: 6616
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019D9 RID: 6617
		private const string TABLE = "GuessJokerLevel";

		// Token: 0x040019DA RID: 6618
		private const string COMMAND = "select BinData from `GuessJokerLevel` where Id=?";

		// Token: 0x040019DB RID: 6619
		private const string KEY_PREFIX = "GuessJokerLevelById";

		// Token: 0x040019DC RID: 6620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019DD RID: 6621
		private static int HandleId;
	}
}
