using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA9 RID: 2729
	public class ConfigTetrisByActivityIdAndGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600400A RID: 16394 RVA: 0x001C6E3F File Offset: 0x001C503F
		static ConfigTetrisByActivityIdAndGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisByActivityIdAndGroupId.CreateStaticDefaultValue), new Action(ConfigTetrisByActivityIdAndGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x001C6E60 File Offset: 0x001C5060
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

		// Token: 0x0600400C RID: 16396 RVA: 0x001C6EDF File Offset: 0x001C50DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisByActivityIdAndGroupId.LogPair = null;
			ConfigTetrisByActivityIdAndGroupId.HandleId = 0;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x001C6EED File Offset: 0x001C50ED
		public static void Init()
		{
			ConfigTetrisByActivityIdAndGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisByActivityIdAndGroupId.HandleId, "db_tetris.db", "select BinData from `Tetris` where ActivityId=? And GroupId=?");
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x001C6F08 File Offset: 0x001C5108
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

		// Token: 0x04004A85 RID: 19077
		private const string DB = "db_tetris.db";

		// Token: 0x04004A86 RID: 19078
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004A87 RID: 19079
		private const string TABLE = "Tetris";

		// Token: 0x04004A88 RID: 19080
		private const string COMMAND = "select BinData from `Tetris` where ActivityId=? And GroupId=?";

		// Token: 0x04004A89 RID: 19081
		private const string KEY_PREFIX = "TetrisByActivityIdAndGroupId";

		// Token: 0x04004A8A RID: 19082
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A8B RID: 19083
		private static int HandleId;
	}
}
