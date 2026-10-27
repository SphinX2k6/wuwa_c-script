using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D2 RID: 1490
	public class ConfigMowTowerLevelsReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x0011F474 File Offset: 0x0011D674
		static ConfigMowTowerLevelsReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerLevelsReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerLevelsReAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0011F494 File Offset: 0x0011D694
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

		// Token: 0x060022FB RID: 8955 RVA: 0x0011F513 File Offset: 0x0011D713
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerLevelsReAll.LogPair = null;
			ConfigMowTowerLevelsReAll.HandleId = 0;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0011F521 File Offset: 0x0011D721
		public static void Init()
		{
			ConfigMowTowerLevelsReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerLevelsReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerLevelsRe`");
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0011F53C File Offset: 0x0011D73C
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

		// Token: 0x040028A2 RID: 10402
		private const string DB = "db_mowtower.db";

		// Token: 0x040028A3 RID: 10403
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x040028A4 RID: 10404
		private const string TABLE = "MowTowerLevelsRe";

		// Token: 0x040028A5 RID: 10405
		private const string COMMAND = "select BinData from `MowTowerLevelsRe`";

		// Token: 0x040028A6 RID: 10406
		private const string KEY_PREFIX = "MowTowerLevelsReAll";

		// Token: 0x040028A7 RID: 10407
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028A8 RID: 10408
		private static int HandleId;
	}
}
