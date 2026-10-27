using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000432 RID: 1074
	public class ConfigInfrPhoneTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x000E8107 File Offset: 0x000E6307
		static ConfigInfrPhoneTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrPhoneTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000E8128 File Offset: 0x000E6328
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPhoneTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPhoneTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPhoneTask"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPhoneTask` where TaskId=?")
			});
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000E81A7 File Offset: 0x000E63A7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneTaskByTaskId.LogPair = null;
			ConfigInfrPhoneTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x000E81B5 File Offset: 0x000E63B5
		public static void Init()
		{
			ConfigInfrPhoneTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneTask` where TaskId=?");
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000E81D0 File Offset: 0x000E63D0
		public static InfrPhoneTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPhoneTaskByTaskId.HandleId, ConfigInfrPhoneTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPhoneTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrPhoneTask?(InfrPhoneTask.GetRootAsInfrPhoneTask(configBuffer));
				}
			}
			ConfigInfrPhoneTaskByTaskId.LogPair.Clear();
			ConfigInfrPhoneTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigInfrPhoneTaskByTaskId.HandleId, 1, p0TaskId, ConfigInfrPhoneTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigInfrPhoneTaskByTaskId.HandleId, true, ConfigInfrPhoneTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrPhoneTaskByTaskId.HandleId, ConfigInfrPhoneTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPhoneTaskByTaskId.HandleId, 0, ConfigInfrPhoneTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrPhoneTaskByTaskId.HandleId, ConfigInfrPhoneTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrPhoneTask rootAsInfrPhoneTask = InfrPhoneTask.GetRootAsInfrPhoneTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPhoneTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrPhoneTaskByTaskId.HandleId, ConfigInfrPhoneTaskByTaskId.LogPair);
			return new InfrPhoneTask?(rootAsInfrPhoneTask);
		}

		// Token: 0x04001D42 RID: 7490
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D43 RID: 7491
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D44 RID: 7492
		private const string TABLE = "InfrPhoneTask";

		// Token: 0x04001D45 RID: 7493
		private const string COMMAND = "select BinData from `InfrPhoneTask` where TaskId=?";

		// Token: 0x04001D46 RID: 7494
		private const string KEY_PREFIX = "InfrPhoneTaskByTaskId";

		// Token: 0x04001D47 RID: 7495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D48 RID: 7496
		private static int HandleId;
	}
}
