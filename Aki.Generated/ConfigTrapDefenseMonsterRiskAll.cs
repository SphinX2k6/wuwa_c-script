using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A38 RID: 2616
	public class ConfigTrapDefenseMonsterRiskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D64 RID: 15716 RVA: 0x001B4EAC File Offset: 0x001B30AC
		static ConfigTrapDefenseMonsterRiskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterRiskAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterRiskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x001B4ECC File Offset: 0x001B30CC
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

		// Token: 0x06003D66 RID: 15718 RVA: 0x001B4F4B File Offset: 0x001B314B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskAll.LogPair = null;
			ConfigTrapDefenseMonsterRiskAll.HandleId = 0;
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x001B4F59 File Offset: 0x001B3159
		public static void Init()
		{
			ConfigTrapDefenseMonsterRiskAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterRiskAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterRisk`");
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x001B4F74 File Offset: 0x001B3174
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

		// Token: 0x0400476E RID: 18286
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400476F RID: 18287
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004770 RID: 18288
		private const string TABLE = "TrapDefenseMonsterRisk";

		// Token: 0x04004771 RID: 18289
		private const string COMMAND = "select BinData from `TrapDefenseMonsterRisk`";

		// Token: 0x04004772 RID: 18290
		private const string KEY_PREFIX = "TrapDefenseMonsterRiskAll";

		// Token: 0x04004773 RID: 18291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004774 RID: 18292
		private static int HandleId;
	}
}
