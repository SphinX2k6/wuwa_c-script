using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A1 RID: 929
	public class ConfigGmAccountAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015CD RID: 5581 RVA: 0x000D4D39 File Offset: 0x000D2F39
		static ConfigGmAccountAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmAccountAll.CreateStaticDefaultValue), new Action(ConfigGmAccountAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000D4D58 File Offset: 0x000D2F58
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

		// Token: 0x060015CF RID: 5583 RVA: 0x000D4DD7 File Offset: 0x000D2FD7
		public static void ResetStaticDefaultValue()
		{
			ConfigGmAccountAll.LogPair = null;
			ConfigGmAccountAll.HandleId = 0;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000D4DE5 File Offset: 0x000D2FE5
		public static void Init()
		{
			ConfigGmAccountAll.HandleId = ConfigCommon.InitDataStatement(ConfigGmAccountAll.HandleId, "db_gm.db", "select BinData from `GmAccount`");
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000D4E00 File Offset: 0x000D3000
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

		// Token: 0x0400194B RID: 6475
		private const string DB = "db_gm.db";

		// Token: 0x0400194C RID: 6476
		private const string FILE = "g.GM.xlsx";

		// Token: 0x0400194D RID: 6477
		private const string TABLE = "GmAccount";

		// Token: 0x0400194E RID: 6478
		private const string COMMAND = "select BinData from `GmAccount`";

		// Token: 0x0400194F RID: 6479
		private const string KEY_PREFIX = "GmAccountAll";

		// Token: 0x04001950 RID: 6480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001951 RID: 6481
		private static int HandleId;
	}
}
