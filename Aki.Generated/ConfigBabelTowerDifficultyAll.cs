using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D3 RID: 211
	public class ConfigBabelTowerDifficultyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x00075A54 File Offset: 0x00073C54
		static ConfigBabelTowerDifficultyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00075A74 File Offset: 0x00073C74
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x00075AF3 File Offset: 0x00073CF3
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyAll.LogPair = null;
			ConfigBabelTowerDifficultyAll.HandleId = 0;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00075B01 File Offset: 0x00073D01
		public static void Init()
		{
			ConfigBabelTowerDifficultyAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty`");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00075B1C File Offset: 0x00073D1C
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

		// Token: 0x040005A9 RID: 1449
		private const string DB = "db_babeltower.db";

		// Token: 0x040005AA RID: 1450
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005AB RID: 1451
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x040005AC RID: 1452
		private const string COMMAND = "select BinData from `BabelTowerDifficulty`";

		// Token: 0x040005AD RID: 1453
		private const string KEY_PREFIX = "BabelTowerDifficultyAll";

		// Token: 0x040005AE RID: 1454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005AF RID: 1455
		private static int HandleId;
	}
}
