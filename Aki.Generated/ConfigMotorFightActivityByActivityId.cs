using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000599 RID: 1433
	public class ConfigMotorFightActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x0011B2BC File Offset: 0x001194BC
		static ConfigMotorFightActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0011B2DC File Offset: 0x001194DC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightActivity` where ActivityId=?")
			});
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0011B35B File Offset: 0x0011955B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightActivityByActivityId.LogPair = null;
			ConfigMotorFightActivityByActivityId.HandleId = 0;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0011B369 File Offset: 0x00119569
		public static void Init()
		{
			ConfigMotorFightActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightActivityByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightActivity` where ActivityId=?");
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0011B384 File Offset: 0x00119584
		public static MotorFightActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightActivity?(MotorFightActivity.GetRootAsMotorFightActivity(configBuffer));
				}
			}
			ConfigMotorFightActivityByActivityId.LogPair.Clear();
			ConfigMotorFightActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightActivityByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigMotorFightActivityByActivityId.HandleId, true, ConfigMotorFightActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightActivityByActivityId.HandleId, 0, ConfigMotorFightActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightActivity rootAsMotorFightActivity = MotorFightActivity.GetRootAsMotorFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
			return new MotorFightActivity?(rootAsMotorFightActivity);
		}

		// Token: 0x04002713 RID: 10003
		private const string DB = "db_motorfight.db";

		// Token: 0x04002714 RID: 10004
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002715 RID: 10005
		private const string TABLE = "MotorFightActivity";

		// Token: 0x04002716 RID: 10006
		private const string COMMAND = "select BinData from `MotorFightActivity` where ActivityId=?";

		// Token: 0x04002717 RID: 10007
		private const string KEY_PREFIX = "MotorFightActivityByActivityId";

		// Token: 0x04002718 RID: 10008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002719 RID: 10009
		private static int HandleId;
	}
}
