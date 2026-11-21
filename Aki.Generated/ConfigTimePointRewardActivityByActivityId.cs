using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB8 RID: 2744
	public class ConfigTimePointRewardActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004064 RID: 16484 RVA: 0x001C8E50 File Offset: 0x001C7050
		static ConfigTimePointRewardActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTimePointRewardActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x001C8E70 File Offset: 0x001C7070
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

		// Token: 0x06004066 RID: 16486 RVA: 0x001C8EEF File Offset: 0x001C70EF
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardActivityByActivityId.LogPair = null;
			ConfigTimePointRewardActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x001C8EFD File Offset: 0x001C70FD
		public static void Init()
		{
			ConfigTimePointRewardActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardActivityByActivityId.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardActivity` where ActivityId = ?");
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x001C8F18 File Offset: 0x001C7118
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

		// Token: 0x04004AEE RID: 19182
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x04004AEF RID: 19183
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x04004AF0 RID: 19184
		private const string TABLE = "TimePointRewardActivity";

		// Token: 0x04004AF1 RID: 19185
		private const string COMMAND = "select BinData from `TimePointRewardActivity` where ActivityId = ?";

		// Token: 0x04004AF2 RID: 19186
		private const string KEY_PREFIX = "TimePointRewardActivityByActivityId";

		// Token: 0x04004AF3 RID: 19187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AF4 RID: 19188
		private static int HandleId;
	}
}
