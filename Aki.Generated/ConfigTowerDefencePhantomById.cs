using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F9 RID: 2553
	public class ConfigTowerDefencePhantomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BEA RID: 15338 RVA: 0x001AC883 File Offset: 0x001AAA83
		static ConfigTowerDefencePhantomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomById.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x001AC8A4 File Offset: 0x001AAAA4
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantom` where Id = ?")
			});
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x001AC923 File Offset: 0x001AAB23
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomById.LogPair = null;
			ConfigTowerDefencePhantomById.HandleId = 0;
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x001AC931 File Offset: 0x001AAB31
		public static void Init()
		{
			ConfigTowerDefencePhantomById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantom` where Id = ?");
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x001AC94C File Offset: 0x001AAB4C
		public static TowerDefencePhantom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefencePhantom?(TowerDefencePhantom.GetRootAsTowerDefencePhantom(configBuffer));
				}
			}
			ConfigTowerDefencePhantomById.LogPair.Clear();
			ConfigTowerDefencePhantomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefencePhantomById.HandleId, 1, p0Id, ConfigTowerDefencePhantomById.LogPair) || ConfigCommon.Step(ConfigTowerDefencePhantomById.HandleId, true, ConfigTowerDefencePhantomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomById.HandleId, 0, ConfigTowerDefencePhantomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefencePhantom rootAsTowerDefencePhantom = TowerDefencePhantom.GetRootAsTowerDefencePhantom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
			return new TowerDefencePhantom?(rootAsTowerDefencePhantom);
		}

		// Token: 0x040045B5 RID: 17845
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045B6 RID: 17846
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045B7 RID: 17847
		private const string TABLE = "TowerDefencePhantom";

		// Token: 0x040045B8 RID: 17848
		private const string COMMAND = "select BinData from `TowerDefencePhantom` where Id = ?";

		// Token: 0x040045B9 RID: 17849
		private const string KEY_PREFIX = "TowerDefencePhantomById";

		// Token: 0x040045BA RID: 17850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045BB RID: 17851
		private static int HandleId;
	}
}
