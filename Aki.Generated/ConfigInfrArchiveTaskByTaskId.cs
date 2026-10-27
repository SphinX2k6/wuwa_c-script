using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000426 RID: 1062
	public class ConfigInfrArchiveTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018ED RID: 6381 RVA: 0x000E693B File Offset: 0x000E4B3B
		static ConfigInfrArchiveTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrArchiveTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000E695C File Offset: 0x000E4B5C
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

		// Token: 0x060018EF RID: 6383 RVA: 0x000E69DB File Offset: 0x000E4BDB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveTaskByTaskId.LogPair = null;
			ConfigInfrArchiveTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000E69E9 File Offset: 0x000E4BE9
		public static void Init()
		{
			ConfigInfrArchiveTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveTask` where TaskId=?");
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x000E6A04 File Offset: 0x000E4C04
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

		// Token: 0x04001CEE RID: 7406
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CEF RID: 7407
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001CF0 RID: 7408
		private const string TABLE = "InfrArchiveTask";

		// Token: 0x04001CF1 RID: 7409
		private const string COMMAND = "select BinData from `InfrArchiveTask` where TaskId=?";

		// Token: 0x04001CF2 RID: 7410
		private const string KEY_PREFIX = "InfrArchiveTaskByTaskId";

		// Token: 0x04001CF3 RID: 7411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CF4 RID: 7412
		private static int HandleId;
	}
}
