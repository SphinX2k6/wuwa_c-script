using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C2 RID: 706
	public class ConfigFarmGoldDifficultyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001091 RID: 4241 RVA: 0x000BAA00 File Offset: 0x000B8C00
		static ConfigFarmGoldDifficultyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldDifficultyAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldDifficultyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000BAA20 File Offset: 0x000B8C20
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldDifficultyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldDifficulty`")
			});
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000BAA9F File Offset: 0x000B8C9F
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyAll.LogPair = null;
			ConfigFarmGoldDifficultyAll.HandleId = 0;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000BAAAD File Offset: 0x000B8CAD
		public static void Init()
		{
			ConfigFarmGoldDifficultyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldDifficultyAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldDifficulty`");
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000BAAC8 File Offset: 0x000B8CC8
		[NullableContext(2)]
		public static IReadOnlyList<FarmGoldDifficulty> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldDifficultyAll.HandleId, ConfigFarmGoldDifficultyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FarmGoldDifficulty> readOnlyList = (IReadOnlyList<FarmGoldDifficulty>)ConfigCommon.GetConfig("FarmGoldDifficultyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FarmGoldDifficulty> list = new List<FarmGoldDifficulty>();
			while (ConfigCommon.Step(ConfigFarmGoldDifficultyAll.HandleId, false, ConfigFarmGoldDifficultyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldDifficultyAll.HandleId, 0, ConfigFarmGoldDifficultyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFarmGoldDifficultyAll.HandleId, ConfigFarmGoldDifficultyAll.LogPair);
					return null;
				}
				FarmGoldDifficulty rootAsFarmGoldDifficulty = FarmGoldDifficulty.GetRootAsFarmGoldDifficulty(new ByteBuffer(item2));
				list.Add(rootAsFarmGoldDifficulty);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FarmGoldDifficultyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFarmGoldDifficultyAll.HandleId, ConfigFarmGoldDifficultyAll.LogPair);
			return list;
		}

		// Token: 0x04001332 RID: 4914
		private const string DB = "db_farmgold.db";

		// Token: 0x04001333 RID: 4915
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001334 RID: 4916
		private const string TABLE = "FarmGoldDifficulty";

		// Token: 0x04001335 RID: 4917
		private const string COMMAND = "select BinData from `FarmGoldDifficulty`";

		// Token: 0x04001336 RID: 4918
		private const string KEY_PREFIX = "FarmGoldDifficultyAll";

		// Token: 0x04001337 RID: 4919
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001338 RID: 4920
		private static int HandleId;
	}
}
