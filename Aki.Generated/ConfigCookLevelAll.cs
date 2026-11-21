using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B0 RID: 432
	public class ConfigCookLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x00096608 File Offset: 0x00094808
		static ConfigCookLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookLevelAll.CreateStaticDefaultValue), new Action(ConfigCookLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00096628 File Offset: 0x00094828
		public static void CreateStaticDefaultValue()
		{
			ConfigCookLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CookLevel`")
			});
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000966A7 File Offset: 0x000948A7
		public static void ResetStaticDefaultValue()
		{
			ConfigCookLevelAll.LogPair = null;
			ConfigCookLevelAll.HandleId = 0;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000966B5 File Offset: 0x000948B5
		public static void Init()
		{
			ConfigCookLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookLevelAll.HandleId, "db_cook.db", "select BinData from `CookLevel`");
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000966D0 File Offset: 0x000948D0
		[NullableContext(2)]
		public static IReadOnlyList<CookLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookLevelAll.HandleId, ConfigCookLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CookLevel> readOnlyList = (IReadOnlyList<CookLevel>)ConfigCommon.GetConfig("CookLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CookLevel> list = new List<CookLevel>();
			while (ConfigCommon.Step(ConfigCookLevelAll.HandleId, false, ConfigCookLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookLevelAll.HandleId, 0, ConfigCookLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCookLevelAll.HandleId, ConfigCookLevelAll.LogPair);
					return null;
				}
				CookLevel rootAsCookLevel = CookLevel.GetRootAsCookLevel(new ByteBuffer(item2));
				list.Add(rootAsCookLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CookLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCookLevelAll.HandleId, ConfigCookLevelAll.LogPair);
			return list;
		}

		// Token: 0x04000BB4 RID: 2996
		private const string DB = "db_cook.db";

		// Token: 0x04000BB5 RID: 2997
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BB6 RID: 2998
		private const string TABLE = "CookLevel";

		// Token: 0x04000BB7 RID: 2999
		private const string COMMAND = "select BinData from `CookLevel`";

		// Token: 0x04000BB8 RID: 3000
		private const string KEY_PREFIX = "CookLevelAll";

		// Token: 0x04000BB9 RID: 3001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BBA RID: 3002
		private static int HandleId;
	}
}
