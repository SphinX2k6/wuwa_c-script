using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CD RID: 1997
	public class ConfigRegressDoubleDropAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EE0 RID: 12000 RVA: 0x001623FC File Offset: 0x001605FC
		static ConfigRegressDoubleDropAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropAll.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0016241C File Offset: 0x0016061C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDoubleDropAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDoubleDropAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDoubleDrop"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDoubleDrop`")
			});
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x0016249B File Offset: 0x0016069B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropAll.LogPair = null;
			ConfigRegressDoubleDropAll.HandleId = 0;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x001624A9 File Offset: 0x001606A9
		public static void Init()
		{
			ConfigRegressDoubleDropAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropAll.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop`");
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x001624C4 File Offset: 0x001606C4
		[NullableContext(2)]
		public static IReadOnlyList<RegressDoubleDrop> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressDoubleDrop> readOnlyList = (IReadOnlyList<RegressDoubleDrop>)ConfigCommon.GetConfig("RegressDoubleDropAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressDoubleDrop> list = new List<RegressDoubleDrop>();
			while (ConfigCommon.Step(ConfigRegressDoubleDropAll.HandleId, false, ConfigRegressDoubleDropAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDoubleDropAll.HandleId, 0, ConfigRegressDoubleDropAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair);
					return null;
				}
				RegressDoubleDrop rootAsRegressDoubleDrop = RegressDoubleDrop.GetRootAsRegressDoubleDrop(new ByteBuffer(item2));
				list.Add(rootAsRegressDoubleDrop);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressDoubleDropAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressDoubleDropAll.HandleId, ConfigRegressDoubleDropAll.LogPair);
			return list;
		}

		// Token: 0x04003681 RID: 13953
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003682 RID: 13954
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003683 RID: 13955
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x04003684 RID: 13956
		private const string COMMAND = "select BinData from `RegressDoubleDrop`";

		// Token: 0x04003685 RID: 13957
		private const string KEY_PREFIX = "RegressDoubleDropAll";

		// Token: 0x04003686 RID: 13958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003687 RID: 13959
		private static int HandleId;
	}
}
