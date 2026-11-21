using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013A RID: 314
	public class ConfigBuildingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00086DEB File Offset: 0x00084FEB
		static ConfigBuildingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingById.CreateStaticDefaultValue), new Action(ConfigBuildingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00086E0C File Offset: 0x0008500C
		public static void CreateStaticDefaultValue()
		{
			ConfigBuildingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuildingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Building"),
				new ValueTuple<string, object>("语句", "select BinData from `Building` where Id=?")
			});
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00086E8B File Offset: 0x0008508B
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingById.LogPair = null;
			ConfigBuildingById.HandleId = 0;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00086E99 File Offset: 0x00085099
		public static void Init()
		{
			ConfigBuildingById.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingById.HandleId, "db_moonchasing.db", "select BinData from `Building` where Id=?");
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00086EB4 File Offset: 0x000850B4
		public static Building? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuildingById.HandleId, ConfigBuildingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Building?(Building.GetRootAsBuilding(configBuffer));
				}
			}
			ConfigBuildingById.LogPair.Clear();
			ConfigBuildingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBuildingById.HandleId, 1, p0Id, ConfigBuildingById.LogPair) || ConfigCommon.Step(ConfigBuildingById.HandleId, true, ConfigBuildingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuildingById.HandleId, ConfigBuildingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuildingById.HandleId, 0, ConfigBuildingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuildingById.HandleId, ConfigBuildingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Building rootAsBuilding = Building.GetRootAsBuilding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuildingById.HandleId, ConfigBuildingById.LogPair);
			return new Building?(rootAsBuilding);
		}

		// Token: 0x0400087A RID: 2170
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400087B RID: 2171
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400087C RID: 2172
		private const string TABLE = "Building";

		// Token: 0x0400087D RID: 2173
		private const string COMMAND = "select BinData from `Building` where Id=?";

		// Token: 0x0400087E RID: 2174
		private const string KEY_PREFIX = "BuildingById";

		// Token: 0x0400087F RID: 2175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000880 RID: 2176
		private static int HandleId;
	}
}
