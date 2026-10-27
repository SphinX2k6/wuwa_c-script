using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A67 RID: 2663
	public class ConfigUiFloatConfigByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E7E RID: 15998 RVA: 0x001BB4E1 File Offset: 0x001B96E1
		static ConfigUiFloatConfigByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiFloatConfigByViewName.CreateStaticDefaultValue), new Action(ConfigUiFloatConfigByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x001BB500 File Offset: 0x001B9700
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

		// Token: 0x06003E80 RID: 16000 RVA: 0x001BB57F File Offset: 0x001B977F
		public static void ResetStaticDefaultValue()
		{
			ConfigUiFloatConfigByViewName.LogPair = null;
			ConfigUiFloatConfigByViewName.HandleId = 0;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001BB58D File Offset: 0x001B978D
		public static void Init()
		{
			ConfigUiFloatConfigByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiFloatConfigByViewName.HandleId, "db_ui.db", "select BinData from `UiFloatConfig` where ViewName = ?");
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001BB5A8 File Offset: 0x001B97A8
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

		// Token: 0x040048B7 RID: 18615
		private const string DB = "db_ui.db";

		// Token: 0x040048B8 RID: 18616
		private const string FILE = "u.UiFloat层级配置.csv";

		// Token: 0x040048B9 RID: 18617
		private const string TABLE = "UiFloatConfig";

		// Token: 0x040048BA RID: 18618
		private const string COMMAND = "select BinData from `UiFloatConfig` where ViewName = ?";

		// Token: 0x040048BB RID: 18619
		private const string KEY_PREFIX = "UiFloatConfigByViewName";

		// Token: 0x040048BC RID: 18620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048BD RID: 18621
		private static int HandleId;
	}
}
