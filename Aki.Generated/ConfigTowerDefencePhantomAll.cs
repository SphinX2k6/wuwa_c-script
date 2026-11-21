using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACD RID: 2765
	public class ConfigTowerDefencePhantomAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040E2 RID: 16610 RVA: 0x001CBA84 File Offset: 0x001C9C84
		static ConfigTowerDefencePhantomAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomAll.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomAll.ResetStaticDefaultValue));
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x001CBAA4 File Offset: 0x001C9CA4
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantom`")
			});
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x001CBB23 File Offset: 0x001C9D23
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomAll.LogPair = null;
			ConfigTowerDefencePhantomAll.HandleId = 0;
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x001CBB31 File Offset: 0x001C9D31
		public static void Init()
		{
			ConfigTowerDefencePhantomAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantom`");
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x001CBB4C File Offset: 0x001C9D4C
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefencePhantom> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefencePhantom> readOnlyList = (IReadOnlyList<TowerDefencePhantom>)ConfigCommon.GetConfig("TowerDefencePhantomAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefencePhantom> list = new List<TowerDefencePhantom>();
			while (ConfigCommon.Step(ConfigTowerDefencePhantomAll.HandleId, false, ConfigTowerDefencePhantomAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomAll.HandleId, 0, ConfigTowerDefencePhantomAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair);
					return null;
				}
				TowerDefencePhantom rootAsTowerDefencePhantom = TowerDefencePhantom.GetRootAsTowerDefencePhantom(new ByteBuffer(item2));
				list.Add(rootAsTowerDefencePhantom);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefencePhantomAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomAll.HandleId, ConfigTowerDefencePhantomAll.LogPair);
			return list;
		}

		// Token: 0x04004B81 RID: 19329
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B82 RID: 19330
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B83 RID: 19331
		private const string TABLE = "TowerDefencePhantom";

		// Token: 0x04004B84 RID: 19332
		private const string COMMAND = "select BinData from `TowerDefencePhantom`";

		// Token: 0x04004B85 RID: 19333
		private const string KEY_PREFIX = "TowerDefencePhantomAll";

		// Token: 0x04004B86 RID: 19334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B87 RID: 19335
		private static int HandleId;
	}
}
