using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058A RID: 1418
	public class ConfigMotorFightBuffGateRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002149 RID: 8521 RVA: 0x00115AAC File Offset: 0x00113CAC
		static ConfigMotorFightBuffGateRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightBuffGateRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightBuffGateRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00115ACC File Offset: 0x00113CCC
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

		// Token: 0x0600214B RID: 8523 RVA: 0x00115B4B File Offset: 0x00113D4B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightBuffGateRefreshById.LogPair = null;
			ConfigMotorFightBuffGateRefreshById.HandleId = 0;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00115B59 File Offset: 0x00113D59
		public static void Init()
		{
			ConfigMotorFightBuffGateRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightBuffGateRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightBuffGateRefresh` where Id=?");
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00115B74 File Offset: 0x00113D74
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

		// Token: 0x040026AA RID: 9898
		private const string DB = "db_motorfight.db";

		// Token: 0x040026AB RID: 9899
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040026AC RID: 9900
		private const string TABLE = "MotorFightBuffGateRefresh";

		// Token: 0x040026AD RID: 9901
		private const string COMMAND = "select BinData from `MotorFightBuffGateRefresh` where Id=?";

		// Token: 0x040026AE RID: 9902
		private const string KEY_PREFIX = "MotorFightBuffGateRefreshById";

		// Token: 0x040026AF RID: 9903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026B0 RID: 9904
		private static int HandleId;
	}
}
