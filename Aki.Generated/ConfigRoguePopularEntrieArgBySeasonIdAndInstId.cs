using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084A RID: 2122
	public class ConfigRoguePopularEntrieArgBySeasonIdAndInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031CE RID: 12750 RVA: 0x001766F4 File Offset: 0x001748F4
		static ConfigRoguePopularEntrieArgBySeasonIdAndInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.CreateStaticDefaultValue), new Action(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00176714 File Offset: 0x00174914
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

		// Token: 0x060031D0 RID: 12752 RVA: 0x00176793 File Offset: 0x00174993
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.LogPair = null;
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId = 0;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x001767A1 File Offset: 0x001749A1
		public static void Init()
		{
			ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePopularEntrieArgBySeasonIdAndInstId.HandleId, "db_rogue.db", "select BinData from `RoguePopularEntrieArg` where SeasonId=? AND InstId=?");
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x001767BC File Offset: 0x001749BC
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

		// Token: 0x040039EC RID: 14828
		private const string DB = "db_rogue.db";

		// Token: 0x040039ED RID: 14829
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039EE RID: 14830
		private const string TABLE = "RoguePopularEntrieArg";

		// Token: 0x040039EF RID: 14831
		private const string COMMAND = "select BinData from `RoguePopularEntrieArg` where SeasonId=? AND InstId=?";

		// Token: 0x040039F0 RID: 14832
		private const string KEY_PREFIX = "RoguePopularEntrieArgBySeasonIdAndInstId";

		// Token: 0x040039F1 RID: 14833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039F2 RID: 14834
		private static int HandleId;
	}
}
