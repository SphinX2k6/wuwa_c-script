using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DA RID: 218
	public class ConfigBabelTowerBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0007A3A4 File Offset: 0x000785A4
		static ConfigBabelTowerBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerBuffAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0007A3C4 File Offset: 0x000785C4
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerBuff`")
			});
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0007A443 File Offset: 0x00078643
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerBuffAll.LogPair = null;
			ConfigBabelTowerBuffAll.HandleId = 0;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0007A451 File Offset: 0x00078651
		public static void Init()
		{
			ConfigBabelTowerBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerBuffAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerBuff`");
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0007A46C File Offset: 0x0007866C
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerBuff> readOnlyList = (IReadOnlyList<BabelTowerBuff>)ConfigCommon.GetConfig("BabelTowerBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerBuff> list = new List<BabelTowerBuff>();
			while (ConfigCommon.Step(ConfigBabelTowerBuffAll.HandleId, false, ConfigBabelTowerBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerBuffAll.HandleId, 0, ConfigBabelTowerBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair);
					return null;
				}
				BabelTowerBuff rootAsBabelTowerBuff = BabelTowerBuff.GetRootAsBabelTowerBuff(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair);
			return list;
		}

		// Token: 0x040005DA RID: 1498
		private const string DB = "db_babeltower.db";

		// Token: 0x040005DB RID: 1499
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005DC RID: 1500
		private const string TABLE = "BabelTowerBuff";

		// Token: 0x040005DD RID: 1501
		private const string COMMAND = "select BinData from `BabelTowerBuff`";

		// Token: 0x040005DE RID: 1502
		private const string KEY_PREFIX = "BabelTowerBuffAll";

		// Token: 0x040005DF RID: 1503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005E0 RID: 1504
		private static int HandleId;
	}
}
