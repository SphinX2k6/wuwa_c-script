using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000370 RID: 880
	public class ConfigFunctionMenuAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x000D1BB0 File Offset: 0x000CFDB0
		static ConfigFunctionMenuAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionMenuAll.CreateStaticDefaultValue), new Action(ConfigFunctionMenuAll.ResetStaticDefaultValue));
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x000D1BD0 File Offset: 0x000CFDD0
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionMenuAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionMenuAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionMenu"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionMenu`")
			});
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000D1C4F File Offset: 0x000CFE4F
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionMenuAll.LogPair = null;
			ConfigFunctionMenuAll.HandleId = 0;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000D1C5D File Offset: 0x000CFE5D
		public static void Init()
		{
			ConfigFunctionMenuAll.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionMenuAll.HandleId, "db_function.db", "select BinData from `FunctionMenu`");
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000D1C78 File Offset: 0x000CFE78
		[NullableContext(2)]
		public static IReadOnlyList<FunctionMenu> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FunctionMenu> readOnlyList = (IReadOnlyList<FunctionMenu>)ConfigCommon.GetConfig("FunctionMenuAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FunctionMenu> list = new List<FunctionMenu>();
			while (ConfigCommon.Step(ConfigFunctionMenuAll.HandleId, false, ConfigFunctionMenuAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionMenuAll.HandleId, 0, ConfigFunctionMenuAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair);
					return null;
				}
				FunctionMenu rootAsFunctionMenu = FunctionMenu.GetRootAsFunctionMenu(new ByteBuffer(item2));
				list.Add(rootAsFunctionMenu);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FunctionMenuAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFunctionMenuAll.HandleId, ConfigFunctionMenuAll.LogPair);
			return list;
		}

		// Token: 0x040017F4 RID: 6132
		private const string DB = "db_function.db";

		// Token: 0x040017F5 RID: 6133
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x040017F6 RID: 6134
		private const string TABLE = "FunctionMenu";

		// Token: 0x040017F7 RID: 6135
		private const string COMMAND = "select BinData from `FunctionMenu`";

		// Token: 0x040017F8 RID: 6136
		private const string KEY_PREFIX = "FunctionMenuAll";

		// Token: 0x040017F9 RID: 6137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017FA RID: 6138
		private static int HandleId;
	}
}
