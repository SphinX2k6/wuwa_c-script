using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6E RID: 2670
	public class ConfigUiShowByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EA8 RID: 16040 RVA: 0x001BC4D1 File Offset: 0x001BA6D1
		static ConfigUiShowByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiShowByViewName.CreateStaticDefaultValue), new Action(ConfigUiShowByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x001BC4F0 File Offset: 0x001BA6F0
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

		// Token: 0x06003EAA RID: 16042 RVA: 0x001BC56F File Offset: 0x001BA76F
		public static void ResetStaticDefaultValue()
		{
			ConfigUiShowByViewName.LogPair = null;
			ConfigUiShowByViewName.HandleId = 0;
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x001BC57D File Offset: 0x001BA77D
		public static void Init()
		{
			ConfigUiShowByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiShowByViewName.HandleId, "db_ui.db", "select BinData from `UiShow` where ViewName=?");
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x001BC598 File Offset: 0x001BA798
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

		// Token: 0x040048E8 RID: 18664
		private const string DB = "db_ui.db";

		// Token: 0x040048E9 RID: 18665
		private const string FILE = "u.UI表现.csv";

		// Token: 0x040048EA RID: 18666
		private const string TABLE = "UiShow";

		// Token: 0x040048EB RID: 18667
		private const string COMMAND = "select BinData from `UiShow` where ViewName=?";

		// Token: 0x040048EC RID: 18668
		private const string KEY_PREFIX = "UiShowByViewName";

		// Token: 0x040048ED RID: 18669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048EE RID: 18670
		private static int HandleId;
	}
}
