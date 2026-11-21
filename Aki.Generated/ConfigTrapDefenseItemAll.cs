using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B03 RID: 2819
	public class ConfigTrapDefenseItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004226 RID: 16934 RVA: 0x001D2E40 File Offset: 0x001D1040
		static ConfigTrapDefenseItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x001D2E60 File Offset: 0x001D1060
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

		// Token: 0x06004228 RID: 16936 RVA: 0x001D2EDF File Offset: 0x001D10DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemAll.LogPair = null;
			ConfigTrapDefenseItemAll.HandleId = 0;
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x001D2EED File Offset: 0x001D10ED
		public static void Init()
		{
			ConfigTrapDefenseItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem`");
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x001D2F08 File Offset: 0x001D1108
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

		// Token: 0x04004CFB RID: 19707
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CFC RID: 19708
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x04004CFD RID: 19709
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x04004CFE RID: 19710
		private const string COMMAND = "select BinData from `TrapDefenseItem`";

		// Token: 0x04004CFF RID: 19711
		private const string KEY_PREFIX = "TrapDefenseItemAll";

		// Token: 0x04004D00 RID: 19712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D01 RID: 19713
		private static int HandleId;
	}
}
