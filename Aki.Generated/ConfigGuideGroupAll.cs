using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D5 RID: 981
	public class ConfigGuideGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x000DF39C File Offset: 0x000DD59C
		static ConfigGuideGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideGroupAll.CreateStaticDefaultValue), new Action(ConfigGuideGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000DF3BC File Offset: 0x000DD5BC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideGroup`")
			});
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000DF43B File Offset: 0x000DD63B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideGroupAll.LogPair = null;
			ConfigGuideGroupAll.HandleId = 0;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000DF449 File Offset: 0x000DD649
		public static void Init()
		{
			ConfigGuideGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideGroupAll.HandleId, "db_guide_new.db", "select BinData from `GuideGroup`");
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000DF464 File Offset: 0x000DD664
		[NullableContext(2)]
		public static IReadOnlyList<GuideGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideGroupAll.HandleId, ConfigGuideGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuideGroup> readOnlyList = (IReadOnlyList<GuideGroup>)ConfigCommon.GetConfig("GuideGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuideGroup> list = new List<GuideGroup>();
			while (ConfigCommon.Step(ConfigGuideGroupAll.HandleId, false, ConfigGuideGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideGroupAll.HandleId, 0, ConfigGuideGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuideGroupAll.HandleId, ConfigGuideGroupAll.LogPair);
					return null;
				}
				GuideGroup rootAsGuideGroup = GuideGroup.GetRootAsGuideGroup(new ByteBuffer(item2));
				list.Add(rootAsGuideGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuideGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuideGroupAll.HandleId, ConfigGuideGroupAll.LogPair);
			return list;
		}

		// Token: 0x04001AB7 RID: 6839
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AB8 RID: 6840
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AB9 RID: 6841
		private const string TABLE = "GuideGroup";

		// Token: 0x04001ABA RID: 6842
		private const string COMMAND = "select BinData from `GuideGroup`";

		// Token: 0x04001ABB RID: 6843
		private const string KEY_PREFIX = "GuideGroupAll";

		// Token: 0x04001ABC RID: 6844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ABD RID: 6845
		private static int HandleId;
	}
}
