using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000497 RID: 1175
	public class ConfigKurotatoItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x000F5548 File Offset: 0x000F3748
		static ConfigKurotatoItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoItemAll.CreateStaticDefaultValue), new Action(ConfigKurotatoItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000F5568 File Offset: 0x000F3768
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoItem"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoItem`")
			});
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000F55E7 File Offset: 0x000F37E7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoItemAll.LogPair = null;
			ConfigKurotatoItemAll.HandleId = 0;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000F55F5 File Offset: 0x000F37F5
		public static void Init()
		{
			ConfigKurotatoItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoItemAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoItem`");
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000F5610 File Offset: 0x000F3810
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoItem> readOnlyList = (IReadOnlyList<KurotatoItem>)ConfigCommon.GetConfig("KurotatoItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoItem> list = new List<KurotatoItem>();
			while (ConfigCommon.Step(ConfigKurotatoItemAll.HandleId, false, ConfigKurotatoItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoItemAll.HandleId, 0, ConfigKurotatoItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair);
					return null;
				}
				KurotatoItem rootAsKurotatoItem = KurotatoItem.GetRootAsKurotatoItem(new ByteBuffer(item2));
				list.Add(rootAsKurotatoItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair);
			return list;
		}

		// Token: 0x04002005 RID: 8197
		private const string DB = "db_kurotato.db";

		// Token: 0x04002006 RID: 8198
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x04002007 RID: 8199
		private const string TABLE = "KurotatoItem";

		// Token: 0x04002008 RID: 8200
		private const string COMMAND = "select BinData from `KurotatoItem`";

		// Token: 0x04002009 RID: 8201
		private const string KEY_PREFIX = "KurotatoItemAll";

		// Token: 0x0400200A RID: 8202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400200B RID: 8203
		private static int HandleId;
	}
}
