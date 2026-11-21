using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000161 RID: 353
	public class ConfigChatFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0008BFEC File Offset: 0x0008A1EC
		static ConfigChatFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigChatFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0008C00C File Offset: 0x0008A20C
		public static void CreateStaticDefaultValue()
		{
			ConfigChatFilterTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatFilterTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatFilterType`")
			});
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0008C08B File Offset: 0x0008A28B
		public static void ResetStaticDefaultValue()
		{
			ConfigChatFilterTypeAll.LogPair = null;
			ConfigChatFilterTypeAll.HandleId = 0;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0008C099 File Offset: 0x0008A299
		public static void Init()
		{
			ConfigChatFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatFilterTypeAll.HandleId, "db_phonemsg.db", "select BinData from `ChatFilterType`");
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0008C0B4 File Offset: 0x0008A2B4
		[NullableContext(2)]
		public static IReadOnlyList<ChatFilterType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatFilterTypeAll.HandleId, ConfigChatFilterTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChatFilterType> readOnlyList = (IReadOnlyList<ChatFilterType>)ConfigCommon.GetConfig("ChatFilterTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChatFilterType> list = new List<ChatFilterType>();
			while (ConfigCommon.Step(ConfigChatFilterTypeAll.HandleId, false, ConfigChatFilterTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatFilterTypeAll.HandleId, 0, ConfigChatFilterTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChatFilterTypeAll.HandleId, ConfigChatFilterTypeAll.LogPair);
					return null;
				}
				ChatFilterType rootAsChatFilterType = ChatFilterType.GetRootAsChatFilterType(new ByteBuffer(item2));
				list.Add(rootAsChatFilterType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChatFilterTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChatFilterTypeAll.HandleId, ConfigChatFilterTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400098B RID: 2443
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400098C RID: 2444
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400098D RID: 2445
		private const string TABLE = "ChatFilterType";

		// Token: 0x0400098E RID: 2446
		private const string COMMAND = "select BinData from `ChatFilterType`";

		// Token: 0x0400098F RID: 2447
		private const string KEY_PREFIX = "ChatFilterTypeAll";

		// Token: 0x04000990 RID: 2448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000991 RID: 2449
		private static int HandleId;
	}
}
