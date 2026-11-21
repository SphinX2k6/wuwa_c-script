using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000319 RID: 793
	public class ConfigFlagChallengeTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x000C64CC File Offset: 0x000C46CC
		static ConfigFlagChallengeTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeTaskById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000C64EC File Offset: 0x000C46EC
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

		// Token: 0x0600129D RID: 4765 RVA: 0x000C656B File Offset: 0x000C476B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeTaskById.LogPair = null;
			ConfigFlagChallengeTaskById.HandleId = 0;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000C6579 File Offset: 0x000C4779
		public static void Init()
		{
			ConfigFlagChallengeTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeTaskById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeTask` where Id=?");
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000C6594 File Offset: 0x000C4794
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

		// Token: 0x04001593 RID: 5523
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001594 RID: 5524
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001595 RID: 5525
		private const string TABLE = "FlagChallengeTask";

		// Token: 0x04001596 RID: 5526
		private const string COMMAND = "select BinData from `FlagChallengeTask` where Id=?";

		// Token: 0x04001597 RID: 5527
		private const string KEY_PREFIX = "FlagChallengeTaskById";

		// Token: 0x04001598 RID: 5528
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001599 RID: 5529
		private static int HandleId;
	}
}
