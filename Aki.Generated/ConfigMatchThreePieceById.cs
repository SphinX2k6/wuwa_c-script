using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054A RID: 1354
	public class ConfigMatchThreePieceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x001107B0 File Offset: 0x0010E9B0
		static ConfigMatchThreePieceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreePieceById.CreateStaticDefaultValue), new Action(ConfigMatchThreePieceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x001107D0 File Offset: 0x0010E9D0
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

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0011084F File Offset: 0x0010EA4F
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreePieceById.LogPair = null;
			ConfigMatchThreePieceById.HandleId = 0;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0011085D File Offset: 0x0010EA5D
		public static void Init()
		{
			ConfigMatchThreePieceById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreePieceById.HandleId, "db_matchthree.db", "select BinData from `MatchThreePiece` where Id=?");
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00110878 File Offset: 0x0010EA78
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

		// Token: 0x040024EA RID: 9450
		private const string DB = "db_matchthree.db";

		// Token: 0x040024EB RID: 9451
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024EC RID: 9452
		private const string TABLE = "MatchThreePiece";

		// Token: 0x040024ED RID: 9453
		private const string COMMAND = "select BinData from `MatchThreePiece` where Id=?";

		// Token: 0x040024EE RID: 9454
		private const string KEY_PREFIX = "MatchThreePieceById";

		// Token: 0x040024EF RID: 9455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024F0 RID: 9456
		private static int HandleId;
	}
}
