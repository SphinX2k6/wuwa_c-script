using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071E RID: 1822
	public class ConfigPhysicsAssetConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AC4 RID: 10948 RVA: 0x0014E89C File Offset: 0x0014CA9C
		static ConfigPhysicsAssetConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhysicsAssetConfigById.CreateStaticDefaultValue), new Action(ConfigPhysicsAssetConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0014E8BC File Offset: 0x0014CABC
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

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0014E93B File Offset: 0x0014CB3B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhysicsAssetConfigById.LogPair = null;
			ConfigPhysicsAssetConfigById.HandleId = 0;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0014E949 File Offset: 0x0014CB49
		public static void Init()
		{
			ConfigPhysicsAssetConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPhysicsAssetConfigById.HandleId, "db_physics_asset.db", "select BinData from `PhysicsAssetConfig` where id=?");
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0014E964 File Offset: 0x0014CB64
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

		// Token: 0x040031B8 RID: 12728
		private const string DB = "db_physics_asset.db";

		// Token: 0x040031B9 RID: 12729
		private const string FILE = "j.角色物理资产.xlsx";

		// Token: 0x040031BA RID: 12730
		private const string TABLE = "PhysicsAssetConfig";

		// Token: 0x040031BB RID: 12731
		private const string COMMAND = "select BinData from `PhysicsAssetConfig` where id=?";

		// Token: 0x040031BC RID: 12732
		private const string KEY_PREFIX = "PhysicsAssetConfigById";

		// Token: 0x040031BD RID: 12733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031BE RID: 12734
		private static int HandleId;
	}
}
