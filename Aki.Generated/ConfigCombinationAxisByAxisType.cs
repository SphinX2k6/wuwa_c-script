using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017E RID: 382
	public class ConfigCombinationAxisByAxisType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x0008C089 File Offset: 0x0008A289
		static ConfigCombinationAxisByAxisType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisByAxisType.CreateStaticDefaultValue), new Action(ConfigCombinationAxisByAxisType.ResetStaticDefaultValue));
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0008C0A8 File Offset: 0x0008A2A8
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

		// Token: 0x060008F7 RID: 2295 RVA: 0x0008C127 File Offset: 0x0008A327
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisType.LogPair = null;
			ConfigCombinationAxisByAxisType.HandleId = 0;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0008C135 File Offset: 0x0008A335
		public static void Init()
		{
			ConfigCombinationAxisByAxisType.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisByAxisType.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where AxisType=?");
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0008C150 File Offset: 0x0008A350
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

		// Token: 0x04000A56 RID: 2646
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A57 RID: 2647
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A58 RID: 2648
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000A59 RID: 2649
		private const string COMMAND = "select BinData from `CombinationAxis` where AxisType=?";

		// Token: 0x04000A5A RID: 2650
		private const string KEY_PREFIX = "CombinationAxisByAxisType";

		// Token: 0x04000A5B RID: 2651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A5C RID: 2652
		private static int HandleId;
	}
}
