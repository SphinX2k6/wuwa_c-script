using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F9 RID: 505
	public class ConfigDangoMonopolyBoardByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x000A02B3 File Offset: 0x0009E4B3
		static ConfigDangoMonopolyBoardByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyBoardByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyBoardByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000A02D4 File Offset: 0x0009E4D4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardByGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyBoardByGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyBoard"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyBoard` where BoardGroupId=?")
			});
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000A0353 File Offset: 0x0009E553
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardByGroup.LogPair = null;
			ConfigDangoMonopolyBoardByGroup.HandleId = 0;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000A0361 File Offset: 0x0009E561
		public static void Init()
		{
			ConfigDangoMonopolyBoardByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyBoardByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyBoard` where BoardGroupId=?");
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000A037C File Offset: 0x0009E57C
		[NullableContext(2)]
		public static IReadOnlyList<DangoMonopolyBoard> GetConfigList(int p0BoardGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyBoardByGroup.HandleId, ConfigDangoMonopolyBoardByGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyBoardByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardGroupId);
				IReadOnlyList<DangoMonopolyBoard> readOnlyList = (IReadOnlyList<DangoMonopolyBoard>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoMonopolyBoardByGroup.LogPair.Clear();
			ConfigDangoMonopolyBoardByGroup.LogPair.Add(new ValueTuple<string, object>("BoardGroupId", p0BoardGroupId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyBoardByGroup.HandleId, 1, p0BoardGroupId, ConfigDangoMonopolyBoardByGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoMonopolyBoardByGroup.HandleId, ConfigDangoMonopolyBoardByGroup.LogPair);
				return null;
			}
			List<DangoMonopolyBoard> list = new List<DangoMonopolyBoard>();
			while (ConfigCommon.Step(ConfigDangoMonopolyBoardByGroup.HandleId, false, ConfigDangoMonopolyBoardByGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyBoardByGroup.HandleId, 0, ConfigDangoMonopolyBoardByGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoMonopolyBoardByGroup.HandleId, ConfigDangoMonopolyBoardByGroup.LogPair);
					return null;
				}
				DangoMonopolyBoard rootAsDangoMonopolyBoard = DangoMonopolyBoard.GetRootAsDangoMonopolyBoard(new ByteBuffer(item2));
				list.Add(rootAsDangoMonopolyBoard);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyBoardByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyBoardByGroup.HandleId, ConfigDangoMonopolyBoardByGroup.LogPair);
			return list;
		}

		// Token: 0x04000DB3 RID: 3507
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DB4 RID: 3508
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DB5 RID: 3509
		private const string TABLE = "DangoMonopolyBoard";

		// Token: 0x04000DB6 RID: 3510
		private const string COMMAND = "select BinData from `DangoMonopolyBoard` where BoardGroupId=?";

		// Token: 0x04000DB7 RID: 3511
		private const string KEY_PREFIX = "DangoMonopolyBoardByGroup";

		// Token: 0x04000DB8 RID: 3512
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DB9 RID: 3513
		private static int HandleId;
	}
}
