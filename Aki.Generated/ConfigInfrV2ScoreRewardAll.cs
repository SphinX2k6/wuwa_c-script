using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000452 RID: 1106
	public class ConfigInfrV2ScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x000EFDC4 File Offset: 0x000EDFC4
		static ConfigInfrV2ScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2ScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigInfrV2ScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000EFDE4 File Offset: 0x000EDFE4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2ScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2ScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2ScoreReward`")
			});
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000EFE63 File Offset: 0x000EE063
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardAll.LogPair = null;
			ConfigInfrV2ScoreRewardAll.HandleId = 0;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000EFE71 File Offset: 0x000EE071
		public static void Init()
		{
			ConfigInfrV2ScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2ScoreRewardAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2ScoreReward`");
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000EFE8C File Offset: 0x000EE08C
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2ScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2ScoreReward> readOnlyList = (IReadOnlyList<InfrV2ScoreReward>)ConfigCommon.GetConfig("InfrV2ScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2ScoreReward> list = new List<InfrV2ScoreReward>();
			while (ConfigCommon.Step(ConfigInfrV2ScoreRewardAll.HandleId, false, ConfigInfrV2ScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2ScoreRewardAll.HandleId, 0, ConfigInfrV2ScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair);
					return null;
				}
				InfrV2ScoreReward rootAsInfrV2ScoreReward = InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(new ByteBuffer(item2));
				list.Add(rootAsInfrV2ScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2ScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04001E22 RID: 7714
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E23 RID: 7715
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E24 RID: 7716
		private const string TABLE = "InfrV2ScoreReward";

		// Token: 0x04001E25 RID: 7717
		private const string COMMAND = "select BinData from `InfrV2ScoreReward`";

		// Token: 0x04001E26 RID: 7718
		private const string KEY_PREFIX = "InfrV2ScoreRewardAll";

		// Token: 0x04001E27 RID: 7719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E28 RID: 7720
		private static int HandleId;
	}
}
