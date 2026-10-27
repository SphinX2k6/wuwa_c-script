using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CF RID: 719
	public class ConfigFishingActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x000B8CFC File Offset: 0x000B6EFC
		static ConfigFishingActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigFishingActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000B8D1C File Offset: 0x000B6F1C
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

		// Token: 0x060010E1 RID: 4321 RVA: 0x000B8D9B File Offset: 0x000B6F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityByActivityId.LogPair = null;
			ConfigFishingActivityByActivityId.HandleId = 0;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000B8DA9 File Offset: 0x000B6FA9
		public static void Init()
		{
			ConfigFishingActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityByActivityId.HandleId, "db_fishing.db", "select BinData from `FishingActivity` where ActivityId=?");
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000B8DC4 File Offset: 0x000B6FC4
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

		// Token: 0x0400138D RID: 5005
		private const string DB = "db_fishing.db";

		// Token: 0x0400138E RID: 5006
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x0400138F RID: 5007
		private const string TABLE = "FishingActivity";

		// Token: 0x04001390 RID: 5008
		private const string COMMAND = "select BinData from `FishingActivity` where ActivityId=?";

		// Token: 0x04001391 RID: 5009
		private const string KEY_PREFIX = "FishingActivityByActivityId";

		// Token: 0x04001392 RID: 5010
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001393 RID: 5011
		private static int HandleId;
	}
}
