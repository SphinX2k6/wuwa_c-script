using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000355 RID: 853
	public class ConfigFuncMenuReplaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x000CAA5B File Offset: 0x000C8C5B
		static ConfigFuncMenuReplaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceAll.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000CAA7C File Offset: 0x000C8C7C
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuReplaceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuReplaceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuReplace`")
			});
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000CAAFB File Offset: 0x000C8CFB
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceAll.LogPair = null;
			ConfigFuncMenuReplaceAll.HandleId = 0;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000CAB09 File Offset: 0x000C8D09
		public static void Init()
		{
			ConfigFuncMenuReplaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceAll.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace`");
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000CAB24 File Offset: 0x000C8D24
		[NullableContext(2)]
		public static IReadOnlyList<FuncMenuReplace> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FuncMenuReplace> readOnlyList = (IReadOnlyList<FuncMenuReplace>)ConfigCommon.GetConfig("FuncMenuReplaceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FuncMenuReplace> list = new List<FuncMenuReplace>();
			while (ConfigCommon.Step(ConfigFuncMenuReplaceAll.HandleId, false, ConfigFuncMenuReplaceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuReplaceAll.HandleId, 0, ConfigFuncMenuReplaceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair);
					return null;
				}
				FuncMenuReplace rootAsFuncMenuReplace = FuncMenuReplace.GetRootAsFuncMenuReplace(new ByteBuffer(item2));
				list.Add(rootAsFuncMenuReplace);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FuncMenuReplaceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFuncMenuReplaceAll.HandleId, ConfigFuncMenuReplaceAll.LogPair);
			return list;
		}

		// Token: 0x04001737 RID: 5943
		private const string DB = "db_roulette.db";

		// Token: 0x04001738 RID: 5944
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x04001739 RID: 5945
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x0400173A RID: 5946
		private const string COMMAND = "select BinData from `FuncMenuReplace`";

		// Token: 0x0400173B RID: 5947
		private const string KEY_PREFIX = "FuncMenuReplaceAll";

		// Token: 0x0400173C RID: 5948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400173D RID: 5949
		private static int HandleId;
	}
}
