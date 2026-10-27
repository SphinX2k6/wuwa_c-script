using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E4 RID: 1508
	public class ConfigNewbieCarnivalTaskByTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002367 RID: 9063 RVA: 0x00121BC4 File Offset: 0x0011FDC4
		static ConfigNewbieCarnivalTaskByTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskByTaskType.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskByTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00121BE4 File Offset: 0x0011FDE4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalTaskByTaskType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalTask` where TaskType=?")
			});
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00121C63 File Offset: 0x0011FE63
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskType.LogPair = null;
			ConfigNewbieCarnivalTaskByTaskType.HandleId = 0;
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00121C71 File Offset: 0x0011FE71
		public static void Init()
		{
			ConfigNewbieCarnivalTaskByTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskByTaskType.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTask` where TaskType=?");
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00121C8C File Offset: 0x0011FE8C
		[NullableContext(2)]
		public static IReadOnlyList<NewbieCarnivalTask> GetConfigList(int p0TaskType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				IReadOnlyList<NewbieCarnivalTask> readOnlyList = (IReadOnlyList<NewbieCarnivalTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieCarnivalTaskByTaskType.LogPair.Clear();
			ConfigNewbieCarnivalTaskByTaskType.LogPair.Add(new ValueTuple<string, object>("TaskType", p0TaskType));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalTaskByTaskType.HandleId, 1, p0TaskType, ConfigNewbieCarnivalTaskByTaskType.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
				return null;
			}
			List<NewbieCarnivalTask> list = new List<NewbieCarnivalTask>();
			while (ConfigCommon.Step(ConfigNewbieCarnivalTaskByTaskType.HandleId, false, ConfigNewbieCarnivalTaskByTaskType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalTaskByTaskType.HandleId, 0, ConfigNewbieCarnivalTaskByTaskType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
					return null;
				}
				NewbieCarnivalTask rootAsNewbieCarnivalTask = NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(new ByteBuffer(item2));
				list.Add(rootAsNewbieCarnivalTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
			return list;
		}

		// Token: 0x04002922 RID: 10530
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x04002923 RID: 10531
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x04002924 RID: 10532
		private const string TABLE = "NewbieCarnivalTask";

		// Token: 0x04002925 RID: 10533
		private const string COMMAND = "select BinData from `NewbieCarnivalTask` where TaskType=?";

		// Token: 0x04002926 RID: 10534
		private const string KEY_PREFIX = "NewbieCarnivalTaskByTaskType";

		// Token: 0x04002927 RID: 10535
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002928 RID: 10536
		private static int HandleId;
	}
}
