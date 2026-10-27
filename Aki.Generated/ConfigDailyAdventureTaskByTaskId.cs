using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B9 RID: 441
	public class ConfigDailyAdventureTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00094278 File Offset: 0x00092478
		static ConfigDailyAdventureTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDailyAdventureTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigDailyAdventureTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00094298 File Offset: 0x00092498
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x00094317 File Offset: 0x00092517
		public static void ResetStaticDefaultValue()
		{
			ConfigDailyAdventureTaskByTaskId.LogPair = null;
			ConfigDailyAdventureTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00094325 File Offset: 0x00092525
		public static void Init()
		{
			ConfigDailyAdventureTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigDailyAdventureTaskByTaskId.HandleId, "db_dailyadventureactivity.db", "select BinData from `DailyAdventureTask` where TaskId=?");
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00094340 File Offset: 0x00092540
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

		// Token: 0x04000BF3 RID: 3059
		private const string DB = "db_dailyadventureactivity.db";

		// Token: 0x04000BF4 RID: 3060
		private const string FILE = "r.日常探险活动.xlsx";

		// Token: 0x04000BF5 RID: 3061
		private const string TABLE = "DailyAdventureTask";

		// Token: 0x04000BF6 RID: 3062
		private const string COMMAND = "select BinData from `DailyAdventureTask` where TaskId=?";

		// Token: 0x04000BF7 RID: 3063
		private const string KEY_PREFIX = "DailyAdventureTaskByTaskId";

		// Token: 0x04000BF8 RID: 3064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BF9 RID: 3065
		private static int HandleId;
	}
}
