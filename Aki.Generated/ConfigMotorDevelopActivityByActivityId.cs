using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000596 RID: 1430
	public class ConfigMotorDevelopActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x0011ABE4 File Offset: 0x00118DE4
		static ConfigMotorDevelopActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDevelopActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorDevelopActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0011AC04 File Offset: 0x00118E04
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

		// Token: 0x06002193 RID: 8595 RVA: 0x0011AC83 File Offset: 0x00118E83
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDevelopActivityByActivityId.LogPair = null;
			ConfigMotorDevelopActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x0011AC91 File Offset: 0x00118E91
		public static void Init()
		{
			ConfigMotorDevelopActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDevelopActivityByActivityId.HandleId, "db_motordeveloptask.db", "select BinData from `MotorDevelopActivity` where ActivityId=?");
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0011ACAC File Offset: 0x00118EAC
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

		// Token: 0x040026FE RID: 9982
		private const string DB = "db_motordeveloptask.db";

		// Token: 0x040026FF RID: 9983
		private const string FILE = "m.摩托养成活动.xlsx";

		// Token: 0x04002700 RID: 9984
		private const string TABLE = "MotorDevelopActivity";

		// Token: 0x04002701 RID: 9985
		private const string COMMAND = "select BinData from `MotorDevelopActivity` where ActivityId=?";

		// Token: 0x04002702 RID: 9986
		private const string KEY_PREFIX = "MotorDevelopActivityByActivityId";

		// Token: 0x04002703 RID: 9987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002704 RID: 9988
		private static int HandleId;
	}
}
