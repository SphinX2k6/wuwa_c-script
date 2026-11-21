using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000102 RID: 258
	public class ConfigBlackboardWhiteListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x0007F889 File Offset: 0x0007DA89
		static ConfigBlackboardWhiteListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackboardWhiteListAll.CreateStaticDefaultValue), new Action(ConfigBlackboardWhiteListAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
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

		// Token: 0x0600060F RID: 1551 RVA: 0x0007F927 File Offset: 0x0007DB27
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackboardWhiteListAll.LogPair = null;
			ConfigBlackboardWhiteListAll.HandleId = 0;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0007F935 File Offset: 0x0007DB35
		public static void Init()
		{
			ConfigBlackboardWhiteListAll.HandleId = ConfigCommon.InitDataStatement(ConfigBlackboardWhiteListAll.HandleId, "db_ai.db", "select BinData from `BlackboardWhiteList`");
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0007F950 File Offset: 0x0007DB50
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

		// Token: 0x040006F2 RID: 1778
		private const string DB = "db_ai.db";

		// Token: 0x040006F3 RID: 1779
		private const string FILE = "a.AI黑板同步白名单.xlsx";

		// Token: 0x040006F4 RID: 1780
		private const string TABLE = "BlackboardWhiteList";

		// Token: 0x040006F5 RID: 1781
		private const string COMMAND = "select BinData from `BlackboardWhiteList`";

		// Token: 0x040006F6 RID: 1782
		private const string KEY_PREFIX = "BlackboardWhiteListAll";

		// Token: 0x040006F7 RID: 1783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006F8 RID: 1784
		private static int HandleId;
	}
}
