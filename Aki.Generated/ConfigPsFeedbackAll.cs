using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000767 RID: 1895
	public class ConfigPsFeedbackAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C7B RID: 11387 RVA: 0x00154AF8 File Offset: 0x00152CF8
		static ConfigPsFeedbackAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPsFeedbackAll.CreateStaticDefaultValue), new Action(ConfigPsFeedbackAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00154B18 File Offset: 0x00152D18
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

		// Token: 0x06002C7D RID: 11389 RVA: 0x00154B97 File Offset: 0x00152D97
		public static void ResetStaticDefaultValue()
		{
			ConfigPsFeedbackAll.LogPair = null;
			ConfigPsFeedbackAll.HandleId = 0;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00154BA5 File Offset: 0x00152DA5
		public static void Init()
		{
			ConfigPsFeedbackAll.HandleId = ConfigCommon.InitDataStatement(ConfigPsFeedbackAll.HandleId, "db_input_settings.db", "select BinData from `PsFeedback`");
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00154BC0 File Offset: 0x00152DC0
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

		// Token: 0x040033B7 RID: 13239
		private const string DB = "db_input_settings.db";

		// Token: 0x040033B8 RID: 13240
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040033B9 RID: 13241
		private const string TABLE = "PsFeedback";

		// Token: 0x040033BA RID: 13242
		private const string COMMAND = "select BinData from `PsFeedback`";

		// Token: 0x040033BB RID: 13243
		private const string KEY_PREFIX = "PsFeedbackAll";

		// Token: 0x040033BC RID: 13244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033BD RID: 13245
		private static int HandleId;
	}
}
