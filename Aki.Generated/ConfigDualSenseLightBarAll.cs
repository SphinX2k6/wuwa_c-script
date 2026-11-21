using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000253 RID: 595
	public class ConfigDualSenseLightBarAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
		static ConfigDualSenseLightBarAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDualSenseLightBarAll.CreateStaticDefaultValue), new Action(ConfigDualSenseLightBarAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000AC0D4 File Offset: 0x000AA2D4
		public static void CreateStaticDefaultValue()
		{
			ConfigDualSenseLightBarAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDualSenseLightBarAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "DualSenseLightBar"),
				new ValueTuple<string, object>("语句", "select BinData from `DualSenseLightBar`")
			});
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000AC153 File Offset: 0x000AA353
		public static void ResetStaticDefaultValue()
		{
			ConfigDualSenseLightBarAll.LogPair = null;
			ConfigDualSenseLightBarAll.HandleId = 0;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000AC161 File Offset: 0x000AA361
		public static void Init()
		{
			ConfigDualSenseLightBarAll.HandleId = ConfigCommon.InitDataStatement(ConfigDualSenseLightBarAll.HandleId, "db_input_settings.db", "select BinData from `DualSenseLightBar`");
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000AC17C File Offset: 0x000AA37C
		[NullableContext(2)]
		public static IReadOnlyList<DualSenseLightBar> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDualSenseLightBarAll.HandleId, ConfigDualSenseLightBarAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DualSenseLightBar> readOnlyList = (IReadOnlyList<DualSenseLightBar>)ConfigCommon.GetConfig("DualSenseLightBarAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DualSenseLightBar> list = new List<DualSenseLightBar>();
			while (ConfigCommon.Step(ConfigDualSenseLightBarAll.HandleId, false, ConfigDualSenseLightBarAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDualSenseLightBarAll.HandleId, 0, ConfigDualSenseLightBarAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDualSenseLightBarAll.HandleId, ConfigDualSenseLightBarAll.LogPair);
					return null;
				}
				DualSenseLightBar rootAsDualSenseLightBar = DualSenseLightBar.GetRootAsDualSenseLightBar(new ByteBuffer(item2));
				list.Add(rootAsDualSenseLightBar);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DualSenseLightBarAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDualSenseLightBarAll.HandleId, ConfigDualSenseLightBarAll.LogPair);
			return list;
		}

		// Token: 0x04001029 RID: 4137
		private const string DB = "db_input_settings.db";

		// Token: 0x0400102A RID: 4138
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x0400102B RID: 4139
		private const string TABLE = "DualSenseLightBar";

		// Token: 0x0400102C RID: 4140
		private const string COMMAND = "select BinData from `DualSenseLightBar`";

		// Token: 0x0400102D RID: 4141
		private const string KEY_PREFIX = "DualSenseLightBarAll";

		// Token: 0x0400102E RID: 4142
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400102F RID: 4143
		private static int HandleId;
	}
}
