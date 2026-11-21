using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C6 RID: 710
	public class ConfigFarmGoldScoreAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010A9 RID: 4265 RVA: 0x000BB26C File Offset: 0x000B946C
		static ConfigFarmGoldScoreAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000BB28C File Offset: 0x000B948C
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

		// Token: 0x060010AB RID: 4267 RVA: 0x000BB30B File Offset: 0x000B950B
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreAll.LogPair = null;
			ConfigFarmGoldScoreAll.HandleId = 0;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000BB319 File Offset: 0x000B9519
		public static void Init()
		{
			ConfigFarmGoldScoreAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore`");
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000BB334 File Offset: 0x000B9534
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

		// Token: 0x0400134E RID: 4942
		private const string DB = "db_farmgold.db";

		// Token: 0x0400134F RID: 4943
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001350 RID: 4944
		private const string TABLE = "FarmGoldScore";

		// Token: 0x04001351 RID: 4945
		private const string COMMAND = "select BinData from `FarmGoldScore`";

		// Token: 0x04001352 RID: 4946
		private const string KEY_PREFIX = "FarmGoldScoreAll";

		// Token: 0x04001353 RID: 4947
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001354 RID: 4948
		private static int HandleId;
	}
}
