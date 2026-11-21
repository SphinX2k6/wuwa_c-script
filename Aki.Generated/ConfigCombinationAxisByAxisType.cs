using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000190 RID: 400
	public class ConfigCombinationAxisByAxisType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00091FC1 File Offset: 0x000901C1
		static ConfigCombinationAxisByAxisType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisByAxisType.CreateStaticDefaultValue), new Action(ConfigCombinationAxisByAxisType.ResetStaticDefaultValue));
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00091FE0 File Offset: 0x000901E0
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationAxisByAxisType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAxis"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAxis` where AxisType=?")
			});
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0009205F File Offset: 0x0009025F
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisType.LogPair = null;
			ConfigCombinationAxisByAxisType.HandleId = 0;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0009206D File Offset: 0x0009026D
		public static void Init()
		{
			ConfigCombinationAxisByAxisType.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisByAxisType.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where AxisType=?");
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00092088 File Offset: 0x00090288
		[NullableContext(2)]
		public static IReadOnlyList<CombinationAxis> GetConfigList(int p0AxisType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationAxisByAxisType.HandleId, ConfigCombinationAxisByAxisType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationAxisByAxisType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AxisType);
				IReadOnlyList<CombinationAxis> readOnlyList = (IReadOnlyList<CombinationAxis>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCombinationAxisByAxisType.LogPair.Clear();
			ConfigCombinationAxisByAxisType.LogPair.Add(new ValueTuple<string, object>("AxisType", p0AxisType));
			if (!ConfigCommon.BindInt(ConfigCombinationAxisByAxisType.HandleId, 1, p0AxisType, ConfigCombinationAxisByAxisType.LogPair))
			{
				ConfigCommon.Reset(ConfigCombinationAxisByAxisType.HandleId, ConfigCombinationAxisByAxisType.LogPair);
				return null;
			}
			List<CombinationAxis> list = new List<CombinationAxis>();
			while (ConfigCommon.Step(ConfigCombinationAxisByAxisType.HandleId, false, ConfigCombinationAxisByAxisType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationAxisByAxisType.HandleId, 0, ConfigCombinationAxisByAxisType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCombinationAxisByAxisType.HandleId, ConfigCombinationAxisByAxisType.LogPair);
					return null;
				}
				CombinationAxis rootAsCombinationAxis = CombinationAxis.GetRootAsCombinationAxis(new ByteBuffer(item2));
				list.Add(rootAsCombinationAxis);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationAxisByAxisType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AxisType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCombinationAxisByAxisType.HandleId, ConfigCombinationAxisByAxisType.LogPair);
			return list;
		}

		// Token: 0x04000AD4 RID: 2772
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AD5 RID: 2773
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000AD6 RID: 2774
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000AD7 RID: 2775
		private const string COMMAND = "select BinData from `CombinationAxis` where AxisType=?";

		// Token: 0x04000AD8 RID: 2776
		private const string KEY_PREFIX = "CombinationAxisByAxisType";

		// Token: 0x04000AD9 RID: 2777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ADA RID: 2778
		private static int HandleId;
	}
}
