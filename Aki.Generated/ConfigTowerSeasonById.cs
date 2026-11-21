using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADA RID: 2778
	public class ConfigTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004130 RID: 16688 RVA: 0x001CD600 File Offset: 0x001CB800
		static ConfigTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x001CD620 File Offset: 0x001CB820
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerSeason` where Id = ?")
			});
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x001CD69F File Offset: 0x001CB89F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerSeasonById.LogPair = null;
			ConfigTowerSeasonById.HandleId = 0;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001CD6AD File Offset: 0x001CB8AD
		public static void Init()
		{
			ConfigTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerSeasonById.HandleId, "db_tower.db", "select BinData from `TowerSeason` where Id = ?");
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001CD6C8 File Offset: 0x001CB8C8
		public static TowerSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerSeasonById.HandleId, ConfigTowerSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerSeason?(TowerSeason.GetRootAsTowerSeason(configBuffer));
				}
			}
			ConfigTowerSeasonById.LogPair.Clear();
			ConfigTowerSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerSeasonById.HandleId, 1, p0Id, ConfigTowerSeasonById.LogPair) || ConfigCommon.Step(ConfigTowerSeasonById.HandleId, true, ConfigTowerSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerSeasonById.HandleId, ConfigTowerSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerSeasonById.HandleId, 0, ConfigTowerSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerSeasonById.HandleId, ConfigTowerSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerSeason rootAsTowerSeason = TowerSeason.GetRootAsTowerSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerSeasonById.HandleId, ConfigTowerSeasonById.LogPair);
			return new TowerSeason?(rootAsTowerSeason);
		}

		// Token: 0x04004BDC RID: 19420
		private const string DB = "db_tower.db";

		// Token: 0x04004BDD RID: 19421
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BDE RID: 19422
		private const string TABLE = "TowerSeason";

		// Token: 0x04004BDF RID: 19423
		private const string COMMAND = "select BinData from `TowerSeason` where Id = ?";

		// Token: 0x04004BE0 RID: 19424
		private const string KEY_PREFIX = "TowerSeasonById";

		// Token: 0x04004BE1 RID: 19425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BE2 RID: 19426
		private static int HandleId;
	}
}
