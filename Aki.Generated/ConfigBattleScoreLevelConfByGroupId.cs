using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F9 RID: 249
	public class ConfigBattleScoreLevelConfByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0007E470 File Offset: 0x0007C670
		static ConfigBattleScoreLevelConfByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreLevelConfByGroupId.CreateStaticDefaultValue), new Action(ConfigBattleScoreLevelConfByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0007E490 File Offset: 0x0007C690
		public static void CreateStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattleScoreLevelConfByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battlescore.db"),
				new ValueTuple<string, object>("文件", "z.战斗评分.xlsx"),
				new ValueTuple<string, object>("表名", "BattleScoreLevelConf"),
				new ValueTuple<string, object>("语句", "select BinData from `BattleScoreLevelConf` where GroupId=?")
			});
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0007E50F File Offset: 0x0007C70F
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfByGroupId.LogPair = null;
			ConfigBattleScoreLevelConfByGroupId.HandleId = 0;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0007E51D File Offset: 0x0007C71D
		public static void Init()
		{
			ConfigBattleScoreLevelConfByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreLevelConfByGroupId.HandleId, "db_battlescore.db", "select BinData from `BattleScoreLevelConf` where GroupId=?");
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0007E538 File Offset: 0x0007C738
		[NullableContext(2)]
		public static IReadOnlyList<BattleScoreLevelConf> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattleScoreLevelConfByGroupId.HandleId, ConfigBattleScoreLevelConfByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreLevelConfByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<BattleScoreLevelConf> readOnlyList = (IReadOnlyList<BattleScoreLevelConf>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBattleScoreLevelConfByGroupId.LogPair.Clear();
			ConfigBattleScoreLevelConfByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigBattleScoreLevelConfByGroupId.HandleId, 1, p0GroupId, ConfigBattleScoreLevelConfByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigBattleScoreLevelConfByGroupId.HandleId, ConfigBattleScoreLevelConfByGroupId.LogPair);
				return null;
			}
			List<BattleScoreLevelConf> list = new List<BattleScoreLevelConf>();
			while (ConfigCommon.Step(ConfigBattleScoreLevelConfByGroupId.HandleId, false, ConfigBattleScoreLevelConfByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattleScoreLevelConfByGroupId.HandleId, 0, ConfigBattleScoreLevelConfByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBattleScoreLevelConfByGroupId.HandleId, ConfigBattleScoreLevelConfByGroupId.LogPair);
					return null;
				}
				BattleScoreLevelConf rootAsBattleScoreLevelConf = BattleScoreLevelConf.GetRootAsBattleScoreLevelConf(new ByteBuffer(item2));
				list.Add(rootAsBattleScoreLevelConf);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreLevelConfByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBattleScoreLevelConfByGroupId.HandleId, ConfigBattleScoreLevelConfByGroupId.LogPair);
			return list;
		}

		// Token: 0x040006B3 RID: 1715
		private const string DB = "db_battlescore.db";

		// Token: 0x040006B4 RID: 1716
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x040006B5 RID: 1717
		private const string TABLE = "BattleScoreLevelConf";

		// Token: 0x040006B6 RID: 1718
		private const string COMMAND = "select BinData from `BattleScoreLevelConf` where GroupId=?";

		// Token: 0x040006B7 RID: 1719
		private const string KEY_PREFIX = "BattleScoreLevelConfByGroupId";

		// Token: 0x040006B8 RID: 1720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006B9 RID: 1721
		private static int HandleId;
	}
}
