using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAF RID: 2735
	public class ConfigTetrisShapeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600402E RID: 16430 RVA: 0x001C7C21 File Offset: 0x001C5E21
		static ConfigTetrisShapeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeAll.CreateStaticDefaultValue), new Action(ConfigTetrisShapeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001C7C40 File Offset: 0x001C5E40
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

		// Token: 0x06004030 RID: 16432 RVA: 0x001C7CBF File Offset: 0x001C5EBF
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeAll.LogPair = null;
			ConfigTetrisShapeAll.HandleId = 0;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001C7CCD File Offset: 0x001C5ECD
		public static void Init()
		{
			ConfigTetrisShapeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeAll.HandleId, "db_tetris.db", "select BinData from `TetrisShape`");
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001C7CE8 File Offset: 0x001C5EE8
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

		// Token: 0x04004AAF RID: 19119
		private const string DB = "db_tetris.db";

		// Token: 0x04004AB0 RID: 19120
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004AB1 RID: 19121
		private const string TABLE = "TetrisShape";

		// Token: 0x04004AB2 RID: 19122
		private const string COMMAND = "select BinData from `TetrisShape`";

		// Token: 0x04004AB3 RID: 19123
		private const string KEY_PREFIX = "TetrisShapeAll";

		// Token: 0x04004AB4 RID: 19124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AB5 RID: 19125
		private static int HandleId;
	}
}
