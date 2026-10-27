using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A72 RID: 2674
	public class ConfigVehicleTeamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EC0 RID: 16064 RVA: 0x001BCDA0 File Offset: 0x001BAFA0
		static ConfigVehicleTeamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVehicleTeamById.CreateStaticDefaultValue), new Action(ConfigVehicleTeamById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x001BCDC0 File Offset: 0x001BAFC0
		public static void CreateStaticDefaultValue()
		{
			ConfigVehicleTeamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVehicleTeamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_vehicleteam.db"),
				new ValueTuple<string, object>("文件", "c.车流.xlsx"),
				new ValueTuple<string, object>("表名", "VehicleTeam"),
				new ValueTuple<string, object>("语句", "select BinData from `VehicleTeam` where Id=?")
			});
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x001BCE3F File Offset: 0x001BB03F
		public static void ResetStaticDefaultValue()
		{
			ConfigVehicleTeamById.LogPair = null;
			ConfigVehicleTeamById.HandleId = 0;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001BCE4D File Offset: 0x001BB04D
		public static void Init()
		{
			ConfigVehicleTeamById.HandleId = ConfigCommon.InitDataStatement(ConfigVehicleTeamById.HandleId, "db_vehicleteam.db", "select BinData from `VehicleTeam` where Id=?");
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x001BCE68 File Offset: 0x001BB068
		public static VehicleTeam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVehicleTeamById.HandleId, ConfigVehicleTeamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VehicleTeamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new VehicleTeam?(VehicleTeam.GetRootAsVehicleTeam(configBuffer));
				}
			}
			ConfigVehicleTeamById.LogPair.Clear();
			ConfigVehicleTeamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigVehicleTeamById.HandleId, 1, p0Id, ConfigVehicleTeamById.LogPair) || ConfigCommon.Step(ConfigVehicleTeamById.HandleId, true, ConfigVehicleTeamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigVehicleTeamById.HandleId, ConfigVehicleTeamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVehicleTeamById.HandleId, 0, ConfigVehicleTeamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigVehicleTeamById.HandleId, ConfigVehicleTeamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			VehicleTeam rootAsVehicleTeam = VehicleTeam.GetRootAsVehicleTeam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("VehicleTeamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigVehicleTeamById.HandleId, ConfigVehicleTeamById.LogPair);
			return new VehicleTeam?(rootAsVehicleTeam);
		}

		// Token: 0x04004904 RID: 18692
		private const string DB = "db_vehicleteam.db";

		// Token: 0x04004905 RID: 18693
		private const string FILE = "c.车流.xlsx";

		// Token: 0x04004906 RID: 18694
		private const string TABLE = "VehicleTeam";

		// Token: 0x04004907 RID: 18695
		private const string COMMAND = "select BinData from `VehicleTeam` where Id=?";

		// Token: 0x04004908 RID: 18696
		private const string KEY_PREFIX = "VehicleTeamById";

		// Token: 0x04004909 RID: 18697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400490A RID: 18698
		private static int HandleId;
	}
}
