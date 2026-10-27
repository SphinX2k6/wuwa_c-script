using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C5 RID: 453
	public class ConfigDangoBrawlChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x00095B08 File Offset: 0x00093D08
		static ConfigDangoBrawlChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlChallengeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00095B28 File Offset: 0x00093D28
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlChallenge` where Id=?")
			});
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00095BA7 File Offset: 0x00093DA7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlChallengeById.LogPair = null;
			ConfigDangoBrawlChallengeById.HandleId = 0;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00095BB5 File Offset: 0x00093DB5
		public static void Init()
		{
			ConfigDangoBrawlChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlChallengeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlChallenge` where Id=?");
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00095BD0 File Offset: 0x00093DD0
		public static DangoBrawlChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlChallengeById.HandleId, ConfigDangoBrawlChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlChallenge?(DangoBrawlChallenge.GetRootAsDangoBrawlChallenge(configBuffer));
				}
			}
			ConfigDangoBrawlChallengeById.LogPair.Clear();
			ConfigDangoBrawlChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlChallengeById.HandleId, 1, p0Id, ConfigDangoBrawlChallengeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlChallengeById.HandleId, true, ConfigDangoBrawlChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlChallengeById.HandleId, ConfigDangoBrawlChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlChallengeById.HandleId, 0, ConfigDangoBrawlChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlChallengeById.HandleId, ConfigDangoBrawlChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlChallenge rootAsDangoBrawlChallenge = DangoBrawlChallenge.GetRootAsDangoBrawlChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlChallengeById.HandleId, ConfigDangoBrawlChallengeById.LogPair);
			return new DangoBrawlChallenge?(rootAsDangoBrawlChallenge);
		}

		// Token: 0x04000C47 RID: 3143
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C48 RID: 3144
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C49 RID: 3145
		private const string TABLE = "DangoBrawlChallenge";

		// Token: 0x04000C4A RID: 3146
		private const string COMMAND = "select BinData from `DangoBrawlChallenge` where Id=?";

		// Token: 0x04000C4B RID: 3147
		private const string KEY_PREFIX = "DangoBrawlChallengeById";

		// Token: 0x04000C4C RID: 3148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C4D RID: 3149
		private static int HandleId;
	}
}
