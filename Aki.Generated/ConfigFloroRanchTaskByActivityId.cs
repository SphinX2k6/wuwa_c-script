using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000329 RID: 809
	public class ConfigFloroRanchTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012FB RID: 4859 RVA: 0x000C4AD4 File Offset: 0x000C2CD4
		static ConfigFloroRanchTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000C4AF4 File Offset: 0x000C2CF4
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

		// Token: 0x060012FD RID: 4861 RVA: 0x000C4B73 File Offset: 0x000C2D73
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskByActivityId.LogPair = null;
			ConfigFloroRanchTaskByActivityId.HandleId = 0;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000C4B81 File Offset: 0x000C2D81
		public static void Init()
		{
			ConfigFloroRanchTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTask` where ActivityId=?");
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000C4B9C File Offset: 0x000C2D9C
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

		// Token: 0x04001603 RID: 5635
		private const string DB = "db_flororanch.db";

		// Token: 0x04001604 RID: 5636
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001605 RID: 5637
		private const string TABLE = "FloroRanchTask";

		// Token: 0x04001606 RID: 5638
		private const string COMMAND = "select BinData from `FloroRanchTask` where ActivityId=?";

		// Token: 0x04001607 RID: 5639
		private const string KEY_PREFIX = "FloroRanchTaskByActivityId";

		// Token: 0x04001608 RID: 5640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001609 RID: 5641
		private static int HandleId;
	}
}
