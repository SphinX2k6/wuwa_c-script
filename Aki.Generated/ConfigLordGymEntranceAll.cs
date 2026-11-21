using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050C RID: 1292
	public class ConfigLordGymEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E53 RID: 7763 RVA: 0x00108394 File Offset: 0x00106594
		static ConfigLordGymEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceAll.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x001083B4 File Offset: 0x001065B4
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

		// Token: 0x06001E55 RID: 7765 RVA: 0x00108433 File Offset: 0x00106633
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceAll.LogPair = null;
			ConfigLordGymEntranceAll.HandleId = 0;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00108441 File Offset: 0x00106641
		public static void Init()
		{
			ConfigLordGymEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceAll.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance`");
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0010845C File Offset: 0x0010665C
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

		// Token: 0x04002338 RID: 9016
		private const string DB = "db_lordgym.db";

		// Token: 0x04002339 RID: 9017
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400233A RID: 9018
		private const string TABLE = "LordGymEntrance";

		// Token: 0x0400233B RID: 9019
		private const string COMMAND = "select BinData from `LordGymEntrance`";

		// Token: 0x0400233C RID: 9020
		private const string KEY_PREFIX = "LordGymEntranceAll";

		// Token: 0x0400233D RID: 9021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400233E RID: 9022
		private static int HandleId;
	}
}
