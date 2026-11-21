using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EE RID: 1262
	public class ConfigLineCrossChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x00104254 File Offset: 0x00102454
		static ConfigLineCrossChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossChallengeById.CreateStaticDefaultValue), new Action(ConfigLineCrossChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00104274 File Offset: 0x00102474
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

		// Token: 0x06001DA1 RID: 7585 RVA: 0x001042F3 File Offset: 0x001024F3
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossChallengeById.LogPair = null;
			ConfigLineCrossChallengeById.HandleId = 0;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00104301 File Offset: 0x00102501
		public static void Init()
		{
			ConfigLineCrossChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossChallengeById.HandleId, "db_linecross.db", "select BinData from `LineCrossChallenge` where Id=?");
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0010431C File Offset: 0x0010251C
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

		// Token: 0x04002266 RID: 8806
		private const string DB = "db_linecross.db";

		// Token: 0x04002267 RID: 8807
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x04002268 RID: 8808
		private const string TABLE = "LineCrossChallenge";

		// Token: 0x04002269 RID: 8809
		private const string COMMAND = "select BinData from `LineCrossChallenge` where Id=?";

		// Token: 0x0400226A RID: 8810
		private const string KEY_PREFIX = "LineCrossChallengeById";

		// Token: 0x0400226B RID: 8811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400226C RID: 8812
		private static int HandleId;
	}
}
