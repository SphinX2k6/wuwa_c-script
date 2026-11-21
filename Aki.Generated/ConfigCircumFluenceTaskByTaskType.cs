using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000181 RID: 385
	public class ConfigCircumFluenceTaskByTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00090178 File Offset: 0x0008E378
		static ConfigCircumFluenceTaskByTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumFluenceTaskByTaskType.CreateStaticDefaultValue), new Action(ConfigCircumFluenceTaskByTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00090198 File Offset: 0x0008E398
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

		// Token: 0x06000909 RID: 2313 RVA: 0x00090217 File Offset: 0x0008E417
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumFluenceTaskByTaskType.LogPair = null;
			ConfigCircumFluenceTaskByTaskType.HandleId = 0;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00090225 File Offset: 0x0008E425
		public static void Init()
		{
			ConfigCircumFluenceTaskByTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumFluenceTaskByTaskType.HandleId, "db_circumfluence.db", "select BinData from `CircumFluenceTask` where TaskType=?");
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00090240 File Offset: 0x0008E440
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

		// Token: 0x04000A6B RID: 2667
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A6C RID: 2668
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A6D RID: 2669
		private const string TABLE = "CircumFluenceTask";

		// Token: 0x04000A6E RID: 2670
		private const string COMMAND = "select BinData from `CircumFluenceTask` where TaskType=?";

		// Token: 0x04000A6F RID: 2671
		private const string KEY_PREFIX = "CircumFluenceTaskByTaskType";

		// Token: 0x04000A70 RID: 2672
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A71 RID: 2673
		private static int HandleId;
	}
}
