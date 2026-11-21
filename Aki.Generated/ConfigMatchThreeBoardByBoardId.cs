using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000541 RID: 1345
	public class ConfigMatchThreeBoardByBoardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F91 RID: 8081 RVA: 0x0010F3EC File Offset: 0x0010D5EC
		static ConfigMatchThreeBoardByBoardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeBoardByBoardId.CreateStaticDefaultValue), new Action(ConfigMatchThreeBoardByBoardId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0010F40C File Offset: 0x0010D60C
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeBoardByBoardId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeBoardByBoardId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeBoard"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeBoard` where BoardId=?")
			});
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0010F48B File Offset: 0x0010D68B
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeBoardByBoardId.LogPair = null;
			ConfigMatchThreeBoardByBoardId.HandleId = 0;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0010F499 File Offset: 0x0010D699
		public static void Init()
		{
			ConfigMatchThreeBoardByBoardId.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeBoardByBoardId.HandleId, "db_matchthree.db", "select BinData from `MatchThreeBoard` where BoardId=?");
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0010F4B4 File Offset: 0x0010D6B4
		[NullableContext(2)]
		public static IReadOnlyList<MatchThreeBoard> GetConfigList(int p0BoardId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeBoardByBoardId.HandleId, ConfigMatchThreeBoardByBoardId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeBoardByBoardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardId);
				IReadOnlyList<MatchThreeBoard> readOnlyList = (IReadOnlyList<MatchThreeBoard>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMatchThreeBoardByBoardId.LogPair.Clear();
			ConfigMatchThreeBoardByBoardId.LogPair.Add(new ValueTuple<string, object>("BoardId", p0BoardId));
			if (!ConfigCommon.BindInt(ConfigMatchThreeBoardByBoardId.HandleId, 1, p0BoardId, ConfigMatchThreeBoardByBoardId.LogPair))
			{
				ConfigCommon.Reset(ConfigMatchThreeBoardByBoardId.HandleId, ConfigMatchThreeBoardByBoardId.LogPair);
				return null;
			}
			List<MatchThreeBoard> list = new List<MatchThreeBoard>();
			while (ConfigCommon.Step(ConfigMatchThreeBoardByBoardId.HandleId, false, ConfigMatchThreeBoardByBoardId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeBoardByBoardId.HandleId, 0, ConfigMatchThreeBoardByBoardId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMatchThreeBoardByBoardId.HandleId, ConfigMatchThreeBoardByBoardId.LogPair);
					return null;
				}
				MatchThreeBoard rootAsMatchThreeBoard = MatchThreeBoard.GetRootAsMatchThreeBoard(new ByteBuffer(item2));
				list.Add(rootAsMatchThreeBoard);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeBoardByBoardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMatchThreeBoardByBoardId.HandleId, ConfigMatchThreeBoardByBoardId.LogPair);
			return list;
		}

		// Token: 0x040024AB RID: 9387
		private const string DB = "db_matchthree.db";

		// Token: 0x040024AC RID: 9388
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024AD RID: 9389
		private const string TABLE = "MatchThreeBoard";

		// Token: 0x040024AE RID: 9390
		private const string COMMAND = "select BinData from `MatchThreeBoard` where BoardId=?";

		// Token: 0x040024AF RID: 9391
		private const string KEY_PREFIX = "MatchThreeBoardByBoardId";

		// Token: 0x040024B0 RID: 9392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024B1 RID: 9393
		private static int HandleId;
	}
}
