using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C0 RID: 2496
	public class ConfigTaskMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A94 RID: 14996 RVA: 0x001A5150 File Offset: 0x001A3350
		static ConfigTaskMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTaskMarkAll.CreateStaticDefaultValue), new Action(ConfigTaskMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x001A5170 File Offset: 0x001A3370
		public static void CreateStaticDefaultValue()
		{
			ConfigTaskMarkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTaskMarkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "TaskMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TaskMark`")
			});
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x001A51EF File Offset: 0x001A33EF
		public static void ResetStaticDefaultValue()
		{
			ConfigTaskMarkAll.LogPair = null;
			ConfigTaskMarkAll.HandleId = 0;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x001A51FD File Offset: 0x001A33FD
		public static void Init()
		{
			ConfigTaskMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigTaskMarkAll.HandleId, "db_map_mark.db", "select BinData from `TaskMark`");
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001A5218 File Offset: 0x001A3418
		[NullableContext(2)]
		public static IReadOnlyList<TaskMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTaskMarkAll.HandleId, ConfigTaskMarkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TaskMark> readOnlyList = (IReadOnlyList<TaskMark>)ConfigCommon.GetConfig("TaskMarkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TaskMark> list = new List<TaskMark>();
			while (ConfigCommon.Step(ConfigTaskMarkAll.HandleId, false, ConfigTaskMarkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTaskMarkAll.HandleId, 0, ConfigTaskMarkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTaskMarkAll.HandleId, ConfigTaskMarkAll.LogPair);
					return null;
				}
				TaskMark rootAsTaskMark = TaskMark.GetRootAsTaskMark(new ByteBuffer(item2));
				list.Add(rootAsTaskMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TaskMarkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTaskMarkAll.HandleId, ConfigTaskMarkAll.LogPair);
			return list;
		}

		// Token: 0x04004426 RID: 17446
		private const string DB = "db_map_mark.db";

		// Token: 0x04004427 RID: 17447
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004428 RID: 17448
		private const string TABLE = "TaskMark";

		// Token: 0x04004429 RID: 17449
		private const string COMMAND = "select BinData from `TaskMark`";

		// Token: 0x0400442A RID: 17450
		private const string KEY_PREFIX = "TaskMarkAll";

		// Token: 0x0400442B RID: 17451
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400442C RID: 17452
		private static int HandleId;
	}
}
