using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000516 RID: 1302
	public class ConfigMailFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x00109838 File Offset: 0x00107A38
		static ConfigMailFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailFilterAll.CreateStaticDefaultValue), new Action(ConfigMailFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00109858 File Offset: 0x00107A58
		public static void CreateStaticDefaultValue()
		{
			ConfigMailFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMailFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mail.db"),
				new ValueTuple<string, object>("文件", "y.邮件.xlsx"),
				new ValueTuple<string, object>("表名", "MailFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `MailFilter`")
			});
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x001098D7 File Offset: 0x00107AD7
		public static void ResetStaticDefaultValue()
		{
			ConfigMailFilterAll.LogPair = null;
			ConfigMailFilterAll.HandleId = 0;
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x001098E5 File Offset: 0x00107AE5
		public static void Init()
		{
			ConfigMailFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigMailFilterAll.HandleId, "db_mail.db", "select BinData from `MailFilter`");
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00109900 File Offset: 0x00107B00
		[NullableContext(2)]
		public static IReadOnlyList<MailFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMailFilterAll.HandleId, ConfigMailFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MailFilter> readOnlyList = (IReadOnlyList<MailFilter>)ConfigCommon.GetConfig("MailFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MailFilter> list = new List<MailFilter>();
			while (ConfigCommon.Step(ConfigMailFilterAll.HandleId, false, ConfigMailFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMailFilterAll.HandleId, 0, ConfigMailFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMailFilterAll.HandleId, ConfigMailFilterAll.LogPair);
					return null;
				}
				MailFilter rootAsMailFilter = MailFilter.GetRootAsMailFilter(new ByteBuffer(item2));
				list.Add(rootAsMailFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MailFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMailFilterAll.HandleId, ConfigMailFilterAll.LogPair);
			return list;
		}

		// Token: 0x0400237E RID: 9086
		private const string DB = "db_mail.db";

		// Token: 0x0400237F RID: 9087
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x04002380 RID: 9088
		private const string TABLE = "MailFilter";

		// Token: 0x04002381 RID: 9089
		private const string COMMAND = "select BinData from `MailFilter`";

		// Token: 0x04002382 RID: 9090
		private const string KEY_PREFIX = "MailFilterAll";

		// Token: 0x04002383 RID: 9091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002384 RID: 9092
		private static int HandleId;
	}
}
