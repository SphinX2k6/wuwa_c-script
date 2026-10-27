using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A7 RID: 1191
	public class ConfigKurotatoMonsterTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BF5 RID: 7157 RVA: 0x000F7720 File Offset: 0x000F5920
		static ConfigKurotatoMonsterTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTagAll.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000F7740 File Offset: 0x000F5940
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

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000F77BF File Offset: 0x000F59BF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagAll.LogPair = null;
			ConfigKurotatoMonsterTagAll.HandleId = 0;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000F77CD File Offset: 0x000F59CD
		public static void Init()
		{
			ConfigKurotatoMonsterTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTagAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterTag`");
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000F77E8 File Offset: 0x000F59E8
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

		// Token: 0x04002075 RID: 8309
		private const string DB = "db_kurotato.db";

		// Token: 0x04002076 RID: 8310
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002077 RID: 8311
		private const string TABLE = "KurotatoMonsterTag";

		// Token: 0x04002078 RID: 8312
		private const string COMMAND = "select BinData from `KurotatoMonsterTag`";

		// Token: 0x04002079 RID: 8313
		private const string KEY_PREFIX = "KurotatoMonsterTagAll";

		// Token: 0x0400207A RID: 8314
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400207B RID: 8315
		private static int HandleId;
	}
}
