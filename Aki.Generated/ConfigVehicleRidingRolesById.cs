using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A71 RID: 2673
	public class ConfigVehicleRidingRolesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x001BCB58 File Offset: 0x001BAD58
		static ConfigVehicleRidingRolesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVehicleRidingRolesById.CreateStaticDefaultValue), new Action(ConfigVehicleRidingRolesById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x001BCB78 File Offset: 0x001BAD78
		public static void CreateStaticDefaultValue()
		{
			ConfigVehicleRidingRolesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVehicleRidingRolesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_vehicleridingroles.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/z.载具共乘角色配置/*.csv*"),
				new ValueTuple<string, object>("表名", "VehicleRidingRoles"),
				new ValueTuple<string, object>("语句", "select BinData from `VehicleRidingRoles` where Id=?")
			});
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x001BCBF7 File Offset: 0x001BADF7
		public static void ResetStaticDefaultValue()
		{
			ConfigVehicleRidingRolesById.LogPair = null;
			ConfigVehicleRidingRolesById.HandleId = 0;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x001BCC05 File Offset: 0x001BAE05
		public static void Init()
		{
			ConfigVehicleRidingRolesById.HandleId = ConfigCommon.InitDataStatement(ConfigVehicleRidingRolesById.HandleId, "db_vehicleridingroles.db", "select BinData from `VehicleRidingRoles` where Id=?");
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x001BCC20 File Offset: 0x001BAE20
		public static VehicleRidingRoles? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVehicleRidingRolesById.HandleId, ConfigVehicleRidingRolesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VehicleRidingRolesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new VehicleRidingRoles?(VehicleRidingRoles.GetRootAsVehicleRidingRoles(configBuffer));
				}
			}
			ConfigVehicleRidingRolesById.LogPair.Clear();
			ConfigVehicleRidingRolesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigVehicleRidingRolesById.HandleId, 1, p0Id, ConfigVehicleRidingRolesById.LogPair) || ConfigCommon.Step(ConfigVehicleRidingRolesById.HandleId, true, ConfigVehicleRidingRolesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigVehicleRidingRolesById.HandleId, ConfigVehicleRidingRolesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVehicleRidingRolesById.HandleId, 0, ConfigVehicleRidingRolesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigVehicleRidingRolesById.HandleId, ConfigVehicleRidingRolesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			VehicleRidingRoles rootAsVehicleRidingRoles = VehicleRidingRoles.GetRootAsVehicleRidingRoles(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VehicleRidingRolesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigVehicleRidingRolesById.HandleId, ConfigVehicleRidingRolesById.LogPair);
			return new VehicleRidingRoles?(rootAsVehicleRidingRoles);
		}

		// Token: 0x040048FD RID: 18685
		private const string DB = "db_vehicleridingroles.db";

		// Token: 0x040048FE RID: 18686
		private const string FILE = "k.可视化编辑/c.Csv/z.载具共乘角色配置/*.csv*";

		// Token: 0x040048FF RID: 18687
		private const string TABLE = "VehicleRidingRoles";

		// Token: 0x04004900 RID: 18688
		private const string COMMAND = "select BinData from `VehicleRidingRoles` where Id=?";

		// Token: 0x04004901 RID: 18689
		private const string KEY_PREFIX = "VehicleRidingRolesById";

		// Token: 0x04004902 RID: 18690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004903 RID: 18691
		private static int HandleId;
	}
}
