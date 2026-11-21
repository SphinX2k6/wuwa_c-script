using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076E RID: 1902
	public class ConfigPreheatBonusAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x00159397 File Offset: 0x00157597
		static ConfigPreheatBonusAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatBonusAll.CreateStaticDefaultValue), new Action(ConfigPreheatBonusAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x001593B8 File Offset: 0x001575B8
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

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00159437 File Offset: 0x00157637
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatBonusAll.LogPair = null;
			ConfigPreheatBonusAll.HandleId = 0;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00159445 File Offset: 0x00157645
		public static void Init()
		{
			ConfigPreheatBonusAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatBonusAll.HandleId, "db_preheat.db", "select BinData from `PreheatBonus`");
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00159460 File Offset: 0x00157660
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

		// Token: 0x040033E8 RID: 13288
		private const string DB = "db_preheat.db";

		// Token: 0x040033E9 RID: 13289
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x040033EA RID: 13290
		private const string TABLE = "PreheatBonus";

		// Token: 0x040033EB RID: 13291
		private const string COMMAND = "select BinData from `PreheatBonus`";

		// Token: 0x040033EC RID: 13292
		private const string KEY_PREFIX = "PreheatBonusAll";

		// Token: 0x040033ED RID: 13293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033EE RID: 13294
		private static int HandleId;
	}
}
