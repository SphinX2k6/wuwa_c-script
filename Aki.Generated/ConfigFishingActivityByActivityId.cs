using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E4 RID: 740
	public class ConfigFishingActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x000BF208 File Offset: 0x000BD408
		static ConfigFishingActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigFishingActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000BF228 File Offset: 0x000BD428
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivity` where ActivityId=?")
			});
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000BF2A7 File Offset: 0x000BD4A7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityByActivityId.LogPair = null;
			ConfigFishingActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000BF2B5 File Offset: 0x000BD4B5
		public static void Init()
		{
			ConfigFishingActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityByActivityId.HandleId, "db_fishing.db", "select BinData from `FishingActivity` where ActivityId=?");
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000BF2D0 File Offset: 0x000BD4D0
		public static FishingActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityByActivityId.HandleId, ConfigFishingActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingActivity?(FishingActivity.GetRootAsFishingActivity(configBuffer));
				}
			}
			ConfigFishingActivityByActivityId.LogPair.Clear();
			ConfigFishingActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFishingActivityByActivityId.HandleId, 1, p0ActivityId, ConfigFishingActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigFishingActivityByActivityId.HandleId, true, ConfigFishingActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingActivityByActivityId.HandleId, ConfigFishingActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityByActivityId.HandleId, 0, ConfigFishingActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingActivityByActivityId.HandleId, ConfigFishingActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingActivity rootAsFishingActivity = FishingActivity.GetRootAsFishingActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingActivityByActivityId.HandleId, ConfigFishingActivityByActivityId.LogPair);
			return new FishingActivity?(rootAsFishingActivity);
		}

		// Token: 0x04001420 RID: 5152
		private const string DB = "db_fishing.db";

		// Token: 0x04001421 RID: 5153
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001422 RID: 5154
		private const string TABLE = "FishingActivity";

		// Token: 0x04001423 RID: 5155
		private const string COMMAND = "select BinData from `FishingActivity` where ActivityId=?";

		// Token: 0x04001424 RID: 5156
		private const string KEY_PREFIX = "FishingActivityByActivityId";

		// Token: 0x04001425 RID: 5157
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001426 RID: 5158
		private static int HandleId;
	}
}
