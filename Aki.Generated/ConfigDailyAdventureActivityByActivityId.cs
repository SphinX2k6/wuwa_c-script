using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B7 RID: 439
	public class ConfigDailyAdventureActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x00093DE8 File Offset: 0x00091FE8
		static ConfigDailyAdventureActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventureActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigDailyAdventureActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00093E08 File Offset: 0x00092008
		public static void CreateStaticDefaultValue()
		{
			ConfigDailyAdventureActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDailyAdventureActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dailyadventureactivity.db"),
				new ValueTuple<string, object>("文件", "r.日常探险活动.xlsx"),
				new ValueTuple<string, object>("表名", "DailyAdventureActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DailyAdventureActivity` where ActivityId=?")
			});
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00093E87 File Offset: 0x00092087
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventureActivityByActivityId.LogPair = null;
			ConfigDailyAdventureActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00093E95 File Offset: 0x00092095
		public static void Init()
		{
			ConfigDailyAdventureActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventureActivityByActivityId.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventureActivity` where ActivityId=?");
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00093EB0 File Offset: 0x000920B0
		public static DailyAdventureActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDailyAdventureActivityByActivityId.HandleId, ConfigDailyAdventureActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventureActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DailyAdventureActivity?(DailyAdventureActivity.GetRootAsDailyAdventureActivity(configBuffer));
				}
			}
			ConfigDailyAdventureActivityByActivityId.LogPair.Clear();
			ConfigDailyAdventureActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDailyAdventureActivityByActivityId.HandleId, 1, p0ActivityId, ConfigDailyAdventureActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigDailyAdventureActivityByActivityId.HandleId, true, ConfigDailyAdventureActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDailyAdventureActivityByActivityId.HandleId, ConfigDailyAdventureActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDailyAdventureActivityByActivityId.HandleId, 0, ConfigDailyAdventureActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDailyAdventureActivityByActivityId.HandleId, ConfigDailyAdventureActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DailyAdventureActivity rootAsDailyAdventureActivity = DailyAdventureActivity.GetRootAsDailyAdventureActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventureActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDailyAdventureActivityByActivityId.HandleId, ConfigDailyAdventureActivityByActivityId.LogPair);
			return new DailyAdventureActivity?(rootAsDailyAdventureActivity);
		}

		// Token: 0x04000BE5 RID: 3045
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000BE6 RID: 3046
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000BE7 RID: 3047
		private const string TABLE = "DailyAdventureActivity";

		// Token: 0x04000BE8 RID: 3048
		private const string COMMAND = "select BinData from `DailyAdventureActivity` where ActivityId=?";

		// Token: 0x04000BE9 RID: 3049
		private const string KEY_PREFIX = "DailyAdventureActivityByActivityId";

		// Token: 0x04000BEA RID: 3050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BEB RID: 3051
		private static int HandleId;
	}
}
