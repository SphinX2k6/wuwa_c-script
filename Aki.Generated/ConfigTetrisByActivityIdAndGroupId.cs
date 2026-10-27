using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D4 RID: 2516
	public class ConfigTetrisByActivityIdAndGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B0C RID: 15116 RVA: 0x001A7AAB File Offset: 0x001A5CAB
		static ConfigTetrisByActivityIdAndGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisByActivityIdAndGroupId.CreateStaticDefaultValue), new Action(ConfigTetrisByActivityIdAndGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x001A7ACC File Offset: 0x001A5CCC
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisByActivityIdAndGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisByActivityIdAndGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "Tetris"),
				new ValueTuple<string, object>("语句", "select BinData from `Tetris` where ActivityId=? And GroupId=?")
			});
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x001A7B4B File Offset: 0x001A5D4B
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisByActivityIdAndGroupId.LogPair = null;
			ConfigTetrisByActivityIdAndGroupId.HandleId = 0;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x001A7B59 File Offset: 0x001A5D59
		public static void Init()
		{
			ConfigTetrisByActivityIdAndGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisByActivityIdAndGroupId.HandleId, "db_tetris.db", "select BinData from `Tetris` where ActivityId=? And GroupId=?");
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x001A7B74 File Offset: 0x001A5D74
		[NullableContext(2)]
		public static IReadOnlyList<Tetris> GetConfigList(int p0ActivityId, int p1GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisByActivityIdAndGroupId.HandleId, ConfigTetrisByActivityIdAndGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisByActivityIdAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				IReadOnlyList<Tetris> readOnlyList = (IReadOnlyList<Tetris>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTetrisByActivityIdAndGroupId.LogPair.Clear();
			ConfigTetrisByActivityIdAndGroupId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigTetrisByActivityIdAndGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p1GroupId));
			if (!ConfigCommon.BindInt(ConfigTetrisByActivityIdAndGroupId.HandleId, 1, p0ActivityId, ConfigTetrisByActivityIdAndGroupId.LogPair) || !ConfigCommon.BindInt(ConfigTetrisByActivityIdAndGroupId.HandleId, 2, p1GroupId, ConfigTetrisByActivityIdAndGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigTetrisByActivityIdAndGroupId.HandleId, ConfigTetrisByActivityIdAndGroupId.LogPair);
				return null;
			}
			List<Tetris> list = new List<Tetris>();
			while (ConfigCommon.Step(ConfigTetrisByActivityIdAndGroupId.HandleId, false, ConfigTetrisByActivityIdAndGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisByActivityIdAndGroupId.HandleId, 0, ConfigTetrisByActivityIdAndGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisByActivityIdAndGroupId.HandleId, ConfigTetrisByActivityIdAndGroupId.LogPair);
					return null;
				}
				Tetris rootAsTetris = Tetris.GetRootAsTetris(new ByteBuffer(item2));
				list.Add(rootAsTetris);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisByActivityIdAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisByActivityIdAndGroupId.HandleId, ConfigTetrisByActivityIdAndGroupId.LogPair);
			return list;
		}

		// Token: 0x040044B2 RID: 17586
		private const string DB = "db_tetris.db";

		// Token: 0x040044B3 RID: 17587
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044B4 RID: 17588
		private const string TABLE = "Tetris";

		// Token: 0x040044B5 RID: 17589
		private const string COMMAND = "select BinData from `Tetris` where ActivityId=? And GroupId=?";

		// Token: 0x040044B6 RID: 17590
		private const string KEY_PREFIX = "TetrisByActivityIdAndGroupId";

		// Token: 0x040044B7 RID: 17591
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044B8 RID: 17592
		private static int HandleId;
	}
}
