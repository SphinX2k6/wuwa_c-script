using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A1 RID: 1441
	public class ConfigMotorFightBuffGateRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x0011C394 File Offset: 0x0011A594
		static ConfigMotorFightBuffGateRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffGateRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffGateRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0011C3B4 File Offset: 0x0011A5B4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightBuffGateRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightBuffGateRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightBuffGateRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightBuffGateRefresh` where Id=?")
			});
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0011C433 File Offset: 0x0011A633
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffGateRefreshById.LogPair = null;
			ConfigMotorFightBuffGateRefreshById.HandleId = 0;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0011C441 File Offset: 0x0011A641
		public static void Init()
		{
			ConfigMotorFightBuffGateRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffGateRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffGateRefresh` where Id=?");
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0011C45C File Offset: 0x0011A65C
		public static MotorFightBuffGateRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightBuffGateRefreshById.HandleId, ConfigMotorFightBuffGateRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightBuffGateRefresh?(MotorFightBuffGateRefresh.GetRootAsMotorFightBuffGateRefresh(configBuffer));
				}
			}
			ConfigMotorFightBuffGateRefreshById.LogPair.Clear();
			ConfigMotorFightBuffGateRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightBuffGateRefreshById.HandleId, 1, p0Id, ConfigMotorFightBuffGateRefreshById.LogPair) || ConfigCommon.Step(ConfigMotorFightBuffGateRefreshById.HandleId, true, ConfigMotorFightBuffGateRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateRefreshById.HandleId, ConfigMotorFightBuffGateRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightBuffGateRefreshById.HandleId, 0, ConfigMotorFightBuffGateRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightBuffGateRefreshById.HandleId, ConfigMotorFightBuffGateRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightBuffGateRefresh rootAsMotorFightBuffGateRefresh = MotorFightBuffGateRefresh.GetRootAsMotorFightBuffGateRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightBuffGateRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightBuffGateRefreshById.HandleId, ConfigMotorFightBuffGateRefreshById.LogPair);
			return new MotorFightBuffGateRefresh?(rootAsMotorFightBuffGateRefresh);
		}

		// Token: 0x0400274B RID: 10059
		private const string DB = "db_motorfight.db";

		// Token: 0x0400274C RID: 10060
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400274D RID: 10061
		private const string TABLE = "MotorFightBuffGateRefresh";

		// Token: 0x0400274E RID: 10062
		private const string COMMAND = "select BinData from `MotorFightBuffGateRefresh` where Id=?";

		// Token: 0x0400274F RID: 10063
		private const string KEY_PREFIX = "MotorFightBuffGateRefreshById";

		// Token: 0x04002750 RID: 10064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002751 RID: 10065
		private static int HandleId;
	}
}
