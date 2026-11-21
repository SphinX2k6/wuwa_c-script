using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C0 RID: 1216
	public class ConfigKurotatoPropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x000FE498 File Offset: 0x000FC698
		static ConfigKurotatoPropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyAll.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000FE4B8 File Offset: 0x000FC6B8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoPropertyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoPropertyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoProperty`")
			});
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000FE537 File Offset: 0x000FC737
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyAll.LogPair = null;
			ConfigKurotatoPropertyAll.HandleId = 0;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000FE545 File Offset: 0x000FC745
		public static void Init()
		{
			ConfigKurotatoPropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty`");
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000FE560 File Offset: 0x000FC760
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoProperty> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoPropertyAll.HandleId, ConfigKurotatoPropertyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoProperty> readOnlyList = (IReadOnlyList<KurotatoProperty>)ConfigCommon.GetConfig("KurotatoPropertyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoProperty> list = new List<KurotatoProperty>();
			while (ConfigCommon.Step(ConfigKurotatoPropertyAll.HandleId, false, ConfigKurotatoPropertyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoPropertyAll.HandleId, 0, ConfigKurotatoPropertyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoPropertyAll.HandleId, ConfigKurotatoPropertyAll.LogPair);
					return null;
				}
				KurotatoProperty rootAsKurotatoProperty = KurotatoProperty.GetRootAsKurotatoProperty(new ByteBuffer(item2));
				list.Add(rootAsKurotatoProperty);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoPropertyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoPropertyAll.HandleId, ConfigKurotatoPropertyAll.LogPair);
			return list;
		}

		// Token: 0x04002124 RID: 8484
		private const string DB = "db_kurotato.db";

		// Token: 0x04002125 RID: 8485
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002126 RID: 8486
		private const string TABLE = "KurotatoProperty";

		// Token: 0x04002127 RID: 8487
		private const string COMMAND = "select BinData from `KurotatoProperty`";

		// Token: 0x04002128 RID: 8488
		private const string KEY_PREFIX = "KurotatoPropertyAll";

		// Token: 0x04002129 RID: 8489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400212A RID: 8490
		private static int HandleId;
	}
}
