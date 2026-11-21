using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000258 RID: 600
	public class ConfigDungeonPackInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x000ACA64 File Offset: 0x000AAC64
		static ConfigDungeonPackInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonPackInfoAll.CreateStaticDefaultValue), new Action(ConfigDungeonPackInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000ACA84 File Offset: 0x000AAC84
		public static void CreateStaticDefaultValue()
		{
			ConfigDungeonPackInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDungeonPackInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dungeonpackinfo.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv"),
				new ValueTuple<string, object>("表名", "DungeonPackInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `DungeonPackInfo`")
			});
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000ACB03 File Offset: 0x000AAD03
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonPackInfoAll.LogPair = null;
			ConfigDungeonPackInfoAll.HandleId = 0;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000ACB11 File Offset: 0x000AAD11
		public static void Init()
		{
			ConfigDungeonPackInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonPackInfoAll.HandleId, "db_dungeonpackinfo.db", "select BinData from `DungeonPackInfo`");
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000ACB2C File Offset: 0x000AAD2C
		[NullableContext(2)]
		public static IReadOnlyList<DungeonPackInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDungeonPackInfoAll.HandleId, ConfigDungeonPackInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DungeonPackInfo> readOnlyList = (IReadOnlyList<DungeonPackInfo>)ConfigCommon.GetConfig("DungeonPackInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DungeonPackInfo> list = new List<DungeonPackInfo>();
			while (ConfigCommon.Step(ConfigDungeonPackInfoAll.HandleId, false, ConfigDungeonPackInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDungeonPackInfoAll.HandleId, 0, ConfigDungeonPackInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDungeonPackInfoAll.HandleId, ConfigDungeonPackInfoAll.LogPair);
					return null;
				}
				DungeonPackInfo rootAsDungeonPackInfo = DungeonPackInfo.GetRootAsDungeonPackInfo(new ByteBuffer(item2));
				list.Add(rootAsDungeonPackInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DungeonPackInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDungeonPackInfoAll.HandleId, ConfigDungeonPackInfoAll.LogPair);
			return list;
		}

		// Token: 0x0400104C RID: 4172
		private const string DB = "db_dungeonpackinfo.db";

		// Token: 0x0400104D RID: 4173
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv";

		// Token: 0x0400104E RID: 4174
		private const string TABLE = "DungeonPackInfo";

		// Token: 0x0400104F RID: 4175
		private const string COMMAND = "select BinData from `DungeonPackInfo`";

		// Token: 0x04001050 RID: 4176
		private const string KEY_PREFIX = "DungeonPackInfoAll";

		// Token: 0x04001051 RID: 4177
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001052 RID: 4178
		private static int HandleId;
	}
}
