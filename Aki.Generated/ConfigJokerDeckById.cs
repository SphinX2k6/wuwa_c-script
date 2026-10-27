using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000465 RID: 1125
	public class ConfigJokerDeckById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x000EEA7B File Offset: 0x000ECC7B
		static ConfigJokerDeckById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerDeckById.CreateStaticDefaultValue), new Action(ConfigJokerDeckById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x000EEA9C File Offset: 0x000ECC9C
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

		// Token: 0x06001A6A RID: 6762 RVA: 0x000EEB1B File Offset: 0x000ECD1B
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerDeckById.LogPair = null;
			ConfigJokerDeckById.HandleId = 0;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000EEB29 File Offset: 0x000ECD29
		public static void Init()
		{
			ConfigJokerDeckById.HandleId = ConfigCommon.InitDataStatement(ConfigJokerDeckById.HandleId, "db_guessjokercard.db", "select BinData from `JokerDeck` where Id=?");
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000EEB44 File Offset: 0x000ECD44
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

		// Token: 0x04001EA7 RID: 7847
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001EA8 RID: 7848
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001EA9 RID: 7849
		private const string TABLE = "JokerDeck";

		// Token: 0x04001EAA RID: 7850
		private const string COMMAND = "select BinData from `JokerDeck` where Id=?";

		// Token: 0x04001EAB RID: 7851
		private const string KEY_PREFIX = "JokerDeckById";

		// Token: 0x04001EAC RID: 7852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EAD RID: 7853
		private static int HandleId;
	}
}
