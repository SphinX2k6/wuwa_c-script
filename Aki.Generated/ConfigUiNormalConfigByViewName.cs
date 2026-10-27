using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A69 RID: 2665
	public class ConfigUiNormalConfigByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E8A RID: 16010 RVA: 0x001BB9BB File Offset: 0x001B9BBB
		static ConfigUiNormalConfigByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiNormalConfigByViewName.CreateStaticDefaultValue), new Action(ConfigUiNormalConfigByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x001BB9DC File Offset: 0x001B9BDC
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

		// Token: 0x06003E8C RID: 16012 RVA: 0x001BBA5B File Offset: 0x001B9C5B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiNormalConfigByViewName.LogPair = null;
			ConfigUiNormalConfigByViewName.HandleId = 0;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x001BBA69 File Offset: 0x001B9C69
		public static void Init()
		{
			ConfigUiNormalConfigByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiNormalConfigByViewName.HandleId, "db_ui.db", "select BinData from `UiNormalConfig` where ViewName = ?");
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x001BBA84 File Offset: 0x001B9C84
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

		// Token: 0x040048C5 RID: 18629
		private const string DB = "db_ui.db";

		// Token: 0x040048C6 RID: 18630
		private const string FILE = "u.UiNormal层级队列配置.csv";

		// Token: 0x040048C7 RID: 18631
		private const string TABLE = "UiNormalConfig";

		// Token: 0x040048C8 RID: 18632
		private const string COMMAND = "select BinData from `UiNormalConfig` where ViewName = ?";

		// Token: 0x040048C9 RID: 18633
		private const string KEY_PREFIX = "UiNormalConfigByViewName";

		// Token: 0x040048CA RID: 18634
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048CB RID: 18635
		private static int HandleId;
	}
}
