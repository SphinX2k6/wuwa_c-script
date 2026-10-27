using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052C RID: 1324
	public class ConfigMatchThreeCommentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x00108ECF File Offset: 0x001070CF
		static ConfigMatchThreeCommentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeCommentAll.CreateStaticDefaultValue), new Action(ConfigMatchThreeCommentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00108EF0 File Offset: 0x001070F0
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

		// Token: 0x06001F15 RID: 7957 RVA: 0x00108F6F File Offset: 0x0010716F
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeCommentAll.LogPair = null;
			ConfigMatchThreeCommentAll.HandleId = 0;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00108F7D File Offset: 0x0010717D
		public static void Init()
		{
			ConfigMatchThreeCommentAll.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeCommentAll.HandleId, "db_matchthree.db", "select BinData from `MatchThreeComment`");
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00108F98 File Offset: 0x00107198
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

		// Token: 0x04002418 RID: 9240
		private const string DB = "db_matchthree.db";

		// Token: 0x04002419 RID: 9241
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x0400241A RID: 9242
		private const string TABLE = "MatchThreeComment";

		// Token: 0x0400241B RID: 9243
		private const string COMMAND = "select BinData from `MatchThreeComment`";

		// Token: 0x0400241C RID: 9244
		private const string KEY_PREFIX = "MatchThreeCommentAll";

		// Token: 0x0400241D RID: 9245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400241E RID: 9246
		private static int HandleId;
	}
}
