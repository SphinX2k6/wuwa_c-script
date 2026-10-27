using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D7 RID: 2519
	public class ConfigTetrisMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x001A81CC File Offset: 0x001A63CC
		static ConfigTetrisMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisMapByMapId.CreateStaticDefaultValue), new Action(ConfigTetrisMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x001A81EC File Offset: 0x001A63EC
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisMapByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisMapByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisMap"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisMap` where MapId=?")
			});
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x001A826B File Offset: 0x001A646B
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisMapByMapId.LogPair = null;
			ConfigTetrisMapByMapId.HandleId = 0;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x001A8279 File Offset: 0x001A6479
		public static void Init()
		{
			ConfigTetrisMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisMapByMapId.HandleId, "db_tetris.db", "select BinData from `TetrisMap` where MapId=?");
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x001A8294 File Offset: 0x001A6494
		[NullableContext(2)]
		public static IReadOnlyList<TetrisMap> GetConfigList(int p0MapID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisMapByMapId.HandleId, ConfigTetrisMapByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapID);
				IReadOnlyList<TetrisMap> readOnlyList = (IReadOnlyList<TetrisMap>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTetrisMapByMapId.LogPair.Clear();
			ConfigTetrisMapByMapId.LogPair.Add(new ValueTuple<string, object>("MapID", p0MapID));
			if (!ConfigCommon.BindInt(ConfigTetrisMapByMapId.HandleId, 1, p0MapID, ConfigTetrisMapByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigTetrisMapByMapId.HandleId, ConfigTetrisMapByMapId.LogPair);
				return null;
			}
			List<TetrisMap> list = new List<TetrisMap>();
			while (ConfigCommon.Step(ConfigTetrisMapByMapId.HandleId, false, ConfigTetrisMapByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisMapByMapId.HandleId, 0, ConfigTetrisMapByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisMapByMapId.HandleId, ConfigTetrisMapByMapId.LogPair);
					return null;
				}
				TetrisMap rootAsTetrisMap = TetrisMap.GetRootAsTetrisMap(new ByteBuffer(item2));
				list.Add(rootAsTetrisMap);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapID);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisMapByMapId.HandleId, ConfigTetrisMapByMapId.LogPair);
			return list;
		}

		// Token: 0x040044C7 RID: 17607
		private const string DB = "db_tetris.db";

		// Token: 0x040044C8 RID: 17608
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x040044C9 RID: 17609
		private const string TABLE = "TetrisMap";

		// Token: 0x040044CA RID: 17610
		private const string COMMAND = "select BinData from `TetrisMap` where MapId=?";

		// Token: 0x040044CB RID: 17611
		private const string KEY_PREFIX = "TetrisMapByMapId";

		// Token: 0x040044CC RID: 17612
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044CD RID: 17613
		private static int HandleId;
	}
}
