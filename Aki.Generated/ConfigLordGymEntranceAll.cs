using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F6 RID: 1270
	public class ConfigLordGymEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x00101C40 File Offset: 0x000FFE40
		static ConfigLordGymEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceAll.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00101C60 File Offset: 0x000FFE60
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntrance`")
			});
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00101CDF File Offset: 0x000FFEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceAll.LogPair = null;
			ConfigLordGymEntranceAll.HandleId = 0;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00101CED File Offset: 0x000FFEED
		public static void Init()
		{
			ConfigLordGymEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceAll.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance`");
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00101D08 File Offset: 0x000FFF08
		[NullableContext(2)]
		public static IReadOnlyList<LordGymEntrance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceAll.HandleId, ConfigLordGymEntranceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGymEntrance> readOnlyList = (IReadOnlyList<LordGymEntrance>)ConfigCommon.GetConfig("LordGymEntranceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGymEntrance> list = new List<LordGymEntrance>();
			while (ConfigCommon.Step(ConfigLordGymEntranceAll.HandleId, false, ConfigLordGymEntranceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceAll.HandleId, 0, ConfigLordGymEntranceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymEntranceAll.HandleId, ConfigLordGymEntranceAll.LogPair);
					return null;
				}
				LordGymEntrance rootAsLordGymEntrance = LordGymEntrance.GetRootAsLordGymEntrance(new ByteBuffer(item2));
				list.Add(rootAsLordGymEntrance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymEntranceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceAll.HandleId, ConfigLordGymEntranceAll.LogPair);
			return list;
		}

		// Token: 0x0400229E RID: 8862
		private const string DB = "db_lordgym.db";

		// Token: 0x0400229F RID: 8863
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022A0 RID: 8864
		private const string TABLE = "LordGymEntrance";

		// Token: 0x040022A1 RID: 8865
		private const string COMMAND = "select BinData from `LordGymEntrance`";

		// Token: 0x040022A2 RID: 8866
		private const string KEY_PREFIX = "LordGymEntranceAll";

		// Token: 0x040022A3 RID: 8867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022A4 RID: 8868
		private static int HandleId;
	}
}
