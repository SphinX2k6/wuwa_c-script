using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052B RID: 1323
	public class ConfigMatchThreeBoardByBoardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x00108C98 File Offset: 0x00106E98
		static ConfigMatchThreeBoardByBoardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeBoardByBoardId.CreateStaticDefaultValue), new Action(ConfigMatchThreeBoardByBoardId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00108CB8 File Offset: 0x00106EB8
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

		// Token: 0x06001F0F RID: 7951 RVA: 0x00108D37 File Offset: 0x00106F37
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeBoardByBoardId.LogPair = null;
			ConfigMatchThreeBoardByBoardId.HandleId = 0;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00108D45 File Offset: 0x00106F45
		public static void Init()
		{
			ConfigMatchThreeBoardByBoardId.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeBoardByBoardId.HandleId, "db_matchthree.db", "select BinData from `MatchThreeBoard` where BoardId=?");
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00108D60 File Offset: 0x00106F60
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

		// Token: 0x04002411 RID: 9233
		private const string DB = "db_matchthree.db";

		// Token: 0x04002412 RID: 9234
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002413 RID: 9235
		private const string TABLE = "MatchThreeBoard";

		// Token: 0x04002414 RID: 9236
		private const string COMMAND = "select BinData from `MatchThreeBoard` where BoardId=?";

		// Token: 0x04002415 RID: 9237
		private const string KEY_PREFIX = "MatchThreeBoardByBoardId";

		// Token: 0x04002416 RID: 9238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002417 RID: 9239
		private static int HandleId;
	}
}
