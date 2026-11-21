using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C9 RID: 457
	public class ConfigDailyAdventureActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00099D20 File Offset: 0x00097F20
		static ConfigDailyAdventureActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventureActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigDailyAdventureActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00099D40 File Offset: 0x00097F40
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

		// Token: 0x06000ABB RID: 2747 RVA: 0x00099DBF File Offset: 0x00097FBF
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventureActivityByActivityId.LogPair = null;
			ConfigDailyAdventureActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00099DCD File Offset: 0x00097FCD
		public static void Init()
		{
			ConfigDailyAdventureActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventureActivityByActivityId.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventureActivity` where ActivityId=?");
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00099DE8 File Offset: 0x00097FE8
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

		// Token: 0x04000C63 RID: 3171
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000C64 RID: 3172
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000C65 RID: 3173
		private const string TABLE = "DailyAdventureActivity";

		// Token: 0x04000C66 RID: 3174
		private const string COMMAND = "select BinData from `DailyAdventureActivity` where ActivityId=?";

		// Token: 0x04000C67 RID: 3175
		private const string KEY_PREFIX = "DailyAdventureActivityByActivityId";

		// Token: 0x04000C68 RID: 3176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C69 RID: 3177
		private static int HandleId;
	}
}
