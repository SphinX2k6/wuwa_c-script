using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000544 RID: 1348
	public class ConfigMatchThreeEliminateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x0010FA00 File Offset: 0x0010DC00
		static ConfigMatchThreeEliminateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeEliminateById.CreateStaticDefaultValue), new Action(ConfigMatchThreeEliminateById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0010FA20 File Offset: 0x0010DC20
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

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0010FA9F File Offset: 0x0010DC9F
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeEliminateById.LogPair = null;
			ConfigMatchThreeEliminateById.HandleId = 0;
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0010FAAD File Offset: 0x0010DCAD
		public static void Init()
		{
			ConfigMatchThreeEliminateById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeEliminateById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeEliminate` where Id=?");
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0010FAC8 File Offset: 0x0010DCC8
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

		// Token: 0x040024C0 RID: 9408
		private const string DB = "db_matchthree.db";

		// Token: 0x040024C1 RID: 9409
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024C2 RID: 9410
		private const string TABLE = "MatchThreeEliminate";

		// Token: 0x040024C3 RID: 9411
		private const string COMMAND = "select BinData from `MatchThreeEliminate` where Id=?";

		// Token: 0x040024C4 RID: 9412
		private const string KEY_PREFIX = "MatchThreeEliminateById";

		// Token: 0x040024C5 RID: 9413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024C6 RID: 9414
		private static int HandleId;
	}
}
