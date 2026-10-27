using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FB RID: 2043
	public class ConfigRhythmSubLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x00168490 File Offset: 0x00166690
		static ConfigRhythmSubLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmSubLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigRhythmSubLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x001684B0 File Offset: 0x001666B0
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

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0016852F File Offset: 0x0016672F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmSubLevelByLevelId.LogPair = null;
			ConfigRhythmSubLevelByLevelId.HandleId = 0;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0016853D File Offset: 0x0016673D
		public static void Init()
		{
			ConfigRhythmSubLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmSubLevelByLevelId.HandleId, "db_rhythmship.db", "select BinData from `RhythmSubLevel` where LevelId=?");
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00168558 File Offset: 0x00166758
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

		// Token: 0x040037C3 RID: 14275
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037C4 RID: 14276
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037C5 RID: 14277
		private const string TABLE = "RhythmSubLevel";

		// Token: 0x040037C6 RID: 14278
		private const string COMMAND = "select BinData from `RhythmSubLevel` where LevelId=?";

		// Token: 0x040037C7 RID: 14279
		private const string KEY_PREFIX = "RhythmSubLevelByLevelId";

		// Token: 0x040037C8 RID: 14280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037C9 RID: 14281
		private static int HandleId;
	}
}
