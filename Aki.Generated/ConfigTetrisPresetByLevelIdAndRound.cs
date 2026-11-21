using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAD RID: 2733
	public class ConfigTetrisPresetByLevelIdAndRound : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004022 RID: 16418 RVA: 0x001C7797 File Offset: 0x001C5997
		static ConfigTetrisPresetByLevelIdAndRound()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisPresetByLevelIdAndRound.CreateStaticDefaultValue), new Action(ConfigTetrisPresetByLevelIdAndRound.ResetStaticDefaultValue));
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x001C77B8 File Offset: 0x001C59B8
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

		// Token: 0x06004024 RID: 16420 RVA: 0x001C7837 File Offset: 0x001C5A37
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisPresetByLevelIdAndRound.LogPair = null;
			ConfigTetrisPresetByLevelIdAndRound.HandleId = 0;
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x001C7845 File Offset: 0x001C5A45
		public static void Init()
		{
			ConfigTetrisPresetByLevelIdAndRound.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisPresetByLevelIdAndRound.HandleId, "db_tetris.db", "select BinData from `TetrisPreset` where LevelId=? And Round=?");
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001C7860 File Offset: 0x001C5A60
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

		// Token: 0x04004AA1 RID: 19105
		private const string DB = "db_tetris.db";

		// Token: 0x04004AA2 RID: 19106
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004AA3 RID: 19107
		private const string TABLE = "TetrisPreset";

		// Token: 0x04004AA4 RID: 19108
		private const string COMMAND = "select BinData from `TetrisPreset` where LevelId=? And Round=?";

		// Token: 0x04004AA5 RID: 19109
		private const string KEY_PREFIX = "TetrisPresetByLevelIdAndRound";

		// Token: 0x04004AA6 RID: 19110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AA7 RID: 19111
		private static int HandleId;
	}
}
