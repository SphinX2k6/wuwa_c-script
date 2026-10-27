using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5F RID: 2655
	public class ConfigTurntableTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E4E RID: 15950 RVA: 0x001BA458 File Offset: 0x001B8658
		static ConfigTurntableTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigTurntableTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x001BA478 File Offset: 0x001B8678
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableTask"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableTask` where TaskId=?")
			});
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x001BA4F7 File Offset: 0x001B86F7
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableTaskByTaskId.LogPair = null;
			ConfigTurntableTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x001BA505 File Offset: 0x001B8705
		public static void Init()
		{
			ConfigTurntableTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableTaskByTaskId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableTask` where TaskId=?");
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001BA520 File Offset: 0x001B8720
		public static TurntableTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableTaskByTaskId.HandleId, ConfigTurntableTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TurntableTask?(TurntableTask.GetRootAsTurntableTask(configBuffer));
				}
			}
			ConfigTurntableTaskByTaskId.LogPair.Clear();
			ConfigTurntableTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigTurntableTaskByTaskId.HandleId, 1, p0TaskId, ConfigTurntableTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigTurntableTaskByTaskId.HandleId, true, ConfigTurntableTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTurntableTaskByTaskId.HandleId, ConfigTurntableTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableTaskByTaskId.HandleId, 0, ConfigTurntableTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTurntableTaskByTaskId.HandleId, ConfigTurntableTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TurntableTask rootAsTurntableTask = TurntableTask.GetRootAsTurntableTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTurntableTaskByTaskId.HandleId, ConfigTurntableTaskByTaskId.LogPair);
			return new TurntableTask?(rootAsTurntableTask);
		}

		// Token: 0x0400487F RID: 18559
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004880 RID: 18560
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004881 RID: 18561
		private const string TABLE = "TurntableTask";

		// Token: 0x04004882 RID: 18562
		private const string COMMAND = "select BinData from `TurntableTask` where TaskId=?";

		// Token: 0x04004883 RID: 18563
		private const string KEY_PREFIX = "TurntableTaskByTaskId";

		// Token: 0x04004884 RID: 18564
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004885 RID: 18565
		private static int HandleId;
	}
}
