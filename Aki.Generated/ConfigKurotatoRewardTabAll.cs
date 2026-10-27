using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B2 RID: 1202
	public class ConfigKurotatoRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C37 RID: 7223 RVA: 0x000F8CC8 File Offset: 0x000F6EC8
		static ConfigKurotatoRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoRewardTabAll.CreateStaticDefaultValue), new Action(ConfigKurotatoRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000F8CE8 File Offset: 0x000F6EE8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoRewardTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoRewardTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoRewardTab`")
			});
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000F8D67 File Offset: 0x000F6F67
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoRewardTabAll.LogPair = null;
			ConfigKurotatoRewardTabAll.HandleId = 0;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000F8D75 File Offset: 0x000F6F75
		public static void Init()
		{
			ConfigKurotatoRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoRewardTabAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoRewardTab`");
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000F8D90 File Offset: 0x000F6F90
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoRewardTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoRewardTabAll.HandleId, ConfigKurotatoRewardTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoRewardTab> readOnlyList = (IReadOnlyList<KurotatoRewardTab>)ConfigCommon.GetConfig("KurotatoRewardTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoRewardTab> list = new List<KurotatoRewardTab>();
			while (ConfigCommon.Step(ConfigKurotatoRewardTabAll.HandleId, false, ConfigKurotatoRewardTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoRewardTabAll.HandleId, 0, ConfigKurotatoRewardTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoRewardTabAll.HandleId, ConfigKurotatoRewardTabAll.LogPair);
					return null;
				}
				KurotatoRewardTab rootAsKurotatoRewardTab = KurotatoRewardTab.GetRootAsKurotatoRewardTab(new ByteBuffer(item2));
				list.Add(rootAsKurotatoRewardTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoRewardTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoRewardTabAll.HandleId, ConfigKurotatoRewardTabAll.LogPair);
			return list;
		}

		// Token: 0x040020C2 RID: 8386
		private const string DB = "db_kurotato.db";

		// Token: 0x040020C3 RID: 8387
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020C4 RID: 8388
		private const string TABLE = "KurotatoRewardTab";

		// Token: 0x040020C5 RID: 8389
		private const string COMMAND = "select BinData from `KurotatoRewardTab`";

		// Token: 0x040020C6 RID: 8390
		private const string KEY_PREFIX = "KurotatoRewardTabAll";

		// Token: 0x040020C7 RID: 8391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020C8 RID: 8392
		private static int HandleId;
	}
}
