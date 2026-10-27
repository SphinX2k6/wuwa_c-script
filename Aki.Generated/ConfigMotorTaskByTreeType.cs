using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C9 RID: 1481
	public class ConfigMotorTaskByTreeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022C3 RID: 8899 RVA: 0x0011E174 File Offset: 0x0011C374
		static ConfigMotorTaskByTreeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTaskByTreeType.CreateStaticDefaultValue), new Action(ConfigMotorTaskByTreeType.ResetStaticDefaultValue));
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0011E194 File Offset: 0x0011C394
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

		// Token: 0x060022C5 RID: 8901 RVA: 0x0011E213 File Offset: 0x0011C413
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTaskByTreeType.LogPair = null;
			ConfigMotorTaskByTreeType.HandleId = 0;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0011E221 File Offset: 0x0011C421
		public static void Init()
		{
			ConfigMotorTaskByTreeType.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTaskByTreeType.HandleId, "db_motor.db", "select BinData from `MotorTask` where TreeType=?");
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0011E23C File Offset: 0x0011C43C
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

		// Token: 0x04002863 RID: 10339
		private const string DB = "db_motor.db";

		// Token: 0x04002864 RID: 10340
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002865 RID: 10341
		private const string TABLE = "MotorTask";

		// Token: 0x04002866 RID: 10342
		private const string COMMAND = "select BinData from `MotorTask` where TreeType=?";

		// Token: 0x04002867 RID: 10343
		private const string KEY_PREFIX = "MotorTaskByTreeType";

		// Token: 0x04002868 RID: 10344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002869 RID: 10345
		private static int HandleId;
	}
}
