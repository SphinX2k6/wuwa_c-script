using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FC RID: 2556
	public class ConfigTowerDefencePhantomLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x001ACE97 File Offset: 0x001AB097
		static ConfigTowerDefencePhantomLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelById.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
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

		// Token: 0x06003BFE RID: 15358 RVA: 0x001ACF37 File Offset: 0x001AB137
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelById.LogPair = null;
			ConfigTowerDefencePhantomLevelById.HandleId = 0;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x001ACF45 File Offset: 0x001AB145
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel` where Id = ?");
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x001ACF60 File Offset: 0x001AB160
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

		// Token: 0x040045CA RID: 17866
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045CB RID: 17867
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045CC RID: 17868
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x040045CD RID: 17869
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel` where Id = ?";

		// Token: 0x040045CE RID: 17870
		private const string KEY_PREFIX = "TowerDefencePhantomLevelById";

		// Token: 0x040045CF RID: 17871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045D0 RID: 17872
		private static int HandleId;
	}
}
