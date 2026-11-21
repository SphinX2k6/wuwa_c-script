using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D5 RID: 213
	public class ConfigAxisMappingByAxisName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x0007995F File Offset: 0x00077B5F
		static ConfigAxisMappingByAxisName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingByAxisName.CreateStaticDefaultValue), new Action(ConfigAxisMappingByAxisName.ResetStaticDefaultValue));
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00079980 File Offset: 0x00077B80
		public static void CreateStaticDefaultValue()
		{
			ConfigAxisMappingByAxisName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAxisMappingByAxisName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "AxisMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `AxisMapping` where AxisName=?")
			});
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000799FF File Offset: 0x00077BFF
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingByAxisName.LogPair = null;
			ConfigAxisMappingByAxisName.HandleId = 0;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00079A0D File Offset: 0x00077C0D
		public static void Init()
		{
			ConfigAxisMappingByAxisName.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingByAxisName.HandleId, "db_input_settings.db", "select BinData from `AxisMapping` where AxisName=?");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00079A28 File Offset: 0x00077C28
		public static AxisMapping? GetConfig(string p0AxisName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAxisMappingByAxisName.HandleId, ConfigAxisMappingByAxisName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("AxisMappingByAxisName#" + p0AxisName);
				if (configBuffer != null)
				{
					return new AxisMapping?(AxisMapping.GetRootAsAxisMapping(configBuffer));
				}
			}
			ConfigAxisMappingByAxisName.LogPair.Clear();
			ConfigAxisMappingByAxisName.LogPair.Add(new ValueTuple<string, object>("AxisName", p0AxisName));
			if (!ConfigCommon.BindString(ConfigAxisMappingByAxisName.HandleId, 1, p0AxisName, ConfigAxisMappingByAxisName.LogPair) || ConfigCommon.Step(ConfigAxisMappingByAxisName.HandleId, true, ConfigAxisMappingByAxisName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAxisMappingByAxisName.HandleId, ConfigAxisMappingByAxisName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAxisMappingByAxisName.HandleId, 0, ConfigAxisMappingByAxisName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAxisMappingByAxisName.HandleId, ConfigAxisMappingByAxisName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AxisMapping rootAsAxisMapping = AxisMapping.GetRootAsAxisMapping(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("AxisMappingByAxisName#" + p0AxisName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAxisMappingByAxisName.HandleId, ConfigAxisMappingByAxisName.LogPair);
			return new AxisMapping?(rootAsAxisMapping);
		}

		// Token: 0x040005B7 RID: 1463
		private const string DB = "db_input_settings.db";

		// Token: 0x040005B8 RID: 1464
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040005B9 RID: 1465
		private const string TABLE = "AxisMapping";

		// Token: 0x040005BA RID: 1466
		private const string COMMAND = "select BinData from `AxisMapping` where AxisName=?";

		// Token: 0x040005BB RID: 1467
		private const string KEY_PREFIX = "AxisMappingByAxisName";

		// Token: 0x040005BC RID: 1468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005BD RID: 1469
		private static int HandleId;
	}
}
