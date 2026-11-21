using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD5 RID: 2773
	public class ConfigTowerDefenseSettleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004112 RID: 16658 RVA: 0x001CCA98 File Offset: 0x001CAC98
		static ConfigTowerDefenseSettleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenseSettleById.CreateStaticDefaultValue), new Action(ConfigTowerDefenseSettleById.ResetStaticDefaultValue));
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x001CCAB8 File Offset: 0x001CACB8
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenseSettleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenseSettleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenseSettle"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenseSettle` where Id = ?")
			});
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x001CCB37 File Offset: 0x001CAD37
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenseSettleById.LogPair = null;
			ConfigTowerDefenseSettleById.HandleId = 0;
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x001CCB45 File Offset: 0x001CAD45
		public static void Init()
		{
			ConfigTowerDefenseSettleById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenseSettleById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenseSettle` where Id = ?");
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x001CCB60 File Offset: 0x001CAD60
		public static TowerDefenseSettle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenseSettleById.HandleId, ConfigTowerDefenseSettleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenseSettleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenseSettle?(TowerDefenseSettle.GetRootAsTowerDefenseSettle(configBuffer));
				}
			}
			ConfigTowerDefenseSettleById.LogPair.Clear();
			ConfigTowerDefenseSettleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefenseSettleById.HandleId, 1, p0Id, ConfigTowerDefenseSettleById.LogPair) || ConfigCommon.Step(ConfigTowerDefenseSettleById.HandleId, true, ConfigTowerDefenseSettleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenseSettleById.HandleId, ConfigTowerDefenseSettleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenseSettleById.HandleId, 0, ConfigTowerDefenseSettleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenseSettleById.HandleId, ConfigTowerDefenseSettleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenseSettle rootAsTowerDefenseSettle = TowerDefenseSettle.GetRootAsTowerDefenseSettle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenseSettleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenseSettleById.HandleId, ConfigTowerDefenseSettleById.LogPair);
			return new TowerDefenseSettle?(rootAsTowerDefenseSettle);
		}

		// Token: 0x04004BB9 RID: 19385
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004BBA RID: 19386
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004BBB RID: 19387
		private const string TABLE = "TowerDefenseSettle";

		// Token: 0x04004BBC RID: 19388
		private const string COMMAND = "select BinData from `TowerDefenseSettle` where Id = ?";

		// Token: 0x04004BBD RID: 19389
		private const string KEY_PREFIX = "TowerDefenseSettleById";

		// Token: 0x04004BBE RID: 19390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BBF RID: 19391
		private static int HandleId;
	}
}
