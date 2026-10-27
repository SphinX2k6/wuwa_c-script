using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E9 RID: 233
	public class ConfigBattleScoreConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x000788C4 File Offset: 0x00076AC4
		static ConfigBattleScoreConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreConfById.CreateStaticDefaultValue), new Action(ConfigBattleScoreConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000788E4 File Offset: 0x00076AE4
		public static void CreateStaticDefaultValue()
		{
			ConfigBattleScoreConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattleScoreConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battlescore.db"),
				new ValueTuple<string, object>("文件", "z.战斗评分.xlsx"),
				new ValueTuple<string, object>("表名", "BattleScoreConf"),
				new ValueTuple<string, object>("语句", "select BinData from `BattleScoreConf` where Id=?")
			});
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00078963 File Offset: 0x00076B63
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreConfById.LogPair = null;
			ConfigBattleScoreConfById.HandleId = 0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00078971 File Offset: 0x00076B71
		public static void Init()
		{
			ConfigBattleScoreConfById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreConfById.HandleId, "db_battlescore.db", "select BinData from `BattleScoreConf` where Id=?");
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0007898C File Offset: 0x00076B8C
		public static BattleScoreConf? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattleScoreConfById.HandleId, ConfigBattleScoreConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattleScoreConf?(BattleScoreConf.GetRootAsBattleScoreConf(configBuffer));
				}
			}
			ConfigBattleScoreConfById.LogPair.Clear();
			ConfigBattleScoreConfById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBattleScoreConfById.HandleId, 1, p0Id, ConfigBattleScoreConfById.LogPair) || ConfigCommon.Step(ConfigBattleScoreConfById.HandleId, true, ConfigBattleScoreConfById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattleScoreConfById.HandleId, ConfigBattleScoreConfById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattleScoreConfById.HandleId, 0, ConfigBattleScoreConfById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattleScoreConfById.HandleId, ConfigBattleScoreConfById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattleScoreConf rootAsBattleScoreConf = BattleScoreConf.GetRootAsBattleScoreConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattleScoreConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattleScoreConfById.HandleId, ConfigBattleScoreConfById.LogPair);
			return new BattleScoreConf?(rootAsBattleScoreConf);
		}

		// Token: 0x04000643 RID: 1603
		private const string DB = "db_battlescore.db";

		// Token: 0x04000644 RID: 1604
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x04000645 RID: 1605
		private const string TABLE = "BattleScoreConf";

		// Token: 0x04000646 RID: 1606
		private const string COMMAND = "select BinData from `BattleScoreConf` where Id=?";

		// Token: 0x04000647 RID: 1607
		private const string KEY_PREFIX = "BattleScoreConfById";

		// Token: 0x04000648 RID: 1608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000649 RID: 1609
		private static int HandleId;
	}
}
