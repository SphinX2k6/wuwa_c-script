using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A64 RID: 2660
	public class ConfigUiDynamicTabByChildViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E6C RID: 15980 RVA: 0x001BAEBD File Offset: 0x001B90BD
		static ConfigUiDynamicTabByChildViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabByChildViewName.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabByChildViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x001BAEDC File Offset: 0x001B90DC
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

		// Token: 0x06003E6E RID: 15982 RVA: 0x001BAF5B File Offset: 0x001B915B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabByChildViewName.LogPair = null;
			ConfigUiDynamicTabByChildViewName.HandleId = 0;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x001BAF69 File Offset: 0x001B9169
		public static void Init()
		{
			ConfigUiDynamicTabByChildViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabByChildViewName.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where ChildViewName = ?");
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001BAF84 File Offset: 0x001B9184
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

		// Token: 0x040048A2 RID: 18594
		private const string DB = "db_ui.db";

		// Token: 0x040048A3 RID: 18595
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x040048A4 RID: 18596
		private const string TABLE = "UiDynamicTab";

		// Token: 0x040048A5 RID: 18597
		private const string COMMAND = "select BinData from `UiDynamicTab` where ChildViewName = ?";

		// Token: 0x040048A6 RID: 18598
		private const string KEY_PREFIX = "UiDynamicTabByChildViewName";

		// Token: 0x040048A7 RID: 18599
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048A8 RID: 18600
		private static int HandleId;
	}
}
