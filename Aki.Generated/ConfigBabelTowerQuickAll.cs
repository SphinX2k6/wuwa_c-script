using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D9 RID: 217
	public class ConfigBabelTowerQuickAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x000766E0 File Offset: 0x000748E0
		static ConfigBabelTowerQuickAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00076700 File Offset: 0x00074900
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerQuickAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerQuickAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerQuick"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerQuick`")
			});
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0007677F File Offset: 0x0007497F
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickAll.LogPair = null;
			ConfigBabelTowerQuickAll.HandleId = 0;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0007678D File Offset: 0x0007498D
		public static void Init()
		{
			ConfigBabelTowerQuickAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick`");
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000767A8 File Offset: 0x000749A8
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerQuick> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerQuickAll.HandleId, ConfigBabelTowerQuickAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerQuick> readOnlyList = (IReadOnlyList<BabelTowerQuick>)ConfigCommon.GetConfig("BabelTowerQuickAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerQuick> list = new List<BabelTowerQuick>();
			while (ConfigCommon.Step(ConfigBabelTowerQuickAll.HandleId, false, ConfigBabelTowerQuickAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerQuickAll.HandleId, 0, ConfigBabelTowerQuickAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerQuickAll.HandleId, ConfigBabelTowerQuickAll.LogPair);
					return null;
				}
				BabelTowerQuick rootAsBabelTowerQuick = BabelTowerQuick.GetRootAsBabelTowerQuick(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerQuick);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerQuickAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerQuickAll.HandleId, ConfigBabelTowerQuickAll.LogPair);
			return list;
		}

		// Token: 0x040005D3 RID: 1491
		private const string DB = "db_babeltower.db";

		// Token: 0x040005D4 RID: 1492
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005D5 RID: 1493
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x040005D6 RID: 1494
		private const string COMMAND = "select BinData from `BabelTowerQuick`";

		// Token: 0x040005D7 RID: 1495
		private const string KEY_PREFIX = "BabelTowerQuickAll";

		// Token: 0x040005D8 RID: 1496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005D9 RID: 1497
		private static int HandleId;
	}
}
