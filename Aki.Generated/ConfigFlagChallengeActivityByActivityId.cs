using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030A RID: 778
	public class ConfigFlagChallengeActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x000C4394 File Offset: 0x000C2594
		static ConfigFlagChallengeActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000C43B4 File Offset: 0x000C25B4
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeActivity` where ActivityId=?")
			});
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000C4433 File Offset: 0x000C2633
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeActivityByActivityId.LogPair = null;
			ConfigFlagChallengeActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x000C4441 File Offset: 0x000C2641
		public static void Init()
		{
			ConfigFlagChallengeActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeActivityByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeActivity` where ActivityId=?");
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000C445C File Offset: 0x000C265C
		public static FlagChallengeActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeActivityByActivityId.HandleId, ConfigFlagChallengeActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeActivity?(FlagChallengeActivity.GetRootAsFlagChallengeActivity(configBuffer));
				}
			}
			ConfigFlagChallengeActivityByActivityId.LogPair.Clear();
			ConfigFlagChallengeActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeActivityByActivityId.HandleId, 1, p0ActivityId, ConfigFlagChallengeActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigFlagChallengeActivityByActivityId.HandleId, true, ConfigFlagChallengeActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeActivityByActivityId.HandleId, ConfigFlagChallengeActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeActivityByActivityId.HandleId, 0, ConfigFlagChallengeActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeActivityByActivityId.HandleId, ConfigFlagChallengeActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeActivity rootAsFlagChallengeActivity = FlagChallengeActivity.GetRootAsFlagChallengeActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeActivityByActivityId.HandleId, ConfigFlagChallengeActivityByActivityId.LogPair);
			return new FlagChallengeActivity?(rootAsFlagChallengeActivity);
		}

		// Token: 0x0400152A RID: 5418
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400152B RID: 5419
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x0400152C RID: 5420
		private const string TABLE = "FlagChallengeActivity";

		// Token: 0x0400152D RID: 5421
		private const string COMMAND = "select BinData from `FlagChallengeActivity` where ActivityId=?";

		// Token: 0x0400152E RID: 5422
		private const string KEY_PREFIX = "FlagChallengeActivityByActivityId";

		// Token: 0x0400152F RID: 5423
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001530 RID: 5424
		private static int HandleId;
	}
}
