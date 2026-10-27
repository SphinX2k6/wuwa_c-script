using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000706 RID: 1798
	public class ConfigPhysicsAssetConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A34 RID: 10804 RVA: 0x00147E20 File Offset: 0x00146020
		static ConfigPhysicsAssetConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhysicsAssetConfigById.CreateStaticDefaultValue), new Action(ConfigPhysicsAssetConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00147E40 File Offset: 0x00146040
		public static void CreateStaticDefaultValue()
		{
			ConfigPhysicsAssetConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhysicsAssetConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_physics_asset.db"),
				new ValueTuple<string, object>("文件", "j.角色物理资产.xlsx"),
				new ValueTuple<string, object>("表名", "PhysicsAssetConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhysicsAssetConfig` where id=?")
			});
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00147EBF File Offset: 0x001460BF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhysicsAssetConfigById.LogPair = null;
			ConfigPhysicsAssetConfigById.HandleId = 0;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00147ECD File Offset: 0x001460CD
		public static void Init()
		{
			ConfigPhysicsAssetConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPhysicsAssetConfigById.HandleId, "db_physics_asset.db", "select BinData from `PhysicsAssetConfig` where id=?");
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00147EE8 File Offset: 0x001460E8
		public static PhysicsAssetConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhysicsAssetConfigById.HandleId, ConfigPhysicsAssetConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PhysicsAssetConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new PhysicsAssetConfig?(PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(configBuffer));
				}
			}
			ConfigPhysicsAssetConfigById.LogPair.Clear();
			ConfigPhysicsAssetConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigPhysicsAssetConfigById.HandleId, 1, p0Id, ConfigPhysicsAssetConfigById.LogPair) || ConfigCommon.Step(ConfigPhysicsAssetConfigById.HandleId, true, ConfigPhysicsAssetConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhysicsAssetConfigById.HandleId, ConfigPhysicsAssetConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhysicsAssetConfigById.HandleId, 0, ConfigPhysicsAssetConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhysicsAssetConfigById.HandleId, ConfigPhysicsAssetConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhysicsAssetConfig rootAsPhysicsAssetConfig = PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PhysicsAssetConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhysicsAssetConfigById.HandleId, ConfigPhysicsAssetConfigById.LogPair);
			return new PhysicsAssetConfig?(rootAsPhysicsAssetConfig);
		}

		// Token: 0x04003110 RID: 12560
		private const string DB = "db_physics_asset.db";

		// Token: 0x04003111 RID: 12561
		private const string FILE = "j.角色物理资产.xlsx";

		// Token: 0x04003112 RID: 12562
		private const string TABLE = "PhysicsAssetConfig";

		// Token: 0x04003113 RID: 12563
		private const string COMMAND = "select BinData from `PhysicsAssetConfig` where id=?";

		// Token: 0x04003114 RID: 12564
		private const string KEY_PREFIX = "PhysicsAssetConfigById";

		// Token: 0x04003115 RID: 12565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003116 RID: 12566
		private static int HandleId;
	}
}
