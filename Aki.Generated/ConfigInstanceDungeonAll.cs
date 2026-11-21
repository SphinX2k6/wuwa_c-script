using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000458 RID: 1112
	public class ConfigInstanceDungeonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A1A RID: 6682 RVA: 0x000F0A0C File Offset: 0x000EEC0C
		static ConfigInstanceDungeonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonAll.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000F0A2C File Offset: 0x000EEC2C
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

		// Token: 0x06001A1C RID: 6684 RVA: 0x000F0AAB File Offset: 0x000EECAB
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonAll.LogPair = null;
			ConfigInstanceDungeonAll.HandleId = 0;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000F0AB9 File Offset: 0x000EECB9
		public static void Init()
		{
			ConfigInstanceDungeonAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonAll.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeon`");
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000F0AD4 File Offset: 0x000EECD4
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

		// Token: 0x04001E4C RID: 7756
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E4D RID: 7757
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E4E RID: 7758
		private const string TABLE = "InstanceDungeon";

		// Token: 0x04001E4F RID: 7759
		private const string COMMAND = "select BinData from `InstanceDungeon`";

		// Token: 0x04001E50 RID: 7760
		private const string KEY_PREFIX = "InstanceDungeonAll";

		// Token: 0x04001E51 RID: 7761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E52 RID: 7762
		private static int HandleId;
	}
}
