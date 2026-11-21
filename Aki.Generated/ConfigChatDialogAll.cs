using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015A RID: 346
	public class ConfigChatDialogAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x0008B220 File Offset: 0x00089420
		static ConfigChatDialogAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatDialogAll.CreateStaticDefaultValue), new Action(ConfigChatDialogAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0008B240 File Offset: 0x00089440
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

		// Token: 0x0600081F RID: 2079 RVA: 0x0008B2BF File Offset: 0x000894BF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatDialogAll.LogPair = null;
			ConfigChatDialogAll.HandleId = 0;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0008B2CD File Offset: 0x000894CD
		public static void Init()
		{
			ConfigChatDialogAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatDialogAll.HandleId, "db_phonemsg.db", "select BinData from `ChatDialog`");
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0008B2E8 File Offset: 0x000894E8
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

		// Token: 0x0400095A RID: 2394
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400095B RID: 2395
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400095C RID: 2396
		private const string TABLE = "ChatDialog";

		// Token: 0x0400095D RID: 2397
		private const string COMMAND = "select BinData from `ChatDialog`";

		// Token: 0x0400095E RID: 2398
		private const string KEY_PREFIX = "ChatDialogAll";

		// Token: 0x0400095F RID: 2399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000960 RID: 2400
		private static int HandleId;
	}
}
