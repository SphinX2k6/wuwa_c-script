using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F8 RID: 248
	public class ConfigBattleScoreConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x0007E228 File Offset: 0x0007C428
		static ConfigBattleScoreConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleScoreConfById.CreateStaticDefaultValue), new Action(ConfigBattleScoreConfById.ResetStaticDefaultValue));
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0007E248 File Offset: 0x0007C448
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x0007E2C7 File Offset: 0x0007C4C7
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleScoreConfById.LogPair = null;
			ConfigBattleScoreConfById.HandleId = 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0007E2D5 File Offset: 0x0007C4D5
		public static void Init()
		{
			ConfigBattleScoreConfById.HandleId = ConfigCommon.InitDataStatement(ConfigBattleScoreConfById.HandleId, "db_battlescore.db", "select BinData from `BattleScoreConf` where Id=?");
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
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

		// Token: 0x040006AC RID: 1708
		private const string DB = "db_battlescore.db";

		// Token: 0x040006AD RID: 1709
		private const string FILE = "z.战斗评分.xlsx";

		// Token: 0x040006AE RID: 1710
		private const string TABLE = "BattleScoreConf";

		// Token: 0x040006AF RID: 1711
		private const string COMMAND = "select BinData from `BattleScoreConf` where Id=?";

		// Token: 0x040006B0 RID: 1712
		private const string KEY_PREFIX = "BattleScoreConfById";

		// Token: 0x040006B1 RID: 1713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006B2 RID: 1714
		private static int HandleId;
	}
}
