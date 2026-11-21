using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D7 RID: 983
	public class ConfigGuideStepAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x000DF778 File Offset: 0x000DD978
		static ConfigGuideStepAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideStepAll.CreateStaticDefaultValue), new Action(ConfigGuideStepAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000DF798 File Offset: 0x000DD998
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

		// Token: 0x06001713 RID: 5907 RVA: 0x000DF817 File Offset: 0x000DDA17
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideStepAll.LogPair = null;
			ConfigGuideStepAll.HandleId = 0;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000DF825 File Offset: 0x000DDA25
		public static void Init()
		{
			ConfigGuideStepAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideStepAll.HandleId, "db_guide_new.db", "select BinData from `GuideStep`");
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000DF840 File Offset: 0x000DDA40
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

		// Token: 0x04001AC5 RID: 6853
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AC6 RID: 6854
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AC7 RID: 6855
		private const string TABLE = "GuideStep";

		// Token: 0x04001AC8 RID: 6856
		private const string COMMAND = "select BinData from `GuideStep`";

		// Token: 0x04001AC9 RID: 6857
		private const string KEY_PREFIX = "GuideStepAll";

		// Token: 0x04001ACA RID: 6858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ACB RID: 6859
		private static int HandleId;
	}
}
