using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000580 RID: 1408
	public class ConfigMotorDevelopTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x00114544 File Offset: 0x00112744
		static ConfigMotorDevelopTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDevelopTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigMotorDevelopTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00114564 File Offset: 0x00112764
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

		// Token: 0x0600210F RID: 8463 RVA: 0x001145E3 File Offset: 0x001127E3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDevelopTaskByTaskId.LogPair = null;
			ConfigMotorDevelopTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x001145F1 File Offset: 0x001127F1
		public static void Init()
		{
			ConfigMotorDevelopTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDevelopTaskByTaskId.HandleId, "db_motordeveloptask.db", "select BinData from `MotorDevelopTask` where TaskId=?");
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0011460C File Offset: 0x0011280C
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

		// Token: 0x04002664 RID: 9828
		private const string DB = "db_motordeveloptask.db";

		// Token: 0x04002665 RID: 9829
		private const string FILE = "m.摩托养成活动.xlsx";

		// Token: 0x04002666 RID: 9830
		private const string TABLE = "MotorDevelopTask";

		// Token: 0x04002667 RID: 9831
		private const string COMMAND = "select BinData from `MotorDevelopTask` where TaskId=?";

		// Token: 0x04002668 RID: 9832
		private const string KEY_PREFIX = "MotorDevelopTaskByTaskId";

		// Token: 0x04002669 RID: 9833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400266A RID: 9834
		private static int HandleId;
	}
}
