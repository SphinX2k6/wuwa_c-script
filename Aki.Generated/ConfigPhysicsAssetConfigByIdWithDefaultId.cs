using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000707 RID: 1799
	public class ConfigPhysicsAssetConfigByIdWithDefaultId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A3A RID: 10810 RVA: 0x00148019 File Offset: 0x00146219
		static ConfigPhysicsAssetConfigByIdWithDefaultId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhysicsAssetConfigByIdWithDefaultId.CreateStaticDefaultValue), new Action(ConfigPhysicsAssetConfigByIdWithDefaultId.ResetStaticDefaultValue));
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00148038 File Offset: 0x00146238
		public static void CreateStaticDefaultValue()
		{
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_physics_asset.db"),
				new ValueTuple<string, object>("文件", "j.角色物理资产.xlsx"),
				new ValueTuple<string, object>("表名", "PhysicsAssetConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhysicsAssetConfig` where id = ? AND (SELECT count() from `PhysicsAssetConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PhysicsAssetConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x001480B7 File Offset: 0x001462B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair = null;
			ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId = 0;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x001480C5 File Offset: 0x001462C5
		public static void Init()
		{
			ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId = ConfigCommon.InitDataStatement(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, "db_physics_asset.db", "select BinData from `PhysicsAssetConfig` where id = ? AND (SELECT count() from `PhysicsAssetConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PhysicsAssetConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x001480E0 File Offset: 0x001462E0
		public static PhysicsAssetConfig? GetConfig(string p0Id, string p1Id, string p2Id, string p3Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("PhysicsAssetConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p3Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhysicsAssetConfig?(PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(configBuffer));
				}
			}
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.Clear();
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p3Id));
			if (!ConfigCommon.BindString(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, 1, p0Id, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindString(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, 2, p1Id, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindString(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, 3, p2Id, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindString(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, 4, p3Id, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair) || ConfigCommon.Step(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, true, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, 0, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhysicsAssetConfig rootAsPhysicsAssetConfig = PhysicsAssetConfig.GetRootAsPhysicsAssetConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("PhysicsAssetConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p3Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhysicsAssetConfigByIdWithDefaultId.HandleId, ConfigPhysicsAssetConfigByIdWithDefaultId.LogPair);
			return new PhysicsAssetConfig?(rootAsPhysicsAssetConfig);
		}

		// Token: 0x04003117 RID: 12567
		private const string DB = "db_physics_asset.db";

		// Token: 0x04003118 RID: 12568
		private const string FILE = "j.角色物理资产.xlsx";

		// Token: 0x04003119 RID: 12569
		private const string TABLE = "PhysicsAssetConfig";

		// Token: 0x0400311A RID: 12570
		private const string COMMAND = "select BinData from `PhysicsAssetConfig` where id = ? AND (SELECT count() from `PhysicsAssetConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `PhysicsAssetConfig` WHERE id = ?) >0;";

		// Token: 0x0400311B RID: 12571
		private const string KEY_PREFIX = "PhysicsAssetConfigByIdWithDefaultId";

		// Token: 0x0400311C RID: 12572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400311D RID: 12573
		private static int HandleId;
	}
}
