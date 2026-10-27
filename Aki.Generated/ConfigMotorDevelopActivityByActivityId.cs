using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057F RID: 1407
	public class ConfigMotorDevelopActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x001142FC File Offset: 0x001124FC
		static ConfigMotorDevelopActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDevelopActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorDevelopActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0011431C File Offset: 0x0011251C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDevelopActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDevelopActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordeveloptask.db"),
				new ValueTuple<string, object>("文件", "m.摩托养成活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDevelopActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDevelopActivity` where ActivityId=?")
			});
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0011439B File Offset: 0x0011259B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDevelopActivityByActivityId.LogPair = null;
			ConfigMotorDevelopActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x001143A9 File Offset: 0x001125A9
		public static void Init()
		{
			ConfigMotorDevelopActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDevelopActivityByActivityId.HandleId, "db_motordeveloptask.db", "select BinData from `MotorDevelopActivity` where ActivityId=?");
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x001143C4 File Offset: 0x001125C4
		public static MotorDevelopActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDevelopActivityByActivityId.HandleId, ConfigMotorDevelopActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDevelopActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDevelopActivity?(MotorDevelopActivity.GetRootAsMotorDevelopActivity(configBuffer));
				}
			}
			ConfigMotorDevelopActivityByActivityId.LogPair.Clear();
			ConfigMotorDevelopActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorDevelopActivityByActivityId.HandleId, 1, p0ActivityId, ConfigMotorDevelopActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigMotorDevelopActivityByActivityId.HandleId, true, ConfigMotorDevelopActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDevelopActivityByActivityId.HandleId, ConfigMotorDevelopActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDevelopActivityByActivityId.HandleId, 0, ConfigMotorDevelopActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDevelopActivityByActivityId.HandleId, ConfigMotorDevelopActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDevelopActivity rootAsMotorDevelopActivity = MotorDevelopActivity.GetRootAsMotorDevelopActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDevelopActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDevelopActivityByActivityId.HandleId, ConfigMotorDevelopActivityByActivityId.LogPair);
			return new MotorDevelopActivity?(rootAsMotorDevelopActivity);
		}

		// Token: 0x0400265D RID: 9821
		private const string DB = "db_motordeveloptask.db";

		// Token: 0x0400265E RID: 9822
		private const string FILE = "m.摩托养成活动.xlsx";

		// Token: 0x0400265F RID: 9823
		private const string TABLE = "MotorDevelopActivity";

		// Token: 0x04002660 RID: 9824
		private const string COMMAND = "select BinData from `MotorDevelopActivity` where ActivityId=?";

		// Token: 0x04002661 RID: 9825
		private const string KEY_PREFIX = "MotorDevelopActivityByActivityId";

		// Token: 0x04002662 RID: 9826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002663 RID: 9827
		private static int HandleId;
	}
}
