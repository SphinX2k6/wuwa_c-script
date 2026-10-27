using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062E RID: 1582
	public class ConfigOpenAndCloseViewHotKeyByActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x0012BAE3 File Offset: 0x00129CE3
		static ConfigOpenAndCloseViewHotKeyByActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyByActionName.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyByActionName.ResetStaticDefaultValue));
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0012BB04 File Offset: 0x00129D04
		public static void CreateStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "OpenAndCloseViewHotKey"),
				new ValueTuple<string, object>("语句", "select BinData from `OpenAndCloseViewHotKey` where ActionName=?")
			});
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0012BB83 File Offset: 0x00129D83
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair = null;
			ConfigOpenAndCloseViewHotKeyByActionName.HandleId = 0;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0012BB91 File Offset: 0x00129D91
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyByActionName.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey` where ActionName=?");
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0012BBAC File Offset: 0x00129DAC
		[return: Nullable(2)]
		public static IReadOnlyList<OpenAndCloseViewHotKey> GetConfigList(string p0ActionName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, ConfigOpenAndCloseViewHotKeyByActionName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OpenAndCloseViewHotKey> readOnlyList = (IReadOnlyList<OpenAndCloseViewHotKey>)ConfigCommon.GetConfig("OpenAndCloseViewHotKeyByActionName#" + p0ActionName);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair.Clear();
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair.Add(new ValueTuple<string, object>("ActionName", p0ActionName));
			if (!ConfigCommon.BindString(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, 1, p0ActionName, ConfigOpenAndCloseViewHotKeyByActionName.LogPair))
			{
				ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, ConfigOpenAndCloseViewHotKeyByActionName.LogPair);
				return null;
			}
			List<OpenAndCloseViewHotKey> list = new List<OpenAndCloseViewHotKey>();
			while (ConfigCommon.Step(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, false, ConfigOpenAndCloseViewHotKeyByActionName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, 0, ConfigOpenAndCloseViewHotKeyByActionName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, ConfigOpenAndCloseViewHotKeyByActionName.LogPair);
					return null;
				}
				OpenAndCloseViewHotKey rootAsOpenAndCloseViewHotKey = OpenAndCloseViewHotKey.GetRootAsOpenAndCloseViewHotKey(new ByteBuffer(item2));
				list.Add(rootAsOpenAndCloseViewHotKey);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OpenAndCloseViewHotKeyByActionName#" + p0ActionName, list, list.Count);
			}
			ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, ConfigOpenAndCloseViewHotKeyByActionName.LogPair);
			return list;
		}

		// Token: 0x04002B28 RID: 11048
		private const string DB = "db_input_settings.db";

		// Token: 0x04002B29 RID: 11049
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002B2A RID: 11050
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002B2B RID: 11051
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey` where ActionName=?";

		// Token: 0x04002B2C RID: 11052
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyByActionName";

		// Token: 0x04002B2D RID: 11053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B2E RID: 11054
		private static int HandleId;
	}
}
