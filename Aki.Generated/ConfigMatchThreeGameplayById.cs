using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000547 RID: 1351
	public class ConfigMatchThreeGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x001100D8 File Offset: 0x0010E2D8
		static ConfigMatchThreeGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeGameplayById.CreateStaticDefaultValue), new Action(ConfigMatchThreeGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x001100F8 File Offset: 0x0010E2F8
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

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00110177 File Offset: 0x0010E377
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeGameplayById.LogPair = null;
			ConfigMatchThreeGameplayById.HandleId = 0;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00110185 File Offset: 0x0010E385
		public static void Init()
		{
			ConfigMatchThreeGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeGameplayById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeGameplay` where Id=?");
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x001101A0 File Offset: 0x0010E3A0
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

		// Token: 0x040024D5 RID: 9429
		private const string DB = "db_matchthree.db";

		// Token: 0x040024D6 RID: 9430
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024D7 RID: 9431
		private const string TABLE = "MatchThreeGameplay";

		// Token: 0x040024D8 RID: 9432
		private const string COMMAND = "select BinData from `MatchThreeGameplay` where Id=?";

		// Token: 0x040024D9 RID: 9433
		private const string KEY_PREFIX = "MatchThreeGameplayById";

		// Token: 0x040024DA RID: 9434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024DB RID: 9435
		private static int HandleId;
	}
}
