using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000646 RID: 1606
	public class ConfigOpenAndCloseViewHotKeyByActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x0013255F File Offset: 0x0013075F
		static ConfigOpenAndCloseViewHotKeyByActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyByActionName.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyByActionName.ResetStaticDefaultValue));
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00132580 File Offset: 0x00130780
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

		// Token: 0x060025B6 RID: 9654 RVA: 0x001325FF File Offset: 0x001307FF
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByActionName.LogPair = null;
			ConfigOpenAndCloseViewHotKeyByActionName.HandleId = 0;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0013260D File Offset: 0x0013080D
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyByActionName.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyByActionName.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey` where ActionName=?");
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00132628 File Offset: 0x00130828
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

		// Token: 0x04002BD0 RID: 11216
		private const string DB = "db_input_settings.db";

		// Token: 0x04002BD1 RID: 11217
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002BD2 RID: 11218
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002BD3 RID: 11219
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey` where ActionName=?";

		// Token: 0x04002BD4 RID: 11220
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyByActionName";

		// Token: 0x04002BD5 RID: 11221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BD6 RID: 11222
		private static int HandleId;
	}
}
