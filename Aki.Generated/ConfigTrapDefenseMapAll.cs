using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B06 RID: 2822
	public class ConfigTrapDefenseMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004238 RID: 16952 RVA: 0x001D3464 File Offset: 0x001D1664
		static ConfigTrapDefenseMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMapAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001D3484 File Offset: 0x001D1684
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMap"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMap`")
			});
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x001D3503 File Offset: 0x001D1703
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMapAll.LogPair = null;
			ConfigTrapDefenseMapAll.HandleId = 0;
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x001D3511 File Offset: 0x001D1711
		public static void Init()
		{
			ConfigTrapDefenseMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMapAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMap`");
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x001D352C File Offset: 0x001D172C
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMap> readOnlyList = (IReadOnlyList<TrapDefenseMap>)ConfigCommon.GetConfig("TrapDefenseMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMap> list = new List<TrapDefenseMap>();
			while (ConfigCommon.Step(ConfigTrapDefenseMapAll.HandleId, false, ConfigTrapDefenseMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMapAll.HandleId, 0, ConfigTrapDefenseMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair);
					return null;
				}
				TrapDefenseMap rootAsTrapDefenseMap = TrapDefenseMap.GetRootAsTrapDefenseMap(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMapAll.HandleId, ConfigTrapDefenseMapAll.LogPair);
			return list;
		}

		// Token: 0x04004D10 RID: 19728
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D11 RID: 19729
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D12 RID: 19730
		private const string TABLE = "TrapDefenseMap";

		// Token: 0x04004D13 RID: 19731
		private const string COMMAND = "select BinData from `TrapDefenseMap`";

		// Token: 0x04004D14 RID: 19732
		private const string KEY_PREFIX = "TrapDefenseMapAll";

		// Token: 0x04004D15 RID: 19733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D16 RID: 19734
		private static int HandleId;
	}
}
