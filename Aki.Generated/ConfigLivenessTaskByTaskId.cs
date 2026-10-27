using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E3 RID: 1251
	public class ConfigLivenessTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x000FF354 File Offset: 0x000FD554
		static ConfigLivenessTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigLivenessTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000FF374 File Offset: 0x000FD574
		public static void CreateStaticDefaultValue()
		{
			ConfigLivenessTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLivenessTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daily_activity.db"),
				new ValueTuple<string, object>("文件", "h.活跃度.xlsx"),
				new ValueTuple<string, object>("表名", "LivenessTask"),
				new ValueTuple<string, object>("语句", "select BinData from `LivenessTask` where TaskId=?")
			});
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000FF3F3 File Offset: 0x000FD5F3
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessTaskByTaskId.LogPair = null;
			ConfigLivenessTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000FF401 File Offset: 0x000FD601
		public static void Init()
		{
			ConfigLivenessTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessTaskByTaskId.HandleId, "db_daily_activity.db", "select BinData from `LivenessTask` where TaskId=?");
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000FF41C File Offset: 0x000FD61C
		public static LivenessTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLivenessTaskByTaskId.HandleId, ConfigLivenessTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LivenessTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LivenessTask?(LivenessTask.GetRootAsLivenessTask(configBuffer));
				}
			}
			ConfigLivenessTaskByTaskId.LogPair.Clear();
			ConfigLivenessTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigLivenessTaskByTaskId.HandleId, 1, p0TaskId, ConfigLivenessTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigLivenessTaskByTaskId.HandleId, true, ConfigLivenessTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLivenessTaskByTaskId.HandleId, ConfigLivenessTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLivenessTaskByTaskId.HandleId, 0, ConfigLivenessTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLivenessTaskByTaskId.HandleId, ConfigLivenessTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LivenessTask rootAsLivenessTask = LivenessTask.GetRootAsLivenessTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LivenessTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLivenessTaskByTaskId.HandleId, ConfigLivenessTaskByTaskId.LogPair);
			return new LivenessTask?(rootAsLivenessTask);
		}

		// Token: 0x04002219 RID: 8729
		private const string DB = "db_daily_activity.db";

		// Token: 0x0400221A RID: 8730
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x0400221B RID: 8731
		private const string TABLE = "LivenessTask";

		// Token: 0x0400221C RID: 8732
		private const string COMMAND = "select BinData from `LivenessTask` where TaskId=?";

		// Token: 0x0400221D RID: 8733
		private const string KEY_PREFIX = "LivenessTaskByTaskId";

		// Token: 0x0400221E RID: 8734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400221F RID: 8735
		private static int HandleId;
	}
}
