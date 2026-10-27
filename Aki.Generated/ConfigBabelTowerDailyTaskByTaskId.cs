using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CE RID: 206
	public class ConfigBabelTowerDailyTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00074FAF File Offset: 0x000731AF
		static ConfigBabelTowerDailyTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDailyTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDailyTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00074FD0 File Offset: 0x000731D0
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007504F File Offset: 0x0007324F
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskByTaskId.LogPair = null;
			ConfigBabelTowerDailyTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0007505D File Offset: 0x0007325D
		public static void Init()
		{
			ConfigBabelTowerDailyTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDailyTaskByTaskId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDailyTask` where TaskId=?");
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00075078 File Offset: 0x00073278
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

		// Token: 0x04000586 RID: 1414
		private const string DB = "db_babeltower.db";

		// Token: 0x04000587 RID: 1415
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000588 RID: 1416
		private const string TABLE = "BabelTowerDailyTask";

		// Token: 0x04000589 RID: 1417
		private const string COMMAND = "select BinData from `BabelTowerDailyTask` where TaskId=?";

		// Token: 0x0400058A RID: 1418
		private const string KEY_PREFIX = "BabelTowerDailyTaskByTaskId";

		// Token: 0x0400058B RID: 1419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400058C RID: 1420
		private static int HandleId;
	}
}
