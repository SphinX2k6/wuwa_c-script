using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D7 RID: 471
	public class ConfigDangoBrawlChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x0009BA40 File Offset: 0x00099C40
		static ConfigDangoBrawlChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlChallengeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0009BA60 File Offset: 0x00099C60
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

		// Token: 0x06000B0F RID: 2831 RVA: 0x0009BADF File Offset: 0x00099CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlChallengeById.LogPair = null;
			ConfigDangoBrawlChallengeById.HandleId = 0;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0009BAED File Offset: 0x00099CED
		public static void Init()
		{
			ConfigDangoBrawlChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlChallengeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlChallenge` where Id=?");
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0009BB08 File Offset: 0x00099D08
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

		// Token: 0x04000CC5 RID: 3269
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CC6 RID: 3270
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CC7 RID: 3271
		private const string TABLE = "DangoBrawlChallenge";

		// Token: 0x04000CC8 RID: 3272
		private const string COMMAND = "select BinData from `DangoBrawlChallenge` where Id=?";

		// Token: 0x04000CC9 RID: 3273
		private const string KEY_PREFIX = "DangoBrawlChallengeById";

		// Token: 0x04000CCA RID: 3274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CCB RID: 3275
		private static int HandleId;
	}
}
