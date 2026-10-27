using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012D RID: 301
	public class ConfigBuildingUpGradeCurveByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00081907 File Offset: 0x0007FB07
		static ConfigBuildingUpGradeCurveByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingUpGradeCurveByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigBuildingUpGradeCurveByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00081928 File Offset: 0x0007FB28
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

		// Token: 0x06000711 RID: 1809 RVA: 0x000819A7 File Offset: 0x0007FBA7
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.LogPair = null;
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000819B5 File Offset: 0x0007FBB5
		public static void Init()
		{
			ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingUpGradeCurveByGroupIdAndLevel.HandleId, "db_moonchasing.db", "select BinData from `BuildingUpGradeCurve` where GroupId=? AND Level=?");
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000819D0 File Offset: 0x0007FBD0
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

		// Token: 0x0400081F RID: 2079
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000820 RID: 2080
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000821 RID: 2081
		private const string TABLE = "BuildingUpGradeCurve";

		// Token: 0x04000822 RID: 2082
		private const string COMMAND = "select BinData from `BuildingUpGradeCurve` where GroupId=? AND Level=?";

		// Token: 0x04000823 RID: 2083
		private const string KEY_PREFIX = "BuildingUpGradeCurveByGroupIdAndLevel";

		// Token: 0x04000824 RID: 2084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000825 RID: 2085
		private static int HandleId;
	}
}
