using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E8 RID: 232
	public class ConfigBabelTowerQuickAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x0007C044 File Offset: 0x0007A244
		static ConfigBabelTowerQuickAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0007C064 File Offset: 0x0007A264
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

		// Token: 0x06000573 RID: 1395 RVA: 0x0007C0E3 File Offset: 0x0007A2E3
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickAll.LogPair = null;
			ConfigBabelTowerQuickAll.HandleId = 0;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0007C0F1 File Offset: 0x0007A2F1
		public static void Init()
		{
			ConfigBabelTowerQuickAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick`");
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0007C10C File Offset: 0x0007A30C
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

		// Token: 0x0400063C RID: 1596
		private const string DB = "db_babeltower.db";

		// Token: 0x0400063D RID: 1597
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400063E RID: 1598
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x0400063F RID: 1599
		private const string COMMAND = "select BinData from `BabelTowerQuick`";

		// Token: 0x04000640 RID: 1600
		private const string KEY_PREFIX = "BabelTowerQuickAll";

		// Token: 0x04000641 RID: 1601
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000642 RID: 1602
		private static int HandleId;
	}
}
