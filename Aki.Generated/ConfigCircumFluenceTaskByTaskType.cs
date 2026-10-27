using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000171 RID: 369
	public class ConfigCircumFluenceTaskByTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x0008A61C File Offset: 0x0008881C
		static ConfigCircumFluenceTaskByTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumFluenceTaskByTaskType.CreateStaticDefaultValue), new Action(ConfigCircumFluenceTaskByTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0008A63C File Offset: 0x0008883C
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumFluenceTaskByTaskType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumFluenceTaskByTaskType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumFluenceTask"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumFluenceTask` where TaskType=?")
			});
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0008A6BB File Offset: 0x000888BB
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumFluenceTaskByTaskType.LogPair = null;
			ConfigCircumFluenceTaskByTaskType.HandleId = 0;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0008A6C9 File Offset: 0x000888C9
		public static void Init()
		{
			ConfigCircumFluenceTaskByTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumFluenceTaskByTaskType.HandleId, "db_circumfluence.db", "select BinData from `CircumFluenceTask` where TaskType=?");
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0008A6E4 File Offset: 0x000888E4
		[NullableContext(2)]
		public static IReadOnlyList<CircumFluenceTask> GetConfigList(int p0TaskType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumFluenceTaskByTaskType.HandleId, ConfigCircumFluenceTaskByTaskType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumFluenceTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				IReadOnlyList<CircumFluenceTask> readOnlyList = (IReadOnlyList<CircumFluenceTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCircumFluenceTaskByTaskType.LogPair.Clear();
			ConfigCircumFluenceTaskByTaskType.LogPair.Add(new ValueTuple<string, object>("TaskType", p0TaskType));
			if (!ConfigCommon.BindInt(ConfigCircumFluenceTaskByTaskType.HandleId, 1, p0TaskType, ConfigCircumFluenceTaskByTaskType.LogPair))
			{
				ConfigCommon.Reset(ConfigCircumFluenceTaskByTaskType.HandleId, ConfigCircumFluenceTaskByTaskType.LogPair);
				return null;
			}
			List<CircumFluenceTask> list = new List<CircumFluenceTask>();
			while (ConfigCommon.Step(ConfigCircumFluenceTaskByTaskType.HandleId, false, ConfigCircumFluenceTaskByTaskType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumFluenceTaskByTaskType.HandleId, 0, ConfigCircumFluenceTaskByTaskType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCircumFluenceTaskByTaskType.HandleId, ConfigCircumFluenceTaskByTaskType.LogPair);
					return null;
				}
				CircumFluenceTask rootAsCircumFluenceTask = CircumFluenceTask.GetRootAsCircumFluenceTask(new ByteBuffer(item2));
				list.Add(rootAsCircumFluenceTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumFluenceTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCircumFluenceTaskByTaskType.HandleId, ConfigCircumFluenceTaskByTaskType.LogPair);
			return list;
		}

		// Token: 0x040009FB RID: 2555
		private const string DB = "db_circumfluence.db";

		// Token: 0x040009FC RID: 2556
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040009FD RID: 2557
		private const string TABLE = "CircumFluenceTask";

		// Token: 0x040009FE RID: 2558
		private const string COMMAND = "select BinData from `CircumFluenceTask` where TaskType=?";

		// Token: 0x040009FF RID: 2559
		private const string KEY_PREFIX = "CircumFluenceTaskByTaskType";

		// Token: 0x04000A00 RID: 2560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A01 RID: 2561
		private static int HandleId;
	}
}
