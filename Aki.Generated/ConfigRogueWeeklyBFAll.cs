using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088A RID: 2186
	public class ConfigRogueWeeklyBFAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600334E RID: 13134 RVA: 0x0017F068 File Offset: 0x0017D268
		static ConfigRogueWeeklyBFAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBFAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBFAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0017F088 File Offset: 0x0017D288
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBFAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBFAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常黑石花奖励.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBF"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBF`")
			});
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x0017F107 File Offset: 0x0017D307
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBFAll.LogPair = null;
			ConfigRogueWeeklyBFAll.HandleId = 0;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0017F115 File Offset: 0x0017D315
		public static void Init()
		{
			ConfigRogueWeeklyBFAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBFAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBF`");
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x0017F130 File Offset: 0x0017D330
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyBF> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBFAll.HandleId, ConfigRogueWeeklyBFAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyBF> readOnlyList = (IReadOnlyList<RogueWeeklyBF>)ConfigCommon.GetConfig("RogueWeeklyBFAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyBF> list = new List<RogueWeeklyBF>();
			while (ConfigCommon.Step(ConfigRogueWeeklyBFAll.HandleId, false, ConfigRogueWeeklyBFAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBFAll.HandleId, 0, ConfigRogueWeeklyBFAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyBFAll.HandleId, ConfigRogueWeeklyBFAll.LogPair);
					return null;
				}
				RogueWeeklyBF rootAsRogueWeeklyBF = RogueWeeklyBF.GetRootAsRogueWeeklyBF(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyBF);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyBFAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBFAll.HandleId, ConfigRogueWeeklyBFAll.LogPair);
			return list;
		}

		// Token: 0x04003BAC RID: 15276
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BAD RID: 15277
		private const string FILE = "r.肉鸽周常黑石花奖励.xlsx";

		// Token: 0x04003BAE RID: 15278
		private const string TABLE = "RogueWeeklyBF";

		// Token: 0x04003BAF RID: 15279
		private const string COMMAND = "select BinData from `RogueWeeklyBF`";

		// Token: 0x04003BB0 RID: 15280
		private const string KEY_PREFIX = "RogueWeeklyBFAll";

		// Token: 0x04003BB1 RID: 15281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BB2 RID: 15282
		private static int HandleId;
	}
}
