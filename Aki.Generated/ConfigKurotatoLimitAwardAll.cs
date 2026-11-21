using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B7 RID: 1207
	public class ConfigKurotatoLimitAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x000FD178 File Offset: 0x000FB378
		static ConfigKurotatoLimitAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLimitAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLimitAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000FD198 File Offset: 0x000FB398
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLimitAwardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLimitAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLimitAward`")
			});
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000FD217 File Offset: 0x000FB417
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardAll.LogPair = null;
			ConfigKurotatoLimitAwardAll.HandleId = 0;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000FD225 File Offset: 0x000FB425
		public static void Init()
		{
			ConfigKurotatoLimitAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLimitAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLimitAward`");
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000FD240 File Offset: 0x000FB440
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLimitAward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoLimitAward> readOnlyList = (IReadOnlyList<KurotatoLimitAward>)ConfigCommon.GetConfig("KurotatoLimitAwardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoLimitAward> list = new List<KurotatoLimitAward>();
			while (ConfigCommon.Step(ConfigKurotatoLimitAwardAll.HandleId, false, ConfigKurotatoLimitAwardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLimitAwardAll.HandleId, 0, ConfigKurotatoLimitAwardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair);
					return null;
				}
				KurotatoLimitAward rootAsKurotatoLimitAward = KurotatoLimitAward.GetRootAsKurotatoLimitAward(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLimitAward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoLimitAwardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair);
			return list;
		}

		// Token: 0x040020E5 RID: 8421
		private const string DB = "db_kurotato.db";

		// Token: 0x040020E6 RID: 8422
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020E7 RID: 8423
		private const string TABLE = "KurotatoLimitAward";

		// Token: 0x040020E8 RID: 8424
		private const string COMMAND = "select BinData from `KurotatoLimitAward`";

		// Token: 0x040020E9 RID: 8425
		private const string KEY_PREFIX = "KurotatoLimitAwardAll";

		// Token: 0x040020EA RID: 8426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020EB RID: 8427
		private static int HandleId;
	}
}
