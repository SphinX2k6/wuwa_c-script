using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3C RID: 2876
	public class ConfigUiFloatConfigByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600437C RID: 17276 RVA: 0x001DA875 File Offset: 0x001D8A75
		static ConfigUiFloatConfigByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiFloatConfigByViewName.CreateStaticDefaultValue), new Action(ConfigUiFloatConfigByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x001DA894 File Offset: 0x001D8A94
		public static void CreateStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiFloatConfigByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UiFloat层级配置.csv"),
				new ValueTuple<string, object>("表名", "UiFloatConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `UiFloatConfig` where ViewName = ?")
			});
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x001DA913 File Offset: 0x001D8B13
		public static void ResetStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewName.LogPair = null;
			ConfigUiFloatConfigByViewName.HandleId = 0;
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x001DA921 File Offset: 0x001D8B21
		public static void Init()
		{
			ConfigUiFloatConfigByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiFloatConfigByViewName.HandleId, "db_ui.db", "select BinData from `UiFloatConfig` where ViewName = ?");
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x001DA93C File Offset: 0x001D8B3C
		public static UiFloatConfig? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiFloatConfigByViewName.HandleId, ConfigUiFloatConfigByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiFloatConfigByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new UiFloatConfig?(UiFloatConfig.GetRootAsUiFloatConfig(configBuffer));
				}
			}
			ConfigUiFloatConfigByViewName.LogPair.Clear();
			ConfigUiFloatConfigByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigUiFloatConfigByViewName.HandleId, 1, p0ViewName, ConfigUiFloatConfigByViewName.LogPair) || ConfigCommon.Step(ConfigUiFloatConfigByViewName.HandleId, true, ConfigUiFloatConfigByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiFloatConfigByViewName.HandleId, ConfigUiFloatConfigByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiFloatConfigByViewName.HandleId, 0, ConfigUiFloatConfigByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiFloatConfigByViewName.HandleId, ConfigUiFloatConfigByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiFloatConfig rootAsUiFloatConfig = UiFloatConfig.GetRootAsUiFloatConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiFloatConfigByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiFloatConfigByViewName.HandleId, ConfigUiFloatConfigByViewName.LogPair);
			return new UiFloatConfig?(rootAsUiFloatConfig);
		}

		// Token: 0x04004E8A RID: 20106
		private const string DB = "db_ui.db";

		// Token: 0x04004E8B RID: 20107
		private const string FILE = "u.UiFloat层级配置.csv";

		// Token: 0x04004E8C RID: 20108
		private const string TABLE = "UiFloatConfig";

		// Token: 0x04004E8D RID: 20109
		private const string COMMAND = "select BinData from `UiFloatConfig` where ViewName = ?";

		// Token: 0x04004E8E RID: 20110
		private const string KEY_PREFIX = "UiFloatConfigByViewName";

		// Token: 0x04004E8F RID: 20111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E90 RID: 20112
		private static int HandleId;
	}
}
