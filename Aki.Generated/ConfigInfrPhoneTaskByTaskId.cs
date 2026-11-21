using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000448 RID: 1096
	public class ConfigInfrPhoneTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x000EE85B File Offset: 0x000ECA5B
		static ConfigInfrPhoneTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigInfrPhoneTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000EE87C File Offset: 0x000ECA7C
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

		// Token: 0x060019BB RID: 6587 RVA: 0x000EE8FB File Offset: 0x000ECAFB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneTaskByTaskId.LogPair = null;
			ConfigInfrPhoneTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000EE909 File Offset: 0x000ECB09
		public static void Init()
		{
			ConfigInfrPhoneTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneTaskByTaskId.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneTask` where TaskId=?");
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000EE924 File Offset: 0x000ECB24
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

		// Token: 0x04001DDC RID: 7644
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DDD RID: 7645
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001DDE RID: 7646
		private const string TABLE = "InfrPhoneTask";

		// Token: 0x04001DDF RID: 7647
		private const string COMMAND = "select BinData from `InfrPhoneTask` where TaskId=?";

		// Token: 0x04001DE0 RID: 7648
		private const string KEY_PREFIX = "InfrPhoneTaskByTaskId";

		// Token: 0x04001DE1 RID: 7649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DE2 RID: 7650
		private static int HandleId;
	}
}
