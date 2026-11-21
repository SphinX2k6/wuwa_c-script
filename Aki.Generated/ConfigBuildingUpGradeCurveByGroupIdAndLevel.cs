using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013C RID: 316
	public class ConfigBuildingUpGradeCurveByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x0008726B File Offset: 0x0008546B
		static ConfigBuildingUpGradeCurveByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingUpGradeCurveByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigBuildingUpGradeCurveByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0008728C File Offset: 0x0008548C
		public static void CreateStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "BuildingUpGradeCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `BuildingUpGradeCurve` where GroupId=? AND Level=?")
			});
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0008730B File Offset: 0x0008550B
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair = null;
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00087319 File Offset: 0x00085519
		public static void Init()
		{
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, "db_moonchasing.db", "select BinData from `BuildingUpGradeCurve` where GroupId=? AND Level=?");
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00087334 File Offset: 0x00085534
		public static BuildingUpGradeCurve? GetConfig(int p0GroupId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingUpGradeCurveByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BuildingUpGradeCurve?(BuildingUpGradeCurve.GetRootAsBuildingUpGradeCurve(configBuffer));
				}
			}
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair.Clear();
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, 1, p0GroupId, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, 2, p1Level, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair) || ConfigCommon.Step(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, true, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, 0, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BuildingUpGradeCurve rootAsBuildingUpGradeCurve = BuildingUpGradeCurve.GetRootAsBuildingUpGradeCurve(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingUpGradeCurveByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair);
			return new BuildingUpGradeCurve?(rootAsBuildingUpGradeCurve);
		}

		// Token: 0x04000888 RID: 2184
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000889 RID: 2185
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400088A RID: 2186
		private const string TABLE = "BuildingUpGradeCurve";

		// Token: 0x0400088B RID: 2187
		private const string COMMAND = "select BinData from `BuildingUpGradeCurve` where GroupId=? AND Level=?";

		// Token: 0x0400088C RID: 2188
		private const string KEY_PREFIX = "BuildingUpGradeCurveByGroupIdAndLevel";

		// Token: 0x0400088D RID: 2189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400088E RID: 2190
		private static int HandleId;
	}
}
