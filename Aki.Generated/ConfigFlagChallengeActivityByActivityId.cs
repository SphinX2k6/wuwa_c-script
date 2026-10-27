using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F5 RID: 757
	public class ConfigFlagChallengeActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011C3 RID: 4547 RVA: 0x000BDE88 File Offset: 0x000BC088
		static ConfigFlagChallengeActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000BDEA8 File Offset: 0x000BC0A8
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

		// Token: 0x060011C5 RID: 4549 RVA: 0x000BDF27 File Offset: 0x000BC127
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeActivityByActivityId.LogPair = null;
			ConfigFlagChallengeActivityByActivityId.HandleId = 0;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000BDF35 File Offset: 0x000BC135
		public static void Init()
		{
			ConfigFlagChallengeActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeActivityByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeActivity` where ActivityId=?");
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000BDF50 File Offset: 0x000BC150
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

		// Token: 0x04001497 RID: 5271
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001498 RID: 5272
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001499 RID: 5273
		private const string TABLE = "FlagChallengeActivity";

		// Token: 0x0400149A RID: 5274
		private const string COMMAND = "select BinData from `FlagChallengeActivity` where ActivityId=?";

		// Token: 0x0400149B RID: 5275
		private const string KEY_PREFIX = "FlagChallengeActivityByActivityId";

		// Token: 0x0400149C RID: 5276
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400149D RID: 5277
		private static int HandleId;
	}
}
