using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D6 RID: 214
	public class ConfigAxisMappingByAxisType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x00079B59 File Offset: 0x00077D59
		static ConfigAxisMappingByAxisType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingByAxisType.CreateStaticDefaultValue), new Action(ConfigAxisMappingByAxisType.ResetStaticDefaultValue));
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00079B78 File Offset: 0x00077D78
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

		// Token: 0x06000507 RID: 1287 RVA: 0x00079BF7 File Offset: 0x00077DF7
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingByAxisType.LogPair = null;
			ConfigAxisMappingByAxisType.HandleId = 0;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00079C05 File Offset: 0x00077E05
		public static void Init()
		{
			ConfigAxisMappingByAxisType.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingByAxisType.HandleId, "db_input_settings.db", "select BinData from `AxisMapping` where AxisType=?");
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00079C20 File Offset: 0x00077E20
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

		// Token: 0x040005BE RID: 1470
		private const string DB = "db_input_settings.db";

		// Token: 0x040005BF RID: 1471
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040005C0 RID: 1472
		private const string TABLE = "AxisMapping";

		// Token: 0x040005C1 RID: 1473
		private const string COMMAND = "select BinData from `AxisMapping` where AxisType=?";

		// Token: 0x040005C2 RID: 1474
		private const string KEY_PREFIX = "AxisMappingByAxisType";

		// Token: 0x040005C3 RID: 1475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005C4 RID: 1476
		private static int HandleId;
	}
}
