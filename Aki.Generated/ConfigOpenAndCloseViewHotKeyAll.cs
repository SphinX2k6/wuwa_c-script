using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000645 RID: 1605
	public class ConfigOpenAndCloseViewHotKeyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x001323CC File Offset: 0x001305CC
		static ConfigOpenAndCloseViewHotKeyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyAll.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x001323EC File Offset: 0x001305EC
		public static void CreateStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOpenAndCloseViewHotKeyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "OpenAndCloseViewHotKey"),
				new ValueTuple<string, object>("语句", "select BinData from `OpenAndCloseViewHotKey`")
			});
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0013246B File Offset: 0x0013066B
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyAll.LogPair = null;
			ConfigOpenAndCloseViewHotKeyAll.HandleId = 0;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00132479 File Offset: 0x00130679
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyAll.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyAll.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey`");
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00132494 File Offset: 0x00130694
		[NullableContext(2)]
		public static IReadOnlyList<OpenAndCloseViewHotKey> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOpenAndCloseViewHotKeyAll.HandleId, ConfigOpenAndCloseViewHotKeyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OpenAndCloseViewHotKey> readOnlyList = (IReadOnlyList<OpenAndCloseViewHotKey>)ConfigCommon.GetConfig("OpenAndCloseViewHotKeyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<OpenAndCloseViewHotKey> list = new List<OpenAndCloseViewHotKey>();
			while (ConfigCommon.Step(ConfigOpenAndCloseViewHotKeyAll.HandleId, false, ConfigOpenAndCloseViewHotKeyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOpenAndCloseViewHotKeyAll.HandleId, 0, ConfigOpenAndCloseViewHotKeyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyAll.HandleId, ConfigOpenAndCloseViewHotKeyAll.LogPair);
					return null;
				}
				OpenAndCloseViewHotKey rootAsOpenAndCloseViewHotKey = OpenAndCloseViewHotKey.GetRootAsOpenAndCloseViewHotKey(new ByteBuffer(item2));
				list.Add(rootAsOpenAndCloseViewHotKey);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OpenAndCloseViewHotKeyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyAll.HandleId, ConfigOpenAndCloseViewHotKeyAll.LogPair);
			return list;
		}

		// Token: 0x04002BC9 RID: 11209
		private const string DB = "db_input_settings.db";

		// Token: 0x04002BCA RID: 11210
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002BCB RID: 11211
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002BCC RID: 11212
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey`";

		// Token: 0x04002BCD RID: 11213
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyAll";

		// Token: 0x04002BCE RID: 11214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BCF RID: 11215
		private static int HandleId;
	}
}
