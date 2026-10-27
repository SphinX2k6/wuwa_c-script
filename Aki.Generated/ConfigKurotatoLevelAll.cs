using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000499 RID: 1177
	public class ConfigKurotatoLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x000F5924 File Offset: 0x000F3B24
		static ConfigKurotatoLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000F5944 File Offset: 0x000F3B44
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

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000F59C3 File Offset: 0x000F3BC3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelAll.LogPair = null;
			ConfigKurotatoLevelAll.HandleId = 0;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000F59D1 File Offset: 0x000F3BD1
		public static void Init()
		{
			ConfigKurotatoLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel`");
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000F59EC File Offset: 0x000F3BEC
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

		// Token: 0x04002013 RID: 8211
		private const string DB = "db_kurotato.db";

		// Token: 0x04002014 RID: 8212
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002015 RID: 8213
		private const string TABLE = "KurotatoLevel";

		// Token: 0x04002016 RID: 8214
		private const string COMMAND = "select BinData from `KurotatoLevel`";

		// Token: 0x04002017 RID: 8215
		private const string KEY_PREFIX = "KurotatoLevelAll";

		// Token: 0x04002018 RID: 8216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002019 RID: 8217
		private static int HandleId;
	}
}
