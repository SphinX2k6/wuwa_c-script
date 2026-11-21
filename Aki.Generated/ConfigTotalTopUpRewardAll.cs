using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABC RID: 2748
	public class ConfigTotalTopUpRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600407C RID: 16508 RVA: 0x001C9760 File Offset: 0x001C7960
		static ConfigTotalTopUpRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRewardAll.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x001C9780 File Offset: 0x001C7980
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

		// Token: 0x0600407E RID: 16510 RVA: 0x001C97FF File Offset: 0x001C79FF
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRewardAll.LogPair = null;
			ConfigTotalTopUpRewardAll.HandleId = 0;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x001C980D File Offset: 0x001C7A0D
		public static void Init()
		{
			ConfigTotalTopUpRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRewardAll.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpReward`");
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x001C9828 File Offset: 0x001C7A28
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

		// Token: 0x04004B0A RID: 19210
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B0B RID: 19211
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B0C RID: 19212
		private const string TABLE = "TotalTopUpReward";

		// Token: 0x04004B0D RID: 19213
		private const string COMMAND = "select BinData from `TotalTopUpReward`";

		// Token: 0x04004B0E RID: 19214
		private const string KEY_PREFIX = "TotalTopUpRewardAll";

		// Token: 0x04004B0F RID: 19215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B10 RID: 19216
		private static int HandleId;
	}
}
