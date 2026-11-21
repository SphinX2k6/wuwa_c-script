using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C8 RID: 1224
	public class ConfigKurotatoRewardTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CBB RID: 7355 RVA: 0x000FF41C File Offset: 0x000FD61C
		static ConfigKurotatoRewardTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoRewardTabAll.CreateStaticDefaultValue), new Action(ConfigKurotatoRewardTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000FF43C File Offset: 0x000FD63C
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

		// Token: 0x06001CBD RID: 7357 RVA: 0x000FF4BB File Offset: 0x000FD6BB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoRewardTabAll.LogPair = null;
			ConfigKurotatoRewardTabAll.HandleId = 0;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000FF4C9 File Offset: 0x000FD6C9
		public static void Init()
		{
			ConfigKurotatoRewardTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoRewardTabAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoRewardTab`");
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000FF4E4 File Offset: 0x000FD6E4
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

		// Token: 0x0400215C RID: 8540
		private const string DB = "db_kurotato.db";

		// Token: 0x0400215D RID: 8541
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x0400215E RID: 8542
		private const string TABLE = "KurotatoRewardTab";

		// Token: 0x0400215F RID: 8543
		private const string COMMAND = "select BinData from `KurotatoRewardTab`";

		// Token: 0x04002160 RID: 8544
		private const string KEY_PREFIX = "KurotatoRewardTabAll";

		// Token: 0x04002161 RID: 8545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002162 RID: 8546
		private static int HandleId;
	}
}
