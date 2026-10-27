using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E4 RID: 2532
	public class ConfigTimePointRewardActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B6C RID: 15212 RVA: 0x001A9CF3 File Offset: 0x001A7EF3
		static ConfigTimePointRewardActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardActivityById.CreateStaticDefaultValue), new Action(ConfigTimePointRewardActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x001A9D14 File Offset: 0x001A7F14
		public static void CreateStaticDefaultValue()
		{
			ConfigTimePointRewardActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTimePointRewardActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_timepointrewardactivity.db"),
				new ValueTuple<string, object>("文件", "d.定点奖励领取活动.xlsx"),
				new ValueTuple<string, object>("表名", "TimePointRewardActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TimePointRewardActivity` where Id = ?")
			});
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x001A9D93 File Offset: 0x001A7F93
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardActivityById.LogPair = null;
			ConfigTimePointRewardActivityById.HandleId = 0;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x001A9DA1 File Offset: 0x001A7FA1
		public static void Init()
		{
			ConfigTimePointRewardActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardActivityById.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardActivity` where Id = ?");
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001A9DBC File Offset: 0x001A7FBC
		public static TimePointRewardActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTimePointRewardActivityById.HandleId, ConfigTimePointRewardActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TimePointRewardActivity?(TimePointRewardActivity.GetRootAsTimePointRewardActivity(configBuffer));
				}
			}
			ConfigTimePointRewardActivityById.LogPair.Clear();
			ConfigTimePointRewardActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTimePointRewardActivityById.HandleId, 1, p0Id, ConfigTimePointRewardActivityById.LogPair) || ConfigCommon.Step(ConfigTimePointRewardActivityById.HandleId, true, ConfigTimePointRewardActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTimePointRewardActivityById.HandleId, ConfigTimePointRewardActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTimePointRewardActivityById.HandleId, 0, ConfigTimePointRewardActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTimePointRewardActivityById.HandleId, ConfigTimePointRewardActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TimePointRewardActivity rootAsTimePointRewardActivity = TimePointRewardActivity.GetRootAsTimePointRewardActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TimePointRewardActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTimePointRewardActivityById.HandleId, ConfigTimePointRewardActivityById.LogPair);
			return new TimePointRewardActivity?(rootAsTimePointRewardActivity);
		}

		// Token: 0x04004522 RID: 17698
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x04004523 RID: 17699
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x04004524 RID: 17700
		private const string TABLE = "TimePointRewardActivity";

		// Token: 0x04004525 RID: 17701
		private const string COMMAND = "select BinData from `TimePointRewardActivity` where Id = ?";

		// Token: 0x04004526 RID: 17702
		private const string KEY_PREFIX = "TimePointRewardActivityById";

		// Token: 0x04004527 RID: 17703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004528 RID: 17704
		private static int HandleId;
	}
}
