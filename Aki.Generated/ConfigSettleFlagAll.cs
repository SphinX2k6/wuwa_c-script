using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000907 RID: 2311
	public class ConfigSettleFlagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600363D RID: 13885 RVA: 0x0018BF30 File Offset: 0x0018A130
		static ConfigSettleFlagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSettleFlagAll.CreateStaticDefaultValue), new Action(ConfigSettleFlagAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0018BF50 File Offset: 0x0018A150
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

		// Token: 0x0600363F RID: 13887 RVA: 0x0018BFCF File Offset: 0x0018A1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigSettleFlagAll.LogPair = null;
			ConfigSettleFlagAll.HandleId = 0;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0018BFDD File Offset: 0x0018A1DD
		public static void Init()
		{
			ConfigSettleFlagAll.HandleId = ConfigCommon.InitDataStatement(ConfigSettleFlagAll.HandleId, "db_teamparkour.db", "select BinData from `SettleFlag`");
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x0018BFF8 File Offset: 0x0018A1F8
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

		// Token: 0x04003F17 RID: 16151
		private const string DB = "db_teamparkour.db";

		// Token: 0x04003F18 RID: 16152
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04003F19 RID: 16153
		private const string TABLE = "SettleFlag";

		// Token: 0x04003F1A RID: 16154
		private const string COMMAND = "select BinData from `SettleFlag`";

		// Token: 0x04003F1B RID: 16155
		private const string KEY_PREFIX = "SettleFlagAll";

		// Token: 0x04003F1C RID: 16156
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F1D RID: 16157
		private static int HandleId;
	}
}
