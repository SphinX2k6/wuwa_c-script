using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BA RID: 1466
	public class ConfigMotorParkourRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002269 RID: 8809 RVA: 0x0011C20C File Offset: 0x0011A40C
		static ConfigMotorParkourRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRankById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRankById.ResetStaticDefaultValue));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0011C22C File Offset: 0x0011A42C
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

		// Token: 0x0600226B RID: 8811 RVA: 0x0011C2AB File Offset: 0x0011A4AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRankById.LogPair = null;
			ConfigMotorParkourRankById.HandleId = 0;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0011C2B9 File Offset: 0x0011A4B9
		public static void Init()
		{
			ConfigMotorParkourRankById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRankById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourRank` where Id=?");
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0011C2D4 File Offset: 0x0011A4D4
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

		// Token: 0x040027FA RID: 10234
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027FB RID: 10235
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027FC RID: 10236
		private const string TABLE = "MotorParkourRank";

		// Token: 0x040027FD RID: 10237
		private const string COMMAND = "select BinData from `MotorParkourRank` where Id=?";

		// Token: 0x040027FE RID: 10238
		private const string KEY_PREFIX = "MotorParkourRankById";

		// Token: 0x040027FF RID: 10239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002800 RID: 10240
		private static int HandleId;
	}
}
