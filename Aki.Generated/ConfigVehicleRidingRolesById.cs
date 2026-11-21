using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B46 RID: 2886
	public class ConfigVehicleRidingRolesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043B8 RID: 17336 RVA: 0x001DBEEC File Offset: 0x001DA0EC
		static ConfigVehicleRidingRolesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVehicleRidingRolesById.CreateStaticDefaultValue), new Action(ConfigVehicleRidingRolesById.ResetStaticDefaultValue));
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x001DBF0C File Offset: 0x001DA10C
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

		// Token: 0x060043BA RID: 17338 RVA: 0x001DBF8B File Offset: 0x001DA18B
		public static void ResetStaticDefaultValue()
		{
			ConfigVehicleRidingRolesById.LogPair = null;
			ConfigVehicleRidingRolesById.HandleId = 0;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x001DBF99 File Offset: 0x001DA199
		public static void Init()
		{
			ConfigVehicleRidingRolesById.HandleId = ConfigCommon.InitDataStatement(ConfigVehicleRidingRolesById.HandleId, "db_vehicleridingroles.db", "select BinData from `VehicleRidingRoles` where Id=?");
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x001DBFB4 File Offset: 0x001DA1B4
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

		// Token: 0x04004ED0 RID: 20176
		private const string DB = "db_vehicleridingroles.db";

		// Token: 0x04004ED1 RID: 20177
		private const string FILE = "k.可视化编辑/c.Csv/z.载具共乘角色配置/*.csv*";

		// Token: 0x04004ED2 RID: 20178
		private const string TABLE = "VehicleRidingRoles";

		// Token: 0x04004ED3 RID: 20179
		private const string COMMAND = "select BinData from `VehicleRidingRoles` where Id=?";

		// Token: 0x04004ED4 RID: 20180
		private const string KEY_PREFIX = "VehicleRidingRolesById";

		// Token: 0x04004ED5 RID: 20181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004ED6 RID: 20182
		private static int HandleId;
	}
}
