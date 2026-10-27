using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EA RID: 234
	public class ConfigBattleScoreLevelConfByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00078B0C File Offset: 0x00076D0C
		static ConfigBattleScoreLevelConfByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreLevelConfByGroupId.CreateStaticDefaultValue), new Action(ConfigBattleScoreLevelConfByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00078B2C File Offset: 0x00076D2C
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

		// Token: 0x0600057F RID: 1407 RVA: 0x00078BAB File Offset: 0x00076DAB
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfByGroupId.LogPair = null;
			ConfigBattleScoreLevelConfByGroupId.HandleId = 0;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00078BB9 File Offset: 0x00076DB9
		public static void Init()
		{
			ConfigBattleScoreLevelConfByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreLevelConfByGroupId.HandleId, "db_battlescore.db", "select BinData from `BattleScoreLevelConf` where GroupId=?");
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00078BD4 File Offset: 0x00076DD4
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

		// Token: 0x0400064A RID: 1610
		private const string DB = "db_battlescore.db";

		// Token: 0x0400064B RID: 1611
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x0400064C RID: 1612
		private const string TABLE = "BattleScoreLevelConf";

		// Token: 0x0400064D RID: 1613
		private const string COMMAND = "select BinData from `BattleScoreLevelConf` where GroupId=?";

		// Token: 0x0400064E RID: 1614
		private const string KEY_PREFIX = "BattleScoreLevelConfByGroupId";

		// Token: 0x0400064F RID: 1615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000650 RID: 1616
		private static int HandleId;
	}
}
