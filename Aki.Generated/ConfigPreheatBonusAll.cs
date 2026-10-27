using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000756 RID: 1878
	public class ConfigPreheatBonusAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C15 RID: 11285 RVA: 0x0015291B File Offset: 0x00150B1B
		static ConfigPreheatBonusAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatBonusAll.CreateStaticDefaultValue), new Action(ConfigPreheatBonusAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0015293C File Offset: 0x00150B3C
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatBonusAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatBonusAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatBonus"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatBonus`")
			});
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x001529BB File Offset: 0x00150BBB
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatBonusAll.LogPair = null;
			ConfigPreheatBonusAll.HandleId = 0;
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x001529C9 File Offset: 0x00150BC9
		public static void Init()
		{
			ConfigPreheatBonusAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatBonusAll.HandleId, "db_preheat.db", "select BinData from `PreheatBonus`");
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x001529E4 File Offset: 0x00150BE4
		[NullableContext(2)]
		public static IReadOnlyList<PreheatBonus> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatBonusAll.HandleId, ConfigPreheatBonusAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreheatBonus> readOnlyList = (IReadOnlyList<PreheatBonus>)ConfigCommon.GetConfig("PreheatBonusAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreheatBonus> list = new List<PreheatBonus>();
			while (ConfigCommon.Step(ConfigPreheatBonusAll.HandleId, false, ConfigPreheatBonusAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatBonusAll.HandleId, 0, ConfigPreheatBonusAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreheatBonusAll.HandleId, ConfigPreheatBonusAll.LogPair);
					return null;
				}
				PreheatBonus rootAsPreheatBonus = PreheatBonus.GetRootAsPreheatBonus(new ByteBuffer(item2));
				list.Add(rootAsPreheatBonus);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreheatBonusAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreheatBonusAll.HandleId, ConfigPreheatBonusAll.LogPair);
			return list;
		}

		// Token: 0x04003340 RID: 13120
		private const string DB = "db_preheat.db";

		// Token: 0x04003341 RID: 13121
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003342 RID: 13122
		private const string TABLE = "PreheatBonus";

		// Token: 0x04003343 RID: 13123
		private const string COMMAND = "select BinData from `PreheatBonus`";

		// Token: 0x04003344 RID: 13124
		private const string KEY_PREFIX = "PreheatBonusAll";

		// Token: 0x04003345 RID: 13125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003346 RID: 13126
		private static int HandleId;
	}
}
