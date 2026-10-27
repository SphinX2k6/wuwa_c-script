using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082E RID: 2094
	public class ConfigRoguePopularEntrieArgBySeasonIdAndInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003126 RID: 12582 RVA: 0x0016F40C File Offset: 0x0016D60C
		static ConfigRoguePopularEntrieArgBySeasonIdAndInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0016F42C File Offset: 0x0016D62C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RoguePopularEntrieArg"),
				new ValueTuple<string, object>("语句", "select BinData from `RoguePopularEntrieArg` where SeasonId=? AND InstId=?")
			});
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0016F4AB File Offset: 0x0016D6AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair = null;
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId = 0;
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x0016F4B9 File Offset: 0x0016D6B9
		public static void Init()
		{
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg` where SeasonId=? AND InstId=?");
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x0016F4D4 File Offset: 0x0016D6D4
		public static RoguePopularEntrieArg? GetConfig(int p0SeasonId, int p1InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePopularEntrieArgBySeasonIdAndInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoguePopularEntrieArg?(RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(configBuffer));
				}
			}
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair.Clear();
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p1InstId));
			if (!ConfigCommon.BindInt(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, 1, p0SeasonId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair) || !ConfigCommon.BindInt(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, 2, p1InstId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair) || ConfigCommon.Step(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, true, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, 0, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoguePopularEntrieArg rootAsRoguePopularEntrieArg = RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePopularEntrieArgBySeasonIdAndInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair);
			return new RoguePopularEntrieArg?(rootAsRoguePopularEntrieArg);
		}

		// Token: 0x04003928 RID: 14632
		private const string DB = "db_rogue.db";

		// Token: 0x04003929 RID: 14633
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400392A RID: 14634
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x0400392B RID: 14635
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg` where SeasonId=? AND InstId=?";

		// Token: 0x0400392C RID: 14636
		private const string KEY_PREFIX = "RoguePopularEntrieArgBySeasonIdAndInstId";

		// Token: 0x0400392D RID: 14637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400392E RID: 14638
		private static int HandleId;
	}
}
