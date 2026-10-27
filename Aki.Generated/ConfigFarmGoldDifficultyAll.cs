using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AD RID: 685
	public class ConfigFarmGoldDifficultyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001013 RID: 4115 RVA: 0x000B44F4 File Offset: 0x000B26F4
		static ConfigFarmGoldDifficultyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldDifficultyAll.CreateStaticDefaultValue), new Action(ConfigFarmGoldDifficultyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000B4514 File Offset: 0x000B2714
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

		// Token: 0x06001015 RID: 4117 RVA: 0x000B4593 File Offset: 0x000B2793
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldDifficultyAll.LogPair = null;
			ConfigFarmGoldDifficultyAll.HandleId = 0;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000B45A1 File Offset: 0x000B27A1
		public static void Init()
		{
			ConfigFarmGoldDifficultyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldDifficultyAll.HandleId, "db_farmgold.db", "select BinData from `FarmGoldDifficulty`");
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000B45BC File Offset: 0x000B27BC
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

		// Token: 0x0400129F RID: 4767
		private const string DB = "db_farmgold.db";

		// Token: 0x040012A0 RID: 4768
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012A1 RID: 4769
		private const string TABLE = "FarmGoldDifficulty";

		// Token: 0x040012A2 RID: 4770
		private const string COMMAND = "select BinData from `FarmGoldDifficulty`";

		// Token: 0x040012A3 RID: 4771
		private const string KEY_PREFIX = "FarmGoldDifficultyAll";

		// Token: 0x040012A4 RID: 4772
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012A5 RID: 4773
		private static int HandleId;
	}
}
