using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000879 RID: 2169
	public class ConfigRogueWeeklyRoomPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x001793A8 File Offset: 0x001775A8
		static ConfigRogueWeeklyRoomPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomPoolAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x001793C8 File Offset: 0x001775C8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRoomPoolAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyRoomPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyRoomPool`")
			});
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00179447 File Offset: 0x00177647
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolAll.LogPair = null;
			ConfigRogueWeeklyRoomPoolAll.HandleId = 0;
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00179455 File Offset: 0x00177655
		public static void Init()
		{
			ConfigRogueWeeklyRoomPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomPoolAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomPool`");
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00179470 File Offset: 0x00177670
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyRoomPool> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRoomPoolAll.HandleId, ConfigRogueWeeklyRoomPoolAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyRoomPool> readOnlyList = (IReadOnlyList<RogueWeeklyRoomPool>)ConfigCommon.GetConfig("RogueWeeklyRoomPoolAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyRoomPool> list = new List<RogueWeeklyRoomPool>();
			while (ConfigCommon.Step(ConfigRogueWeeklyRoomPoolAll.HandleId, false, ConfigRogueWeeklyRoomPoolAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRoomPoolAll.HandleId, 0, ConfigRogueWeeklyRoomPoolAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyRoomPoolAll.HandleId, ConfigRogueWeeklyRoomPoolAll.LogPair);
					return null;
				}
				RogueWeeklyRoomPool rootAsRogueWeeklyRoomPool = RogueWeeklyRoomPool.GetRootAsRogueWeeklyRoomPool(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyRoomPool);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyRoomPoolAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRoomPoolAll.HandleId, ConfigRogueWeeklyRoomPoolAll.LogPair);
			return list;
		}

		// Token: 0x04003B35 RID: 15157
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B36 RID: 15158
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B37 RID: 15159
		private const string TABLE = "RogueWeeklyRoomPool";

		// Token: 0x04003B38 RID: 15160
		private const string COMMAND = "select BinData from `RogueWeeklyRoomPool`";

		// Token: 0x04003B39 RID: 15161
		private const string KEY_PREFIX = "RogueWeeklyRoomPoolAll";

		// Token: 0x04003B3A RID: 15162
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B3B RID: 15163
		private static int HandleId;
	}
}
