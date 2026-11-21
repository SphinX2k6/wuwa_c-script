using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CB RID: 1227
	public class ConfigKurotatoScoreAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x000FF98B File Offset: 0x000FDB8B
		static ConfigKurotatoScoreAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoScoreAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoScoreAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000FF9AC File Offset: 0x000FDBAC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoScoreAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoScoreAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoScoreAward` where Id=?")
			});
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000FFA2B File Offset: 0x000FDC2B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardById.LogPair = null;
			ConfigKurotatoScoreAwardById.HandleId = 0;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000FFA39 File Offset: 0x000FDC39
		public static void Init()
		{
			ConfigKurotatoScoreAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoScoreAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoScoreAward` where Id=?");
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000FFA54 File Offset: 0x000FDC54
		public static KurotatoScoreAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoScoreAwardById.HandleId, ConfigKurotatoScoreAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoScoreAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoScoreAward?(KurotatoScoreAward.GetRootAsKurotatoScoreAward(configBuffer));
				}
			}
			ConfigKurotatoScoreAwardById.LogPair.Clear();
			ConfigKurotatoScoreAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoScoreAwardById.HandleId, 1, p0Id, ConfigKurotatoScoreAwardById.LogPair) || ConfigCommon.Step(ConfigKurotatoScoreAwardById.HandleId, true, ConfigKurotatoScoreAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoScoreAwardById.HandleId, ConfigKurotatoScoreAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoScoreAwardById.HandleId, 0, ConfigKurotatoScoreAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoScoreAwardById.HandleId, ConfigKurotatoScoreAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoScoreAward rootAsKurotatoScoreAward = KurotatoScoreAward.GetRootAsKurotatoScoreAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoScoreAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoScoreAwardById.HandleId, ConfigKurotatoScoreAwardById.LogPair);
			return new KurotatoScoreAward?(rootAsKurotatoScoreAward);
		}

		// Token: 0x04002171 RID: 8561
		private const string DB = "db_kurotato.db";

		// Token: 0x04002172 RID: 8562
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002173 RID: 8563
		private const string TABLE = "KurotatoScoreAward";

		// Token: 0x04002174 RID: 8564
		private const string COMMAND = "select BinData from `KurotatoScoreAward` where Id=?";

		// Token: 0x04002175 RID: 8565
		private const string KEY_PREFIX = "KurotatoScoreAwardById";

		// Token: 0x04002176 RID: 8566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002177 RID: 8567
		private static int HandleId;
	}
}
