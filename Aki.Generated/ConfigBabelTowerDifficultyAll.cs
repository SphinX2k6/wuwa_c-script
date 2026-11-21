using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E2 RID: 226
	public class ConfigBabelTowerDifficultyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x0007B3B8 File Offset: 0x000795B8
		static ConfigBabelTowerDifficultyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0007B3D8 File Offset: 0x000795D8
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDifficultyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDifficulty`")
			});
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0007B457 File Offset: 0x00079657
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyAll.LogPair = null;
			ConfigBabelTowerDifficultyAll.HandleId = 0;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0007B465 File Offset: 0x00079665
		public static void Init()
		{
			ConfigBabelTowerDifficultyAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty`");
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0007B480 File Offset: 0x00079680
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerDifficulty> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDifficultyAll.HandleId, ConfigBabelTowerDifficultyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerDifficulty> readOnlyList = (IReadOnlyList<BabelTowerDifficulty>)ConfigCommon.GetConfig("BabelTowerDifficultyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerDifficulty> list = new List<BabelTowerDifficulty>();
			while (ConfigCommon.Step(ConfigBabelTowerDifficultyAll.HandleId, false, ConfigBabelTowerDifficultyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDifficultyAll.HandleId, 0, ConfigBabelTowerDifficultyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerDifficultyAll.HandleId, ConfigBabelTowerDifficultyAll.LogPair);
					return null;
				}
				BabelTowerDifficulty rootAsBabelTowerDifficulty = BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerDifficulty);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerDifficultyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerDifficultyAll.HandleId, ConfigBabelTowerDifficultyAll.LogPair);
			return list;
		}

		// Token: 0x04000612 RID: 1554
		private const string DB = "db_babeltower.db";

		// Token: 0x04000613 RID: 1555
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000614 RID: 1556
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x04000615 RID: 1557
		private const string COMMAND = "select BinData from `BabelTowerDifficulty`";

		// Token: 0x04000616 RID: 1558
		private const string KEY_PREFIX = "BabelTowerDifficultyAll";

		// Token: 0x04000617 RID: 1559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000618 RID: 1560
		private static int HandleId;
	}
}
