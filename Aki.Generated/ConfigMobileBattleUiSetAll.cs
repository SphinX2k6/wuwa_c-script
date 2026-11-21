using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000557 RID: 1367
	public class ConfigMobileBattleUiSetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x0011257C File Offset: 0x0011077C
		static ConfigMobileBattleUiSetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMobileBattleUiSetAll.CreateStaticDefaultValue), new Action(ConfigMobileBattleUiSetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0011259C File Offset: 0x0011079C
		public static void CreateStaticDefaultValue()
		{
			ConfigMobileBattleUiSetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMobileBattleUiSetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mobile_battle_ui_set.db"),
				new ValueTuple<string, object>("文件", "y.移动端主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "MobileBattleUiSet"),
				new ValueTuple<string, object>("语句", "select BinData from `MobileBattleUiSet`")
			});
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0011261B File Offset: 0x0011081B
		public static void ResetStaticDefaultValue()
		{
			ConfigMobileBattleUiSetAll.LogPair = null;
			ConfigMobileBattleUiSetAll.HandleId = 0;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00112629 File Offset: 0x00110829
		public static void Init()
		{
			ConfigMobileBattleUiSetAll.HandleId = ConfigCommon.InitDataStatement(ConfigMobileBattleUiSetAll.HandleId, "db_mobile_battle_ui_set.db", "select BinData from `MobileBattleUiSet`");
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00112644 File Offset: 0x00110844
		[NullableContext(2)]
		public static IReadOnlyList<MobileBattleUiSet> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMobileBattleUiSetAll.HandleId, ConfigMobileBattleUiSetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MobileBattleUiSet> readOnlyList = (IReadOnlyList<MobileBattleUiSet>)ConfigCommon.GetConfig("MobileBattleUiSetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MobileBattleUiSet> list = new List<MobileBattleUiSet>();
			while (ConfigCommon.Step(ConfigMobileBattleUiSetAll.HandleId, false, ConfigMobileBattleUiSetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMobileBattleUiSetAll.HandleId, 0, ConfigMobileBattleUiSetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMobileBattleUiSetAll.HandleId, ConfigMobileBattleUiSetAll.LogPair);
					return null;
				}
				MobileBattleUiSet rootAsMobileBattleUiSet = MobileBattleUiSet.GetRootAsMobileBattleUiSet(new ByteBuffer(item2));
				list.Add(rootAsMobileBattleUiSet);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MobileBattleUiSetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMobileBattleUiSetAll.HandleId, ConfigMobileBattleUiSetAll.LogPair);
			return list;
		}

		// Token: 0x04002545 RID: 9541
		private const string DB = "db_mobile_battle_ui_set.db";

		// Token: 0x04002546 RID: 9542
		private const string FILE = "y.移动端主界面键位配置.xlsx";

		// Token: 0x04002547 RID: 9543
		private const string TABLE = "MobileBattleUiSet";

		// Token: 0x04002548 RID: 9544
		private const string COMMAND = "select BinData from `MobileBattleUiSet`";

		// Token: 0x04002549 RID: 9545
		private const string KEY_PREFIX = "MobileBattleUiSetAll";

		// Token: 0x0400254A RID: 9546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400254B RID: 9547
		private static int HandleId;
	}
}
