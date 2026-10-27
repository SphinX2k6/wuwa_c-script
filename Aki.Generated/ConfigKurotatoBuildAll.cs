using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000485 RID: 1157
	public class ConfigKurotatoBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x000F2E20 File Offset: 0x000F1020
		static ConfigKurotatoBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoBuildAll.CreateStaticDefaultValue), new Action(ConfigKurotatoBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000F2E40 File Offset: 0x000F1040
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoBuildAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoBuildAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_抽取规则.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoBuild`")
			});
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000F2EBF File Offset: 0x000F10BF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoBuildAll.LogPair = null;
			ConfigKurotatoBuildAll.HandleId = 0;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000F2ECD File Offset: 0x000F10CD
		public static void Init()
		{
			ConfigKurotatoBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoBuildAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoBuild`");
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000F2EE8 File Offset: 0x000F10E8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoBuild> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoBuild> readOnlyList = (IReadOnlyList<KurotatoBuild>)ConfigCommon.GetConfig("KurotatoBuildAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoBuild> list = new List<KurotatoBuild>();
			while (ConfigCommon.Step(ConfigKurotatoBuildAll.HandleId, false, ConfigKurotatoBuildAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoBuildAll.HandleId, 0, ConfigKurotatoBuildAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair);
					return null;
				}
				KurotatoBuild rootAsKurotatoBuild = KurotatoBuild.GetRootAsKurotatoBuild(new ByteBuffer(item2));
				list.Add(rootAsKurotatoBuild);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoBuildAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoBuildAll.HandleId, ConfigKurotatoBuildAll.LogPair);
			return list;
		}

		// Token: 0x04001F87 RID: 8071
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F88 RID: 8072
		private const string FILE = "t.土豆兄弟_抽取规则.xlsx";

		// Token: 0x04001F89 RID: 8073
		private const string TABLE = "KurotatoBuild";

		// Token: 0x04001F8A RID: 8074
		private const string COMMAND = "select BinData from `KurotatoBuild`";

		// Token: 0x04001F8B RID: 8075
		private const string KEY_PREFIX = "KurotatoBuildAll";

		// Token: 0x04001F8C RID: 8076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F8D RID: 8077
		private static int HandleId;
	}
}
