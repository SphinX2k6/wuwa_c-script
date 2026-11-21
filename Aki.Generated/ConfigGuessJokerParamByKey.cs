using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CC RID: 972
	public class ConfigGuessJokerParamByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x000DE068 File Offset: 0x000DC268
		static ConfigGuessJokerParamByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerParamByKey.CreateStaticDefaultValue), new Action(ConfigGuessJokerParamByKey.ResetStaticDefaultValue));
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x000DE088 File Offset: 0x000DC288
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerParamByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerParamByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerParam"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerParam` where Key=?")
			});
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000DE107 File Offset: 0x000DC307
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerParamByKey.LogPair = null;
			ConfigGuessJokerParamByKey.HandleId = 0;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000DE115 File Offset: 0x000DC315
		public static void Init()
		{
			ConfigGuessJokerParamByKey.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerParamByKey.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerParam` where Key=?");
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000DE130 File Offset: 0x000DC330
		public static GuessJokerParam? GetConfig(string p0Key, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerParamByKey.HandleId, ConfigGuessJokerParamByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GuessJokerParamByKey#" + p0Key);
				if (configBuffer != null)
				{
					return new GuessJokerParam?(GuessJokerParam.GetRootAsGuessJokerParam(configBuffer));
				}
			}
			ConfigGuessJokerParamByKey.LogPair.Clear();
			ConfigGuessJokerParamByKey.LogPair.Add(new ValueTuple<string, object>("Key", p0Key));
			if (!ConfigCommon.BindString(ConfigGuessJokerParamByKey.HandleId, 1, p0Key, ConfigGuessJokerParamByKey.LogPair) || ConfigCommon.Step(ConfigGuessJokerParamByKey.HandleId, true, ConfigGuessJokerParamByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerParamByKey.HandleId, ConfigGuessJokerParamByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerParamByKey.HandleId, 0, ConfigGuessJokerParamByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerParamByKey.HandleId, ConfigGuessJokerParamByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerParam rootAsGuessJokerParam = GuessJokerParam.GetRootAsGuessJokerParam(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GuessJokerParamByKey#" + p0Key, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerParamByKey.HandleId, ConfigGuessJokerParamByKey.LogPair);
			return new GuessJokerParam?(rootAsGuessJokerParam);
		}

		// Token: 0x04001A78 RID: 6776
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A79 RID: 6777
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A7A RID: 6778
		private const string TABLE = "GuessJokerParam";

		// Token: 0x04001A7B RID: 6779
		private const string COMMAND = "select BinData from `GuessJokerParam` where Key=?";

		// Token: 0x04001A7C RID: 6780
		private const string KEY_PREFIX = "GuessJokerParamByKey";

		// Token: 0x04001A7D RID: 6781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A7E RID: 6782
		private static int HandleId;
	}
}
