using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD1 RID: 2769
	public class ConfigTowerDefencePhantomLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040FA RID: 16634 RVA: 0x001CC22B File Offset: 0x001CA42B
		static ConfigTowerDefencePhantomLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelById.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x001CC24C File Offset: 0x001CA44C
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantomLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantomLevel` where Id = ?")
			});
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x001CC2CB File Offset: 0x001CA4CB
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelById.LogPair = null;
			ConfigTowerDefencePhantomLevelById.HandleId = 0;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x001CC2D9 File Offset: 0x001CA4D9
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel` where Id = ?");
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x001CC2F4 File Offset: 0x001CA4F4
		public static TowerDefencePhantomLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomLevelById.HandleId, ConfigTowerDefencePhantomLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefencePhantomLevel?(TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(configBuffer));
				}
			}
			ConfigTowerDefencePhantomLevelById.LogPair.Clear();
			ConfigTowerDefencePhantomLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefencePhantomLevelById.HandleId, 1, p0Id, ConfigTowerDefencePhantomLevelById.LogPair) || ConfigCommon.Step(ConfigTowerDefencePhantomLevelById.HandleId, true, ConfigTowerDefencePhantomLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomLevelById.HandleId, ConfigTowerDefencePhantomLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomLevelById.HandleId, 0, ConfigTowerDefencePhantomLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomLevelById.HandleId, ConfigTowerDefencePhantomLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefencePhantomLevel rootAsTowerDefencePhantomLevel = TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomLevelById.HandleId, ConfigTowerDefencePhantomLevelById.LogPair);
			return new TowerDefencePhantomLevel?(rootAsTowerDefencePhantomLevel);
		}

		// Token: 0x04004B9D RID: 19357
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B9E RID: 19358
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B9F RID: 19359
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x04004BA0 RID: 19360
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel` where Id = ?";

		// Token: 0x04004BA1 RID: 19361
		private const string KEY_PREFIX = "TowerDefencePhantomLevelById";

		// Token: 0x04004BA2 RID: 19362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BA3 RID: 19363
		private static int HandleId;
	}
}
