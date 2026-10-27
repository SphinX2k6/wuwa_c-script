using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035D RID: 861
	public class ConfigFunctionOpenViewLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x000CBA80 File Offset: 0x000C9C80
		static ConfigFunctionOpenViewLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionOpenViewLimitAll.CreateStaticDefaultValue), new Action(ConfigFunctionOpenViewLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000CBAA0 File Offset: 0x000C9CA0
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

		// Token: 0x06001435 RID: 5173 RVA: 0x000CBB1F File Offset: 0x000C9D1F
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionOpenViewLimitAll.LogPair = null;
			ConfigFunctionOpenViewLimitAll.HandleId = 0;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000CBB2D File Offset: 0x000C9D2D
		public static void Init()
		{
			ConfigFunctionOpenViewLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionOpenViewLimitAll.HandleId, "db_function.db", "select BinData from `FunctionOpenViewLimit`");
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000CBB48 File Offset: 0x000C9D48
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

		// Token: 0x0400176F RID: 5999
		private const string DB = "db_function.db";

		// Token: 0x04001770 RID: 6000
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x04001771 RID: 6001
		private const string TABLE = "FunctionOpenViewLimit";

		// Token: 0x04001772 RID: 6002
		private const string COMMAND = "select BinData from `FunctionOpenViewLimit`";

		// Token: 0x04001773 RID: 6003
		private const string KEY_PREFIX = "FunctionOpenViewLimitAll";

		// Token: 0x04001774 RID: 6004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001775 RID: 6005
		private static int HandleId;
	}
}
