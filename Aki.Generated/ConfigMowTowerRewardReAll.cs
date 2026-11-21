using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EC RID: 1516
	public class ConfigMowTowerRewardReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002395 RID: 9109 RVA: 0x001262CC File Offset: 0x001244CC
		static ConfigMowTowerRewardReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerRewardReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerRewardReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x001262EC File Offset: 0x001244EC
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

		// Token: 0x06002397 RID: 9111 RVA: 0x0012636B File Offset: 0x0012456B
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerRewardReAll.LogPair = null;
			ConfigMowTowerRewardReAll.HandleId = 0;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00126379 File Offset: 0x00124579
		public static void Init()
		{
			ConfigMowTowerRewardReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerRewardReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerRewardRe`");
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00126394 File Offset: 0x00124594
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

		// Token: 0x04002958 RID: 10584
		private const string DB = "db_mowtower.db";

		// Token: 0x04002959 RID: 10585
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x0400295A RID: 10586
		private const string TABLE = "MowTowerRewardRe";

		// Token: 0x0400295B RID: 10587
		private const string COMMAND = "select BinData from `MowTowerRewardRe`";

		// Token: 0x0400295C RID: 10588
		private const string KEY_PREFIX = "MowTowerRewardReAll";

		// Token: 0x0400295D RID: 10589
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400295E RID: 10590
		private static int HandleId;
	}
}
