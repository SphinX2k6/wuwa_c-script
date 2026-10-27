using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014B RID: 331
	public class ConfigChatDialogAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x000858BC File Offset: 0x00083ABC
		static ConfigChatDialogAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatDialogAll.CreateStaticDefaultValue), new Action(ConfigChatDialogAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000858DC File Offset: 0x00083ADC
		public static void CreateStaticDefaultValue()
		{
			ConfigChatDialogAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatDialogAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatDialog`")
			});
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0008595B File Offset: 0x00083B5B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatDialogAll.LogPair = null;
			ConfigChatDialogAll.HandleId = 0;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00085969 File Offset: 0x00083B69
		public static void Init()
		{
			ConfigChatDialogAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatDialogAll.HandleId, "db_phonemsg.db", "select BinData from `ChatDialog`");
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00085984 File Offset: 0x00083B84
		[NullableContext(2)]
		public static IReadOnlyList<ChatDialog> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatDialogAll.HandleId, ConfigChatDialogAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatDialog> readOnlyList = (IReadOnlyList<ChatDialog>)ConfigCommon.GetConfig("ChatDialogAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatDialog> list = new List<ChatDialog>();
			while (ConfigCommon.Step(ConfigChatDialogAll.HandleId, false, ConfigChatDialogAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatDialogAll.HandleId, 0, ConfigChatDialogAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatDialogAll.HandleId, ConfigChatDialogAll.LogPair);
					return null;
				}
				ChatDialog rootAsChatDialog = ChatDialog.GetRootAsChatDialog(new ByteBuffer(item2));
				list.Add(rootAsChatDialog);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatDialogAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatDialogAll.HandleId, ConfigChatDialogAll.LogPair);
			return list;
		}

		// Token: 0x040008F1 RID: 2289
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008F2 RID: 2290
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008F3 RID: 2291
		private const string TABLE = "ChatDialog";

		// Token: 0x040008F4 RID: 2292
		private const string COMMAND = "select BinData from `ChatDialog`";

		// Token: 0x040008F5 RID: 2293
		private const string KEY_PREFIX = "ChatDialogAll";

		// Token: 0x040008F6 RID: 2294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008F7 RID: 2295
		private static int HandleId;
	}
}
