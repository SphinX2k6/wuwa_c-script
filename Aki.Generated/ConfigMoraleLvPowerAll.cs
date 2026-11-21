using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000580 RID: 1408
	public class ConfigMoraleLvPowerAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x00117C34 File Offset: 0x00115E34
		static ConfigMoraleLvPowerAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLvPowerAll.CreateStaticDefaultValue), new Action(ConfigMoraleLvPowerAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00117C54 File Offset: 0x00115E54
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLvPowerAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLvPowerAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLvPower"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLvPower`")
			});
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00117CD3 File Offset: 0x00115ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLvPowerAll.LogPair = null;
			ConfigMoraleLvPowerAll.HandleId = 0;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00117CE1 File Offset: 0x00115EE1
		public static void Init()
		{
			ConfigMoraleLvPowerAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLvPowerAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleLvPower`");
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00117CFC File Offset: 0x00115EFC
		[NullableContext(2)]
		public static IReadOnlyList<MoraleLvPower> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLvPowerAll.HandleId, ConfigMoraleLvPowerAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleLvPower> readOnlyList = (IReadOnlyList<MoraleLvPower>)ConfigCommon.GetConfig("MoraleLvPowerAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleLvPower> list = new List<MoraleLvPower>();
			while (ConfigCommon.Step(ConfigMoraleLvPowerAll.HandleId, false, ConfigMoraleLvPowerAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLvPowerAll.HandleId, 0, ConfigMoraleLvPowerAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleLvPowerAll.HandleId, ConfigMoraleLvPowerAll.LogPair);
					return null;
				}
				MoraleLvPower rootAsMoraleLvPower = MoraleLvPower.GetRootAsMoraleLvPower(new ByteBuffer(item2));
				list.Add(rootAsMoraleLvPower);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleLvPowerAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleLvPowerAll.HandleId, ConfigMoraleLvPowerAll.LogPair);
			return list;
		}

		// Token: 0x04002664 RID: 9828
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002665 RID: 9829
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002666 RID: 9830
		private const string TABLE = "MoraleLvPower";

		// Token: 0x04002667 RID: 9831
		private const string COMMAND = "select BinData from `MoraleLvPower`";

		// Token: 0x04002668 RID: 9832
		private const string KEY_PREFIX = "MoraleLvPowerAll";

		// Token: 0x04002669 RID: 9833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400266A RID: 9834
		private static int HandleId;
	}
}
