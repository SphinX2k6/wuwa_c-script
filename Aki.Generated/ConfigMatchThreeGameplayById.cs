using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000531 RID: 1329
	public class ConfigMatchThreeGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F31 RID: 7985 RVA: 0x00109984 File Offset: 0x00107B84
		static ConfigMatchThreeGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeGameplayById.CreateStaticDefaultValue), new Action(ConfigMatchThreeGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x001099A4 File Offset: 0x00107BA4
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeGameplay` where Id=?")
			});
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00109A23 File Offset: 0x00107C23
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeGameplayById.LogPair = null;
			ConfigMatchThreeGameplayById.HandleId = 0;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00109A31 File Offset: 0x00107C31
		public static void Init()
		{
			ConfigMatchThreeGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeGameplayById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeGameplay` where Id=?");
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00109A4C File Offset: 0x00107C4C
		public static MatchThreeGameplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeGameplayById.HandleId, ConfigMatchThreeGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeGameplay?(MatchThreeGameplay.GetRootAsMatchThreeGameplay(configBuffer));
				}
			}
			ConfigMatchThreeGameplayById.LogPair.Clear();
			ConfigMatchThreeGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeGameplayById.HandleId, 1, p0Id, ConfigMatchThreeGameplayById.LogPair) || ConfigCommon.Step(ConfigMatchThreeGameplayById.HandleId, true, ConfigMatchThreeGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeGameplayById.HandleId, ConfigMatchThreeGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeGameplayById.HandleId, 0, ConfigMatchThreeGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeGameplayById.HandleId, ConfigMatchThreeGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeGameplay rootAsMatchThreeGameplay = MatchThreeGameplay.GetRootAsMatchThreeGameplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeGameplayById.HandleId, ConfigMatchThreeGameplayById.LogPair);
			return new MatchThreeGameplay?(rootAsMatchThreeGameplay);
		}

		// Token: 0x0400243B RID: 9275
		private const string DB = "db_matchthree.db";

		// Token: 0x0400243C RID: 9276
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x0400243D RID: 9277
		private const string TABLE = "MatchThreeGameplay";

		// Token: 0x0400243E RID: 9278
		private const string COMMAND = "select BinData from `MatchThreeGameplay` where Id=?";

		// Token: 0x0400243F RID: 9279
		private const string KEY_PREFIX = "MatchThreeGameplayById";

		// Token: 0x04002440 RID: 9280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002441 RID: 9281
		private static int HandleId;
	}
}
