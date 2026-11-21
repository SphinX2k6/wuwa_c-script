using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AF RID: 1199
	public class ConfigKurotatoLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C25 RID: 7205 RVA: 0x000FC078 File Offset: 0x000FA278
		static ConfigKurotatoLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000FC098 File Offset: 0x000FA298
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevel`")
			});
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000FC117 File Offset: 0x000FA317
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelAll.LogPair = null;
			ConfigKurotatoLevelAll.HandleId = 0;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000FC125 File Offset: 0x000FA325
		public static void Init()
		{
			ConfigKurotatoLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel`");
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000FC140 File Offset: 0x000FA340
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelAll.HandleId, ConfigKurotatoLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoLevel> readOnlyList = (IReadOnlyList<KurotatoLevel>)ConfigCommon.GetConfig("KurotatoLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoLevel> list = new List<KurotatoLevel>();
			while (ConfigCommon.Step(ConfigKurotatoLevelAll.HandleId, false, ConfigKurotatoLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelAll.HandleId, 0, ConfigKurotatoLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLevelAll.HandleId, ConfigKurotatoLevelAll.LogPair);
					return null;
				}
				KurotatoLevel rootAsKurotatoLevel = KurotatoLevel.GetRootAsKurotatoLevel(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelAll.HandleId, ConfigKurotatoLevelAll.LogPair);
			return list;
		}

		// Token: 0x040020AD RID: 8365
		private const string DB = "db_kurotato.db";

		// Token: 0x040020AE RID: 8366
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020AF RID: 8367
		private const string TABLE = "KurotatoLevel";

		// Token: 0x040020B0 RID: 8368
		private const string COMMAND = "select BinData from `KurotatoLevel`";

		// Token: 0x040020B1 RID: 8369
		private const string KEY_PREFIX = "KurotatoLevelAll";

		// Token: 0x040020B2 RID: 8370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020B3 RID: 8371
		private static int HandleId;
	}
}
