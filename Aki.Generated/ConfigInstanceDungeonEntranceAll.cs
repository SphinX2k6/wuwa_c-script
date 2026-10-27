using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000444 RID: 1092
	public class ConfigInstanceDungeonEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x000EA694 File Offset: 0x000E8894
		static ConfigInstanceDungeonEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceAll.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000EA6B4 File Offset: 0x000E88B4
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonEntranceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeonEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeonEntrance`")
			});
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000EA733 File Offset: 0x000E8933
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceAll.LogPair = null;
			ConfigInstanceDungeonEntranceAll.HandleId = 0;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000EA741 File Offset: 0x000E8941
		public static void Init()
		{
			ConfigInstanceDungeonEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceAll.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance`");
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000EA75C File Offset: 0x000E895C
		[NullableContext(2)]
		public static IReadOnlyList<InstanceDungeonEntrance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonEntranceAll.HandleId, ConfigInstanceDungeonEntranceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InstanceDungeonEntrance> readOnlyList = (IReadOnlyList<InstanceDungeonEntrance>)ConfigCommon.GetConfig("InstanceDungeonEntranceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InstanceDungeonEntrance> list = new List<InstanceDungeonEntrance>();
			while (ConfigCommon.Step(ConfigInstanceDungeonEntranceAll.HandleId, false, ConfigInstanceDungeonEntranceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonEntranceAll.HandleId, 0, ConfigInstanceDungeonEntranceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInstanceDungeonEntranceAll.HandleId, ConfigInstanceDungeonEntranceAll.LogPair);
					return null;
				}
				InstanceDungeonEntrance rootAsInstanceDungeonEntrance = InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(new ByteBuffer(item2));
				list.Add(rootAsInstanceDungeonEntrance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InstanceDungeonEntranceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonEntranceAll.HandleId, ConfigInstanceDungeonEntranceAll.LogPair);
			return list;
		}

		// Token: 0x04001DC0 RID: 7616
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DC1 RID: 7617
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DC2 RID: 7618
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001DC3 RID: 7619
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance`";

		// Token: 0x04001DC4 RID: 7620
		private const string KEY_PREFIX = "InstanceDungeonEntranceAll";

		// Token: 0x04001DC5 RID: 7621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DC6 RID: 7622
		private static int HandleId;
	}
}
