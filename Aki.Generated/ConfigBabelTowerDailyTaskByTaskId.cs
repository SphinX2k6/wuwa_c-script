using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DD RID: 221
	public class ConfigBabelTowerDailyTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x0007A913 File Offset: 0x00078B13
		static ConfigBabelTowerDailyTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDailyTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDailyTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0007A934 File Offset: 0x00078B34
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDailyTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDailyTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDailyTask` where TaskId=?")
			});
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0007A9B3 File Offset: 0x00078BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskByTaskId.LogPair = null;
			ConfigBabelTowerDailyTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0007A9C1 File Offset: 0x00078BC1
		public static void Init()
		{
			ConfigBabelTowerDailyTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDailyTaskByTaskId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDailyTask` where TaskId=?");
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0007A9DC File Offset: 0x00078BDC
		public static BabelTowerDailyTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDailyTaskByTaskId.HandleId, ConfigBabelTowerDailyTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDailyTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDailyTask?(BabelTowerDailyTask.GetRootAsBabelTowerDailyTask(configBuffer));
				}
			}
			ConfigBabelTowerDailyTaskByTaskId.LogPair.Clear();
			ConfigBabelTowerDailyTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDailyTaskByTaskId.HandleId, 1, p0TaskId, ConfigBabelTowerDailyTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigBabelTowerDailyTaskByTaskId.HandleId, true, ConfigBabelTowerDailyTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDailyTaskByTaskId.HandleId, ConfigBabelTowerDailyTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDailyTaskByTaskId.HandleId, 0, ConfigBabelTowerDailyTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDailyTaskByTaskId.HandleId, ConfigBabelTowerDailyTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDailyTask rootAsBabelTowerDailyTask = BabelTowerDailyTask.GetRootAsBabelTowerDailyTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDailyTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDailyTaskByTaskId.HandleId, ConfigBabelTowerDailyTaskByTaskId.LogPair);
			return new BabelTowerDailyTask?(rootAsBabelTowerDailyTask);
		}

		// Token: 0x040005EF RID: 1519
		private const string DB = "db_babeltower.db";

		// Token: 0x040005F0 RID: 1520
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005F1 RID: 1521
		private const string TABLE = "BabelTowerDailyTask";

		// Token: 0x040005F2 RID: 1522
		private const string COMMAND = "select BinData from `BabelTowerDailyTask` where TaskId=?";

		// Token: 0x040005F3 RID: 1523
		private const string KEY_PREFIX = "BabelTowerDailyTaskByTaskId";

		// Token: 0x040005F4 RID: 1524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005F5 RID: 1525
		private static int HandleId;
	}
}
