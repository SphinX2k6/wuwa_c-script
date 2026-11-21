using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EA RID: 1258
	public class ConfigLifePointChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x00103934 File Offset: 0x00101B34
		static ConfigLifePointChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointChallengeById.CreateStaticDefaultValue), new Action(ConfigLifePointChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00103954 File Offset: 0x00101B54
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointChallenge` where Id=?")
			});
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x001039D3 File Offset: 0x00101BD3
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointChallengeById.LogPair = null;
			ConfigLifePointChallengeById.HandleId = 0;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x001039E1 File Offset: 0x00101BE1
		public static void Init()
		{
			ConfigLifePointChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointChallengeById.HandleId, "db_lifepoint.db", "select BinData from `LifePointChallenge` where Id=?");
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x001039FC File Offset: 0x00101BFC
		public static LifePointChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointChallenge?(LifePointChallenge.GetRootAsLifePointChallenge(configBuffer));
				}
			}
			ConfigLifePointChallengeById.LogPair.Clear();
			ConfigLifePointChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLifePointChallengeById.HandleId, 1, p0Id, ConfigLifePointChallengeById.LogPair) || ConfigCommon.Step(ConfigLifePointChallengeById.HandleId, true, ConfigLifePointChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointChallengeById.HandleId, 0, ConfigLifePointChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointChallenge rootAsLifePointChallenge = LifePointChallenge.GetRootAsLifePointChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
			return new LifePointChallenge?(rootAsLifePointChallenge);
		}

		// Token: 0x0400224A RID: 8778
		private const string DB = "db_lifepoint.db";

		// Token: 0x0400224B RID: 8779
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x0400224C RID: 8780
		private const string TABLE = "LifePointChallenge";

		// Token: 0x0400224D RID: 8781
		private const string COMMAND = "select BinData from `LifePointChallenge` where Id=?";

		// Token: 0x0400224E RID: 8782
		private const string KEY_PREFIX = "LifePointChallengeById";

		// Token: 0x0400224F RID: 8783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002250 RID: 8784
		private static int HandleId;
	}
}
