using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000817 RID: 2071
	public class ConfigRhythmSubLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600309C RID: 12444 RVA: 0x0016F778 File Offset: 0x0016D978
		static ConfigRhythmSubLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmSubLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigRhythmSubLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x0016F798 File Offset: 0x0016D998
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmSubLevelByLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmSubLevelByLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmSubLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmSubLevel` where LevelId=?")
			});
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x0016F817 File Offset: 0x0016DA17
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmSubLevelByLevelId.LogPair = null;
			ConfigRhythmSubLevelByLevelId.HandleId = 0;
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0016F825 File Offset: 0x0016DA25
		public static void Init()
		{
			ConfigRhythmSubLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmSubLevelByLevelId.HandleId, "db_rhythmship.db", "select BinData from `RhythmSubLevel` where LevelId=?");
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0016F840 File Offset: 0x0016DA40
		[NullableContext(2)]
		public static IReadOnlyList<RhythmSubLevel> GetConfigList(int p0LevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmSubLevelByLevelId.HandleId, ConfigRhythmSubLevelByLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				IReadOnlyList<RhythmSubLevel> readOnlyList = (IReadOnlyList<RhythmSubLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmSubLevelByLevelId.LogPair.Clear();
			ConfigRhythmSubLevelByLevelId.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			if (!ConfigCommon.BindInt(ConfigRhythmSubLevelByLevelId.HandleId, 1, p0LevelId, ConfigRhythmSubLevelByLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmSubLevelByLevelId.HandleId, ConfigRhythmSubLevelByLevelId.LogPair);
				return null;
			}
			List<RhythmSubLevel> list = new List<RhythmSubLevel>();
			while (ConfigCommon.Step(ConfigRhythmSubLevelByLevelId.HandleId, false, ConfigRhythmSubLevelByLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmSubLevelByLevelId.HandleId, 0, ConfigRhythmSubLevelByLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmSubLevelByLevelId.HandleId, ConfigRhythmSubLevelByLevelId.LogPair);
					return null;
				}
				RhythmSubLevel rootAsRhythmSubLevel = RhythmSubLevel.GetRootAsRhythmSubLevel(new ByteBuffer(item2));
				list.Add(rootAsRhythmSubLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmSubLevelByLevelId.HandleId, ConfigRhythmSubLevelByLevelId.LogPair);
			return list;
		}

		// Token: 0x04003887 RID: 14471
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003888 RID: 14472
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003889 RID: 14473
		private const string TABLE = "RhythmSubLevel";

		// Token: 0x0400388A RID: 14474
		private const string COMMAND = "select BinData from `RhythmSubLevel` where LevelId=?";

		// Token: 0x0400388B RID: 14475
		private const string KEY_PREFIX = "RhythmSubLevelByLevelId";

		// Token: 0x0400388C RID: 14476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400388D RID: 14477
		private static int HandleId;
	}
}
