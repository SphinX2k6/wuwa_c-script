using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000952 RID: 2386
	public class ConfigSettleFlagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037FF RID: 14335 RVA: 0x00199150 File Offset: 0x00197350
		static ConfigSettleFlagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleFlagAll.CreateStaticDefaultValue), new Action(ConfigSettleFlagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00199170 File Offset: 0x00197370
		public static void CreateStaticDefaultValue()
		{
			ConfigSettleFlagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSettleFlagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "SettleFlag"),
				new ValueTuple<string, object>("语句", "select BinData from `SettleFlag`")
			});
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x001991EF File Offset: 0x001973EF
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleFlagAll.LogPair = null;
			ConfigSettleFlagAll.HandleId = 0;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x001991FD File Offset: 0x001973FD
		public static void Init()
		{
			ConfigSettleFlagAll.HandleId = ConfigCommon.InitDataStatement(ConfigSettleFlagAll.HandleId, "db_teamparkour.db", "select BinData from `SettleFlag`");
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00199218 File Offset: 0x00197418
		[NullableContext(2)]
		public static IReadOnlyList<SettleFlag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSettleFlagAll.HandleId, ConfigSettleFlagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SettleFlag> readOnlyList = (IReadOnlyList<SettleFlag>)ConfigCommon.GetConfig("SettleFlagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SettleFlag> list = new List<SettleFlag>();
			while (ConfigCommon.Step(ConfigSettleFlagAll.HandleId, false, ConfigSettleFlagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSettleFlagAll.HandleId, 0, ConfigSettleFlagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSettleFlagAll.HandleId, ConfigSettleFlagAll.LogPair);
					return null;
				}
				SettleFlag rootAsSettleFlag = SettleFlag.GetRootAsSettleFlag(new ByteBuffer(item2));
				list.Add(rootAsSettleFlag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SettleFlagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSettleFlagAll.HandleId, ConfigSettleFlagAll.LogPair);
			return list;
		}

		// Token: 0x04004124 RID: 16676
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004125 RID: 16677
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004126 RID: 16678
		private const string TABLE = "SettleFlag";

		// Token: 0x04004127 RID: 16679
		private const string COMMAND = "select BinData from `SettleFlag`";

		// Token: 0x04004128 RID: 16680
		private const string KEY_PREFIX = "SettleFlagAll";

		// Token: 0x04004129 RID: 16681
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400412A RID: 16682
		private static int HandleId;
	}
}
