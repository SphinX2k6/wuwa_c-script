using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F3 RID: 2547
	public class ConfigTowerDefenceInstanceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x001ABCEF File Offset: 0x001A9EEF
		static ConfigTowerDefenceInstanceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceAll.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x001ABD10 File Offset: 0x001A9F10
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceInstanceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceInstance`")
			});
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x001ABD8F File Offset: 0x001A9F8F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceAll.LogPair = null;
			ConfigTowerDefenceInstanceAll.HandleId = 0;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001ABD9D File Offset: 0x001A9F9D
		public static void Init()
		{
			ConfigTowerDefenceInstanceAll.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceAll.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance`");
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x001ABDB8 File Offset: 0x001A9FB8
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefenceInstance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TowerDefenceInstance> readOnlyList = (IReadOnlyList<TowerDefenceInstance>)ConfigCommon.GetConfig("TowerDefenceInstanceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TowerDefenceInstance> list = new List<TowerDefenceInstance>();
			while (ConfigCommon.Step(ConfigTowerDefenceInstanceAll.HandleId, false, ConfigTowerDefenceInstanceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceInstanceAll.HandleId, 0, ConfigTowerDefenceInstanceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair);
					return null;
				}
				TowerDefenceInstance rootAsTowerDefenceInstance = TowerDefenceInstance.GetRootAsTowerDefenceInstance(new ByteBuffer(item2));
				list.Add(rootAsTowerDefenceInstance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TowerDefenceInstanceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefenceInstanceAll.HandleId, ConfigTowerDefenceInstanceAll.LogPair);
			return list;
		}

		// Token: 0x0400458B RID: 17803
		private const string DB = "db_towerdefense.db";

		// Token: 0x0400458C RID: 17804
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x0400458D RID: 17805
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x0400458E RID: 17806
		private const string COMMAND = "select BinData from `TowerDefenceInstance`";

		// Token: 0x0400458F RID: 17807
		private const string KEY_PREFIX = "TowerDefenceInstanceAll";

		// Token: 0x04004590 RID: 17808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004591 RID: 17809
		private static int HandleId;
	}
}
