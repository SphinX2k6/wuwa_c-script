using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CE RID: 1230
	public class ConfigKurotatoTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CDF RID: 7391 RVA: 0x00100064 File Offset: 0x000FE264
		static ConfigKurotatoTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoTagAll.CreateStaticDefaultValue), new Action(ConfigKurotatoTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00100084 File Offset: 0x000FE284
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_标签.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoTag`")
			});
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00100103 File Offset: 0x000FE303
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoTagAll.LogPair = null;
			ConfigKurotatoTagAll.HandleId = 0;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00100111 File Offset: 0x000FE311
		public static void Init()
		{
			ConfigKurotatoTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoTagAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoTag`");
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0010012C File Offset: 0x000FE32C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoTag> readOnlyList = (IReadOnlyList<KurotatoTag>)ConfigCommon.GetConfig("KurotatoTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoTag> list = new List<KurotatoTag>();
			while (ConfigCommon.Step(ConfigKurotatoTagAll.HandleId, false, ConfigKurotatoTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoTagAll.HandleId, 0, ConfigKurotatoTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair);
					return null;
				}
				KurotatoTag rootAsKurotatoTag = KurotatoTag.GetRootAsKurotatoTag(new ByteBuffer(item2));
				list.Add(rootAsKurotatoTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair);
			return list;
		}

		// Token: 0x04002186 RID: 8582
		private const string DB = "db_kurotato.db";

		// Token: 0x04002187 RID: 8583
		private const string FILE = "t.土豆兄弟_标签.xlsx";

		// Token: 0x04002188 RID: 8584
		private const string TABLE = "KurotatoTag";

		// Token: 0x04002189 RID: 8585
		private const string COMMAND = "select BinData from `KurotatoTag`";

		// Token: 0x0400218A RID: 8586
		private const string KEY_PREFIX = "KurotatoTagAll";

		// Token: 0x0400218B RID: 8587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400218C RID: 8588
		private static int HandleId;
	}
}
