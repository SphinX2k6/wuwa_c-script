using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3E RID: 2878
	public class ConfigUiNormalConfigByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x001DAD4F File Offset: 0x001D8F4F
		static ConfigUiNormalConfigByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiNormalConfigByViewName.CreateStaticDefaultValue), new Action(ConfigUiNormalConfigByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x001DAD70 File Offset: 0x001D8F70
		public static void CreateStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiNormalConfigByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UiNormal层级队列配置.csv"),
				new ValueTuple<string, object>("表名", "UiNormalConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `UiNormalConfig` where ViewName = ?")
			});
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x001DADEF File Offset: 0x001D8FEF
		public static void ResetStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewName.LogPair = null;
			ConfigUiNormalConfigByViewName.HandleId = 0;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x001DADFD File Offset: 0x001D8FFD
		public static void Init()
		{
			ConfigUiNormalConfigByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiNormalConfigByViewName.HandleId, "db_ui.db", "select BinData from `UiNormalConfig` where ViewName = ?");
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x001DAE18 File Offset: 0x001D9018
		public static UiNormalConfig? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiNormalConfigByViewName.HandleId, ConfigUiNormalConfigByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiNormalConfigByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new UiNormalConfig?(UiNormalConfig.GetRootAsUiNormalConfig(configBuffer));
				}
			}
			ConfigUiNormalConfigByViewName.LogPair.Clear();
			ConfigUiNormalConfigByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigUiNormalConfigByViewName.HandleId, 1, p0ViewName, ConfigUiNormalConfigByViewName.LogPair) || ConfigCommon.Step(ConfigUiNormalConfigByViewName.HandleId, true, ConfigUiNormalConfigByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiNormalConfigByViewName.HandleId, ConfigUiNormalConfigByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiNormalConfigByViewName.HandleId, 0, ConfigUiNormalConfigByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiNormalConfigByViewName.HandleId, ConfigUiNormalConfigByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiNormalConfig rootAsUiNormalConfig = UiNormalConfig.GetRootAsUiNormalConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiNormalConfigByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiNormalConfigByViewName.HandleId, ConfigUiNormalConfigByViewName.LogPair);
			return new UiNormalConfig?(rootAsUiNormalConfig);
		}

		// Token: 0x04004E98 RID: 20120
		private const string DB = "db_ui.db";

		// Token: 0x04004E99 RID: 20121
		private const string FILE = "u.UiNormal层级队列配置.csv";

		// Token: 0x04004E9A RID: 20122
		private const string TABLE = "UiNormalConfig";

		// Token: 0x04004E9B RID: 20123
		private const string COMMAND = "select BinData from `UiNormalConfig` where ViewName = ?";

		// Token: 0x04004E9C RID: 20124
		private const string KEY_PREFIX = "UiNormalConfigByViewName";

		// Token: 0x04004E9D RID: 20125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E9E RID: 20126
		private static int HandleId;
	}
}
