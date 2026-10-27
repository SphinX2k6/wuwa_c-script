using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000500 RID: 1280
	public class ConfigMailFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x001030E4 File Offset: 0x001012E4
		static ConfigMailFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailFilterAll.CreateStaticDefaultValue), new Action(ConfigMailFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00103104 File Offset: 0x00101304
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

		// Token: 0x06001E0D RID: 7693 RVA: 0x00103183 File Offset: 0x00101383
		public static void ResetStaticDefaultValue()
		{
			ConfigMailFilterAll.LogPair = null;
			ConfigMailFilterAll.HandleId = 0;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00103191 File Offset: 0x00101391
		public static void Init()
		{
			ConfigMailFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigMailFilterAll.HandleId, "db_mail.db", "select BinData from `MailFilter`");
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x001031AC File Offset: 0x001013AC
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

		// Token: 0x040022E4 RID: 8932
		private const string DB = "db_mail.db";

		// Token: 0x040022E5 RID: 8933
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x040022E6 RID: 8934
		private const string TABLE = "MailFilter";

		// Token: 0x040022E7 RID: 8935
		private const string COMMAND = "select BinData from `MailFilter`";

		// Token: 0x040022E8 RID: 8936
		private const string KEY_PREFIX = "MailFilterAll";

		// Token: 0x040022E9 RID: 8937
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022EA RID: 8938
		private static int HandleId;
	}
}
