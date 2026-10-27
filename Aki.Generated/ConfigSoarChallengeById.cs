using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000961 RID: 2401
	public class ConfigSoarChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600385A RID: 14426 RVA: 0x0019821B File Offset: 0x0019641B
		static ConfigSoarChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarChallengeById.CreateStaticDefaultValue), new Action(ConfigSoarChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x0019823C File Offset: 0x0019643C
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

		// Token: 0x0600385C RID: 14428 RVA: 0x001982BB File Offset: 0x001964BB
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarChallengeById.LogPair = null;
			ConfigSoarChallengeById.HandleId = 0;
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x001982C9 File Offset: 0x001964C9
		public static void Init()
		{
			ConfigSoarChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigSoarChallengeById.HandleId, "db_activitymaptravel.db", "select BinData from `SoarChallenge` where Id=?");
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x001982E4 File Offset: 0x001964E4
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

		// Token: 0x0400418D RID: 16781
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x0400418E RID: 16782
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400418F RID: 16783
		private const string TABLE = "SoarChallenge";

		// Token: 0x04004190 RID: 16784
		private const string COMMAND = "select BinData from `SoarChallenge` where Id=?";

		// Token: 0x04004191 RID: 16785
		private const string KEY_PREFIX = "SoarChallengeById";

		// Token: 0x04004192 RID: 16786
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004193 RID: 16787
		private static int HandleId;
	}
}
