using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FF RID: 2559
	public class ConfigTowerDefenseConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C0E RID: 15374 RVA: 0x001AD4BC File Offset: 0x001AB6BC
		static ConfigTowerDefenseConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenseConfigById.CreateStaticDefaultValue), new Action(ConfigTowerDefenseConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x001AD4DC File Offset: 0x001AB6DC
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

		// Token: 0x06003C10 RID: 15376 RVA: 0x001AD55B File Offset: 0x001AB75B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenseConfigById.LogPair = null;
			ConfigTowerDefenseConfigById.HandleId = 0;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x001AD569 File Offset: 0x001AB769
		public static void Init()
		{
			ConfigTowerDefenseConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenseConfigById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenseConfig` where Id = ?");
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x001AD584 File Offset: 0x001AB784
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

		// Token: 0x040045DF RID: 17887
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045E0 RID: 17888
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045E1 RID: 17889
		private const string TABLE = "TowerDefenseConfig";

		// Token: 0x040045E2 RID: 17890
		private const string COMMAND = "select BinData from `TowerDefenseConfig` where Id = ?";

		// Token: 0x040045E3 RID: 17891
		private const string KEY_PREFIX = "TowerDefenseConfigById";

		// Token: 0x040045E4 RID: 17892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045E5 RID: 17893
		private static int HandleId;
	}
}
