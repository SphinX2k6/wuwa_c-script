using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FA RID: 1274
	public class ConfigLordGymEntranceSetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x0010249B File Offset: 0x0010069B
		static ConfigLordGymEntranceSetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetAll.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x001024BC File Offset: 0x001006BC
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceSetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceSetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntranceSet"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntranceSet`")
			});
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0010253B File Offset: 0x0010073B
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetAll.LogPair = null;
			ConfigLordGymEntranceSetAll.HandleId = 0;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00102549 File Offset: 0x00100749
		public static void Init()
		{
			ConfigLordGymEntranceSetAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetAll.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet`");
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00102564 File Offset: 0x00100764
		[NullableContext(2)]
		public static IReadOnlyList<LordGymEntranceSet> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGymEntranceSet> readOnlyList = (IReadOnlyList<LordGymEntranceSet>)ConfigCommon.GetConfig("LordGymEntranceSetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGymEntranceSet> list = new List<LordGymEntranceSet>();
			while (ConfigCommon.Step(ConfigLordGymEntranceSetAll.HandleId, false, ConfigLordGymEntranceSetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceSetAll.HandleId, 0, ConfigLordGymEntranceSetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair);
					return null;
				}
				LordGymEntranceSet rootAsLordGymEntranceSet = LordGymEntranceSet.GetRootAsLordGymEntranceSet(new ByteBuffer(item2));
				list.Add(rootAsLordGymEntranceSet);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymEntranceSetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair);
			return list;
		}

		// Token: 0x040022BA RID: 8890
		private const string DB = "db_lordgym.db";

		// Token: 0x040022BB RID: 8891
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022BC RID: 8892
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x040022BD RID: 8893
		private const string COMMAND = "select BinData from `LordGymEntranceSet`";

		// Token: 0x040022BE RID: 8894
		private const string KEY_PREFIX = "LordGymEntranceSetAll";

		// Token: 0x040022BF RID: 8895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022C0 RID: 8896
		private static int HandleId;
	}
}
