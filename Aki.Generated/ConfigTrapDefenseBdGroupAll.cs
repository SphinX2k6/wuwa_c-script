using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A24 RID: 2596
	public class ConfigTrapDefenseBdGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CEC RID: 15596 RVA: 0x001B2554 File Offset: 0x001B0754
		static ConfigTrapDefenseBdGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x001B2574 File Offset: 0x001B0774
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

		// Token: 0x06003CEE RID: 15598 RVA: 0x001B25F3 File Offset: 0x001B07F3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupAll.LogPair = null;
			ConfigTrapDefenseBdGroupAll.HandleId = 0;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x001B2601 File Offset: 0x001B0801
		public static void Init()
		{
			ConfigTrapDefenseBdGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup`");
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x001B261C File Offset: 0x001B081C
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

		// Token: 0x040046E2 RID: 18146
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046E3 RID: 18147
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046E4 RID: 18148
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x040046E5 RID: 18149
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup`";

		// Token: 0x040046E6 RID: 18150
		private const string KEY_PREFIX = "TrapDefenseBdGroupAll";

		// Token: 0x040046E7 RID: 18151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046E8 RID: 18152
		private static int HandleId;
	}
}
