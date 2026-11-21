using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A5 RID: 1189
	public class ConfigKurotatoExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BE8 RID: 7144 RVA: 0x000FAA18 File Offset: 0x000F8C18
		static ConfigKurotatoExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoExpAll.CreateStaticDefaultValue), new Action(ConfigKurotatoExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000FAA38 File Offset: 0x000F8C38
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoExpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoExpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoExp"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoExp`")
			});
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000FAAB7 File Offset: 0x000F8CB7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoExpAll.LogPair = null;
			ConfigKurotatoExpAll.HandleId = 0;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000FAAC5 File Offset: 0x000F8CC5
		public static void Init()
		{
			ConfigKurotatoExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoExpAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoExp`");
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000FAAE0 File Offset: 0x000F8CE0
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoExp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoExp> readOnlyList = (IReadOnlyList<KurotatoExp>)ConfigCommon.GetConfig("KurotatoExpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoExp> list = new List<KurotatoExp>();
			while (ConfigCommon.Step(ConfigKurotatoExpAll.HandleId, false, ConfigKurotatoExpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpAll.HandleId, 0, ConfigKurotatoExpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair);
					return null;
				}
				KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(new ByteBuffer(item2));
				list.Add(rootAsKurotatoExp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoExpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair);
			return list;
		}

		// Token: 0x04002067 RID: 8295
		private const string DB = "db_kurotato.db";

		// Token: 0x04002068 RID: 8296
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002069 RID: 8297
		private const string TABLE = "KurotatoExp";

		// Token: 0x0400206A RID: 8298
		private const string COMMAND = "select BinData from `KurotatoExp`";

		// Token: 0x0400206B RID: 8299
		private const string KEY_PREFIX = "KurotatoExpAll";

		// Token: 0x0400206C RID: 8300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400206D RID: 8301
		private static int HandleId;
	}
}
