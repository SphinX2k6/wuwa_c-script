using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABA RID: 2746
	public class ConfigTimePointRewardConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004070 RID: 16496 RVA: 0x001C92D0 File Offset: 0x001C74D0
		static ConfigTimePointRewardConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTimePointRewardConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x001C92F0 File Offset: 0x001C74F0
		public static void CreateStaticDefaultValue()
		{
			ConfigTimePointRewardConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTimePointRewardConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_timepointrewardactivity.db"),
				new ValueTuple<string, object>("文件", "d.定点奖励领取活动.xlsx"),
				new ValueTuple<string, object>("表名", "TimePointRewardConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TimePointRewardConfig` where ActivityId = ?")
			});
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x001C936F File Offset: 0x001C756F
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardConfigByActivityId.LogPair = null;
			ConfigTimePointRewardConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x001C937D File Offset: 0x001C757D
		public static void Init()
		{
			ConfigTimePointRewardConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardConfigByActivityId.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardConfig` where ActivityId = ?");
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x001C9398 File Offset: 0x001C7598
		public static TimePointRewardConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTimePointRewardConfigByActivityId.HandleId, ConfigTimePointRewardConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TimePointRewardConfig?(TimePointRewardConfig.GetRootAsTimePointRewardConfig(configBuffer));
				}
			}
			ConfigTimePointRewardConfigByActivityId.LogPair.Clear();
			ConfigTimePointRewardConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTimePointRewardConfigByActivityId.HandleId, 1, p0ActivityId, ConfigTimePointRewardConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigTimePointRewardConfigByActivityId.HandleId, true, ConfigTimePointRewardConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTimePointRewardConfigByActivityId.HandleId, ConfigTimePointRewardConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTimePointRewardConfigByActivityId.HandleId, 0, ConfigTimePointRewardConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTimePointRewardConfigByActivityId.HandleId, ConfigTimePointRewardConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TimePointRewardConfig rootAsTimePointRewardConfig = TimePointRewardConfig.GetRootAsTimePointRewardConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTimePointRewardConfigByActivityId.HandleId, ConfigTimePointRewardConfigByActivityId.LogPair);
			return new TimePointRewardConfig?(rootAsTimePointRewardConfig);
		}

		// Token: 0x04004AFC RID: 19196
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x04004AFD RID: 19197
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x04004AFE RID: 19198
		private const string TABLE = "TimePointRewardConfig";

		// Token: 0x04004AFF RID: 19199
		private const string COMMAND = "select BinData from `TimePointRewardConfig` where ActivityId = ?";

		// Token: 0x04004B00 RID: 19200
		private const string KEY_PREFIX = "TimePointRewardConfigByActivityId";

		// Token: 0x04004B01 RID: 19201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B02 RID: 19202
		private static int HandleId;
	}
}
