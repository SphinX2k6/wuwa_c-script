using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000818 RID: 2072
	public class ConfigRoadBookTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030A2 RID: 12450 RVA: 0x0016C343 File Offset: 0x0016A543
		static ConfigRoadBookTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigRoadBookTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x0016C364 File Offset: 0x0016A564
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookTask` where TaskId=?")
			});
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0016C3E3 File Offset: 0x0016A5E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookTaskByTaskId.LogPair = null;
			ConfigRoadBookTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0016C3F1 File Offset: 0x0016A5F1
		public static void Init()
		{
			ConfigRoadBookTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookTaskByTaskId.HandleId, "db_roadbook.db", "select BinData from `RoadBookTask` where TaskId=?");
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0016C40C File Offset: 0x0016A60C
		public static RoadBookTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookTaskByTaskId.HandleId, ConfigRoadBookTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookTask?(RoadBookTask.GetRootAsRoadBookTask(configBuffer));
				}
			}
			ConfigRoadBookTaskByTaskId.LogPair.Clear();
			ConfigRoadBookTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigRoadBookTaskByTaskId.HandleId, 1, p0TaskId, ConfigRoadBookTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigRoadBookTaskByTaskId.HandleId, true, ConfigRoadBookTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookTaskByTaskId.HandleId, ConfigRoadBookTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookTaskByTaskId.HandleId, 0, ConfigRoadBookTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookTaskByTaskId.HandleId, ConfigRoadBookTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookTask rootAsRoadBookTask = RoadBookTask.GetRootAsRoadBookTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookTaskByTaskId.HandleId, ConfigRoadBookTaskByTaskId.LogPair);
			return new RoadBookTask?(rootAsRoadBookTask);
		}

		// Token: 0x0400388E RID: 14478
		private const string DB = "db_roadbook.db";

		// Token: 0x0400388F RID: 14479
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003890 RID: 14480
		private const string TABLE = "RoadBookTask";

		// Token: 0x04003891 RID: 14481
		private const string COMMAND = "select BinData from `RoadBookTask` where TaskId=?";

		// Token: 0x04003892 RID: 14482
		private const string KEY_PREFIX = "RoadBookTaskByTaskId";

		// Token: 0x04003893 RID: 14483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003894 RID: 14484
		private static int HandleId;
	}
}
