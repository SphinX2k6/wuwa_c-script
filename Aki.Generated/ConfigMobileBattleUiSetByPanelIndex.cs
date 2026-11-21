using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000558 RID: 1368
	public class ConfigMobileBattleUiSetByPanelIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x0011270F File Offset: 0x0011090F
		static ConfigMobileBattleUiSetByPanelIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMobileBattleUiSetByPanelIndex.CreateStaticDefaultValue), new Action(ConfigMobileBattleUiSetByPanelIndex.ResetStaticDefaultValue));
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00112730 File Offset: 0x00110930
		public static void CreateStaticDefaultValue()
		{
			ConfigMobileBattleUiSetByPanelIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMobileBattleUiSetByPanelIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mobile_battle_ui_set.db"),
				new ValueTuple<string, object>("文件", "y.移动端主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "MobileBattleUiSet"),
				new ValueTuple<string, object>("语句", "select BinData from `MobileBattleUiSet` where PanelIndex=?")
			});
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x001127AF File Offset: 0x001109AF
		public static void ResetStaticDefaultValue()
		{
			ConfigMobileBattleUiSetByPanelIndex.LogPair = null;
			ConfigMobileBattleUiSetByPanelIndex.HandleId = 0;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x001127BD File Offset: 0x001109BD
		public static void Init()
		{
			ConfigMobileBattleUiSetByPanelIndex.HandleId = ConfigCommon.InitDataStatement(ConfigMobileBattleUiSetByPanelIndex.HandleId, "db_mobile_battle_ui_set.db", "select BinData from `MobileBattleUiSet` where PanelIndex=?");
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x001127D8 File Offset: 0x001109D8
		[NullableContext(2)]
		public static IReadOnlyList<MobileBattleUiSet> GetConfigList(int p0PanelIndex, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMobileBattleUiSetByPanelIndex.HandleId, ConfigMobileBattleUiSetByPanelIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MobileBattleUiSetByPanelIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PanelIndex);
				IReadOnlyList<MobileBattleUiSet> readOnlyList = (IReadOnlyList<MobileBattleUiSet>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMobileBattleUiSetByPanelIndex.LogPair.Clear();
			ConfigMobileBattleUiSetByPanelIndex.LogPair.Add(new ValueTuple<string, object>("PanelIndex", p0PanelIndex));
			if (!ConfigCommon.BindInt(ConfigMobileBattleUiSetByPanelIndex.HandleId, 1, p0PanelIndex, ConfigMobileBattleUiSetByPanelIndex.LogPair))
			{
				ConfigCommon.Reset(ConfigMobileBattleUiSetByPanelIndex.HandleId, ConfigMobileBattleUiSetByPanelIndex.LogPair);
				return null;
			}
			List<MobileBattleUiSet> list = new List<MobileBattleUiSet>();
			while (ConfigCommon.Step(ConfigMobileBattleUiSetByPanelIndex.HandleId, false, ConfigMobileBattleUiSetByPanelIndex.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMobileBattleUiSetByPanelIndex.HandleId, 0, ConfigMobileBattleUiSetByPanelIndex.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMobileBattleUiSetByPanelIndex.HandleId, ConfigMobileBattleUiSetByPanelIndex.LogPair);
					return null;
				}
				MobileBattleUiSet rootAsMobileBattleUiSet = MobileBattleUiSet.GetRootAsMobileBattleUiSet(new ByteBuffer(item2));
				list.Add(rootAsMobileBattleUiSet);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MobileBattleUiSetByPanelIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PanelIndex);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMobileBattleUiSetByPanelIndex.HandleId, ConfigMobileBattleUiSetByPanelIndex.LogPair);
			return list;
		}

		// Token: 0x0400254C RID: 9548
		private const string DB = "db_mobile_battle_ui_set.db";

		// Token: 0x0400254D RID: 9549
		private const string FILE = "y.移动端主界面键位配置.xlsx";

		// Token: 0x0400254E RID: 9550
		private const string TABLE = "MobileBattleUiSet";

		// Token: 0x0400254F RID: 9551
		private const string COMMAND = "select BinData from `MobileBattleUiSet` where PanelIndex=?";

		// Token: 0x04002550 RID: 9552
		private const string KEY_PREFIX = "MobileBattleUiSetByPanelIndex";

		// Token: 0x04002551 RID: 9553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002552 RID: 9554
		private static int HandleId;
	}
}
