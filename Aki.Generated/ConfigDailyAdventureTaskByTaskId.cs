using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CB RID: 459
	public class ConfigDailyAdventureTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0009A1B0 File Offset: 0x000983B0
		static ConfigDailyAdventureTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventureTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigDailyAdventureTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0009A1D0 File Offset: 0x000983D0
		public static void CreateStaticDefaultValue()
		{
			ConfigDailyAdventureTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDailyAdventureTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dailyadventureactivity.db"),
				new ValueTuple<string, object>("文件", "r.日常探险活动.xlsx"),
				new ValueTuple<string, object>("表名", "DailyAdventureTask"),
				new ValueTuple<string, object>("语句", "select BinData from `DailyAdventureTask` where TaskId=?")
			});
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0009A24F File Offset: 0x0009844F
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventureTaskByTaskId.LogPair = null;
			ConfigDailyAdventureTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0009A25D File Offset: 0x0009845D
		public static void Init()
		{
			ConfigDailyAdventureTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventureTaskByTaskId.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventureTask` where TaskId=?");
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0009A278 File Offset: 0x00098478
		public static DailyAdventureTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDailyAdventureTaskByTaskId.HandleId, ConfigDailyAdventureTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventureTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DailyAdventureTask?(DailyAdventureTask.GetRootAsDailyAdventureTask(configBuffer));
				}
			}
			ConfigDailyAdventureTaskByTaskId.LogPair.Clear();
			ConfigDailyAdventureTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigDailyAdventureTaskByTaskId.HandleId, 1, p0TaskId, ConfigDailyAdventureTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigDailyAdventureTaskByTaskId.HandleId, true, ConfigDailyAdventureTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDailyAdventureTaskByTaskId.HandleId, ConfigDailyAdventureTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDailyAdventureTaskByTaskId.HandleId, 0, ConfigDailyAdventureTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDailyAdventureTaskByTaskId.HandleId, ConfigDailyAdventureTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DailyAdventureTask rootAsDailyAdventureTask = DailyAdventureTask.GetRootAsDailyAdventureTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DailyAdventureTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDailyAdventureTaskByTaskId.HandleId, ConfigDailyAdventureTaskByTaskId.LogPair);
			return new DailyAdventureTask?(rootAsDailyAdventureTask);
		}

		// Token: 0x04000C71 RID: 3185
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000C72 RID: 3186
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000C73 RID: 3187
		private const string TABLE = "DailyAdventureTask";

		// Token: 0x04000C74 RID: 3188
		private const string COMMAND = "select BinData from `DailyAdventureTask` where TaskId=?";

		// Token: 0x04000C75 RID: 3189
		private const string KEY_PREFIX = "DailyAdventureTaskByTaskId";

		// Token: 0x04000C76 RID: 3190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C77 RID: 3191
		private static int HandleId;
	}
}
