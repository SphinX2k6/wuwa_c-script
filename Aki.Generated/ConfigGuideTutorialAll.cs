using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C4 RID: 964
	public class ConfigGuideTutorialAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x000D9648 File Offset: 0x000D7848
		static ConfigGuideTutorialAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialAll.CreateStaticDefaultValue), new Action(ConfigGuideTutorialAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000D9668 File Offset: 0x000D7868
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x000D96E7 File Offset: 0x000D78E7
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialAll.LogPair = null;
			ConfigGuideTutorialAll.HandleId = 0;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000D96F5 File Offset: 0x000D78F5
		public static void Init()
		{
			ConfigGuideTutorialAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialAll.HandleId, "db_guide_new.db", "select BinData from `GuideTutorial`");
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000D9710 File Offset: 0x000D7910
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

		// Token: 0x04001A40 RID: 6720
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A41 RID: 6721
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A42 RID: 6722
		private const string TABLE = "GuideTutorial";

		// Token: 0x04001A43 RID: 6723
		private const string COMMAND = "select BinData from `GuideTutorial`";

		// Token: 0x04001A44 RID: 6724
		private const string KEY_PREFIX = "GuideTutorialAll";

		// Token: 0x04001A45 RID: 6725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A46 RID: 6726
		private static int HandleId;
	}
}
