using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3B RID: 2875
	public class ConfigUiDynamicTabByParentViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004376 RID: 17270 RVA: 0x001DA690 File Offset: 0x001D8890
		static ConfigUiDynamicTabByParentViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabByParentViewName.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabByParentViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x001DA6B0 File Offset: 0x001D88B0
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

		// Token: 0x06004378 RID: 17272 RVA: 0x001DA72F File Offset: 0x001D892F
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabByParentViewName.LogPair = null;
			ConfigUiDynamicTabByParentViewName.HandleId = 0;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x001DA73D File Offset: 0x001D893D
		public static void Init()
		{
			ConfigUiDynamicTabByParentViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabByParentViewName.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where ParentViewName = ?");
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x001DA758 File Offset: 0x001D8958
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

		// Token: 0x04004E83 RID: 20099
		private const string DB = "db_ui.db";

		// Token: 0x04004E84 RID: 20100
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x04004E85 RID: 20101
		private const string TABLE = "UiDynamicTab";

		// Token: 0x04004E86 RID: 20102
		private const string COMMAND = "select BinData from `UiDynamicTab` where ParentViewName = ?";

		// Token: 0x04004E87 RID: 20103
		private const string KEY_PREFIX = "UiDynamicTabByParentViewName";

		// Token: 0x04004E88 RID: 20104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E89 RID: 20105
		private static int HandleId;
	}
}
