using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D8 RID: 2520
	public class ConfigTetrisPresetByLevelIdAndRound : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x001A8403 File Offset: 0x001A6603
		static ConfigTetrisPresetByLevelIdAndRound()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisPresetByLevelIdAndRound.CreateStaticDefaultValue), new Action(ConfigTetrisPresetByLevelIdAndRound.ResetStaticDefaultValue));
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x001A8424 File Offset: 0x001A6624
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisPresetByLevelIdAndRound.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisPresetByLevelIdAndRound.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisPreset"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisPreset` where LevelId=? And Round=?")
			});
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x001A84A3 File Offset: 0x001A66A3
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisPresetByLevelIdAndRound.LogPair = null;
			ConfigTetrisPresetByLevelIdAndRound.HandleId = 0;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x001A84B1 File Offset: 0x001A66B1
		public static void Init()
		{
			ConfigTetrisPresetByLevelIdAndRound.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisPresetByLevelIdAndRound.HandleId, "db_tetris.db", "select BinData from `TetrisPreset` where LevelId=? And Round=?");
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x001A84CC File Offset: 0x001A66CC
		[NullableContext(2)]
		public static IReadOnlyList<TetrisPreset> GetConfigList(int p0LevelId, int p1Round, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisPresetByLevelIdAndRound.HandleId, ConfigTetrisPresetByLevelIdAndRound.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisPresetByLevelIdAndRound");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Round);
				IReadOnlyList<TetrisPreset> readOnlyList = (IReadOnlyList<TetrisPreset>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTetrisPresetByLevelIdAndRound.LogPair.Clear();
			ConfigTetrisPresetByLevelIdAndRound.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			ConfigTetrisPresetByLevelIdAndRound.LogPair.Add(new ValueTuple<string, object>("Round", p1Round));
			if (!ConfigCommon.BindInt(ConfigTetrisPresetByLevelIdAndRound.HandleId, 1, p0LevelId, ConfigTetrisPresetByLevelIdAndRound.LogPair) || !ConfigCommon.BindInt(ConfigTetrisPresetByLevelIdAndRound.HandleId, 2, p1Round, ConfigTetrisPresetByLevelIdAndRound.LogPair))
			{
				ConfigCommon.Reset(ConfigTetrisPresetByLevelIdAndRound.HandleId, ConfigTetrisPresetByLevelIdAndRound.LogPair);
				return null;
			}
			List<TetrisPreset> list = new List<TetrisPreset>();
			while (ConfigCommon.Step(ConfigTetrisPresetByLevelIdAndRound.HandleId, false, ConfigTetrisPresetByLevelIdAndRound.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisPresetByLevelIdAndRound.HandleId, 0, ConfigTetrisPresetByLevelIdAndRound.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisPresetByLevelIdAndRound.HandleId, ConfigTetrisPresetByLevelIdAndRound.LogPair);
					return null;
				}
				TetrisPreset rootAsTetrisPreset = TetrisPreset.GetRootAsTetrisPreset(new ByteBuffer(item2));
				list.Add(rootAsTetrisPreset);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisPresetByLevelIdAndRound");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Round);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisPresetByLevelIdAndRound.HandleId, ConfigTetrisPresetByLevelIdAndRound.LogPair);
			return list;
		}

		// Token: 0x040044CE RID: 17614
		private const string DB = "db_tetris.db";

		// Token: 0x040044CF RID: 17615
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044D0 RID: 17616
		private const string TABLE = "TetrisPreset";

		// Token: 0x040044D1 RID: 17617
		private const string COMMAND = "select BinData from `TetrisPreset` where LevelId=? And Round=?";

		// Token: 0x040044D2 RID: 17618
		private const string KEY_PREFIX = "TetrisPresetByLevelIdAndRound";

		// Token: 0x040044D3 RID: 17619
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044D4 RID: 17620
		private static int HandleId;
	}
}
