using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D8 RID: 1240
	public class ConfigLineCrossChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D1B RID: 7451 RVA: 0x000FDB00 File Offset: 0x000FBD00
		static ConfigLineCrossChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossChallengeById.CreateStaticDefaultValue), new Action(ConfigLineCrossChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000FDB20 File Offset: 0x000FBD20
		public static void CreateStaticDefaultValue()
		{
			ConfigLineCrossChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLineCrossChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linecross.db"),
				new ValueTuple<string, object>("文件", "s.十字连线.xlsx"),
				new ValueTuple<string, object>("表名", "LineCrossChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `LineCrossChallenge` where Id=?")
			});
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x000FDB9F File Offset: 0x000FBD9F
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossChallengeById.LogPair = null;
			ConfigLineCrossChallengeById.HandleId = 0;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000FDBAD File Offset: 0x000FBDAD
		public static void Init()
		{
			ConfigLineCrossChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossChallengeById.HandleId, "db_linecross.db", "select BinData from `LineCrossChallenge` where Id=?");
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000FDBC8 File Offset: 0x000FBDC8
		public static LineCrossChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLineCrossChallengeById.HandleId, ConfigLineCrossChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LineCrossChallenge?(LineCrossChallenge.GetRootAsLineCrossChallenge(configBuffer));
				}
			}
			ConfigLineCrossChallengeById.LogPair.Clear();
			ConfigLineCrossChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLineCrossChallengeById.HandleId, 1, p0Id, ConfigLineCrossChallengeById.LogPair) || ConfigCommon.Step(ConfigLineCrossChallengeById.HandleId, true, ConfigLineCrossChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLineCrossChallengeById.HandleId, ConfigLineCrossChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLineCrossChallengeById.HandleId, 0, ConfigLineCrossChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLineCrossChallengeById.HandleId, ConfigLineCrossChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LineCrossChallenge rootAsLineCrossChallenge = LineCrossChallenge.GetRootAsLineCrossChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLineCrossChallengeById.HandleId, ConfigLineCrossChallengeById.LogPair);
			return new LineCrossChallenge?(rootAsLineCrossChallenge);
		}

		// Token: 0x040021CC RID: 8652
		private const string DB = "db_linecross.db";

		// Token: 0x040021CD RID: 8653
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x040021CE RID: 8654
		private const string TABLE = "LineCrossChallenge";

		// Token: 0x040021CF RID: 8655
		private const string COMMAND = "select BinData from `LineCrossChallenge` where Id=?";

		// Token: 0x040021D0 RID: 8656
		private const string KEY_PREFIX = "LineCrossChallengeById";

		// Token: 0x040021D1 RID: 8657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021D2 RID: 8658
		private static int HandleId;
	}
}
