using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000895 RID: 2197
	public class ConfigRogueWeeklyRoomPoolAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003390 RID: 13200 RVA: 0x00180690 File Offset: 0x0017E890
		static ConfigRogueWeeklyRoomPoolAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomPoolAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomPoolAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x001806B0 File Offset: 0x0017E8B0
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

		// Token: 0x06003392 RID: 13202 RVA: 0x0018072F File Offset: 0x0017E92F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomPoolAll.LogPair = null;
			ConfigRogueWeeklyRoomPoolAll.HandleId = 0;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0018073D File Offset: 0x0017E93D
		public static void Init()
		{
			ConfigRogueWeeklyRoomPoolAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomPoolAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomPool`");
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00180758 File Offset: 0x0017E958
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

		// Token: 0x04003BF9 RID: 15353
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BFA RID: 15354
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BFB RID: 15355
		private const string TABLE = "RogueWeeklyRoomPool";

		// Token: 0x04003BFC RID: 15356
		private const string COMMAND = "select BinData from `RogueWeeklyRoomPool`";

		// Token: 0x04003BFD RID: 15357
		private const string KEY_PREFIX = "RogueWeeklyRoomPoolAll";

		// Token: 0x04003BFE RID: 15358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BFF RID: 15359
		private static int HandleId;
	}
}
