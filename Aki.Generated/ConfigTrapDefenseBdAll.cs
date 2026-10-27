using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1F RID: 2591
	public class ConfigTrapDefenseBdAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CCE RID: 15566 RVA: 0x001B1A5C File Offset: 0x001AFC5C
		static ConfigTrapDefenseBdAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x001B1A7C File Offset: 0x001AFC7C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBd"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBd`")
			});
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x001B1AFB File Offset: 0x001AFCFB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdAll.LogPair = null;
			ConfigTrapDefenseBdAll.HandleId = 0;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x001B1B09 File Offset: 0x001AFD09
		public static void Init()
		{
			ConfigTrapDefenseBdAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBd`");
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x001B1B24 File Offset: 0x001AFD24
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBd> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseBd> readOnlyList = (IReadOnlyList<TrapDefenseBd>)ConfigCommon.GetConfig("TrapDefenseBdAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseBd> list = new List<TrapDefenseBd>();
			while (ConfigCommon.Step(ConfigTrapDefenseBdAll.HandleId, false, ConfigTrapDefenseBdAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdAll.HandleId, 0, ConfigTrapDefenseBdAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair);
					return null;
				}
				TrapDefenseBd rootAsTrapDefenseBd = TrapDefenseBd.GetRootAsTrapDefenseBd(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBd);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseBdAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdAll.HandleId, ConfigTrapDefenseBdAll.LogPair);
			return list;
		}

		// Token: 0x040046BF RID: 18111
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046C0 RID: 18112
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046C1 RID: 18113
		private const string TABLE = "TrapDefenseBd";

		// Token: 0x040046C2 RID: 18114
		private const string COMMAND = "select BinData from `TrapDefenseBd`";

		// Token: 0x040046C3 RID: 18115
		private const string KEY_PREFIX = "TrapDefenseBdAll";

		// Token: 0x040046C4 RID: 18116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046C5 RID: 18117
		private static int HandleId;
	}
}
