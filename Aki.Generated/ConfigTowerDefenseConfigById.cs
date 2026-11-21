using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD4 RID: 2772
	public class ConfigTowerDefenseConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600410C RID: 16652 RVA: 0x001CC850 File Offset: 0x001CAA50
		static ConfigTowerDefenseConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenseConfigById.CreateStaticDefaultValue), new Action(ConfigTowerDefenseConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x001CC870 File Offset: 0x001CAA70
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenseConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenseConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenseConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenseConfig` where Id = ?")
			});
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x001CC8EF File Offset: 0x001CAAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenseConfigById.LogPair = null;
			ConfigTowerDefenseConfigById.HandleId = 0;
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x001CC8FD File Offset: 0x001CAAFD
		public static void Init()
		{
			ConfigTowerDefenseConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenseConfigById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenseConfig` where Id = ?");
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x001CC918 File Offset: 0x001CAB18
		public static TowerDefenseConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenseConfigById.HandleId, ConfigTowerDefenseConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenseConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenseConfig?(TowerDefenseConfig.GetRootAsTowerDefenseConfig(configBuffer));
				}
			}
			ConfigTowerDefenseConfigById.LogPair.Clear();
			ConfigTowerDefenseConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefenseConfigById.HandleId, 1, p0Id, ConfigTowerDefenseConfigById.LogPair) || ConfigCommon.Step(ConfigTowerDefenseConfigById.HandleId, true, ConfigTowerDefenseConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenseConfigById.HandleId, ConfigTowerDefenseConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenseConfigById.HandleId, 0, ConfigTowerDefenseConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenseConfigById.HandleId, ConfigTowerDefenseConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenseConfig rootAsTowerDefenseConfig = TowerDefenseConfig.GetRootAsTowerDefenseConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenseConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenseConfigById.HandleId, ConfigTowerDefenseConfigById.LogPair);
			return new TowerDefenseConfig?(rootAsTowerDefenseConfig);
		}

		// Token: 0x04004BB2 RID: 19378
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004BB3 RID: 19379
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004BB4 RID: 19380
		private const string TABLE = "TowerDefenseConfig";

		// Token: 0x04004BB5 RID: 19381
		private const string COMMAND = "select BinData from `TowerDefenseConfig` where Id = ?";

		// Token: 0x04004BB6 RID: 19382
		private const string KEY_PREFIX = "TowerDefenseConfigById";

		// Token: 0x04004BB7 RID: 19383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BB8 RID: 19384
		private static int HandleId;
	}
}
