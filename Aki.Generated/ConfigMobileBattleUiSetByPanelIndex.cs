using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000542 RID: 1346
	public class ConfigMobileBattleUiSetByPanelIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x0010BFBB File Offset: 0x0010A1BB
		static ConfigMobileBattleUiSetByPanelIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMobileBattleUiSetByPanelIndex.CreateStaticDefaultValue), new Action(ConfigMobileBattleUiSetByPanelIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0010BFDC File Offset: 0x0010A1DC
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

		// Token: 0x06001F9B RID: 8091 RVA: 0x0010C05B File Offset: 0x0010A25B
		public static void ResetStaticDefaultValue()
		{
			ConfigMobileBattleUiSetByPanelIndex.LogPair = null;
			ConfigMobileBattleUiSetByPanelIndex.HandleId = 0;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0010C069 File Offset: 0x0010A269
		public static void Init()
		{
			ConfigMobileBattleUiSetByPanelIndex.HandleId = ConfigCommon.InitDataStatement(ConfigMobileBattleUiSetByPanelIndex.HandleId, "db_mobile_battle_ui_set.db", "select BinData from `MobileBattleUiSet` where PanelIndex=?");
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x0010C084 File Offset: 0x0010A284
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

		// Token: 0x040024B2 RID: 9394
		private const string DB = "db_mobile_battle_ui_set.db";

		// Token: 0x040024B3 RID: 9395
		private const string FILE = "y.移动端主界面键位配置.xlsx";

		// Token: 0x040024B4 RID: 9396
		private const string TABLE = "MobileBattleUiSet";

		// Token: 0x040024B5 RID: 9397
		private const string COMMAND = "select BinData from `MobileBattleUiSet` where PanelIndex=?";

		// Token: 0x040024B6 RID: 9398
		private const string KEY_PREFIX = "MobileBattleUiSetByPanelIndex";

		// Token: 0x040024B7 RID: 9399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024B8 RID: 9400
		private static int HandleId;
	}
}
