using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E7 RID: 2535
	public class ConfigTotalTopUpRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B7E RID: 15230 RVA: 0x001AA3CC File Offset: 0x001A85CC
		static ConfigTotalTopUpRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRewardAll.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x001AA3EC File Offset: 0x001A85EC
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpReward`")
			});
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x001AA46B File Offset: 0x001A866B
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRewardAll.LogPair = null;
			ConfigTotalTopUpRewardAll.HandleId = 0;
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x001AA479 File Offset: 0x001A8679
		public static void Init()
		{
			ConfigTotalTopUpRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRewardAll.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpReward`");
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x001AA494 File Offset: 0x001A8694
		[NullableContext(2)]
		public static IReadOnlyList<TotalTopUpReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRewardAll.HandleId, ConfigTotalTopUpRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TotalTopUpReward> readOnlyList = (IReadOnlyList<TotalTopUpReward>)ConfigCommon.GetConfig("TotalTopUpRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TotalTopUpReward> list = new List<TotalTopUpReward>();
			while (ConfigCommon.Step(ConfigTotalTopUpRewardAll.HandleId, false, ConfigTotalTopUpRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRewardAll.HandleId, 0, ConfigTotalTopUpRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTotalTopUpRewardAll.HandleId, ConfigTotalTopUpRewardAll.LogPair);
					return null;
				}
				TotalTopUpReward rootAsTotalTopUpReward = TotalTopUpReward.GetRootAsTotalTopUpReward(new ByteBuffer(item2));
				list.Add(rootAsTotalTopUpReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TotalTopUpRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRewardAll.HandleId, ConfigTotalTopUpRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004537 RID: 17719
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004538 RID: 17720
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004539 RID: 17721
		private const string TABLE = "TotalTopUpReward";

		// Token: 0x0400453A RID: 17722
		private const string COMMAND = "select BinData from `TotalTopUpReward`";

		// Token: 0x0400453B RID: 17723
		private const string KEY_PREFIX = "TotalTopUpRewardAll";

		// Token: 0x0400453C RID: 17724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400453D RID: 17725
		private static int HandleId;
	}
}
