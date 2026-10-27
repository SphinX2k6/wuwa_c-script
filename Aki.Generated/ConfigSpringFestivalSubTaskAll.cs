using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000985 RID: 2437
	public class ConfigSpringFestivalSubTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003932 RID: 14642 RVA: 0x0019CFFC File Offset: 0x0019B1FC
		static ConfigSpringFestivalSubTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0019D01C File Offset: 0x0019B21C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSubTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSubTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSubTask`")
			});
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0019D09B File Offset: 0x0019B29B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskAll.LogPair = null;
			ConfigSpringFestivalSubTaskAll.HandleId = 0;
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0019D0A9 File Offset: 0x0019B2A9
		public static void Init()
		{
			ConfigSpringFestivalSubTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask`");
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x0019D0C4 File Offset: 0x0019B2C4
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalSubTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSubTaskAll.HandleId, ConfigSpringFestivalSubTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringFestivalSubTask> readOnlyList = (IReadOnlyList<SpringFestivalSubTask>)ConfigCommon.GetConfig("SpringFestivalSubTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringFestivalSubTask> list = new List<SpringFestivalSubTask>();
			while (ConfigCommon.Step(ConfigSpringFestivalSubTaskAll.HandleId, false, ConfigSpringFestivalSubTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSubTaskAll.HandleId, 0, ConfigSpringFestivalSubTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalSubTaskAll.HandleId, ConfigSpringFestivalSubTaskAll.LogPair);
					return null;
				}
				SpringFestivalSubTask rootAsSpringFestivalSubTask = SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalSubTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringFestivalSubTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSubTaskAll.HandleId, ConfigSpringFestivalSubTaskAll.LogPair);
			return list;
		}

		// Token: 0x04004289 RID: 17033
		private const string DB = "db_spring26.db";

		// Token: 0x0400428A RID: 17034
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400428B RID: 17035
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x0400428C RID: 17036
		private const string COMMAND = "select BinData from `SpringFestivalSubTask`";

		// Token: 0x0400428D RID: 17037
		private const string KEY_PREFIX = "SpringFestivalSubTaskAll";

		// Token: 0x0400428E RID: 17038
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400428F RID: 17039
		private static int HandleId;
	}
}
