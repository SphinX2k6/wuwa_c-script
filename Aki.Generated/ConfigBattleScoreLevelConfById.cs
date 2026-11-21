using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FA RID: 250
	public class ConfigBattleScoreLevelConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x0007E6A7 File Offset: 0x0007C8A7
		static ConfigBattleScoreLevelConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreLevelConfById.CreateStaticDefaultValue), new Action(ConfigBattleScoreLevelConfById.ResetStaticDefaultValue));
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0007E6C8 File Offset: 0x0007C8C8
		public static void CreateStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattleScoreLevelConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battlescore.db"),
				new ValueTuple<string, object>("文件", "z.战斗评分.xlsx"),
				new ValueTuple<string, object>("表名", "BattleScoreLevelConf"),
				new ValueTuple<string, object>("语句", "select BinData from `BattleScoreLevelConf` where Id=?")
			});
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0007E747 File Offset: 0x0007C947
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfById.LogPair = null;
			ConfigBattleScoreLevelConfById.HandleId = 0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0007E755 File Offset: 0x0007C955
		public static void Init()
		{
			ConfigBattleScoreLevelConfById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreLevelConfById.HandleId, "db_battlescore.db", "select BinData from `BattleScoreLevelConf` where Id=?");
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0007E770 File Offset: 0x0007C970
		public static BattleScoreLevelConf? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattleScoreLevelConfById.HandleId, ConfigBattleScoreLevelConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreLevelConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattleScoreLevelConf?(BattleScoreLevelConf.GetRootAsBattleScoreLevelConf(configBuffer));
				}
			}
			ConfigBattleScoreLevelConfById.LogPair.Clear();
			ConfigBattleScoreLevelConfById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBattleScoreLevelConfById.HandleId, 1, p0Id, ConfigBattleScoreLevelConfById.LogPair) || ConfigCommon.Step(ConfigBattleScoreLevelConfById.HandleId, true, ConfigBattleScoreLevelConfById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattleScoreLevelConfById.HandleId, ConfigBattleScoreLevelConfById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattleScoreLevelConfById.HandleId, 0, ConfigBattleScoreLevelConfById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattleScoreLevelConfById.HandleId, ConfigBattleScoreLevelConfById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattleScoreLevelConf rootAsBattleScoreLevelConf = BattleScoreLevelConf.GetRootAsBattleScoreLevelConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreLevelConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattleScoreLevelConfById.HandleId, ConfigBattleScoreLevelConfById.LogPair);
			return new BattleScoreLevelConf?(rootAsBattleScoreLevelConf);
		}

		// Token: 0x040006BA RID: 1722
		private const string DB = "db_battlescore.db";

		// Token: 0x040006BB RID: 1723
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x040006BC RID: 1724
		private const string TABLE = "BattleScoreLevelConf";

		// Token: 0x040006BD RID: 1725
		private const string COMMAND = "select BinData from `BattleScoreLevelConf` where Id=?";

		// Token: 0x040006BE RID: 1726
		private const string KEY_PREFIX = "BattleScoreLevelConfById";

		// Token: 0x040006BF RID: 1727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006C0 RID: 1728
		private static int HandleId;
	}
}
