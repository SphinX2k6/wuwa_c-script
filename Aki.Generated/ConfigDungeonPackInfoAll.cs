using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000244 RID: 580
	public class ConfigDungeonPackInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D9C RID: 3484 RVA: 0x000A67A0 File Offset: 0x000A49A0
		static ConfigDungeonPackInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonPackInfoAll.CreateStaticDefaultValue), new Action(ConfigDungeonPackInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x000A67C0 File Offset: 0x000A49C0
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

		// Token: 0x06000D9E RID: 3486 RVA: 0x000A683F File Offset: 0x000A4A3F
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonPackInfoAll.LogPair = null;
			ConfigDungeonPackInfoAll.HandleId = 0;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000A684D File Offset: 0x000A4A4D
		public static void Init()
		{
			ConfigDungeonPackInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonPackInfoAll.HandleId, "db_dungeonpackinfo.db", "select BinData from `DungeonPackInfo`");
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000A6868 File Offset: 0x000A4A68
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

		// Token: 0x04000FC0 RID: 4032
		private const string DB = "db_dungeonpackinfo.db";

		// Token: 0x04000FC1 RID: 4033
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv";

		// Token: 0x04000FC2 RID: 4034
		private const string TABLE = "DungeonPackInfo";

		// Token: 0x04000FC3 RID: 4035
		private const string COMMAND = "select BinData from `DungeonPackInfo`";

		// Token: 0x04000FC4 RID: 4036
		private const string KEY_PREFIX = "DungeonPackInfoAll";

		// Token: 0x04000FC5 RID: 4037
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FC6 RID: 4038
		private static int HandleId;
	}
}
