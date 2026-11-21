using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E1 RID: 1505
	public class ConfigMotorTaskByTreeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x00124BF0 File Offset: 0x00122DF0
		static ConfigMotorTaskByTreeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTaskByTreeType.CreateStaticDefaultValue), new Action(ConfigMotorTaskByTreeType.ResetStaticDefaultValue));
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00124C10 File Offset: 0x00122E10
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTaskByTreeType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTaskByTreeType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTask` where TreeType=?")
			});
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00124C8F File Offset: 0x00122E8F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTaskByTreeType.LogPair = null;
			ConfigMotorTaskByTreeType.HandleId = 0;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00124C9D File Offset: 0x00122E9D
		public static void Init()
		{
			ConfigMotorTaskByTreeType.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTaskByTreeType.HandleId, "db_motor.db", "select BinData from `MotorTask` where TreeType=?");
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00124CB8 File Offset: 0x00122EB8
		[NullableContext(2)]
		public static IReadOnlyList<MotorTask> GetConfigList(int p0TreeType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTaskByTreeType.HandleId, ConfigMotorTaskByTreeType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTaskByTreeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TreeType);
				IReadOnlyList<MotorTask> readOnlyList = (IReadOnlyList<MotorTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorTaskByTreeType.LogPair.Clear();
			ConfigMotorTaskByTreeType.LogPair.Add(new ValueTuple<string, object>("TreeType", p0TreeType));
			if (!ConfigCommon.BindInt(ConfigMotorTaskByTreeType.HandleId, 1, p0TreeType, ConfigMotorTaskByTreeType.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorTaskByTreeType.HandleId, ConfigMotorTaskByTreeType.LogPair);
				return null;
			}
			List<MotorTask> list = new List<MotorTask>();
			while (ConfigCommon.Step(ConfigMotorTaskByTreeType.HandleId, false, ConfigMotorTaskByTreeType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTaskByTreeType.HandleId, 0, ConfigMotorTaskByTreeType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorTaskByTreeType.HandleId, ConfigMotorTaskByTreeType.LogPair);
					return null;
				}
				MotorTask rootAsMotorTask = MotorTask.GetRootAsMotorTask(new ByteBuffer(item2));
				list.Add(rootAsMotorTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTaskByTreeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TreeType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorTaskByTreeType.HandleId, ConfigMotorTaskByTreeType.LogPair);
			return list;
		}

		// Token: 0x0400290B RID: 10507
		private const string DB = "db_motor.db";

		// Token: 0x0400290C RID: 10508
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400290D RID: 10509
		private const string TABLE = "MotorTask";

		// Token: 0x0400290E RID: 10510
		private const string COMMAND = "select BinData from `MotorTask` where TreeType=?";

		// Token: 0x0400290F RID: 10511
		private const string KEY_PREFIX = "MotorTaskByTreeType";

		// Token: 0x04002910 RID: 10512
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002911 RID: 10513
		private static int HandleId;
	}
}
