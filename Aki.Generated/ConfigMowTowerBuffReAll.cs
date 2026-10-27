using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D0 RID: 1488
	public class ConfigMowTowerBuffReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022ED RID: 8941 RVA: 0x0011F098 File Offset: 0x0011D298
		static ConfigMowTowerBuffReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerBuffReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerBuffReAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0011F0B8 File Offset: 0x0011D2B8
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerBuffReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerBuffReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerBuffRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerBuffRe`")
			});
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0011F137 File Offset: 0x0011D337
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerBuffReAll.LogPair = null;
			ConfigMowTowerBuffReAll.HandleId = 0;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0011F145 File Offset: 0x0011D345
		public static void Init()
		{
			ConfigMowTowerBuffReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerBuffReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerBuffRe`");
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0011F160 File Offset: 0x0011D360
		[NullableContext(2)]
		public static IReadOnlyList<MowTowerBuffRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerBuffReAll.HandleId, ConfigMowTowerBuffReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MowTowerBuffRe> readOnlyList = (IReadOnlyList<MowTowerBuffRe>)ConfigCommon.GetConfig("MowTowerBuffReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MowTowerBuffRe> list = new List<MowTowerBuffRe>();
			while (ConfigCommon.Step(ConfigMowTowerBuffReAll.HandleId, false, ConfigMowTowerBuffReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerBuffReAll.HandleId, 0, ConfigMowTowerBuffReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMowTowerBuffReAll.HandleId, ConfigMowTowerBuffReAll.LogPair);
					return null;
				}
				MowTowerBuffRe rootAsMowTowerBuffRe = MowTowerBuffRe.GetRootAsMowTowerBuffRe(new ByteBuffer(item2));
				list.Add(rootAsMowTowerBuffRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MowTowerBuffReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMowTowerBuffReAll.HandleId, ConfigMowTowerBuffReAll.LogPair);
			return list;
		}

		// Token: 0x04002894 RID: 10388
		private const string DB = "db_mowtower.db";

		// Token: 0x04002895 RID: 10389
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x04002896 RID: 10390
		private const string TABLE = "MowTowerBuffRe";

		// Token: 0x04002897 RID: 10391
		private const string COMMAND = "select BinData from `MowTowerBuffRe`";

		// Token: 0x04002898 RID: 10392
		private const string KEY_PREFIX = "MowTowerBuffReAll";

		// Token: 0x04002899 RID: 10393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400289A RID: 10394
		private static int HandleId;
	}
}
