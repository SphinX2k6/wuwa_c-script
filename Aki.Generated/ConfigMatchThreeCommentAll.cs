using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000542 RID: 1346
	public class ConfigMatchThreeCommentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F97 RID: 8087 RVA: 0x0010F623 File Offset: 0x0010D823
		static ConfigMatchThreeCommentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeCommentAll.CreateStaticDefaultValue), new Action(ConfigMatchThreeCommentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0010F644 File Offset: 0x0010D844
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeCommentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeCommentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeComment"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeComment`")
			});
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0010F6C3 File Offset: 0x0010D8C3
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeCommentAll.LogPair = null;
			ConfigMatchThreeCommentAll.HandleId = 0;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0010F6D1 File Offset: 0x0010D8D1
		public static void Init()
		{
			ConfigMatchThreeCommentAll.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeCommentAll.HandleId, "db_matchthree.db", "select BinData from `MatchThreeComment`");
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0010F6EC File Offset: 0x0010D8EC
		[NullableContext(2)]
		public static IReadOnlyList<MatchThreeComment> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeCommentAll.HandleId, ConfigMatchThreeCommentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MatchThreeComment> readOnlyList = (IReadOnlyList<MatchThreeComment>)ConfigCommon.GetConfig("MatchThreeCommentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MatchThreeComment> list = new List<MatchThreeComment>();
			while (ConfigCommon.Step(ConfigMatchThreeCommentAll.HandleId, false, ConfigMatchThreeCommentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeCommentAll.HandleId, 0, ConfigMatchThreeCommentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMatchThreeCommentAll.HandleId, ConfigMatchThreeCommentAll.LogPair);
					return null;
				}
				MatchThreeComment rootAsMatchThreeComment = MatchThreeComment.GetRootAsMatchThreeComment(new ByteBuffer(item2));
				list.Add(rootAsMatchThreeComment);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MatchThreeCommentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMatchThreeCommentAll.HandleId, ConfigMatchThreeCommentAll.LogPair);
			return list;
		}

		// Token: 0x040024B2 RID: 9394
		private const string DB = "db_matchthree.db";

		// Token: 0x040024B3 RID: 9395
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024B4 RID: 9396
		private const string TABLE = "MatchThreeComment";

		// Token: 0x040024B5 RID: 9397
		private const string COMMAND = "select BinData from `MatchThreeComment`";

		// Token: 0x040024B6 RID: 9398
		private const string KEY_PREFIX = "MatchThreeCommentAll";

		// Token: 0x040024B7 RID: 9399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024B8 RID: 9400
		private static int HandleId;
	}
}
