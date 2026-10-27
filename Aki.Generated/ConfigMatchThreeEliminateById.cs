using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052E RID: 1326
	public class ConfigMatchThreeEliminateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x001092AC File Offset: 0x001074AC
		static ConfigMatchThreeEliminateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeEliminateById.CreateStaticDefaultValue), new Action(ConfigMatchThreeEliminateById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x001092CC File Offset: 0x001074CC
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeEliminateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeEliminateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeEliminate"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeEliminate` where Id=?")
			});
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0010934B File Offset: 0x0010754B
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeEliminateById.LogPair = null;
			ConfigMatchThreeEliminateById.HandleId = 0;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00109359 File Offset: 0x00107559
		public static void Init()
		{
			ConfigMatchThreeEliminateById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeEliminateById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeEliminate` where Id=?");
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00109374 File Offset: 0x00107574
		public static MatchThreeEliminate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeEliminateById.HandleId, ConfigMatchThreeEliminateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEliminateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeEliminate?(MatchThreeEliminate.GetRootAsMatchThreeEliminate(configBuffer));
				}
			}
			ConfigMatchThreeEliminateById.LogPair.Clear();
			ConfigMatchThreeEliminateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeEliminateById.HandleId, 1, p0Id, ConfigMatchThreeEliminateById.LogPair) || ConfigCommon.Step(ConfigMatchThreeEliminateById.HandleId, true, ConfigMatchThreeEliminateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeEliminateById.HandleId, ConfigMatchThreeEliminateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeEliminateById.HandleId, 0, ConfigMatchThreeEliminateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeEliminateById.HandleId, ConfigMatchThreeEliminateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeEliminate rootAsMatchThreeEliminate = MatchThreeEliminate.GetRootAsMatchThreeEliminate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEliminateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeEliminateById.HandleId, ConfigMatchThreeEliminateById.LogPair);
			return new MatchThreeEliminate?(rootAsMatchThreeEliminate);
		}

		// Token: 0x04002426 RID: 9254
		private const string DB = "db_matchthree.db";

		// Token: 0x04002427 RID: 9255
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002428 RID: 9256
		private const string TABLE = "MatchThreeEliminate";

		// Token: 0x04002429 RID: 9257
		private const string COMMAND = "select BinData from `MatchThreeEliminate` where Id=?";

		// Token: 0x0400242A RID: 9258
		private const string KEY_PREFIX = "MatchThreeEliminateById";

		// Token: 0x0400242B RID: 9259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400242C RID: 9260
		private static int HandleId;
	}
}
