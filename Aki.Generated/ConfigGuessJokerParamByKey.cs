using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B6 RID: 950
	public class ConfigGuessJokerParamByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x000D7914 File Offset: 0x000D5B14
		static ConfigGuessJokerParamByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerParamByKey.CreateStaticDefaultValue), new Action(ConfigGuessJokerParamByKey.ResetStaticDefaultValue));
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000D7934 File Offset: 0x000D5B34
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

		// Token: 0x0600164D RID: 5709 RVA: 0x000D79B3 File Offset: 0x000D5BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerParamByKey.LogPair = null;
			ConfigGuessJokerParamByKey.HandleId = 0;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000D79C1 File Offset: 0x000D5BC1
		public static void Init()
		{
			ConfigGuessJokerParamByKey.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerParamByKey.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerParam` where Key=?");
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000D79DC File Offset: 0x000D5BDC
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

		// Token: 0x040019DE RID: 6622
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019DF RID: 6623
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019E0 RID: 6624
		private const string TABLE = "GuessJokerParam";

		// Token: 0x040019E1 RID: 6625
		private const string COMMAND = "select BinData from `GuessJokerParam` where Key=?";

		// Token: 0x040019E2 RID: 6626
		private const string KEY_PREFIX = "GuessJokerParamByKey";

		// Token: 0x040019E3 RID: 6627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019E4 RID: 6628
		private static int HandleId;
	}
}
