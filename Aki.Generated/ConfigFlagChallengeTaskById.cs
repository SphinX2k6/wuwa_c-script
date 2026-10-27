using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000304 RID: 772
	public class ConfigFlagChallengeTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x000BFFC0 File Offset: 0x000BE1C0
		static ConfigFlagChallengeTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeTaskById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000BFFE0 File Offset: 0x000BE1E0
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeTask"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeTask` where Id=?")
			});
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000C005F File Offset: 0x000BE25F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeTaskById.LogPair = null;
			ConfigFlagChallengeTaskById.HandleId = 0;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000C006D File Offset: 0x000BE26D
		public static void Init()
		{
			ConfigFlagChallengeTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeTaskById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeTask` where Id=?");
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000C0088 File Offset: 0x000BE288
		public static FlagChallengeTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeTaskById.HandleId, ConfigFlagChallengeTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeTask?(FlagChallengeTask.GetRootAsFlagChallengeTask(configBuffer));
				}
			}
			ConfigFlagChallengeTaskById.LogPair.Clear();
			ConfigFlagChallengeTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeTaskById.HandleId, 1, p0Id, ConfigFlagChallengeTaskById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeTaskById.HandleId, true, ConfigFlagChallengeTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeTaskById.HandleId, ConfigFlagChallengeTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeTaskById.HandleId, 0, ConfigFlagChallengeTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeTaskById.HandleId, ConfigFlagChallengeTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeTask rootAsFlagChallengeTask = FlagChallengeTask.GetRootAsFlagChallengeTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeTaskById.HandleId, ConfigFlagChallengeTaskById.LogPair);
			return new FlagChallengeTask?(rootAsFlagChallengeTask);
		}

		// Token: 0x04001500 RID: 5376
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001501 RID: 5377
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001502 RID: 5378
		private const string TABLE = "FlagChallengeTask";

		// Token: 0x04001503 RID: 5379
		private const string COMMAND = "select BinData from `FlagChallengeTask` where Id=?";

		// Token: 0x04001504 RID: 5380
		private const string KEY_PREFIX = "FlagChallengeTaskById";

		// Token: 0x04001505 RID: 5381
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001506 RID: 5382
		private static int HandleId;
	}
}
