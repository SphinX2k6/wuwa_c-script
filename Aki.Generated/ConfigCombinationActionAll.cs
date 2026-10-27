using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000178 RID: 376
	public class ConfigCombinationActionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0008B4F0 File Offset: 0x000896F0
		static ConfigCombinationActionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionAll.CreateStaticDefaultValue), new Action(ConfigCombinationActionAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0008B510 File Offset: 0x00089710
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

		// Token: 0x060008D3 RID: 2259 RVA: 0x0008B58F File Offset: 0x0008978F
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionAll.LogPair = null;
			ConfigCombinationActionAll.HandleId = 0;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0008B59D File Offset: 0x0008979D
		public static void Init()
		{
			ConfigCombinationActionAll.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionAll.HandleId, "db_input_settings.db", "select BinData from `CombinationAction`");
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0008B5B8 File Offset: 0x000897B8
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

		// Token: 0x04000A2C RID: 2604
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A2D RID: 2605
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A2E RID: 2606
		private const string TABLE = "CombinationAction";

		// Token: 0x04000A2F RID: 2607
		private const string COMMAND = "select BinData from `CombinationAction`";

		// Token: 0x04000A30 RID: 2608
		private const string KEY_PREFIX = "CombinationActionAll";

		// Token: 0x04000A31 RID: 2609
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A32 RID: 2610
		private static int HandleId;
	}
}
