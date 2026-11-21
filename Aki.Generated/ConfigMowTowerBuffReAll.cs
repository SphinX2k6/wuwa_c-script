using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E8 RID: 1512
	public class ConfigMowTowerBuffReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600237D RID: 9085 RVA: 0x00125B14 File Offset: 0x00123D14
		static ConfigMowTowerBuffReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerBuffReAll.CreateStaticDefaultValue), new Action(ConfigMowTowerBuffReAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00125B34 File Offset: 0x00123D34
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

		// Token: 0x0600237F RID: 9087 RVA: 0x00125BB3 File Offset: 0x00123DB3
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerBuffReAll.LogPair = null;
			ConfigMowTowerBuffReAll.HandleId = 0;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00125BC1 File Offset: 0x00123DC1
		public static void Init()
		{
			ConfigMowTowerBuffReAll.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerBuffReAll.HandleId, "db_mowtower.db", "select BinData from `MowTowerBuffRe`");
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00125BDC File Offset: 0x00123DDC
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

		// Token: 0x0400293C RID: 10556
		private const string DB = "db_mowtower.db";

		// Token: 0x0400293D RID: 10557
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x0400293E RID: 10558
		private const string TABLE = "MowTowerBuffRe";

		// Token: 0x0400293F RID: 10559
		private const string COMMAND = "select BinData from `MowTowerBuffRe`";

		// Token: 0x04002940 RID: 10560
		private const string KEY_PREFIX = "MowTowerBuffReAll";

		// Token: 0x04002941 RID: 10561
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002942 RID: 10562
		private static int HandleId;
	}
}
