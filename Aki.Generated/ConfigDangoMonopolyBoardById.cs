using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E8 RID: 488
	public class ConfigDangoMonopolyBoardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x0009A5B3 File Offset: 0x000987B3
		static ConfigDangoMonopolyBoardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyBoardById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyBoardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0009A5D4 File Offset: 0x000987D4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyBoardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyBoard"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyBoard` where BoardId=?")
			});
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0009A653 File Offset: 0x00098853
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardById.LogPair = null;
			ConfigDangoMonopolyBoardById.HandleId = 0;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0009A661 File Offset: 0x00098861
		public static void Init()
		{
			ConfigDangoMonopolyBoardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyBoardById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyBoard` where BoardId=?");
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0009A67C File Offset: 0x0009887C
		public static DangoMonopolyBoard? GetConfig(int p0BoardId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyBoardById.HandleId, ConfigDangoMonopolyBoardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyBoardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopolyBoard?(DangoMonopolyBoard.GetRootAsDangoMonopolyBoard(configBuffer));
				}
			}
			ConfigDangoMonopolyBoardById.LogPair.Clear();
			ConfigDangoMonopolyBoardById.LogPair.Add(new ValueTuple<string, object>("BoardId", p0BoardId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyBoardById.HandleId, 1, p0BoardId, ConfigDangoMonopolyBoardById.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyBoardById.HandleId, true, ConfigDangoMonopolyBoardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyBoardById.HandleId, ConfigDangoMonopolyBoardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyBoardById.HandleId, 0, ConfigDangoMonopolyBoardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyBoardById.HandleId, ConfigDangoMonopolyBoardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopolyBoard rootAsDangoMonopolyBoard = DangoMonopolyBoard.GetRootAsDangoMonopolyBoard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyBoardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BoardId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyBoardById.HandleId, ConfigDangoMonopolyBoardById.LogPair);
			return new DangoMonopolyBoard?(rootAsDangoMonopolyBoard);
		}

		// Token: 0x04000D3C RID: 3388
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D3D RID: 3389
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D3E RID: 3390
		private const string TABLE = "DangoMonopolyBoard";

		// Token: 0x04000D3F RID: 3391
		private const string COMMAND = "select BinData from `DangoMonopolyBoard` where BoardId=?";

		// Token: 0x04000D40 RID: 3392
		private const string KEY_PREFIX = "DangoMonopolyBoardById";

		// Token: 0x04000D41 RID: 3393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D42 RID: 3394
		private static int HandleId;
	}
}
