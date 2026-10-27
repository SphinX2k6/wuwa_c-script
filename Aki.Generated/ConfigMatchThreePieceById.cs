using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000534 RID: 1332
	public class ConfigMatchThreePieceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x0010A05C File Offset: 0x0010825C
		static ConfigMatchThreePieceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreePieceById.CreateStaticDefaultValue), new Action(ConfigMatchThreePieceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0010A07C File Offset: 0x0010827C
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreePieceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreePieceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreePiece"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreePiece` where Id=?")
			});
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0010A0FB File Offset: 0x001082FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreePieceById.LogPair = null;
			ConfigMatchThreePieceById.HandleId = 0;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0010A109 File Offset: 0x00108309
		public static void Init()
		{
			ConfigMatchThreePieceById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreePieceById.HandleId, "db_matchthree.db", "select BinData from `MatchThreePiece` where Id=?");
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0010A124 File Offset: 0x00108324
		public static MatchThreePiece? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreePieceById.HandleId, ConfigMatchThreePieceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreePieceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreePiece?(MatchThreePiece.GetRootAsMatchThreePiece(configBuffer));
				}
			}
			ConfigMatchThreePieceById.LogPair.Clear();
			ConfigMatchThreePieceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreePieceById.HandleId, 1, p0Id, ConfigMatchThreePieceById.LogPair) || ConfigCommon.Step(ConfigMatchThreePieceById.HandleId, true, ConfigMatchThreePieceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreePieceById.HandleId, ConfigMatchThreePieceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreePieceById.HandleId, 0, ConfigMatchThreePieceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreePieceById.HandleId, ConfigMatchThreePieceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreePiece rootAsMatchThreePiece = MatchThreePiece.GetRootAsMatchThreePiece(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreePieceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreePieceById.HandleId, ConfigMatchThreePieceById.LogPair);
			return new MatchThreePiece?(rootAsMatchThreePiece);
		}

		// Token: 0x04002450 RID: 9296
		private const string DB = "db_matchthree.db";

		// Token: 0x04002451 RID: 9297
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002452 RID: 9298
		private const string TABLE = "MatchThreePiece";

		// Token: 0x04002453 RID: 9299
		private const string COMMAND = "select BinData from `MatchThreePiece` where Id=?";

		// Token: 0x04002454 RID: 9300
		private const string KEY_PREFIX = "MatchThreePieceById";

		// Token: 0x04002455 RID: 9301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002456 RID: 9302
		private static int HandleId;
	}
}
