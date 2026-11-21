using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B39 RID: 2873
	public class ConfigUiDynamicTabByChildViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600436A RID: 17258 RVA: 0x001DA251 File Offset: 0x001D8451
		static ConfigUiDynamicTabByChildViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabByChildViewName.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabByChildViewName.ResetStaticDefaultValue));
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x001DA270 File Offset: 0x001D8470
		public static void CreateStaticDefaultValue()
		{
			ConfigUiDynamicTabByChildViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiDynamicTabByChildViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UI动态页签.csv"),
				new ValueTuple<string, object>("表名", "UiDynamicTab"),
				new ValueTuple<string, object>("语句", "select BinData from `UiDynamicTab` where ChildViewName = ?")
			});
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x001DA2EF File Offset: 0x001D84EF
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabByChildViewName.LogPair = null;
			ConfigUiDynamicTabByChildViewName.HandleId = 0;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x001DA2FD File Offset: 0x001D84FD
		public static void Init()
		{
			ConfigUiDynamicTabByChildViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabByChildViewName.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where ChildViewName = ?");
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x001DA318 File Offset: 0x001D8518
		public static UiDynamicTab? GetConfig(string p0ChildViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiDynamicTabByChildViewName.HandleId, ConfigUiDynamicTabByChildViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiDynamicTabByChildViewName#" + p0ChildViewName);
				if (configBuffer != null)
				{
					return new UiDynamicTab?(UiDynamicTab.GetRootAsUiDynamicTab(configBuffer));
				}
			}
			ConfigUiDynamicTabByChildViewName.LogPair.Clear();
			ConfigUiDynamicTabByChildViewName.LogPair.Add(new ValueTuple<string, object>("ChildViewName", p0ChildViewName));
			if (!ConfigCommon.BindString(ConfigUiDynamicTabByChildViewName.HandleId, 1, p0ChildViewName, ConfigUiDynamicTabByChildViewName.LogPair) || ConfigCommon.Step(ConfigUiDynamicTabByChildViewName.HandleId, true, ConfigUiDynamicTabByChildViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiDynamicTabByChildViewName.HandleId, ConfigUiDynamicTabByChildViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiDynamicTabByChildViewName.HandleId, 0, ConfigUiDynamicTabByChildViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiDynamicTabByChildViewName.HandleId, ConfigUiDynamicTabByChildViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiDynamicTab rootAsUiDynamicTab = UiDynamicTab.GetRootAsUiDynamicTab(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiDynamicTabByChildViewName#" + p0ChildViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiDynamicTabByChildViewName.HandleId, ConfigUiDynamicTabByChildViewName.LogPair);
			return new UiDynamicTab?(rootAsUiDynamicTab);
		}

		// Token: 0x04004E75 RID: 20085
		private const string DB = "db_ui.db";

		// Token: 0x04004E76 RID: 20086
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x04004E77 RID: 20087
		private const string TABLE = "UiDynamicTab";

		// Token: 0x04004E78 RID: 20088
		private const string COMMAND = "select BinData from `UiDynamicTab` where ChildViewName = ?";

		// Token: 0x04004E79 RID: 20089
		private const string KEY_PREFIX = "UiDynamicTabByChildViewName";

		// Token: 0x04004E7A RID: 20090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E7B RID: 20091
		private static int HandleId;
	}
}
