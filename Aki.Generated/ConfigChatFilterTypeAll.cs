using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000152 RID: 338
	public class ConfigChatFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x00086688 File Offset: 0x00084888
		static ConfigChatFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigChatFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000866A8 File Offset: 0x000848A8
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

		// Token: 0x060007EF RID: 2031 RVA: 0x00086727 File Offset: 0x00084927
		public static void ResetStaticDefaultValue()
		{
			ConfigChatFilterTypeAll.LogPair = null;
			ConfigChatFilterTypeAll.HandleId = 0;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00086735 File Offset: 0x00084935
		public static void Init()
		{
			ConfigChatFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChatFilterTypeAll.HandleId, "db_phonemsg.db", "select BinData from `ChatFilterType`");
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00086750 File Offset: 0x00084950
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

		// Token: 0x04000922 RID: 2338
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000923 RID: 2339
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000924 RID: 2340
		private const string TABLE = "ChatFilterType";

		// Token: 0x04000925 RID: 2341
		private const string COMMAND = "select BinData from `ChatFilterType`";

		// Token: 0x04000926 RID: 2342
		private const string KEY_PREFIX = "ChatFilterTypeAll";

		// Token: 0x04000927 RID: 2343
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000928 RID: 2344
		private static int HandleId;
	}
}
