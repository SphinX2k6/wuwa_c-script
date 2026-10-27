using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000442 RID: 1090
	public class ConfigInstanceDungeonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x000EA2B8 File Offset: 0x000E84B8
		static ConfigInstanceDungeonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonAll.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000EA2D8 File Offset: 0x000E84D8
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeon"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeon`")
			});
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000EA357 File Offset: 0x000E8557
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonAll.LogPair = null;
			ConfigInstanceDungeonAll.HandleId = 0;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000EA365 File Offset: 0x000E8565
		public static void Init()
		{
			ConfigInstanceDungeonAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonAll.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeon`");
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000EA380 File Offset: 0x000E8580
		[NullableContext(2)]
		public static IReadOnlyList<InstanceDungeon> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonAll.HandleId, ConfigInstanceDungeonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InstanceDungeon> readOnlyList = (IReadOnlyList<InstanceDungeon>)ConfigCommon.GetConfig("InstanceDungeonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InstanceDungeon> list = new List<InstanceDungeon>();
			while (ConfigCommon.Step(ConfigInstanceDungeonAll.HandleId, false, ConfigInstanceDungeonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonAll.HandleId, 0, ConfigInstanceDungeonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInstanceDungeonAll.HandleId, ConfigInstanceDungeonAll.LogPair);
					return null;
				}
				InstanceDungeon rootAsInstanceDungeon = InstanceDungeon.GetRootAsInstanceDungeon(new ByteBuffer(item2));
				list.Add(rootAsInstanceDungeon);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InstanceDungeonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonAll.HandleId, ConfigInstanceDungeonAll.LogPair);
			return list;
		}

		// Token: 0x04001DB2 RID: 7602
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DB3 RID: 7603
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DB4 RID: 7604
		private const string TABLE = "InstanceDungeon";

		// Token: 0x04001DB5 RID: 7605
		private const string COMMAND = "select BinData from `InstanceDungeon`";

		// Token: 0x04001DB6 RID: 7606
		private const string KEY_PREFIX = "InstanceDungeonAll";

		// Token: 0x04001DB7 RID: 7607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DB8 RID: 7608
		private static int HandleId;
	}
}
