using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000781 RID: 1921
	public class ConfigPsFeedbackAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D17 RID: 11543 RVA: 0x0015BA04 File Offset: 0x00159C04
		static ConfigPsFeedbackAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPsFeedbackAll.CreateStaticDefaultValue), new Action(ConfigPsFeedbackAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x0015BA24 File Offset: 0x00159C24
		public static void CreateStaticDefaultValue()
		{
			ConfigPsFeedbackAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPsFeedbackAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "PsFeedback"),
				new ValueTuple<string, object>("语句", "select BinData from `PsFeedback`")
			});
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0015BAA3 File Offset: 0x00159CA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPsFeedbackAll.LogPair = null;
			ConfigPsFeedbackAll.HandleId = 0;
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0015BAB1 File Offset: 0x00159CB1
		public static void Init()
		{
			ConfigPsFeedbackAll.HandleId = ConfigCommon.InitDataStatement(ConfigPsFeedbackAll.HandleId, "db_input_settings.db", "select BinData from `PsFeedback`");
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x0015BACC File Offset: 0x00159CCC
		[NullableContext(2)]
		public static IReadOnlyList<PsFeedback> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPsFeedbackAll.HandleId, ConfigPsFeedbackAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PsFeedback> readOnlyList = (IReadOnlyList<PsFeedback>)ConfigCommon.GetConfig("PsFeedbackAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PsFeedback> list = new List<PsFeedback>();
			while (ConfigCommon.Step(ConfigPsFeedbackAll.HandleId, false, ConfigPsFeedbackAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPsFeedbackAll.HandleId, 0, ConfigPsFeedbackAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPsFeedbackAll.HandleId, ConfigPsFeedbackAll.LogPair);
					return null;
				}
				PsFeedback rootAsPsFeedback = PsFeedback.GetRootAsPsFeedback(new ByteBuffer(item2));
				list.Add(rootAsPsFeedback);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PsFeedbackAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPsFeedbackAll.HandleId, ConfigPsFeedbackAll.LogPair);
			return list;
		}

		// Token: 0x0400346D RID: 13421
		private const string DB = "db_input_settings.db";

		// Token: 0x0400346E RID: 13422
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x0400346F RID: 13423
		private const string TABLE = "PsFeedback";

		// Token: 0x04003470 RID: 13424
		private const string COMMAND = "select BinData from `PsFeedback`";

		// Token: 0x04003471 RID: 13425
		private const string KEY_PREFIX = "PsFeedbackAll";

		// Token: 0x04003472 RID: 13426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003473 RID: 13427
		private static int HandleId;
	}
}
