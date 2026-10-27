using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D7 RID: 215
	public class ConfigBabelTowerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00076304 File Offset: 0x00074504
		static ConfigBabelTowerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerLevelAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00076324 File Offset: 0x00074524
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerLevel`")
			});
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000763A3 File Offset: 0x000745A3
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerLevelAll.LogPair = null;
			ConfigBabelTowerLevelAll.HandleId = 0;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000763B1 File Offset: 0x000745B1
		public static void Init()
		{
			ConfigBabelTowerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerLevelAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerLevel`");
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000763CC File Offset: 0x000745CC
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerLevel> readOnlyList = (IReadOnlyList<BabelTowerLevel>)ConfigCommon.GetConfig("BabelTowerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerLevel> list = new List<BabelTowerLevel>();
			while (ConfigCommon.Step(ConfigBabelTowerLevelAll.HandleId, false, ConfigBabelTowerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerLevelAll.HandleId, 0, ConfigBabelTowerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair);
					return null;
				}
				BabelTowerLevel rootAsBabelTowerLevel = BabelTowerLevel.GetRootAsBabelTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerLevelAll.HandleId, ConfigBabelTowerLevelAll.LogPair);
			return list;
		}

		// Token: 0x040005C5 RID: 1477
		private const string DB = "db_babeltower.db";

		// Token: 0x040005C6 RID: 1478
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005C7 RID: 1479
		private const string TABLE = "BabelTowerLevel";

		// Token: 0x040005C8 RID: 1480
		private const string COMMAND = "select BinData from `BabelTowerLevel`";

		// Token: 0x040005C9 RID: 1481
		private const string KEY_PREFIX = "BabelTowerLevelAll";

		// Token: 0x040005CA RID: 1482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005CB RID: 1483
		private static int HandleId;
	}
}
