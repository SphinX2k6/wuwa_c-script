using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043C RID: 1084
	public class ConfigInfrArchiveTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001971 RID: 6513 RVA: 0x000ED08F File Offset: 0x000EB28F
		static ConfigInfrArchiveTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrArchiveTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000ED0B0 File Offset: 0x000EB2B0
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrArchiveTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrArchiveTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrArchiveTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrArchiveTask` where TaskId=?")
			});
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000ED12F File Offset: 0x000EB32F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveTaskByTaskId.LogPair = null;
			ConfigInfrArchiveTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000ED13D File Offset: 0x000EB33D
		public static void Init()
		{
			ConfigInfrArchiveTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveTask` where TaskId=?");
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000ED158 File Offset: 0x000EB358
		public static InfrArchiveTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrArchiveTaskByTaskId.HandleId, ConfigInfrArchiveTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrArchiveTask?(InfrArchiveTask.GetRootAsInfrArchiveTask(configBuffer));
				}
			}
			ConfigInfrArchiveTaskByTaskId.LogPair.Clear();
			ConfigInfrArchiveTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigInfrArchiveTaskByTaskId.HandleId, 1, p0TaskId, ConfigInfrArchiveTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigInfrArchiveTaskByTaskId.HandleId, true, ConfigInfrArchiveTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrArchiveTaskByTaskId.HandleId, ConfigInfrArchiveTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrArchiveTaskByTaskId.HandleId, 0, ConfigInfrArchiveTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrArchiveTaskByTaskId.HandleId, ConfigInfrArchiveTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrArchiveTask rootAsInfrArchiveTask = InfrArchiveTask.GetRootAsInfrArchiveTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrArchiveTaskByTaskId.HandleId, ConfigInfrArchiveTaskByTaskId.LogPair);
			return new InfrArchiveTask?(rootAsInfrArchiveTask);
		}

		// Token: 0x04001D88 RID: 7560
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D89 RID: 7561
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D8A RID: 7562
		private const string TABLE = "InfrArchiveTask";

		// Token: 0x04001D8B RID: 7563
		private const string COMMAND = "select BinData from `InfrArchiveTask` where TaskId=?";

		// Token: 0x04001D8C RID: 7564
		private const string KEY_PREFIX = "InfrArchiveTaskByTaskId";

		// Token: 0x04001D8D RID: 7565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D8E RID: 7566
		private static int HandleId;
	}
}
