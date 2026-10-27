using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059D RID: 1437
	public class ConfigMotorFightTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021BB RID: 8635 RVA: 0x0011845C File Offset: 0x0011665C
		static ConfigMotorFightTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0011847C File Offset: 0x0011667C
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

		// Token: 0x060021BD RID: 8637 RVA: 0x001184FB File Offset: 0x001166FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskByActivityId.LogPair = null;
			ConfigMotorFightTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00118509 File Offset: 0x00116709
		public static void Init()
		{
			ConfigMotorFightTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTask` where ActivityId=?");
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00118524 File Offset: 0x00116724
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

		// Token: 0x0400272F RID: 10031
		private const string DB = "db_motorfight.db";

		// Token: 0x04002730 RID: 10032
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002731 RID: 10033
		private const string TABLE = "MotorFightTask";

		// Token: 0x04002732 RID: 10034
		private const string COMMAND = "select BinData from `MotorFightTask` where ActivityId=?";

		// Token: 0x04002733 RID: 10035
		private const string KEY_PREFIX = "MotorFightTaskByActivityId";

		// Token: 0x04002734 RID: 10036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002735 RID: 10037
		private static int HandleId;
	}
}
