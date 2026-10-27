using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075E RID: 1886
	public class ConfigPreheatVoteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x0015388B File Offset: 0x00151A8B
		static ConfigPreheatVoteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatVoteById.CreateStaticDefaultValue), new Action(ConfigPreheatVoteById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x001538AC File Offset: 0x00151AAC
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

		// Token: 0x06002C47 RID: 11335 RVA: 0x0015392B File Offset: 0x00151B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatVoteById.LogPair = null;
			ConfigPreheatVoteById.HandleId = 0;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x00153939 File Offset: 0x00151B39
		public static void Init()
		{
			ConfigPreheatVoteById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatVoteById.HandleId, "db_preheat.db", "select BinData from `PreheatVote` where Id=?");
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00153954 File Offset: 0x00151B54
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

		// Token: 0x04003378 RID: 13176
		private const string DB = "db_preheat.db";

		// Token: 0x04003379 RID: 13177
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x0400337A RID: 13178
		private const string TABLE = "PreheatVote";

		// Token: 0x0400337B RID: 13179
		private const string COMMAND = "select BinData from `PreheatVote` where Id=?";

		// Token: 0x0400337C RID: 13180
		private const string KEY_PREFIX = "PreheatVoteById";

		// Token: 0x0400337D RID: 13181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400337E RID: 13182
		private static int HandleId;
	}
}
