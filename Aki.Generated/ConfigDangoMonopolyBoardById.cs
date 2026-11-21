using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FA RID: 506
	public class ConfigDangoMonopolyBoardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x000A04EB File Offset: 0x0009E6EB
		static ConfigDangoMonopolyBoardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyBoardById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyBoardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000A050C File Offset: 0x0009E70C
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

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000A058B File Offset: 0x0009E78B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyBoardById.LogPair = null;
			ConfigDangoMonopolyBoardById.HandleId = 0;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000A0599 File Offset: 0x0009E799
		public static void Init()
		{
			ConfigDangoMonopolyBoardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyBoardById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyBoard` where BoardId=?");
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000A05B4 File Offset: 0x0009E7B4
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

		// Token: 0x04000DBA RID: 3514
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DBB RID: 3515
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DBC RID: 3516
		private const string TABLE = "DangoMonopolyBoard";

		// Token: 0x04000DBD RID: 3517
		private const string COMMAND = "select BinData from `DangoMonopolyBoard` where BoardId=?";

		// Token: 0x04000DBE RID: 3518
		private const string KEY_PREFIX = "DangoMonopolyBoardById";

		// Token: 0x04000DBF RID: 3519
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DC0 RID: 3520
		private static int HandleId;
	}
}
