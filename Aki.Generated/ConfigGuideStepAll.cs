using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C1 RID: 961
	public class ConfigGuideStepAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x000D9024 File Offset: 0x000D7224
		static ConfigGuideStepAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideStepAll.CreateStaticDefaultValue), new Action(ConfigGuideStepAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000D9044 File Offset: 0x000D7244
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideStepAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideStepAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideStep"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideStep`")
			});
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000D90C3 File Offset: 0x000D72C3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideStepAll.LogPair = null;
			ConfigGuideStepAll.HandleId = 0;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000D90D1 File Offset: 0x000D72D1
		public static void Init()
		{
			ConfigGuideStepAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideStepAll.HandleId, "db_guide_new.db", "select BinData from `GuideStep`");
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000D90EC File Offset: 0x000D72EC
		[NullableContext(2)]
		public static IReadOnlyList<GuideStep> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideStepAll.HandleId, ConfigGuideStepAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuideStep> readOnlyList = (IReadOnlyList<GuideStep>)ConfigCommon.GetConfig("GuideStepAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuideStep> list = new List<GuideStep>();
			while (ConfigCommon.Step(ConfigGuideStepAll.HandleId, false, ConfigGuideStepAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideStepAll.HandleId, 0, ConfigGuideStepAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuideStepAll.HandleId, ConfigGuideStepAll.LogPair);
					return null;
				}
				GuideStep rootAsGuideStep = GuideStep.GetRootAsGuideStep(new ByteBuffer(item2));
				list.Add(rootAsGuideStep);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuideStepAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuideStepAll.HandleId, ConfigGuideStepAll.LogPair);
			return list;
		}

		// Token: 0x04001A2B RID: 6699
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A2C RID: 6700
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A2D RID: 6701
		private const string TABLE = "GuideStep";

		// Token: 0x04001A2E RID: 6702
		private const string COMMAND = "select BinData from `GuideStep`";

		// Token: 0x04001A2F RID: 6703
		private const string KEY_PREFIX = "GuideStepAll";

		// Token: 0x04001A30 RID: 6704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A31 RID: 6705
		private static int HandleId;
	}
}
