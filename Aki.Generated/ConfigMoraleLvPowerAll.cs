using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056A RID: 1386
	public class ConfigMoraleLvPowerAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002089 RID: 8329 RVA: 0x001114E0 File Offset: 0x0010F6E0
		static ConfigMoraleLvPowerAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLvPowerAll.CreateStaticDefaultValue), new Action(ConfigMoraleLvPowerAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00111500 File Offset: 0x0010F700
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

		// Token: 0x0600208B RID: 8331 RVA: 0x0011157F File Offset: 0x0010F77F
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLvPowerAll.LogPair = null;
			ConfigMoraleLvPowerAll.HandleId = 0;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x0011158D File Offset: 0x0010F78D
		public static void Init()
		{
			ConfigMoraleLvPowerAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLvPowerAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleLvPower`");
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x001115A8 File Offset: 0x0010F7A8
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

		// Token: 0x040025CA RID: 9674
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025CB RID: 9675
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025CC RID: 9676
		private const string TABLE = "MoraleLvPower";

		// Token: 0x040025CD RID: 9677
		private const string COMMAND = "select BinData from `MoraleLvPower`";

		// Token: 0x040025CE RID: 9678
		private const string KEY_PREFIX = "MoraleLvPowerAll";

		// Token: 0x040025CF RID: 9679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025D0 RID: 9680
		private static int HandleId;
	}
}
