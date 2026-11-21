using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059A RID: 1434
	public class ConfigMotorFightActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x0011B504 File Offset: 0x00119704
		static ConfigMotorFightActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightActivityById.CreateStaticDefaultValue), new Action(ConfigMotorFightActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0011B524 File Offset: 0x00119724
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightActivity` where Id=?")
			});
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0011B5A3 File Offset: 0x001197A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightActivityById.LogPair = null;
			ConfigMotorFightActivityById.HandleId = 0;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0011B5B1 File Offset: 0x001197B1
		public static void Init()
		{
			ConfigMotorFightActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightActivityById.HandleId, "db_motorfight.db", "select BinData from `MotorFightActivity` where Id=?");
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0011B5CC File Offset: 0x001197CC
		public static MotorFightActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightActivity?(MotorFightActivity.GetRootAsMotorFightActivity(configBuffer));
				}
			}
			ConfigMotorFightActivityById.LogPair.Clear();
			ConfigMotorFightActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightActivityById.HandleId, 1, p0Id, ConfigMotorFightActivityById.LogPair) || ConfigCommon.Step(ConfigMotorFightActivityById.HandleId, true, ConfigMotorFightActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightActivityById.HandleId, 0, ConfigMotorFightActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightActivity rootAsMotorFightActivity = MotorFightActivity.GetRootAsMotorFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
			return new MotorFightActivity?(rootAsMotorFightActivity);
		}

		// Token: 0x0400271A RID: 10010
		private const string DB = "db_motorfight.db";

		// Token: 0x0400271B RID: 10011
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400271C RID: 10012
		private const string TABLE = "MotorFightActivity";

		// Token: 0x0400271D RID: 10013
		private const string COMMAND = "select BinData from `MotorFightActivity` where Id=?";

		// Token: 0x0400271E RID: 10014
		private const string KEY_PREFIX = "MotorFightActivityById";

		// Token: 0x0400271F RID: 10015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002720 RID: 10016
		private static int HandleId;
	}
}
