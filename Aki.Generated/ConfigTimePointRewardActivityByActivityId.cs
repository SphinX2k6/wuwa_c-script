using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E3 RID: 2531
	public class ConfigTimePointRewardActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x001A9ABC File Offset: 0x001A7CBC
		static ConfigTimePointRewardActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTimePointRewardActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x001A9ADC File Offset: 0x001A7CDC
		public static void CreateStaticDefaultValue()
		{
			ConfigTimePointRewardActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTimePointRewardActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_timepointrewardactivity.db"),
				new ValueTuple<string, object>("文件", "d.定点奖励领取活动.xlsx"),
				new ValueTuple<string, object>("表名", "TimePointRewardActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TimePointRewardActivity` where ActivityId = ?")
			});
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x001A9B5B File Offset: 0x001A7D5B
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardActivityByActivityId.LogPair = null;
			ConfigTimePointRewardActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x001A9B69 File Offset: 0x001A7D69
		public static void Init()
		{
			ConfigTimePointRewardActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardActivityByActivityId.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardActivity` where ActivityId = ?");
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001A9B84 File Offset: 0x001A7D84
		[NullableContext(2)]
		public static IReadOnlyList<TimePointRewardActivity> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTimePointRewardActivityByActivityId.HandleId, ConfigTimePointRewardActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TimePointRewardActivity> readOnlyList = (IReadOnlyList<TimePointRewardActivity>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTimePointRewardActivityByActivityId.LogPair.Clear();
			ConfigTimePointRewardActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTimePointRewardActivityByActivityId.HandleId, 1, p0ActivityId, ConfigTimePointRewardActivityByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTimePointRewardActivityByActivityId.HandleId, ConfigTimePointRewardActivityByActivityId.LogPair);
				return null;
			}
			List<TimePointRewardActivity> list = new List<TimePointRewardActivity>();
			while (ConfigCommon.Step(ConfigTimePointRewardActivityByActivityId.HandleId, false, ConfigTimePointRewardActivityByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTimePointRewardActivityByActivityId.HandleId, 0, ConfigTimePointRewardActivityByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTimePointRewardActivityByActivityId.HandleId, ConfigTimePointRewardActivityByActivityId.LogPair);
					return null;
				}
				TimePointRewardActivity rootAsTimePointRewardActivity = TimePointRewardActivity.GetRootAsTimePointRewardActivity(new ByteBuffer(item2));
				list.Add(rootAsTimePointRewardActivity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTimePointRewardActivityByActivityId.HandleId, ConfigTimePointRewardActivityByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400451B RID: 17691
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x0400451C RID: 17692
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x0400451D RID: 17693
		private const string TABLE = "TimePointRewardActivity";

		// Token: 0x0400451E RID: 17694
		private const string COMMAND = "select BinData from `TimePointRewardActivity` where ActivityId = ?";

		// Token: 0x0400451F RID: 17695
		private const string KEY_PREFIX = "TimePointRewardActivityByActivityId";

		// Token: 0x04004520 RID: 17696
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004521 RID: 17697
		private static int HandleId;
	}
}
