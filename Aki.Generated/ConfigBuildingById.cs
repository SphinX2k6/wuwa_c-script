using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012B RID: 299
	public class ConfigBuildingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00081487 File Offset: 0x0007F687
		static ConfigBuildingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingById.CreateStaticDefaultValue), new Action(ConfigBuildingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000814A8 File Offset: 0x0007F6A8
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

		// Token: 0x06000705 RID: 1797 RVA: 0x00081527 File Offset: 0x0007F727
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingById.LogPair = null;
			ConfigBuildingById.HandleId = 0;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00081535 File Offset: 0x0007F735
		public static void Init()
		{
			ConfigBuildingById.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingById.HandleId, "db_moonchasing.db", "select BinData from `Building` where Id=?");
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00081550 File Offset: 0x0007F750
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

		// Token: 0x04000811 RID: 2065
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000812 RID: 2066
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000813 RID: 2067
		private const string TABLE = "Building";

		// Token: 0x04000814 RID: 2068
		private const string COMMAND = "select BinData from `Building` where Id=?";

		// Token: 0x04000815 RID: 2069
		private const string KEY_PREFIX = "BuildingById";

		// Token: 0x04000816 RID: 2070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000817 RID: 2071
		private static int HandleId;
	}
}
