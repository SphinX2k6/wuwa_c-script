using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002E RID: 46
	public class ConfigAbyssSettleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0005FE6F File Offset: 0x0005E06F
		static ConfigAbyssSettleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssSettleAll.CreateStaticDefaultValue), new Action(ConfigAbyssSettleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0005FE90 File Offset: 0x0005E090
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssSettleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssSettleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssSettle"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssSettle`")
			});
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0005FF0F File Offset: 0x0005E10F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssSettleAll.LogPair = null;
			ConfigAbyssSettleAll.HandleId = 0;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0005FF1D File Offset: 0x0005E11D
		public static void Init()
		{
			ConfigAbyssSettleAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssSettleAll.HandleId, "db_dangoabyss.db", "select BinData from `AbyssSettle`");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0005FF38 File Offset: 0x0005E138
		[NullableContext(2)]
		public static IReadOnlyList<AbyssSettle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssSettleAll.HandleId, ConfigAbyssSettleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssSettle> readOnlyList = (IReadOnlyList<AbyssSettle>)ConfigCommon.GetConfig("AbyssSettleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssSettle> list = new List<AbyssSettle>();
			while (ConfigCommon.Step(ConfigAbyssSettleAll.HandleId, false, ConfigAbyssSettleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssSettleAll.HandleId, 0, ConfigAbyssSettleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssSettleAll.HandleId, ConfigAbyssSettleAll.LogPair);
					return null;
				}
				AbyssSettle rootAsAbyssSettle = AbyssSettle.GetRootAsAbyssSettle(new ByteBuffer(item2));
				list.Add(rootAsAbyssSettle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssSettleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssSettleAll.HandleId, ConfigAbyssSettleAll.LogPair);
			return list;
		}

		// Token: 0x04000126 RID: 294
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000127 RID: 295
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000128 RID: 296
		private const string TABLE = "AbyssSettle";

		// Token: 0x04000129 RID: 297
		private const string COMMAND = "select BinData from `AbyssSettle`";

		// Token: 0x0400012A RID: 298
		private const string KEY_PREFIX = "AbyssSettleAll";

		// Token: 0x0400012B RID: 299
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400012C RID: 300
		private static int HandleId;
	}
}
