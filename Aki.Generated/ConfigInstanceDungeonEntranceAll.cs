using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045A RID: 1114
	public class ConfigInstanceDungeonEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x000F0DE8 File Offset: 0x000EEFE8
		static ConfigInstanceDungeonEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceAll.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000F0E08 File Offset: 0x000EF008
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

		// Token: 0x06001A28 RID: 6696 RVA: 0x000F0E87 File Offset: 0x000EF087
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceAll.LogPair = null;
			ConfigInstanceDungeonEntranceAll.HandleId = 0;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000F0E95 File Offset: 0x000EF095
		public static void Init()
		{
			ConfigInstanceDungeonEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceAll.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance`");
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000F0EB0 File Offset: 0x000EF0B0
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

		// Token: 0x04001E5A RID: 7770
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E5B RID: 7771
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E5C RID: 7772
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001E5D RID: 7773
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance`";

		// Token: 0x04001E5E RID: 7774
		private const string KEY_PREFIX = "InstanceDungeonEntranceAll";

		// Token: 0x04001E5F RID: 7775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E60 RID: 7776
		private static int HandleId;
	}
}
