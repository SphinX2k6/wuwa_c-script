using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059E RID: 1438
	public class ConfigMotorFightBossRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021C1 RID: 8641 RVA: 0x0011BCBC File Offset: 0x00119EBC
		static ConfigMotorFightBossRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBossRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightBossRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0011BCDC File Offset: 0x00119EDC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightBossRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightBossRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightBossRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightBossRefresh` where Id=?")
			});
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0011BD5B File Offset: 0x00119F5B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBossRefreshById.LogPair = null;
			ConfigMotorFightBossRefreshById.HandleId = 0;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0011BD69 File Offset: 0x00119F69
		public static void Init()
		{
			ConfigMotorFightBossRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBossRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBossRefresh` where Id=?");
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0011BD84 File Offset: 0x00119F84
		public static MotorFightBossRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightBossRefreshById.HandleId, ConfigMotorFightBossRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBossRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightBossRefresh?(MotorFightBossRefresh.GetRootAsMotorFightBossRefresh(configBuffer));
				}
			}
			ConfigMotorFightBossRefreshById.LogPair.Clear();
			ConfigMotorFightBossRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightBossRefreshById.HandleId, 1, p0Id, ConfigMotorFightBossRefreshById.LogPair) || ConfigCommon.Step(ConfigMotorFightBossRefreshById.HandleId, true, ConfigMotorFightBossRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightBossRefreshById.HandleId, ConfigMotorFightBossRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightBossRefreshById.HandleId, 0, ConfigMotorFightBossRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightBossRefreshById.HandleId, ConfigMotorFightBossRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightBossRefresh rootAsMotorFightBossRefresh = MotorFightBossRefresh.GetRootAsMotorFightBossRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBossRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightBossRefreshById.HandleId, ConfigMotorFightBossRefreshById.LogPair);
			return new MotorFightBossRefresh?(rootAsMotorFightBossRefresh);
		}

		// Token: 0x04002736 RID: 10038
		private const string DB = "db_motorfight.db";

		// Token: 0x04002737 RID: 10039
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002738 RID: 10040
		private const string TABLE = "MotorFightBossRefresh";

		// Token: 0x04002739 RID: 10041
		private const string COMMAND = "select BinData from `MotorFightBossRefresh` where Id=?";

		// Token: 0x0400273A RID: 10042
		private const string KEY_PREFIX = "MotorFightBossRefreshById";

		// Token: 0x0400273B RID: 10043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400273C RID: 10044
		private static int HandleId;
	}
}
