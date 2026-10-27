using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000354 RID: 852
	public class ConfigFriendFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013FD RID: 5117 RVA: 0x000CA8C8 File Offset: 0x000C8AC8
		static ConfigFriendFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFriendFilterAll.CreateStaticDefaultValue), new Action(ConfigFriendFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000CA8E8 File Offset: 0x000C8AE8
		public static void CreateStaticDefaultValue()
		{
			ConfigFriendFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFriendFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_friend.db"),
				new ValueTuple<string, object>("文件", "h.好友.xlsx"),
				new ValueTuple<string, object>("表名", "FriendFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `FriendFilter`")
			});
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000CA967 File Offset: 0x000C8B67
		public static void ResetStaticDefaultValue()
		{
			ConfigFriendFilterAll.LogPair = null;
			ConfigFriendFilterAll.HandleId = 0;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000CA975 File Offset: 0x000C8B75
		public static void Init()
		{
			ConfigFriendFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigFriendFilterAll.HandleId, "db_friend.db", "select BinData from `FriendFilter`");
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000CA990 File Offset: 0x000C8B90
		[NullableContext(2)]
		public static IReadOnlyList<FriendFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFriendFilterAll.HandleId, ConfigFriendFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FriendFilter> readOnlyList = (IReadOnlyList<FriendFilter>)ConfigCommon.GetConfig("FriendFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FriendFilter> list = new List<FriendFilter>();
			while (ConfigCommon.Step(ConfigFriendFilterAll.HandleId, false, ConfigFriendFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFriendFilterAll.HandleId, 0, ConfigFriendFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFriendFilterAll.HandleId, ConfigFriendFilterAll.LogPair);
					return null;
				}
				FriendFilter rootAsFriendFilter = FriendFilter.GetRootAsFriendFilter(new ByteBuffer(item2));
				list.Add(rootAsFriendFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FriendFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFriendFilterAll.HandleId, ConfigFriendFilterAll.LogPair);
			return list;
		}

		// Token: 0x04001730 RID: 5936
		private const string DB = "db_friend.db";

		// Token: 0x04001731 RID: 5937
		private const string FILE = "h.好友.xlsx";

		// Token: 0x04001732 RID: 5938
		private const string TABLE = "FriendFilter";

		// Token: 0x04001733 RID: 5939
		private const string COMMAND = "select BinData from `FriendFilter`";

		// Token: 0x04001734 RID: 5940
		private const string KEY_PREFIX = "FriendFilterAll";

		// Token: 0x04001735 RID: 5941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001736 RID: 5942
		private static int HandleId;
	}
}
