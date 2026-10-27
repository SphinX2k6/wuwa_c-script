using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086E RID: 2158
	public class ConfigRogueWeeklyBFAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00177D80 File Offset: 0x00175F80
		static ConfigRogueWeeklyBFAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBFAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBFAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00177DA0 File Offset: 0x00175FA0
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

		// Token: 0x060032A8 RID: 12968 RVA: 0x00177E1F File Offset: 0x0017601F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBFAll.LogPair = null;
			ConfigRogueWeeklyBFAll.HandleId = 0;
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x00177E2D File Offset: 0x0017602D
		public static void Init()
		{
			ConfigRogueWeeklyBFAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBFAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBF`");
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x00177E48 File Offset: 0x00176048
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

		// Token: 0x04003AE8 RID: 15080
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003AE9 RID: 15081
		private const string FILE = "r.肉鸽周常黑石花奖励.xlsx";

		// Token: 0x04003AEA RID: 15082
		private const string TABLE = "RogueWeeklyBF";

		// Token: 0x04003AEB RID: 15083
		private const string COMMAND = "select BinData from `RogueWeeklyBF`";

		// Token: 0x04003AEC RID: 15084
		private const string KEY_PREFIX = "RogueWeeklyBFAll";

		// Token: 0x04003AED RID: 15085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AEE RID: 15086
		private static int HandleId;
	}
}
