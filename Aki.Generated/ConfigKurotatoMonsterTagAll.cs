using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BD RID: 1213
	public class ConfigKurotatoMonsterTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x000FDE74 File Offset: 0x000FC074
		static ConfigKurotatoMonsterTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTagAll.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000FDE94 File Offset: 0x000FC094
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterTag`")
			});
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000FDF13 File Offset: 0x000FC113
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagAll.LogPair = null;
			ConfigKurotatoMonsterTagAll.HandleId = 0;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000FDF21 File Offset: 0x000FC121
		public static void Init()
		{
			ConfigKurotatoMonsterTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTagAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterTag`");
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000FDF3C File Offset: 0x000FC13C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoMonsterTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterTagAll.HandleId, ConfigKurotatoMonsterTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoMonsterTag> readOnlyList = (IReadOnlyList<KurotatoMonsterTag>)ConfigCommon.GetConfig("KurotatoMonsterTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoMonsterTag> list = new List<KurotatoMonsterTag>();
			while (ConfigCommon.Step(ConfigKurotatoMonsterTagAll.HandleId, false, ConfigKurotatoMonsterTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterTagAll.HandleId, 0, ConfigKurotatoMonsterTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoMonsterTagAll.HandleId, ConfigKurotatoMonsterTagAll.LogPair);
					return null;
				}
				KurotatoMonsterTag rootAsKurotatoMonsterTag = KurotatoMonsterTag.GetRootAsKurotatoMonsterTag(new ByteBuffer(item2));
				list.Add(rootAsKurotatoMonsterTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoMonsterTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterTagAll.HandleId, ConfigKurotatoMonsterTagAll.LogPair);
			return list;
		}

		// Token: 0x0400210F RID: 8463
		private const string DB = "db_kurotato.db";

		// Token: 0x04002110 RID: 8464
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002111 RID: 8465
		private const string TABLE = "KurotatoMonsterTag";

		// Token: 0x04002112 RID: 8466
		private const string COMMAND = "select BinData from `KurotatoMonsterTag`";

		// Token: 0x04002113 RID: 8467
		private const string KEY_PREFIX = "KurotatoMonsterTagAll";

		// Token: 0x04002114 RID: 8468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002115 RID: 8469
		private static int HandleId;
	}
}
