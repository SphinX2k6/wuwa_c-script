using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018A RID: 394
	public class ConfigCombinationActionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x00091428 File Offset: 0x0008F628
		static ConfigCombinationActionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionAll.CreateStaticDefaultValue), new Action(ConfigCombinationActionAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00091448 File Offset: 0x0008F648
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationActionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationActionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAction"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAction`")
			});
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000914C7 File Offset: 0x0008F6C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionAll.LogPair = null;
			ConfigCombinationActionAll.HandleId = 0;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000914D5 File Offset: 0x0008F6D5
		public static void Init()
		{
			ConfigCombinationActionAll.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionAll.HandleId, "db_input_settings.db", "select BinData from `CombinationAction`");
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000914F0 File Offset: 0x0008F6F0
		[NullableContext(2)]
		public static IReadOnlyList<CombinationAction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationActionAll.HandleId, ConfigCombinationActionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CombinationAction> readOnlyList = (IReadOnlyList<CombinationAction>)ConfigCommon.GetConfig("CombinationActionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CombinationAction> list = new List<CombinationAction>();
			while (ConfigCommon.Step(ConfigCombinationActionAll.HandleId, false, ConfigCombinationActionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationActionAll.HandleId, 0, ConfigCombinationActionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCombinationActionAll.HandleId, ConfigCombinationActionAll.LogPair);
					return null;
				}
				CombinationAction rootAsCombinationAction = CombinationAction.GetRootAsCombinationAction(new ByteBuffer(item2));
				list.Add(rootAsCombinationAction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CombinationActionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCombinationActionAll.HandleId, ConfigCombinationActionAll.LogPair);
			return list;
		}

		// Token: 0x04000AAA RID: 2730
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AAB RID: 2731
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000AAC RID: 2732
		private const string TABLE = "CombinationAction";

		// Token: 0x04000AAD RID: 2733
		private const string COMMAND = "select BinData from `CombinationAction`";

		// Token: 0x04000AAE RID: 2734
		private const string KEY_PREFIX = "CombinationActionAll";

		// Token: 0x04000AAF RID: 2735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AB0 RID: 2736
		private static int HandleId;
	}
}
