using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5A RID: 2650
	public class ConfigSpringFestivalSubTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x001BC390 File Offset: 0x001BA590
		static ConfigSpringFestivalSubTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001BC3B0 File Offset: 0x001BA5B0
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

		// Token: 0x06003E32 RID: 15922 RVA: 0x001BC42F File Offset: 0x001BA62F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskAll.LogPair = null;
			ConfigSpringFestivalSubTaskAll.HandleId = 0;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x001BC43D File Offset: 0x001BA63D
		public static void Init()
		{
			ConfigSpringFestivalSubTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskAll.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask`");
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x001BC458 File Offset: 0x001BA658
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

		// Token: 0x0400485C RID: 18524
		private const string DB = "db_spring26.db";

		// Token: 0x0400485D RID: 18525
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400485E RID: 18526
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x0400485F RID: 18527
		private const string COMMAND = "select BinData from `SpringFestivalSubTask`";

		// Token: 0x04004860 RID: 18528
		private const string KEY_PREFIX = "SpringFestivalSubTaskAll";

		// Token: 0x04004861 RID: 18529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004862 RID: 18530
		private static int HandleId;
	}
}
