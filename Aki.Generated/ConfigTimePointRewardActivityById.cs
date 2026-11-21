using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB9 RID: 2745
	public class ConfigTimePointRewardActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600406A RID: 16490 RVA: 0x001C9087 File Offset: 0x001C7287
		static ConfigTimePointRewardActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTimePointRewardActivityById.CreateStaticDefaultValue), new Action(ConfigTimePointRewardActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x001C90A8 File Offset: 0x001C72A8
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

		// Token: 0x0600406C RID: 16492 RVA: 0x001C9127 File Offset: 0x001C7327
		public static void ResetStaticDefaultValue()
		{
			ConfigTimePointRewardActivityById.LogPair = null;
			ConfigTimePointRewardActivityById.HandleId = 0;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x001C9135 File Offset: 0x001C7335
		public static void Init()
		{
			ConfigTimePointRewardActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTimePointRewardActivityById.HandleId, "db_timepointrewardactivity.db", "select BinData from `TimePointRewardActivity` where Id = ?");
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x001C9150 File Offset: 0x001C7350
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

		// Token: 0x04004AF5 RID: 19189
		private const string DB = "db_timepointrewardactivity.db";

		// Token: 0x04004AF6 RID: 19190
		private const string FILE = "d.定点奖励领取活动.xlsx";

		// Token: 0x04004AF7 RID: 19191
		private const string TABLE = "TimePointRewardActivity";

		// Token: 0x04004AF8 RID: 19192
		private const string COMMAND = "select BinData from `TimePointRewardActivity` where Id = ?";

		// Token: 0x04004AF9 RID: 19193
		private const string KEY_PREFIX = "TimePointRewardActivityById";

		// Token: 0x04004AFA RID: 19194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AFB RID: 19195
		private static int HandleId;
	}
}
