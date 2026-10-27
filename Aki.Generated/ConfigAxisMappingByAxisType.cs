using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C7 RID: 199
	public class ConfigAxisMappingByAxisType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x000741F5 File Offset: 0x000723F5
		static ConfigAxisMappingByAxisType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingByAxisType.CreateStaticDefaultValue), new Action(ConfigAxisMappingByAxisType.ResetStaticDefaultValue));
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00074214 File Offset: 0x00072414
		public static void CreateStaticDefaultValue()
		{
			ConfigAxisMappingByAxisType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAxisMappingByAxisType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "AxisMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `AxisMapping` where AxisType=?")
			});
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00074293 File Offset: 0x00072493
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingByAxisType.LogPair = null;
			ConfigAxisMappingByAxisType.HandleId = 0;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000742A1 File Offset: 0x000724A1
		public static void Init()
		{
			ConfigAxisMappingByAxisType.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingByAxisType.HandleId, "db_input_settings.db", "select BinData from `AxisMapping` where AxisType=?");
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000742BC File Offset: 0x000724BC
		[NullableContext(2)]
		public static IReadOnlyList<AxisMapping> GetConfigList(int p0AxisType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAxisMappingByAxisType.HandleId, ConfigAxisMappingByAxisType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AxisMappingByAxisType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AxisType);
				IReadOnlyList<AxisMapping> readOnlyList = (IReadOnlyList<AxisMapping>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAxisMappingByAxisType.LogPair.Clear();
			ConfigAxisMappingByAxisType.LogPair.Add(new ValueTuple<string, object>("AxisType", p0AxisType));
			if (!ConfigCommon.BindInt(ConfigAxisMappingByAxisType.HandleId, 1, p0AxisType, ConfigAxisMappingByAxisType.LogPair))
			{
				ConfigCommon.Reset(ConfigAxisMappingByAxisType.HandleId, ConfigAxisMappingByAxisType.LogPair);
				return null;
			}
			List<AxisMapping> list = new List<AxisMapping>();
			while (ConfigCommon.Step(ConfigAxisMappingByAxisType.HandleId, false, ConfigAxisMappingByAxisType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAxisMappingByAxisType.HandleId, 0, ConfigAxisMappingByAxisType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAxisMappingByAxisType.HandleId, ConfigAxisMappingByAxisType.LogPair);
					return null;
				}
				AxisMapping rootAsAxisMapping = AxisMapping.GetRootAsAxisMapping(new ByteBuffer(item2));
				list.Add(rootAsAxisMapping);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AxisMappingByAxisType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AxisType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAxisMappingByAxisType.HandleId, ConfigAxisMappingByAxisType.LogPair);
			return list;
		}

		// Token: 0x04000555 RID: 1365
		private const string DB = "db_input_settings.db";

		// Token: 0x04000556 RID: 1366
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000557 RID: 1367
		private const string TABLE = "AxisMapping";

		// Token: 0x04000558 RID: 1368
		private const string COMMAND = "select BinData from `AxisMapping` where AxisType=?";

		// Token: 0x04000559 RID: 1369
		private const string KEY_PREFIX = "AxisMappingByAxisType";

		// Token: 0x0400055A RID: 1370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400055B RID: 1371
		private static int HandleId;
	}
}
