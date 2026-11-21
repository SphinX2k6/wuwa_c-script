using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AC RID: 2476
	public class ConfigSoarChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A1C RID: 14876 RVA: 0x001A543B File Offset: 0x001A363B
		static ConfigSoarChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarChallengeById.CreateStaticDefaultValue), new Action(ConfigSoarChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x001A545C File Offset: 0x001A365C
		public static void CreateStaticDefaultValue()
		{
			ConfigSoarChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoarChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "SoarChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `SoarChallenge` where Id=?")
			});
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x001A54DB File Offset: 0x001A36DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarChallengeById.LogPair = null;
			ConfigSoarChallengeById.HandleId = 0;
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001A54E9 File Offset: 0x001A36E9
		public static void Init()
		{
			ConfigSoarChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigSoarChallengeById.HandleId, "db_activitymaptravel.db", "select BinData from `SoarChallenge` where Id=?");
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001A5504 File Offset: 0x001A3704
		public static SoarChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoarChallengeById.HandleId, ConfigSoarChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoarChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SoarChallenge?(SoarChallenge.GetRootAsSoarChallenge(configBuffer));
				}
			}
			ConfigSoarChallengeById.LogPair.Clear();
			ConfigSoarChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSoarChallengeById.HandleId, 1, p0Id, ConfigSoarChallengeById.LogPair) || ConfigCommon.Step(ConfigSoarChallengeById.HandleId, true, ConfigSoarChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSoarChallengeById.HandleId, ConfigSoarChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoarChallengeById.HandleId, 0, ConfigSoarChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSoarChallengeById.HandleId, ConfigSoarChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SoarChallenge rootAsSoarChallenge = SoarChallenge.GetRootAsSoarChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoarChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSoarChallengeById.HandleId, ConfigSoarChallengeById.LogPair);
			return new SoarChallenge?(rootAsSoarChallenge);
		}

		// Token: 0x0400439A RID: 17306
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x0400439B RID: 17307
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400439C RID: 17308
		private const string TABLE = "SoarChallenge";

		// Token: 0x0400439D RID: 17309
		private const string COMMAND = "select BinData from `SoarChallenge` where Id=?";

		// Token: 0x0400439E RID: 17310
		private const string KEY_PREFIX = "SoarChallengeById";

		// Token: 0x0400439F RID: 17311
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043A0 RID: 17312
		private static int HandleId;
	}
}
