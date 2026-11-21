using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018F RID: 399
	public class ConfigCombinationAxisByAxisName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x00091DC7 File Offset: 0x0008FFC7
		static ConfigCombinationAxisByAxisName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisByAxisName.CreateStaticDefaultValue), new Action(ConfigCombinationAxisByAxisName.ResetStaticDefaultValue));
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00091DE8 File Offset: 0x0008FFE8
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

		// Token: 0x0600095D RID: 2397 RVA: 0x00091E67 File Offset: 0x00090067
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisByAxisName.LogPair = null;
			ConfigCombinationAxisByAxisName.HandleId = 0;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00091E75 File Offset: 0x00090075
		public static void Init()
		{
			ConfigCombinationAxisByAxisName.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisByAxisName.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where AxisName=?");
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00091E90 File Offset: 0x00090090
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

		// Token: 0x04000ACD RID: 2765
		private const string DB = "db_input_settings.db";

		// Token: 0x04000ACE RID: 2766
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000ACF RID: 2767
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000AD0 RID: 2768
		private const string COMMAND = "select BinData from `CombinationAxis` where AxisName=?";

		// Token: 0x04000AD1 RID: 2769
		private const string KEY_PREFIX = "CombinationAxisByAxisName";

		// Token: 0x04000AD2 RID: 2770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AD3 RID: 2771
		private static int HandleId;
	}
}
