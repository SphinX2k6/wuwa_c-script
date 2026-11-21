using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000027 RID: 39
	public class ConfigAbyssRoleSlotAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000EA RID: 234 RVA: 0x000628ED File Offset: 0x00060AED
		static ConfigAbyssRoleSlotAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleSlotAll.CreateStaticDefaultValue), new Action(ConfigAbyssRoleSlotAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0006290C File Offset: 0x00060B0C
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleSlotAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleSlotAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleSlot`")
			});
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0006298B File Offset: 0x00060B8B
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleSlotAll.LogPair = null;
			ConfigAbyssRoleSlotAll.HandleId = 0;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00062999 File Offset: 0x00060B99
		public static void Init()
		{
			ConfigAbyssRoleSlotAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleSlotAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleSlot`");
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000629B4 File Offset: 0x00060BB4
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoleSlot> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleSlotAll.HandleId, ConfigAbyssRoleSlotAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRoleSlot> readOnlyList = (IReadOnlyList<AbyssRoleSlot>)ConfigCommon.GetConfig("AbyssRoleSlotAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRoleSlot> list = new List<AbyssRoleSlot>();
			while (ConfigCommon.Step(ConfigAbyssRoleSlotAll.HandleId, false, ConfigAbyssRoleSlotAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleSlotAll.HandleId, 0, ConfigAbyssRoleSlotAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRoleSlotAll.HandleId, ConfigAbyssRoleSlotAll.LogPair);
					return null;
				}
				AbyssRoleSlot rootAsAbyssRoleSlot = AbyssRoleSlot.GetRootAsAbyssRoleSlot(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoleSlot);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRoleSlotAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRoleSlotAll.HandleId, ConfigAbyssRoleSlotAll.LogPair);
			return list;
		}

		// Token: 0x040000F5 RID: 245
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000F6 RID: 246
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000F7 RID: 247
		private const string TABLE = "AbyssRoleSlot";

		// Token: 0x040000F8 RID: 248
		private const string COMMAND = "select BinData from `AbyssRoleSlot`";

		// Token: 0x040000F9 RID: 249
		private const string KEY_PREFIX = "AbyssRoleSlotAll";

		// Token: 0x040000FA RID: 250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000FB RID: 251
		private static int HandleId;
	}
}
