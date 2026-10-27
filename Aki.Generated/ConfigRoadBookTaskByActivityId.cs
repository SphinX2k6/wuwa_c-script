using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000817 RID: 2071
	public class ConfigRoadBookTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600309C RID: 12444 RVA: 0x0016C10C File Offset: 0x0016A30C
		static ConfigRoadBookTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x0016C12C File Offset: 0x0016A32C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookTask` where ActivityId=?")
			});
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x0016C1AB File Offset: 0x0016A3AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookTaskByActivityId.LogPair = null;
			ConfigRoadBookTaskByActivityId.HandleId = 0;
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0016C1B9 File Offset: 0x0016A3B9
		public static void Init()
		{
			ConfigRoadBookTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookTaskByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookTask` where ActivityId=?");
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0016C1D4 File Offset: 0x0016A3D4
		[NullableContext(2)]
		public static IReadOnlyList<RoadBookTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookTaskByActivityId.HandleId, ConfigRoadBookTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoadBookTask> readOnlyList = (IReadOnlyList<RoadBookTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoadBookTaskByActivityId.LogPair.Clear();
			ConfigRoadBookTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoadBookTaskByActivityId.HandleId, 1, p0ActivityId, ConfigRoadBookTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoadBookTaskByActivityId.HandleId, ConfigRoadBookTaskByActivityId.LogPair);
				return null;
			}
			List<RoadBookTask> list = new List<RoadBookTask>();
			while (ConfigCommon.Step(ConfigRoadBookTaskByActivityId.HandleId, false, ConfigRoadBookTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookTaskByActivityId.HandleId, 0, ConfigRoadBookTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoadBookTaskByActivityId.HandleId, ConfigRoadBookTaskByActivityId.LogPair);
					return null;
				}
				RoadBookTask rootAsRoadBookTask = RoadBookTask.GetRootAsRoadBookTask(new ByteBuffer(item2));
				list.Add(rootAsRoadBookTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoadBookTaskByActivityId.HandleId, ConfigRoadBookTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003887 RID: 14471
		private const string DB = "db_roadbook.db";

		// Token: 0x04003888 RID: 14472
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003889 RID: 14473
		private const string TABLE = "RoadBookTask";

		// Token: 0x0400388A RID: 14474
		private const string COMMAND = "select BinData from `RoadBookTask` where ActivityId=?";

		// Token: 0x0400388B RID: 14475
		private const string KEY_PREFIX = "RoadBookTaskByActivityId";

		// Token: 0x0400388C RID: 14476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400388D RID: 14477
		private static int HandleId;
	}
}
