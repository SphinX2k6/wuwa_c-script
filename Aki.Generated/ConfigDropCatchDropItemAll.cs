using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000247 RID: 583
	public class ConfigDropCatchDropItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x000AA780 File Offset: 0x000A8980
		static ConfigDropCatchDropItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropItemAll.CreateStaticDefaultValue), new Action(ConfigDropCatchDropItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000AA7A0 File Offset: 0x000A89A0
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchDropItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchDropItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchDropItem"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchDropItem`")
			});
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000AA81F File Offset: 0x000A8A1F
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropItemAll.LogPair = null;
			ConfigDropCatchDropItemAll.HandleId = 0;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000AA82D File Offset: 0x000A8A2D
		public static void Init()
		{
			ConfigDropCatchDropItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropItemAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropItem`");
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000AA848 File Offset: 0x000A8A48
		[NullableContext(2)]
		public static IReadOnlyList<DropCatchDropItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchDropItemAll.HandleId, ConfigDropCatchDropItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DropCatchDropItem> readOnlyList = (IReadOnlyList<DropCatchDropItem>)ConfigCommon.GetConfig("DropCatchDropItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DropCatchDropItem> list = new List<DropCatchDropItem>();
			while (ConfigCommon.Step(ConfigDropCatchDropItemAll.HandleId, false, ConfigDropCatchDropItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchDropItemAll.HandleId, 0, ConfigDropCatchDropItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDropCatchDropItemAll.HandleId, ConfigDropCatchDropItemAll.LogPair);
					return null;
				}
				DropCatchDropItem rootAsDropCatchDropItem = DropCatchDropItem.GetRootAsDropCatchDropItem(new ByteBuffer(item2));
				list.Add(rootAsDropCatchDropItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DropCatchDropItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDropCatchDropItemAll.HandleId, ConfigDropCatchDropItemAll.LogPair);
			return list;
		}

		// Token: 0x04000FD5 RID: 4053
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FD6 RID: 4054
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FD7 RID: 4055
		private const string TABLE = "DropCatchDropItem";

		// Token: 0x04000FD8 RID: 4056
		private const string COMMAND = "select BinData from `DropCatchDropItem`";

		// Token: 0x04000FD9 RID: 4057
		private const string KEY_PREFIX = "DropCatchDropItemAll";

		// Token: 0x04000FDA RID: 4058
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FDB RID: 4059
		private static int HandleId;
	}
}
