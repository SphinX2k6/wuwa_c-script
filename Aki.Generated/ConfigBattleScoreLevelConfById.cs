using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EB RID: 235
	public class ConfigBattleScoreLevelConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00078D43 File Offset: 0x00076F43
		static ConfigBattleScoreLevelConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreLevelConfById.CreateStaticDefaultValue), new Action(ConfigBattleScoreLevelConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00078D64 File Offset: 0x00076F64
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

		// Token: 0x06000585 RID: 1413 RVA: 0x00078DE3 File Offset: 0x00076FE3
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreLevelConfById.LogPair = null;
			ConfigBattleScoreLevelConfById.HandleId = 0;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00078DF1 File Offset: 0x00076FF1
		public static void Init()
		{
			ConfigBattleScoreLevelConfById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreLevelConfById.HandleId, "db_battlescore.db", "select BinData from `BattleScoreLevelConf` where Id=?");
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00078E0C File Offset: 0x0007700C
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

		// Token: 0x04000651 RID: 1617
		private const string DB = "db_battlescore.db";

		// Token: 0x04000652 RID: 1618
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x04000653 RID: 1619
		private const string TABLE = "BattleScoreLevelConf";

		// Token: 0x04000654 RID: 1620
		private const string COMMAND = "select BinData from `BattleScoreLevelConf` where Id=?";

		// Token: 0x04000655 RID: 1621
		private const string KEY_PREFIX = "BattleScoreLevelConfById";

		// Token: 0x04000656 RID: 1622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000657 RID: 1623
		private static int HandleId;
	}
}
