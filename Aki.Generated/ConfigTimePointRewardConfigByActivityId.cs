using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E5 RID: 2533
	public class ConfigTimePointRewardConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x001A9F3C File Offset: 0x001A813C
		static ConfigTimePointRewardConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTimePointRewardConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x001A9F5C File Offset: 0x001A815C
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

		// Token: 0x06003B74 RID: 15220 RVA: 0x001A9FDB File Offset: 0x001A81DB
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardConfigByActivityId.LogPair = null;
			ConfigTimePointRewardConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x001A9FE9 File Offset: 0x001A81E9
		public static void Init()
		{
			ConfigTimePointRewardConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardConfigByActivityId.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardConfig` where ActivityId = ?");
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x001AA004 File Offset: 0x001A8204
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

		// Token: 0x04004529 RID: 17705
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x0400452A RID: 17706
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x0400452B RID: 17707
		private const string TABLE = "TimePointRewardConfig";

		// Token: 0x0400452C RID: 17708
		private const string COMMAND = "select BinData from `TimePointRewardConfig` where ActivityId = ?";

		// Token: 0x0400452D RID: 17709
		private const string KEY_PREFIX = "TimePointRewardConfigByActivityId";

		// Token: 0x0400452E RID: 17710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400452F RID: 17711
		private static int HandleId;
	}
}
