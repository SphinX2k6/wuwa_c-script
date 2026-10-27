using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BF RID: 959
	public class ConfigGuideGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x000D8C48 File Offset: 0x000D6E48
		static ConfigGuideGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideGroupAll.CreateStaticDefaultValue), new Action(ConfigGuideGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000D8C68 File Offset: 0x000D6E68
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

		// Token: 0x06001683 RID: 5763 RVA: 0x000D8CE7 File Offset: 0x000D6EE7
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideGroupAll.LogPair = null;
			ConfigGuideGroupAll.HandleId = 0;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000D8CF5 File Offset: 0x000D6EF5
		public static void Init()
		{
			ConfigGuideGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuideGroupAll.HandleId, "db_guide_new.db", "select BinData from `GuideGroup`");
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000D8D10 File Offset: 0x000D6F10
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

		// Token: 0x04001A1D RID: 6685
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A1E RID: 6686
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A1F RID: 6687
		private const string TABLE = "GuideGroup";

		// Token: 0x04001A20 RID: 6688
		private const string COMMAND = "select BinData from `GuideGroup`";

		// Token: 0x04001A21 RID: 6689
		private const string KEY_PREFIX = "GuideGroupAll";

		// Token: 0x04001A22 RID: 6690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A23 RID: 6691
		private static int HandleId;
	}
}
