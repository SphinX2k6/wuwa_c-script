using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F9 RID: 1273
	public class ConfigLivenessTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DE1 RID: 7649 RVA: 0x00105AA8 File Offset: 0x00103CA8
		static ConfigLivenessTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigLivenessTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00105AC8 File Offset: 0x00103CC8
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

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00105B47 File Offset: 0x00103D47
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessTaskByTaskId.LogPair = null;
			ConfigLivenessTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00105B55 File Offset: 0x00103D55
		public static void Init()
		{
			ConfigLivenessTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessTaskByTaskId.HandleId, "db_daily_activity.db", "select BinData from `LivenessTask` where TaskId=?");
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00105B70 File Offset: 0x00103D70
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

		// Token: 0x040022B3 RID: 8883
		private const string DB = "db_daily_activity.db";

		// Token: 0x040022B4 RID: 8884
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x040022B5 RID: 8885
		private const string TABLE = "LivenessTask";

		// Token: 0x040022B6 RID: 8886
		private const string COMMAND = "select BinData from `LivenessTask` where TaskId=?";

		// Token: 0x040022B7 RID: 8887
		private const string KEY_PREFIX = "LivenessTaskByTaskId";

		// Token: 0x040022B8 RID: 8888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022B9 RID: 8889
		private static int HandleId;
	}
}
