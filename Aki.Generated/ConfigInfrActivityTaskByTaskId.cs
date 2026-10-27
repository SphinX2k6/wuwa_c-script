using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000421 RID: 1057
	public class ConfigInfrActivityTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x000E5F3B File Offset: 0x000E413B
		static ConfigInfrActivityTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrActivityTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrActivityTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000E5F5C File Offset: 0x000E415C
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

		// Token: 0x060018D1 RID: 6353 RVA: 0x000E5FDB File Offset: 0x000E41DB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrActivityTaskByTaskId.LogPair = null;
			ConfigInfrActivityTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x000E5FE9 File Offset: 0x000E41E9
		public static void Init()
		{
			ConfigInfrActivityTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrActivityTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrActivityTask` where TaskId=?");
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000E6004 File Offset: 0x000E4204
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

		// Token: 0x04001CCB RID: 7371
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CCC RID: 7372
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001CCD RID: 7373
		private const string TABLE = "InfrActivityTask";

		// Token: 0x04001CCE RID: 7374
		private const string COMMAND = "select BinData from `InfrActivityTask` where TaskId=?";

		// Token: 0x04001CCF RID: 7375
		private const string KEY_PREFIX = "InfrActivityTaskByTaskId";

		// Token: 0x04001CD0 RID: 7376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CD1 RID: 7377
		private static int HandleId;
	}
}
