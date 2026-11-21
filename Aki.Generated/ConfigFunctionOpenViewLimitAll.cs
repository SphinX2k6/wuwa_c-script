using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000372 RID: 882
	public class ConfigFunctionOpenViewLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014B1 RID: 5297 RVA: 0x000D1F8C File Offset: 0x000D018C
		static ConfigFunctionOpenViewLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionOpenViewLimitAll.CreateStaticDefaultValue), new Action(ConfigFunctionOpenViewLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000D1FAC File Offset: 0x000D01AC
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionOpenViewLimitAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionOpenViewLimitAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionOpenViewLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionOpenViewLimit`")
			});
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000D202B File Offset: 0x000D022B
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionOpenViewLimitAll.LogPair = null;
			ConfigFunctionOpenViewLimitAll.HandleId = 0;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000D2039 File Offset: 0x000D0239
		public static void Init()
		{
			ConfigFunctionOpenViewLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionOpenViewLimitAll.HandleId, "db_function.db", "select BinData from `FunctionOpenViewLimit`");
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000D2054 File Offset: 0x000D0254
		[NullableContext(2)]
		public static IReadOnlyList<FunctionOpenViewLimit> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionOpenViewLimitAll.HandleId, ConfigFunctionOpenViewLimitAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FunctionOpenViewLimit> readOnlyList = (IReadOnlyList<FunctionOpenViewLimit>)ConfigCommon.GetConfig("FunctionOpenViewLimitAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FunctionOpenViewLimit> list = new List<FunctionOpenViewLimit>();
			while (ConfigCommon.Step(ConfigFunctionOpenViewLimitAll.HandleId, false, ConfigFunctionOpenViewLimitAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionOpenViewLimitAll.HandleId, 0, ConfigFunctionOpenViewLimitAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFunctionOpenViewLimitAll.HandleId, ConfigFunctionOpenViewLimitAll.LogPair);
					return null;
				}
				FunctionOpenViewLimit rootAsFunctionOpenViewLimit = FunctionOpenViewLimit.GetRootAsFunctionOpenViewLimit(new ByteBuffer(item2));
				list.Add(rootAsFunctionOpenViewLimit);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FunctionOpenViewLimitAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFunctionOpenViewLimitAll.HandleId, ConfigFunctionOpenViewLimitAll.LogPair);
			return list;
		}

		// Token: 0x04001802 RID: 6146
		private const string DB = "db_function.db";

		// Token: 0x04001803 RID: 6147
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x04001804 RID: 6148
		private const string TABLE = "FunctionOpenViewLimit";

		// Token: 0x04001805 RID: 6149
		private const string COMMAND = "select BinData from `FunctionOpenViewLimit`";

		// Token: 0x04001806 RID: 6150
		private const string KEY_PREFIX = "FunctionOpenViewLimitAll";

		// Token: 0x04001807 RID: 6151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001808 RID: 6152
		private static int HandleId;
	}
}
