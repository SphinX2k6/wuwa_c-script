using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CC RID: 460
	public class ConfigDailyTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x0009A3F8 File Offset: 0x000985F8
		static ConfigDailyTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyTaskById.CreateStaticDefaultValue), new Action(ConfigDailyTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0009A418 File Offset: 0x00098618
		public static void CreateStaticDefaultValue()
		{
			ConfigDailyTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDailyTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daily_task.db"),
				new ValueTuple<string, object>("文件", "m.每日任务.xlsx"),
				new ValueTuple<string, object>("表名", "DailyTask"),
				new ValueTuple<string, object>("语句", "select BinData from `DailyTask` where Id=?")
			});
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0009A497 File Offset: 0x00098697
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyTaskById.LogPair = null;
			ConfigDailyTaskById.HandleId = 0;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0009A4A5 File Offset: 0x000986A5
		public static void Init()
		{
			ConfigDailyTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigDailyTaskById.HandleId, "db_daily_task.db", "select BinData from `DailyTask` where Id=?");
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0009A4C0 File Offset: 0x000986C0
		public static DailyTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDailyTaskById.HandleId, ConfigDailyTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DailyTask?(DailyTask.GetRootAsDailyTask(configBuffer));
				}
			}
			ConfigDailyTaskById.LogPair.Clear();
			ConfigDailyTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDailyTaskById.HandleId, 1, p0Id, ConfigDailyTaskById.LogPair) || ConfigCommon.Step(ConfigDailyTaskById.HandleId, true, ConfigDailyTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDailyTaskById.HandleId, ConfigDailyTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDailyTaskById.HandleId, 0, ConfigDailyTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDailyTaskById.HandleId, ConfigDailyTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DailyTask rootAsDailyTask = DailyTask.GetRootAsDailyTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDailyTaskById.HandleId, ConfigDailyTaskById.LogPair);
			return new DailyTask?(rootAsDailyTask);
		}

		// Token: 0x04000C78 RID: 3192
		private const string DB = "db_daily_task.db";

		// Token: 0x04000C79 RID: 3193
		private const string FILE = "m.每日任务.xlsx";

		// Token: 0x04000C7A RID: 3194
		private const string TABLE = "DailyTask";

		// Token: 0x04000C7B RID: 3195
		private const string COMMAND = "select BinData from `DailyTask` where Id=?";

		// Token: 0x04000C7C RID: 3196
		private const string KEY_PREFIX = "DailyTaskById";

		// Token: 0x04000C7D RID: 3197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C7E RID: 3198
		private static int HandleId;
	}
}
