using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DA RID: 986
	public class ConfigGuideTutorialAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x000DFD9C File Offset: 0x000DDF9C
		static ConfigGuideTutorialAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialAll.CreateStaticDefaultValue), new Action(ConfigGuideTutorialAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000DFDBC File Offset: 0x000DDFBC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideTutorialAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideTutorialAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideTutorial"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideTutorial`")
			});
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x000DFE3B File Offset: 0x000DE03B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialAll.LogPair = null;
			ConfigGuideTutorialAll.HandleId = 0;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000DFE49 File Offset: 0x000DE049
		public static void Init()
		{
			ConfigGuideTutorialAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialAll.HandleId, "db_guide_new.db", "select BinData from `GuideTutorial`");
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000DFE64 File Offset: 0x000DE064
		[NullableContext(2)]
		public static IReadOnlyList<GuideTutorial> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideTutorialAll.HandleId, ConfigGuideTutorialAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuideTutorial> readOnlyList = (IReadOnlyList<GuideTutorial>)ConfigCommon.GetConfig("GuideTutorialAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuideTutorial> list = new List<GuideTutorial>();
			while (ConfigCommon.Step(ConfigGuideTutorialAll.HandleId, false, ConfigGuideTutorialAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideTutorialAll.HandleId, 0, ConfigGuideTutorialAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuideTutorialAll.HandleId, ConfigGuideTutorialAll.LogPair);
					return null;
				}
				GuideTutorial rootAsGuideTutorial = GuideTutorial.GetRootAsGuideTutorial(new ByteBuffer(item2));
				list.Add(rootAsGuideTutorial);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuideTutorialAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuideTutorialAll.HandleId, ConfigGuideTutorialAll.LogPair);
			return list;
		}

		// Token: 0x04001ADA RID: 6874
		private const string DB = "db_guide_new.db";

		// Token: 0x04001ADB RID: 6875
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001ADC RID: 6876
		private const string TABLE = "GuideTutorial";

		// Token: 0x04001ADD RID: 6877
		private const string COMMAND = "select BinData from `GuideTutorial`";

		// Token: 0x04001ADE RID: 6878
		private const string KEY_PREFIX = "GuideTutorialAll";

		// Token: 0x04001ADF RID: 6879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AE0 RID: 6880
		private static int HandleId;
	}
}
