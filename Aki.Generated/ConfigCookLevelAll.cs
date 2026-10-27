using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019E RID: 414
	public class ConfigCookLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009B7 RID: 2487 RVA: 0x000906D0 File Offset: 0x0008E8D0
		static ConfigCookLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookLevelAll.CreateStaticDefaultValue), new Action(ConfigCookLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000906F0 File Offset: 0x0008E8F0
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

		// Token: 0x060009B9 RID: 2489 RVA: 0x0009076F File Offset: 0x0008E96F
		public static void ResetStaticDefaultValue()
		{
			ConfigCookLevelAll.LogPair = null;
			ConfigCookLevelAll.HandleId = 0;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0009077D File Offset: 0x0008E97D
		public static void Init()
		{
			ConfigCookLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookLevelAll.HandleId, "db_cook.db", "select BinData from `CookLevel`");
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00090798 File Offset: 0x0008E998
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

		// Token: 0x04000B36 RID: 2870
		private const string DB = "db_cook.db";

		// Token: 0x04000B37 RID: 2871
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B38 RID: 2872
		private const string TABLE = "CookLevel";

		// Token: 0x04000B39 RID: 2873
		private const string COMMAND = "select BinData from `CookLevel`";

		// Token: 0x04000B3A RID: 2874
		private const string KEY_PREFIX = "CookLevelAll";

		// Token: 0x04000B3B RID: 2875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B3C RID: 2876
		private static int HandleId;
	}
}
