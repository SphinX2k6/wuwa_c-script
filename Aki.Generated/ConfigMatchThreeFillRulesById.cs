using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000530 RID: 1328
	public class ConfigMatchThreeFillRulesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x0010973C File Offset: 0x0010793C
		static ConfigMatchThreeFillRulesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeFillRulesById.CreateStaticDefaultValue), new Action(ConfigMatchThreeFillRulesById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0010975C File Offset: 0x0010795C
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeFillRulesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeFillRulesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeFillRules"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeFillRules` where Id=?")
			});
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x001097DB File Offset: 0x001079DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeFillRulesById.LogPair = null;
			ConfigMatchThreeFillRulesById.HandleId = 0;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x001097E9 File Offset: 0x001079E9
		public static void Init()
		{
			ConfigMatchThreeFillRulesById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeFillRulesById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeFillRules` where Id=?");
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00109804 File Offset: 0x00107A04
		public static MatchThreeFillRules? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeFillRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeFillRules?(MatchThreeFillRules.GetRootAsMatchThreeFillRules(configBuffer));
				}
			}
			ConfigMatchThreeFillRulesById.LogPair.Clear();
			ConfigMatchThreeFillRulesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeFillRulesById.HandleId, 1, p0Id, ConfigMatchThreeFillRulesById.LogPair) || ConfigCommon.Step(ConfigMatchThreeFillRulesById.HandleId, true, ConfigMatchThreeFillRulesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeFillRulesById.HandleId, 0, ConfigMatchThreeFillRulesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeFillRules rootAsMatchThreeFillRules = MatchThreeFillRules.GetRootAsMatchThreeFillRules(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeFillRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeFillRulesById.HandleId, ConfigMatchThreeFillRulesById.LogPair);
			return new MatchThreeFillRules?(rootAsMatchThreeFillRules);
		}

		// Token: 0x04002434 RID: 9268
		private const string DB = "db_matchthree.db";

		// Token: 0x04002435 RID: 9269
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002436 RID: 9270
		private const string TABLE = "MatchThreeFillRules";

		// Token: 0x04002437 RID: 9271
		private const string COMMAND = "select BinData from `MatchThreeFillRules` where Id=?";

		// Token: 0x04002438 RID: 9272
		private const string KEY_PREFIX = "MatchThreeFillRulesById";

		// Token: 0x04002439 RID: 9273
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400243A RID: 9274
		private static int HandleId;
	}
}
