using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D4 RID: 1492
	public class ConfigMowTowerRewardReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002305 RID: 8965 RVA: 0x0011F850 File Offset: 0x0011DA50
		static ConfigMowTowerRewardReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerRewardReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerRewardReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0011F870 File Offset: 0x0011DA70
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerRewardReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerRewardReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerRewardRe`")
			});
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0011F8EF File Offset: 0x0011DAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerRewardReAll.LogPair = null;
			ConfigMowTowerRewardReAll.HandleId = 0;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0011F8FD File Offset: 0x0011DAFD
		public static void Init()
		{
			ConfigMowTowerRewardReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerRewardReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerRewardRe`");
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x0011F918 File Offset: 0x0011DB18
		[NullableContext(2)]
		public static IReadOnlyList<MowTowerRewardRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerRewardReAll.HandleId, ConfigMowTowerRewardReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MowTowerRewardRe> readOnlyList = (IReadOnlyList<MowTowerRewardRe>)ConfigCommon.GetConfig("MowTowerRewardReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MowTowerRewardRe> list = new List<MowTowerRewardRe>();
			while (ConfigCommon.Step(ConfigMowTowerRewardReAll.HandleId, false, ConfigMowTowerRewardReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerRewardReAll.HandleId, 0, ConfigMowTowerRewardReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMowTowerRewardReAll.HandleId, ConfigMowTowerRewardReAll.LogPair);
					return null;
				}
				MowTowerRewardRe rootAsMowTowerRewardRe = MowTowerRewardRe.GetRootAsMowTowerRewardRe(new ByteBuffer(item2));
				list.Add(rootAsMowTowerRewardRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MowTowerRewardReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMowTowerRewardReAll.HandleId, ConfigMowTowerRewardReAll.LogPair);
			return list;
		}

		// Token: 0x040028B0 RID: 10416
		private const string DB = "db_mowtower.db";

		// Token: 0x040028B1 RID: 10417
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x040028B2 RID: 10418
		private const string TABLE = "MowTowerRewardRe";

		// Token: 0x040028B3 RID: 10419
		private const string COMMAND = "select BinData from `MowTowerRewardRe`";

		// Token: 0x040028B4 RID: 10420
		private const string KEY_PREFIX = "MowTowerRewardReAll";

		// Token: 0x040028B5 RID: 10421
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028B6 RID: 10422
		private static int HandleId;
	}
}
