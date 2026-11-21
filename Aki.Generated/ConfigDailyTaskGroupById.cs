using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CD RID: 461
	public class ConfigDailyTaskGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x0009A640 File Offset: 0x00098840
		static ConfigDailyTaskGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyTaskGroupById.CreateStaticDefaultValue), new Action(ConfigDailyTaskGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0009A660 File Offset: 0x00098860
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

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0009A6DF File Offset: 0x000988DF
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyTaskGroupById.LogPair = null;
			ConfigDailyTaskGroupById.HandleId = 0;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0009A6ED File Offset: 0x000988ED
		public static void Init()
		{
			ConfigDailyTaskGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigDailyTaskGroupById.HandleId, "db_daily_task.db", "select BinData from `DailyTaskGroup` where Id=?");
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0009A708 File Offset: 0x00098908
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

		// Token: 0x04000C7F RID: 3199
		private const string DB = "db_daily_task.db";

		// Token: 0x04000C80 RID: 3200
		private const string FILE = "m.每日任务.xlsx";

		// Token: 0x04000C81 RID: 3201
		private const string TABLE = "DailyTaskGroup";

		// Token: 0x04000C82 RID: 3202
		private const string COMMAND = "select BinData from `DailyTaskGroup` where Id=?";

		// Token: 0x04000C83 RID: 3203
		private const string KEY_PREFIX = "DailyTaskGroupById";

		// Token: 0x04000C84 RID: 3204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C85 RID: 3205
		private static int HandleId;
	}
}
