using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EA RID: 1514
	public class ConfigMowTowerLevelsReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x00125EF0 File Offset: 0x001240F0
		static ConfigMowTowerLevelsReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerLevelsReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerLevelsReAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00125F10 File Offset: 0x00124110
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerLevelsReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerLevelsReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerLevelsRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerLevelsRe`")
			});
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00125F8F File Offset: 0x0012418F
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerLevelsReAll.LogPair = null;
			ConfigMowTowerLevelsReAll.HandleId = 0;
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00125F9D File Offset: 0x0012419D
		public static void Init()
		{
			ConfigMowTowerLevelsReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerLevelsReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerLevelsRe`");
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00125FB8 File Offset: 0x001241B8
		[NullableContext(2)]
		public static IReadOnlyList<MowTowerLevelsRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerLevelsReAll.HandleId, ConfigMowTowerLevelsReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MowTowerLevelsRe> readOnlyList = (IReadOnlyList<MowTowerLevelsRe>)ConfigCommon.GetConfig("MowTowerLevelsReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MowTowerLevelsRe> list = new List<MowTowerLevelsRe>();
			while (ConfigCommon.Step(ConfigMowTowerLevelsReAll.HandleId, false, ConfigMowTowerLevelsReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerLevelsReAll.HandleId, 0, ConfigMowTowerLevelsReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMowTowerLevelsReAll.HandleId, ConfigMowTowerLevelsReAll.LogPair);
					return null;
				}
				MowTowerLevelsRe rootAsMowTowerLevelsRe = MowTowerLevelsRe.GetRootAsMowTowerLevelsRe(new ByteBuffer(item2));
				list.Add(rootAsMowTowerLevelsRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MowTowerLevelsReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMowTowerLevelsReAll.HandleId, ConfigMowTowerLevelsReAll.LogPair);
			return list;
		}

		// Token: 0x0400294A RID: 10570
		private const string DB = "db_mowtower.db";

		// Token: 0x0400294B RID: 10571
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x0400294C RID: 10572
		private const string TABLE = "MowTowerLevelsRe";

		// Token: 0x0400294D RID: 10573
		private const string COMMAND = "select BinData from `MowTowerLevelsRe`";

		// Token: 0x0400294E RID: 10574
		private const string KEY_PREFIX = "MowTowerLevelsReAll";

		// Token: 0x0400294F RID: 10575
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002950 RID: 10576
		private static int HandleId;
	}
}
