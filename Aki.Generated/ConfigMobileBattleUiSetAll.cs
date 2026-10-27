using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000541 RID: 1345
	public class ConfigMobileBattleUiSetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F93 RID: 8083 RVA: 0x0010BE28 File Offset: 0x0010A028
		static ConfigMobileBattleUiSetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMobileBattleUiSetAll.CreateStaticDefaultValue), new Action(ConfigMobileBattleUiSetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0010BE48 File Offset: 0x0010A048
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

		// Token: 0x06001F95 RID: 8085 RVA: 0x0010BEC7 File Offset: 0x0010A0C7
		public static void ResetStaticDefaultValue()
		{
			ConfigMobileBattleUiSetAll.LogPair = null;
			ConfigMobileBattleUiSetAll.HandleId = 0;
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0010BED5 File Offset: 0x0010A0D5
		public static void Init()
		{
			ConfigMobileBattleUiSetAll.HandleId = ConfigCommon.InitDataStatement(ConfigMobileBattleUiSetAll.HandleId, "db_mobile_battle_ui_set.db", "select BinData from `MobileBattleUiSet`");
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x0010BEF0 File Offset: 0x0010A0F0
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

		// Token: 0x040024AB RID: 9387
		private const string DB = "db_mobile_battle_ui_set.db";

		// Token: 0x040024AC RID: 9388
		private const string FILE = "y.移动端主界面键位配置.xlsx";

		// Token: 0x040024AD RID: 9389
		private const string TABLE = "MobileBattleUiSet";

		// Token: 0x040024AE RID: 9390
		private const string COMMAND = "select BinData from `MobileBattleUiSet`";

		// Token: 0x040024AF RID: 9391
		private const string KEY_PREFIX = "MobileBattleUiSetAll";

		// Token: 0x040024B0 RID: 9392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024B1 RID: 9393
		private static int HandleId;
	}
}
