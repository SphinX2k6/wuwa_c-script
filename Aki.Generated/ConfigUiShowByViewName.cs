using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B43 RID: 2883
	public class ConfigUiShowByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043A6 RID: 17318 RVA: 0x001DB865 File Offset: 0x001D9A65
		static ConfigUiShowByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiShowByViewName.CreateStaticDefaultValue), new Action(ConfigUiShowByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x001DB884 File Offset: 0x001D9A84
		public static void CreateStaticDefaultValue()
		{
			ConfigUiShowByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiShowByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UI表现.csv"),
				new ValueTuple<string, object>("表名", "UiShow"),
				new ValueTuple<string, object>("语句", "select BinData from `UiShow` where ViewName=?")
			});
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x001DB903 File Offset: 0x001D9B03
		public static void ResetStaticDefaultValue()
		{
			ConfigUiShowByViewName.LogPair = null;
			ConfigUiShowByViewName.HandleId = 0;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x001DB911 File Offset: 0x001D9B11
		public static void Init()
		{
			ConfigUiShowByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiShowByViewName.HandleId, "db_ui.db", "select BinData from `UiShow` where ViewName=?");
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x001DB92C File Offset: 0x001D9B2C
		public static UiShow? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiShowByViewName.HandleId, ConfigUiShowByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiShowByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new UiShow?(UiShow.GetRootAsUiShow(configBuffer));
				}
			}
			ConfigUiShowByViewName.LogPair.Clear();
			ConfigUiShowByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigUiShowByViewName.HandleId, 1, p0ViewName, ConfigUiShowByViewName.LogPair) || ConfigCommon.Step(ConfigUiShowByViewName.HandleId, true, ConfigUiShowByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiShowByViewName.HandleId, ConfigUiShowByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiShowByViewName.HandleId, 0, ConfigUiShowByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiShowByViewName.HandleId, ConfigUiShowByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiShow rootAsUiShow = UiShow.GetRootAsUiShow(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiShowByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiShowByViewName.HandleId, ConfigUiShowByViewName.LogPair);
			return new UiShow?(rootAsUiShow);
		}

		// Token: 0x04004EBB RID: 20155
		private const string DB = "db_ui.db";

		// Token: 0x04004EBC RID: 20156
		private const string FILE = "u.UI表现.csv";

		// Token: 0x04004EBD RID: 20157
		private const string TABLE = "UiShow";

		// Token: 0x04004EBE RID: 20158
		private const string COMMAND = "select BinData from `UiShow` where ViewName=?";

		// Token: 0x04004EBF RID: 20159
		private const string KEY_PREFIX = "UiShowByViewName";

		// Token: 0x04004EC0 RID: 20160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EC1 RID: 20161
		private static int HandleId;
	}
}
