using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B1 RID: 689
	public class ConfigFarmGoldScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x000B4D60 File Offset: 0x000B2F60
		static ConfigFarmGoldScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000B4D80 File Offset: 0x000B2F80
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldScoreAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldScoreAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldScore"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldScore`")
			});
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x000B4DFF File Offset: 0x000B2FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreAll.LogPair = null;
			ConfigFarmGoldScoreAll.HandleId = 0;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000B4E0D File Offset: 0x000B300D
		public static void Init()
		{
			ConfigFarmGoldScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore`");
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000B4E28 File Offset: 0x000B3028
		[NullableContext(2)]
		public static IReadOnlyList<FarmGoldScore> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldScoreAll.HandleId, ConfigFarmGoldScoreAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FarmGoldScore> readOnlyList = (IReadOnlyList<FarmGoldScore>)ConfigCommon.GetConfig("FarmGoldScoreAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FarmGoldScore> list = new List<FarmGoldScore>();
			while (ConfigCommon.Step(ConfigFarmGoldScoreAll.HandleId, false, ConfigFarmGoldScoreAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldScoreAll.HandleId, 0, ConfigFarmGoldScoreAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFarmGoldScoreAll.HandleId, ConfigFarmGoldScoreAll.LogPair);
					return null;
				}
				FarmGoldScore rootAsFarmGoldScore = FarmGoldScore.GetRootAsFarmGoldScore(new ByteBuffer(item2));
				list.Add(rootAsFarmGoldScore);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FarmGoldScoreAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFarmGoldScoreAll.HandleId, ConfigFarmGoldScoreAll.LogPair);
			return list;
		}

		// Token: 0x040012BB RID: 4795
		private const string DB = "db_farmgold.db";

		// Token: 0x040012BC RID: 4796
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012BD RID: 4797
		private const string TABLE = "FarmGoldScore";

		// Token: 0x040012BE RID: 4798
		private const string COMMAND = "select BinData from `FarmGoldScore`";

		// Token: 0x040012BF RID: 4799
		private const string KEY_PREFIX = "FarmGoldScoreAll";

		// Token: 0x040012C0 RID: 4800
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012C1 RID: 4801
		private static int HandleId;
	}
}
