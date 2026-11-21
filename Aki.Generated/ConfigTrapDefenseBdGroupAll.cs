using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF9 RID: 2809
	public class ConfigTrapDefenseBdGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041EA RID: 16874 RVA: 0x001D18E8 File Offset: 0x001CFAE8
		static ConfigTrapDefenseBdGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001D1908 File Offset: 0x001CFB08
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdGroup`")
			});
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x001D1987 File Offset: 0x001CFB87
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupAll.LogPair = null;
			ConfigTrapDefenseBdGroupAll.HandleId = 0;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x001D1995 File Offset: 0x001CFB95
		public static void Init()
		{
			ConfigTrapDefenseBdGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup`");
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001D19B0 File Offset: 0x001CFBB0
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBdGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdGroupAll.HandleId, ConfigTrapDefenseBdGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseBdGroup> readOnlyList = (IReadOnlyList<TrapDefenseBdGroup>)ConfigCommon.GetConfig("TrapDefenseBdGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseBdGroup> list = new List<TrapDefenseBdGroup>();
			while (ConfigCommon.Step(ConfigTrapDefenseBdGroupAll.HandleId, false, ConfigTrapDefenseBdGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdGroupAll.HandleId, 0, ConfigTrapDefenseBdGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBdGroupAll.HandleId, ConfigTrapDefenseBdGroupAll.LogPair);
					return null;
				}
				TrapDefenseBdGroup rootAsTrapDefenseBdGroup = TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBdGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseBdGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdGroupAll.HandleId, ConfigTrapDefenseBdGroupAll.LogPair);
			return list;
		}

		// Token: 0x04004CB5 RID: 19637
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CB6 RID: 19638
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CB7 RID: 19639
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x04004CB8 RID: 19640
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup`";

		// Token: 0x04004CB9 RID: 19641
		private const string KEY_PREFIX = "TrapDefenseBdGroupAll";

		// Token: 0x04004CBA RID: 19642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CBB RID: 19643
		private static int HandleId;
	}
}
