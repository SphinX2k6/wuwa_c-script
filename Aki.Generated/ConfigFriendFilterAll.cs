using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000369 RID: 873
	public class ConfigFriendFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x000D0DD4 File Offset: 0x000CEFD4
		static ConfigFriendFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFriendFilterAll.CreateStaticDefaultValue), new Action(ConfigFriendFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000D0DF4 File Offset: 0x000CEFF4
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

		// Token: 0x0600147D RID: 5245 RVA: 0x000D0E73 File Offset: 0x000CF073
		public static void ResetStaticDefaultValue()
		{
			ConfigFriendFilterAll.LogPair = null;
			ConfigFriendFilterAll.HandleId = 0;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000D0E81 File Offset: 0x000CF081
		public static void Init()
		{
			ConfigFriendFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigFriendFilterAll.HandleId, "db_friend.db", "select BinData from `FriendFilter`");
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000D0E9C File Offset: 0x000CF09C
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

		// Token: 0x040017C3 RID: 6083
		private const string DB = "db_friend.db";

		// Token: 0x040017C4 RID: 6084
		private const string FILE = "h.好友.xlsx";

		// Token: 0x040017C5 RID: 6085
		private const string TABLE = "FriendFilter";

		// Token: 0x040017C6 RID: 6086
		private const string COMMAND = "select BinData from `FriendFilter`";

		// Token: 0x040017C7 RID: 6087
		private const string KEY_PREFIX = "FriendFilterAll";

		// Token: 0x040017C8 RID: 6088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017C9 RID: 6089
		private static int HandleId;
	}
}
