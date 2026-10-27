using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A00 RID: 2560
	public class ConfigTowerDefenseSettleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C14 RID: 15380 RVA: 0x001AD704 File Offset: 0x001AB904
		static ConfigTowerDefenseSettleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenseSettleById.CreateStaticDefaultValue), new Action(ConfigTowerDefenseSettleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x001AD724 File Offset: 0x001AB924
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

		// Token: 0x06003C16 RID: 15382 RVA: 0x001AD7A3 File Offset: 0x001AB9A3
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenseSettleById.LogPair = null;
			ConfigTowerDefenseSettleById.HandleId = 0;
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x001AD7B1 File Offset: 0x001AB9B1
		public static void Init()
		{
			ConfigTowerDefenseSettleById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenseSettleById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenseSettle` where Id = ?");
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x001AD7CC File Offset: 0x001AB9CC
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

		// Token: 0x040045E6 RID: 17894
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045E7 RID: 17895
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045E8 RID: 17896
		private const string TABLE = "TowerDefenseSettle";

		// Token: 0x040045E9 RID: 17897
		private const string COMMAND = "select BinData from `TowerDefenseSettle` where Id = ?";

		// Token: 0x040045EA RID: 17898
		private const string KEY_PREFIX = "TowerDefenseSettleById";

		// Token: 0x040045EB RID: 17899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045EC RID: 17900
		private static int HandleId;
	}
}
