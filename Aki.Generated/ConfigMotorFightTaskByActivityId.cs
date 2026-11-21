using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B4 RID: 1460
	public class ConfigMotorFightTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0011ED44 File Offset: 0x0011CF44
		static ConfigMotorFightTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0011ED64 File Offset: 0x0011CF64
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTask` where ActivityId=?")
			});
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0011EDE3 File Offset: 0x0011CFE3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskByActivityId.LogPair = null;
			ConfigMotorFightTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0011EDF1 File Offset: 0x0011CFF1
		public static void Init()
		{
			ConfigMotorFightTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTask` where ActivityId=?");
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0011EE0C File Offset: 0x0011D00C
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskByActivityId.HandleId, ConfigMotorFightTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightTask> readOnlyList = (IReadOnlyList<MotorFightTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightTaskByActivityId.LogPair.Clear();
			ConfigMotorFightTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightTaskByActivityId.HandleId, ConfigMotorFightTaskByActivityId.LogPair);
				return null;
			}
			List<MotorFightTask> list = new List<MotorFightTask>();
			while (ConfigCommon.Step(ConfigMotorFightTaskByActivityId.HandleId, false, ConfigMotorFightTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskByActivityId.HandleId, 0, ConfigMotorFightTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightTaskByActivityId.HandleId, ConfigMotorFightTaskByActivityId.LogPair);
					return null;
				}
				MotorFightTask rootAsMotorFightTask = MotorFightTask.GetRootAsMotorFightTask(new ByteBuffer(item2));
				list.Add(rootAsMotorFightTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskByActivityId.HandleId, ConfigMotorFightTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x040027D0 RID: 10192
		private const string DB = "db_motorfight.db";

		// Token: 0x040027D1 RID: 10193
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027D2 RID: 10194
		private const string TABLE = "MotorFightTask";

		// Token: 0x040027D3 RID: 10195
		private const string COMMAND = "select BinData from `MotorFightTask` where ActivityId=?";

		// Token: 0x040027D4 RID: 10196
		private const string KEY_PREFIX = "MotorFightTaskByActivityId";

		// Token: 0x040027D5 RID: 10197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027D6 RID: 10198
		private static int HandleId;
	}
}
