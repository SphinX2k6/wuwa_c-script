using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000597 RID: 1431
	public class ConfigMotorDevelopTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002197 RID: 8599 RVA: 0x0011AE2C File Offset: 0x0011902C
		static ConfigMotorDevelopTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDevelopTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigMotorDevelopTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0011AE4C File Offset: 0x0011904C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDevelopTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDevelopTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordeveloptask.db"),
				new ValueTuple<string, object>("文件", "m.摩托养成活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDevelopTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDevelopTask` where TaskId=?")
			});
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0011AECB File Offset: 0x001190CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDevelopTaskByTaskId.LogPair = null;
			ConfigMotorDevelopTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0011AED9 File Offset: 0x001190D9
		public static void Init()
		{
			ConfigMotorDevelopTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDevelopTaskByTaskId.HandleId, "db_motordeveloptask.db", "select BinData from `MotorDevelopTask` where TaskId=?");
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0011AEF4 File Offset: 0x001190F4
		public static MotorDevelopTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDevelopTaskByTaskId.HandleId, ConfigMotorDevelopTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDevelopTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDevelopTask?(MotorDevelopTask.GetRootAsMotorDevelopTask(configBuffer));
				}
			}
			ConfigMotorDevelopTaskByTaskId.LogPair.Clear();
			ConfigMotorDevelopTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigMotorDevelopTaskByTaskId.HandleId, 1, p0TaskId, ConfigMotorDevelopTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigMotorDevelopTaskByTaskId.HandleId, true, ConfigMotorDevelopTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDevelopTaskByTaskId.HandleId, ConfigMotorDevelopTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDevelopTaskByTaskId.HandleId, 0, ConfigMotorDevelopTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDevelopTaskByTaskId.HandleId, ConfigMotorDevelopTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDevelopTask rootAsMotorDevelopTask = MotorDevelopTask.GetRootAsMotorDevelopTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDevelopTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDevelopTaskByTaskId.HandleId, ConfigMotorDevelopTaskByTaskId.LogPair);
			return new MotorDevelopTask?(rootAsMotorDevelopTask);
		}

		// Token: 0x04002705 RID: 9989
		private const string DB = "db_motordeveloptask.db";

		// Token: 0x04002706 RID: 9990
		private const string FILE = "m.摩托养成活动.xlsx";

		// Token: 0x04002707 RID: 9991
		private const string TABLE = "MotorDevelopTask";

		// Token: 0x04002708 RID: 9992
		private const string COMMAND = "select BinData from `MotorDevelopTask` where TaskId=?";

		// Token: 0x04002709 RID: 9993
		private const string KEY_PREFIX = "MotorDevelopTaskByTaskId";

		// Token: 0x0400270A RID: 9994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400270B RID: 9995
		private static int HandleId;
	}
}
