using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062D RID: 1581
	public class ConfigOpenAndCloseViewHotKeyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x0012B950 File Offset: 0x00129B50
		static ConfigOpenAndCloseViewHotKeyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyAll.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0012B970 File Offset: 0x00129B70
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

		// Token: 0x06002520 RID: 9504 RVA: 0x0012B9EF File Offset: 0x00129BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyAll.LogPair = null;
			ConfigOpenAndCloseViewHotKeyAll.HandleId = 0;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0012B9FD File Offset: 0x00129BFD
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyAll.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyAll.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey`");
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0012BA18 File Offset: 0x00129C18
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

		// Token: 0x04002B21 RID: 11041
		private const string DB = "db_input_settings.db";

		// Token: 0x04002B22 RID: 11042
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002B23 RID: 11043
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002B24 RID: 11044
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey`";

		// Token: 0x04002B25 RID: 11045
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyAll";

		// Token: 0x04002B26 RID: 11046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B27 RID: 11047
		private static int HandleId;
	}
}
