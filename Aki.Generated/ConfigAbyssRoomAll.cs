using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000029 RID: 41
	public class ConfigAbyssRoomAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0005F428 File Offset: 0x0005D628
		static ConfigAbyssRoomAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoomAll.CreateStaticDefaultValue), new Action(ConfigAbyssRoomAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0005F448 File Offset: 0x0005D648
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoomAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoomAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoom"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoom`")
			});
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0005F4C7 File Offset: 0x0005D6C7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoomAll.LogPair = null;
			ConfigAbyssRoomAll.HandleId = 0;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0005F4D5 File Offset: 0x0005D6D5
		public static void Init()
		{
			ConfigAbyssRoomAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoomAll.HandleId, "db_dangoabyss.db", "select BinData from `AbyssRoom`");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0005F4F0 File Offset: 0x0005D6F0
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoom> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoomAll.HandleId, ConfigAbyssRoomAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRoom> readOnlyList = (IReadOnlyList<AbyssRoom>)ConfigCommon.GetConfig("AbyssRoomAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRoom> list = new List<AbyssRoom>();
			while (ConfigCommon.Step(ConfigAbyssRoomAll.HandleId, false, ConfigAbyssRoomAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoomAll.HandleId, 0, ConfigAbyssRoomAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRoomAll.HandleId, ConfigAbyssRoomAll.LogPair);
					return null;
				}
				AbyssRoom rootAsAbyssRoom = AbyssRoom.GetRootAsAbyssRoom(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoom);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRoomAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRoomAll.HandleId, ConfigAbyssRoomAll.LogPair);
			return list;
		}

		// Token: 0x04000103 RID: 259
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000104 RID: 260
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000105 RID: 261
		private const string TABLE = "AbyssRoom";

		// Token: 0x04000106 RID: 262
		private const string COMMAND = "select BinData from `AbyssRoom`";

		// Token: 0x04000107 RID: 263
		private const string KEY_PREFIX = "AbyssRoomAll";

		// Token: 0x04000108 RID: 264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000109 RID: 265
		private static int HandleId;
	}
}
