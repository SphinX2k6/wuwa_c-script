using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AA RID: 1194
	public class ConfigKurotatoPropertyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x000F7D44 File Offset: 0x000F5F44
		static ConfigKurotatoPropertyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyAll.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000F7D64 File Offset: 0x000F5F64
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

		// Token: 0x06001C09 RID: 7177 RVA: 0x000F7DE3 File Offset: 0x000F5FE3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyAll.LogPair = null;
			ConfigKurotatoPropertyAll.HandleId = 0;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000F7DF1 File Offset: 0x000F5FF1
		public static void Init()
		{
			ConfigKurotatoPropertyAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty`");
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000F7E0C File Offset: 0x000F600C
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

		// Token: 0x0400208A RID: 8330
		private const string DB = "db_kurotato.db";

		// Token: 0x0400208B RID: 8331
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x0400208C RID: 8332
		private const string TABLE = "KurotatoProperty";

		// Token: 0x0400208D RID: 8333
		private const string COMMAND = "select BinData from `KurotatoProperty`";

		// Token: 0x0400208E RID: 8334
		private const string KEY_PREFIX = "KurotatoPropertyAll";

		// Token: 0x0400208F RID: 8335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002090 RID: 8336
		private static int HandleId;
	}
}
