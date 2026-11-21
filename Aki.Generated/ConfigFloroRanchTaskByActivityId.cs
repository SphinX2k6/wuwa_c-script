using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033E RID: 830
	public class ConfigFloroRanchTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x000CAFE0 File Offset: 0x000C91E0
		static ConfigFloroRanchTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000CB000 File Offset: 0x000C9200
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTask"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTask` where ActivityId=?")
			});
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000CB07F File Offset: 0x000C927F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskByActivityId.LogPair = null;
			ConfigFloroRanchTaskByActivityId.HandleId = 0;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000CB08D File Offset: 0x000C928D
		public static void Init()
		{
			ConfigFloroRanchTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTask` where ActivityId=?");
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000CB0A8 File Offset: 0x000C92A8
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTaskByActivityId.HandleId, ConfigFloroRanchTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FloroRanchTask> readOnlyList = (IReadOnlyList<FloroRanchTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchTaskByActivityId.LogPair.Clear();
			ConfigFloroRanchTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTaskByActivityId.HandleId, 1, p0ActivityId, ConfigFloroRanchTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchTaskByActivityId.HandleId, ConfigFloroRanchTaskByActivityId.LogPair);
				return null;
			}
			List<FloroRanchTask> list = new List<FloroRanchTask>();
			while (ConfigCommon.Step(ConfigFloroRanchTaskByActivityId.HandleId, false, ConfigFloroRanchTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTaskByActivityId.HandleId, 0, ConfigFloroRanchTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTaskByActivityId.HandleId, ConfigFloroRanchTaskByActivityId.LogPair);
					return null;
				}
				FloroRanchTask rootAsFloroRanchTask = FloroRanchTask.GetRootAsFloroRanchTask(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTaskByActivityId.HandleId, ConfigFloroRanchTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001696 RID: 5782
		private const string DB = "db_flororanch.db";

		// Token: 0x04001697 RID: 5783
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001698 RID: 5784
		private const string TABLE = "FloroRanchTask";

		// Token: 0x04001699 RID: 5785
		private const string COMMAND = "select BinData from `FloroRanchTask` where ActivityId=?";

		// Token: 0x0400169A RID: 5786
		private const string KEY_PREFIX = "FloroRanchTaskByActivityId";

		// Token: 0x0400169B RID: 5787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400169C RID: 5788
		private static int HandleId;
	}
}
