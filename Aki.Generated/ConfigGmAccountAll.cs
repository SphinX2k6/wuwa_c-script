using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B7 RID: 951
	public class ConfigGmAccountAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x000DB48D File Offset: 0x000D968D
		static ConfigGmAccountAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmAccountAll.CreateStaticDefaultValue), new Action(ConfigGmAccountAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000DB4AC File Offset: 0x000D96AC
		public static void CreateStaticDefaultValue()
		{
			ConfigGmAccountAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmAccountAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmAccount"),
				new ValueTuple<string, object>("语句", "select BinData from `GmAccount`")
			});
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000DB52B File Offset: 0x000D972B
		public static void ResetStaticDefaultValue()
		{
			ConfigGmAccountAll.LogPair = null;
			ConfigGmAccountAll.HandleId = 0;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000DB539 File Offset: 0x000D9739
		public static void Init()
		{
			ConfigGmAccountAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmAccountAll.HandleId, "db_gm.db", "select BinData from `GmAccount`");
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000DB554 File Offset: 0x000D9754
		[NullableContext(2)]
		public static IReadOnlyList<GmAccount> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmAccountAll.HandleId, ConfigGmAccountAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GmAccount> readOnlyList = (IReadOnlyList<GmAccount>)ConfigCommon.GetConfig("GmAccountAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GmAccount> list = new List<GmAccount>();
			while (ConfigCommon.Step(ConfigGmAccountAll.HandleId, false, ConfigGmAccountAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmAccountAll.HandleId, 0, ConfigGmAccountAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGmAccountAll.HandleId, ConfigGmAccountAll.LogPair);
					return null;
				}
				GmAccount rootAsGmAccount = GmAccount.GetRootAsGmAccount(new ByteBuffer(item2));
				list.Add(rootAsGmAccount);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GmAccountAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGmAccountAll.HandleId, ConfigGmAccountAll.LogPair);
			return list;
		}

		// Token: 0x040019E5 RID: 6629
		private const string DB = "db_gm.db";

		// Token: 0x040019E6 RID: 6630
		private const string FILE = "g.GM.xlsx";

		// Token: 0x040019E7 RID: 6631
		private const string TABLE = "GmAccount";

		// Token: 0x040019E8 RID: 6632
		private const string COMMAND = "select BinData from `GmAccount`";

		// Token: 0x040019E9 RID: 6633
		private const string KEY_PREFIX = "GmAccountAll";

		// Token: 0x040019EA RID: 6634
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019EB RID: 6635
		private static int HandleId;
	}
}
