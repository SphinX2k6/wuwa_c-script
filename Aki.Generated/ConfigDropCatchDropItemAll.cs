using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000235 RID: 565
	public class ConfigDropCatchDropItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x000A4848 File Offset: 0x000A2A48
		static ConfigDropCatchDropItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropItemAll.CreateStaticDefaultValue), new Action(ConfigDropCatchDropItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000A4868 File Offset: 0x000A2A68
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

		// Token: 0x06000D44 RID: 3396 RVA: 0x000A48E7 File Offset: 0x000A2AE7
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropItemAll.LogPair = null;
			ConfigDropCatchDropItemAll.HandleId = 0;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000A48F5 File Offset: 0x000A2AF5
		public static void Init()
		{
			ConfigDropCatchDropItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropItemAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropItem`");
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000A4910 File Offset: 0x000A2B10
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

		// Token: 0x04000F57 RID: 3927
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F58 RID: 3928
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F59 RID: 3929
		private const string TABLE = "DropCatchDropItem";

		// Token: 0x04000F5A RID: 3930
		private const string COMMAND = "select BinData from `DropCatchDropItem`";

		// Token: 0x04000F5B RID: 3931
		private const string KEY_PREFIX = "DropCatchDropItemAll";

		// Token: 0x04000F5C RID: 3932
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F5D RID: 3933
		private static int HandleId;
	}
}
