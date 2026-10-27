using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F3 RID: 243
	public class ConfigBlackboardWhiteListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00079F25 File Offset: 0x00078125
		static ConfigBlackboardWhiteListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackboardWhiteListAll.CreateStaticDefaultValue), new Action(ConfigBlackboardWhiteListAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00079F44 File Offset: 0x00078144
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackboardWhiteListAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackboardWhiteListAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI黑板同步白名单.xlsx"),
				new ValueTuple<string, object>("表名", "BlackboardWhiteList"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackboardWhiteList`")
			});
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00079FC3 File Offset: 0x000781C3
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackboardWhiteListAll.LogPair = null;
			ConfigBlackboardWhiteListAll.HandleId = 0;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00079FD1 File Offset: 0x000781D1
		public static void Init()
		{
			ConfigBlackboardWhiteListAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackboardWhiteListAll.HandleId, "db_ai.db", "select BinData from `BlackboardWhiteList`");
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00079FEC File Offset: 0x000781EC
		[NullableContext(2)]
		public static IReadOnlyList<BlackboardWhiteList> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackboardWhiteListAll.HandleId, ConfigBlackboardWhiteListAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BlackboardWhiteList> readOnlyList = (IReadOnlyList<BlackboardWhiteList>)ConfigCommon.GetConfig("BlackboardWhiteListAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BlackboardWhiteList> list = new List<BlackboardWhiteList>();
			while (ConfigCommon.Step(ConfigBlackboardWhiteListAll.HandleId, false, ConfigBlackboardWhiteListAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackboardWhiteListAll.HandleId, 0, ConfigBlackboardWhiteListAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackboardWhiteListAll.HandleId, ConfigBlackboardWhiteListAll.LogPair);
					return null;
				}
				BlackboardWhiteList rootAsBlackboardWhiteList = BlackboardWhiteList.GetRootAsBlackboardWhiteList(new ByteBuffer(item2));
				list.Add(rootAsBlackboardWhiteList);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BlackboardWhiteListAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackboardWhiteListAll.HandleId, ConfigBlackboardWhiteListAll.LogPair);
			return list;
		}

		// Token: 0x04000689 RID: 1673
		private const string DB = "db_ai.db";

		// Token: 0x0400068A RID: 1674
		private const string FILE = "a.AI黑板同步白名单.xlsx";

		// Token: 0x0400068B RID: 1675
		private const string TABLE = "BlackboardWhiteList";

		// Token: 0x0400068C RID: 1676
		private const string COMMAND = "select BinData from `BlackboardWhiteList`";

		// Token: 0x0400068D RID: 1677
		private const string KEY_PREFIX = "BlackboardWhiteListAll";

		// Token: 0x0400068E RID: 1678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400068F RID: 1679
		private static int HandleId;
	}
}
