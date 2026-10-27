using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A66 RID: 2662
	public class ConfigUiDynamicTabByParentViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E78 RID: 15992 RVA: 0x001BB2FC File Offset: 0x001B94FC
		static ConfigUiDynamicTabByParentViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabByParentViewName.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabByParentViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x001BB31C File Offset: 0x001B951C
		public static void CreateStaticDefaultValue()
		{
			ConfigUiDynamicTabByParentViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiDynamicTabByParentViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UI动态页签.csv"),
				new ValueTuple<string, object>("表名", "UiDynamicTab"),
				new ValueTuple<string, object>("语句", "select BinData from `UiDynamicTab` where ParentViewName = ?")
			});
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x001BB39B File Offset: 0x001B959B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabByParentViewName.LogPair = null;
			ConfigUiDynamicTabByParentViewName.HandleId = 0;
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x001BB3A9 File Offset: 0x001B95A9
		public static void Init()
		{
			ConfigUiDynamicTabByParentViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabByParentViewName.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where ParentViewName = ?");
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x001BB3C4 File Offset: 0x001B95C4
		[return: Nullable(2)]
		public static IReadOnlyList<UiDynamicTab> GetConfigList(string p0ParentViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiDynamicTabByParentViewName.HandleId, ConfigUiDynamicTabByParentViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<UiDynamicTab> readOnlyList = (IReadOnlyList<UiDynamicTab>)ConfigCommon.GetConfig("UiDynamicTabByParentViewName#" + p0ParentViewName);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigUiDynamicTabByParentViewName.LogPair.Clear();
			ConfigUiDynamicTabByParentViewName.LogPair.Add(new ValueTuple<string, object>("ParentViewName", p0ParentViewName));
			if (!ConfigCommon.BindString(ConfigUiDynamicTabByParentViewName.HandleId, 1, p0ParentViewName, ConfigUiDynamicTabByParentViewName.LogPair))
			{
				ConfigCommon.Reset(ConfigUiDynamicTabByParentViewName.HandleId, ConfigUiDynamicTabByParentViewName.LogPair);
				return null;
			}
			List<UiDynamicTab> list = new List<UiDynamicTab>();
			while (ConfigCommon.Step(ConfigUiDynamicTabByParentViewName.HandleId, false, ConfigUiDynamicTabByParentViewName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiDynamicTabByParentViewName.HandleId, 0, ConfigUiDynamicTabByParentViewName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigUiDynamicTabByParentViewName.HandleId, ConfigUiDynamicTabByParentViewName.LogPair);
					return null;
				}
				UiDynamicTab rootAsUiDynamicTab = UiDynamicTab.GetRootAsUiDynamicTab(new ByteBuffer(item2));
				list.Add(rootAsUiDynamicTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("UiDynamicTabByParentViewName#" + p0ParentViewName, list, list.Count);
			}
			ConfigCommon.Reset(ConfigUiDynamicTabByParentViewName.HandleId, ConfigUiDynamicTabByParentViewName.LogPair);
			return list;
		}

		// Token: 0x040048B0 RID: 18608
		private const string DB = "db_ui.db";

		// Token: 0x040048B1 RID: 18609
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x040048B2 RID: 18610
		private const string TABLE = "UiDynamicTab";

		// Token: 0x040048B3 RID: 18611
		private const string COMMAND = "select BinData from `UiDynamicTab` where ParentViewName = ?";

		// Token: 0x040048B4 RID: 18612
		private const string KEY_PREFIX = "UiDynamicTabByParentViewName";

		// Token: 0x040048B5 RID: 18613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048B6 RID: 18614
		private static int HandleId;
	}
}
