using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000834 RID: 2100
	public class ConfigRoadBookTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600314A RID: 12618 RVA: 0x0017362B File Offset: 0x0017182B
		static ConfigRoadBookTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigRoadBookTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x0017364C File Offset: 0x0017184C
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

		// Token: 0x0600314C RID: 12620 RVA: 0x001736CB File Offset: 0x001718CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookTaskByTaskId.LogPair = null;
			ConfigRoadBookTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x001736D9 File Offset: 0x001718D9
		public static void Init()
		{
			ConfigRoadBookTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookTaskByTaskId.HandleId, "db_roadbook.db", "select BinData from `RoadBookTask` where TaskId=?");
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x001736F4 File Offset: 0x001718F4
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

		// Token: 0x04003952 RID: 14674
		private const string DB = "db_roadbook.db";

		// Token: 0x04003953 RID: 14675
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003954 RID: 14676
		private const string TABLE = "RoadBookTask";

		// Token: 0x04003955 RID: 14677
		private const string COMMAND = "select BinData from `RoadBookTask` where TaskId=?";

		// Token: 0x04003956 RID: 14678
		private const string KEY_PREFIX = "RoadBookTaskByTaskId";

		// Token: 0x04003957 RID: 14679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003958 RID: 14680
		private static int HandleId;
	}
}
