using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012C RID: 300
	public class ConfigBuildingUpGradeCurveByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x000816D0 File Offset: 0x0007F8D0
		static ConfigBuildingUpGradeCurveByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuildingUpGradeCurveByGroupId.CreateStaticDefaultValue), new Action(ConfigBuildingUpGradeCurveByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000816F0 File Offset: 0x0007F8F0
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

		// Token: 0x0600070B RID: 1803 RVA: 0x0008176F File Offset: 0x0007F96F
		public static void ResetStaticDefaultValue()
		{
			ConfigBuildingUpGradeCurveByGroupId.LogPair = null;
			ConfigBuildingUpGradeCurveByGroupId.HandleId = 0;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0008177D File Offset: 0x0007F97D
		public static void Init()
		{
			ConfigBuildingUpGradeCurveByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBuildingUpGradeCurveByGroupId.HandleId, "db_moonchasing.db", "select BinData from `BuildingUpGradeCurve` where GroupId=?");
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00081798 File Offset: 0x0007F998
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

		// Token: 0x04000818 RID: 2072
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000819 RID: 2073
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400081A RID: 2074
		private const string TABLE = "BuildingUpGradeCurve";

		// Token: 0x0400081B RID: 2075
		private const string COMMAND = "select BinData from `BuildingUpGradeCurve` where GroupId=?";

		// Token: 0x0400081C RID: 2076
		private const string KEY_PREFIX = "BuildingUpGradeCurveByGroupId";

		// Token: 0x0400081D RID: 2077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400081E RID: 2078
		private static int HandleId;
	}
}
