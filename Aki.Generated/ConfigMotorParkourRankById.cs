using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D1 RID: 1489
	public class ConfigMotorParkourRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022F3 RID: 8947 RVA: 0x00122AF4 File Offset: 0x00120CF4
		static ConfigMotorParkourRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRankById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRankById.ResetStaticDefaultValue));
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00122B14 File Offset: 0x00120D14
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourRankById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourRankById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkourRank"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkourRank` where Id=?")
			});
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00122B93 File Offset: 0x00120D93
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRankById.LogPair = null;
			ConfigMotorParkourRankById.HandleId = 0;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00122BA1 File Offset: 0x00120DA1
		public static void Init()
		{
			ConfigMotorParkourRankById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRankById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRank` where Id=?");
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00122BBC File Offset: 0x00120DBC
		public static MotorParkourRank? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourRankById.HandleId, ConfigMotorParkourRankById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkourRank?(MotorParkourRank.GetRootAsMotorParkourRank(configBuffer));
				}
			}
			ConfigMotorParkourRankById.LogPair.Clear();
			ConfigMotorParkourRankById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorParkourRankById.HandleId, 1, p0Id, ConfigMotorParkourRankById.LogPair) || ConfigCommon.Step(ConfigMotorParkourRankById.HandleId, true, ConfigMotorParkourRankById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourRankById.HandleId, ConfigMotorParkourRankById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourRankById.HandleId, 0, ConfigMotorParkourRankById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourRankById.HandleId, ConfigMotorParkourRankById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkourRank rootAsMotorParkourRank = MotorParkourRank.GetRootAsMotorParkourRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourRankById.HandleId, ConfigMotorParkourRankById.LogPair);
			return new MotorParkourRank?(rootAsMotorParkourRank);
		}

		// Token: 0x0400289B RID: 10395
		private const string DB = "db_motorparkour.db";

		// Token: 0x0400289C RID: 10396
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x0400289D RID: 10397
		private const string TABLE = "MotorParkourRank";

		// Token: 0x0400289E RID: 10398
		private const string COMMAND = "select BinData from `MotorParkourRank` where Id=?";

		// Token: 0x0400289F RID: 10399
		private const string KEY_PREFIX = "MotorParkourRankById";

		// Token: 0x040028A0 RID: 10400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028A1 RID: 10401
		private static int HandleId;
	}
}
