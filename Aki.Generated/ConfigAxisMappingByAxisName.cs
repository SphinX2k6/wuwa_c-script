using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C6 RID: 198
	public class ConfigAxisMappingByAxisName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00073FFB File Offset: 0x000721FB
		static ConfigAxisMappingByAxisName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisMappingByAxisName.CreateStaticDefaultValue), new Action(ConfigAxisMappingByAxisName.ResetStaticDefaultValue));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0007401C File Offset: 0x0007221C
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x0007409B File Offset: 0x0007229B
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisMappingByAxisName.LogPair = null;
			ConfigAxisMappingByAxisName.HandleId = 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000740A9 File Offset: 0x000722A9
		public static void Init()
		{
			ConfigAxisMappingByAxisName.HandleId = ConfigCommon.InitDataStatement(ConfigAxisMappingByAxisName.HandleId, "db_input_settings.db", "select BinData from `AxisMapping` where AxisName=?");
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000740C4 File Offset: 0x000722C4
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

		// Token: 0x0400054E RID: 1358
		private const string DB = "db_input_settings.db";

		// Token: 0x0400054F RID: 1359
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000550 RID: 1360
		private const string TABLE = "AxisMapping";

		// Token: 0x04000551 RID: 1361
		private const string COMMAND = "select BinData from `AxisMapping` where AxisName=?";

		// Token: 0x04000552 RID: 1362
		private const string KEY_PREFIX = "AxisMappingByAxisName";

		// Token: 0x04000553 RID: 1363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000554 RID: 1364
		private static int HandleId;
	}
}
