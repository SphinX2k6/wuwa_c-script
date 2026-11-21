using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0D RID: 2829
	public class ConfigTrapDefenseMonsterRiskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004262 RID: 16994 RVA: 0x001D4240 File Offset: 0x001D2440
		static ConfigTrapDefenseMonsterRiskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterRiskAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterRiskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x001D4260 File Offset: 0x001D2460
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterRiskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterRisk"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterRisk`")
			});
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x001D42DF File Offset: 0x001D24DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskAll.LogPair = null;
			ConfigTrapDefenseMonsterRiskAll.HandleId = 0;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x001D42ED File Offset: 0x001D24ED
		public static void Init()
		{
			ConfigTrapDefenseMonsterRiskAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterRiskAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterRisk`");
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x001D4308 File Offset: 0x001D2508
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseMonsterRisk> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterRiskAll.HandleId, ConfigTrapDefenseMonsterRiskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseMonsterRisk> readOnlyList = (IReadOnlyList<TrapDefenseMonsterRisk>)ConfigCommon.GetConfig("TrapDefenseMonsterRiskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseMonsterRisk> list = new List<TrapDefenseMonsterRisk>();
			while (ConfigCommon.Step(ConfigTrapDefenseMonsterRiskAll.HandleId, false, ConfigTrapDefenseMonsterRiskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterRiskAll.HandleId, 0, ConfigTrapDefenseMonsterRiskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskAll.HandleId, ConfigTrapDefenseMonsterRiskAll.LogPair);
					return null;
				}
				TrapDefenseMonsterRisk rootAsTrapDefenseMonsterRisk = TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseMonsterRisk);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseMonsterRiskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskAll.HandleId, ConfigTrapDefenseMonsterRiskAll.LogPair);
			return list;
		}

		// Token: 0x04004D41 RID: 19777
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D42 RID: 19778
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D43 RID: 19779
		private const string TABLE = "TrapDefenseMonsterRisk";

		// Token: 0x04004D44 RID: 19780
		private const string COMMAND = "select BinData from `TrapDefenseMonsterRisk`";

		// Token: 0x04004D45 RID: 19781
		private const string KEY_PREFIX = "TrapDefenseMonsterRiskAll";

		// Token: 0x04004D46 RID: 19782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D47 RID: 19783
		private static int HandleId;
	}
}
