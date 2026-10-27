using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097A RID: 2426
	public class ConfigSpringFestivalMainTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038F0 RID: 14576 RVA: 0x0019B7D8 File Offset: 0x001999D8
		static ConfigSpringFestivalMainTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0019B7F8 File Offset: 0x001999F8
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

		// Token: 0x060038F2 RID: 14578 RVA: 0x0019B877 File Offset: 0x00199A77
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskAll.LogPair = null;
			ConfigSpringFestivalMainTaskAll.HandleId = 0;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0019B885 File Offset: 0x00199A85
		public static void Init()
		{
			ConfigSpringFestivalMainTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask`");
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0019B8A0 File Offset: 0x00199AA0
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

		// Token: 0x0400423C RID: 16956
		private const string DB = "db_spring26.db";

		// Token: 0x0400423D RID: 16957
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400423E RID: 16958
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x0400423F RID: 16959
		private const string COMMAND = "select BinData from `SpringFestivalMainTask`";

		// Token: 0x04004240 RID: 16960
		private const string KEY_PREFIX = "SpringFestivalMainTaskAll";

		// Token: 0x04004241 RID: 16961
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004242 RID: 16962
		private static int HandleId;
	}
}
