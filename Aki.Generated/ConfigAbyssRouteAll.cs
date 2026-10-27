using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002B RID: 43
	public class ConfigAbyssRouteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0005F804 File Offset: 0x0005DA04
		static ConfigAbyssRouteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRouteAll.CreateStaticDefaultValue), new Action(ConfigAbyssRouteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0005F824 File Offset: 0x0005DA24
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRouteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRouteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoute"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoute`")
			});
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0005F8A3 File Offset: 0x0005DAA3
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRouteAll.LogPair = null;
			ConfigAbyssRouteAll.HandleId = 0;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0005F8B1 File Offset: 0x0005DAB1
		public static void Init()
		{
			ConfigAbyssRouteAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRouteAll.HandleId, "db_dangoabyss.db", "select BinData from `AbyssRoute`");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0005F8CC File Offset: 0x0005DACC
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoute> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRouteAll.HandleId, ConfigAbyssRouteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRoute> readOnlyList = (IReadOnlyList<AbyssRoute>)ConfigCommon.GetConfig("AbyssRouteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRoute> list = new List<AbyssRoute>();
			while (ConfigCommon.Step(ConfigAbyssRouteAll.HandleId, false, ConfigAbyssRouteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRouteAll.HandleId, 0, ConfigAbyssRouteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRouteAll.HandleId, ConfigAbyssRouteAll.LogPair);
					return null;
				}
				AbyssRoute rootAsAbyssRoute = AbyssRoute.GetRootAsAbyssRoute(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoute);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRouteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRouteAll.HandleId, ConfigAbyssRouteAll.LogPair);
			return list;
		}

		// Token: 0x04000111 RID: 273
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000112 RID: 274
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000113 RID: 275
		private const string TABLE = "AbyssRoute";

		// Token: 0x04000114 RID: 276
		private const string COMMAND = "select BinData from `AbyssRoute`";

		// Token: 0x04000115 RID: 277
		private const string KEY_PREFIX = "AbyssRouteAll";

		// Token: 0x04000116 RID: 278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000117 RID: 279
		private static int HandleId;
	}
}
