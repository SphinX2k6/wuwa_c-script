using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B5 RID: 1205
	public class ConfigKurotatoScoreAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x000F9237 File Offset: 0x000F7437
		static ConfigKurotatoScoreAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoScoreAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoScoreAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000F9258 File Offset: 0x000F7458
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

		// Token: 0x06001C4B RID: 7243 RVA: 0x000F92D7 File Offset: 0x000F74D7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardById.LogPair = null;
			ConfigKurotatoScoreAwardById.HandleId = 0;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000F92E5 File Offset: 0x000F74E5
		public static void Init()
		{
			ConfigKurotatoScoreAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoScoreAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoScoreAward` where Id=?");
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000F9300 File Offset: 0x000F7500
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

		// Token: 0x040020D7 RID: 8407
		private const string DB = "db_kurotato.db";

		// Token: 0x040020D8 RID: 8408
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020D9 RID: 8409
		private const string TABLE = "KurotatoScoreAward";

		// Token: 0x040020DA RID: 8410
		private const string COMMAND = "select BinData from `KurotatoScoreAward` where Id=?";

		// Token: 0x040020DB RID: 8411
		private const string KEY_PREFIX = "KurotatoScoreAwardById";

		// Token: 0x040020DC RID: 8412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020DD RID: 8413
		private static int HandleId;
	}
}
