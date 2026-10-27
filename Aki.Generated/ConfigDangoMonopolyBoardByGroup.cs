using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E7 RID: 487
	public class ConfigDangoMonopolyBoardByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x0009A37B File Offset: 0x0009857B
		static ConfigDangoMonopolyBoardByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyBoardByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyBoardByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0009A39C File Offset: 0x0009859C
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

		// Token: 0x06000B6F RID: 2927 RVA: 0x0009A41B File Offset: 0x0009861B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardByGroup.LogPair = null;
			ConfigDangoMonopolyBoardByGroup.HandleId = 0;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0009A429 File Offset: 0x00098629
		public static void Init()
		{
			ConfigDangoMonopolyBoardByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyBoardByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyBoard` where BoardGroupId=?");
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0009A444 File Offset: 0x00098644
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

		// Token: 0x04000D35 RID: 3381
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D36 RID: 3382
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D37 RID: 3383
		private const string TABLE = "DangoMonopolyBoard";

		// Token: 0x04000D38 RID: 3384
		private const string COMMAND = "select BinData from `DangoMonopolyBoard` where BoardGroupId=?";

		// Token: 0x04000D39 RID: 3385
		private const string KEY_PREFIX = "DangoMonopolyBoardByGroup";

		// Token: 0x04000D3A RID: 3386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D3B RID: 3387
		private static int HandleId;
	}
}
