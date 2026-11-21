using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FE RID: 1534
	public class ConfigNewbieCourseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x00128AC0 File Offset: 0x00126CC0
		static ConfigNewbieCourseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseAll.CreateStaticDefaultValue), new Action(ConfigNewbieCourseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00128AE0 File Offset: 0x00126CE0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCourseAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCourseAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecourse.db"),
				new ValueTuple<string, object>("文件", "x.新手历程活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCourse"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCourse`")
			});
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00128B5F File Offset: 0x00126D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseAll.LogPair = null;
			ConfigNewbieCourseAll.HandleId = 0;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00128B6D File Offset: 0x00126D6D
		public static void Init()
		{
			ConfigNewbieCourseAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseAll.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourse`");
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00128B88 File Offset: 0x00126D88
		[NullableContext(2)]
		public static IReadOnlyList<NewbieCourse> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewbieCourse> readOnlyList = (IReadOnlyList<NewbieCourse>)ConfigCommon.GetConfig("NewbieCourseAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewbieCourse> list = new List<NewbieCourse>();
			while (ConfigCommon.Step(ConfigNewbieCourseAll.HandleId, false, ConfigNewbieCourseAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCourseAll.HandleId, 0, ConfigNewbieCourseAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair);
					return null;
				}
				NewbieCourse rootAsNewbieCourse = NewbieCourse.GetRootAsNewbieCourse(new ByteBuffer(item2));
				list.Add(rootAsNewbieCourse);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewbieCourseAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair);
			return list;
		}

		// Token: 0x040029D8 RID: 10712
		private const string DB = "db_newbiecourse.db";

		// Token: 0x040029D9 RID: 10713
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x040029DA RID: 10714
		private const string TABLE = "NewbieCourse";

		// Token: 0x040029DB RID: 10715
		private const string COMMAND = "select BinData from `NewbieCourse`";

		// Token: 0x040029DC RID: 10716
		private const string KEY_PREFIX = "NewbieCourseAll";

		// Token: 0x040029DD RID: 10717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029DE RID: 10718
		private static int HandleId;
	}
}
