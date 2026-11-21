using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000833 RID: 2099
	public class ConfigRoadBookTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003144 RID: 12612 RVA: 0x001733F4 File Offset: 0x001715F4
		static ConfigRoadBookTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x00173414 File Offset: 0x00171614
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

		// Token: 0x06003146 RID: 12614 RVA: 0x00173493 File Offset: 0x00171693
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookTaskByActivityId.LogPair = null;
			ConfigRoadBookTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x001734A1 File Offset: 0x001716A1
		public static void Init()
		{
			ConfigRoadBookTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookTaskByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookTask` where ActivityId=?");
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x001734BC File Offset: 0x001716BC
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

		// Token: 0x0400394B RID: 14667
		private const string DB = "db_roadbook.db";

		// Token: 0x0400394C RID: 14668
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400394D RID: 14669
		private const string TABLE = "RoadBookTask";

		// Token: 0x0400394E RID: 14670
		private const string COMMAND = "select BinData from `RoadBookTask` where ActivityId=?";

		// Token: 0x0400394F RID: 14671
		private const string KEY_PREFIX = "RoadBookTaskByActivityId";

		// Token: 0x04003950 RID: 14672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003951 RID: 14673
		private static int HandleId;
	}
}
