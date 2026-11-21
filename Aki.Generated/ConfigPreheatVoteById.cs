using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000776 RID: 1910
	public class ConfigPreheatVoteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CD5 RID: 11477 RVA: 0x0015A307 File Offset: 0x00158507
		static ConfigPreheatVoteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatVoteById.CreateStaticDefaultValue), new Action(ConfigPreheatVoteById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0015A328 File Offset: 0x00158528
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatVoteById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatVoteById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatVote"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatVote` where Id=?")
			});
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0015A3A7 File Offset: 0x001585A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatVoteById.LogPair = null;
			ConfigPreheatVoteById.HandleId = 0;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0015A3B5 File Offset: 0x001585B5
		public static void Init()
		{
			ConfigPreheatVoteById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatVoteById.HandleId, "db_preheat.db", "select BinData from `PreheatVote` where Id=?");
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x0015A3D0 File Offset: 0x001585D0
		public static PreheatVote? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatVoteById.HandleId, ConfigPreheatVoteById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatVoteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreheatVote?(PreheatVote.GetRootAsPreheatVote(configBuffer));
				}
			}
			ConfigPreheatVoteById.LogPair.Clear();
			ConfigPreheatVoteById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreheatVoteById.HandleId, 1, p0Id, ConfigPreheatVoteById.LogPair) || ConfigCommon.Step(ConfigPreheatVoteById.HandleId, true, ConfigPreheatVoteById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreheatVoteById.HandleId, ConfigPreheatVoteById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatVoteById.HandleId, 0, ConfigPreheatVoteById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreheatVoteById.HandleId, ConfigPreheatVoteById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreheatVote rootAsPreheatVote = PreheatVote.GetRootAsPreheatVote(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatVoteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreheatVoteById.HandleId, ConfigPreheatVoteById.LogPair);
			return new PreheatVote?(rootAsPreheatVote);
		}

		// Token: 0x04003420 RID: 13344
		private const string DB = "db_preheat.db";

		// Token: 0x04003421 RID: 13345
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003422 RID: 13346
		private const string TABLE = "PreheatVote";

		// Token: 0x04003423 RID: 13347
		private const string COMMAND = "select BinData from `PreheatVote` where Id=?";

		// Token: 0x04003424 RID: 13348
		private const string KEY_PREFIX = "PreheatVoteById";

		// Token: 0x04003425 RID: 13349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003426 RID: 13350
		private static int HandleId;
	}
}
