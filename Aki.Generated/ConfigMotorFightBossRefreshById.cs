using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000587 RID: 1415
	public class ConfigMotorFightBossRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002137 RID: 8503 RVA: 0x001153D4 File Offset: 0x001135D4
		static ConfigMotorFightBossRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBossRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightBossRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x001153F4 File Offset: 0x001135F4
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

		// Token: 0x06002139 RID: 8505 RVA: 0x00115473 File Offset: 0x00113673
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBossRefreshById.LogPair = null;
			ConfigMotorFightBossRefreshById.HandleId = 0;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00115481 File Offset: 0x00113681
		public static void Init()
		{
			ConfigMotorFightBossRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBossRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBossRefresh` where Id=?");
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0011549C File Offset: 0x0011369C
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

		// Token: 0x04002695 RID: 9877
		private const string DB = "db_motorfight.db";

		// Token: 0x04002696 RID: 9878
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002697 RID: 9879
		private const string TABLE = "MotorFightBossRefresh";

		// Token: 0x04002698 RID: 9880
		private const string COMMAND = "select BinData from `MotorFightBossRefresh` where Id=?";

		// Token: 0x04002699 RID: 9881
		private const string KEY_PREFIX = "MotorFightBossRefreshById";

		// Token: 0x0400269A RID: 9882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400269B RID: 9883
		private static int HandleId;
	}
}
