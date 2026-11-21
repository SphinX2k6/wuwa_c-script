using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000437 RID: 1079
	public class ConfigInfrActivityTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x000EC68F File Offset: 0x000EA88F
		static ConfigInfrActivityTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrActivityTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrActivityTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000EC6B0 File Offset: 0x000EA8B0
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrActivityTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrActivityTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrActivityTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrActivityTask` where TaskId=?")
			});
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000EC72F File Offset: 0x000EA92F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrActivityTaskByTaskId.LogPair = null;
			ConfigInfrActivityTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000EC73D File Offset: 0x000EA93D
		public static void Init()
		{
			ConfigInfrActivityTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrActivityTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrActivityTask` where TaskId=?");
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000EC758 File Offset: 0x000EA958
		public static InfrActivityTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrActivityTaskByTaskId.HandleId, ConfigInfrActivityTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrActivityTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrActivityTask?(InfrActivityTask.GetRootAsInfrActivityTask(configBuffer));
				}
			}
			ConfigInfrActivityTaskByTaskId.LogPair.Clear();
			ConfigInfrActivityTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigInfrActivityTaskByTaskId.HandleId, 1, p0TaskId, ConfigInfrActivityTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigInfrActivityTaskByTaskId.HandleId, true, ConfigInfrActivityTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrActivityTaskByTaskId.HandleId, ConfigInfrActivityTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrActivityTaskByTaskId.HandleId, 0, ConfigInfrActivityTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrActivityTaskByTaskId.HandleId, ConfigInfrActivityTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrActivityTask rootAsInfrActivityTask = InfrActivityTask.GetRootAsInfrActivityTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrActivityTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrActivityTaskByTaskId.HandleId, ConfigInfrActivityTaskByTaskId.LogPair);
			return new InfrActivityTask?(rootAsInfrActivityTask);
		}

		// Token: 0x04001D65 RID: 7525
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D66 RID: 7526
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D67 RID: 7527
		private const string TABLE = "InfrActivityTask";

		// Token: 0x04001D68 RID: 7528
		private const string COMMAND = "select BinData from `InfrActivityTask` where TaskId=?";

		// Token: 0x04001D69 RID: 7529
		private const string KEY_PREFIX = "InfrActivityTaskByTaskId";

		// Token: 0x04001D6A RID: 7530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D6B RID: 7531
		private static int HandleId;
	}
}
