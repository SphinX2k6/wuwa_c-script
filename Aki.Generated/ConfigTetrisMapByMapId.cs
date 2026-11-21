using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAC RID: 2732
	public class ConfigTetrisMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600401C RID: 16412 RVA: 0x001C7560 File Offset: 0x001C5760
		static ConfigTetrisMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisMapByMapId.CreateStaticDefaultValue), new Action(ConfigTetrisMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x001C7580 File Offset: 0x001C5780
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

		// Token: 0x0600401E RID: 16414 RVA: 0x001C75FF File Offset: 0x001C57FF
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisMapByMapId.LogPair = null;
			ConfigTetrisMapByMapId.HandleId = 0;
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x001C760D File Offset: 0x001C580D
		public static void Init()
		{
			ConfigTetrisMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisMapByMapId.HandleId, "db_tetris.db", "select BinData from `TetrisMap` where MapId=?");
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x001C7628 File Offset: 0x001C5828
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

		// Token: 0x04004A9A RID: 19098
		private const string DB = "db_tetris.db";

		// Token: 0x04004A9B RID: 19099
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004A9C RID: 19100
		private const string TABLE = "TetrisMap";

		// Token: 0x04004A9D RID: 19101
		private const string COMMAND = "select BinData from `TetrisMap` where MapId=?";

		// Token: 0x04004A9E RID: 19102
		private const string KEY_PREFIX = "TetrisMapByMapId";

		// Token: 0x04004A9F RID: 19103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AA0 RID: 19104
		private static int HandleId;
	}
}
