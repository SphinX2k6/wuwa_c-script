using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B34 RID: 2868
	public class ConfigTurntableTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600434C RID: 17228 RVA: 0x001D97EC File Offset: 0x001D79EC
		static ConfigTurntableTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigTurntableTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x001D980C File Offset: 0x001D7A0C
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

		// Token: 0x0600434E RID: 17230 RVA: 0x001D988B File Offset: 0x001D7A8B
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableTaskByTaskId.LogPair = null;
			ConfigTurntableTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x001D9899 File Offset: 0x001D7A99
		public static void Init()
		{
			ConfigTurntableTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableTaskByTaskId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableTask` where TaskId=?");
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x001D98B4 File Offset: 0x001D7AB4
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

		// Token: 0x04004E52 RID: 20050
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004E53 RID: 20051
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004E54 RID: 20052
		private const string TABLE = "TurntableTask";

		// Token: 0x04004E55 RID: 20053
		private const string COMMAND = "select BinData from `TurntableTask` where TaskId=?";

		// Token: 0x04004E56 RID: 20054
		private const string KEY_PREFIX = "TurntableTaskByTaskId";

		// Token: 0x04004E57 RID: 20055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E58 RID: 20056
		private static int HandleId;
	}
}
