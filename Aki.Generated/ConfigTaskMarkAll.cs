using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A95 RID: 2709
	public class ConfigTaskMarkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F92 RID: 16274 RVA: 0x001C44E4 File Offset: 0x001C26E4
		static ConfigTaskMarkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTaskMarkAll.CreateStaticDefaultValue), new Action(ConfigTaskMarkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x001C4504 File Offset: 0x001C2704
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

		// Token: 0x06003F94 RID: 16276 RVA: 0x001C4583 File Offset: 0x001C2783
		public static void ResetStaticDefaultValue()
		{
			ConfigTaskMarkAll.LogPair = null;
			ConfigTaskMarkAll.HandleId = 0;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x001C4591 File Offset: 0x001C2791
		public static void Init()
		{
			ConfigTaskMarkAll.HandleId = ConfigCommon.InitDataStatement(ConfigTaskMarkAll.HandleId, "db_map_mark.db", "select BinData from `TaskMark`");
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x001C45AC File Offset: 0x001C27AC
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

		// Token: 0x040049F9 RID: 18937
		private const string DB = "db_map_mark.db";

		// Token: 0x040049FA RID: 18938
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040049FB RID: 18939
		private const string TABLE = "TaskMark";

		// Token: 0x040049FC RID: 18940
		private const string COMMAND = "select BinData from `TaskMark`";

		// Token: 0x040049FD RID: 18941
		private const string KEY_PREFIX = "TaskMarkAll";

		// Token: 0x040049FE RID: 18942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049FF RID: 18943
		private static int HandleId;
	}
}
