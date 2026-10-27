using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000293 RID: 659
	public class ConfigExploreActivityTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x000B0F8C File Offset: 0x000AF18C
		static ConfigExploreActivityTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigExploreActivityTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000B0FAC File Offset: 0x000AF1AC
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreActivityTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreActivityTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exploreactivity.db"),
				new ValueTuple<string, object>("文件", "t.探索度活动.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreActivityTask"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreActivityTask` where ActivityId=?")
			});
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000B102B File Offset: 0x000AF22B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityTaskByActivityId.LogPair = null;
			ConfigExploreActivityTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000B1039 File Offset: 0x000AF239
		public static void Init()
		{
			ConfigExploreActivityTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityTaskByActivityId.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivityTask` where ActivityId=?");
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000B1054 File Offset: 0x000AF254
		[NullableContext(2)]
		public static IReadOnlyList<ExploreActivityTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreActivityTaskByActivityId.HandleId, ConfigExploreActivityTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<ExploreActivityTask> readOnlyList = (IReadOnlyList<ExploreActivityTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigExploreActivityTaskByActivityId.LogPair.Clear();
			ConfigExploreActivityTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigExploreActivityTaskByActivityId.HandleId, 1, p0ActivityId, ConfigExploreActivityTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigExploreActivityTaskByActivityId.HandleId, ConfigExploreActivityTaskByActivityId.LogPair);
				return null;
			}
			List<ExploreActivityTask> list = new List<ExploreActivityTask>();
			while (ConfigCommon.Step(ConfigExploreActivityTaskByActivityId.HandleId, false, ConfigExploreActivityTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreActivityTaskByActivityId.HandleId, 0, ConfigExploreActivityTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreActivityTaskByActivityId.HandleId, ConfigExploreActivityTaskByActivityId.LogPair);
					return null;
				}
				ExploreActivityTask rootAsExploreActivityTask = ExploreActivityTask.GetRootAsExploreActivityTask(new ByteBuffer(item2));
				list.Add(rootAsExploreActivityTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreActivityTaskByActivityId.HandleId, ConfigExploreActivityTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x040011E9 RID: 4585
		private const string DB = "db_exploreactivity.db";

		// Token: 0x040011EA RID: 4586
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x040011EB RID: 4587
		private const string TABLE = "ExploreActivityTask";

		// Token: 0x040011EC RID: 4588
		private const string COMMAND = "select BinData from `ExploreActivityTask` where ActivityId=?";

		// Token: 0x040011ED RID: 4589
		private const string KEY_PREFIX = "ExploreActivityTaskByActivityId";

		// Token: 0x040011EE RID: 4590
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011EF RID: 4591
		private static int HandleId;
	}
}
