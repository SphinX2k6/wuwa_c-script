using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013B RID: 315
	public class ConfigBuildingUpGradeCurveByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000763 RID: 1891 RVA: 0x00087034 File Offset: 0x00085234
		static ConfigBuildingUpGradeCurveByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingUpGradeCurveByGroupId.CreateStaticDefaultValue), new Action(ConfigBuildingUpGradeCurveByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00087054 File Offset: 0x00085254
		public static void CreateStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuildingUpGradeCurveByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "BuildingUpGradeCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `BuildingUpGradeCurve` where GroupId=?")
			});
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000870D3 File Offset: 0x000852D3
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupId.LogPair = null;
			ConfigBuildingUpGradeCurveByGroupId.HandleId = 0;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000870E1 File Offset: 0x000852E1
		public static void Init()
		{
			ConfigBuildingUpGradeCurveByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingUpGradeCurveByGroupId.HandleId, "db_moonchasing.db", "select BinData from `BuildingUpGradeCurve` where GroupId=?");
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000870FC File Offset: 0x000852FC
		[NullableContext(2)]
		public static IReadOnlyList<BuildingUpGradeCurve> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuildingUpGradeCurveByGroupId.HandleId, ConfigBuildingUpGradeCurveByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingUpGradeCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<BuildingUpGradeCurve> readOnlyList = (IReadOnlyList<BuildingUpGradeCurve>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBuildingUpGradeCurveByGroupId.LogPair.Clear();
			ConfigBuildingUpGradeCurveByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigBuildingUpGradeCurveByGroupId.HandleId, 1, p0GroupId, ConfigBuildingUpGradeCurveByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupId.HandleId, ConfigBuildingUpGradeCurveByGroupId.LogPair);
				return null;
			}
			List<BuildingUpGradeCurve> list = new List<BuildingUpGradeCurve>();
			while (ConfigCommon.Step(ConfigBuildingUpGradeCurveByGroupId.HandleId, false, ConfigBuildingUpGradeCurveByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuildingUpGradeCurveByGroupId.HandleId, 0, ConfigBuildingUpGradeCurveByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupId.HandleId, ConfigBuildingUpGradeCurveByGroupId.LogPair);
					return null;
				}
				BuildingUpGradeCurve rootAsBuildingUpGradeCurve = BuildingUpGradeCurve.GetRootAsBuildingUpGradeCurve(new ByteBuffer(item2));
				list.Add(rootAsBuildingUpGradeCurve);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuildingUpGradeCurveByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBuildingUpGradeCurveByGroupId.HandleId, ConfigBuildingUpGradeCurveByGroupId.LogPair);
			return list;
		}

		// Token: 0x04000881 RID: 2177
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000882 RID: 2178
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000883 RID: 2179
		private const string TABLE = "BuildingUpGradeCurve";

		// Token: 0x04000884 RID: 2180
		private const string COMMAND = "select BinData from `BuildingUpGradeCurve` where GroupId=?";

		// Token: 0x04000885 RID: 2181
		private const string KEY_PREFIX = "BuildingUpGradeCurveByGroupId";

		// Token: 0x04000886 RID: 2182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000887 RID: 2183
		private static int HandleId;
	}
}
