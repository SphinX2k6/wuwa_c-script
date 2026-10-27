using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DA RID: 2522
	public class ConfigTetrisShapeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B30 RID: 15152 RVA: 0x001A888D File Offset: 0x001A6A8D
		static ConfigTetrisShapeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeAll.CreateStaticDefaultValue), new Action(ConfigTetrisShapeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x001A88AC File Offset: 0x001A6AAC
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisShapeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisShapeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisShape"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisShape`")
			});
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001A892B File Offset: 0x001A6B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeAll.LogPair = null;
			ConfigTetrisShapeAll.HandleId = 0;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x001A8939 File Offset: 0x001A6B39
		public static void Init()
		{
			ConfigTetrisShapeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeAll.HandleId, "db_tetris.db", "select BinData from `TetrisShape`");
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x001A8954 File Offset: 0x001A6B54
		[NullableContext(2)]
		public static IReadOnlyList<TetrisShape> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisShapeAll.HandleId, ConfigTetrisShapeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TetrisShape> readOnlyList = (IReadOnlyList<TetrisShape>)ConfigCommon.GetConfig("TetrisShapeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TetrisShape> list = new List<TetrisShape>();
			while (ConfigCommon.Step(ConfigTetrisShapeAll.HandleId, false, ConfigTetrisShapeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisShapeAll.HandleId, 0, ConfigTetrisShapeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisShapeAll.HandleId, ConfigTetrisShapeAll.LogPair);
					return null;
				}
				TetrisShape rootAsTetrisShape = TetrisShape.GetRootAsTetrisShape(new ByteBuffer(item2));
				list.Add(rootAsTetrisShape);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TetrisShapeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisShapeAll.HandleId, ConfigTetrisShapeAll.LogPair);
			return list;
		}

		// Token: 0x040044DC RID: 17628
		private const string DB = "db_tetris.db";

		// Token: 0x040044DD RID: 17629
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044DE RID: 17630
		private const string TABLE = "TetrisShape";

		// Token: 0x040044DF RID: 17631
		private const string COMMAND = "select BinData from `TetrisShape`";

		// Token: 0x040044E0 RID: 17632
		private const string KEY_PREFIX = "TetrisShapeAll";

		// Token: 0x040044E1 RID: 17633
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044E2 RID: 17634
		private static int HandleId;
	}
}
