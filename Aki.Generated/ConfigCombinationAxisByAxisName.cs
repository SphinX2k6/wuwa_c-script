using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017D RID: 381
	public class ConfigCombinationAxisByAxisName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x0008BE8F File Offset: 0x0008A08F
		static ConfigCombinationAxisByAxisName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisByAxisName.CreateStaticDefaultValue), new Action(ConfigCombinationAxisByAxisName.ResetStaticDefaultValue));
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationAxisByAxisName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAxis"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAxis` where AxisName=?")
			});
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0008BF2F File Offset: 0x0008A12F
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisName.LogPair = null;
			ConfigCombinationAxisByAxisName.HandleId = 0;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0008BF3D File Offset: 0x0008A13D
		public static void Init()
		{
			ConfigCombinationAxisByAxisName.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisByAxisName.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where AxisName=?");
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0008BF58 File Offset: 0x0008A158
		public static CombinationAxis? GetConfig(string p0AxisName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationAxisByAxisName.HandleId, ConfigCombinationAxisByAxisName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CombinationAxisByAxisName#" + p0AxisName);
				if (configBuffer != null)
				{
					return new CombinationAxis?(CombinationAxis.GetRootAsCombinationAxis(configBuffer));
				}
			}
			ConfigCombinationAxisByAxisName.LogPair.Clear();
			ConfigCombinationAxisByAxisName.LogPair.Add(new ValueTuple<string, object>("AxisName", p0AxisName));
			if (!ConfigCommon.BindString(ConfigCombinationAxisByAxisName.HandleId, 1, p0AxisName, ConfigCombinationAxisByAxisName.LogPair) || ConfigCommon.Step(ConfigCombinationAxisByAxisName.HandleId, true, ConfigCombinationAxisByAxisName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCombinationAxisByAxisName.HandleId, ConfigCombinationAxisByAxisName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationAxisByAxisName.HandleId, 0, ConfigCombinationAxisByAxisName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCombinationAxisByAxisName.HandleId, ConfigCombinationAxisByAxisName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CombinationAxis rootAsCombinationAxis = CombinationAxis.GetRootAsCombinationAxis(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CombinationAxisByAxisName#" + p0AxisName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCombinationAxisByAxisName.HandleId, ConfigCombinationAxisByAxisName.LogPair);
			return new CombinationAxis?(rootAsCombinationAxis);
		}

		// Token: 0x04000A4F RID: 2639
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A50 RID: 2640
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A51 RID: 2641
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000A52 RID: 2642
		private const string COMMAND = "select BinData from `CombinationAxis` where AxisName=?";

		// Token: 0x04000A53 RID: 2643
		private const string KEY_PREFIX = "CombinationAxisByAxisName";

		// Token: 0x04000A54 RID: 2644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A55 RID: 2645
		private static int HandleId;
	}
}
