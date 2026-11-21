using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A7 RID: 679
	public class ConfigExploreActivityTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FEF RID: 4079 RVA: 0x000B7250 File Offset: 0x000B5450
		static ConfigExploreActivityTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigExploreActivityTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x000B7270 File Offset: 0x000B5470
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

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000B72EF File Offset: 0x000B54EF
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityTaskByActivityId.LogPair = null;
			ConfigExploreActivityTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000B72FD File Offset: 0x000B54FD
		public static void Init()
		{
			ConfigExploreActivityTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityTaskByActivityId.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivityTask` where ActivityId=?");
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000B7318 File Offset: 0x000B5518
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

		// Token: 0x04001275 RID: 4725
		private const string DB = "db_exploreactivity.db";

		// Token: 0x04001276 RID: 4726
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x04001277 RID: 4727
		private const string TABLE = "ExploreActivityTask";

		// Token: 0x04001278 RID: 4728
		private const string COMMAND = "select BinData from `ExploreActivityTask` where ActivityId=?";

		// Token: 0x04001279 RID: 4729
		private const string KEY_PREFIX = "ExploreActivityTaskByActivityId";

		// Token: 0x0400127A RID: 4730
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400127B RID: 4731
		private static int HandleId;
	}
}
