using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B47 RID: 2887
	public class ConfigVehicleTeamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043BE RID: 17342 RVA: 0x001DC134 File Offset: 0x001DA334
		static ConfigVehicleTeamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVehicleTeamById.CreateStaticDefaultValue), new Action(ConfigVehicleTeamById.ResetStaticDefaultValue));
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x001DC154 File Offset: 0x001DA354
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

		// Token: 0x060043C0 RID: 17344 RVA: 0x001DC1D3 File Offset: 0x001DA3D3
		public static void ResetStaticDefaultValue()
		{
			ConfigVehicleTeamById.LogPair = null;
			ConfigVehicleTeamById.HandleId = 0;
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x001DC1E1 File Offset: 0x001DA3E1
		public static void Init()
		{
			ConfigVehicleTeamById.HandleId = ConfigCommon.InitDataStatement(ConfigVehicleTeamById.HandleId, "db_vehicleteam.db", "select BinData from `VehicleTeam` where Id=?");
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x001DC1FC File Offset: 0x001DA3FC
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

		// Token: 0x04004ED7 RID: 20183
		private const string DB = "db_vehicleteam.db";

		// Token: 0x04004ED8 RID: 20184
		private const string FILE = "c.车流.xlsx";

		// Token: 0x04004ED9 RID: 20185
		private const string TABLE = "VehicleTeam";

		// Token: 0x04004EDA RID: 20186
		private const string COMMAND = "select BinData from `VehicleTeam` where Id=?";

		// Token: 0x04004EDB RID: 20187
		private const string KEY_PREFIX = "VehicleTeamById";

		// Token: 0x04004EDC RID: 20188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EDD RID: 20189
		private static int HandleId;
	}
}
