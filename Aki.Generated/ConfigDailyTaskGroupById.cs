using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BB RID: 443
	public class ConfigDailyTaskGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x00094708 File Offset: 0x00092908
		static ConfigDailyTaskGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyTaskGroupById.CreateStaticDefaultValue), new Action(ConfigDailyTaskGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00094728 File Offset: 0x00092928
		public static void CreateStaticDefaultValue()
		{
			ConfigDailyTaskGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDailyTaskGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daily_task.db"),
				new ValueTuple<string, object>("文件", "m.每日任务.xlsx"),
				new ValueTuple<string, object>("表名", "DailyTaskGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `DailyTaskGroup` where Id=?")
			});
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000947A7 File Offset: 0x000929A7
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyTaskGroupById.LogPair = null;
			ConfigDailyTaskGroupById.HandleId = 0;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000947B5 File Offset: 0x000929B5
		public static void Init()
		{
			ConfigDailyTaskGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigDailyTaskGroupById.HandleId, "db_daily_task.db", "select BinData from `DailyTaskGroup` where Id=?");
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000947D0 File Offset: 0x000929D0
		public static DailyTaskGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDailyTaskGroupById.HandleId, ConfigDailyTaskGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyTaskGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DailyTaskGroup?(DailyTaskGroup.GetRootAsDailyTaskGroup(configBuffer));
				}
			}
			ConfigDailyTaskGroupById.LogPair.Clear();
			ConfigDailyTaskGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDailyTaskGroupById.HandleId, 1, p0Id, ConfigDailyTaskGroupById.LogPair) || ConfigCommon.Step(ConfigDailyTaskGroupById.HandleId, true, ConfigDailyTaskGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDailyTaskGroupById.HandleId, ConfigDailyTaskGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDailyTaskGroupById.HandleId, 0, ConfigDailyTaskGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDailyTaskGroupById.HandleId, ConfigDailyTaskGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DailyTaskGroup rootAsDailyTaskGroup = DailyTaskGroup.GetRootAsDailyTaskGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyTaskGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDailyTaskGroupById.HandleId, ConfigDailyTaskGroupById.LogPair);
			return new DailyTaskGroup?(rootAsDailyTaskGroup);
		}

		// Token: 0x04000C01 RID: 3073
		private const string DB = "db_daily_task.db";

		// Token: 0x04000C02 RID: 3074
		private const string FILE = "m.每日任务.xlsx";

		// Token: 0x04000C03 RID: 3075
		private const string TABLE = "DailyTaskGroup";

		// Token: 0x04000C04 RID: 3076
		private const string COMMAND = "select BinData from `DailyTaskGroup` where Id=?";

		// Token: 0x04000C05 RID: 3077
		private const string KEY_PREFIX = "DailyTaskGroupById";

		// Token: 0x04000C06 RID: 3078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C07 RID: 3079
		private static int HandleId;
	}
}
