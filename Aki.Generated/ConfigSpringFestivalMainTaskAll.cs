using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4F RID: 2639
	public class ConfigSpringFestivalMainTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x001BAB6C File Offset: 0x001B8D6C
		static ConfigSpringFestivalMainTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x001BAB8C File Offset: 0x001B8D8C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalMainTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalMainTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalMainTask`")
			});
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x001BAC0B File Offset: 0x001B8E0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskAll.LogPair = null;
			ConfigSpringFestivalMainTaskAll.HandleId = 0;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x001BAC19 File Offset: 0x001B8E19
		public static void Init()
		{
			ConfigSpringFestivalMainTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask`");
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x001BAC34 File Offset: 0x001B8E34
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalMainTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalMainTaskAll.HandleId, ConfigSpringFestivalMainTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringFestivalMainTask> readOnlyList = (IReadOnlyList<SpringFestivalMainTask>)ConfigCommon.GetConfig("SpringFestivalMainTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringFestivalMainTask> list = new List<SpringFestivalMainTask>();
			while (ConfigCommon.Step(ConfigSpringFestivalMainTaskAll.HandleId, false, ConfigSpringFestivalMainTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalMainTaskAll.HandleId, 0, ConfigSpringFestivalMainTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalMainTaskAll.HandleId, ConfigSpringFestivalMainTaskAll.LogPair);
					return null;
				}
				SpringFestivalMainTask rootAsSpringFestivalMainTask = SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalMainTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringFestivalMainTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalMainTaskAll.HandleId, ConfigSpringFestivalMainTaskAll.LogPair);
			return list;
		}

		// Token: 0x0400480F RID: 18447
		private const string DB = "db_spring26.db";

		// Token: 0x04004810 RID: 18448
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004811 RID: 18449
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x04004812 RID: 18450
		private const string COMMAND = "select BinData from `SpringFestivalMainTask`";

		// Token: 0x04004813 RID: 18451
		private const string KEY_PREFIX = "SpringFestivalMainTaskAll";

		// Token: 0x04004814 RID: 18452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004815 RID: 18453
		private static int HandleId;
	}
}
