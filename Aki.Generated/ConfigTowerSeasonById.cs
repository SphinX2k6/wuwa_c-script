using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A05 RID: 2565
	public class ConfigTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x001AE26C File Offset: 0x001AC46C
		static ConfigTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x001AE28C File Offset: 0x001AC48C
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

		// Token: 0x06003C34 RID: 15412 RVA: 0x001AE30B File Offset: 0x001AC50B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerSeasonById.LogPair = null;
			ConfigTowerSeasonById.HandleId = 0;
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x001AE319 File Offset: 0x001AC519
		public static void Init()
		{
			ConfigTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerSeasonById.HandleId, "db_tower.db", "select BinData from `TowerSeason` where Id = ?");
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x001AE334 File Offset: 0x001AC534
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

		// Token: 0x04004609 RID: 17929
		private const string DB = "db_tower.db";

		// Token: 0x0400460A RID: 17930
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x0400460B RID: 17931
		private const string TABLE = "TowerSeason";

		// Token: 0x0400460C RID: 17932
		private const string COMMAND = "select BinData from `TowerSeason` where Id = ?";

		// Token: 0x0400460D RID: 17933
		private const string KEY_PREFIX = "TowerSeasonById";

		// Token: 0x0400460E RID: 17934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400460F RID: 17935
		private static int HandleId;
	}
}
