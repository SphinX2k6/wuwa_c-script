using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D3 RID: 2515
	public class ConfigTetrisByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B06 RID: 15110 RVA: 0x001A7874 File Offset: 0x001A5A74
		static ConfigTetrisByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisByActivityId.CreateStaticDefaultValue), new Action(ConfigTetrisByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x001A7894 File Offset: 0x001A5A94
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

		// Token: 0x06003B08 RID: 15112 RVA: 0x001A7913 File Offset: 0x001A5B13
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisByActivityId.LogPair = null;
			ConfigTetrisByActivityId.HandleId = 0;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x001A7921 File Offset: 0x001A5B21
		public static void Init()
		{
			ConfigTetrisByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisByActivityId.HandleId, "db_tetris.db", "select BinData from `Tetris` where ActivityId=?");
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x001A793C File Offset: 0x001A5B3C
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

		// Token: 0x040044AB RID: 17579
		private const string DB = "db_tetris.db";

		// Token: 0x040044AC RID: 17580
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044AD RID: 17581
		private const string TABLE = "Tetris";

		// Token: 0x040044AE RID: 17582
		private const string COMMAND = "select BinData from `Tetris` where ActivityId=?";

		// Token: 0x040044AF RID: 17583
		private const string KEY_PREFIX = "TetrisByActivityId";

		// Token: 0x040044B0 RID: 17584
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044B1 RID: 17585
		private static int HandleId;
	}
}
