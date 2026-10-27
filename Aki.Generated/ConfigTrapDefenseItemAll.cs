using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2E RID: 2606
	public class ConfigTrapDefenseItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D28 RID: 15656 RVA: 0x001B3AAC File Offset: 0x001B1CAC
		static ConfigTrapDefenseItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x001B3ACC File Offset: 0x001B1CCC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_商店.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseItem"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseItem`")
			});
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x001B3B4B File Offset: 0x001B1D4B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemAll.LogPair = null;
			ConfigTrapDefenseItemAll.HandleId = 0;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001B3B59 File Offset: 0x001B1D59
		public static void Init()
		{
			ConfigTrapDefenseItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem`");
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001B3B74 File Offset: 0x001B1D74
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseItemAll.HandleId, ConfigTrapDefenseItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseItem> readOnlyList = (IReadOnlyList<TrapDefenseItem>)ConfigCommon.GetConfig("TrapDefenseItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseItem> list = new List<TrapDefenseItem>();
			while (ConfigCommon.Step(ConfigTrapDefenseItemAll.HandleId, false, ConfigTrapDefenseItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseItemAll.HandleId, 0, ConfigTrapDefenseItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseItemAll.HandleId, ConfigTrapDefenseItemAll.LogPair);
					return null;
				}
				TrapDefenseItem rootAsTrapDefenseItem = TrapDefenseItem.GetRootAsTrapDefenseItem(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseItemAll.HandleId, ConfigTrapDefenseItemAll.LogPair);
			return list;
		}

		// Token: 0x04004728 RID: 18216
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004729 RID: 18217
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x0400472A RID: 18218
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x0400472B RID: 18219
		private const string COMMAND = "select BinData from `TrapDefenseItem`";

		// Token: 0x0400472C RID: 18220
		private const string KEY_PREFIX = "TrapDefenseItemAll";

		// Token: 0x0400472D RID: 18221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400472E RID: 18222
		private static int HandleId;
	}
}
