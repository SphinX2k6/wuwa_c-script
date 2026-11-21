using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA8 RID: 2728
	public class ConfigTetrisByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004004 RID: 16388 RVA: 0x001C6C08 File Offset: 0x001C4E08
		static ConfigTetrisByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisByActivityId.CreateStaticDefaultValue), new Action(ConfigTetrisByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x001C6C28 File Offset: 0x001C4E28
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "Tetris"),
				new ValueTuple<string, object>("语句", "select BinData from `Tetris` where ActivityId=?")
			});
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x001C6CA7 File Offset: 0x001C4EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisByActivityId.LogPair = null;
			ConfigTetrisByActivityId.HandleId = 0;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x001C6CB5 File Offset: 0x001C4EB5
		public static void Init()
		{
			ConfigTetrisByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisByActivityId.HandleId, "db_tetris.db", "select BinData from `Tetris` where ActivityId=?");
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x001C6CD0 File Offset: 0x001C4ED0
		[NullableContext(2)]
		public static IReadOnlyList<Tetris> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisByActivityId.HandleId, ConfigTetrisByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<Tetris> readOnlyList = (IReadOnlyList<Tetris>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTetrisByActivityId.LogPair.Clear();
			ConfigTetrisByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTetrisByActivityId.HandleId, 1, p0ActivityId, ConfigTetrisByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTetrisByActivityId.HandleId, ConfigTetrisByActivityId.LogPair);
				return null;
			}
			List<Tetris> list = new List<Tetris>();
			while (ConfigCommon.Step(ConfigTetrisByActivityId.HandleId, false, ConfigTetrisByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisByActivityId.HandleId, 0, ConfigTetrisByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisByActivityId.HandleId, ConfigTetrisByActivityId.LogPair);
					return null;
				}
				Tetris rootAsTetris = Tetris.GetRootAsTetris(new ByteBuffer(item2));
				list.Add(rootAsTetris);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisByActivityId.HandleId, ConfigTetrisByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004A7E RID: 19070
		private const string DB = "db_tetris.db";

		// Token: 0x04004A7F RID: 19071
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004A80 RID: 19072
		private const string TABLE = "Tetris";

		// Token: 0x04004A81 RID: 19073
		private const string COMMAND = "select BinData from `Tetris` where ActivityId=?";

		// Token: 0x04004A82 RID: 19074
		private const string KEY_PREFIX = "TetrisByActivityId";

		// Token: 0x04004A83 RID: 19075
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A84 RID: 19076
		private static int HandleId;
	}
}
